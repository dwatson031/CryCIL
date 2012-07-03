﻿using CryEngine;
using CryEngine.Native;
using Moq;
using NUnit.Framework;

namespace CryBrary.Tests.Console
{
    [TestFixture]
    public class CVarTests : CryBraryTests
    {
        [Test]
        public void CreateCvar_Integer_RegisteredSuccessfully()
        {
            // Arrange
            var cvarMock = GetMock<INativeCVarMethods>();

            int value = 5;

            // Act
            CVar.Register("my_cvar", value);

            // Assert
            cvarMock.Verify(m => m.RegisterCVarInt("my_cvar", ref value, It.IsAny<int>(), It.IsAny<CVarFlags>(), It.IsAny<string>()));
        }

        [Test]
        public void CreateCvar_Float_RegisteredSuccessfully()
        {
            // Arrange
            var cvarMock = GetMock<INativeCVarMethods>();

            float value = 1337.0f;

            // Act
            CVar.Register("my_cvar", value);

            // Assert
            cvarMock.Verify(m => m.RegisterCVarFloat("my_cvar", ref value, It.IsAny<float>(), It.IsAny<CVarFlags>(), It.IsAny<string>()));
        }
    }
}