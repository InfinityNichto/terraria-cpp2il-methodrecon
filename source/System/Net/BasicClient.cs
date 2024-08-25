using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x0200022E RID: 558
	internal class BasicClient : IAuthenticationModule
	{
		// Token: 0x06000E0A RID: 3594 RVA: 0x0002CBC8 File Offset: 0x0002ADC8
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			if (challenge != null && credentials != null)
			{
				int num = challenge.Trim().ToLower().IndexOf("basic", StringComparison.Ordinal);
				return BasicClient.InternalAuthenticate(webRequest, credentials);
			}
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00002050 File Offset: 0x00000250
		private static byte[] GetBytes(string str)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x0002CBFC File Offset: 0x0002ADFC
		private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			while (webRequest == null)
			{
			}
			while (webRequest == null)
			{
			}
			string text;
			while (text == null)
			{
			}
			bool flag = text == "";
			string text2;
			if (text2 != null)
			{
				bool flag2 = text2 == "";
				bool flag3 = text2.Trim() == "";
			}
			string text4;
			string text3 = Convert.ToBase64String(BasicClient.GetBytes(text + ":" + text4));
			string text5 = "Basic " + text3;
			if (text2 == null || ("\\" != null && "\\" == null) || (":" != null && ":" == null) || text5 == null || text5 != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x0002CC9C File Offset: 0x0002AE9C
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			return BasicClient.InternalAuthenticate(webRequest, credentials);
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x0002CCB0 File Offset: 0x0002AEB0
		public string AuthenticationType
		{
			get
			{
				return "Basic";
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x0002CCC4 File Offset: 0x0002AEC4
		public bool CanPreAuthenticate
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x0002CCD4 File Offset: 0x0002AED4
		public BasicClient()
		{
		}
	}
}
