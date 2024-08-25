using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000167 RID: 359
	[StructLayout(0)]
	internal class MonoTypeInfo
	{
		// Token: 0x06000E8F RID: 3727 RVA: 0x0001F7BC File Offset: 0x0001D9BC
		public MonoTypeInfo()
		{
		}

		// Token: 0x0400062E RID: 1582
		public string full_name;

		// Token: 0x0400062F RID: 1583
		public RuntimeConstructorInfo default_ctor;
	}
}
