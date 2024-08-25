using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	// Token: 0x020005D0 RID: 1488
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
	[ComVisible(true)]
	public sealed class DebuggerTypeProxyAttribute : Attribute
	{
		// Token: 0x06002D53 RID: 11603 RVA: 0x00064550 File Offset: 0x00062750
		public DebuggerTypeProxyAttribute(Type type)
		{
			if (!true)
			{
			}
			this.typeName = type;
		}

		// Token: 0x0400195B RID: 6491
		private string typeName;
	}
}
