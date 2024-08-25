using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002F8 RID: 760
	[ComVisible(true)]
	public class RSAPKCS1KeyExchangeFormatter : AsymmetricKeyExchangeFormatter
	{
		// Token: 0x060019C1 RID: 6593 RVA: 0x00037658 File Offset: 0x00035858
		public RSAPKCS1KeyExchangeFormatter()
		{
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x0003766C File Offset: 0x0003586C
		public RSAPKCS1KeyExchangeFormatter(AsymmetricAlgorithm key)
		{
			do
			{
				base..ctor();
			}
			while (key == null);
			this._rsaKey = key;
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060019C3 RID: 6595 RVA: 0x00037690 File Offset: 0x00035890
		public override string Parameters
		{
			get
			{
				return "<enc:KeyEncryptionMethod enc:Algorithm=\"http://www.microsoft.com/xml/security/algorithm/PKCS1-v1.5-KeyEx\" xmlns:enc=\"http://www.microsoft.com/xml/security/encryption/v1.0\" />";
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x000376A4 File Offset: 0x000358A4
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x000376B8 File Offset: 0x000358B8
		public RandomNumberGenerator Rng
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

		// Token: 0x060019C6 RID: 6598 RVA: 0x000376CC File Offset: 0x000358CC
		public override void SetKey(AsymmetricAlgorithm key)
		{
			while (key == null)
			{
			}
			this._rsaKey = key;
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x000376EC File Offset: 0x000358EC
		public override byte[] CreateKeyExchange(byte[] rgbData)
		{
			if (rgbData != null)
			{
				RSA rsaKey = this._rsaKey;
				if (rsaKey != null)
				{
					bool overridesEncrypt = this.OverridesEncrypt;
					RSA rsaKey2 = this._rsaKey;
					if (rsaKey == null)
					{
					}
					if (!true)
					{
					}
					RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
				}
			}
			string resourceString = Environment.GetResourceString("No asymmetric key object has been associated with this formatter object.");
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x0000207A File Offset: 0x0000027A
		public override byte[] CreateKeyExchange(byte[] rgbData, Type symAlgType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x00037738 File Offset: 0x00035938
		private bool OverridesEncrypt
		{
			get
			{
				if (this._rsaOverridesEncrypt == null)
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

		// Token: 0x04000D10 RID: 3344
		private RandomNumberGenerator RngValue;

		// Token: 0x04000D11 RID: 3345
		private RSA _rsaKey;

		// Token: 0x04000D12 RID: 3346
		private bool? _rsaOverridesEncrypt;
	}
}
