using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AB5 RID: 2741
	public class UIHairStyleButton : UIImageButton
	{
		// Token: 0x060050CD RID: 20685 RVA: 0x0027E66C File Offset: 0x0027C86C
		public UIHairStyleButton(Player player, int hairStyleId)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060050CE RID: 20686 RVA: 0x0027E6A0 File Offset: 0x0027C8A0
		public void SkipRenderingContent(int timeInFrames)
		{
			this._framesToSkip = timeInFrames;
		}

		// Token: 0x060050CF RID: 20687 RVA: 0x0027E6B4 File Offset: 0x0027C8B4
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
			base.DrawSelf(spriteBatch);
			Player player = this._player;
			int hairStyleId = this.HairStyleId;
			int hair = player.hair;
			Asset<Texture2D> selectedBorderTexture = this._selectedBorderTexture;
			float x = this._dimensions.X;
			Asset<Texture2D> selectedBorderTexture2 = this._selectedBorderTexture;
			if (selectedBorderTexture == null)
			{
			}
			Vector2 vector = Utils.Size(selectedBorderTexture2);
			if (selectedBorderTexture == null)
			{
			}
			if (selectedBorderTexture == null)
			{
			}
			if (this._hovered)
			{
				Asset<Texture2D> hoveredBorderTexture = this._hoveredBorderTexture;
				float x2 = this._dimensions.X;
				Asset<Texture2D> hoveredBorderTexture2 = this._hoveredBorderTexture;
				if (hoveredBorderTexture == null)
				{
				}
				Vector2 vector2 = Utils.Size(hoveredBorderTexture2);
				if (hoveredBorderTexture == null)
				{
				}
				if (hoveredBorderTexture == null)
				{
				}
			}
			int framesToSkip = this._framesToSkip;
			this._framesToSkip = framesToSkip;
		}

		// Token: 0x060050D0 RID: 20688 RVA: 0x0027E7F8 File Offset: 0x0027C9F8
		public override void LeftMouseDown(UIMouseEvent evt)
		{
			Player player = this._player;
			int hairStyleId = this.HairStyleId;
			player.hair = hairStyleId;
			base.LeftMouseDown(evt);
		}

		// Token: 0x060050D1 RID: 20689 RVA: 0x0027E824 File Offset: 0x0027CA24
		public override void MouseOver(UIMouseEvent evt)
		{
			base.MouseOver(evt);
			this._hovered = true;
		}

		// Token: 0x060050D2 RID: 20690 RVA: 0x0027E840 File Offset: 0x0027CA40
		public override void MouseOut(UIMouseEvent evt)
		{
			base.MouseOut(evt);
		}

		// Token: 0x0400898C RID: 35212
		private readonly Player _player;

		// Token: 0x0400898D RID: 35213
		public readonly int HairStyleId;

		// Token: 0x0400898E RID: 35214
		private readonly Asset<Texture2D> _selectedBorderTexture;

		// Token: 0x0400898F RID: 35215
		private readonly Asset<Texture2D> _hoveredBorderTexture;

		// Token: 0x04008990 RID: 35216
		private bool _hovered;

		// Token: 0x04008991 RID: 35217
		private bool _soundedHover;

		// Token: 0x04008992 RID: 35218
		private int _framesToSkip;
	}
}
