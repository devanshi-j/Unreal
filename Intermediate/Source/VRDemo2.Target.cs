using UnrealBuildTool;

public class VRDemo2Target : TargetRules
{
	public VRDemo2Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("VRDemo2");
	}
}
