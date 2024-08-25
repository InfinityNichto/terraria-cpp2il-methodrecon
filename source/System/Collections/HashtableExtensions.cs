using System;
using System.Runtime.InteropServices;

namespace System.Collections
{
	// Token: 0x02000416 RID: 1046
	internal static class HashtableExtensions
	{
		// Token: 0x06001C1F RID: 7199 RVA: 0x0004D128 File Offset: 0x0004B328
		public static bool TryGetValue<T>(this Hashtable table, object key, [Out] T value)
		{
			IEqualityComparer keycomparer = table._keycomparer;
			return true;
		}
	}
}
