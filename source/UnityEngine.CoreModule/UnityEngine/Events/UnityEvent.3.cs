using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
	// Token: 0x0200016D RID: 365
	[Serializable]
	public class UnityEvent<T0, T1, T2> : UnityEventBase
	{
		// Token: 0x060006D3 RID: 1747 RVA: 0x0000C398 File Offset: 0x0000A598
		[RequiredByNativeCode]
		public UnityEvent()
		{
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0000C3AC File Offset: 0x0000A5AC
		protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			Type type;
			Type type2;
			Type type3;
			if ((type == null || type != null) && (type2 == null || type2 != null) && (type3 == null || type3 != null))
			{
				MethodInfo methodInfo;
				return methodInfo;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x000021B3 File Offset: 0x000003B3
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000668 RID: 1640
		private object[] m_InvokeArray;
	}
}
