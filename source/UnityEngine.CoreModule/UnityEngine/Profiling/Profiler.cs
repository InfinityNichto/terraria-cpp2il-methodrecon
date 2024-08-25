using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Profiling
{
	// Token: 0x020000EF RID: 239
	[NativeHeader("Runtime/Profiler/ScriptBindings/Profiler.bindings.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Utilities/MemoryUtilities.h")]
	[NativeHeader("Runtime/Allocator/MemoryManager.h")]
	[NativeHeader("Runtime/Profiler/Profiler.h")]
	[MovedFrom("UnityEngine")]
	[NativeHeader("Runtime/ScriptingBackend/ScriptingApi.h")]
	public sealed class Profiler
	{
		// Token: 0x0600051A RID: 1306 RVA: 0x0000936C File Offset: 0x0000756C
		[NativeConditional("ENABLE_PROFILER")]
		public static void EndThreadProfiling()
		{
		}
	}
}
