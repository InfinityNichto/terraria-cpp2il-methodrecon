using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI
{
	// Token: 0x02000716 RID: 1814
	public class LegacyNetDiagnosticsUI : INetDiagnosticsUI
	{
		// Token: 0x06003C08 RID: 15368 RVA: 0x00235684 File Offset: 0x00233884
		public LegacyNetDiagnosticsUI()
		{
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x00235698 File Offset: 0x00233898
		public void Reset()
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
		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x002356B4 File Offset: 0x002338B4
		public void CountReadMessage(int messageId, int messageLength)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x002356C4 File Offset: 0x002338C4
		public void CountSentMessage(int messageId, int messageLength)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x002356D4 File Offset: 0x002338D4
		public void Draw(SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
			LegacyNetDiagnosticsUI.DrawTitles(spriteBatch);
			LegacyNetDiagnosticsUI.DrawMesageLines(spriteBatch);
		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x002356F0 File Offset: 0x002338F0
		private static void DrawMesageLines(SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x00235708 File Offset: 0x00233908
		private static void DrawTitles(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x00235748 File Offset: 0x00233948
		private static void PrintNetDiagnosticsLineForMessage(SpriteBatch spriteBatch, int msgId, int x, int y)
		{
			string text2;
			string text = text2 + ": ";
			string text4;
			string text3 = "rx:" + text4;
			string text6;
			string text5 = text6 + ": ";
			string text8;
			string text7 = "tx:" + text8;
		}

		// Token: 0x06003C10 RID: 15376 RVA: 0x0023578C File Offset: 0x0023398C
		public void CountReadModuleMessage(int moduleMessageId, int messageLength)
		{
		}

		// Token: 0x06003C11 RID: 15377 RVA: 0x0023579C File Offset: 0x0023399C
		public void CountSentModuleMessage(int moduleMessageId, int messageLength)
		{
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x002357AC File Offset: 0x002339AC
		// Note: this type is marked as 'beforefieldinit'.
		static LegacyNetDiagnosticsUI()
		{
		}

		// Token: 0x04007B64 RID: 31588
		public static bool netDiag;

		// Token: 0x04007B65 RID: 31589
		public static int txData;

		// Token: 0x04007B66 RID: 31590
		public static int rxData;

		// Token: 0x04007B67 RID: 31591
		public static int txMsg;

		// Token: 0x04007B68 RID: 31592
		public static int rxMsg;

		// Token: 0x04007B69 RID: 31593
		private static readonly int maxMsg;

		// Token: 0x04007B6A RID: 31594
		public static int[] rxMsgType;

		// Token: 0x04007B6B RID: 31595
		public static int[] rxDataType;

		// Token: 0x04007B6C RID: 31596
		public static int[] txMsgType;

		// Token: 0x04007B6D RID: 31597
		public static int[] txDataType;
	}
}
