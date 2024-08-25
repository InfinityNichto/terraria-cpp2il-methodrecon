using System;
using System.Reflection;

namespace System
{
	// Token: 0x0200007F RID: 127
	internal static class SecurityUtils
	{
		// Token: 0x060001EA RID: 490 RVA: 0x0000691C File Offset: 0x00004B1C
		private static void DemandReflectionAccess(Type type)
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000692C File Offset: 0x00004B2C
		private static void DemandGrantSet(Assembly assembly)
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000693C File Offset: 0x00004B3C
		private static bool HasReflectionPermission(Type type)
		{
			return true;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000694C File Offset: 0x00004B4C
		internal static object SecureCreateInstance(Type type)
		{
			object obj;
			return obj;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000695C File Offset: 0x00004B5C
		internal static object SecureCreateInstance(Type type, object[] args, bool allowNonPublic)
		{
			if (!true)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00006970 File Offset: 0x00004B70
		internal static object SecureCreateInstance(Type type, object[] args)
		{
			object obj;
			return obj;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00006980 File Offset: 0x00004B80
		internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic)
		{
			object obj;
			return obj;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00006990 File Offset: 0x00004B90
		internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags)
		{
			if (!true)
			{
			}
			ConstructorInfo constructorInfo;
			return constructorInfo.Invoke(argTypes);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000069AC File Offset: 0x00004BAC
		private static bool GenericArgumentsAreVisible(MethodInfo method)
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000069C0 File Offset: 0x00004BC0
		internal static object MethodInfoInvoke(MethodInfo method, object target, object[] args)
		{
			object obj;
			return obj;
		}
	}
}
