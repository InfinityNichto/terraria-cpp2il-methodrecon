using System;

namespace System.Diagnostics
{
	// Token: 0x020005C8 RID: 1480
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false)]
	internal sealed class StackTraceHiddenAttribute : Attribute
	{
		// Token: 0x06002D4D RID: 11597 RVA: 0x000644C8 File Offset: 0x000626C8
		public StackTraceHiddenAttribute()
		{
		}
	}
}
