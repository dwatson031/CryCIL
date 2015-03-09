#include "stdafx.h"
#include "InitializationInterop.h"
#include "RunTime/MonoInterface.h"

const char *InitializationInterop::GetName()
{
	return "Initialization";
}

void InitializationInterop::OnRunTimeInitialized()
{
	REGISTER_METHOD(OnCompilationStartingBind);
	REGISTER_METHOD(OnCompilationCompleteBind);
	REGISTER_METHOD(GetSubscribedStagesBind);
	REGISTER_METHOD(OnInitializationStageBind);
}

void InitializationInterop::OnCompilationStartingBind()
{
	static_cast<MonoInterface *>(MonoEnv)->broadcaster->OnCompilationStarting();
}
void InitializationInterop::OnCompilationCompleteBind(bool success)
{
	static_cast<MonoInterface *>(MonoEnv)->broadcaster->OnCompilationComplete(success);
}
mono::Array InitializationInterop::GetSubscribedStagesBind()
{
	int stagesCount;
	int *indices =
		static_cast<MonoInterface *>(MonoEnv)->broadcaster->GetSubscribedStagesInfo(stagesCount);
	IMonoClass *SystemInt32 = MonoClassCache::Wrap(mono_get_int32_class());
	IMonoArray<int> result = MonoEnv->Objects->Arrays->Create(stagesCount, SystemInt32);
	for (int i = 0; i < stagesCount; i++)
	{
		result[i] = indices[i];
	}
	return result;
}
void InitializationInterop::OnInitializationStageBind(int stageIndex)
{
	static_cast<MonoInterface *>(MonoEnv)->broadcaster->OnInitializationStage(stageIndex);
}
