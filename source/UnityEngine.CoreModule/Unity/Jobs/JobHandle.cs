using System;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;

namespace Unity.Jobs
{
	// Token: 0x02000008 RID: 8
	[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
	public struct JobHandle
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000020E0 File Offset: 0x000002E0
		[NativeMethod("ScheduleBatchedScriptingJobs", IsFreeFunction = true, IsThreadSafe = true)]
		public static void ScheduleBatchedJobs()
		{
			throw new MissingMethodException();
		}

		// Token: 0x0400000A RID: 10
		[NativeDisableUnsafePtrRestriction]
		internal IntPtr jobGroup;

		// Token: 0x0400000B RID: 11
		internal int version;
	}
}
