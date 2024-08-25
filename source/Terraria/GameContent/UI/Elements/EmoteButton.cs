using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000A8E RID: 2702
	public class EmoteButton : UIElement
	{
		// Token: 0x06004FD2 RID: 20434 RVA: 0x0027B754 File Offset: 0x00279954
		public EmoteButton(int emoteIndex)
		{
			int num = 1;
			if (num == 0)
			{
			}
			base..ctor();
			if (num == 0)
			{
			}
			string text2;
			string text = "Images/Extra_" + text2;
		}

		// Token: 0x06004FD3 RID: 20435 RVA: 0x0027B78C File Offset: 0x0027998C
		private Rectangle GetFrame()
		{
			int frameCounter = this._frameCounter;
			Asset<Texture2D> texture = this._texture;
			int emoteIndex = this._emoteIndex;
			if (frameCounter == 0)
			{
			}
			Rectangle rectangle;
			return rectangle;
		}

		// Token: 0x06004FD4 RID: 20436 RVA: 0x0027B7B4 File Offset: 0x002799B4
		private void UpdateFrame()
		{
		}

		// Token: 0x06004FD5 RID: 20437 RVA: 0x0027B7C4 File Offset: 0x002799C4
		public override void Update(GameTime gameTime)
		{
			int frameCounter = this._frameCounter;
			this._frameCounter = frameCounter;
			base.Update(gameTime);
		}

		// Token: 0x06004FD6 RID: 20438 RVA: 0x0027B7E8 File Offset: 0x002799E8
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Rectangle frame = this.GetFrame();
			Asset<Texture2D> texture = this._texture;
			if (num == 0)
			{
			}
			int num2 = Utils.Width(texture);
			Vector2 vector = frame.Size();
			if (num == 0)
			{
			}
			bool hovered = this._hovered;
			if (hovered)
			{
				if (num == 0)
				{
				}
				return;
			}
			Asset<Texture2D> texture2 = this._texture;
			Asset<Texture2D> texture3 = this._texture;
			Asset<Texture2D> textureBorder = this._textureBorder;
			if (!hovered)
			{
			}
			if (!true)
			{
			}
			bool hovered2 = this._hovered;
			if (hovered2)
			{
				if (!hovered2)
				{
				}
				int emoteIndex = this._emoteIndex;
				string text;
				string textValue = Language.GetTextValue("EmojiName." + text);
				string text2 = "/" + textValue;
				if (!hovered)
				{
				}
			}
		}

		// Token: 0x06004FD7 RID: 20439 RVA: 0x0027B89C File Offset: 0x00279A9C
		public override void MouseOver(UIMouseEvent evt)
		{
			base.MouseOver(evt);
			this._hovered = true;
		}

		// Token: 0x06004FD8 RID: 20440 RVA: 0x0027B8B8 File Offset: 0x00279AB8
		public override void MouseOut(UIMouseEvent evt)
		{
			base.MouseOut(evt);
		}

		// Token: 0x06004FD9 RID: 20441 RVA: 0x0027B8CC File Offset: 0x00279ACC
		public override void LeftClick(UIMouseEvent evt)
		{
			base.LeftClick(evt);
			if (!true)
			{
			}
			int myPlayer;
			if (true)
			{
				if (!true)
				{
				}
				myPlayer = Main.myPlayer;
				int emoteIndex = this._emoteIndex;
				return;
			}
			Player localPlayer = Main.LocalPlayer;
			Player localPlayer2 = Main.LocalPlayer;
			EmoteBubble.CheckForNPCsToReactToEmoteBubble(myPlayer, localPlayer2);
			IngameFancyUI.Close();
		}

		// Token: 0x040088AC RID: 34988
		private Asset<Texture2D> _texture;

		// Token: 0x040088AD RID: 34989
		private Asset<Texture2D> _textureBorder;

		// Token: 0x040088AE RID: 34990
		private int _emoteIndex;

		// Token: 0x040088AF RID: 34991
		private bool _hovered;

		// Token: 0x040088B0 RID: 34992
		private int _frameCounter;
	}
}
