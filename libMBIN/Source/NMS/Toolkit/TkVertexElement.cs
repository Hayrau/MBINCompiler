using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x20, GUID = 0x56D2CFD1D4DB01F3, NameHash = 0x8687A0CA8457FC32)]
    public class TkVertexElement : NMSTemplate
    {
        /* 0x00 */ public int SemanticID;
        /* 0x04 */ public int Size;
        /* 0x08 */ public int Type;
        /* 0x0C */ public int Offset;
        /* 0x10 */ public int Normalise;

		public enum InstancingEnum { PerVertex, PerModel }
		public InstancingEnum Instancing;

        [NMS(Size = 8)]
        /* 0x18 */ public string PlatformData;
    }
}
