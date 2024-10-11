using UnrealBuildTool;

public class VRDemo2ClientTarget : TargetRules
{
	public VRDemo2ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("VRDemo2");
	}
}
