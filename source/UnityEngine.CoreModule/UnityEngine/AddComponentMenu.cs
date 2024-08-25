using System;

namespace UnityEngine
{
	// Token: 0x020000B0 RID: 176
	public sealed class AddComponentMenu : Attribute
	{
		// Token: 0x0600031F RID: 799 RVA: 0x000068C4 File Offset: 0x00004AC4
		public AddComponentMenu(string menuName)
		{
			this.m_AddComponentMenu = menuName;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000068E0 File Offset: 0x00004AE0
		public AddComponentMenu(string menuName, int order)
		{
			this.m_AddComponentMenu = menuName;
		}

		// Token: 0x0400036D RID: 877
		private string m_AddComponentMenu;

		// Token: 0x0400036E RID: 878
		private int m_Ordering;
	}
}
