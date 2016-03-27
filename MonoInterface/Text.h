#pragma once

// Stop compiler from complaining about strncpy.
#pragma warning(disable:4996)

#ifdef USE_CRYCIL_API

#include "IMonoInterface.h"

#endif // USE_CRYCIL_API

#ifdef CRYCIL_MODULE

#include <mono/metadata/object.h>
#include <mono/metadata/appdomain.h>

#endif // CRYCIL_MODULE

#ifdef CRYCIL_MODULE
#include <ISystem.h>

#define FatalError(message) CryFatalError(message)
#define ReportMessage CryLogAlways

#else
#include <iostream>
#include <string>
#include <sstream>
#include <vector>
#include <stdexcept>
#include <algorithm>
#define FatalError(message) throw std::logic_error(message)
#define ReportMessage(text,...) printf(text##"\n", __VA_ARGS__)

#endif // CRYCIL_MODULE

#include "List.h"

#if 0
#define TextBuilderMessage ReportMessage
#else
#define TextBuilderMessage(...) void(0)
#endif

//! Base class for Text and TextBuilder.
class TextBase
{
protected:
	char *text;			//!< Pointer to the text within the memory. It is not null-terminated.
	int length;			//!< Number of characters within the text.
public:
	//! Creates a default text.
	//!
	//! Only default text can be assigned to.
	TextBase()
	{
		this->text = nullptr;
		this->length = 0;
	}
	//! Assigns contents of the temporary object to the new one.
	TextBase(TextBase &&other)
		: text(other.text)
		, length(other.length)
	{
		other.text = nullptr;
		other.length = 0;
	}
	//! Creates a new immutable string from given null-terminated one.
	//!
	//! Text from given string is copied into new object without a terminating null character.
	//!
	//! @param t Text to initialize this object with.
	TextBase(const char *t)
	{
		this->text = nullptr;
		this->length = 0;
		if (!t)
		{
			return;
		}
		this->FromNtString(t);
	}
	//! Creates a new immutable string from given char array.
	//!
	//! @param t         Text to initialize this object with.
	//! @param index     Zero-based index of the first symbol to copy.
	//! @param charCount Number of characters to copy.
	TextBase(char *t, int index, int charCount)
	{
		this->text = nullptr;
		this->length = 0;
		if (!t)
		{
			return;
		}
		this->length = charCount;
		this->text = new char[this->length];
		for (int i = 0; i < this->length; i++)
		{
			this->text[i] = t[i + index];
		}
	}
#ifdef CRYCIL_MODULE
	//! Creates a new immutable string from given .Net/Mono string.
	//!
	//! @param managedString Instance of type System.String.
	TextBase(MonoString *managedString)
	{
		MonoError error;
		char *ntText = mono_string_to_utf8_checked(managedString, &error);
		if (mono_error_ok(&error))
		{
			this->FromNtString(ntText);
			mono_free(ntText);
		}
		else
		{
			FatalError(mono_error_get_message(&error));
		}
	}
#endif // CRYCIL_MODULE

#ifdef USE_CRYCIL_API

	//! Creates a new null-terminated string from given .Net/Mono string.
	//!
	//! @param managedString Instance of type System.String.
	TextBase(mono::string managedString)
	{
		this->FromNtString(ToNativeString(managedString));
	}

#endif // USE_CRYCIL_API
	virtual ~TextBase()
	{
		if (this->text && this->length)
		{
			delete this->text;
			this->text = nullptr;
			this->length = 0;
		}
	}
	//! Creates a null-terminated string from this object.
	//!
	//! Created string is allocated within the heap and needs to be deleted after use.
	const char *ToNTString() const
	{
		return this->ToNTString(0, this->length);
	}
	//! Creates a null-terminated string from substring of this text.
	//!
	//! Created string is allocated within the heap and needs to be deleted after use.
	//!
	//! @param index Zero-based index of the first symbol of the substring to copy to
	//!              null-terminated result.
	//! @param count Number of characters to copy. Length of the resultant string will
	//!              be count + 1 to accommodate the null character.
	const char *ToNTString(int index, int count) const
	{
		if (!this->text)
		{
			return nullptr;
		}
		if (index + count > this->length)
		{
			FatalError("Attempt to copy too many characters from the string.");
		}

		TextBuilderMessage("Building the null-terminated version of the text from index %d %d characters long.", index, count);

		char *ntText = new char[count + 1];

		TextBuilderMessage("Allocated memory.");

		int i, j, counter;
		for(i = index, j = 0, counter = 0;
			counter < count;					// Counter tells us where to stop.
			i++, j++, counter++)
		{
			//TextBuilderMessage("Copying a %c from index %d to index %d with counter on %d.",
			//				   this->text[i], i, j, counter);
			ntText[j] = this->text[i];
		}

		ntText[j] = '\0';

		TextBuilderMessage("Last character is now null.");

		TextBuilderMessage("Built the null-terminated version of the text: %s", ntText);

		return const_cast<const char *>(ntText);
	}
	//! Copies characters from beginning of this text to the given character array.
	//!
	//! @param destination Pointer to the beginning of the destination array.
	//! @param index       Zero-based index of the first symbol within destination array
	//!                    to copy text to.
	//! @param symbolCount Number of characters to copy.
	void CopyTo(char *destination, int index, int symbolCount) const
	{
		this->CopyTo(destination, 0, index, symbolCount);
	}
	//! Copies characters from substring of this text to the given character array.
	//!
	//! @param destination      Pointer to the beginning of the destination array.
	//! @param sourceIndex      Zero-based index of the first symbol of this text to copy.
	//! @param destinationIndex Zero-based index of the first symbol within destination array
	//!                         to copy text to.
	//! @param charCount        Number of characters to copy.
	void CopyTo(char *destination, int sourceIndex, int destinationIndex, int charCount) const
	{
		if (sourceIndex + charCount > this->length)
		{
			FatalError("Attempt to copy too many characters from the string.");
		}
		for
			(
			int i = sourceIndex, j = destinationIndex, counter = 0;
		counter < charCount;						// Counter tells us where to stop.
		i++, j++, counter++							//
			)
		{
			destination[j] = this->text[i];
		}
	}
#ifdef CRYCIL_MODULE
	//! Creates a managed string from this one.
	MonoString *ToManagedString() const
	{
		return mono_string_new_len(mono_domain_get(), this->text, this->length);
	}
#endif // CRYCIL_MODULE
	//! Splits this string into parts separated by the given symbol.
	//!
	//! @param symbol           Symbol that will separate the parts.
	//! @param removeEmptyParts Indicates whether empty parts should be present in the result.
	//!
	//! @return A list of parts. Must be deleted after use. Before that though, each part
	//!         must be deleted separately.
	List<const char *> *Split(char symbol, bool removeEmptyParts) const
	{
		List<const char *> *parts = new List<const char *>(6);

		int partStartIndex = 0;
		for (int i = 0; i <= this->length; i++)
		{
			if (this->text[i] == symbol || i == this->length)
			{
				if (i != partStartIndex || !removeEmptyParts)
				{
					parts->Add(this->ToNTString(partStartIndex, i - partStartIndex));
				}
				partStartIndex = i + 1;
			}
		}

		return parts;
	}
	//! Finds first occurrence of the given symbol.
	//!
	//! @param symbol Character to find.
	//!
	//! @return Zero-based index of the first occurrence of the given symbol.
	//!         -1 is returned if symbol was not found.
	int IndexOf(char symbol) const
	{
		for (int i = 0; i < this->length; i++)
		{
			if (this->text[i] == symbol)
			{
				return i;
			}
		}
		return -1;
	}
	//! Finds last occurrence of the given symbol.
	//!
	//! @param symbol Character to find.
	//!
	//! @return Zero-based index of the last occurrence of the given symbol.
	//!         -1 is returned if symbol was not found.
	int LastIndexOf(char symbol) const
	{
		for (int i = this->length - 1; i >= 0; i--)
		{
			if (this->text[i] == symbol)
			{
				return i;
			}
		}
		return -1;
	}
	//! Determines whether this text is equal to one in the null-terminated string.
	bool Equals(const char *ntString) const
	{
		return strlen(ntString) == this->length && strncmp(this->text, ntString, this->length) == 0;
	}
	int CompareTo(TextBase *other)
	{
		int minLength = this->length > other->length ? other->length : this->length;
		int comparison = strncmp(this->text, other->text, minLength);
		if (comparison == 0 && this->length != other->length)
		{
			return this->length > other->length ? 1 : -1;
		}
		return comparison;
	}
	//! Gets the length of the string.
	__declspec(property(get=GetLength)) int Length;
	//! Gets the length of the string.
	int GetLength() const
	{
		return this->length;
	}
	//! Gets the pointer to the buffer that contains the symbols of this text.
	//! It is not very safe to use.
	__declspec(property(get=GetTextBuffer)) const char *TextBuffer;
	//! Gets the pointer to the buffer that contains the symbols of this text.
	//! It is not very safe to use.
	const char *GetTextBuffer() const
	{
		return this->text;
	}
private:
	void FromNtString(const char *ntString)
	{
		this->length = strlen(ntString);
		this->text = new char[this->length];
		for (int i = 0; i < this->length; i++)
		{
			this->text[i] = ntString[i];
		}
	}
};

//! Represents immutable string.
//!
//! Since this is an immutable object, it's important to keep a reference to
//! every object of this type that exists. Not abiding this rule will create
//! unremovable memory leaks.
class Text : public TextBase
{
public:
	//! Creates an default text.
	//!
	//! Only default text can be assigned to.
	Text() : TextBase() {}
	//! Assigns contents of the temporary object to the new one.
	Text(Text &&other) : TextBase(std::move(other)) {}
	//! Creates a new immutable string from given null-terminated one.
	//!
	//! Text from given string is copied into new object without a terminating null character.
	//!
	//! @param t Text to initialize this object with.
	explicit Text(const char *t) : TextBase(t) {}
	//! Creates a new immutable string from given char array.
	//!
	//! @param t         Text to initialize this object with.
	//! @param index     Zero-based index of the first symbol to copy.
	//! @param charCount Number of characters to copy.
	Text(char *t, int index, int charCount) : TextBase(t, index, charCount) {}
#ifdef CRYCIL_MODULE
	//! Creates a new immutable string from given .Net/Mono string.
	//!
	//! @param managedString Instance of type System.String.
	explicit Text(MonoString *managedString) : TextBase(managedString) {}
#endif // CRYCIL_MODULE

#ifdef USE_CRYCIL_API

	//! Creates a new null-terminated string from given .Net/Mono string.
	//!
	//! @param managedString Instance of type System.String.
	explicit Text(mono::string managedString) : TextBase(managedString) {}

#endif // USE_CRYCIL_API
	//! Constructs a text out of given parts.
	//!
	//! @param parts An initializer list that contains the parts to build this object out of.
	explicit Text(std::initializer_list<const char *> parts)
	{
		int totalLength = 0;
		for (auto current = parts.begin(); current < parts.end(); current++)
		{
			totalLength += strlen(*current);
		}

		this->text = new char[totalLength];

		for (auto current = parts.begin(); current < parts.end(); current++)
		{
			int j = 0;
			while (char c = (*current)[j++])
			{
				this->text[this->length++] = c;
			}
		}
	}
	//! Creates a substring of this text.
	//!
	//! @param index Zero-based index of the first symbol of the substring to copy to the result.
	//! @param count Number of characters to copy.
	Text *Substring(int index, int count) const
	{
		if (!this->text)
		{
			return nullptr;
		}
		if (index + count > this->length)
		{
			FatalError("Attempt to copy too many characters from the string.");
		}
		Text *result = new Text();
		result->length = count;
		result->text = new char[result->length];
		for (int i = 0; i < result->length; i++)
		{
			result->text[i] = this->text[i + index];
		}
		return result;
	}
	//! Assigns a null-terminated string to this object.
	//!
	//! Fatal error is thrown when this object is initialized already.
	void operator=(const char *&t)
	{
		if (this->text)
		{
			FatalError("Attempt to modify immutable string.");
		}
		this->length = strlen(t);
		this->text = new char[this->length];
		for (int i = 0; i < this->length; i++)
		{
			this->text[i] = t[i];
		}
	}
	//! Assigns an immutable string to this object.
	//!
	//! Fatal error is thrown when this object is initialized already.
	void operator=(Text &t)
	{
		if (this->text)
		{
			FatalError("Attempt to modify immutable string.");
		}
		this->length = t.length;
		this->text = new char[this->length];
		for (int i = 0; i < this->length; i++)
		{
			this->text[i] = t.text[i];
		}
	}
	//! Creates an immutable string that represents a combination of 2 other strings.
	//!
	//! Fatal error is thrown when there is an attempt to chain the operators.
	//!
	//! @param text Immutable string that will represent ending of the resultant string.
	//!
	//! @return New immutable string that needs to be assigned before used in another operator.
	Text *operator +(Text text) const
	{
		int combinedLength = this->length + text.length;
		if (combinedLength == 0)
		{
			return nullptr;
		}
		Text *result = new Text();
		result->length = combinedLength;
		result->text = new char[result->length];
		int i = 0;											// Index within result.
		int j;												// Index within left then right.
		for (j = 0; j < this->length; j++, i++)				// Copy left.
		{
			result->text[i] = this->text[j];
		}
		for (j = 0; j < text.length; j++, i++)				// Copy right.
		{
			result->text[i] = text.text[j];
		}
		return result;
	}
	//! Creates an immutable string that represents a combination of 2 other strings.
	//!
	//! Fatal error is thrown when there is an attempt to chain the operators.
	//!
	//! @param str Null-terminated string that will represent ending of the resultant string.
	//!
	//! @return New immutable string that needs to be assigned before used in another operator.
	Text *operator +(const char *str) const
	{
		int rightLength = str ? strlen(str) : 0;
		int combinedLength = this->length + rightLength;
		if (combinedLength == 0)
		{
			return nullptr;
		}
		Text *result = new Text();
		result->length = combinedLength;
		result->text = new char[result->length];
		int i = 0;											// Index within result.
		int j;												// Index within left then right.
		for (j = 0; j < this->length; j++, i++)				// Copy left.
		{
			result->text[i] = this->text[j];
		}
		for (j = 0; j < rightLength; j++, i++)				// Copy right.
		{
			result->text[i] = str[j];
		}
		return result;
	}
	//! Creates a new immutable string that represents this one with a symbol added to it.
	//!
	//! @param symbol Symbol to add to the end of the resultant string.
	//!
	//! @return A brand new immutable string.
	Text *operator +(char symbol) const
	{
		int combinedLength = this->length + 1;
		Text *result = new Text();
		result->length = combinedLength;
		result->text = new char[result->length];
		for (int i = 0; i < this->length; i++)				// Copy this text to result.
		{
			result->text[i] = this->text[i];
		}
		result->text[result->length - 1] = symbol;			// Put the symbol at the end.
		return result;
	}
};

//! Represents a string that can be changed.
class TextBuilder : public TextBase
{
	int capacity;		//!< Size of the buffer.
public:
	//! Gets the capacity of the string.
	__declspec(property(get = GetCapacity)) int Capacity;
	//! Gets the capacity of the string.
	int GetCapacity() const
	{
		return this->capacity;
	}
	//! Creates default constructive text.
	TextBuilder() : TextBase()
	{
		this->capacity = 0;
	}
	//! Assigns contents of the temporary object to the new one.
	TextBuilder(TextBuilder &&other)
		: TextBase(std::move(other))
		, capacity(other.capacity)
	{
		other.capacity = 0;
	}
	//! Creates a constructive text with desired capacity.
	//!
	//! @param capacity Amount of space to allocate for symbols before any of them are added.
	explicit TextBuilder(int capacity)
	{
		this->capacity = capacity;
		this->length = 0;
		this->text = new char[this->capacity];
	}
	//! Creates a new mutable string from given null-terminated one.
	//!
	//! Text from given string is copied into new object without a terminating null character.
	//!
	//! @param text Text to initialize this object with.
	explicit TextBuilder(const char *text)
	{
		this->Init(text, 0, strlen(text));
	}
	//! Creates a new mutable string from a portion of given character array.
	//!
	//! @param text  Pointer to the beginning of the array.
	//! @param index Zero-based index of the first character within the array to copy.
	//! @param count Number of characters to copy.
	TextBuilder(const char *text, int index, int count)
	{
		this->Init(text, index, count);
	}
	//! Creates a new mutable string from a given immutable string.
	//!
	//! @param immutableString Immutable string which is used for initialization.
	explicit TextBuilder(Text *immutableString)
	{
		this->Init(immutableString, 0, immutableString->Length);
	}
	//! Creates a new mutable string from a substring of given immutable string.
	//!
	//! @param immutableString  Immutable string which portion is used for initialization.
	//! @param index            Zero-based index of the first character of the substring to copy.
	//! @param count            Number of characters to copy.
	TextBuilder(Text *immutableString, int index, int count)
	{
		this->Init(immutableString, index, count);
	}
	//! Constructs a text out of given parts.
	//!
	//! @param capacity Initial capacity. This value will only be selected as a capacity if
	//!                 combined length of all parts is less.
	//! @param parts    An initializer list that contains the parts to build this text out of.
	TextBuilder(int capacity, std::initializer_list<const char *> parts)
	{
		int totalLength = 0;
		for (auto current = parts.begin(); current < parts.end(); current++)
		{
			totalLength += strlen(*current);
		}

		this->capacity = std::max(capacity, totalLength);
		this->text = new char[this->capacity];

		for (auto current = parts.begin(); current < parts.end(); current++)
		{
			int j = 0;
			while (char c = (*current)[j++])
			{
				this->text[this->length++] = c;
			}
		}
	}
	~TextBuilder()
	{
		if (this->text)
		{
			delete this->text;
			this->text = nullptr;
			this->length = 0;
			this->capacity = 0;
		}
	}
	//! Creates immutable string out of this one.
	//!
	//! Returned pointer points at the object in the heap.
	//!
	//! @return Pointer to the immutable string, null if this object is not initialized.
	Text *ToText() const
	{
		return this->ToText(0, this->length);
	}
	//! Creates immutable string out of substring of this one.
	//!
	//! Returned pointer points at the object in the heap.
	//!
	//! @param index Zero-based index of the first symbol of the substring to copy.
	//! @param count Number of characters to copy.
	//!
	//! @return Pointer to the immutable string, null if this object is not initialized.
	Text *ToText(int index, int count) const
	{
		if (!this->text)
		{
			return nullptr;
		}
		if (index + count > this->length)
		{
			FatalError("Attempt to copy too many characters from the string.");
		}
		return new Text(this->text, index, count);
	}
	//! Creates a substring of this text.
	//!
	//! @param index Zero-based index of the first symbol of the substring to copy to the result.
	//! @param count Number of characters to copy.
	TextBuilder *Substring(int index, int count) const
	{
		if (!this->text)
		{
			return nullptr;
		}
		if (index + count > this->length)
		{
			FatalError("Attempt to copy too many characters from the string.");
		}
		TextBuilder *result = new TextBuilder();
		result->length = count;
		result->text = new char[result->length];
		for (int i = 0; i < result->length; i++)
		{
			result->text[i] = this->text[i + index];
		}
		return result;
	}
	//! Appends a symbol to the end of this text.
	TextBuilder &operator <<(char character)
	{
		TextBuilderMessage("Adding a %c character to the text.", character);
		this->Resize(this->length + 1);
		this->text[this->length++] = character;
		return *this;
	}
	//! Appends a null-terminated string to the end of this text.
	//!
	//! Avoid invocation of this operator unless given string is a literal.
	TextBuilder &operator <<(const char *str)
	{
		this->Append(const_cast<char *>(str), strlen(str));
		return *this;
	}
	//! Appends an immutable string to the end of this text.
	TextBuilder &operator <<(Text &text)
	{
		this->Append(const_cast<char *>(text.TextBuffer), text.Length);
		return *this;
	}
	//! Appends a string to the end of this text.
	TextBuilder &operator <<(TextBuilder &text)
	{
		this->Append(text.text, text.length);
		return *this;
	}

private:
	void Append(char *bufferToCopy, int count)
	{
		TextBuilderMessage("Adding %d character text to the builder that is %d characters long.",
						   count, this->length);

		int combinedLength = this->length + count;
		this->Resize(combinedLength);
		// Copy data.
		for (int i = 0, j = this->length; j < combinedLength; i++, j++)
		{
			this->text[j] = bufferToCopy[i];
		}
		this->length = combinedLength;
	}
	void Init(const char *text, int index, int count)
	{
		this->capacity = this->length = count;
		this->text = new char[this->capacity];
		strncpy(this->text, text + index, this->capacity);
	}
	void Init(Text *immutableString, int index, int count)
	{
		if (index + count > immutableString->Length)
		{
			FatalError("Attempt to copy too many characters from the string.");
		}
		this->capacity = this->length = count;
		this->text = new char[this->capacity];
		immutableString->CopyTo(this->text, index, 0, this->length);
	}
	void Resize(int combinedLength)
	{
		// Check the capacity.
		if (this->capacity < combinedLength)
		{
			// Allocate new memory.
			char *newText = new char[combinedLength];
			for (int i = 0; i < this->length; i++)
			{
				newText[i] = this->text[i];
			}

			// Deallocate old memory.
			delete this->text;

			this->text = newText;
			this->capacity = combinedLength;
		}
	}
};

inline std::ostream &operator <<(std::ostream &out, Text &text)
{
	const char *nt = text.ToNTString();
	out << nt;
	delete nt;
	return out;
}

inline std::ostream &operator <<(std::ostream &out, Text *text)
{
	const char *nt = text->ToNTString();
	out << nt;
	delete nt;
	return out;
}