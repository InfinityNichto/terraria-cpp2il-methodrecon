using System;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x02000752 RID: 1874
	public interface IPooledParticle : IParticle
	{
		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06003DB7 RID: 15799
		bool IsRestingInPool { get; }

		// Token: 0x06003DB8 RID: 15800
		void RestInPool();

		// Token: 0x06003DB9 RID: 15801
		void FetchFromPool();
	}
}
