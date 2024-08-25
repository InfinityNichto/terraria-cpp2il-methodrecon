using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	// Token: 0x020005CB RID: 1483
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, Inherited = false)]
	[Serializable]
	public sealed class DebuggerNonUserCodeAttribute : Attribute
	{
		// Token: 0x06002D50 RID: 11600 RVA: 0x00064504 File Offset: 0x00062704
		public DebuggerNonUserCodeAttribute()
		{
		}
	}
}
