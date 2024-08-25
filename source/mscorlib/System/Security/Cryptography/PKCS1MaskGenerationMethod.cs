using System;
using System.Runtime.InteropServices;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x020002E8 RID: 744
	[ComVisible(true)]
	public class PKCS1MaskGenerationMethod : MaskGenerationMethod
	{
		// Token: 0x060018FA RID: 6394 RVA: 0x00035910 File Offset: 0x00033B10
		public PKCS1MaskGenerationMethod()
		{
			this.HashNameValue = "SHA1";
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060018FB RID: 6395 RVA: 0x00035930 File Offset: 0x00033B30
		// (set) Token: 0x060018FC RID: 6396 RVA: 0x00035944 File Offset: 0x00033B44
		public string HashName
		{
			get
			{
				return this.HashNameValue;
			}
			set
			{
				this.HashNameValue = value;
				if (value == null)
				{
					this.HashNameValue = "SHA1";
				}
			}
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00035968 File Offset: 0x00033B68
		public override byte[] GenerateMask(byte[] rgbSeed, int cbReturn)
		{
			return PKCS1.MGF1(HashAlgorithm.Create(this.HashNameValue), rgbSeed, cbReturn);
		}

		// Token: 0x04000CCE RID: 3278
		private string HashNameValue;
	}
}
