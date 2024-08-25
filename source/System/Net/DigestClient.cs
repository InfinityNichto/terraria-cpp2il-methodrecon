using System;
using System.Collections;

namespace System.Net
{
	// Token: 0x0200023A RID: 570
	internal class DigestClient : IAuthenticationModule
	{
		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x0002D810 File Offset: 0x0002BA10
		private static Hashtable Cache
		{
			get
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				DigestClient.CheckExpired(1);
				long num = 0L;
				if (true)
				{
				}
				if (num == 0L)
				{
					if (!true)
					{
					}
					return 1;
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0002D84C File Offset: 0x0002BA4C
		private static void CheckExpired(int count)
		{
			if (!true)
			{
			}
			DateTime utcNow = DateTime.UtcNow;
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0002D8E4 File Offset: 0x0002BAE4
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			if (challenge != null && credentials != null)
			{
				int num = challenge.Trim().ToLower().IndexOf("digest");
				if (webRequest != null)
				{
				}
			}
			if (DigestClient.Cache != null)
			{
			}
			Hashtable hashtable = DigestClient.Cache;
			Authorization authorization;
			return authorization;
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0002D928 File Offset: 0x0002BB28
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			do
			{
				if (webRequest != null)
				{
				}
				while (credentials == null)
				{
				}
			}
			while (DigestClient.Cache == null);
			Authorization authorization;
			return authorization;
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x0002D94C File Offset: 0x0002BB4C
		public string AuthenticationType
		{
			get
			{
				return "Digest";
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x0002D960 File Offset: 0x0002BB60
		public bool CanPreAuthenticate
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x0002D970 File Offset: 0x0002BB70
		public DigestClient()
		{
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x0002D984 File Offset: 0x0002BB84
		// Note: this type is marked as 'beforefieldinit'.
		static DigestClient()
		{
		}

		// Token: 0x04000BD7 RID: 3031
		private static readonly Hashtable cache;
	}
}
