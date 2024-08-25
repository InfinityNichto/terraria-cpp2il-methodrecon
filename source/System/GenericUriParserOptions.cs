using System;

namespace System
{
	// Token: 0x02000081 RID: 129
	[Flags]
	public enum GenericUriParserOptions
	{
		// Token: 0x0400016E RID: 366
		Default = 0,
		// Token: 0x0400016F RID: 367
		GenericAuthority = 1,
		// Token: 0x04000170 RID: 368
		AllowEmptyAuthority = 2,
		// Token: 0x04000171 RID: 369
		NoUserInfo = 4,
		// Token: 0x04000172 RID: 370
		NoPort = 8,
		// Token: 0x04000173 RID: 371
		NoQuery = 16,
		// Token: 0x04000174 RID: 372
		NoFragment = 32,
		// Token: 0x04000175 RID: 373
		DontConvertPathBackslashes = 64,
		// Token: 0x04000176 RID: 374
		DontCompressPath = 128,
		// Token: 0x04000177 RID: 375
		DontUnescapePathDotsAndSlashes = 256,
		// Token: 0x04000178 RID: 376
		Idn = 512,
		// Token: 0x04000179 RID: 377
		IriParsing = 1024
	}
}
