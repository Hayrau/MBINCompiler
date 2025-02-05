﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1F78F7E6ABC7B3B2, NameHash = 0xDB9BCAEA43E96FA6)]
    public class GcStatGroupData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string GroupName;
        public List<NMSString0x10> TrackedStats;
    }
}
