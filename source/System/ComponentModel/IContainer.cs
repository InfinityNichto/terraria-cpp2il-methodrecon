using System;

namespace System.ComponentModel
{
	// Token: 0x0200033B RID: 827
	public interface IContainer : IDisposable
	{
		// Token: 0x06001596 RID: 5526
		void Add(IComponent component);

		// Token: 0x06001597 RID: 5527
		void Add(IComponent component, string name);

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001598 RID: 5528
		ComponentCollection Components { get; }

		// Token: 0x06001599 RID: 5529
		void Remove(IComponent component);
	}
}
