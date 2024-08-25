using System;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x020000A0 RID: 160
	internal class Ucs4Encoding4321 : Ucs4Encoding
	{
		// Token: 0x06000762 RID: 1890 RVA: 0x00018A00 File Offset: 0x00016C00
		public Ucs4Encoding4321()
		{
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x00018A14 File Offset: 0x00016C14
		public override string EncodingName
		{
			get
			{
				return "ucs-4";
			}
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00003FFD File Offset: 0x000021FD
		public override byte[] GetPreamble()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
