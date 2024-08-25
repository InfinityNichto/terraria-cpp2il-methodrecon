using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x02000ADC RID: 2780
	public class LegacyChatMonitor : IChatMonitor
	{
		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x060051B6 RID: 20918 RVA: 0x0028105C File Offset: 0x0027F25C
		public int TextMaxLengthForScreen
		{
			get
			{
				if (!true)
				{
				}
				return Main.screenWidth;
			}
		}

		// Token: 0x060051B7 RID: 20919 RVA: 0x00281074 File Offset: 0x0027F274
		public void OnResolutionChange()
		{
		}

		// Token: 0x060051B8 RID: 20920 RVA: 0x00281084 File Offset: 0x0027F284
		public LegacyChatMonitor()
		{
			int num = 500;
			this.numChatLines = num;
			int num2 = this.numChatLines;
			ChatLine[] array = this.chatLine;
		}

		// Token: 0x060051B9 RID: 20921 RVA: 0x002810C0 File Offset: 0x0027F2C0
		public void Clear()
		{
			int num = this.numChatLines;
			ChatLine[] array = this.chatLine;
		}

		// Token: 0x060051BA RID: 20922 RVA: 0x002810E4 File Offset: 0x0027F2E4
		public void ResetOffset()
		{
		}

		// Token: 0x060051BB RID: 20923 RVA: 0x002810F4 File Offset: 0x0027F2F4
		public void Update()
		{
			int num = this.numChatLines;
			TextSnippet[] parsedText = this.chatLine.parsedText;
		}

		// Token: 0x060051BC RID: 20924 RVA: 0x00281118 File Offset: 0x0027F318
		public void Offset(int linesOffset)
		{
			if (!true)
			{
			}
			int screenHeight = Main.screenHeight;
			int num = 21846;
			this.showCount = num;
			int num2 = this.startChatLine;
			int num3 = this.numChatLines;
			this.startChatLine = num;
			bool flag = this.chatLine.parsedText.TextOriginal == "";
			int num4 = this.startChatLine;
		}

		// Token: 0x060051BD RID: 20925 RVA: 0x0028118C File Offset: 0x0027F38C
		public void NewText(string newText, byte R = 255, byte G = 255, byte B = 255)
		{
		}

		// Token: 0x060051BE RID: 20926 RVA: 0x0028119C File Offset: 0x0027F39C
		public void NewTextInternal(string newText, byte R = 255, byte G = 255, byte B = 255, bool force = false)
		{
			int stringLength = newText._stringLength;
			int num = this.numChatLines;
			ChatLine[] array = this.chatLine;
			ChatLine[] array2 = this.chatLine;
			array2.parsedText.Text = array2;
			ChatLine[] array3 = this.chatLine;
			array3.parsedText.TextOriginal = newText;
			TextSnippet[] parsedText = array3.parsedText;
			string textOriginal = parsedText.TextOriginal;
			string text = parsedText.Text;
			if (array3 == null)
			{
			}
			TextSnippet[] array4;
			parsedText.Color = array4;
			ChatLine[] array5 = this.chatLine;
			int num2 = this.chatLength;
			TextSnippet[] parsedText2 = array5.parsedText;
		}

		// Token: 0x060051BF RID: 20927 RVA: 0x00281238 File Offset: 0x0027F438
		private string TrimIntoMultipleLines(byte R, byte G, byte B, int maxTextSize, string oldText)
		{
			int stringLength = oldText._stringLength;
			int num = 1;
			bool flag = oldText.Substring(maxTextSize, num) != " ";
			if (maxTextSize == 0)
			{
				int num2 = 1;
				bool flag2 = oldText.Substring(maxTextSize, num2) != " ";
			}
			long num3 = 0L;
			string text = oldText.Substring((int)num3, maxTextSize);
			int num4 = 1;
			this.NewTextInternal(text, R, G, B, num4 != 0);
			string text2 = oldText.Substring(maxTextSize);
			int stringLength2 = text2._stringLength;
			int num5 = 1;
			long num6 = 0L;
			bool flag3 = text2.Substring((int)num6, num5) == " ";
			int num7 = 1;
			return text2.Substring(num7);
		}

		// Token: 0x060051C0 RID: 20928 RVA: 0x002812F0 File Offset: 0x0027F4F0
		public void NewTextMultiline(string text, bool force = false, [Optional] Color c, int WidthLimit = -1)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
			List<List<TextSnippet>> list;
			int size = list._size;
			this.NewText(list);
			int size2 = list._size;
		}

		// Token: 0x060051C1 RID: 20929 RVA: 0x00281328 File Offset: 0x0027F528
		public void NewText(List<TextSnippet> snippets)
		{
			int num = this.numChatLines;
			ChatLine[] array = this.chatLine;
			ChatLine[] array2 = this.chatLine;
			array2.parsedText.TextOriginal = "this is a hack because draw checks length is higher than 0";
			array2.parsedText.Color = snippets;
			ChatLine[] array3 = this.chatLine;
			int num2 = this.chatLength;
			TextSnippet[] parsedText = array3.parsedText;
		}

		// Token: 0x060051C2 RID: 20930 RVA: 0x00281384 File Offset: 0x0027F584
		public void DrawChat(bool drawingPlayerChat)
		{
			int num = this.showCount;
			int num2 = this.numChatLines;
			ChatLine[] array = this.chatLine;
			int showTime = array.showTime;
			string textOriginal = array.parsedText.TextOriginal;
			if (textOriginal != null)
			{
				if (textOriginal == null)
				{
				}
				ChatLine[] array2 = this.chatLine;
				TextSnippet[] parsedText = array2.parsedText;
				int screenHeight = Main.screenHeight;
				if (17072 == 0)
				{
				}
				if (!true)
				{
				}
				bool checkForHover = this.chatLine.parsedText.CheckForHover;
			}
			Color color = this.chatLine.parsedText.Color;
			bool mouseLeft = Main.mouseLeft;
			bool mouseLeftRelease = Main.mouseLeftRelease;
			Color color2 = this.chatLine.parsedText.Color;
		}

		// Token: 0x04008A37 RID: 35383
		private int numChatLines;

		// Token: 0x04008A38 RID: 35384
		private ChatLine[] chatLine;

		// Token: 0x04008A39 RID: 35385
		private int chatLength;

		// Token: 0x04008A3A RID: 35386
		private int showCount;

		// Token: 0x04008A3B RID: 35387
		private int startChatLine;
	}
}
