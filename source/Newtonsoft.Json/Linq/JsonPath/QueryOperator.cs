using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000EE RID: 238
	[Preserve]
	internal enum QueryOperator
	{
		// Token: 0x040003D1 RID: 977
		None,
		// Token: 0x040003D2 RID: 978
		Equals,
		// Token: 0x040003D3 RID: 979
		NotEquals,
		// Token: 0x040003D4 RID: 980
		Exists,
		// Token: 0x040003D5 RID: 981
		LessThan,
		// Token: 0x040003D6 RID: 982
		LessThanOrEquals,
		// Token: 0x040003D7 RID: 983
		GreaterThan,
		// Token: 0x040003D8 RID: 984
		GreaterThanOrEquals,
		// Token: 0x040003D9 RID: 985
		And,
		// Token: 0x040003DA RID: 986
		Or
	}
}
