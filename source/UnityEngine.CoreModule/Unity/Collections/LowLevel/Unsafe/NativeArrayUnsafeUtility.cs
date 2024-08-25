using System;
using Cpp2IlInjected;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000020 RID: 32
	public static class NativeArrayUnsafeUtility
	{
		// Token: 0x0600002D RID: 45 RVA: 0x000021B3 File Offset: 0x000003B3
		public unsafe static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Allocator allocator) where T : struct
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000021B3 File Offset: 0x000003B3
		public unsafe static void* GetUnsafePtr<T>(this NativeArray<T> nativeArray) where T : struct
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
