using System;
using System.Reflection;
using UnityEngine.Events;

// Token: 0x02000301 RID: 769
public static class UnityEventBaseExtensions
{
	// Token: 0x060011CF RID: 4559 RVA: 0x000570D4 File Offset: 0x000552D4
	public static MethodInfo FindMethod(this UnityEventBase eventBase, string name, object listener, PersistentListenerMode mode, Type argumentType)
	{
		if (listener == null)
		{
		}
		if (listener == null)
		{
		}
		Type type;
		Type type2;
		MethodInfo methodInfo;
		if (type == null)
		{
			if (listener == null)
			{
			}
			if (type2 == null)
			{
				return methodInfo;
			}
		}
		if (type2 == null)
		{
			throw new ArrayTypeMismatchException();
		}
		return methodInfo;
	}
}
