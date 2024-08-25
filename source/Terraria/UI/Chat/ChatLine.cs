using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI.Chat
{
	// Token: 0x0200072B RID: 1835
	public class ChatLine
	{
		// Token: 0x06003CBA RID: 15546 RVA: 0x00237268 File Offset: 0x00235468
		public void UpdateTimeLeft()
		{
			int num = this.showTime;
			this.showTime = num;
			if (this.needsParsing)
			{
			}
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x0023728C File Offset: 0x0023548C
		public void Copy(ChatLine other)
		{
			bool flag = other.needsParsing;
			this.needsParsing = flag;
			int? num = other.parsingPixelLimit;
			this.parsingPixelLimit = num;
			int num2 = other.showTime;
			this.showTime = num2;
			Color color = other.color;
			this.color = color;
			Vector2 vector = other.calculatedSizeMiniTouch;
			this.calculatedSizeMiniTouch = vector;
			Vector2 vector2 = other.calculatedSizeMini;
			this.calculatedSizeMini = vector2;
			Vector2 vector3 = other.calculatedSizePage;
			this.calculatedSizePage = vector3;
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x00237304 File Offset: 0x00235504
		public void FlagAsNeedsReprocessing()
		{
			this.needsParsing = true;
		}

		// Token: 0x06003CBD RID: 15549 RVA: 0x00237318 File Offset: 0x00235518
		public ChatLine()
		{
			if (!true)
			{
			}
			this.color = 1;
			this.originalText = "";
			base..ctor();
		}

		// Token: 0x04007BD5 RID: 31701
		public Color color;

		// Token: 0x04007BD6 RID: 31702
		public int showTime;

		// Token: 0x04007BD7 RID: 31703
		public string originalText;

		// Token: 0x04007BD8 RID: 31704
		public TextSnippet[] parsedText;

		// Token: 0x04007BD9 RID: 31705
		public TextSnippet[] parsedMiniText;

		// Token: 0x04007BDA RID: 31706
		public TextSnippet[] parsedMiniTouchText;

		// Token: 0x04007BDB RID: 31707
		public Vector2 calculatedSizeMiniTouch;

		// Token: 0x04007BDC RID: 31708
		public Vector2 calculatedSizeMini;

		// Token: 0x04007BDD RID: 31709
		public Vector2 calculatedSizePage;

		// Token: 0x04007BDE RID: 31710
		private int? parsingPixelLimit;

		// Token: 0x04007BDF RID: 31711
		private bool needsParsing;
	}
}
