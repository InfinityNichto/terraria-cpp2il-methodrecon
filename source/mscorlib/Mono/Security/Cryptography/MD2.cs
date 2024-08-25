using System;
using System.Security.Cryptography;
using Cpp2IlInjected;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000045 RID: 69
	internal abstract class MD2 : HashAlgorithm
	{
		// Token: 0x0600014C RID: 332 RVA: 0x0000508C File Offset: 0x0000328C
		protected MD2()
		{
			this.HashSizeValue = 128;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000207A File Offset: 0x0000027A
		public new static MD2 Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
