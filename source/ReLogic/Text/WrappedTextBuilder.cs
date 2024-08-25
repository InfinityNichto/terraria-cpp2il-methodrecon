using System;
using System.Globalization;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace ReLogic.Text
{
	// Token: 0x02000B18 RID: 2840
	public class WrappedTextBuilder
	{
		// Token: 0x06005321 RID: 21281 RVA: 0x00283FEC File Offset: 0x002821EC
		public WrappedTextBuilder(SpriteFont font, float maxWidth, CultureInfo culture)
		{
			this._font = font;
			this._culture = culture;
		}

		// Token: 0x06005322 RID: 21282 RVA: 0x00284010 File Offset: 0x00282210
		public void CommitWorkingLine()
		{
			if (this._completedText.Length != 0)
			{
				StringBuilder completedText = this._completedText;
			}
			StringBuilder completedText2 = this._completedText;
			StringBuilder workingLine = this._workingLine;
			StringBuilder stringBuilder = completedText2.Append(workingLine);
			StringBuilder stringBuilder2 = this._workingLine.Clear();
		}

		// Token: 0x06005323 RID: 21283 RVA: 0x00284058 File Offset: 0x00282258
		private void Append(WrappedTextBuilder.NonBreakingText textToken)
		{
			if (this._workingLine.Length != 0)
			{
				SpriteFont font = this._font;
				float workingLineWidth = this._workingLineWidth;
				float width = textToken.Width;
				float widthOnNewLine = textToken.WidthOnNewLine;
				float <Spacing>k__BackingField = font.<Spacing>k__BackingField;
				return;
			}
			float widthOnNewLine2 = textToken.WidthOnNewLine;
			float maxWidth = this._maxWidth;
			if (this._workingLine.Length != 0)
			{
				this.CommitWorkingLine();
			}
			float maxWidth2 = this._maxWidth;
			string text;
			this.Append(text);
		}

		// Token: 0x06005324 RID: 21284 RVA: 0x00284120 File Offset: 0x00282320
		public void Append(string text)
		{
			StringBuilder completedText = this._completedText;
			long num = 0L;
			int capacity = completedText.Capacity;
			int stringLength = text._stringLength;
			int num2 = completedText.EnsureCapacity((int)num);
			this.CommitWorkingLine();
		}

		// Token: 0x06005325 RID: 21285 RVA: 0x00284164 File Offset: 0x00282364
		public override string ToString()
		{
			if (this._completedText.Length != 0)
			{
				StringBuilder completedText = this._completedText;
				if (this._workingLine != null)
				{
				}
			}
			string text;
			return text;
		}

		// Token: 0x04008AF5 RID: 35573
		private readonly SpriteFont _font;

		// Token: 0x04008AF6 RID: 35574
		private readonly CultureInfo _culture;

		// Token: 0x04008AF7 RID: 35575
		private readonly float _maxWidth;

		// Token: 0x04008AF8 RID: 35576
		private readonly StringBuilder _completedText;

		// Token: 0x04008AF9 RID: 35577
		private readonly StringBuilder _workingLine;

		// Token: 0x04008AFA RID: 35578
		private float _workingLineWidth;

		// Token: 0x02000B19 RID: 2841
		private struct NonBreakingText
		{
			// Token: 0x06005326 RID: 21286 RVA: 0x00284190 File Offset: 0x00282390
			public NonBreakingText(SpriteFont font, string text)
			{
				int num = 1;
				this.Text = text;
				this.IsWhitespace = num != 0;
				this._font = font;
				int stringLength = text._stringLength;
				long num2 = 0L;
				char c = text[(int)num2];
				SpriteFont.Glyph characterMetrics = font.GetCharacterMetrics(c);
				if (num2 != 0L)
				{
					float <Spacing>k__BackingField = font.<Spacing>k__BackingField;
					return;
				}
				if (stringLength == 0)
				{
				}
				char c2 = text[(int)num2];
				int stringLength2 = text._stringLength;
			}

			// Token: 0x06005327 RID: 21287 RVA: 0x002841FC File Offset: 0x002823FC
			public string GetAsWrappedText(float maxWidth)
			{
				long num = 0L;
				char c;
				SpriteFont.Glyph characterMetrics = this._font.GetCharacterMetrics(c);
				SpriteFont font;
				if (num != 0L)
				{
					font = this._font;
					float <Spacing>k__BackingField = font.<Spacing>k__BackingField;
				}
				if (font == null)
				{
				}
				if (font == null)
				{
					return;
				}
			}

			// Token: 0x04008AFB RID: 35579
			public readonly string Text;

			// Token: 0x04008AFC RID: 35580
			public readonly float Width;

			// Token: 0x04008AFD RID: 35581
			public readonly float WidthOnNewLine;

			// Token: 0x04008AFE RID: 35582
			public readonly bool IsWhitespace;

			// Token: 0x04008AFF RID: 35583
			private readonly SpriteFont _font;
		}
	}
}
