﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x10, GUID = 0x738CDF94ACD0CC0A, NameHash = 0x88CFB7D1D223D0C5)]
    public class GcHUDTextData : NMSTemplate
    {
        public GcHUDComponent Data;

        [NMS(Size = 0x80)]
        public string Text;

        [NMS(Size = 8, Ignore = true)]
        public byte[] PaddingA8;

        public GcTextPreset Preset;
    }
}
