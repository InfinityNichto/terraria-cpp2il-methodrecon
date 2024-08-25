using System;
using System.Security.Cryptography;
using Cpp2IlInjected;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000056 RID: 86
	public abstract class MD4 : HashAlgorithm
	{
		// Token: 0x0600024B RID: 587 RVA: 0x00009528 File Offset: 0x00007728
		protected MD4()
		{
			this.HashSizeValue = 128;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002050 File Offset: 0x00000250
		public new static MD4 Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
