using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
	// Token: 0x0200016F RID: 367
	[Serializable]
	public class UnityEvent<T0, T1, T2, T3> : UnityEventBase
	{
		// Token: 0x060006D8 RID: 1752 RVA: 0x0000C404 File Offset: 0x0000A604
		[RequiredByNativeCode]
		public UnityEvent()
		{
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0000C418 File Offset: 0x0000A618
		protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			Type type;
			Type type2;
			Type type3;
			Type type4;
			if ((type == null || type != null) && (type2 == null || type2 != null) && (type3 == null || type3 != null) && (type4 == null || type4 != null))
			{
				MethodInfo methodInfo;
				return methodInfo;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x000021B3 File Offset: 0x000003B3
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000669 RID: 1641
		private object[] m_InvokeArray;
	}
}
