using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002FD RID: 765
	[ComVisible(true)]
	public abstract class SHA384 : HashAlgorithm
	{
		// Token: 0x060019EA RID: 6634 RVA: 0x00037B94 File Offset: 0x00035D94
		protected SHA384()
		{
			this.HashSizeValue = 384;
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x0000207A File Offset: 0x0000027A
		public new static SHA384 Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x00037BB4 File Offset: 0x00035DB4
		public new static SHA384 Create(string hashName)
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
