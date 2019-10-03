﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0xB0D5463CD4B43499, NameHash = 0x3A526CC4024569BA)]
    public class GcFrigateTraitData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ID;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string DisplayName;
        /* 0x30 */ public GcFrigateStatType FrigateStatType;
        /* 0x34 */ public GcFrigateTraitStrength Strength;
        [NMS(Size = 0x5)]
        /* 0x38 */ public int[] ChanceOfBeingOffered;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4C */ public byte[] EndPadding;
    }
}
