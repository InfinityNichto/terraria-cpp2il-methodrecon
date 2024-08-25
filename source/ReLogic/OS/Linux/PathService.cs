using System;
using ReLogic.OS.Base;

namespace ReLogic.OS.Linux
{
	// Token: 0x02000B2B RID: 2859
	internal class PathService : PathService
	{
		// Token: 0x0600536A RID: 21354 RVA: 0x002848A4 File Offset: 0x00282AA4
		public override string GetStoragePath()
		{
			bool flag = string.IsNullOrEmpty(Environment.GetEnvironmentVariable("XDG_DATA_HOME"));
			bool flag2 = string.IsNullOrEmpty(Environment.GetEnvironmentVariable("HOME"));
			return ".";
		}

		// Token: 0x0600536B RID: 21355 RVA: 0x002848E8 File Offset: 0x00282AE8
		public PathService()
		{
		}
	}
}
