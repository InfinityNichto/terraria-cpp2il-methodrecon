using System;

namespace System.Collections
{
	// Token: 0x020005EC RID: 1516
	public interface IStructuralEquatable
	{
		// Token: 0x06002DC8 RID: 11720
		bool Equals(object other, IEqualityComparer comparer);

		// Token: 0x06002DC9 RID: 11721
		int GetHashCode(IEqualityComparer comparer);
	}
}
