using UnrealBuildTool;

public class VRDemo2EditorTarget : TargetRules
{
	public VRDemo2EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("VRDemo2");
	}
}
