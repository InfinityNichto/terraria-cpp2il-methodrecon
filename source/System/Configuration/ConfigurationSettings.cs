using System;
using System.Collections.Specialized;

namespace System.Configuration
{
	// Token: 0x02000494 RID: 1172
	public sealed class ConfigurationSettings
	{
		// Token: 0x06001FD1 RID: 8145 RVA: 0x00052688 File Offset: 0x00050888
		internal ConfigurationSettings()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x0005269C File Offset: 0x0005089C
		public static global::System.Collections.Specialized.NameValueCollection AppSettings
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x000526B0 File Offset: 0x000508B0
		[Obsolete("This method is obsolete, it has been replaced by System.Configuration!System.Configuration.ConfigurationManager.GetSection")]
		public static object GetConfig(string sectionName)
		{
			throw new NotSupportedException();
		}
	}
}
