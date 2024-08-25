using System;

namespace System.ComponentModel
{
	// Token: 0x0200033C RID: 828
	public interface ISite : IServiceProvider
	{
		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600159A RID: 5530
		IComponent Component { get; }

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600159B RID: 5531
		IContainer Container { get; }

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x0600159C RID: 5532
		bool DesignMode { get; }

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x0600159D RID: 5533
		// (set) Token: 0x0600159E RID: 5534
		string Name { get; set; }
	}
}
