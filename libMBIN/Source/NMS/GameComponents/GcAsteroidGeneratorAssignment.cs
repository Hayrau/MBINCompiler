﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xEC29C33F72A89F71, NameHash = 0xA3D40DA508711D13)]
    public class GcAsteroidGeneratorAssignment : NMSTemplate // 0x48 bytes
    {
        /* 0x00 */ public int PlanetIndex;
        /* 0x04 */ public GcSolarSystemLocatorChoice Locator;
        /* 0x30 */ public GcSeed Seed;
        /* 0x40 */ public int AsteroidCount;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding44;
    }
}
