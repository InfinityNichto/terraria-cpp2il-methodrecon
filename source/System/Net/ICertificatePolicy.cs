using System;
using System.Security.Cryptography.X509Certificates;

namespace System.Net
{
	// Token: 0x02000198 RID: 408
	public interface ICertificatePolicy
	{
		// Token: 0x06000A63 RID: 2659
		bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem);
	}
}
