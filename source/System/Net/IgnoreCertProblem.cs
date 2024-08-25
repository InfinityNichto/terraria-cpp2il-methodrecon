using System;

namespace System.Net
{
	// Token: 0x020001AD RID: 429
	internal enum IgnoreCertProblem
	{
		// Token: 0x040008CA RID: 2250
		not_time_valid = 1,
		// Token: 0x040008CB RID: 2251
		ctl_not_time_valid,
		// Token: 0x040008CC RID: 2252
		not_time_nested = 4,
		// Token: 0x040008CD RID: 2253
		invalid_basic_constraints = 8,
		// Token: 0x040008CE RID: 2254
		all_not_time_valid = 7,
		// Token: 0x040008CF RID: 2255
		allow_unknown_ca = 16,
		// Token: 0x040008D0 RID: 2256
		wrong_usage = 32,
		// Token: 0x040008D1 RID: 2257
		invalid_name = 64,
		// Token: 0x040008D2 RID: 2258
		invalid_policy = 128,
		// Token: 0x040008D3 RID: 2259
		end_rev_unknown = 256,
		// Token: 0x040008D4 RID: 2260
		ctl_signer_rev_unknown = 512,
		// Token: 0x040008D5 RID: 2261
		ca_rev_unknown = 1024,
		// Token: 0x040008D6 RID: 2262
		root_rev_unknown = 2048,
		// Token: 0x040008D7 RID: 2263
		all_rev_unknown = 3840,
		// Token: 0x040008D8 RID: 2264
		none = 4095
	}
}
