using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x02000759 RID: 1881
	public class RandomizedFrameParticle : ABasicParticle
	{
		// Token: 0x06003DE9 RID: 15849 RVA: 0x0023A98C File Offset: 0x00238B8C
		public override void FetchFromPool()
		{
			base.FetchFromPool();
		}

		// Token: 0x06003DEA RID: 15850 RVA: 0x0023A9A0 File Offset: 0x00238BA0
		public void SetTypeInfo(int animationFramesAmount, int gameFramesPerAnimationFrame, float timeToLive)
		{
			this.AnimationFramesAmount = animationFramesAmount;
			this._timeTolive = (float)gameFramesPerAnimationFrame;
			this.RandomizeFrame();
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x0023A9C4 File Offset: 0x00238BC4
		private void RandomizeFrame()
		{
			Asset<Texture2D> texture = this._texture;
			int animationFramesAmount = this.AnimationFramesAmount;
			if (!true)
			{
			}
			int animationFramesAmount2 = this.AnimationFramesAmount;
			long num = 0L;
			long num2 = 0L;
			long num3 = 0L;
			int num4;
			Rectangle rectangle = Utils.Frame(texture, 1, animationFramesAmount, (int)num, num4, (int)num2, (int)num3);
			this._frame = rectangle;
			this._frame.Width = 1;
			Vector2 vector = rectangle.Size();
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x0023AA24 File Offset: 0x00238C24
		public override void Update(ParticleRendererSettings settings)
		{
			base.Update(settings);
			float timeTolive = this._timeTolive;
			float timeSinceSpawn = this._timeSinceSpawn;
			this._timeSinceSpawn = timeSinceSpawn;
			int num = 1;
			this.<ShouldBeRemovedFromRenderer>k__BackingField = num != 0;
			int gameFramesCounted = this._gameFramesCounted;
			int gameFramesPerAnimationFrame = this.GameFramesPerAnimationFrame;
			this._gameFramesCounted = gameFramesCounted;
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x0023AA74 File Offset: 0x00238C74
		public override void Draw(ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
			Color colorTint = this.ColorTint;
			float fadeInNormalizedTime = this.FadeInNormalizedTime;
			float timeTolive = this._timeTolive;
			float timeSinceSpawn = this._timeSinceSpawn;
			if (!true)
			{
			}
			if (!true)
			{
			}
			float num;
			Color color = colorTint * num;
			float timeTolive2 = this._timeTolive;
			float timeSinceSpawn2 = this._timeSinceSpawn;
			float fadeOutNormalizedTime = this.FadeOutNormalizedTime;
			float x = this.LocalPosition.X;
			float y = this.LocalPosition.Y;
			Rectangle frame = this._frame;
			int width = this._frame.Width;
			float y2 = this._origin.Y;
			float rotation = this.Rotation;
			float x2 = this._origin.X;
			float x3 = this.Scale.X;
			float y3 = this.Scale.Y;
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x0023AB34 File Offset: 0x00238D34
		public RandomizedFrameParticle()
		{
			if (16256 == 0)
			{
			}
			this.ColorTint = 16256;
			base..ctor();
		}

		// Token: 0x04007CA2 RID: 31906
		public float FadeInNormalizedTime;

		// Token: 0x04007CA3 RID: 31907
		public float FadeOutNormalizedTime = (float)16256;

		// Token: 0x04007CA4 RID: 31908
		public Color ColorTint;

		// Token: 0x04007CA5 RID: 31909
		public int AnimationFramesAmount;

		// Token: 0x04007CA6 RID: 31910
		public int GameFramesPerAnimationFrame;

		// Token: 0x04007CA7 RID: 31911
		private float _timeTolive;

		// Token: 0x04007CA8 RID: 31912
		private float _timeSinceSpawn;

		// Token: 0x04007CA9 RID: 31913
		private int _gameFramesCounted;
	}
}
