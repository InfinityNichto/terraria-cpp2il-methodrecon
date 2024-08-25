using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x02000753 RID: 1875
	public class LittleFlyingCritterParticle : IPooledParticle, IParticle
	{
		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06003DBA RID: 15802 RVA: 0x00239E80 File Offset: 0x00238080
		// (set) Token: 0x06003DBB RID: 15803 RVA: 0x00239E94 File Offset: 0x00238094
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

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06003DBC RID: 15804 RVA: 0x00239EA4 File Offset: 0x002380A4
		// (set) Token: 0x06003DBD RID: 15805 RVA: 0x00239EB8 File Offset: 0x002380B8
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

		// Token: 0x06003DBE RID: 15806 RVA: 0x00239EC8 File Offset: 0x002380C8
		public LittleFlyingCritterParticle()
		{
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x00239EDC File Offset: 0x002380DC
		public void Prepare(Vector2 position, int duration)
		{
			if (!true)
			{
			}
			this.RandomizeVelocity();
			int num = 60;
			this._lifeTimeTotal = num;
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x00239F04 File Offset: 0x00238104
		private void RandomizeVelocity()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x00239F14 File Offset: 0x00238114
		public void RestInPool()
		{
			this.<IsRestingInPool>k__BackingField = true;
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x00239F28 File Offset: 0x00238128
		public virtual void FetchFromPool()
		{
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x00239F38 File Offset: 0x00238138
		public void Update(ParticleRendererSettings settings)
		{
			int lifeTimeCounted = this._lifeTimeCounted;
			bool flag = this.<IsRestingInPool>k__BackingField;
			this._lifeTimeCounted = lifeTimeCounted;
			int num = 1;
			this.<ShouldBeRemovedFromRenderer>k__BackingField = num != 0;
			float x = this._velocity.X;
			float y = this._velocity.Y;
			float x2 = this._spawnPosition.X;
			float x3 = this._localPosition.X;
			float y2 = this._spawnPosition.Y;
			float y3 = this._localPosition.Y;
			this._velocity.X = y2;
			int num2;
			if (num2 == 0)
			{
				this.RandomizeVelocity();
				int num3;
				if (num3 == 0)
				{
					float x4 = this._velocity.X;
					float y4 = this._velocity.Y;
					this._velocity.X = y2;
				}
			}
			float x5 = this._localPosition.X;
			float y5 = this._localPosition.Y;
			float x6 = this._velocity.X;
			float y6 = this._velocity.Y;
			float neverGoBelowThis = this._neverGoBelowThis;
			this._localPosition.X = y2;
			float y7 = this._velocity.Y;
			this._localPosition.Y = neverGoBelowThis;
			this._velocity.Y = y7;
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x0023A078 File Offset: 0x00238278
		public void Draw(ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
			int num = 1;
			Vector2 anchorPosition = settings.AnchorPosition;
			float x = this._localPosition.X;
			float y = this._localPosition.Y;
			if (num == 0)
			{
			}
			int num2 = 1;
			this.<ShouldBeRemovedFromRenderer>k__BackingField = num2 != 0;
		}

		// Token: 0x04007C6F RID: 31855
		private int _lifeTimeCounted;

		// Token: 0x04007C70 RID: 31856
		private int _lifeTimeTotal;

		// Token: 0x04007C71 RID: 31857
		[CompilerGenerated]
		private bool <IsRestingInPool>k__BackingField;

		// Token: 0x04007C72 RID: 31858
		[CompilerGenerated]
		private bool <ShouldBeRemovedFromRenderer>k__BackingField;

		// Token: 0x04007C73 RID: 31859
		private Vector2 _spawnPosition;

		// Token: 0x04007C74 RID: 31860
		private Vector2 _localPosition;

		// Token: 0x04007C75 RID: 31861
		private Vector2 _velocity;

		// Token: 0x04007C76 RID: 31862
		private float _neverGoBelowThis;
	}
}
