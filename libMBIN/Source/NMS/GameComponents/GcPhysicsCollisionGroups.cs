﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7E5F8259CA3DB8C9, NameHash = 0x29A5D23AA5A4C794)]
    public class GcPhysicsCollisionGroups : NMSTemplate
    {
        // 0x10 entries
		public enum CollisionGroupEnum { Normal, Water, Terrain, Substance, Asteroid, TerrainInstance, TerrainActivated, Player, Creature, Spaceship, Debris, Shield, Raycast, NetworkPlayer, NPCs, Trigger }
		public CollisionGroupEnum CollisionGroup;
    }
}
