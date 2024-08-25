using System;
using System.Runtime.InteropServices;

namespace System.Configuration
{
	// Token: 0x02000498 RID: 1176
	[ComVisible(false)]
	public interface IConfigurationSystem
	{
		// Token: 0x06001FE0 RID: 8160
		object GetConfig(string configKey);

		// Token: 0x06001FE1 RID: 8161
		void Init();
	}
}
