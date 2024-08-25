using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200043E RID: 1086
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	public sealed class ComVisibleAttribute : Attribute
	{
		// Token: 0x0600216B RID: 8555 RVA: 0x0004C074 File Offset: 0x0004A274
		public ComVisibleAttribute(bool visibility)
		{
		}

		// Token: 0x04001208 RID: 4616
		internal bool _val;
	}
}
