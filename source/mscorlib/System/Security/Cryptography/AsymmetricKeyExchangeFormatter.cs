using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002C6 RID: 710
	[ComVisible(true)]
	public abstract class AsymmetricKeyExchangeFormatter
	{
		// Token: 0x06001817 RID: 6167 RVA: 0x0003396C File Offset: 0x00031B6C
		protected AsymmetricKeyExchangeFormatter()
		{
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06001818 RID: 6168
		public abstract string Parameters { get; }

		// Token: 0x06001819 RID: 6169
		public abstract void SetKey(AsymmetricAlgorithm key);

		// Token: 0x0600181A RID: 6170
		public abstract byte[] CreateKeyExchange(byte[] data);

		// Token: 0x0600181B RID: 6171
		public abstract byte[] CreateKeyExchange(byte[] data, Type symAlgType);
	}
}
