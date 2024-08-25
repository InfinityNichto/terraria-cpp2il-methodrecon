using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002DB RID: 731
	[ComVisible(true)]
	public class HMACMD5 : HMAC
	{
		// Token: 0x060018A9 RID: 6313 RVA: 0x00034D78 File Offset: 0x00032F78
		public HMACMD5()
		{
			if (!true)
			{
			}
			byte[] array = Utils.GenerateRandom(64);
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00034D90 File Offset: 0x00032F90
		public HMACMD5(byte[] key)
		{
			this.blockSizeValue = 64;
			base..ctor();
			this.m_hashName = "MD5";
			this.HashSizeValue = 128;
			base.InitializeKey(key);
		}
	}
}
