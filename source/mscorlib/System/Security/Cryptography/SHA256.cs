using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002FB RID: 763
	[ComVisible(true)]
	public abstract class SHA256 : HashAlgorithm
	{
		// Token: 0x060019D6 RID: 6614 RVA: 0x0003792C File Offset: 0x00035B2C
		protected SHA256()
		{
			this.HashSizeValue = 256;
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x0000207A File Offset: 0x0000027A
		public new static SHA256 Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x0003794C File Offset: 0x00035B4C
		public new static SHA256 Create(string hashName)
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
