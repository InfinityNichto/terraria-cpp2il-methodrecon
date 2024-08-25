using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

namespace UnityEngine.Events
{
	// Token: 0x02000166 RID: 358
	internal class InvokableCallList
	{
		// Token: 0x060006AE RID: 1710 RVA: 0x000021B3 File Offset: 0x000003B3
		public void AddPersistentInvokableCall(BaseInvokableCall call)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x000021B3 File Offset: 0x000003B3
		public void AddListener(BaseInvokableCall call)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0000BFC8 File Offset: 0x0000A1C8
		public void RemoveListener(object targetObj, MethodInfo method)
		{
			int size = this.m_RuntimeCalls._size;
			List<BaseInvokableCall> runtimeCalls = this.m_RuntimeCalls;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x000021B3 File Offset: 0x000003B3
		public void ClearPersistent()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x000021B3 File Offset: 0x000003B3
		public List<BaseInvokableCall> PrepareInvoke()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0000C02C File Offset: 0x0000A22C
		public InvokableCallList()
		{
		}

		// Token: 0x0400065F RID: 1631
		private readonly List<BaseInvokableCall> m_PersistentCalls;

		// Token: 0x04000660 RID: 1632
		private readonly List<BaseInvokableCall> m_RuntimeCalls;

		// Token: 0x04000661 RID: 1633
		private List<BaseInvokableCall> m_ExecutingCalls;

		// Token: 0x04000662 RID: 1634
		private bool m_NeedsUpdate = true;
	}
}
