// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "ModelLibraryGameModeBase.generated.h"

/**
 *
 */
UCLASS()
class MODELLIBRARY_API AModelLibraryGameModeBase : public AGameModeBase
{
  GENERATED_BODY()


  virtual void InitGame(const FString& MapName, const FString& Options, FString& ErrorMessage) override;
};
