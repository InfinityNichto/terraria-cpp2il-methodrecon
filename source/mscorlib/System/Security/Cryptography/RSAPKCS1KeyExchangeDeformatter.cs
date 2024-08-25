using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002F7 RID: 759
	[ComVisible(true)]
	public class RSAPKCS1KeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
	{
		// Token: 0x060019B8 RID: 6584 RVA: 0x00037544 File Offset: 0x00035744
		public RSAPKCS1KeyExchangeDeformatter()
		{
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x00037558 File Offset: 0x00035758
		public RSAPKCS1KeyExchangeDeformatter(AsymmetricAlgorithm key)
		{
			do
			{
				base..ctor();
			}
			while (key == null);
			this._rsaKey = key;
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x0003757C File Offset: 0x0003577C
		// (set) Token: 0x060019BB RID: 6587 RVA: 0x00037590 File Offset: 0x00035790
		public RandomNumberGenerator RNG
		{
			get
			{
				return this.RngValue;
			}
			set
			{
				this.RngValue = value;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x000375A4 File Offset: 0x000357A4
		// (set) Token: 0x060019BD RID: 6589 RVA: 0x000375B4 File Offset: 0x000357B4
		public override string Parameters
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x000375C4 File Offset: 0x000357C4
		public override byte[] DecryptKeyExchange(byte[] rgbIn)
		{
			RSA rsaKey = this._rsaKey;
			if (rsaKey != null)
			{
				bool overridesDecrypt = this.OverridesDecrypt;
				RSA rsaKey2 = this._rsaKey;
				if (rsaKey == null)
				{
				}
				if (!true)
				{
				}
				KeySizes[] legalKeySizesValue = rsaKey2.LegalKeySizesValue;
				string resourceString = Environment.GetResourceString("Error occurred while decoding PKCS1 padding.");
			}
			return "No asymmetric key object has been associated with this formatter object.";
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x00037608 File Offset: 0x00035808
		public override void SetKey(AsymmetricAlgorithm key)
		{
			while (key == null)
			{
			}
			this._rsaKey = key;
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x00037628 File Offset: 0x00035828
		private bool OverridesDecrypt
		{
			get
			{
				if (this._rsaOverridesDecrypt == null)
				{
					RSA rsaKey = this._rsaKey;
					Type type;
					Type type2;
					if ((type != null && type == null) || type2 == null || type2 != null)
					{
					}
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x04000D0D RID: 3341
		private RSA _rsaKey;

		// Token: 0x04000D0E RID: 3342
		private bool? _rsaOverridesDecrypt;

		// Token: 0x04000D0F RID: 3343
		private RandomNumberGenerator RngValue;
	}
}
