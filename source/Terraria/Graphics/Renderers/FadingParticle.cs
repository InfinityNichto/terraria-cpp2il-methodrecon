using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x02000757 RID: 1879
	public class FadingParticle : ABasicParticle
	{
		// Token: 0x06003DDE RID: 15838 RVA: 0x0023A65C File Offset: 0x0023885C
		public override void FetchFromPool()
		{
			base.FetchFromPool();
		}

		// Token: 0x06003DDF RID: 15839 RVA: 0x0023A670 File Offset: 0x00238870
		public void SetTypeInfo(float timeToLive)
		{
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x0023A680 File Offset: 0x00238880
		public override void Update(ParticleRendererSettings settings)
		{
			base.Update(settings);
			float timeTolive = this._timeTolive;
			float timeSinceSpawn = this._timeSinceSpawn;
			this._timeSinceSpawn = timeSinceSpawn;
			this.<ShouldBeRemovedFromRenderer>k__BackingField = true;
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x0023A6B0 File Offset: 0x002388B0
		public override void Draw(ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
			Color colorTint = this.ColorTint;
			float fadeInNormalizedTime = this.FadeInNormalizedTime;
			if (!true)
			{
			}
			if (!true)
			{
			}
			float num;
			Color color = colorTint * num;
			float timeTolive = this._timeTolive;
			float timeSinceSpawn = this._timeSinceSpawn;
			float fadeOutNormalizedTime = this.FadeOutNormalizedTime;
			Asset<Texture2D> texture = this._texture;
			Vector2 anchorPosition = settings.AnchorPosition;
			float x = this.LocalPosition.X;
			float y = this.LocalPosition.Y;
			if (texture == null)
			{
			}
			Rectangle frame = this._frame;
			int width = this._frame.Width;
			float y2 = this._origin.Y;
			float rotation = this.Rotation;
			float x2 = this._origin.X;
			float x3 = this.Scale.X;
			float y3 = this.Scale.Y;
		}

		// Token: 0x06003DE2 RID: 15842 RVA: 0x0023A774 File Offset: 0x00238974
		public FadingParticle()
		{
			if (16256 == 0)
			{
			}
			this.ColorTint = 16256;
			base..ctor();
		}

		// Token: 0x04007C98 RID: 31896
		public float FadeInNormalizedTime;

		// Token: 0x04007C99 RID: 31897
		public float FadeOutNormalizedTime = (float)16256;

		// Token: 0x04007C9A RID: 31898
		public Color ColorTint;

		// Token: 0x04007C9B RID: 31899
		private float _timeTolive;

		// Token: 0x04007C9C RID: 31900
		private float _timeSinceSpawn;
	}
}
