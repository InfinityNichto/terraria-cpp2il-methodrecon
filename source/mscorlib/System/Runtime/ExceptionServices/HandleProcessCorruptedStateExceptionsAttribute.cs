using System;

namespace System.Runtime.ExceptionServices
{
	// Token: 0x0200045B RID: 1115
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class HandleProcessCorruptedStateExceptionsAttribute : Attribute
	{
		// Token: 0x060021E6 RID: 8678 RVA: 0x0004CAA4 File Offset: 0x0004ACA4
		public HandleProcessCorruptedStateExceptionsAttribute()
		{
		}
	}
}
