﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB807E0A43E0D5F25, NameHash = 0xE2FBC00AA319096D)]
    public class GcMissionSequenceSetGlobalMission : NMSTemplate
    {
		public enum GlobalMissionEnum { Atlas, BlackHole, Anomaly, Explore }
		public GlobalMissionEnum GlobalMission;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string DebugText;
    }
}
