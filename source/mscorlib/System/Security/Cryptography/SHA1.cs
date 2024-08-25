using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002F9 RID: 761
	[ComVisible(true)]
	public abstract class SHA1 : HashAlgorithm
	{
		// Token: 0x060019CA RID: 6602 RVA: 0x00037768 File Offset: 0x00035968
		protected SHA1()
		{
			this.HashSizeValue = 160;
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x0000207A File Offset: 0x0000027A
		public new static SHA1 Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x00037788 File Offset: 0x00035988
		public new static SHA1 Create(string hashName)
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
