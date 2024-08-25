using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	// Token: 0x020003E8 RID: 1000
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public sealed class OnSerializingAttribute : Attribute
	{
		// Token: 0x06001F8E RID: 8078 RVA: 0x00045578 File Offset: 0x00043778
		public OnSerializingAttribute()
		{
		}
	}
}
