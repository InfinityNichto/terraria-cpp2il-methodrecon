using System;
using ReLogic.OS.Base;

namespace ReLogic.OS.OSX
{
	// Token: 0x02000B28 RID: 2856
	internal class PathService : PathService
	{
		// Token: 0x0600535E RID: 21342 RVA: 0x00284718 File Offset: 0x00282918
		public override string GetStoragePath()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("HOME");
			bool flag = string.IsNullOrEmpty(environmentVariable);
			return ".";
		}

		// Token: 0x0600535F RID: 21343 RVA: 0x00284748 File Offset: 0x00282948
		public PathService()
		{
		}
	}
}
