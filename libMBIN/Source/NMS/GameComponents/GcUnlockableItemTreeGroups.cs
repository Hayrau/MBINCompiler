﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x6B0A243454D26E36, NameHash = 0x8F55B25E91A470A9)]
    public class GcUnlockableItemTreeGroups : NMSTemplate
    {
        // 0xB entries
        public enum UnlockableItemTreeEnum { Test, BasicBaseParts, BasicTechParts, BaseParts, SpecialBaseParts, SuitTech, ShipTech, WeapTech, ExocraftTech, CraftProducts, FreighterTech }
        public UnlockableItemTreeEnum GetUnlockableItemTree;
    }
}
