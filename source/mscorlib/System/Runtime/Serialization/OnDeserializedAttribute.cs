using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	// Token: 0x020003EB RID: 1003
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public sealed class OnDeserializedAttribute : Attribute
	{
		// Token: 0x06001F91 RID: 8081 RVA: 0x000455B4 File Offset: 0x000437B4
		public OnDeserializedAttribute()
		{
		}
	}
}
