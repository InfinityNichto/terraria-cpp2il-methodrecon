using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Achievements;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000A93 RID: 2707
	public class UIAchievementListItem : UIPanel
	{
		// Token: 0x06004FEB RID: 20459 RVA: 0x0027BAD8 File Offset: 0x00279CD8
		public UIAchievementListItem(Achievement achievement, bool largeForOtherLanguages)
		{
			int num = 1;
			base..ctor();
			if (num == 0)
			{
			}
			Color color;
			this.BackgroundColor = color;
			Color color2;
			this.BorderColor = color2;
			bool large = this._large;
			int num2 = true.ToInt();
			int num3 = this._large.ToInt();
			int num4 = this._large.ToInt();
			this._achievement = achievement;
			AchievementManager achievements = Main.Achievements;
			string name = achievement.Name;
			int iconIndex = achievements.GetIconIndex(name);
			this._iconIndex = iconIndex;
			Rectangle iconFrameLocked = this._iconFrameLocked;
			this._iconFrameLocked = iconFrameLocked;
			this.UpdateIconFrame();
			if (iconFrameLocked != null)
			{
			}
		}

		// Token: 0x06004FEC RID: 20460 RVA: 0x000021DB File Offset: 0x000003DB
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004FED RID: 20461 RVA: 0x0027BBF4 File Offset: 0x00279DF4
		private void UpdateIconFrame()
		{
			bool locked = this._locked;
			if (this._achievementIcon != null)
			{
				bool value = locked.m_value;
				return;
			}
		}

		// Token: 0x06004FEE RID: 20462 RVA: 0x0027BC18 File Offset: 0x00279E18
		private void DrawPanelTop(SpriteBatch spriteBatch, Vector2 position, float width, Color color)
		{
			Asset<Texture2D> innerPanelTopTexture = this._innerPanelTopTexture;
			if (!true)
			{
			}
			int num = Utils.Height(innerPanelTopTexture);
			Asset<Texture2D> innerPanelTopTexture2 = this._innerPanelTopTexture;
			int num2 = Utils.Height(this._innerPanelTopTexture);
			if (innerPanelTopTexture2 == null)
			{
			}
			if (!true)
			{
			}
			Asset<Texture2D> innerPanelTopTexture3 = this._innerPanelTopTexture;
			int num3 = Utils.Height(this._innerPanelTopTexture);
		}

		// Token: 0x06004FEF RID: 20463 RVA: 0x0027BC74 File Offset: 0x00279E74
		private void DrawPanelBottom(SpriteBatch spriteBatch, Vector2 position, float width, Color color)
		{
			Asset<Texture2D> innerPanelBottomTexture = this._innerPanelBottomTexture;
			if (!true)
			{
			}
			int num = Utils.Height(innerPanelBottomTexture);
			Asset<Texture2D> innerPanelBottomTexture2 = this._innerPanelBottomTexture;
			int num2 = Utils.Height(this._innerPanelBottomTexture);
			if (innerPanelBottomTexture2 == null)
			{
			}
			if (!true)
			{
			}
			Asset<Texture2D> innerPanelBottomTexture3 = this._innerPanelBottomTexture;
			int num3 = Utils.Height(this._innerPanelBottomTexture);
		}

		// Token: 0x06004FF0 RID: 20464 RVA: 0x0027BCD0 File Offset: 0x00279ED0
		public override void MouseOver(UIMouseEvent evt)
		{
			base.MouseOver(evt);
		}

		// Token: 0x06004FF1 RID: 20465 RVA: 0x0027BCE4 File Offset: 0x00279EE4
		public override void MouseOut(UIMouseEvent evt)
		{
			base.MouseOut(evt);
			if (!true)
			{
			}
			Color color;
			this.BackgroundColor = color;
			Color color2;
			this.BorderColor = color2;
		}

		// Token: 0x06004FF2 RID: 20466 RVA: 0x0027BD0C File Offset: 0x00279F0C
		public Achievement GetAchievement()
		{
			return this._achievement;
		}

		// Token: 0x06004FF3 RID: 20467 RVA: 0x0027BD20 File Offset: 0x00279F20
		private Tuple<decimal, decimal> GetTrackerValues()
		{
			bool hasTracker = this._achievement.HasTracker;
			if (this._achievement._tracker != null)
			{
			}
			long num = 0L;
			decimal num2 = 1073741824;
			long value = num.m_value;
			if (num != 0L)
			{
				if (value == 0L)
				{
				}
				long value2 = value.m_value;
			}
			if (num != 0L)
			{
			}
			Tuple tuple;
			return tuple;
		}

		// Token: 0x06004FF4 RID: 20468 RVA: 0x0027BD7C File Offset: 0x00279F7C
		private void DrawProgressBar(SpriteBatch spriteBatch, float progress, Vector2 spot, float Width = 169f, [Optional] Color BackColor, [Optional] Color FillingColor, [Optional] Color BlipColor)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			int value = num.m_value;
			if (!true)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value2 = num2.m_value;
			if (!true)
			{
			}
			int num3 = 1;
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
		}

		// Token: 0x06004FF5 RID: 20469 RVA: 0x0027BE5C File Offset: 0x0027A05C
		public override int CompareTo(object obj)
		{
			if (obj != null)
			{
			}
			bool isCompleted = this._achievement.IsCompleted;
			bool isCompleted2 = this._achievement.IsCompleted;
			return 1;
		}

		// Token: 0x040088CE RID: 35022
		private Achievement _achievement;

		// Token: 0x040088CF RID: 35023
		private UIImageFramed _achievementIcon;

		// Token: 0x040088D0 RID: 35024
		private UIImage _achievementIconBorders;

		// Token: 0x040088D1 RID: 35025
		private const int _iconSize = 64;

		// Token: 0x040088D2 RID: 35026
		private const int _iconSizeWithSpace = 66;

		// Token: 0x040088D3 RID: 35027
		private const int _iconsPerRow = 8;

		// Token: 0x040088D4 RID: 35028
		private int _iconIndex;

		// Token: 0x040088D5 RID: 35029
		private Rectangle _iconFrame;

		// Token: 0x040088D6 RID: 35030
		private Rectangle _iconFrameUnlocked;

		// Token: 0x040088D7 RID: 35031
		private Rectangle _iconFrameLocked;

		// Token: 0x040088D8 RID: 35032
		private Asset<Texture2D> _innerPanelTopTexture;

		// Token: 0x040088D9 RID: 35033
		private Asset<Texture2D> _innerPanelBottomTexture;

		// Token: 0x040088DA RID: 35034
		private Asset<Texture2D> _categoryTexture;

		// Token: 0x040088DB RID: 35035
		private bool _locked;

		// Token: 0x040088DC RID: 35036
		private bool _large;
	}
}
