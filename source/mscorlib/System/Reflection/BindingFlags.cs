using System;

namespace System.Reflection
{
	// Token: 0x020004CA RID: 1226
	[Flags]
	public enum BindingFlags
	{
		// Token: 0x0400136A RID: 4970
		Default = 0,
		// Token: 0x0400136B RID: 4971
		IgnoreCase = 1,
		// Token: 0x0400136C RID: 4972
		DeclaredOnly = 2,
		// Token: 0x0400136D RID: 4973
		Instance = 4,
		// Token: 0x0400136E RID: 4974
		Static = 8,
		// Token: 0x0400136F RID: 4975
		Public = 16,
		// Token: 0x04001370 RID: 4976
		NonPublic = 32,
		// Token: 0x04001371 RID: 4977
		FlattenHierarchy = 64,
		// Token: 0x04001372 RID: 4978
		InvokeMethod = 256,
		// Token: 0x04001373 RID: 4979
		CreateInstance = 512,
		// Token: 0x04001374 RID: 4980
		GetField = 1024,
		// Token: 0x04001375 RID: 4981
		SetField = 2048,
		// Token: 0x04001376 RID: 4982
		GetProperty = 4096,
		// Token: 0x04001377 RID: 4983
		SetProperty = 8192,
		// Token: 0x04001378 RID: 4984
		PutDispProperty = 16384,
		// Token: 0x04001379 RID: 4985
		PutRefDispProperty = 32768,
		// Token: 0x0400137A RID: 4986
		ExactBinding = 65536,
		// Token: 0x0400137B RID: 4987
		SuppressChangeType = 131072,
		// Token: 0x0400137C RID: 4988
		OptionalParamBinding = 262144,
		// Token: 0x0400137D RID: 4989
		IgnoreReturn = 16777216,
		// Token: 0x0400137E RID: 4990
		DoNotWrapExceptions = 33554432
	}
}
