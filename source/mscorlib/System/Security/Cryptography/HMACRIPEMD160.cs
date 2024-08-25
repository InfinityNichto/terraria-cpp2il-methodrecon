using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002DC RID: 732
	[ComVisible(true)]
	public class HMACRIPEMD160 : HMAC
	{
		// Token: 0x060018AB RID: 6315 RVA: 0x00034DC8 File Offset: 0x00032FC8
		public HMACRIPEMD160()
		{
			if (!true)
			{
			}
			byte[] array = Utils.GenerateRandom(64);
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x00034DE0 File Offset: 0x00032FE0
		public HMACRIPEMD160(byte[] key)
		{
			this.blockSizeValue = 64;
			base..ctor();
			this.m_hashName = "RIPEMD160";
			this.HashSizeValue = 160;
			base.InitializeKey(key);
		}
	}
}
