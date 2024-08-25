using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x02000A7E RID: 2686
	public class ClassicPlayerResourcesDisplaySet : IPlayerResourcesDisplaySet, IConfigKeyHolder
	{
		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06004F62 RID: 20322 RVA: 0x0027A070 File Offset: 0x00278270
		// (set) Token: 0x06004F63 RID: 20323 RVA: 0x0027A084 File Offset: 0x00278284
		public string NameKey
		{
			[CompilerGenerated]
			get
			{
				return this.<NameKey>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<NameKey>k__BackingField = value;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06004F64 RID: 20324 RVA: 0x0027A098 File Offset: 0x00278298
		// (set) Token: 0x06004F65 RID: 20325 RVA: 0x0027A0AC File Offset: 0x002782AC
		public string ConfigKey
		{
			[CompilerGenerated]
			get
			{
				return this.<ConfigKey>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ConfigKey>k__BackingField = value;
			}
		}

		// Token: 0x06004F66 RID: 20326 RVA: 0x0027A0C0 File Offset: 0x002782C0
		public ClassicPlayerResourcesDisplaySet(string nameKey, string configKey)
		{
			this.NameKey = nameKey;
			this.ConfigKey = configKey;
		}

		// Token: 0x06004F67 RID: 20327 RVA: 0x0027A0E4 File Offset: 0x002782E4
		public void Draw()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int screenWidth = Main.screenWidth;
			this.UI_ScreenAnchorX = num;
			this.DrawLife();
			this.DrawMana();
		}

		// Token: 0x06004F68 RID: 20328 RVA: 0x0027A114 File Offset: 0x00278314
		private void DrawLife()
		{
			if (!true)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			int num = 16800;
			this.UIDisplay_LifePerHeart = (float)num;
			if (!localPlayer.ghost)
			{
				return;
			}
		}

		// Token: 0x06004F69 RID: 20329 RVA: 0x0027A248 File Offset: 0x00278448
		private void DrawMana()
		{
			if (!true)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			int num = 20;
			this.UIDisplay_ManaPerStar = num;
			if (num != 0)
			{
				return;
			}
			if (localPlayer.statManaMax2 == 0)
			{
			}
		}

		// Token: 0x06004F6A RID: 20330 RVA: 0x0027A2E8 File Offset: 0x002784E8
		public void TryToHover()
		{
			if (!true)
			{
			}
			Vector2 mouseScreen = Main.MouseScreen;
			Player localPlayer = Main.LocalPlayer;
			int ui_ScreenAnchorX = this.UI_ScreenAnchorX;
			float uidisplay_LifePerHeart = this.UIDisplay_LifePerHeart;
			int statLifeMax = localPlayer.statLifeMax2;
			int num = 16896;
			if (ui_ScreenAnchorX == 0)
			{
			}
			if (num == 0)
			{
			}
			CommonResourceBarMethods.DrawLifeMouseOver();
			int ui_ScreenAnchorX2 = this.UI_ScreenAnchorX;
			int statManaMax = localPlayer.statManaMax2;
			int uidisplay_ManaPerStar = this.UIDisplay_ManaPerStar;
			CommonResourceBarMethods.DrawManaMouseOver();
		}

		// Token: 0x0400884D RID: 34893
		private int UIDisplay_ManaPerStar;

		// Token: 0x0400884E RID: 34894
		private float UIDisplay_LifePerHeart;

		// Token: 0x0400884F RID: 34895
		private int UI_ScreenAnchorX;

		// Token: 0x04008850 RID: 34896
		[CompilerGenerated]
		private string <NameKey>k__BackingField;

		// Token: 0x04008851 RID: 34897
		[CompilerGenerated]
		private string <ConfigKey>k__BackingField;
	}
}
