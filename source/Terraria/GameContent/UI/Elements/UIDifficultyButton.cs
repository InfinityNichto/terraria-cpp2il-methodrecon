using System;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AB3 RID: 2739
	public class UIDifficultyButton : UIElement
	{
		// Token: 0x060050C2 RID: 20674 RVA: 0x0027E31C File Offset: 0x0027C51C
		public UIDifficultyButton(Player player, LocalizedText title, LocalizedText description, byte difficulty, Color color)
		{
			int num = 1;
			if (num == 0)
			{
			}
			base..ctor();
			this._player = player;
			this._difficulty = difficulty;
			if (num == 0)
			{
			}
			if (17116 == 0)
			{
			}
		}

		// Token: 0x060050C3 RID: 20675 RVA: 0x0027E388 File Offset: 0x0027C588
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			if (!this._hovered)
			{
				return;
			}
			if (this._soundedHover)
			{
				return;
			}
			int num = 1;
			this._soundedHover = num != 0;
			Player player = this._player;
			Asset<Texture2D> basePanelTexture = this._BasePanelTexture;
			float height = this._dimensions.Height;
			float x = this._dimensions.X;
			float y = this._dimensions.Y;
			float width = this._dimensions.Width;
			byte difficulty = this._difficulty;
			byte difficulty2 = player.difficulty;
			if (player == null)
			{
			}
			if (player == null)
			{
			}
			int num2 = 32640;
			int num3 = 32768;
			if (this._BasePanelTexture == null)
			{
			}
			if (num2 == 0)
			{
			}
			if (this._hovered)
			{
				Asset<Texture2D> hoveredBorderTexture = this._hoveredBorderTexture;
				if (num2 == 0)
				{
				}
				if (num3 == 0)
				{
				}
			}
		}

		// Token: 0x060050C4 RID: 20676 RVA: 0x0027E440 File Offset: 0x0027C640
		public override void LeftMouseDown(UIMouseEvent evt)
		{
			Player player = this._player;
			byte difficulty = this._difficulty;
			player.difficulty = difficulty;
			base.LeftMouseDown(evt);
		}

		// Token: 0x060050C5 RID: 20677 RVA: 0x0027E46C File Offset: 0x0027C66C
		public override void MouseOver(UIMouseEvent evt)
		{
			base.MouseOver(evt);
			this._hovered = true;
		}

		// Token: 0x060050C6 RID: 20678 RVA: 0x0027E488 File Offset: 0x0027C688
		public override void MouseOut(UIMouseEvent evt)
		{
			base.MouseOut(evt);
		}

		// Token: 0x0400897B RID: 35195
		private readonly Player _player;

		// Token: 0x0400897C RID: 35196
		private readonly Asset<Texture2D> _BasePanelTexture;

		// Token: 0x0400897D RID: 35197
		private readonly Asset<Texture2D> _selectedBorderTexture;

		// Token: 0x0400897E RID: 35198
		private readonly Asset<Texture2D> _hoveredBorderTexture;

		// Token: 0x0400897F RID: 35199
		private readonly byte _difficulty;

		// Token: 0x04008980 RID: 35200
		private readonly Color _color;

		// Token: 0x04008981 RID: 35201
		private bool _hovered;

		// Token: 0x04008982 RID: 35202
		private bool _soundedHover;
	}
}
