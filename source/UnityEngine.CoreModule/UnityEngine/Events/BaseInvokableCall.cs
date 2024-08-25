using System;
using System.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x0200015C RID: 348
	internal abstract class BaseInvokableCall
	{
		// Token: 0x06000681 RID: 1665 RVA: 0x0000B90C File Offset: 0x00009B0C
		protected BaseInvokableCall()
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0000B920 File Offset: 0x00009B20
		protected BaseInvokableCall(object target, MethodInfo function)
		{
			if (function == null)
			{
				return;
			}
			bool isStatic = function.IsStatic;
			if (target != null)
			{
				return;
			}
		}

		// Token: 0x06000683 RID: 1667
		public abstract void Invoke(object[] args);

		// Token: 0x06000684 RID: 1668 RVA: 0x0000B944 File Offset: 0x00009B44
		protected static void ThrowOnInvalidArg<T>(object arg)
		{
			if (arg == null || arg != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0000B964 File Offset: 0x00009B64
		protected static bool AllowInvoke(Delegate @delegate)
		{
			int num = 1;
			if (num != 0)
			{
			}
			if (num == 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000686 RID: 1670
		public abstract bool Find(object targetObj, MethodInfo method);
	}
}
