using System;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x020000A2 RID: 162
	internal class Ucs4Encoding3412 : Ucs4Encoding
	{
		// Token: 0x06000768 RID: 1896 RVA: 0x00018A50 File Offset: 0x00016C50
		public Ucs4Encoding3412()
		{
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00018A64 File Offset: 0x00016C64
		public override string EncodingName
		{
			get
			{
				return "ucs-4 (order 3412)";
			}
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00003FFD File Offset: 0x000021FD
		public override byte[] GetPreamble()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
