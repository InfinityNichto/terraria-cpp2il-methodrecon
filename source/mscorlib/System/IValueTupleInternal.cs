using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x0200011A RID: 282
	internal interface IValueTupleInternal : ITuple
	{
		// Token: 0x06000B0A RID: 2826
		int GetHashCode(IEqualityComparer comparer);

		// Token: 0x06000B0B RID: 2827
		string ToStringEnd();
	}
}
