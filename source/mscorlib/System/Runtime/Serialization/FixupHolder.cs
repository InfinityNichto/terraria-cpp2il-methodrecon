using System;

namespace System.Runtime.Serialization
{
	// Token: 0x020003DE RID: 990
	[Serializable]
	internal class FixupHolder
	{
		// Token: 0x06001F67 RID: 8039 RVA: 0x0004500C File Offset: 0x0004320C
		internal FixupHolder(long id, object fixupInfo, int fixupType)
		{
			this.m_id = id;
			this.m_fixupInfo = fixupInfo;
			this.m_fixupType = fixupType;
		}

		// Token: 0x04000FB0 RID: 4016
		internal long m_id;

		// Token: 0x04000FB1 RID: 4017
		internal object m_fixupInfo;

		// Token: 0x04000FB2 RID: 4018
		internal int m_fixupType;
	}
}
