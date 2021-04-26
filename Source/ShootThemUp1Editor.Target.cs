// Shoot Them UP Game, All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ShootThemUp1EditorTarget : TargetRules
{
	public ShootThemUp1EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ShootThemUp1" } );
	}
}
