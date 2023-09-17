//Copyright 2020-2023 Kenneth Claassen. All Rights Reserved.

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
