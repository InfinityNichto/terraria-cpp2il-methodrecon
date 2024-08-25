using System;

namespace Mono.Interop
{
	// Token: 0x0200002F RID: 47
	[AttributeUsage(AttributeTargets.Method)]
	internal sealed class MonoPInvokeCallbackAttribute : Attribute
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00002FAC File Offset: 0x000011AC
		public MonoPInvokeCallbackAttribute(Type t)
		{
		}
	}
}
