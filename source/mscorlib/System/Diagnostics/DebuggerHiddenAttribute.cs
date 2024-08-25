using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	// Token: 0x020005CA RID: 1482
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, Inherited = false)]
	[Serializable]
	public sealed class DebuggerHiddenAttribute : Attribute
	{
		// Token: 0x06002D4F RID: 11599 RVA: 0x000644F0 File Offset: 0x000626F0
		public DebuggerHiddenAttribute()
		{
		}
	}
}
