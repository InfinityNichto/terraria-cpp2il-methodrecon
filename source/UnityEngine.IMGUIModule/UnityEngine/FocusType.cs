using System;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	public enum FocusType
	{
		// Token: 0x0400001D RID: 29
		[Obsolete("FocusType.Native now behaves the same as FocusType.Passive in all OS cases. (UnityUpgradable) -> Passive", false)]
		Native,
		// Token: 0x0400001E RID: 30
		Keyboard,
		// Token: 0x0400001F RID: 31
		Passive
	}
}
