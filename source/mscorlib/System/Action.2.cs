using System;

namespace System
{
	// Token: 0x02000074 RID: 116
	public sealed class Action<in T> : MulticastDelegate
	{
		// Token: 0x06000399 RID: 921 RVA: 0x0000B9CC File Offset: 0x00009BCC
		public Action(object @object, IntPtr method)
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		public void Invoke(T obj)
		{
		}
	}
}
