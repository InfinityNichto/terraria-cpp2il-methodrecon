using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	// Token: 0x020005CF RID: 1487
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public sealed class DebuggerBrowsableAttribute : Attribute
	{
		// Token: 0x06002D52 RID: 11602 RVA: 0x00064534 File Offset: 0x00062734
		public DebuggerBrowsableAttribute(DebuggerBrowsableState state)
		{
			this.state = state;
		}

		// Token: 0x0400195A RID: 6490
		private DebuggerBrowsableState state;
	}
}
