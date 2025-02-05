using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x78E22E9728E307D2, NameHash = 0x315B295516601328)]
    public class GcPlanetDataResourceHint : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Hint;
        [NMS(Size = 0x10)]
        public string Icon;
    }
}
