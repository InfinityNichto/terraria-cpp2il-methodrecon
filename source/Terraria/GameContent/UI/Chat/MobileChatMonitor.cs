using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x02000ADD RID: 2781
	public class MobileChatMonitor : IChatMonitor
	{
		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x060051C3 RID: 20931 RVA: 0x00281434 File Offset: 0x0027F634
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

		// Token: 0x060051C4 RID: 20932 RVA: 0x0028144C File Offset: 0x0027F64C
		public void OnResolutionChange()
		{
		}

		// Token: 0x060051C5 RID: 20933 RVA: 0x0028145C File Offset: 0x0027F65C
		public MobileChatMonitor()
		{
			int num = 500;
			this.numChatLines = num;
			int num2 = this.numChatLines;
			ChatLine[] array = this.chatLine;
		}

		// Token: 0x060051C6 RID: 20934 RVA: 0x00281498 File Offset: 0x0027F698
		public void Clear()
		{
			int num = this.numChatLines;
			ChatLine[] array = this.chatLine;
			ChatLine[] array2 = this.chatLine;
			int num2 = this.numChatLines;
		}

		// Token: 0x060051C7 RID: 20935 RVA: 0x002814C8 File Offset: 0x0027F6C8
		public void ResetOffset()
		{
		}

		// Token: 0x060051C8 RID: 20936 RVA: 0x002814D8 File Offset: 0x0027F6D8
		public void Update()
		{
			int num = this.numChatLines;
			TextSnippet[] parsedText = this.chatLine.parsedText;
		}

		// Token: 0x060051C9 RID: 20937 RVA: 0x002814FC File Offset: 0x0027F6FC
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

		// Token: 0x060051CA RID: 20938 RVA: 0x00281570 File Offset: 0x0027F770
		public void NewText(string newText, byte R = 255, byte G = 255, byte B = 255)
		{
			long num = 0L;
			this.NewTextInternal(newText, R, G, B, num != 0L);
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x0028158C File Offset: 0x0027F78C
		public void NewTextInternal(string newText, byte R = 255, byte G = 255, byte B = 255, bool force = false)
		{
			int num = this.numChatLines;
			ChatLine[] array = this.chatLine;
			ChatLine[] array2 = this.chatLine;
			array2.parsedText.Text = array2;
			ChatLine[] array3 = this.chatLine;
			array3.parsedText.TextOriginal = newText;
			TextSnippet[] parsedText = array3.parsedText;
			string textOriginal = parsedText.TextOriginal;
			string text = parsedText.Text;
			TextSnippet[] array4;
			parsedText.Color = array4;
			TextSnippet[] parsedText2 = this.chatLine.parsedText;
			string textOriginal2 = parsedText2.TextOriginal;
			string text2 = parsedText2.Text;
			TextSnippet[] array5;
			parsedText2.CheckForHover = array5 != null;
			TextSnippet[] parsedText3 = this.chatLine.parsedText;
			string textOriginal3 = parsedText3.TextOriginal;
			string text3 = parsedText3.Text;
			ChatLine[] array6 = this.chatLine;
			int num2 = this.chatLength;
			Color color = array6.parsedText.Color;
			TextSnippet[] parsedText4 = this.chatLine.parsedText;
			Color color2 = this.chatLine.parsedText.Color;
			Color color3 = this.chatLine.parsedText.Color;
			TextSnippet[] parsedText5 = this.chatLine.parsedText;
			int num3 = this.numChatItems;
			int num4 = this.numChatLines;
			this.numChatItems = num3;
			this.numChatItems = num4;
		}

		// Token: 0x060051CC RID: 20940 RVA: 0x002816B8 File Offset: 0x0027F8B8
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
			long num4 = 0L;
			this.NewTextInternal(text, R, G, B, num4 != 0L);
			string text2 = oldText.Substring(maxTextSize);
			int stringLength2 = text2._stringLength;
			int num5 = 1;
			long num6 = 0L;
			bool flag3 = text2.Substring((int)num6, num5) == " ";
			int num7 = 1;
			return text2.Substring(num7);
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x00281770 File Offset: 0x0027F970
		public void NewTextMultiline(string text, bool force = false, [Optional] Color c, int WidthLimit = -1)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x00281784 File Offset: 0x0027F984
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

		// Token: 0x060051CF RID: 20943 RVA: 0x002817E0 File Offset: 0x0027F9E0
		public void DrawChat(bool drawingPlayerChat)
		{
			int num = this.showCount;
			int num2 = this.numChatItems;
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
				Color color = this.chatLine.parsedText.Color;
			}
			Color color2 = this.chatLine.parsedText.Color;
			bool mouseLeft = Main.mouseLeft;
			bool mouseLeftRelease = Main.mouseLeftRelease;
			Color color3 = this.chatLine.parsedText.Color;
		}

		// Token: 0x04008A3C RID: 35388
		public int numChatLines;

		// Token: 0x04008A3D RID: 35389
		public ChatLine[] chatLine;

		// Token: 0x04008A3E RID: 35390
		private int chatLength;

		// Token: 0x04008A3F RID: 35391
		private int showCount;

		// Token: 0x04008A40 RID: 35392
		private int startChatLine;

		// Token: 0x04008A41 RID: 35393
		public int numChatItems;
	}
}
