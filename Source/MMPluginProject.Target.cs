//Copyright 2020-2023 Kenneth Claassen. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class MMPluginProjectTarget : TargetRules
{
	public MMPluginProjectTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "MMPluginProject" } );
		
		bUseUnityBuild = false;
		DefaultBuildSettings = BuildSettingsVersion.V2;
	}
}
