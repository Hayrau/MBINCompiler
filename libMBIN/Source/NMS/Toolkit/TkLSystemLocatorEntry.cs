﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x75324406CCCAAABD, NameHash = 0x5FB32B8921A7FE69)]
    public class TkLSystemLocatorEntry : NMSTemplate // 0x98 bytes
    {
        [NMS(Size = 0x80)]
        public string Model;

        public float Probability;
        public List<TkLSystemRestrictionData> Restrictions;
    }
}
