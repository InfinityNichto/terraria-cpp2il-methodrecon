using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x0200074D RID: 1869
	public interface IParticle
	{
		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06003DA8 RID: 15784
		bool ShouldBeRemovedFromRenderer { get; }

		// Token: 0x06003DA9 RID: 15785
		void Update(ParticleRendererSettings settings);

		// Token: 0x06003DAA RID: 15786
		void Draw(ParticleRendererSettings settings, SpriteBatch spritebatch);
	}
}
