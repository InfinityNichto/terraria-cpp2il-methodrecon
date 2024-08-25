using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000076 RID: 118
	[Preserve]
	internal static class TypeExtensions
	{
		// Token: 0x06000438 RID: 1080 RVA: 0x0000B858 File Offset: 0x00009A58
		public static MethodInfo Method(this Delegate d)
		{
			MethodInfo methodInfo;
			return methodInfo;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0000212A File Offset: 0x0000032A
		public static MemberTypes MemberType(this MemberInfo memberInfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0000212A File Offset: 0x0000032A
		public static bool ContainsGenericParameters(this Type type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0000B868 File Offset: 0x00009A68
		public static bool IsInterface(this Type type)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0000212A File Offset: 0x0000032A
		public static bool IsGenericType(this Type type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0000212A File Offset: 0x0000032A
		public static bool IsGenericTypeDefinition(this Type type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0000212A File Offset: 0x0000032A
		public static Type BaseType(this Type type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000212A File Offset: 0x0000032A
		public static Assembly Assembly(this Type type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000212A File Offset: 0x0000032A
		public static bool IsEnum(this Type type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000B878 File Offset: 0x00009A78
		public static bool IsClass(this Type type)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0000B888 File Offset: 0x00009A88
		public static bool IsSealed(this Type type)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000B898 File Offset: 0x00009A98
		public static bool IsAbstract(this Type type)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000B8A8 File Offset: 0x00009AA8
		public static bool IsVisible(this Type type)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000B8B8 File Offset: 0x00009AB8
		public static bool IsValueType(this Type type)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		public static bool AssignableToTypeName(this Type type, string fullTypeName, [Out] Type match)
		{
			bool flag;
			while (flag)
			{
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000B8E4 File Offset: 0x00009AE4
		public static bool AssignableToTypeName(this Type type, string fullTypeName)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000B8F4 File Offset: 0x00009AF4
		public static bool ImplementInterface(this Type type, Type interfaceType)
		{
			bool flag;
			return flag;
		}
	}
}
