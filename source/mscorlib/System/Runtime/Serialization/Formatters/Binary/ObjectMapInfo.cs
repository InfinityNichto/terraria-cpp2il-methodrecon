using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000418 RID: 1048
	internal sealed class ObjectMapInfo
	{
		// Token: 0x0600207C RID: 8316 RVA: 0x00047AC8 File Offset: 0x00045CC8
		internal ObjectMapInfo(int objectId, int numMembers, string[] memberNames, Type[] memberTypes)
		{
			this.memberNames = numMembers;
			this.memberNames = memberNames;
			this.memberTypes = memberTypes;
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00047AF4 File Offset: 0x00045CF4
		internal bool isCompatible(int numMembers, string[] memberNames, Type[] memberTypes)
		{
			int num = this.numMembers;
			string[] array = this.memberNames;
			if (memberTypes == null || this.memberTypes == null)
			{
				return;
			}
		}

		// Token: 0x04001108 RID: 4360
		internal int objectId;

		// Token: 0x04001109 RID: 4361
		private int numMembers;

		// Token: 0x0400110A RID: 4362
		private string[] memberNames;

		// Token: 0x0400110B RID: 4363
		private Type[] memberTypes;
	}
}
