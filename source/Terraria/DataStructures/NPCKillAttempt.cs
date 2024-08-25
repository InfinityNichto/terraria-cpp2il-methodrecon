using System;
using Cpp2IlInjected;

namespace Terraria.DataStructures
{
	// Token: 0x0200063A RID: 1594
	public struct NPCKillAttempt
	{
		// Token: 0x06003646 RID: 13894 RVA: 0x002128B0 File Offset: 0x00210AB0
		public NPCKillAttempt(NPC target)
		{
			this.npc = target;
			int netID = target.netID;
			this.netId = netID;
			bool flag = target.active;
			this.active = flag;
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x000021DB File Offset: 0x000003DB
		public bool DidNPCDie()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x002128E0 File Offset: 0x00210AE0
		public bool DidNPCDieOrTransform()
		{
			int num = this.netId;
			return true;
		}

		// Token: 0x040076FE RID: 30462
		public readonly NPC npc;

		// Token: 0x040076FF RID: 30463
		public readonly int netId;

		// Token: 0x04007700 RID: 30464
		public readonly bool active;
	}
}
