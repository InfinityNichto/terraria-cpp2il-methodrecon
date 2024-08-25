using System;

namespace System.Security.Cryptography
{
	// Token: 0x02000307 RID: 775
	internal class DSASignatureDescription : SignatureDescription
	{
		// Token: 0x06001A26 RID: 6694 RVA: 0x0003830C File Offset: 0x0003650C
		public DSASignatureDescription()
		{
			this._strKey = "System.Security.Cryptography.DSACryptoServiceProvider";
			this._strDigest = "System.Security.Cryptography.SHA1CryptoServiceProvider";
			this._strFormatter = "System.Security.Cryptography.DSASignatureFormatter";
			this._strDeformatter = "System.Security.Cryptography.DSASignatureDeformatter";
		}
	}
}
