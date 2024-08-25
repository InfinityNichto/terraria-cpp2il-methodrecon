using System;

namespace System.Security.Cryptography
{
	// Token: 0x02000302 RID: 770
	internal abstract class RSAPKCS1SignatureDescription : SignatureDescription
	{
		// Token: 0x06001A1F RID: 6687 RVA: 0x00038208 File Offset: 0x00036408
		protected RSAPKCS1SignatureDescription(string hashAlgorithm, string digestAlgorithm)
		{
			this._strKey = "System.Security.Cryptography.RSA";
			this._strDigest = digestAlgorithm;
			this._strFormatter = "System.Security.Cryptography.RSAPKCS1SignatureFormatter";
			this._strDeformatter = "System.Security.Cryptography.RSAPKCS1SignatureDeformatter";
			this._hashAlgorithm = hashAlgorithm;
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x0003824C File Offset: 0x0003644C
		public sealed override AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key)
		{
			AsymmetricSignatureDeformatter asymmetricSignatureDeformatter = base.CreateDeformatter(key);
			string hashAlgorithm = this._hashAlgorithm;
			return asymmetricSignatureDeformatter;
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x0003826C File Offset: 0x0003646C
		public sealed override AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key)
		{
			AsymmetricSignatureFormatter asymmetricSignatureFormatter = base.CreateFormatter(key);
			string hashAlgorithm = this._hashAlgorithm;
			return asymmetricSignatureFormatter;
		}

		// Token: 0x04000D2A RID: 3370
		private string _hashAlgorithm;
	}
}
