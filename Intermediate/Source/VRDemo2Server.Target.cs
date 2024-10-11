using UnrealBuildTool;

public class VRDemo2ServerTarget : TargetRules
{
	public VRDemo2ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("VRDemo2");
	}
}
