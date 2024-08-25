using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	internal class AndroidReflection
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00003F90 File Offset: 0x00002190
		public static bool IsPrimitive(Type t)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000353A File Offset: 0x0000173A
		public static bool IsAssignableFrom(Type t, Type from)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003FA0 File Offset: 0x000021A0
		private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature)
		{
			IntPtr intPtr;
			IntPtr staticMethodID = AndroidJNISafe.GetStaticMethodID(intPtr, clazz, methodName);
			AndroidJNISafe.DeleteLocalRef(intPtr);
			return staticMethodID;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003FDC File Offset: 0x000021DC
		private static IntPtr GetMethodID(string clazz, string methodName, string signature)
		{
			IntPtr intPtr;
			IntPtr methodID = AndroidJNISafe.GetMethodID(intPtr, clazz, methodName);
			AndroidJNISafe.DeleteLocalRef(intPtr);
			return methodID;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00004018 File Offset: 0x00002218
		public static IntPtr GetConstructorMember(IntPtr jclass, string signature)
		{
			if (!true)
			{
			}
			long num = 0L;
			IntPtr intPtr;
			AndroidJNISafe.DeleteLocalRef(intPtr);
			if (num == 0L)
			{
				return intPtr;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004054 File Offset: 0x00002254
		public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic)
		{
			IntPtr intPtr = AndroidJNISafe.NewString(methodName);
			if (!true)
			{
			}
			long num = 0L;
			IntPtr intPtr2;
			AndroidJNISafe.DeleteLocalRef(intPtr2);
			AndroidJNISafe.DeleteLocalRef(intPtr2);
			if (num == 0L)
			{
				return intPtr2;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000040A4 File Offset: 0x000022A4
		public static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic)
		{
			IntPtr intPtr = AndroidJNISafe.NewString(fieldName);
			if (!true)
			{
			}
			long num = 0L;
			IntPtr intPtr2;
			AndroidJNISafe.DeleteLocalRef(intPtr2);
			AndroidJNISafe.DeleteLocalRef(intPtr2);
			if (num == 0L)
			{
				return intPtr2;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000040F4 File Offset: 0x000022F4
		public static IntPtr GetFieldClass(IntPtr field)
		{
			if (!true)
			{
			}
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004108 File Offset: 0x00002308
		public static string GetFieldSignature(IntPtr field)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000411C File Offset: 0x0000231C
		public static IntPtr NewProxyInstance(IntPtr delegateHandle, IntPtr interfaze)
		{
			if (!true)
			{
			}
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00004130 File Offset: 0x00002330
		public static void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, bool methodNotFound)
		{
			long num = GCHandle.ToIntPtr(GCHandle.Alloc(e)).ToInt64();
			if (!true)
			{
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00004154 File Offset: 0x00002354
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidReflection()
		{
			IntPtr intPtr = AndroidJNISafe.FindClass("com/unity3d/player/ReflectionHelper");
			IntPtr staticMethodID = AndroidReflection.GetStaticMethodID("com/unity3d/player/ReflectionHelper", "getConstructorID", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Constructor;");
			IntPtr staticMethodID2 = AndroidReflection.GetStaticMethodID("com/unity3d/player/ReflectionHelper", "getMethodID", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/reflect/Method;");
			IntPtr staticMethodID3 = AndroidReflection.GetStaticMethodID("com/unity3d/player/ReflectionHelper", "getFieldID", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/reflect/Field;");
			IntPtr staticMethodID4 = AndroidReflection.GetStaticMethodID("com/unity3d/player/ReflectionHelper", "getFieldSignature", "(Ljava/lang/reflect/Field;)Ljava/lang/String;");
			IntPtr staticMethodID5 = AndroidReflection.GetStaticMethodID("com/unity3d/player/ReflectionHelper", "newProxyInstance", "(JLjava/lang/Class;)Ljava/lang/Object;");
			IntPtr staticMethodID6 = AndroidReflection.GetStaticMethodID("com/unity3d/player/ReflectionHelper", "setNativeExceptionOnProxy", "(Ljava/lang/Object;JZ)V");
			IntPtr methodID = AndroidReflection.GetMethodID("java/lang/reflect/Field", "getDeclaringClass", "()Ljava/lang/Class;");
		}

		// Token: 0x0400000C RID: 12
		private static readonly GlobalJavaObjectRef s_ReflectionHelperClass;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr s_ReflectionHelperGetConstructorID;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr s_ReflectionHelperGetMethodID;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr s_ReflectionHelperGetFieldID;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr s_ReflectionHelperGetFieldSignature;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr s_ReflectionHelperNewProxyInstance;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr s_ReflectionHelperSetNativeExceptionOnProxy;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr s_FieldGetDeclaringClass;
	}
}
