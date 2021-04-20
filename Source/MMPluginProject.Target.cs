// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

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
