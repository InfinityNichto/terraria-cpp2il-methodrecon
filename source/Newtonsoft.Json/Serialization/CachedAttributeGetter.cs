using System;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000B3 RID: 179
	[Preserve]
	internal static class CachedAttributeGetter<T> where T : Attribute
	{
		// Token: 0x060006BA RID: 1722 RVA: 0x0000212A File Offset: 0x0000032A
		public static T GetAttribute(object type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00011DD0 File Offset: 0x0000FFD0
		// Note: this type is marked as 'beforefieldinit'.
		static CachedAttributeGetter()
		{
		}

		// Token: 0x040002E7 RID: 743
		private static readonly ThreadSafeStore<object, T> TypeAttributeCache;
	}
}
