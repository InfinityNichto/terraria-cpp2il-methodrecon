using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002DE RID: 734
	[ComVisible(true)]
	public class HMACSHA256 : HMAC
	{
		// Token: 0x060018B0 RID: 6320 RVA: 0x00034E7C File Offset: 0x0003307C
		public HMACSHA256()
		{
			if (!true)
			{
			}
			byte[] array = Utils.GenerateRandom(64);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00034E94 File Offset: 0x00033094
		public HMACSHA256(byte[] key)
		{
			this.blockSizeValue = 64;
			base..ctor();
			this.m_hashName = "SHA256";
			this.HashSizeValue = 256;
			base.InitializeKey(key);
		}
	}
}
