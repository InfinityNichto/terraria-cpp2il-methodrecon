using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000ACF RID: 2767
	internal class UITextBox : UITextPanel<string>
	{
		// Token: 0x06005175 RID: 20853 RVA: 0x002807F8 File Offset: 0x0027E9F8
		public UITextBox(string text, float textScale = 1f, bool large = false)
		{
		}

		// Token: 0x06005176 RID: 20854 RVA: 0x00280814 File Offset: 0x0027EA14
		public void Write(string text)
		{
			string text2 = base.Text;
			int cursor = this._cursor;
			string text3 = text2.Insert(cursor, text);
			int cursor2 = this._cursor;
			int stringLength = text._stringLength;
			this._cursor = cursor2;
		}

		// Token: 0x06005177 RID: 20855 RVA: 0x00280850 File Offset: 0x0027EA50
		public override void SetText(string text, float textScale, bool large)
		{
			int maxLength = this._maxLength;
			int stringLength = text._stringLength;
			long num = 0L;
			string text2 = text.Substring((int)num, maxLength);
			string text3 = base.Text;
			int stringLength2 = text3._stringLength;
			int cursor = this._cursor;
			if (text3 == null)
			{
			}
			int num2 = Math.Min(stringLength2, cursor);
			this._cursor = num2;
		}

		// Token: 0x06005178 RID: 20856 RVA: 0x002808A8 File Offset: 0x0027EAA8
		public void SetTextMaxLength(int maxLength)
		{
			this._maxLength = maxLength;
		}

		// Token: 0x06005179 RID: 20857 RVA: 0x002808BC File Offset: 0x0027EABC
		public void Backspace()
		{
			if (this._cursor != 0)
			{
				string text = base.Text;
				int stringLength = base.Text._stringLength;
				return;
			}
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x002808E8 File Offset: 0x0027EAE8
		public void CursorLeft()
		{
			int cursor = this._cursor;
			if (cursor != 0)
			{
				this._cursor = cursor;
			}
		}

		// Token: 0x0600517B RID: 20859 RVA: 0x00280908 File Offset: 0x0027EB08
		public void CursorRight()
		{
			int cursor = this._cursor;
			int stringLength = base.Text._stringLength;
			int cursor2 = this._cursor;
			this._cursor = cursor2;
		}

		// Token: 0x0600517C RID: 20860 RVA: 0x00280938 File Offset: 0x0027EB38
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			if (!this.HideSelf)
			{
				int stringLength = base.Text._stringLength;
				this._cursor = stringLength;
				base.DrawSelf(spriteBatch);
				int frameCount = this._frameCount;
				this._frameCount = frameCount;
				bool showInputTicker = this.ShowInputTicker;
				if (showInputTicker)
				{
					float x = this._innerDimensions.X;
					if (!showInputTicker)
					{
					}
					string text = base.Text;
					int cursor = this._cursor;
					long num = 0L;
					string text2 = text.Substring((int)num, cursor);
					if (!showInputTicker)
					{
					}
					if (!showInputTicker)
					{
					}
					return;
				}
			}
		}

		// Token: 0x040089FB RID: 35323
		private int _cursor;

		// Token: 0x040089FC RID: 35324
		private int _frameCount;

		// Token: 0x040089FD RID: 35325
		private int _maxLength = 20;

		// Token: 0x040089FE RID: 35326
		public bool ShowInputTicker = true;

		// Token: 0x040089FF RID: 35327
		public bool HideSelf;
	}
}
