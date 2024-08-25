using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
	// Token: 0x02000171 RID: 369
	[Serializable]
	public class UnityEvent : UnityEventBase
	{
		// Token: 0x060006DD RID: 1757 RVA: 0x0000C4C0 File Offset: 0x0000A6C0
		[RequiredByNativeCode]
		public UnityEvent()
		{
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0000C4D4 File Offset: 0x0000A6D4
		public void AddListener(UnityAction call)
		{
			BaseInvokableCall @delegate = UnityEvent.GetDelegate(call);
			this.m_Calls.AddListener(@delegate);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0000C4F4 File Offset: 0x0000A6F4
		protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			MethodInfo methodInfo;
			return methodInfo;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000021B3 File Offset: 0x000003B3
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000021B3 File Offset: 0x000003B3
		private static BaseInvokableCall GetDelegate(UnityAction action)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000021B3 File Offset: 0x000003B3
		public void Invoke()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400066A RID: 1642
		private object[] m_InvokeArray;
	}
}
