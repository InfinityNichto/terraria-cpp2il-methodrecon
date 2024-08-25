using System;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x0200009F RID: 159
	internal class Ucs4Encoding1234 : Ucs4Encoding
	{
		// Token: 0x0600075F RID: 1887 RVA: 0x000189D8 File Offset: 0x00016BD8
		public Ucs4Encoding1234()
		{
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x000189EC File Offset: 0x00016BEC
		public override string EncodingName
		{
			get
			{
				return "ucs-4 (Bigendian)";
			}
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00003FFD File Offset: 0x000021FD
		public override byte[] GetPreamble()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
