using System;
using System.Security.Cryptography;
using Cpp2IlInjected;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000047 RID: 71
	internal abstract class MD4 : HashAlgorithm
	{
		// Token: 0x06000155 RID: 341 RVA: 0x00005278 File Offset: 0x00003478
		protected MD4()
		{
			this.HashSizeValue = 128;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000207A File Offset: 0x0000027A
		public new static MD4 Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
