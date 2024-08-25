using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Runtime.Serialization
{
	// Token: 0x020003D3 RID: 979
	internal static class SerializationEventsCache
	{
		// Token: 0x06001EF5 RID: 7925 RVA: 0x0000207A File Offset: 0x0000027A
		internal static SerializationEvents GetSerializationEventsForType(Type t)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x00043A40 File Offset: 0x00041C40
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationEventsCache()
		{
		}

		// Token: 0x04000F85 RID: 3973
		private static readonly ConcurrentDictionary<Type, SerializationEvents> s_cache;

		// Token: 0x020003D4 RID: 980
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001EF7 RID: 7927 RVA: 0x00043A50 File Offset: 0x00041C50
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001EF8 RID: 7928 RVA: 0x00043A60 File Offset: 0x00041C60
			public <>c()
			{
			}

			// Token: 0x06001EF9 RID: 7929 RVA: 0x0000207A File Offset: 0x0000027A
			internal SerializationEvents <GetSerializationEventsForType>b__1_0(Type type)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000F86 RID: 3974
			public static readonly SerializationEventsCache.<>c <>9;

			// Token: 0x04000F87 RID: 3975
			public static Func<Type, SerializationEvents> <>9__1_0;
		}
	}
}
