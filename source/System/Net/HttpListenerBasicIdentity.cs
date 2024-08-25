using System;
using System.Security.Principal;

namespace System.Net
{
	// Token: 0x0200024B RID: 587
	public class HttpListenerBasicIdentity : GenericIdentity
	{
		// Token: 0x06000EF5 RID: 3829 RVA: 0x0002FC64 File Offset: 0x0002DE64
		public HttpListenerBasicIdentity(string username, string password)
			: base(username, "Basic")
		{
			this.password = password;
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x0002FC84 File Offset: 0x0002DE84
		public virtual string Password
		{
			get
			{
				return this.password;
			}
		}

		// Token: 0x04000C28 RID: 3112
		private string password;
	}
}
