using System;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Effects
{
	// Token: 0x02000785 RID: 1925
	public abstract class GameEffect
	{
		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06003F04 RID: 16132 RVA: 0x0023F920 File Offset: 0x0023DB20
		public bool IsLoaded
		{
			get
			{
				return this._isLoaded;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06003F05 RID: 16133 RVA: 0x0023F934 File Offset: 0x0023DB34
		public EffectPriority Priority
		{
			get
			{
				return this._priority;
			}
		}

		// Token: 0x06003F06 RID: 16134 RVA: 0x0023F948 File Offset: 0x0023DB48
		public void Load()
		{
			if (this._isLoaded)
			{
				return;
			}
			this._isLoaded = true;
		}

		// Token: 0x06003F07 RID: 16135 RVA: 0x0023F968 File Offset: 0x0023DB68
		public virtual void OnLoad()
		{
		}

		// Token: 0x06003F08 RID: 16136
		public abstract bool IsVisible();

		// Token: 0x06003F09 RID: 16137
		public abstract void Activate(Vector2 position, params object[] args);

		// Token: 0x06003F0A RID: 16138
		public abstract void Deactivate(params object[] args);

		// Token: 0x06003F0B RID: 16139 RVA: 0x0023F978 File Offset: 0x0023DB78
		protected GameEffect()
		{
		}

		// Token: 0x04007D84 RID: 32132
		public float Opacity;

		// Token: 0x04007D85 RID: 32133
		protected bool _isLoaded;

		// Token: 0x04007D86 RID: 32134
		protected EffectPriority _priority;
	}
}
