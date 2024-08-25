using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI
{
	// Token: 0x02000718 RID: 1816
	public class NetDiagnosticsUI : INetDiagnosticsUI
	{
		// Token: 0x06003C1A RID: 15386 RVA: 0x00235830 File Offset: 0x00233A30
		public void Reset()
		{
			NetDiagnosticsUI.CounterForMessage[] counterByMessageId = this._counterByMessageId;
			NetDiagnosticsUI.CounterForMessage[] counterByMessageId2 = this._counterByMessageId;
			Dictionary<int, NetDiagnosticsUI.CounterForMessage> counterByModuleId = this._counterByModuleId;
			NetDiagnosticsUI.CounterForMessage[] counterByMessageId3 = this._counterByMessageId;
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x00235864 File Offset: 0x00233A64
		public void CountReadMessage(int messageId, int messageLength)
		{
			NetDiagnosticsUI.CounterForMessage[] counterByMessageId = this._counterByMessageId;
		}

		// Token: 0x06003C1C RID: 15388 RVA: 0x0023587C File Offset: 0x00233A7C
		public void CountSentMessage(int messageId, int messageLength)
		{
			NetDiagnosticsUI.CounterForMessage[] counterByMessageId = this._counterByMessageId;
		}

		// Token: 0x06003C1D RID: 15389 RVA: 0x00235894 File Offset: 0x00233A94
		public void CountReadModuleMessage(int moduleMessageId, int messageLength)
		{
			Dictionary<int, NetDiagnosticsUI.CounterForMessage> counterByModuleId = this._counterByModuleId;
			Dictionary<int, NetDiagnosticsUI.CounterForMessage> counterByModuleId2 = this._counterByModuleId;
		}

		// Token: 0x06003C1E RID: 15390 RVA: 0x002358B0 File Offset: 0x00233AB0
		public void CountSentModuleMessage(int moduleMessageId, int messageLength)
		{
			Dictionary<int, NetDiagnosticsUI.CounterForMessage> counterByModuleId = this._counterByModuleId;
			Dictionary<int, NetDiagnosticsUI.CounterForMessage> counterByModuleId2 = this._counterByModuleId;
		}

		// Token: 0x06003C1F RID: 15391 RVA: 0x002358CC File Offset: 0x00233ACC
		public void Draw(SpriteBatch spriteBatch)
		{
			int num = 1;
			NetDiagnosticsUI.CounterForMessage[] counterByMessageId = this._counterByMessageId;
			Dictionary<int, NetDiagnosticsUI.CounterForMessage> counterByModuleId = this._counterByModuleId;
			if (num == 0)
			{
			}
			NetDiagnosticsUI.CounterForMessage[] counterByMessageId2 = this._counterByMessageId;
			NetDiagnosticsUI.CounterForMessage[] counterByMessageId3 = this._counterByMessageId;
			Dictionary<int, NetDiagnosticsUI.CounterForMessage> counterByModuleId2 = this._counterByModuleId;
			string text2;
			string text = ".." + text2;
		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x0023592C File Offset: 0x00233B2C
		private void DrawCounter(SpriteBatch spriteBatch, NetDiagnosticsUI.CounterForMessage counter, string title, Vector2 position)
		{
			int bytesReceived;
			if (!counter.exemptFromBadScoreTest)
			{
				int highestFoundReadCount = this._highestFoundReadCount;
				int highestFoundReadBytes = this._highestFoundReadBytes;
				bytesReceived = counter.bytesReceived;
				this._highestFoundReadBytes = bytesReceived;
			}
			string text = title + ": ";
			int bytesReceived2 = counter.bytesReceived;
			int highestFoundReadBytes2 = this._highestFoundReadBytes;
			if (bytesReceived == 0)
			{
			}
			bool exemptFromBadScoreTest = counter.exemptFromBadScoreTest;
			if (!exemptFromBadScoreTest || !exemptFromBadScoreTest)
			{
			}
			string text3;
			string text2 = "rx:" + text3;
			int bytesReceived3 = counter.bytesReceived;
			int timesSent = counter.timesSent;
			string text5;
			string text4 = "tx:" + text5;
			int bytesSent = counter.bytesSent;
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x002359C0 File Offset: 0x00233BC0
		private void DrawText(SpriteBatch spriteBatch, string text, Vector2 pos, Color color)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x002359D4 File Offset: 0x00233BD4
		public NetDiagnosticsUI()
		{
		}

		// Token: 0x04007B6E RID: 31598
		private NetDiagnosticsUI.CounterForMessage[] _counterByMessageId;

		// Token: 0x04007B6F RID: 31599
		private Dictionary<int, NetDiagnosticsUI.CounterForMessage> _counterByModuleId;

		// Token: 0x04007B70 RID: 31600
		private int _highestFoundReadBytes;

		// Token: 0x04007B71 RID: 31601
		private int _highestFoundReadCount;

		// Token: 0x02000719 RID: 1817
		private struct CounterForMessage
		{
			// Token: 0x06003C23 RID: 15395 RVA: 0x002359E8 File Offset: 0x00233BE8
			public void Reset()
			{
			}

			// Token: 0x06003C24 RID: 15396 RVA: 0x002359F8 File Offset: 0x00233BF8
			public void CountReadMessage(int messageLength)
			{
				int num = this.bytesReceived;
				this.bytesReceived = num;
			}

			// Token: 0x06003C25 RID: 15397 RVA: 0x00235A14 File Offset: 0x00233C14
			public void CountSentMessage(int messageLength)
			{
				int num = this.timesSent;
				int num2 = this.bytesSent;
				this.timesSent = num;
				this.bytesSent = num2;
			}

			// Token: 0x04007B72 RID: 31602
			public int timesReceived;

			// Token: 0x04007B73 RID: 31603
			public int timesSent;

			// Token: 0x04007B74 RID: 31604
			public int bytesReceived;

			// Token: 0x04007B75 RID: 31605
			public int bytesSent;

			// Token: 0x04007B76 RID: 31606
			public bool exemptFromBadScoreTest;
		}
	}
}
