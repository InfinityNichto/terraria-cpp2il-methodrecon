using System;

namespace System
{
	// Token: 0x02000076 RID: 118
	public sealed class Action<in T1, in T2, in T3> : MulticastDelegate
	{
		// Token: 0x0600039D RID: 925 RVA: 0x0000BA24 File Offset: 0x00009C24
		public Action(object @object, IntPtr method)
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000BA40 File Offset: 0x00009C40
		public void Invoke(T1 arg1, T2 arg2, T3 arg3)
		{
		}
	}
}
