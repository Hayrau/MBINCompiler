﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS( GUID = 0xAD35D04007689211)]
    public class GcPlayerGlobals : NMSTemplate
    {
        /* 0x0 */ public bool InteractNearbyRadiusEnabled;
        /* 0x1 */ public bool DebugExperience;
        [NMS(Size = 0x80)]
		/* 0x2 */ public string DefaultShipFilename;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x82 */ public byte[] Padding82;
        /* 0x88 */ public GcSeed DefaultShipSeed;
		/* 0x98 */ public bool DebugExperienceRender;
		/* 0x99 */ public bool DebugDroneScanPlayer;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x9A */ public byte[] Padding9A;
		/* 0xA0 */ public Vector4f DebugDroneSpawn;
		/* 0xB0 */ public Vector4f DebugDroneTarget;
		/* 0xC0 */ public int DebugNumDrones;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0xC4 */ public byte[] PaddingC4;
		/* 0xD0 */ public Vector4f DebugWalkerSpawn;
		/* 0xE0 */ public Vector4f DebugWalkerTarget;
		/* 0xF0 */ public Vector4f DebugFlybyTarget;
		/* 0x100 */ public Vector4f DebugFlybyDir;
		/* 0x110 */ public float DebugFlybyRange;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x114 */ public byte[] Padding114;
        /* 0x118 */ public GcSeed DebugFlybySeed;
        [NMS(Size = 0x10)]
        /* 0x128 */ public string DebugExperienceCamShake;
		/* 0x138 */ public float JetpackUnderwaterDrainRate;
		/* 0x13C */ public float JetpackUnderwaterFillRate;
		/* 0x140 */ public float UnderwaterMargin;
		/* 0x144 */ public float UnderwaterMinDepth;
		/* 0x148 */ public float UnderwaterSurfaceTension;
		/* 0x14C */ public float UnderwaterSurfaceTensionOffset;
		/* 0x150 */ public float UnderwaterSurfaceForceFlattenAngleMin;
		/* 0x154 */ public float UnderwaterSurfaceForceFlattenAngleRange;
		/* 0x158 */ public float UnderwaterImpact;
		/* 0x15C */ public float UnderwaterMaxSpeed;
		/* 0x160 */ public float UnderwaterForce;
		/* 0x164 */ public float UnderwaterMaxJetpackSpeed;
		/* 0x168 */ public float UnderwaterJetpackForce;
		/* 0x16C */ public float UnderwaterMaxJetpackEscapeSpeed;
		/* 0x170 */ public float UnderwaterJetpackEscapeForce;
		/* 0x174 */ public float UnderwaterBrake;
		/* 0x178 */ public float UnderwaterFloat;
		/* 0x17C */ public float UnderwaterFloatForce;
		/* 0x180 */ public float UnderwaterFloatRange;
		/* 0x184 */ public float UnderwaterFloatFreq;
		/* 0x188 */ public float RespawnOnPadRadius;
		/* 0x18C */ public float DeepWaterDepth;
		/* 0x190 */ public float CockpitEjectTestRadius;
		/* 0x194 */ public float CockpitEjectTestStartHeightOffset;
		/* 0x198 */ public float CockpitEjectTestEndHeightOffset;
		/* 0x19C */ public float CockpitEjectFirstPersonOffsetTime;
		/* 0x1A0 */ public float CockpitEjectFirstPersonOffset;
		/* 0x1A4 */ public float BinocularRangePlanet;
		/* 0x1A8 */ public float BinocularRangeSpace;
		/* 0x1AC */ public float MinBinocActiveTime;
		/* 0x1B0 */ public int RobotMultiplierWithFriends;
		/* 0x1B4 */ public float DroneStartLocationRadius;
		/* 0x1B8 */ public float ShipSummonLastSafeMargin;
		/* 0x1BC */ public float CreativeModeDeathFadeInTime;
		/* 0x1C0 */ public float CreativeModeDeathFadeOutTime;
		/* 0x1C4 */ public int NumberOfWarpsRequiredForFreightersToSpawn;
		/* 0x1C8 */ public float SpawningDistanceBetweenPlayersAfterWarp;
		/* 0x1CC */ public float SpawningSpaceBattleLookOffset;
		/* 0x1D0 */ public float SpawningSpaceBattleLookOffsetUp;
		/* 0x1D4 */ public bool MultiplayerShareWanted;
		/* 0x1D5 */ public bool ReportAllProjectileDamage;
		/* 0x1D8 */ public int DefaultHitPoints;
		/* 0x1DC */ public int DefaultHealthPips;
		/* 0x1E0 */ public int DefaultShipHealthPips;
		/* 0x1E4 */ public int MaxHealthPips;
		/* 0x1E8 */ public bool UseLargeHealthBar;
		/* 0x1EC */ public float DroneSpawnAccelerator;
		/* 0x1F0 */ public float TrackArrowStaticTargetOffsetMultiplier;
		/* 0x1F4 */ public float WitnessSenseEnhancementTime;
		/* 0x1F8 */ public float WitnessSenseEnhancement;
		/* 0x1FC */ public float MultiplayerMinWanteEscalationTime;
		/* 0x200 */ public float HealthRechargeMinTimeSinceDamage;
		/* 0x204 */ public float HealthPipRechargeRate;
		/* 0x208 */ public float MinEnergyPercentOnRespawn;
		/* 0x20C */ public float VehicleRaceResultsHintTime;
		/* 0x210 */ public float OtherPlayerTrackArrowRange;
		/* 0x214 */ public float WantedLevelPlayerRange;
		/* 0x218 */ public float WantedLevelPlayerRangeSpace;
		/* 0x21C */ public float PlayerTransferRange;
		/* 0x220 */ public float PlayerSpaceTransferRange;
		/* 0x224 */ public float DroneScanTimeToForget;
		/* 0x228 */ public float GhostbusterStartLength;
		/* 0x22C */ public float GhostbusterStart1;
		/* 0x230 */ public float GhostbusterSpeed1;
		/* 0x234 */ public float GhostbusterFreq1;
		/* 0x238 */ public float GhostbusterAmp1;
		/* 0x23C */ public float GhostbusterStart2;
		/* 0x240 */ public float GhostbusterSpeed2;
		/* 0x244 */ public float GhostbusterFreq2;
		/* 0x248 */ public float GhostbusterAmp2;
		/* 0x24C */ public float GhostbusterStart3;
		/* 0x250 */ public float GhostbusterSpeed3;
		/* 0x254 */ public float GhostbusterFreq3;
		/* 0x258 */ public float GhostbusterAmp3;
		/* 0x25C */ public bool WeaponZoomEnabled;
		/* 0x260 */ public float WeaponZoomFOV;
		/* 0x264 */ public float WeaponZoomRecoilMultiplier;
		/* 0x268 */ public float WeaponZoomVertRotation;
		/* 0x26C */ public float WeaponZoomHorzRotation;
		/* 0x270 */ public bool FrontShieldEnabled;
		/* 0x274 */ public float FrontShieldOffsetOff;
		/* 0x278 */ public float FrontShieldOffsetOn;
		/* 0x27C */ public float FrontShieldSpeedSlowdown;
		/* 0x280 */ public float CombatSpawnMinWantedTime;
		/* 0x284 */ public float ExperienceHardPiratesDamagePotentialMin;
		/* 0x288 */ public float ExperienceHardPiratesDamagePotentialRange;
		/* 0x28C */ public float ExperienceHardPiratesDamageMaxOdds;
		/* 0x290 */ public float ExperienceMediumPiratesDamagePotentialMin;
		/* 0x294 */ public float ExperienceMediumPiratesDamagePotentialRange;
		/* 0x298 */ public float ExperienceMediumPiratesDamageMaxOdds;
		/* 0x29C */ public float CommunicatorSpeed;
		/* 0x2A0 */ public float GrenadeBounceDamping;
		/* 0x2A4 */ public float GrenadeBounceMaxSpeed;
		/* 0x2A8 */ public float GrenadeStopExplodeTime;
		/* 0x2AC */ public float CockpitEjectTestSphereRadius;
		/* 0x2B0 */ public float CockpitEjectTestSphereRange;
		/* 0x2B4 */ public float CockpitEjectSideTestRange;
		/* 0x2B8 */ public float WeaponShotgunSlowdown;
		/* 0x2BC */ public int MouseSmoothMode;
		/* 0x2C0 */ public Vector2f MouseSpringStrength;
		/* 0x2C8 */ public Vector2f MouseSpringStrengthMinDelta;
		/* 0x2D0 */ public Vector2f MouseSpringStrengthMaxDelta;
		/* 0x2D8 */ public float HardModeEnergyDischargeRateLow;
		/* 0x2DC */ public float HardModeEnergyDischargeRateMedium;
		/* 0x2E0 */ public float HardModeEnergyDischargeRateHigh;
		/* 0x2E4 */ public float HazardDamageMinTime;
		/* 0x2E8 */ public float EnergyDamageMinTime;
		/* 0x2EC */ public float EnergyDischargeRateLow;
		/* 0x2F0 */ public float EnergyDischargeRateMedium;
		/* 0x2F4 */ public float EnergyDischargeRateHigh;
		/* 0x2F8 */ public float EnergyDischargeRateFloatingInSpace;
		/* 0x2FC */ public float EnergyPainRate;
		/* 0x300 */ public float SolarRegenFactor;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x304 */ public byte[] Padding2AC;
        /* 0x310 */ public Colour DefaultMuzzleColour;
		/* 0x320 */ public Colour TerrainEditorMuzzleColourSubtract;
		/* 0x330 */ public Colour TerrainEditorMuzzleColourAdd;
		/* 0x340 */ public Colour TerrainEditorMuzzleColourUndo;
		/* 0x350 */ public Colour DefaultMuzzleLaserColour;
		/* 0x360 */ public float FreeJetpackRange;
		/* 0x364 */ public float FreeJetpackRangeNonTerrain;
		/* 0x368 */ public float JetpackDrainHorizontalFactor;
		/* 0x36C */ public float MinTimeAfterMeleeBeforeBoost;
		/* 0x370 */ public float MaxTimeAfterMeleeBeforeBoost;
		/* 0x374 */ public float MeleeBoostAirForce;
		/* 0x378 */ public float MeleeToAirBoostInitialImpulse;
		/* 0x37C */ public float MaxTimeInMeleeBoost;
		/* 0x380 */ public bool RocketBootsEnabled;
		/* 0x381 */ public bool RocketBootsUseCustomCamera;
		/* 0x384 */ public float RocketBootsActivationWindow;
		/* 0x388 */ public float RocketBootsDoubleTapTime;
		/* 0x38C */ public float RocketBootsImpulse;
		/* 0x390 */ public float RocketBootsBoostForce;
		/* 0x394 */ public float RocketBootsDriftForce;
		/* 0x398 */ public float RocketBootsForceStartTime;
		/* 0x39C */ public float RocketBootsForceDuration;
		/* 0x3A0 */ public float RocketBootsMinDesiredHeight;
		/* 0x3A4 */ public float RocketBootsMaxDesiredHeight;
		/* 0x3A8 */ public float RocketBootsHeightAdjustTime;
		/* 0x3AC */ public float RocketBootsHeightAdjustUpStrength;
		/* 0x3B0 */ public float RocketBootsHeightAdjustDownStrength;
		/* 0x3B4 */ public float RocketBootsJetpackMinLevel;
		/* 0x3B8 */ public float RocketBootsBoostTankDrainSpeed;
		/* 0x3BC */ public float RocketBootsDriftTankDrainSpeed;
		/* 0x3C0 */ public float RocketBootsBoostOnTime;
		/* 0x3C4 */ public float RocketBootsBoostOffTime;
		/* 0x3C8 */ public float RocketBootsZigZagStrength;
		/* 0x3CC */ public float RocketBootsZigZagForceDuration;
		/* 0x3D0 */ public float RocketBootsMaxSpeed;
		/* 0x3D4 */ public float RocketBootsDriftEndTime;
		/* 0x3D8 */ public float RocketBootsWindUpBraking;
		/* 0x3DC */ public float RocketBootsDriftBraking;
		/* 0x3E0 */ public float RocketBootsDriftDownwardForce;
		/* 0x3E4 */ public float JetpackForce;
		/* 0x3E8 */ public float JetpackBrake;
		/* 0x3EC */ public float JetpackMinLevel;
		/* 0x3F0 */ public float JetpackMaxSpeed;
		/* 0x3F4 */ public float JetpackMaxUpSpeed;
		/* 0x3F8 */ public float JetpackUpForce;
		/* 0x3FC */ public float JetpackIgnitionForce;
		/* 0x400 */ public float JetpackIgnitionTime;
		/* 0x404 */ public float JetpackMinIgnitionTime;
        [NMS(Size = 0x3)]
        /* 0x408 */ public float[] JetpackTankTimes;
        /* 0x414 */ public float JetpackFillRate;
        /* 0x418 */ public float JetpackFillRateHardMode;
        /* 0x41C */ public float JetpackFillRateSpaceStationMultiplier;
        /* 0x420 */ public float JetpackUpForceDeadPlanetExtra;
        /* 0x424 */ public float JetpackForceDeadPlanetExtra;
        /* 0x428 */ public float JetpackIgnitionForceDeadPlanetExtra;
        /* 0x42C */ public bool EnableHeadMovements;
        /* 0x42D */ public bool ClampPitch;
        /* 0x430 */ public float DamageRepairFactor;
        /* 0x434 */ public float DamageRepairFactorHardMode;
        /* 0x438 */ public float NormalModeHazardTimeMultiplier;
        /* 0x43C */ public float NormalModeHazardDamageRateMultiplier;
        /* 0x440 */ public float NormalModeHazardDamageWoundRateMultiplier;
        /* 0x444 */ public float NormalModeSubstanceRewardMultiplier;
        /* 0x448 */ public float NormalModeHazardRechargeUnderground;
        /* 0x44C */ public float HardModeHazardTimeMultiplier;
        /* 0x450 */ public float HardModeHazardDamageRateMultiplier;
        /* 0x454 */ public float HardModeHazardDamageWoundRateMultiplier;
        /* 0x458 */ public float HardModeSubstanceRewardMultiplier;
        /* 0x45C */ public float HardModeHazardRechargeUnderground;
        /* 0x460 */ public float FreighterProbeScanTime;
        /* 0x464 */ public int MaxNumDestroyEffects;
        /* 0x468 */ public int MinNumDestroyEffects;
        /* 0x46C */ public float ProjectileEndTime;
        /* 0x470 */ public float ExplosionTimePerEffect;
        /* 0x474 */ public float ExplosionTimeVariance;
        /* 0x478 */ public float ExplosionScaleVariance;
        /* 0x47C */ public float ExplosionBoundingInset;
        /* 0x480 */ public float ExplosionBoundingInsetRange;
        /* 0x484 */ public float DestroyEffectFinalDelay;
        /* 0x488 */ public float ShipPriceExp2;
        /* 0x48C */ public float WeaponPriceExp2;
        /* 0x490 */ public float FreighterPriceExp2;
        /* 0x494 */ public float ShipCoolFactor;
        /* 0x498 */ public float WeaponCoolFactor;
        /* 0x49C */ public float FreighterCoolFactor;
        /* 0x4A0 */ public bool MouseCrosshairVisible;
        /* 0x4A4 */ public float MouseMaxLength;
        /* 0x4A8 */ public float MouseDeadZone;
        /* 0x4AC */ public float MouseAimZone;
        /* 0x4B0 */ public float MouseCrosshairMaxAlpha;
        /* 0x4B4 */ public float MouseCrosshairAlphaFade;
        /* 0x4B8 */ public float MouseCrosshairAlphaFadeSpeed;
        /* 0x4BC */ public float MouseCrosshairLineAlpha;
        /* 0x4C0 */ public float MouseCrosshairLineWidth;
        /* 0x4C4 */ public float MouseCrosshairShipStrength;
        /* 0x4C8 */ public float MouseCrosshairMultiplier;
        /* 0x4CC */ public bool UseEnergy;
        /* 0x4CD */ public bool InventoryDamage;
        /* 0x4CE */ public bool NeverPreyedOn;
        /* 0x4CF */ public bool PermanantFire;
        /* 0x4D0 */ public bool PermanantAltFire;
        /* 0x4D1 */ public bool LuckyWithTech;
        /* 0x4D4 */ public int BulletCostReducer;
        /* 0x4D8 */ public int BulletClipMultiplier;
        /* 0x4DC */ public float LootForceMultiplier;
        /* 0x4E0 */ public float WoundTimeMinimum;
        /* 0x4E4 */ public float WoundDamageLimit;
        /* 0x4E8 */ public float WoundDamageLimitShip;
        /* 0x4EC */ public float WoundDamageDecayTime;
        /* 0x4F0 */ public float ResourceBlobFinalScaleDistance;
        /* 0x4F4 */ public float LaserPlayerOffset;
        /* 0x4F8 */ public float WalkerAlertRange;
        /* 0x4FC */ public float WalkerSightRange;
        /* 0x500 */ public float WalkerSightAngle;
        /* 0x504 */ public float CombatEscalateTime;
        /* 0x508 */ public float CombatEscapeRadius;
        /* 0x50C */ public float CombatEscapeTime;
        /* 0x510 */ public bool UpgradeExosuitWithProduct;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x4A1 */ public byte[] Padding4A1;
        [NMS(Size = 0x10)]
        /* 0x518 */ public string ExosuitUpgradeProduct;
        /* 0x528 */ public int SuitInventoryStartSeed;
        /* 0x52C */ public int MaxNumShipsAttackingPlayer;
        /* 0x530 */ public float ObjectScanTime;
        /* 0x534 */ public float DroneProbeScanTime;
        /* 0x538 */ public int PirateHailPercent;
        /* 0x53C */ public float PirateBountyInitTime;
        /* 0x540 */ public float PirateProbeInitTime;
        /* 0x544 */ public float PirateProbeAttackWaitTime;
        /* 0x548 */ public float PirateProbeAttackWarnTime;
        /* 0x54C */ public float PirateProbeScanTime;
        /* 0x550 */ public float PirateProbeScanTotalTime;
        /* 0x554 */ public float PirateProbeHailPause;
        /* 0x558 */ public float PirateBattleMarkerRange;
        /* 0x55C */ public float PirateBattleWarnTime;
        /* 0x560 */ public float PirateBattleMarkerTime;
        /* 0x564 */ public float PirateBattleMaxTime;
        [NMS(Size = 0x20)]
        /* 0x568 */ public string TraderHailReceiveOSDLoc;
        [NMS(Size = 0x20)]
        /* 0x588 */ public string TraderHailRefusedOSDLoc;
        /* 0x5A8 */ public float TraderHailTime;
        /* 0x5AC */ public float TraderApproachTime;
        /* 0x5B0 */ public float TraderHailDistance;
        /* 0x5B4 */ public float TraderApproachDistance;
        /* 0x5B8 */ public float TraderSpamTimeWait;
        /* 0x5BC */ public float TraderStayCloseLockOffset;
        /* 0x5C0 */ public float TraderStayCloseLockSin1Coeff;
        /* 0x5C4 */ public float TraderStayCloseLockSin1Offset;
        /* 0x5C8 */ public float TraderStayCloseLockSin2Coeff;
        /* 0x5CC */ public float TraderStayCloseLockSin2Offset;
        /* 0x5D0 */ public float TraderStayCloseLockSinsAdd;
        /* 0x5D4 */ public float TraderStayCloseLockSpread;
        /* 0x5D8 */ public float TraderStayCloseLockSpreadAdd;
        /* 0x5DC */ public float TraderStayCloseLockSpreadTime;
        /* 0x5E0 */ public float TraderHealthFightThreshold;
        /* 0x5E4 */ public int TraderCommunicationBanMinTime;
        /* 0x5E8 */ public int TraderCommunicationBanMaxTime;
        /* 0x5EC */ public float LaserMiningDamageMultiplier;
        /* 0x5F0 */ public float ShieldRechargeMinTimeSinceDamage;
        /* 0x5F4 */ public float ShieldRechargeRate;
        /* 0x5F8 */ public float MoveStickHighRangeLimit;
        /* 0x5FC */ public float WitnessAIDamageDistance;
        /* 0x600 */ public float WitnessAIDamageAngle;
        /* 0x604 */ public float DeathDamageDrainChargeFactor;
        /* 0x608 */ public int DeathDamageTechBrokenPercent;
        /* 0x60C */ public float MaxProjectileRadiusMultiplier;
        /* 0x610 */ public float HardLandPainTime;
        /* 0x614 */ public int GunBaseClipSize;
        /* 0x618 */ public int GrenadeBaseClipSize;
        /* 0x61C */ public float MeleeCooldown;
        /* 0x620 */ public float ChargeMeleeCooldown;
        /* 0x624 */ public float MeleeDistance;
        /* 0x628 */ public float MeleeDistance3P;
        /* 0x62C */ public float MeleeRadius;
        /* 0x630 */ public float MeleeHitTime;
        /* 0x634 */ public float MeleeSpeedBoost;
        /* 0x638 */ public float MeleeSpeedDamageBoost;
        /* 0x63C */ public float MeleeSpeedBoostRangeMultiplier;
        /* 0x640 */ public float MeleeStaminaDrain;
        /* 0x644 */ public float TemperatureDisplaySampleTime;
        /* 0x650 */ public Colour StarFieldColour;
        /* 0x660 */ public float StarFieldRadius;
        /* 0x664 */ public float StarFieldDensity;
        /* 0x668 */ public float StarFieldStarSize;
        /* 0x66C */ public float SpeedLinesSpeedMin;
        /* 0x670 */ public float SpeedLinesSpeedMax;
        /* 0x674 */ public float SpeedLinesLength;
        /* 0x678 */ public float SpeedLinesTotalLength;
        /* 0x67C */ public float SpeedLinesWidthMin;
        /* 0x680 */ public float SpeedLinesWidthMax;
        /* 0x684 */ public float SpeedLinesRadiusStartMin;
        /* 0x688 */ public float SpeedLinesRadiusStartMax;
        /* 0x68C */ public float SpeedLinesRadiusIncrement;
        /* 0x690 */ public float SpeedLinesStartFade;
        /* 0x694 */ public float SpeedLinesMinAlpha;
        /* 0x698 */ public float SpeedLinesMaxAlpha;
        /* 0x69C */ public float SpeedLinesOffset;
        /* 0x6A0 */ public float SleepFadeTime;
        /* 0x6A4 */ public float StaminaRate;
        /* 0x6A8 */ public float StaminaRecoveryRate;
        /* 0x6AC */ public float StaminaRecoveredFactor;
        /* 0x6B0 */ public float ScanLabelTime;
        /* 0x6B4 */ public float ScanWobbleFreq;
        /* 0x6B8 */ public float ScanWobbleAmp;
        /* 0x6BC */ public float ScanWobbleFreq2;
        /* 0x6C0 */ public float ScanWobbleAmp2;
        /* 0x6C4 */ public float ScanRotate;
        /* 0x6C8 */ public float ScanRotateDist;
        /* 0x6CC */ public float ScanRotateWobbleAmp;
        /* 0x6D0 */ public float ScanFadeInTime;
        /* 0x6D4 */ public float ScanFadeOutTime;
        /* 0x6D8 */ public float ScanBeamWidth;
        /* 0x6DC */ public float ScanRotateBeamWdith;
        /* 0x6E0 */ public float ScanBeamMainWidth;
        /* 0x6E4 */ public float WantedDroneEventRadius;
        /* 0x6E8 */ public float WantedMinSpaceTime;
        /* 0x6EC */ public float WantedMinPlanetTime;
        /* 0x6F0 */ public float WantedLevelDelay;
        /* 0x6F4 */ public float WantedWitnessTimer;
        /* 0x6F8 */ public float WantedWitnessFuzzyTime;
        /* 0x6FC */ public float WantedMinorCrimeAmount;
        /* 0x700 */ public float WantedTimeoutAggressive;
        [NMS(Size = 0x5)]
        /* 0x704 */ public float[] WantedTimeout;
        [NMS(Size = 0x5)]
        /* 0x718 */ public float[] WantedEscalateTime;
        [NMS(Size = 0x5)]
        /* 0x72C */ public float[] WantedExtremeEscalateTime;
        /* 0x740 */ public float ControlModes;
        /* 0x744 */ public float InteractionScanRange;
        /* 0x748 */ public float InteractionButtonRange;
        /* 0x74C */ public float InteractionFocusTime;
        /* 0x750 */ public float InteractionSubstanceRange;
        /* 0x754 */ public float HeatShieldTime;
        /* 0x758 */ public float LaserShakeMin;
        /* 0x75C */ public float LaserShakeMax;
        /* 0x760 */ public float GunRecoil;
        /* 0x764 */ public float LaserRecoil;
        /* 0x768 */ public float BeamRecoil;
        /* 0x76C */ public float GrenadeRecoil;
        /* 0x770 */ public float GunRecoilSpring;
        /* 0x774 */ public float BlastRecoilSpring;
        /* 0x778 */ public float RailRecoilSpring;
        /* 0x77C */ public float PulseRecoilSpring;
        /* 0x780 */ public float GunRecoilSettleSpring;
        /* 0x784 */ public float ThirdPersonRecoilMultiplier;
        /* 0x788 */ public float GunRecoilMin;
        /* 0x78C */ public float GunRecoilMax;
        /* 0x790 */ public float ProjectileDamageFalloff;
        /* 0x794 */ public float ShotgunDispersion;
        /* 0x798 */ public GcResourceCollectEffect TerrainResourceCollect;
        /* 0x7CC */ public GcResourceCollectEffect TerrainResourceMiniCollect;
        /* 0x800 */ public GcResourceCollectEffect TerrainResourceMeleeCollect;
        /* 0x834 */ public GcResourceCollectEffect CrystalResourceCollect;
        /* 0x868 */ public GcResourceCollectEffect ShardResourceCollect;
        /* 0x89C */ public GcBoidData MissileSwarm;
        /* 0x8C8 */ public GcPlayerStickData StickData;
        /* 0x8E4 */ public bool AutoAim;
        /* 0x8E8 */ public float AutoAimMaxAccelFactor;
        /* 0x8EC */ public float AutoAimFixedInterceptSpeed;
        /* 0x8F0 */ public float AutoAimTimeOut;
        /* 0x8F4 */ public float AutoAimMaxAngle;
        /* 0x8F8 */ public float AutoAimMinScreenDistance;
        /* 0x8FC */ public float AutoAimRadiusExtra;
        /* 0x900 */ public float AutoAimStickyMin;
        /* 0x904 */ public float AutoAimStickyMax;
        /* 0x908 */ public TkCurveType AutoAimDotCurve;
        /* 0x90C */ public TkCurveType AutoAimCentreOffsetCurve;
        /* 0x910 */ public float AimDistanceShip;
        /* 0x914 */ public float AimSpeed;
        /* 0x918 */ public float AimWeightAdd;
        /* 0x91C */ public float AimMinWeight;
        /* 0x920 */ public float AimDecay;
        /* 0x924 */ public float AimOffset;
        /* 0x928 */ public float AimShootableTargetAngle;
        /* 0x92C */ public float AimDisperseTime;
        /* 0x930 */ public float AimDisperseMinTime;
        /* 0x934 */ public float AimDisperseCooldownTime;
        /* 0x938 */ public float AimDisperseCooldownFactor;
        /* 0x93C */ public TkCurveType AimDisperseCurve;
        /* 0x940 */ public float CrosshairTime;
        /* 0x944 */ public float BeaconActivateRange;
        /* 0x948 */ public float ExperiencePirateFreighterAttackRange;
        /* 0x94C */ public float ExperienceWalkerSize;
        /* 0x950 */ public float ExperienceInterestingShipDistance;
        /* 0x954 */ public float ExperienceInterestingFreighterDistance;
        /* 0x958 */ public float ExperienceInterestingDroneDistance;
        /* 0x95C */ public float ExperienceShipTimeMin;
        /* 0x960 */ public float ExperienceShipTimeMax;
        /* 0x964 */ public int ExperiencePirateCloseAttackPercentage;
        /* 0x968 */ public float ExperiencePirateTimeMin;
        /* 0x96C */ public float ExperiencePirateTimeMax;
        /* 0x970 */ public float ExperienceDroneTimeMin;
        /* 0x974 */ public float ExperienceDroneTimeMax;
        /* 0x978 */ public float ExperienceFlybyScareRadius;
        /* 0x97C */ public float ExperienceFlybyScareTime;
        /* 0x980 */ public Vector2f ExperienceFlybyStartAngle;
        /* 0x988 */ public float ExperienceAlertRange;
        /* 0x98C */ public float ExperienceAlertSightRange;
        /* 0x990 */ public float ExperienceAlertSightAngle;
        /* 0x994 */ public float ExperienceDroneSpawnOffset;
        /* 0x998 */ public float ExperienceDroneSpawnAngle;
        /* 0x99C */ public float ExperienceMessageBroadcastNearbyDistance;
        /* 0x9A0 */ public float WantedEnemyAttackAmount;
        [NMS(Size = 0x80)]
        /* 0x9A4 */ public string Gun;
        /* 0xA24 */ public float StickDeadZoneMin;
        /* 0xA28 */ public float StickDeadZoneMax;
        /* 0xA2C */ public TkCurveType StickCurve;
        /* 0xA30 */ public float AutoLandRange;
        /* 0xA34 */ public float AutoLandTime;
        /* 0xA38 */ public float LabelSpringTime;
        /* 0xA3C */ public float LabelOffset;
        /* 0xA40 */ public float AtmosphereEffectTime;
        /* 0xA44 */ public float AtmosphereEffectOffset;
        [NMS(Size = 0x7)]
        /* 0xA48 */ public GcCreatureAlertData[] AlertTable;
        /* 0xAF0 */ public float PainFlickerAmount;
        /* 0xAF4 */ public float PainColourSeperateAmount;
        /* 0xAF8 */ public float PainTime;
        /* 0xAFC */ public GcProjectileLineData PlayerBullet;
        /* 0xB24 */ public GcProjectileLineData RobotBullet;
        /* 0xB4C */ public GcProjectileLineData ShipBullet;
        /* 0xB74 */ public float ExplodeShakeMaxDist;
        /* 0xB78 */ public float ExplodeShakeMaxDistSpace;
        /* 0xB7C */ public float ExplodeShakeStrength;
        /* 0xB80 */ public float FlashSize;
        /* 0xB84 */ public float FlashPosX;
        /* 0xB88 */ public float FlashPosY;
        /* 0xB8C */ public float FlashPosZ;
        /* 0xB90 */ public float FlashSpeed;
        /* 0xB94 */ public float FlashPulse;
        /* 0xB98 */ public float FlashGrow;
        /* 0xB9C */ public float GunRightOffset;
        /* 0xBA0 */ public float GunUpOffset;
        /* 0xBA4 */ public float LaserBeamMineRate;
        /* 0xBA8 */ public float LaserBeamCore;
        /* 0xBAC */ public float LaserBeamFlickerAmp;
        /* 0xBB0 */ public float LaserBeamFlickerFreq;
        /* 0xBB4 */ public float LaserEndOffset;
        /* 0xBB8 */ public float GrenadeTerrainDeformRadius;
        /* 0xBBC */ public float LaserBeamTerrainDeformRadius;
        /* 0xBC0 */ public float LaserBeamTerrainDeformVariance;
        /* 0xBC4 */ public float LaserBeamOverheatTime;
        /* 0xBC8 */ public float LaserBeamAmmoUseTime;
        /* 0xBCC */ public float ReloadButtonHoldTimeToHolster;
        /* 0xBD0 */ public float WeaponChangeModeTime;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0xBD4 */ public byte[] PaddingBD4;
        /* 0xBE0 */ public Vector4f WeaponBarrelOffset;
        /* 0xBF0 */ public float WeaponLowerDelay;
        /* 0xBF4 */ public float WeaponHolsterDelay;
        /* 0xBF8 */ public float WeaponLag;
        /* 0xBFC */ public float WeaponBobFactorWalkDeadZone;
        /* 0xC00 */ public float WeaponBobFactorWalk;
        /* 0xC04 */ public float WeaponBobFactorRun;
        /* 0xC08 */ public float WeaponBobBlendTime;
        /* 0xC0C */ public TkCurveType WeaponBobBlendCurve;
        /* 0xC10 */ public float WeaponGrenadeTime;
        /* 0xC14 */ public float WeaponGunTime;
        /* 0xC18 */ public float WeaponRailFireTime;
        /* 0xC1C */ public float WeaponRailRechargeTime;
        /* 0xC20 */ public int MaxBuildHeight;
        /* 0xC24 */ public float SpaceMaxGravityDist;
        /* 0xC28 */ public float SpaceMinGravityDist;
		/* 0xC2C */ public float BulletBend;
		/* 0xC30 */ public float ShootSizeMinZ;
		/* 0xC34 */ public float ShootSizeMaxZ;
		/* 0xC38 */ public float ShootSizeMinXY;
		/* 0xC3C */ public float ShootSizeMaxXY;
		/* 0xC40 */ public float ShootSizeTime;
		/* 0xC44 */ public float ShootSizeBase;
		/* 0xC48 */ public float ShootOffset;
		/* 0xC4C */ public float ShootPrepTime;
		/* 0xC50 */ public float GrenadeCarveRadius;
		/* 0xC54 */ public float ChargeTime;
		/* 0xC58 */ public float EnergyBallSpeed;
		/* 0xC5C */ public float ChargedEnergyBallSpeed;
		/* 0xC60 */ public float LookRayRadius;
		/* 0xC64 */ public float PickRange;
		/* 0xC68 */ public float DamageRateWhenUnderNoGravity;
		/* 0xC6C */ public float TakeDamageImpulse;
		/* 0xC70 */ public float HardLandTime;
		/* 0xC74 */ public float HardLandMin;
		/* 0xC78 */ public float HardLandMax;
		/* 0xC7C */ public float MeleeRange;
		/* 0xC80 */ public float MeleeTime;
		/* 0xC84 */ public float MeleeForcePush;
		/* 0xC88 */ public float MeleeOffset;
		/* 0xC8C */ public float PushForceAirFactor;
		/* 0xC90 */ public int HUDHeightPosX;
		/* 0xC94 */ public int HUDHeightPosY;
		/* 0xC98 */ public float TargetDistance;
		/* 0xC9C */ public float TargetRadius;
		/* 0xCA0 */ public float HoldForce;
		/* 0xCA4 */ public float HoldTime;
		/* 0xCA8 */ public float HoldActionDistX;
		/* 0xCAC */ public float HoldActionDistY;
		/* 0xCB0 */ public float HoldActionDistZ;
		/* 0xCB4 */ public float HoldDistX;
		/* 0xCB8 */ public float HoldDistY;
		/* 0xCBC */ public float HoldDistZ;
		/* 0xCC0 */ public float HoldMaxForce;
		/* 0xCC4 */ public float HoldRotate;
		/* 0xCC8 */ public float BalanceStrength;
		/* 0xCCC */ public float BalanceSpeed;
		/* 0xCD0 */ public float GroundWalkForce;
		/* 0xCD4 */ public float GroundWalkBrake;
		/* 0xCD8 */ public float GroundWalkBrakeWhileMoving;
		/* 0xCDC */ public float GroundWalkSpeed;
		/* 0xCE0 */ public float GroundRunSpeed;
		/* 0xCE4 */ public float GroundWalkRecoverySpeedDamper;
		/* 0xCE8 */ public float ExertionSmoothTime;
		/* 0xCEC */ public float ExertionFromPainTime;
		/* 0xCF0 */ public float AnimWalkSpeed;
		/* 0xCF4 */ public float AnimRunSpeed;
		/* 0xCF8 */ public float AnimWalkToRunSpeed;
		/* 0xCFC */ public float AnimWalkBlendPoint;
		/* 0xD00 */ public float AnimRunBlendPoint;
		/* 0xD04 */ public float MaxSlopeAngle;
		/* 0xD08 */ public float SlopeSlidingSpeed;
		/* 0xD0C */ public float SlopeSlideBrake;
		/* 0xD10 */ public float MinSlideTime;
		/* 0xD14 */ public float MaxWalkableSlopeAngle;
		/* 0xD18 */ public float MinSpidermanSlopeAngle;
		/* 0xD1C */ public float MinTimeToHoldSpidermanPose;
		/* 0xD20 */ public float MaxSpidermanSlopeAngle;
		/* 0xD24 */ public float MaxClingableSlopeAngle;
		/* 0xD28 */ public float MinimumPushOffForceToSlide;
		/* 0xD2C */ public float FullClipReloadSpeedMultiplier;
		/* 0xD30 */ public float ReloadTapButtonSpeedIncrease;
		/* 0xD34 */ public float ClingBrakeMultiplier;
		/* 0xD38 */ public float ClingAngleThreshold;
		/* 0xD3C */ public float ClingSpeedThreshold;
		/* 0xD40 */ public float ClimbableStickinessAngle;
		/* 0xD44 */ public float MinUpAmount;
		/* 0xD48 */ public float FootOffset;
		/* 0xD4C */ public float MaxFallSpeed;
		/* 0xD50 */ public float PushForceDecay;
		/* 0xD54 */ public float LeanFwdMaxAngle;
		/* 0xD58 */ public float LeanBackMaxAngle;
		/* 0xD5C */ public float LeanLeftMaxAngle;
		/* 0xD60 */ public float LeanRightMaxAngle;
		/* 0xD64 */ public float LeanAmount;
		/* 0xD68 */ public float LeanAmountFwd;
		/* 0xD6C */ public float HelmetLag;
		/* 0xD70 */ public float HelmetMaxLag;
		/* 0xD74 */ public float HelmetBob;
		/* 0xD78 */ public float JetpackHelmetBob;
		/* 0xD7C */ public float ShipCameraLag;
		/* 0xD80 */ public float MaxResource;
		/* 0xD84 */ public float ShieldRestoreSpeed;
		/* 0xD88 */ public float ShieldRestoreDelay;
		/* 0xD8C */ public float TimeHoldDownAccelerateToLaunchFromOutpost;
		/* 0xD90 */ public float DeathScreenFadeInThirdPerson;
		/* 0xD94 */ public float DeathScreenFadeInUnderwaterThirdPerson;
		/* 0xD98 */ public float DeathScreenFadeInTime;
		/* 0xD9C */ public float DeathScreenShipFadeInTime;
		/* 0xDA0 */ public float DeathScreenPauseTime;
		/* 0xDA4 */ public float DeathScreenMaxRegenWaitTime;
		/* 0xDA8 */ public float DeathScreenMinRegenWaitTime;
		/* 0xDAC */ public float DeathScreenFadeOutTime;
        /* 0xDB0 */ public GcPlayerStickData LookStickData;
        /* 0xDCC */ public GcPlayerStickData AmbientModeLookStickData;
		/* 0xDE8 */ public int LowHealthEffectPips;
		/* 0xDEC */ public int LowHealthEffectShield;
		/* 0xDF0 */ public float CriticalHitTime;
		/* 0xDF4 */ public float CriticalHitDesatTime;
		/* 0xDF8 */ public float CriticalHitDesatFreq;
        [NMS(Size = 0x2)]
        /* 0xDFC */ public GcCameraSpawnSetupData[] FirstSpawnDataTable;
        /* 0xE1C */ public GcInventoryValueData ShipValueData;
        /* 0xE38 */ public GcInventoryValueData WeaponValueData;
        /* 0xE54 */ public GcInventoryValueData FreighterValueData;
        [NMS(Size = 0x7)]
        /* 0xE70 */ public float[] TechRarityData;
        [NMS(Size = 0x6)]
        /* 0xE8C */ public float[] TechLearningProbabilities;
        /* 0xEA4 */ public int NumTechShopSlots;
        /* 0xEA8 */ public float GrassPushDistance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xEAC */ public byte[] PaddingD1c;
        /* 0xEB0 */ public GcCameraAnomalySetupData AnomalyBlachHoleSpawnData;
        /* 0xEF0 */ public GcCameraAnomalySetupData AnomalyAtlasStationSpawnData;
        /* 0xF30 */ public GcCameraAnomalySetupData AnomalyMiniStationSpawnData;
        /* 0xF70 */ public GcJourneyMedalTiers MedalTiers;
        /* 0xF80 */ public int LowGuildRank;
        /* 0xF84 */ public int MedGuildRank;
        /* 0xF88 */ public int HighGuildRank;
        /* 0xF8C */ public int BestGuildRank;
        /* 0xF90 */ public float LaserWeaponRange;
        /* 0xF94 */ public float LaserShipRange;
        /* 0xF98 */ public float TerrainLaserRange;
        /* 0xF9C */ public float VehicleLaserRange;
        /* 0xFA0 */ public GcPlayerCommunicatorMessage PirateHailMessage;
        /* 0xFF0 */ public GcShipDialogue TraderHailMessages;
        [NMS(Size =  0x4)]
        /* 0x1258 */ public int[] TraderHailReceiveRegular;
        [NMS(Size = 0x2)]
        /* 0x1268 */ public int[] TraderHailReceiveFight;
        [NMS(Size =  0x4)]
        /* 0x1270 */ public int[] TraderHailSend;
    }
}
