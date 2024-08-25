using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002E6 RID: 742
	[ComVisible(true)]
	public abstract class MD5 : HashAlgorithm
	{
		// Token: 0x060018E2 RID: 6370 RVA: 0x00035534 File Offset: 0x00033734
		protected MD5()
		{
			this.HashSizeValue = 128;
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0000207A File Offset: 0x0000027A
		public new static MD5 Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00035554 File Offset: 0x00033754
		public new static MD5 Create(string algName)
		{
			if (!true)
			{
			}
			object obj;
			if (obj != null)
			{
			}
			throw new InvalidCastException();
		}
	}
}
