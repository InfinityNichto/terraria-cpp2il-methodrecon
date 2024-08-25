using System;

namespace System.Reflection
{
	// Token: 0x02000509 RID: 1289
	internal struct MonoEventInfo
	{
		// Token: 0x040014DE RID: 5342
		public Type declaring_type;

		// Token: 0x040014DF RID: 5343
		public Type reflected_type;

		// Token: 0x040014E0 RID: 5344
		public string name;

		// Token: 0x040014E1 RID: 5345
		public MethodInfo add_method;

		// Token: 0x040014E2 RID: 5346
		public MethodInfo remove_method;

		// Token: 0x040014E3 RID: 5347
		public MethodInfo raise_method;

		// Token: 0x040014E4 RID: 5348
		public EventAttributes attrs;

		// Token: 0x040014E5 RID: 5349
		public MethodInfo[] other_methods;
	}
}
