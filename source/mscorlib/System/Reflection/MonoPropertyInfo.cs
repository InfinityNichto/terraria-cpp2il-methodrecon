using System;

namespace System.Reflection
{
	// Token: 0x02000512 RID: 1298
	internal struct MonoPropertyInfo
	{
		// Token: 0x04001500 RID: 5376
		public Type parent;

		// Token: 0x04001501 RID: 5377
		public Type declaring_type;

		// Token: 0x04001502 RID: 5378
		public string name;

		// Token: 0x04001503 RID: 5379
		public MethodInfo get_method;

		// Token: 0x04001504 RID: 5380
		public MethodInfo set_method;

		// Token: 0x04001505 RID: 5381
		public PropertyAttributes attrs;
	}
}
