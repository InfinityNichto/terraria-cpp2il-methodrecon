using System;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000006 RID: 6
	public static class RSACertificateExtensions
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00002514 File Offset: 0x00000714
		public static RSA GetRSAPublicKey(this X509Certificate2 certificate)
		{
			PublicKey publicKey;
			while (publicKey.Key == null)
			{
			}
		}
	}
}
