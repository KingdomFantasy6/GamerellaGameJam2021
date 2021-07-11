using UnrealBuildTool;

public class GameJamProjectTarget : TargetRules
{
	public GameJamProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("GameJamProject");
	}
}
