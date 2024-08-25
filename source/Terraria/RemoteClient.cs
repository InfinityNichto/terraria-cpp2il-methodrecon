using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.Localization;

namespace Terraria
{
	// Token: 0x02000420 RID: 1056
	public class RemoteClient
	{
		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x0600273C RID: 10044 RVA: 0x0018C3B8 File Offset: 0x0018A5B8
		public bool HasAnySection
		{
			get
			{
				for (;;)
				{
					int num = 1;
					if (num == 0)
					{
					}
					if (num == 0)
					{
					}
					if (this.TileSections != null)
					{
						return;
					}
				}
			}
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x0018C3DC File Offset: 0x0018A5DC
		public void SpamUpdate()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				float spamProjectile = this.SpamProjectile;
				float spamProjectileMax = this.SpamProjectileMax;
				int id = this.Id;
				if (num == 0)
				{
				}
				NetworkText networkText;
				NetMessage.BootPlayer(id, networkText);
				float spamAddBlock = this.SpamAddBlock;
				float spamAddBlockMax = this.SpamAddBlockMax;
				NetworkText networkText2;
				NetMessage.BootPlayer(this.Id, networkText2);
				float spamDeleteBlock = this.SpamDeleteBlock;
				float spamDeleteBlockMax = this.SpamDeleteBlockMax;
				NetworkText networkText3;
				NetMessage.BootPlayer(this.Id, networkText3);
				float spamWater = this.SpamWater;
				float spamWaterMax = this.SpamWaterMax;
				NetworkText networkText4;
				NetMessage.BootPlayer(this.Id, networkText4);
				float spamWater2 = this.SpamWater;
				float spamProjectile2 = this.SpamProjectile;
				float spamDeleteBlock2 = this.SpamDeleteBlock;
				this.SpamDeleteBlock = spamDeleteBlock2;
				this.SpamProjectile = spamProjectile2;
				this.SpamWater = spamWater2;
				return;
			}
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x0018C49C File Offset: 0x0018A69C
		public void SpamClear()
		{
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x0018C4AC File Offset: 0x0018A6AC
		public static void CheckSection(int playerIndex, Vector2 position, int fluff = 1)
		{
			if (!true)
			{
			}
			int num = 34079;
			if (33205 == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			long num2 = 0L;
			string textValue = Language.GetTextValue("Net.IsReceivingTileData");
			NetMessage.SendSection(playerIndex, (int)num2, 42178960);
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x0018C4F4 File Offset: 0x0018A6F4
		public bool SectionRange(int size, int firstX, int firstY)
		{
			if (!true)
			{
			}
			if (this.TileSections == null)
			{
				return;
			}
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x0018C514 File Offset: 0x0018A714
		public void ResetSections()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool[,] tileSections = this.TileSections;
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x0018C534 File Offset: 0x0018A734
		public void Reset(bool setupActive = false)
		{
			int num = 1;
			this.ResetSections();
			int id = this.Id;
			if (num == 0)
			{
				int id2 = this.Id;
			}
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x0018C57C File Offset: 0x0018A77C
		public void ServerWriteCallBack(object state)
		{
			if (!true)
			{
			}
			int statusMax = this.StatusMax;
			int statusCount = this.StatusCount;
			this.StatusCount = statusCount;
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x0018C5A4 File Offset: 0x0018A7A4
		public RemoteClient()
		{
			if ("" == null)
			{
			}
			base..ctor();
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x0018C5D4 File Offset: 0x0018A7D4
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteClient()
		{
		}

		// Token: 0x04003374 RID: 13172
		private static List<Point> _pendingSectionFraming;

		// Token: 0x04003375 RID: 13173
		public int Id;

		// Token: 0x04003376 RID: 13174
		public string Name = "Anonymous";

		// Token: 0x04003377 RID: 13175
		public bool LocalHost;

		// Token: 0x04003378 RID: 13176
		public bool Connected;

		// Token: 0x04003379 RID: 13177
		public bool IsActive;

		// Token: 0x0400337A RID: 13178
		public bool PendingTermination;

		// Token: 0x0400337B RID: 13179
		public bool IsAnnouncementCompleted;

		// Token: 0x0400337C RID: 13180
		public int State;

		// Token: 0x0400337D RID: 13181
		public int TimeOutTimer;

		// Token: 0x0400337E RID: 13182
		public string StatusText = "";

		// Token: 0x0400337F RID: 13183
		public string StatusText2;

		// Token: 0x04003380 RID: 13184
		public int StatusCount;

		// Token: 0x04003381 RID: 13185
		public int StatusMax;

		// Token: 0x04003382 RID: 13186
		public bool[,] TileSections;

		// Token: 0x04003383 RID: 13187
		public float SpamProjectile;

		// Token: 0x04003384 RID: 13188
		public float SpamAddBlock;

		// Token: 0x04003385 RID: 13189
		public float SpamDeleteBlock;

		// Token: 0x04003386 RID: 13190
		public float SpamWater;

		// Token: 0x04003387 RID: 13191
		public float SpamProjectileMax;

		// Token: 0x04003388 RID: 13192
		public float SpamAddBlockMax;

		// Token: 0x04003389 RID: 13193
		public float SpamDeleteBlockMax;

		// Token: 0x0400338A RID: 13194
		public float SpamWaterMax;
	}
}
