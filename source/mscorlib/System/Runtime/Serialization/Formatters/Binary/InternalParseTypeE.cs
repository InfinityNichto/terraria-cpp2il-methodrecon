using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003F7 RID: 1015
	internal enum InternalParseTypeE
	{
		// Token: 0x0400101C RID: 4124
		Empty,
		// Token: 0x0400101D RID: 4125
		SerializedStreamHeader,
		// Token: 0x0400101E RID: 4126
		Object,
		// Token: 0x0400101F RID: 4127
		Member,
		// Token: 0x04001020 RID: 4128
		ObjectEnd,
		// Token: 0x04001021 RID: 4129
		MemberEnd,
		// Token: 0x04001022 RID: 4130
		Headers,
		// Token: 0x04001023 RID: 4131
		HeadersEnd,
		// Token: 0x04001024 RID: 4132
		SerializedStreamHeaderEnd,
		// Token: 0x04001025 RID: 4133
		Envelope,
		// Token: 0x04001026 RID: 4134
		EnvelopeEnd,
		// Token: 0x04001027 RID: 4135
		Body,
		// Token: 0x04001028 RID: 4136
		BodyEnd
	}
}
