using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x02000301 RID: 769
	[ComVisible(true)]
	public class SignatureDescription
	{
		// Token: 0x06001A12 RID: 6674 RVA: 0x00038078 File Offset: 0x00036278
		public SignatureDescription()
		{
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0003808C File Offset: 0x0003628C
		public SignatureDescription(SecurityElement el)
		{
			do
			{
				base..ctor();
			}
			while (el == null);
			string text = el.SearchForTextOfTag("Key");
			this._strKey = text;
			string text2 = el.SearchForTextOfTag("Digest");
			this._strDigest = text2;
			string text3 = el.SearchForTextOfTag("Formatter");
			this._strFormatter = text3;
			string text4 = el.SearchForTextOfTag("Deformatter");
			this._strDeformatter = text4;
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06001A14 RID: 6676 RVA: 0x000380F0 File Offset: 0x000362F0
		// (set) Token: 0x06001A15 RID: 6677 RVA: 0x00038104 File Offset: 0x00036304
		public string KeyAlgorithm
		{
			get
			{
				return this._strKey;
			}
			set
			{
				this._strKey = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x00038118 File Offset: 0x00036318
		// (set) Token: 0x06001A17 RID: 6679 RVA: 0x0003812C File Offset: 0x0003632C
		public string DigestAlgorithm
		{
			get
			{
				return this._strDigest;
			}
			set
			{
				this._strDigest = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x00038140 File Offset: 0x00036340
		// (set) Token: 0x06001A19 RID: 6681 RVA: 0x00038154 File Offset: 0x00036354
		public string FormatterAlgorithm
		{
			get
			{
				return this._strFormatter;
			}
			set
			{
				this._strFormatter = value;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x00038168 File Offset: 0x00036368
		// (set) Token: 0x06001A1B RID: 6683 RVA: 0x0003817C File Offset: 0x0003637C
		public string DeformatterAlgorithm
		{
			get
			{
				return this._strDeformatter;
			}
			set
			{
				this._strDeformatter = value;
			}
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x00038190 File Offset: 0x00036390
		public virtual AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key)
		{
			int num = 1;
			string strDeformatter = this._strDeformatter;
			if (num == 0)
			{
			}
			object obj = CryptoConfig.CreateFromName(strDeformatter);
			throw new InvalidCastException();
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x000381B8 File Offset: 0x000363B8
		public virtual AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key)
		{
			int num = 1;
			string strFormatter = this._strFormatter;
			if (num == 0)
			{
			}
			object obj = CryptoConfig.CreateFromName(strFormatter);
			throw new InvalidCastException();
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x000381E0 File Offset: 0x000363E0
		public virtual HashAlgorithm CreateDigest()
		{
			int num = 1;
			string strDigest = this._strDigest;
			if (num == 0)
			{
			}
			if (CryptoConfig.CreateFromName(strDigest) != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x04000D26 RID: 3366
		private string _strKey;

		// Token: 0x04000D27 RID: 3367
		private string _strDigest;

		// Token: 0x04000D28 RID: 3368
		private string _strFormatter;

		// Token: 0x04000D29 RID: 3369
		private string _strDeformatter;
	}
}
