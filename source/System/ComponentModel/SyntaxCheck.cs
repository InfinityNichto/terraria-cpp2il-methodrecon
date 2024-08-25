using System;

namespace System.ComponentModel
{
	// Token: 0x020003BB RID: 955
	public static class SyntaxCheck
	{
		// Token: 0x0600196F RID: 6511 RVA: 0x000471D8 File Offset: 0x000453D8
		public static bool CheckMachineName(string value)
		{
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x000471E8 File Offset: 0x000453E8
		public static bool CheckPath(string value)
		{
			string text;
			return text.StartsWith("\\\\");
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00047204 File Offset: 0x00045404
		public static bool CheckRootedPath(string value)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}
	}
}
