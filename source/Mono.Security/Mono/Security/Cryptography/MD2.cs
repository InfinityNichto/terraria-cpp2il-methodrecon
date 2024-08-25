using System;
using System.Security.Cryptography;
using Cpp2IlInjected;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000054 RID: 84
	public abstract class MD2 : HashAlgorithm
	{
		// Token: 0x06000242 RID: 578 RVA: 0x00009324 File Offset: 0x00007524
		protected MD2()
		{
			this.HashSizeValue = 128;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
		public new static MD2 Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
