using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	// Token: 0x020005D1 RID: 1489
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Delegate, AllowMultiple = true)]
	[ComVisible(true)]
	public sealed class DebuggerDisplayAttribute : Attribute
	{
		// Token: 0x06002D54 RID: 11604 RVA: 0x00064570 File Offset: 0x00062770
		public DebuggerDisplayAttribute(string value)
		{
			if (value != null)
			{
				this.value = value;
				return;
			}
			this.value = "";
			this.name = "";
			this.type = "";
		}

		// Token: 0x0400195C RID: 6492
		private string name;

		// Token: 0x0400195D RID: 6493
		private string value;

		// Token: 0x0400195E RID: 6494
		private string type;
	}
}
