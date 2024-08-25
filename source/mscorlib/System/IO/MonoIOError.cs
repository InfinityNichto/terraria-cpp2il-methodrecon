﻿using System;

namespace System.IO
{
	// Token: 0x0200056B RID: 1387
	internal enum MonoIOError
	{
		// Token: 0x0400165A RID: 5722
		ERROR_SUCCESS,
		// Token: 0x0400165B RID: 5723
		ERROR_FILE_NOT_FOUND = 2,
		// Token: 0x0400165C RID: 5724
		ERROR_PATH_NOT_FOUND,
		// Token: 0x0400165D RID: 5725
		ERROR_TOO_MANY_OPEN_FILES,
		// Token: 0x0400165E RID: 5726
		ERROR_ACCESS_DENIED,
		// Token: 0x0400165F RID: 5727
		ERROR_INVALID_HANDLE,
		// Token: 0x04001660 RID: 5728
		ERROR_INVALID_DRIVE = 15,
		// Token: 0x04001661 RID: 5729
		ERROR_NOT_SAME_DEVICE = 17,
		// Token: 0x04001662 RID: 5730
		ERROR_NO_MORE_FILES,
		// Token: 0x04001663 RID: 5731
		ERROR_NOT_READY = 21,
		// Token: 0x04001664 RID: 5732
		ERROR_WRITE_FAULT = 29,
		// Token: 0x04001665 RID: 5733
		ERROR_READ_FAULT,
		// Token: 0x04001666 RID: 5734
		ERROR_GEN_FAILURE,
		// Token: 0x04001667 RID: 5735
		ERROR_SHARING_VIOLATION,
		// Token: 0x04001668 RID: 5736
		ERROR_LOCK_VIOLATION,
		// Token: 0x04001669 RID: 5737
		ERROR_HANDLE_DISK_FULL = 39,
		// Token: 0x0400166A RID: 5738
		ERROR_NOT_SUPPORTED = 50,
		// Token: 0x0400166B RID: 5739
		ERROR_FILE_EXISTS = 80,
		// Token: 0x0400166C RID: 5740
		ERROR_CANNOT_MAKE = 82,
		// Token: 0x0400166D RID: 5741
		ERROR_INVALID_PARAMETER = 87,
		// Token: 0x0400166E RID: 5742
		ERROR_BROKEN_PIPE = 109,
		// Token: 0x0400166F RID: 5743
		ERROR_INVALID_NAME = 123,
		// Token: 0x04001670 RID: 5744
		ERROR_DIR_NOT_EMPTY = 145,
		// Token: 0x04001671 RID: 5745
		ERROR_ALREADY_EXISTS = 183,
		// Token: 0x04001672 RID: 5746
		ERROR_FILENAME_EXCED_RANGE = 206,
		// Token: 0x04001673 RID: 5747
		ERROR_DIRECTORY = 267,
		// Token: 0x04001674 RID: 5748
		ERROR_ENCRYPTION_FAILED = 6000
	}
}
