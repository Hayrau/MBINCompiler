using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0xA829A15F1ECEF45B, NameHash = 0x792FD0F5EBBA55E9)]
    public class GcDamageMultiplierLookup : NMSTemplate
    {

        [NMS(Size = 0x10)]
        public string Id;
        public float Default;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding14;
        public List<GcDamageMultiplier> Multipliers;
    }
}