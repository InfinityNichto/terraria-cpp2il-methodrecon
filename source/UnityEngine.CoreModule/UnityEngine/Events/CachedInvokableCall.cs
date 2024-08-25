using System;
using System.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x02000162 RID: 354
	internal class CachedInvokableCall<T> : InvokableCall<T>
	{
		// Token: 0x0600069E RID: 1694 RVA: 0x0000BD50 File Offset: 0x00009F50
		public CachedInvokableCall(Object target, MethodInfo theFunction, T argument)
		{
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0000BD60 File Offset: 0x00009F60
		public override void Invoke(object[] args)
		{
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0000BD70 File Offset: 0x00009F70
		public override void Invoke(T arg0)
		{
		}

		// Token: 0x04000653 RID: 1619
		private readonly T m_Arg1;
	}
}
