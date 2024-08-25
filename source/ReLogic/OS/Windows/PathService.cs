using System;
using System.IO;
using ReLogic.OS.Base;

namespace ReLogic.OS.Windows
{
	// Token: 0x02000B23 RID: 2851
	internal class PathService : PathService
	{
		// Token: 0x0600534E RID: 21326 RVA: 0x00284448 File Offset: 0x00282648
		public override string GetStoragePath()
		{
			return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "My Games");
		}

		// Token: 0x0600534F RID: 21327 RVA: 0x00284468 File Offset: 0x00282668
		public PathService()
		{
		}
	}
}
