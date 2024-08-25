using System;
using System.Runtime.InteropServices;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000316 RID: 790
	[ComVisible(true)]
	public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
	{
		// Token: 0x06001AD6 RID: 6870 RVA: 0x00039F00 File Offset: 0x00038100
		public RSAPKCS1SignatureDeformatter()
		{
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x00039F14 File Offset: 0x00038114
		public RSAPKCS1SignatureDeformatter(AsymmetricAlgorithm key)
		{
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00039F28 File Offset: 0x00038128
		public override void SetHashAlgorithm(string strName)
		{
			while (strName == null)
			{
			}
			this.hashName = strName;
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00039F40 File Offset: 0x00038140
		public override void SetKey(AsymmetricAlgorithm key)
		{
			while (key == null)
			{
			}
			this.rsa = key;
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x00039F60 File Offset: 0x00038160
		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			RSA rsa;
			string text;
			do
			{
				rsa = this.rsa;
				if (rsa == null)
				{
					goto IL_0024;
				}
				text = this.hashName;
				if (text == null)
				{
					goto IL_002A;
				}
				if (rgbHash == null)
				{
					goto IL_0035;
				}
			}
			while (rgbSignature == null);
			return PKCS1.Verify_v15(rsa, text, rgbHash, rgbSignature);
			IL_0024:
			return "No public key available." != null;
			IL_002A:
			string text2 = Locale.GetText("Missing hash algorithm.");
			IL_0035:
			return "rgbHash" != null;
		}

		// Token: 0x04000DAA RID: 3498
		private RSA rsa;

		// Token: 0x04000DAB RID: 3499
		private string hashName;
	}
}
