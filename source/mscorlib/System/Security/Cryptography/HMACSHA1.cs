using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002DD RID: 733
	[ComVisible(true)]
	public class HMACSHA1 : HMAC
	{
		// Token: 0x060018AD RID: 6317 RVA: 0x00034E18 File Offset: 0x00033018
		public HMACSHA1()
		{
			if (!true)
			{
			}
			byte[] array = Utils.GenerateRandom(64);
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00034E34 File Offset: 0x00033034
		public HMACSHA1(byte[] key)
		{
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00034E44 File Offset: 0x00033044
		public HMACSHA1(byte[] key, bool useManagedSha1)
		{
			this.blockSizeValue = 64;
			base..ctor();
			this.m_hashName = "SHA1";
			this.HashSizeValue = 160;
			base.InitializeKey(key);
		}
	}
}
