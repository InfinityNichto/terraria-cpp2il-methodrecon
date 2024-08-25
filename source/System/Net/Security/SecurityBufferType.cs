﻿using System;

namespace System.Net.Security
{
	// Token: 0x02000313 RID: 787
	internal enum SecurityBufferType
	{
		// Token: 0x04001120 RID: 4384
		SECBUFFER_EMPTY,
		// Token: 0x04001121 RID: 4385
		SECBUFFER_DATA,
		// Token: 0x04001122 RID: 4386
		SECBUFFER_TOKEN,
		// Token: 0x04001123 RID: 4387
		SECBUFFER_PKG_PARAMS,
		// Token: 0x04001124 RID: 4388
		SECBUFFER_MISSING,
		// Token: 0x04001125 RID: 4389
		SECBUFFER_EXTRA,
		// Token: 0x04001126 RID: 4390
		SECBUFFER_STREAM_TRAILER,
		// Token: 0x04001127 RID: 4391
		SECBUFFER_STREAM_HEADER,
		// Token: 0x04001128 RID: 4392
		SECBUFFER_PADDING = 9,
		// Token: 0x04001129 RID: 4393
		SECBUFFER_STREAM,
		// Token: 0x0400112A RID: 4394
		SECBUFFER_CHANNEL_BINDINGS = 14,
		// Token: 0x0400112B RID: 4395
		SECBUFFER_TARGET_HOST = 16,
		// Token: 0x0400112C RID: 4396
		SECBUFFER_ALERT,
		// Token: 0x0400112D RID: 4397
		SECBUFFER_APPLICATION_PROTOCOLS,
		// Token: 0x0400112E RID: 4398
		SECBUFFER_READONLY = -2147483648,
		// Token: 0x0400112F RID: 4399
		SECBUFFER_READONLY_WITH_CHECKSUM = 268435456
	}
}
