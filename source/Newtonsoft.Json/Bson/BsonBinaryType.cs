using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200011E RID: 286
	[Preserve]
	internal enum BsonBinaryType : byte
	{
		// Token: 0x04000425 RID: 1061
		Binary,
		// Token: 0x04000426 RID: 1062
		Function,
		// Token: 0x04000427 RID: 1063
		[Obsolete("This type has been deprecated in the BSON specification. Use Binary instead.")]
		BinaryOld,
		// Token: 0x04000428 RID: 1064
		[Obsolete("This type has been deprecated in the BSON specification. Use Uuid instead.")]
		UuidOld,
		// Token: 0x04000429 RID: 1065
		Uuid,
		// Token: 0x0400042A RID: 1066
		Md5,
		// Token: 0x0400042B RID: 1067
		UserDefined = 128
	}
}
