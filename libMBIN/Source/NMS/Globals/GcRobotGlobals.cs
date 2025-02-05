﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS( GUID = 0x48CC76496D394BEC)]
    public class GcRobotGlobals : NMSTemplate
    {
		/* 0x0 */ public float GrenadeLaunchFlightTime;
		/* 0x4 */ public int AttackSentinelWantedValue;
		/* 0x8 */ public int MaxNumPatrolDrones;
		/* 0xC */ public float UnderwaterPerceptionMargin;
		/* 0x10 */ public bool DronePatrolScanPlayer;
		/* 0x14 */ public float DroneSearchPickNearbyTime;
		/* 0x18 */ public float DroneSearchPickNearbyAngleMin;
		/* 0x1C */ public float DroneSearchPickNearbyAngleMax;
		/* 0x20 */ public float DroneInvestigateMinWitnessRange;
		/* 0x24 */ public float DroneInvestigateMinWitnessTime;
		/* 0x28 */ public float DroneInvestigateSpeedBoost;
		/* 0x2C */ public float DroneInvestigateSpeedBoostStartDistance;
		/* 0x30 */ public float DroneInvestigateSpeedBoostRange;
		/* 0x34 */ public float DroneCrimePostInvestigateWaitTime;
		/* 0x38 */ public float DroneAttackPlayerHeightOffset;
		/* 0x3C */ public float DroneSpawnTime;
		/* 0x40 */ public float DroneSpawnFadeTime;
		/* 0x44 */ public float LineOfSightReturnCheckMinDistance;
		/* 0x48 */ public float LineOfSightReturnCheckRadius;
		/* 0x4C */ public float LineOfSightReturnRange;
		/* 0x50 */ public float FakeQuadGuard;
		/* 0x54 */ public float RobotSightAngle;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x58 */ public byte[] Padding58;
        /* 0x60 */ public Vector4f DroneRepairOffset;
        /* 0x70 */ public float QuadLookAngleMin;
        /* 0x74 */ public float QuadLookAngleMax;
        /* 0x78 */ public Vector2f QuadLookTurnSpeeds;
        /* 0x80 */ public float QuadAttackTurnAngleMin;
        /* 0x84 */ public float QuadAttackTurnAngleMax;
        /* 0x88 */ public Vector2f QuadAttackTurnSpeeds;
        /* 0x90 */ public int DroneAggroDamage;
        /* 0x94 */ public float CombatWaveSpawnTime;
        /* 0x98 */ public float DronePerceptionMinHearingSpeed;
        /* 0x9C */ public float DroneSearchLookSpeed;
        /* 0xA0 */ public float DroneSearchLookDistance;
        /* 0xA4 */ public int DroneMiningValueActivate;
        /* 0xA8 */ public int DroneCrimeWitnessLimit;
        /* 0xAC */ public float DroneCrimeWitnessInvestigateDistance;
        /* 0xB0 */ public float DroneCrimeProximityMultiplier;
        /* 0xB4 */ public int DroneSeriousCrimeStep;
        /* 0xB8 */ public bool DroneChatter;
        /* 0xBC */ public int DroneHealth;
		/* 0xC0 */ public int CorruptedDroneHealth;
		/* 0xC4 */ public int QuadHealth;
		/* 0xC8 */ public int WalkerHealth;
		/* 0xCC */ public float WalkerEnergyLength;
		/* 0xD0 */ public float WalkerEnergySpeedMin;
		/* 0xD4 */ public float WalkerEnergySpeedMax;
		/* 0xD8 */ public float WalkerEnergyRadiusStartMin;
		/* 0xDC */ public float WalkerEnergyRadiusStartMax;
		/* 0xE0 */ public float WalkerEnergyMinAlpha;
		/* 0xE4 */ public float WalkerEnergyMaxAlpha;
		/* 0xE8 */ public float CriticalHitSizeDrone;
		/* 0xEC */ public float CriticalHitSizeQuad;
		/* 0xF0 */ public float CriticalHitSizeWalker;
		/* 0xF4 */ public float LabelOffsetDrone;
		/* 0xF8 */ public float LabelOffsetQuad;
        /* 0xFC */ public float LabelOffsetWalker;
        /* 0x100 */ public Vector4f QuadCriticalOffset;
        /* 0x110 */ public Vector4f DroneCriticalOffset;
        /* 0x120 */ public Vector4f WalkerGunOffset1;
        /* 0x130 */ public Vector4f WalkerGunOffset2;
        /* 0x140 */ public float RobotSteeringFollowWeight;
        /* 0x144 */ public float RobotSteeringAvoidTurnWeight;
        /* 0x148 */ public float RobotSteeringAvoidCreaturesWeight;
        /* 0x14C */ public float RobotSteeringAvoidDangerWeight;
        /* 0x150 */ public GcScanData AttackScan;
        /* 0x164 */ public float RobotHUDMarkerRange;
        /* 0x168 */ public float RobotHUDMarkerFalloff;
        /* 0x16C */ public float RobotHUDMarkerMinChangeTime;
        /* 0x170 */ public float DroneSquadSpawnRadius;
        /* 0x174 */ public float DroneSpawnHeight;
        /* 0x178 */ public float DroneScale;
        /* 0x17C */ public float TestLookFactor;
        /* 0x180 */ public float TurnInPlaceTorque;
        /* 0x184 */ public float TurnInPlaceHopTorque;
        /* 0x188 */ public float TurnInPlaceHopTimeMin;
        /* 0x18C */ public float TurnInPlaceHopTimeMax;
        /* 0x190 */ public float TrackArrowOffsetMultiplier;
        /* 0x194 */ public float DroneCombatSpawnAngle;
        /* 0x198 */ public float CombatSpawnSquadRadiusDrones;
        /* 0x19C */ public float CombatSpawnSquadRadiusRobots;
        /* 0x1A0 */ public float RobotMapScale;
        /* 0x1A4 */ public float WalkerTestNeckAngle;
        /* 0x1A8 */ public float SuspiciousFactorGoingToSceneDistance;
        /* 0x1AC */ public float SuspiciousFactorGoingToScene;
        /* 0x1B0 */ public float SuspiciousFactorBase;
        /* 0x1B4 */ public float WalkerLaserOvershootVehicleReducer;
        /* 0x1B8 */ public bool DronesUseEscalationTimer;
        /* 0x1B9 */ public bool DisableDronePerception;
        /* 0x1BC */ public float DroneHeightAngle;
        /* 0x1C0 */ public float DroneAttackGetInRangeBoost;
        /* 0x1C4 */ public float DroneAggressiveInvestigateAttackTime;
        /* 0x1C8 */ public float DronePushLaserForce;
        /* 0x1CC */ public float DronePushMaxSpeed;
        /* 0x1D0 */ public float DronePushMaxTurn;
        /* 0x1D4 */ public float DroneInvestigateMaxRange;
        /* 0x1D8 */ public float DroneInvestigateCooldownTime;
        /* 0x1DC */ public float DroneCriminalScanTime;
        /* 0x1E0 */ public bool DroneClickToMove;
        /* 0x1E4 */ public float DroneInvestigateMinScanTimeAttackMe;
        /* 0x1E8 */ public float DroneInvestigateMinScanTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1EC */ public byte[] Padding1EC;
        /* 0x1F0 */ public GcScanEffectData DroneScanEffect;
        /* 0x240 */ public float HeightTestSampleDistance;
        /* 0x244 */ public float HeightTestSampleTime;
        /* 0x248 */ public float CollisionDistance;
        /* 0x24C */ public float RobotSightTimer;
        /* 0x250 */ public float DroneReAttackTime;
        /* 0x254 */ public float DronePatrolAttackSightTime;
        /* 0x258 */ public float DronePatrolInvestigateSpeedBoost;
        /* 0x25C */ public float DronePatrolSearchTime;
        /* 0x260 */ public int MaxNumInvestigatingDrones;
        /* 0x264 */ public float DroneCrimeCooldown;
        /* 0x268 */ public float DroneCrimeCooldownWaitTime;
        /* 0x26C */ public float DroneCrimeCooldownWaitTimeAtMax;
        /* 0x270 */ public float DroneRadius;
        /* 0x274 */ public float DroneLightPulseFreq;
        /* 0x278 */ public float DroneLightPulseAmp;
        /* 0x27C */ public float DroneMaxScanLength;
        /* 0x280 */ public float DroneDecisionTime;
        /* 0x284 */ public float DroneInvestigateAttackDecisionTime;
        /* 0x288 */ public float DroneInvestigateMajorAttackDecisionTime;
        /* 0x28C */ public float DroneInvestigateMinPositionAngle;
        /* 0x290 */ public float DroneInvestigateMaxPositionAngle;
        /* 0x294 */ public float DroneInvestigateRepositionTime;
        /* 0x298 */ public float DroneInvestigateMinCrimeInterval;
        /* 0x29C */ public float DroneScanRadius;
        /* 0x2A0 */ public float DroneMaxScanAngle;
        /* 0x2A4 */ public float DroneScanWaitTime;
        /* 0x2A8 */ public float DroneScanMinPerpSpeed;
        /* 0x2AC */ public float EnergyExplodeTime;
        /* 0x2B0 */ public float FollowRoutineArriveRadius;
        /* 0x2B4 */ public float WalkerPauseTime;
        /* 0x2B8 */ public float WalkerAttackRange;
        /* 0x2BC */ public float WalkerGuardAlertRange;
        /* 0x2C0 */ public float WalkerClosingRange;
        /* 0x2C4 */ public float WalkerAttackRate;
        /* 0x2C8 */ public float WalkerAttackAngle;
        /* 0x2CC */ public float WalkerMoveSpeed;
        /* 0x2D0 */ public float WalkerFastMoveFactor;
        /* 0x2D4 */ public float WalkerHeight;
        /* 0x2D8 */ public float WalkerNavRadius;
        /* 0x2DC */ public float WalkerPushTime;
        /* 0x2E0 */ public float WalkerPushRadius;
        /* 0x2E4 */ public float WalkerLaserOvershootStart;
        /* 0x2E8 */ public float WalkerLaserOvershootEnd;
        /* 0x2EC */ public float WalkerLaserBodyOffset;
        /* 0x2F0 */ public float WalkerObstacleSize;
        /* 0x2F4 */ public float WalkerGunShootTime;
        /* 0x2F8 */ public float WalkerGunChargeTime;
        /* 0x2FC */ public float WalkerGunRate;
        /* 0x300 */ public float QuadAlertRange;
        /* 0x304 */ public float QuadAttackRange;
        /* 0x308 */ public float QuadAttackMinRange;
        /* 0x30C */ public float QuadAttackAngle;
        /* 0x310 */ public float QuadAttackRepositionTime;
        /* 0x314 */ public float QuadRepairOffsetChangeTime;
        /* 0x318 */ public float QuadRepairOffset;
        /* 0x31C */ public float QuadRepairScanArriveDistance;
        /* 0x320 */ public float QuadRepairRate;
        /* 0x324 */ public float QuadRepairScanRadius;
        /* 0x328 */ public float QuadRepairChargeTime;
        /* 0x32C */ public float QuadJumpBackRange;
        /* 0x330 */ public float QuadJumpBackCheckRange;
        /* 0x334 */ public float QuadJumpBackHeightRange;
        /* 0x338 */ public float QuadJumpBackJumpDistance;
        /* 0x33C */ public float QuadJumpBackJumpMinLength;
        /* 0x340 */ public float QuadJumpBackDoFlipDistance;
        /* 0x344 */ public float QuadJumpBackMinTime;
        /* 0x348 */ public float QuadJumpBackFacingAngle;
        /* 0x34C */ public float QuadJumpBackTestRadius;
        /* 0x350 */ public float QuadJumpBackTestHeightOffset;
        /* 0x354 */ public float QuadPounceRange;
        /* 0x358 */ public float QuadPounceMinRange;
        /* 0x35C */ public float QuadPounceMinTimeBetweenPounces;
        /* 0x360 */ public float QuadPounceOffset;
        /* 0x364 */ public float QuadPounceDamageRadius;
        /* 0x368 */ public float QuadCannotSeeTargetRepositionTime;
        /* 0x36C */ public float QuadChargeTime;
        /* 0x370 */ public float QuadFireTime;
        /* 0x374 */ public float QuadChargeTargetLockPercent;
        /* 0x378 */ public float QuadHopMinTime;
        /* 0x37C */ public float QuadHopCombatMinTime;
        /* 0x380 */ public int QuadDamageMoveThreshold;
        /* 0x384 */ public float QuadAttackRate;
        /* 0x388 */ public float QuadMoveSpeed;
        /* 0x38C */ public float QuadLaserSpringMin;
        /* 0x390 */ public float QuadLaserSpringMax;
        /* 0x394 */ public float QuadLaserIntensity;
        /* 0x398 */ public float QuadFastMoveFactor;
        /* 0x39C */ public float QuadTurnBlendTime;
        /* 0x3A0 */ public float QuadHeight;
        /* 0x3A4 */ public float QuadNavRadius;
        /* 0x3A8 */ public float QuadObstacleSize;
        /* 0x3AC */ public float QuadPatrolRadius;
        /* 0x3B0 */ public Vector2f QuadPatrolPauseTime;
        /* 0x3B8 */ public float QuadHearingRange;
        /* 0x3BC */ public float QuadSightRange;
        /* 0x3C0 */ public float QuadSightAngle;
        /* 0x3C4 */ public float DronePerceptionRange;
        /* 0x3C8 */ public float DronePerceptionSightRange;
        /* 0x3CC */ public float DronePerceptionSightAngle;
        /* 0x3D0 */ public float AttackMoveMaxTime;
        /* 0x3D4 */ public float AttackMoveArrivalDistance;
        /* 0x3D8 */ public float LaserFadeTime;
        /* 0x3DC */ public float LaserFadeTime2;
        /* 0x3E0 */ public GcRobotLaserData WalkerLaser;
        /* 0x430 */ public GcRobotLaserData QuadLaser;
        /* 0x480 */ public GcDroneData DroneControl;
    }
}
