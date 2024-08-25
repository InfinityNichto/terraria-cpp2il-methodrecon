using System;

namespace System
{
	// Token: 0x02000196 RID: 406
	internal interface TypeIdentifier : TypeName, IEquatable<TypeName>
	{
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000FC1 RID: 4033
		string InternalName { get; }
	}
}
