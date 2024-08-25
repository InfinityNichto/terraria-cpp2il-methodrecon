using System;

namespace UnityEngine.Bindings
{
	// Token: 0x02000016 RID: 22
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Method)]
	internal class FreeFunctionAttribute : NativeMethodAttribute
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000024B8 File Offset: 0x000006B8
		public FreeFunctionAttribute()
		{
			this.<IsFreeFunction>k__BackingField = true;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000024D4 File Offset: 0x000006D4
		public FreeFunctionAttribute(string name)
			: base(name)
		{
			this.<IsFreeFunction>k__BackingField = true;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000024F0 File Offset: 0x000006F0
		public FreeFunctionAttribute(string name, bool isThreadSafe)
			: base(name)
		{
			this.<IsFreeFunction>k__BackingField = true;
		}
	}
}
