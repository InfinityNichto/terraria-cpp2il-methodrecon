using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002F0 RID: 752
	[ComVisible(true)]
	public abstract class RIPEMD160 : HashAlgorithm
	{
		// Token: 0x06001940 RID: 6464 RVA: 0x000366BC File Offset: 0x000348BC
		protected RIPEMD160()
		{
			this.HashSizeValue = 160;
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x0000207A File Offset: 0x0000027A
		public new static RIPEMD160 Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x000366DC File Offset: 0x000348DC
		public new static RIPEMD160 Create(string hashName)
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
