﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, Alignment = 0x8, GUID = 0x25CDC540F8CBEBCF, NameHash = 0xD46635882CF8E5)]
    public class GcTechnologyRequirement : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;

        public GcInventoryType InventoryType;
        public int Amount;
    }
}
