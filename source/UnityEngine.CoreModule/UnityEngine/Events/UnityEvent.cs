using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
	// Token: 0x02000169 RID: 361
	[Serializable]
	public class UnityEvent<T0, T1> : UnityEventBase
	{
		// Token: 0x060006C5 RID: 1733 RVA: 0x0000C268 File Offset: 0x0000A468
		[RequiredByNativeCode]
		public UnityEvent()
		{
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0000C27C File Offset: 0x0000A47C
		protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			Type type;
			Type type2;
			if ((type == null || type != null) && (type2 == null || type2 != null))
			{
				MethodInfo methodInfo;
				return methodInfo;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000021B3 File Offset: 0x000003B3
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000666 RID: 1638
		private object[] m_InvokeArray;
	}
}
