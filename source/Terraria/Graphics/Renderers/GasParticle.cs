using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x0200075A RID: 1882
	public class GasParticle : ABasicParticle
	{
		// Token: 0x06003DEF RID: 15855 RVA: 0x0023AB64 File Offset: 0x00238D64
		public override void FetchFromPool()
		{
			base.FetchFromPool();
			if (!true)
			{
			}
			this.TimeToLive = (float)17056;
			this.ColorTint = 1;
			if (!true)
			{
			}
			int num;
			this._internalIndentifier = num;
			this.SlowdownScalar = (float)13107;
			this.InitialScale = (float)16256;
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x0023ABAC File Offset: 0x00238DAC
		public override void Update(ParticleRendererSettings settings)
		{
			base.Update(settings);
			float timeSinceSpawn = this._timeSinceSpawn;
			float timeToLive = this.TimeToLive;
			if (!true)
			{
			}
			if (!true)
			{
			}
			float initialScale = this.InitialScale;
			if (!true)
			{
			}
			float fadeInNormalizedTime = this.FadeInNormalizedTime;
			this.Scale.X = timeSinceSpawn;
			float fadeOutNormalizedTime = this.FadeOutNormalizedTime;
			float slowdownScalar = this.SlowdownScalar;
			float timeSinceSpawn2 = this._timeSinceSpawn;
			int internalIndentifier = this._internalIndentifier;
			this.Opacity = timeSinceSpawn;
			float x = this.Velocity.X;
			float y = this.Velocity.Y;
			this.Rotation = (float)internalIndentifier;
			this.Velocity.X = x;
			this.Velocity.Y = y;
			Color lightColorTint = this.LightColorTint;
			if (17392 == 0)
			{
			}
			Color lightColorTint2 = this.LightColorTint;
			float opacity = this.Opacity;
			if (17392 == 0)
			{
			}
			float num;
			Color color = lightColorTint2 * num;
			float x2 = this.LocalPosition.X;
			float y2 = this.LocalPosition.Y;
			float timeSinceSpawn3 = this._timeSinceSpawn;
			float timeToLive2 = this.TimeToLive;
			this.<ShouldBeRemovedFromRenderer>k__BackingField = true;
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x0023ACC8 File Offset: 0x00238EC8
		public override void Draw(ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Vector2 anchorPosition = settings.AnchorPosition;
			float x = this.LocalPosition.X;
			float y = this.LocalPosition.Y;
			if (!true)
			{
			}
			float x2 = this.LocalPosition.X;
			float y2 = this.LocalPosition.Y;
			if (!true)
			{
			}
			Point point;
			Color color = Lighting.GetColor(point);
			Color colorTint = this.ColorTint;
			float opacity = this.Opacity;
			float x3 = this.Scale.X;
			float y3 = this.Scale.Y;
			float rotation = this.Rotation;
			float opacity2 = this.Opacity;
			float rotation2 = this.Rotation;
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x0023AD70 File Offset: 0x00238F70
		public GasParticle()
		{
		}

		// Token: 0x04007CAA RID: 31914
		public float FadeInNormalizedTime;

		// Token: 0x04007CAB RID: 31915
		public float FadeOutNormalizedTime;

		// Token: 0x04007CAC RID: 31916
		public float TimeToLive = (float)17056;

		// Token: 0x04007CAD RID: 31917
		public Color ColorTint;

		// Token: 0x04007CAE RID: 31918
		public float Opacity;

		// Token: 0x04007CAF RID: 31919
		public float AdditiveAmount;

		// Token: 0x04007CB0 RID: 31920
		public float FadeInEnd;

		// Token: 0x04007CB1 RID: 31921
		public float FadeOutStart;

		// Token: 0x04007CB2 RID: 31922
		public float FadeOutEnd;

		// Token: 0x04007CB3 RID: 31923
		public float SlowdownScalar = (float)13107;

		// Token: 0x04007CB4 RID: 31924
		private float _timeSinceSpawn;

		// Token: 0x04007CB5 RID: 31925
		public Color LightColorTint;

		// Token: 0x04007CB6 RID: 31926
		private int _internalIndentifier;

		// Token: 0x04007CB7 RID: 31927
		public float InitialScale = (float)16256;
	}
}
