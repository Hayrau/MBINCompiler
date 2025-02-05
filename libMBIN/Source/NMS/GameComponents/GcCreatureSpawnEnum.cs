﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5DFE5E8FA0CB7628, NameHash = 0xF1142B73FBEC2939)]
    public class GcCreatureSpawnEnum : NMSTemplate
    {
        // 0x1A entries
		public enum IncrementorEnum { None, Resource, ResourceAway, HeavyAir, Drone, Deer, DeerScan, DeerWords, DeerWordsAway, Diplo, DiploScan, DiploWords, DiploWordsAway, Flyby, Beast, Wingmen, Scouts, Fleet, Attackers, AttackersFromBehind, Flee, RemoveFleet, Fighters, PostFighters, Escape, Warp }
		public IncrementorEnum Incrementor;
    }
}
