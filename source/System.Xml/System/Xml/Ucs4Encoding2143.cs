using System;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x020000A1 RID: 161
	internal class Ucs4Encoding2143 : Ucs4Encoding
	{
		// Token: 0x06000765 RID: 1893 RVA: 0x00018A28 File Offset: 0x00016C28
		public Ucs4Encoding2143()
		{
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00018A3C File Offset: 0x00016C3C
		public override string EncodingName
		{
			get
			{
				return "ucs-4 (order 2143)";
			}
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00003FFD File Offset: 0x000021FD
		public override byte[] GetPreamble()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
