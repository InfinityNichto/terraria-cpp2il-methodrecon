using System;

namespace System
{
	// Token: 0x02000075 RID: 117
	public sealed class Action<in T1, in T2> : MulticastDelegate
	{
		// Token: 0x0600039B RID: 923 RVA: 0x0000B9F8 File Offset: 0x00009BF8
		public Action(object @object, IntPtr method)
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000BA14 File Offset: 0x00009C14
		public void Invoke(T1 arg1, T2 arg2)
		{
		}
	}
}
