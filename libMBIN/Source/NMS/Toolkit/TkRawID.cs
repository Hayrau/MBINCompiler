﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xB73B8BA0886BF755, NameHash = 0x8DE367576DE742FE)]
    public class TkRawID : NMSTemplate
    {
        [NMS(Size = 0x8)]
        public string Value0;
        public ulong Value1;
    }
}
