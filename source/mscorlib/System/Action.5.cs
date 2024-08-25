using System;

namespace System
{
	// Token: 0x02000077 RID: 119
	public sealed class Action<in T1, in T2, in T3, in T4> : MulticastDelegate
	{
		// Token: 0x0600039F RID: 927 RVA: 0x0000BA50 File Offset: 0x00009C50
		public Action(object @object, IntPtr method)
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000BA70 File Offset: 0x00009C70
		public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}
	}
}
