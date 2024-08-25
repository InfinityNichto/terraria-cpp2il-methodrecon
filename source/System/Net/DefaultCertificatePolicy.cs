using System;
using System.Security.Cryptography.X509Certificates;

namespace System.Net
{
	// Token: 0x02000237 RID: 567
	internal class DefaultCertificatePolicy : ICertificatePolicy
	{
		// Token: 0x06000E28 RID: 3624 RVA: 0x0002D0FC File Offset: 0x0002B2FC
		public bool CheckValidationResult(ServicePoint point, X509Certificate certificate, WebRequest request, int certificateProblem)
		{
			if (!true)
			{
			}
			if (ServicePointManager.ServerCertificateValidationCallback == null)
			{
			}
			return true;
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x0002D118 File Offset: 0x0002B318
		public DefaultCertificatePolicy()
		{
		}
	}
}
