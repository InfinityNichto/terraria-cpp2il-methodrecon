using System;
using System.Diagnostics;

namespace Mono.Util
{
	// Token: 0x0200000D RID: 13
	[Conditional("FULL_AOT_RUNTIME")]
	[Conditional("UNITY")]
	[AttributeUsage(AttributeTargets.Method)]
	[Conditional("MONOTOUCH")]
	internal sealed class MonoPInvokeCallbackAttribute : Attribute
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00002428 File Offset: 0x00000628
		public MonoPInvokeCallbackAttribute(Type t)
		{
		}
	}
}
