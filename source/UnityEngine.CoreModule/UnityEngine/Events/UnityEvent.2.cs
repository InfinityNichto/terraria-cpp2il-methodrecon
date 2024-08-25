using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
	// Token: 0x0200016B RID: 363
	[Serializable]
	public class UnityEvent<T0> : UnityEventBase
	{
		// Token: 0x060006CA RID: 1738 RVA: 0x0000C2C8 File Offset: 0x0000A4C8
		[RequiredByNativeCode]
		public UnityEvent()
		{
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0000C2DC File Offset: 0x0000A4DC
		public void AddListener(UnityAction<T0> call)
		{
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0000C2EC File Offset: 0x0000A4EC
		public void RemoveListener(UnityAction<T0> call)
		{
			long num = 0L;
			MethodInfo method = call.Method;
			base.RemoveListener(num, method);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0000C30C File Offset: 0x0000A50C
		protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			Type type;
			if (type == null || type != null)
			{
				MethodInfo methodInfo;
				return methodInfo;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x000021B3 File Offset: 0x000003B3
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x000021B3 File Offset: 0x000003B3
		private static BaseInvokableCall GetDelegate(UnityAction<T0> action)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0000C328 File Offset: 0x0000A528
		public void Invoke(T0 arg0)
		{
			List<BaseInvokableCall> list = base.PrepareInvoke();
			int size = list._size;
			if (list != null)
			{
			}
			if (list != null)
			{
			}
			int size2 = list._size;
		}

		// Token: 0x04000667 RID: 1639
		private object[] m_InvokeArray;
	}
}
