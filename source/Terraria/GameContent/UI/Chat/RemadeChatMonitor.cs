using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x02000ADE RID: 2782
	public class RemadeChatMonitor : IChatMonitor
	{
		// Token: 0x060051D0 RID: 20944 RVA: 0x00281890 File Offset: 0x0027FA90
		public RemadeChatMonitor()
		{
		}

		// Token: 0x060051D1 RID: 20945 RVA: 0x002818A4 File Offset: 0x0027FAA4
		public void NewText(string newText, byte R = 255, byte G = 255, byte B = 255)
		{
		}

		// Token: 0x060051D2 RID: 20946 RVA: 0x002818B4 File Offset: 0x0027FAB4
		public void NewTextMultiline(string text, bool force = false, [Optional] Color c, int WidthLimit = -1)
		{
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x002818C4 File Offset: 0x0027FAC4
		public void AddNewMessage(string text, Color color, int widthLimitInPixels = -1)
		{
			List<ChatMessageContainer> messages = this._messages;
			int size = this._messages._size;
			int size2 = this._messages._size;
		}

		// Token: 0x060051D4 RID: 20948 RVA: 0x002818F0 File Offset: 0x0027FAF0
		public void DrawChat(bool drawingPlayerChat)
		{
			int startChatLine = this._startChatLine;
			int size = this._messages._size;
			int num2;
			int num = Math.Min(startChatLine, num2);
			List<ChatMessageContainer> messages = this._messages;
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x000021DB File Offset: 0x000003DB
		public void Clear()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x00281994 File Offset: 0x0027FB94
		public void Update()
		{
			if (this._recalculateOnNextUpdate)
			{
				int size = this._messages._size;
				int size2 = this._messages._size;
				return;
			}
			int size3 = this._messages._size;
			int size4 = this._messages._size;
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x002819E0 File Offset: 0x0027FBE0
		public void Offset(int linesOffset)
		{
			int startChatLine = this._startChatLine;
			this._startChatLine = startChatLine;
			this.ClampMessageIndex();
		}

		// Token: 0x060051D8 RID: 20952 RVA: 0x00281A04 File Offset: 0x0027FC04
		private void ClampMessageIndex()
		{
			int showCount = this._showCount;
			List<ChatMessageContainer> messages = this._messages;
			int size = this._messages._size;
			int num2;
			int num = Math.Min(0, num2);
		}

		// Token: 0x060051D9 RID: 20953 RVA: 0x00281A60 File Offset: 0x0027FC60
		public void ResetOffset()
		{
		}

		// Token: 0x060051DA RID: 20954 RVA: 0x00281A70 File Offset: 0x0027FC70
		public void OnResolutionChange()
		{
			this._recalculateOnNextUpdate = true;
		}

		// Token: 0x04008A42 RID: 35394
		private const int MaxMessages = 500;

		// Token: 0x04008A43 RID: 35395
		private int _showCount;

		// Token: 0x04008A44 RID: 35396
		private int _startChatLine;

		// Token: 0x04008A45 RID: 35397
		private List<ChatMessageContainer> _messages;

		// Token: 0x04008A46 RID: 35398
		private bool _recalculateOnNextUpdate;
	}
}
