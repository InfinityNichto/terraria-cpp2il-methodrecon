using System;

namespace UnityEngine.Android
{
	// Token: 0x02000010 RID: 16
	public enum AndroidAssetPackError
	{
		// Token: 0x04000028 RID: 40
		NoError,
		// Token: 0x04000029 RID: 41
		AppUnavailable = -1,
		// Token: 0x0400002A RID: 42
		PackUnavailable = -2,
		// Token: 0x0400002B RID: 43
		InvalidRequest = -3,
		// Token: 0x0400002C RID: 44
		DownloadNotFound = -4,
		// Token: 0x0400002D RID: 45
		ApiNotAvailable = -5,
		// Token: 0x0400002E RID: 46
		NetworkError = -6,
		// Token: 0x0400002F RID: 47
		AccessDenied = -7,
		// Token: 0x04000030 RID: 48
		InsufficientStorage = -10,
		// Token: 0x04000031 RID: 49
		PlayStoreNotFound = -11,
		// Token: 0x04000032 RID: 50
		NetworkUnrestricted = -12,
		// Token: 0x04000033 RID: 51
		AppNotOwned = -13,
		// Token: 0x04000034 RID: 52
		InternalError = -100
	}
}
