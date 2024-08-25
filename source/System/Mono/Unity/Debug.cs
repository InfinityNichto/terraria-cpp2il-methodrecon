using System;
using Mono.Security.Interface;

namespace Mono.Unity
{
	// Token: 0x0200000F RID: 15
	internal static class Debug
	{
		// Token: 0x0600003B RID: 59 RVA: 0x000024E0 File Offset: 0x000006E0
		public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, string context, AlertDescription defaultAlert = AlertDescription.InternalError)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000024F0 File Offset: 0x000006F0
		public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, UnityTls.unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert = AlertDescription.InternalError)
		{
			while (context != null)
			{
			}
		}
	}
}
