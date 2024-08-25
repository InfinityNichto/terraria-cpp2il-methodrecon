using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x0200075B RID: 1883
	public class PrettySparkleParticle : ABasicParticle
	{
		// Token: 0x06003DF3 RID: 15859 RVA: 0x0023ADA4 File Offset: 0x00238FA4
		public override void FetchFromPool()
		{
			base.FetchFromPool();
			if (!true)
			{
			}
			this.FadeOutEnd = (float)16948;
			this.TimeToLive = (float)17008;
			this.Opacity = (float)1;
			this.DrawHorizontalAxis = 257 != 0;
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x0023ADE4 File Offset: 0x00238FE4
		public override void Update(ParticleRendererSettings settings)
		{
			base.Update(settings);
			float timeSinceSpawn = this._timeSinceSpawn;
			float fadeInNormalizedTime = this.FadeInNormalizedTime;
			float timeToLive = this.TimeToLive;
			if (!true)
			{
			}
			float timeSinceSpawn2 = this._timeSinceSpawn;
			float fadeOutNormalizedTime = this.FadeOutNormalizedTime;
			float timeToLive2 = this.TimeToLive;
			float timeSinceSpawn3 = this._timeSinceSpawn;
			float timeToLive3 = this.TimeToLive;
			this.Opacity = timeSinceSpawn2;
			this.<ShouldBeRemovedFromRenderer>k__BackingField = true;
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x0023AE48 File Offset: 0x00239048
		public override void Draw(ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
			if (!true)
			{
			}
			float opacity = this.Opacity;
			Color colorTint = this.ColorTint;
			float opacity2 = this.Opacity;
			float additiveAmount = this.AdditiveAmount;
			float timeSinceSpawn = this._timeSinceSpawn;
			float timeToLive = this.TimeToLive;
			float fadeInEnd = this.FadeInEnd;
			float fadeOutStart = this.FadeOutStart;
			float fadeOutEnd = this.FadeOutEnd;
			float x = this.Scale.X;
			float y = this.Scale.Y;
			float x2 = this.Scale.X;
			float y2 = this.Scale.Y;
			Color color2;
			float num;
			Color color = color2 * num;
			Vector2 anchorPosition = settings.AnchorPosition;
			float x3 = this.LocalPosition.X;
			float y3 = this.LocalPosition.Y;
			if (this.DrawHorizontalAxis)
			{
				float rotation = this.Rotation;
			}
			if (this.DrawVerticalAxis)
			{
				float rotation2 = this.Rotation;
			}
			bool drawHorizontalAxis = this.DrawHorizontalAxis;
			if (drawHorizontalAxis)
			{
				float rotation3 = this.Rotation;
				if (!drawHorizontalAxis)
				{
				}
			}
			bool drawVerticalAxis = this.DrawVerticalAxis;
			if (drawVerticalAxis)
			{
				float rotation4 = this.Rotation;
				if (!drawVerticalAxis)
				{
				}
			}
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x0023AF68 File Offset: 0x00239168
		public PrettySparkleParticle()
		{
		}

		// Token: 0x04007CB8 RID: 31928
		public float FadeInNormalizedTime;

		// Token: 0x04007CB9 RID: 31929
		public float FadeOutNormalizedTime;

		// Token: 0x04007CBA RID: 31930
		public float TimeToLive = (float)17008;

		// Token: 0x04007CBB RID: 31931
		public Color ColorTint;

		// Token: 0x04007CBC RID: 31932
		public float Opacity;

		// Token: 0x04007CBD RID: 31933
		public float AdditiveAmount;

		// Token: 0x04007CBE RID: 31934
		public float FadeInEnd;

		// Token: 0x04007CBF RID: 31935
		public float FadeOutStart;

		// Token: 0x04007CC0 RID: 31936
		public float FadeOutEnd;

		// Token: 0x04007CC1 RID: 31937
		public bool DrawHorizontalAxis = 257 != 0;

		// Token: 0x04007CC2 RID: 31938
		public bool DrawVerticalAxis;

		// Token: 0x04007CC3 RID: 31939
		private float _timeSinceSpawn;
	}
}
