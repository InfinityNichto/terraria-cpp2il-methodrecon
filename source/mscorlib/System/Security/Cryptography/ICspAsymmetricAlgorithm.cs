using System;

namespace System.Security.Cryptography
{
	// Token: 0x020002B3 RID: 691
	public interface ICspAsymmetricAlgorithm
	{
		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600177F RID: 6015
		CspKeyContainerInfo CspKeyContainerInfo { get; }

		// Token: 0x06001780 RID: 6016
		byte[] ExportCspBlob(bool includePrivateParameters);

		// Token: 0x06001781 RID: 6017
		void ImportCspBlob(byte[] rawData);
	}
}
