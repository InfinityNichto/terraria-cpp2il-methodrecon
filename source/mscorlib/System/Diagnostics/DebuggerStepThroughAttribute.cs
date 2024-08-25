using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	// Token: 0x020005C9 RID: 1481
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false)]
	[Serializable]
	public sealed class DebuggerStepThroughAttribute : Attribute
	{
		// Token: 0x06002D4E RID: 11598 RVA: 0x000644DC File Offset: 0x000626DC
		public DebuggerStepThroughAttribute()
		{
		}
	}
}
