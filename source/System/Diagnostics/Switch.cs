using System;
using System.Collections.Generic;

namespace System.Diagnostics
{
	// Token: 0x020000C9 RID: 201
	public abstract class Switch
	{
		// Token: 0x06000497 RID: 1175 RVA: 0x000134EC File Offset: 0x000116EC
		protected Switch(string displayName, string description)
		{
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x000134FC File Offset: 0x000116FC
		protected Switch(string displayName, string description, string defaultSwitchValue)
		{
			if (displayName == null)
			{
			}
			this.description = description;
			Switch._pruneCachedSwitches();
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00013548 File Offset: 0x00011748
		private static void _pruneCachedSwitches()
		{
			if ("Shadow Key" == null)
			{
			}
			if ("Shadow Key" == null)
			{
			}
			int num = GC.CollectionCount(2);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x000135D8 File Offset: 0x000117D8
		// Note: this type is marked as 'beforefieldinit'.
		static Switch()
		{
		}

		// Token: 0x0400038D RID: 909
		private readonly string description;

		// Token: 0x0400038E RID: 910
		private readonly string displayName;

		// Token: 0x0400038F RID: 911
		private string switchValueString;

		// Token: 0x04000390 RID: 912
		private string defaultValue;

		// Token: 0x04000391 RID: 913
		private static List<WeakReference> switches;

		// Token: 0x04000392 RID: 914
		private static int s_LastCollectionCount;
	}
}
