﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x240, GUID = 0x419D99411C2B0A01, NameHash = 0x2EB82866D685EFBF)]
    public class GcMissionSequenceWaitForPhoto : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string MessageSecondary;
        [NMS(Size = 0x80)]
        /* 0x100 */ public string MessageSuccess;
        /* 0x180 */ public List<GcBiomeType> Biomes;
        /* 0x190 */ public List<GcPhotoFauna> Fauna;
        /* 0x1A0 */ public List<GcPhotoFlora> Flora;
        /* 0x1B0 */ public List<GcPhotoBuildings> Buildings;
        [NMS(Size = 0x80)]
        /* 0x1C0 */ public string DebugText;
    }
}
