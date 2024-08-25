using System;

namespace System.Runtime.Serialization
{
	// Token: 0x020003DF RID: 991
	[Serializable]
	internal class FixupHolderList
	{
		// Token: 0x06001F68 RID: 8040 RVA: 0x00045034 File Offset: 0x00043234
		internal FixupHolderList()
		{
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x00045044 File Offset: 0x00043244
		internal FixupHolderList(int startingSize)
		{
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x00045058 File Offset: 0x00043258
		internal virtual void Add(FixupHolder fixup)
		{
			FixupHolder[] values = this.m_values;
			int count = this.m_count;
			object fixupInfo = values.m_fixupInfo;
			this.EnlargeArray();
			FixupHolder[] values2 = this.m_values;
			int count2 = this.m_count;
			this.m_count = fixupInfo;
			if (fixup == null || fixup != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x000450A4 File Offset: 0x000432A4
		private void EnlargeArray()
		{
			object fixupInfo = this.m_values.m_fixupInfo;
			FixupHolder[] values = this.m_values;
			int count = this.m_count;
		}

		// Token: 0x04000FB3 RID: 4019
		internal FixupHolder[] m_values;

		// Token: 0x04000FB4 RID: 4020
		internal int m_count;
	}
}
