// Shoot Them UP Game, All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ShootThemUp1Target : TargetRules
{
	public ShootThemUp1Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ShootThemUp1" } );
	}
}
