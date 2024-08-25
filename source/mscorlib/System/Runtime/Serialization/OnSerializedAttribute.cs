using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	// Token: 0x020003E9 RID: 1001
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	[ComVisible(true)]
	public sealed class OnSerializedAttribute : Attribute
	{
		// Token: 0x06001F8F RID: 8079 RVA: 0x0004558C File Offset: 0x0004378C
		public OnSerializedAttribute()
		{
		}
	}
}
