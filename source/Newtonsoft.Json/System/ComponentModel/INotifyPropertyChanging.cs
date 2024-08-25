using System;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	// Token: 0x02000005 RID: 5
	[Preserve]
	public interface INotifyPropertyChanging
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600000B RID: 11
		// (remove) Token: 0x0600000C RID: 12
		event PropertyChangingEventHandler PropertyChanging;
	}
}
