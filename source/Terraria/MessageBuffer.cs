using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Terraria
{
	// Token: 0x020003FF RID: 1023
	public class MessageBuffer
	{
		// Token: 0x14000029 RID: 41
		// (add) Token: 0x060020C1 RID: 8385 RVA: 0x000CD498 File Offset: 0x000CB698
		// (remove) Token: 0x060020C2 RID: 8386 RVA: 0x000CD4B4 File Offset: 0x000CB6B4
		public static event TileChangeReceivedEvent OnTileChangeReceived
		{
			[CompilerGenerated]
			add
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x000CD4D0 File Offset: 0x000CB6D0
		public void Reset(bool setupActive = false)
		{
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x000CD4E0 File Offset: 0x000CB6E0
		private float[] ReUseTemporaryProjectileAI()
		{
			return this._temporaryProjectileAI;
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x000CD4F8 File Offset: 0x000CB6F8
		private float[] ReUseTemporaryNPCAI()
		{
			return this._temporaryNPCAI;
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x000CD510 File Offset: 0x000CB710
		public void ProcessData(byte[] messageData, int length, [Out] int messageType)
		{
			int num = 1;
			int num2 = this.whoAmI;
			if (num == 0)
			{
			}
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x000CFF5C File Offset: 0x000CE15C
		private static void ReadAccessoryVisibility(BinaryReader reader, bool[] hideVisibleAccessory)
		{
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x000CFF6C File Offset: 0x000CE16C
		private static void TrySendingItemArray(int plr, Item[] array, int slotStartIndex)
		{
			long entityId = array.entityId;
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x000CFF84 File Offset: 0x000CE184
		public MessageBuffer()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x000CFFA0 File Offset: 0x000CE1A0
		// Note: this type is marked as 'beforefieldinit'.
		static MessageBuffer()
		{
		}

		// Token: 0x04002CE7 RID: 11495
		private static byte[] processData;

		// Token: 0x04002CE8 RID: 11496
		private static MemoryStream readerStream;

		// Token: 0x04002CE9 RID: 11497
		private static BinaryReader reader;

		// Token: 0x04002CEA RID: 11498
		public bool broadcast;

		// Token: 0x04002CEB RID: 11499
		public int whoAmI;

		// Token: 0x04002CEC RID: 11500
		public int spamCount;

		// Token: 0x04002CED RID: 11501
		public int maxSpam;

		// Token: 0x04002CEE RID: 11502
		[CompilerGenerated]
		private static TileChangeReceivedEvent OnTileChangeReceived;

		// Token: 0x04002CEF RID: 11503
		private float[] _temporaryProjectileAI;

		// Token: 0x04002CF0 RID: 11504
		private float[] _temporaryNPCAI;
	}
}
