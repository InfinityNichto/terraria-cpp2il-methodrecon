using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x02000754 RID: 1876
	public class ItemTransferParticle : IPooledParticle, IParticle
	{
		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06003DC5 RID: 15813 RVA: 0x0023A16C File Offset: 0x0023836C
		// (set) Token: 0x06003DC6 RID: 15814 RVA: 0x0023A180 File Offset: 0x00238380
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

		// Token: 0x06003DC7 RID: 15815 RVA: 0x0023A190 File Offset: 0x00238390
		public ItemTransferParticle()
		{
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x0023A1A4 File Offset: 0x002383A4
		public void Update(ParticleRendererSettings settings)
		{
			int lifeTimeCounted = this._lifeTimeCounted;
			bool flag = this.<IsRestingInPool>k__BackingField;
			this._lifeTimeCounted = lifeTimeCounted;
			int num = 1;
			this.<ShouldBeRemovedFromRenderer>k__BackingField = num != 0;
		}

		// Token: 0x06003DC9 RID: 15817 RVA: 0x0023A1D0 File Offset: 0x002383D0
		public void Prepare(int itemType, int lifeTimeTotal, Vector2 playerPosition, Vector2 chestPosition)
		{
			this._itemInstance.SetDefaults(itemType);
			this._lifeTimeTotal = lifeTimeTotal;
			if (!true)
			{
			}
			if (!true)
			{
			}
			int num;
			if (num == 0)
			{
			}
			float x = this.EndPosition.X;
			float y = this.EndPosition.Y;
			float x2 = this.StartPosition.X;
			float y2 = this.StartPosition.Y;
		}

		// Token: 0x06003DCA RID: 15818 RVA: 0x0023A24C File Offset: 0x0023844C
		public void Draw(ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
			int num = 1;
			int lifeTimeCounted = this._lifeTimeCounted;
			int lifeTimeTotal = this._lifeTimeTotal;
			if (num == 0)
			{
			}
			Item itemInstance = this._itemInstance;
			Vector2 anchorPosition = settings.AnchorPosition;
			float scale = this._itemInstance.scale;
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06003DCB RID: 15819 RVA: 0x0023A2A0 File Offset: 0x002384A0
		// (set) Token: 0x06003DCC RID: 15820 RVA: 0x0023A2B4 File Offset: 0x002384B4
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

		// Token: 0x06003DCD RID: 15821 RVA: 0x0023A2C4 File Offset: 0x002384C4
		public void RestInPool()
		{
			this.<IsRestingInPool>k__BackingField = true;
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x0023A2D8 File Offset: 0x002384D8
		public virtual void FetchFromPool()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x04007C77 RID: 31863
		[CompilerGenerated]
		private bool <ShouldBeRemovedFromRenderer>k__BackingField;

		// Token: 0x04007C78 RID: 31864
		public Vector2 StartPosition;

		// Token: 0x04007C79 RID: 31865
		public Vector2 EndPosition;

		// Token: 0x04007C7A RID: 31866
		public Vector2 BezierHelper1;

		// Token: 0x04007C7B RID: 31867
		public Vector2 BezierHelper2;

		// Token: 0x04007C7C RID: 31868
		private Item _itemInstance;

		// Token: 0x04007C7D RID: 31869
		private int _lifeTimeCounted;

		// Token: 0x04007C7E RID: 31870
		private int _lifeTimeTotal;

		// Token: 0x04007C7F RID: 31871
		[CompilerGenerated]
		private bool <IsRestingInPool>k__BackingField;
	}
}
