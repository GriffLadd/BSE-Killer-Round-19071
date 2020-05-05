using UnrealBuildTool;

public class MoveSkatePhysTarget : TargetRules
{
	public MoveSkatePhysTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("MoveSkatePhys");
	}
}
