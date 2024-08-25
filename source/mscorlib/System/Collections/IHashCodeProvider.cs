using System;

namespace System.Collections
{
	// Token: 0x0200060F RID: 1551
	[Obsolete("Please use IEqualityComparer instead.")]
	public interface IHashCodeProvider
	{
		// Token: 0x06002F56 RID: 12118
		int GetHashCode(object obj);
	}
}
