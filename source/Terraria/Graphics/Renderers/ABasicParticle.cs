using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x02000756 RID: 1878
	public abstract class ABasicParticle : IPooledParticle, IParticle
	{
		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06003DD4 RID: 15828 RVA: 0x0023A498 File Offset: 0x00238698
		// (set) Token: 0x06003DD5 RID: 15829 RVA: 0x0023A4AC File Offset: 0x002386AC
		public bool ShouldBeRemovedFromRenderer
		{
			[CompilerGenerated]
			get
			{
				return this.<ShouldBeRemovedFromRenderer>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003DD6 RID: 15830 RVA: 0x0023A4BC File Offset: 0x002386BC
		public ABasicParticle()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x000021DB File Offset: 0x000003DB
		public virtual void SetBasicInfo(Asset<Texture2D> textureAsset, Rectangle? frame, Vector2 initialVelocity, Vector2 initialLocalPosition)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x0023A4E4 File Offset: 0x002386E4
		public virtual void Update(ParticleRendererSettings settings)
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
			float rotation = this.Rotation;
			float rotationVelocity = this.RotationVelocity;
			float rotationAcceleration = this.RotationAcceleration;
			this.LocalPosition.X = x3;
			this.LocalPosition.Y = y3;
			float x4 = this.ScaleVelocity.X;
			float y4 = this.ScaleVelocity.Y;
			float x5 = this.ScaleAcceleration.X;
			float y5 = this.ScaleAcceleration.Y;
			this.Rotation = rotation;
			this.RotationVelocity = rotationVelocity;
			float x6 = this.Scale.X;
			float y6 = this.Scale.Y;
			this.Scale.X = x6;
			this.Scale.Y = y6;
		}

		// Token: 0x06003DD9 RID: 15833
		public abstract void Draw(ParticleRendererSettings settings, SpriteBatch spritebatch);

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06003DDA RID: 15834 RVA: 0x0023A5F4 File Offset: 0x002387F4
		// (set) Token: 0x06003DDB RID: 15835 RVA: 0x0023A608 File Offset: 0x00238808
		public bool IsRestingInPool
		{
			[CompilerGenerated]
			get
			{
				return this.<IsRestingInPool>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x0023A618 File Offset: 0x00238818
		public void RestInPool()
		{
			this.<IsRestingInPool>k__BackingField = true;
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x0023A62C File Offset: 0x0023882C
		public virtual void FetchFromPool()
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (true)
			{
				return;
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
		}

		// Token: 0x04007C8A RID: 31882
		[CompilerGenerated]
		private bool <ShouldBeRemovedFromRenderer>k__BackingField;

		// Token: 0x04007C8B RID: 31883
		public Vector2 AccelerationPerFrame;

		// Token: 0x04007C8C RID: 31884
		public Vector2 Velocity;

		// Token: 0x04007C8D RID: 31885
		public Vector2 LocalPosition;

		// Token: 0x04007C8E RID: 31886
		protected Asset<Texture2D> _texture;

		// Token: 0x04007C8F RID: 31887
		protected Rectangle _frame;

		// Token: 0x04007C90 RID: 31888
		protected Vector2 _origin;

		// Token: 0x04007C91 RID: 31889
		public float Rotation;

		// Token: 0x04007C92 RID: 31890
		public float RotationVelocity;

		// Token: 0x04007C93 RID: 31891
		public float RotationAcceleration;

		// Token: 0x04007C94 RID: 31892
		public Vector2 Scale;

		// Token: 0x04007C95 RID: 31893
		public Vector2 ScaleVelocity;

		// Token: 0x04007C96 RID: 31894
		public Vector2 ScaleAcceleration;

		// Token: 0x04007C97 RID: 31895
		[CompilerGenerated]
		private bool <IsRestingInPool>k__BackingField;
	}
}
