using System;

namespace System.Collections
{
	// Token: 0x020005E9 RID: 1513
	public interface IEqualityComparer
	{
		// Token: 0x06002DBA RID: 11706
		bool Equals(object x, object y);

		// Token: 0x06002DBB RID: 11707
		int GetHashCode(object obj);
	}
}
