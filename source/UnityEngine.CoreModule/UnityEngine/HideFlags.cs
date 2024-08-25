using System;

namespace UnityEngine
{
	// Token: 0x020000A2 RID: 162
	[Flags]
	public enum HideFlags
	{
		// Token: 0x04000354 RID: 852
		None = 0,
		// Token: 0x04000355 RID: 853
		HideInHierarchy = 1,
		// Token: 0x04000356 RID: 854
		HideInInspector = 2,
		// Token: 0x04000357 RID: 855
		DontSaveInEditor = 4,
		// Token: 0x04000358 RID: 856
		NotEditable = 8,
		// Token: 0x04000359 RID: 857
		DontSaveInBuild = 16,
		// Token: 0x0400035A RID: 858
		DontUnloadUnusedAsset = 32,
		// Token: 0x0400035B RID: 859
		DontSave = 52,
		// Token: 0x0400035C RID: 860
		HideAndDontSave = 61
	}
}
