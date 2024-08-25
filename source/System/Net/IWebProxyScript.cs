using System;

namespace System.Net
{
	// Token: 0x02000260 RID: 608
	public interface IWebProxyScript
	{
		// Token: 0x0600105F RID: 4191
		void Close();

		// Token: 0x06001060 RID: 4192
		bool Load(global::System.Uri scriptLocation, string script, Type helperType);

		// Token: 0x06001061 RID: 4193
		string Run(string url, string host);
	}
}
