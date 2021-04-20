// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class MMPluginProjectEditorTarget : TargetRules
{
	public MMPluginProjectEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "MMPluginProject" } );
		
		bUseUnityBuild = false;
		DefaultBuildSettings = BuildSettingsVersion.V2;
	}
}
