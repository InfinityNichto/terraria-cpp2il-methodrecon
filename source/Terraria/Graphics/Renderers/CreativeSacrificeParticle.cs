using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x02000755 RID: 1877
	public class CreativeSacrificeParticle : IParticle
	{
		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06003DCF RID: 15823 RVA: 0x0023A2EC File Offset: 0x002384EC
		// (set) Token: 0x06003DD0 RID: 15824 RVA: 0x0023A300 File Offset: 0x00238500
		public bool ShouldBeRemovedFromRenderer
		{
			[CompilerGenerated]
			get
			{
				return this.<ShouldBeRemovedFromRenderer>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x0023A310 File Offset: 0x00238510
		public CreativeSacrificeParticle(Asset<Texture2D> textureAsset, Rectangle? frame, Vector2 initialVelocity, Vector2 initialLocalPosition)
		{
			this._texture = textureAsset;
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x0023A36C File Offset: 0x0023856C
		public void Update(ParticleRendererSettings settings)
		{
			float x = this.Velocity.X;
			float y = this.Velocity.Y;
			float x2 = this.AccelerationPerFrame.X;
			float y2 = this.AccelerationPerFrame.Y;
			if (!true)
			{
			}
			float x3 = this.LocalPosition.X;
			float y3 = this.LocalPosition.Y;
			float scale = this._scale;
			float scaleOffsetPerFrame = this.ScaleOffsetPerFrame;
			float stopWhenBelowXScale = this.StopWhenBelowXScale;
			this.LocalPosition.X = x3;
			this.LocalPosition.Y = y3;
			this._scale = x3;
			this.<ShouldBeRemovedFromRenderer>k__BackingField = true;
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x0023A410 File Offset: 0x00238610
		public void Draw(ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
			if (!true)
			{
			}
			float scale = this._scale;
			if (!true)
			{
			}
			Asset<Texture2D> texture = this._texture;
			Vector2 anchorPosition = settings.AnchorPosition;
			float x = this.LocalPosition.X;
			float y = this.LocalPosition.Y;
			if (texture == null)
			{
			}
			Rectangle frame = this._frame;
			int width = this._frame.Width;
			float x2 = this._origin.X;
			float y2 = this._origin.Y;
			float scale2 = this._scale;
		}

		// Token: 0x04007C80 RID: 31872
		[CompilerGenerated]
		private bool <ShouldBeRemovedFromRenderer>k__BackingField;

		// Token: 0x04007C81 RID: 31873
		public Vector2 AccelerationPerFrame;

		// Token: 0x04007C82 RID: 31874
		public Vector2 Velocity;

		// Token: 0x04007C83 RID: 31875
		public Vector2 LocalPosition;

		// Token: 0x04007C84 RID: 31876
		public float ScaleOffsetPerFrame;

		// Token: 0x04007C85 RID: 31877
		public float StopWhenBelowXScale;

		// Token: 0x04007C86 RID: 31878
		private Asset<Texture2D> _texture;

		// Token: 0x04007C87 RID: 31879
		private Rectangle _frame;

		// Token: 0x04007C88 RID: 31880
		private Vector2 _origin;

		// Token: 0x04007C89 RID: 31881
		private float _scale;
	}
}
