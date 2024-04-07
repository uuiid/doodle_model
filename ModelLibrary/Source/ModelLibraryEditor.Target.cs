// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ModelLibraryEditorTarget : TargetRules
{
	public ModelLibraryEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "ModelLibrary" } );
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_2;
    }
}
