using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Renderers;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AC6 RID: 2758
	public class UIParticleLayer : UIElement
	{
		// Token: 0x06005121 RID: 20769 RVA: 0x0027F868 File Offset: 0x0027DA68
		public UIParticleLayer()
		{
			if (!true)
			{
			}
			base..ctor();
			this.IgnoresMouseInteraction = true;
		}

		// Token: 0x06005122 RID: 20770 RVA: 0x0027F888 File Offset: 0x0027DA88
		private void ParticleSystemUpdate(UIElement affectedElement)
		{
			this.ParticleSystem.Update();
		}

		// Token: 0x06005123 RID: 20771 RVA: 0x0027F8A0 File Offset: 0x0027DAA0
		public override void Recalculate()
		{
			base.Recalculate();
			float x = this._dimensions.X;
			ParticleRenderer particleSystem = this.ParticleSystem;
			if (!true)
			{
			}
			Rectangle rectangle;
			Vector2 vector = rectangle.TopLeft();
			float x2 = this.AnchorPositionOffsetByPercents.X;
			float y = this.AnchorPositionOffsetByPercents.Y;
			Vector2 vector2 = rectangle.Size();
			if (!true)
			{
			}
			float x3 = this.AnchorPositionOffsetByPixels.X;
			float y2 = this.AnchorPositionOffsetByPixels.Y;
		}

		// Token: 0x06005124 RID: 20772 RVA: 0x0027F918 File Offset: 0x0027DB18
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			this.ParticleSystem.Draw(spriteBatch);
		}

		// Token: 0x06005125 RID: 20773 RVA: 0x0027F934 File Offset: 0x0027DB34
		public void AddParticle(IParticle particle)
		{
			this.ParticleSystem.Add(particle);
		}

		// Token: 0x06005126 RID: 20774 RVA: 0x0027F950 File Offset: 0x0027DB50
		public void ClearParticles()
		{
			this.ParticleSystem.Clear();
		}

		// Token: 0x040089C9 RID: 35273
		public ParticleRenderer ParticleSystem;

		// Token: 0x040089CA RID: 35274
		public Vector2 AnchorPositionOffsetByPercents;

		// Token: 0x040089CB RID: 35275
		public Vector2 AnchorPositionOffsetByPixels;
	}
}
