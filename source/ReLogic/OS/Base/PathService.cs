using System;

namespace ReLogic.OS.Base
{
	// Token: 0x02000B2E RID: 2862
	internal abstract class PathService : IPathService
	{
		// Token: 0x06005379 RID: 21369 RVA: 0x002849A8 File Offset: 0x00282BA8
		public string ExpandPathVariables(string path)
		{
			return Environment.ExpandEnvironmentVariables(path);
		}

		// Token: 0x0600537A RID: 21370
		public abstract string GetStoragePath();

		// Token: 0x0600537B RID: 21371 RVA: 0x002849BC File Offset: 0x00282BBC
		public string GetStoragePath(string subfolder)
		{
			string text;
			return text;
		}

		// Token: 0x0600537C RID: 21372 RVA: 0x002849CC File Offset: 0x00282BCC
		protected PathService()
		{
		}
	}
}
