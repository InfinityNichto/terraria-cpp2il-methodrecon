using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	// Token: 0x020003EA RID: 1002
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public sealed class OnDeserializingAttribute : Attribute
	{
		// Token: 0x06001F90 RID: 8080 RVA: 0x000455A0 File Offset: 0x000437A0
		public OnDeserializingAttribute()
		{
		}
	}
}
