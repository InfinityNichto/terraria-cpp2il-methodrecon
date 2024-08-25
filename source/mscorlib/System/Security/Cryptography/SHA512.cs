using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002FF RID: 767
	[ComVisible(true)]
	public abstract class SHA512 : HashAlgorithm
	{
		// Token: 0x060019FE RID: 6654 RVA: 0x00037E08 File Offset: 0x00036008
		protected SHA512()
		{
			this.HashSizeValue = 512;
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x0000207A File Offset: 0x0000027A
		public new static SHA512 Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x00037E28 File Offset: 0x00036028
		public new static SHA512 Create(string hashName)
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
