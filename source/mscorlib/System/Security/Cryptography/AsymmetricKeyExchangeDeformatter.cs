using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002C5 RID: 709
	[ComVisible(true)]
	public abstract class AsymmetricKeyExchangeDeformatter
	{
		// Token: 0x06001812 RID: 6162 RVA: 0x00033958 File Offset: 0x00031B58
		protected AsymmetricKeyExchangeDeformatter()
		{
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06001813 RID: 6163
		// (set) Token: 0x06001814 RID: 6164
		public abstract string Parameters { get; set; }

		// Token: 0x06001815 RID: 6165
		public abstract void SetKey(AsymmetricAlgorithm key);

		// Token: 0x06001816 RID: 6166
		public abstract byte[] DecryptKeyExchange(byte[] rgb);
	}
}
