using System;

namespace ReLogic.OS
{
	// Token: 0x02000B20 RID: 2848
	public interface IPathService
	{
		// Token: 0x06005346 RID: 21318
		string GetStoragePath();

		// Token: 0x06005347 RID: 21319
		string GetStoragePath(string subfolder);

		// Token: 0x06005348 RID: 21320
		string ExpandPathVariables(string path);
	}
}
