using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020000C3 RID: 195
	[NativeHeader("Runtime/Export/Scripting/NoAllocHelpers.bindings.h")]
	internal sealed class NoAllocHelpers
	{
		// Token: 0x06000356 RID: 854 RVA: 0x00006DD0 File Offset: 0x00004FD0
		public static void ResizeList<T>(List<T> list, int size)
		{
			while (list == null)
			{
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00006DEC File Offset: 0x00004FEC
		public static void EnsureListElemCount<T>(List<T> list, int count)
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000021B3 File Offset: 0x000003B3
		public static int SafeLength<T>(List<T> values)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00006DFC File Offset: 0x00004FFC
		[FreeFunction("NoAllocHelpers_Bindings::Internal_ResizeList")]
		internal static void Internal_ResizeList(object list, int size)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00006E10 File Offset: 0x00005010
		[FreeFunction("NoAllocHelpers_Bindings::ExtractArrayFromList")]
		public static Array ExtractArrayFromList(object list)
		{
			throw new MissingMethodException();
		}
	}
}
