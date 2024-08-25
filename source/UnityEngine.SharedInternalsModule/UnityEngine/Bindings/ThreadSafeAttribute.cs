using System;

namespace UnityEngine.Bindings
{
	// Token: 0x02000017 RID: 23
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Method)]
	internal class ThreadSafeAttribute : NativeMethodAttribute
	{
		// Token: 0x06000033 RID: 51 RVA: 0x0000250C File Offset: 0x0000070C
		public ThreadSafeAttribute()
		{
			this.<IsThreadSafe>k__BackingField = true;
		}
	}
}
