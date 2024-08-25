using System;

namespace System.ComponentModel.Design
{
	// Token: 0x0200040E RID: 1038
	public interface IDesignerHost : IServiceProvider
	{
		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001C0A RID: 7178
		IComponent RootComponent { get; }

		// Token: 0x06001C0B RID: 7179
		IDesigner GetDesigner(IComponent component);
	}
}
