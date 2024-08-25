using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType.DoubleColon)]
	[UsedByNativeCode]
	[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
	[NativeConditional("PLATFORM_ANDROID")]
	public static class AndroidJNIHelper
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000046D4 File Offset: 0x000028D4
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x000046E8 File Offset: 0x000028E8
		public static bool debug
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000046FC File Offset: 0x000028FC
		public static IntPtr GetConstructorID(IntPtr javaClass)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000470C File Offset: 0x0000290C
		public static IntPtr GetConstructorID(IntPtr javaClass, [DefaultValue(null)] string signature)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000471C File Offset: 0x0000291C
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000472C File Offset: 0x0000292C
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName, [DefaultValue(null)] string signature)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000473C File Offset: 0x0000293C
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName, [DefaultValue(null)] string signature, [DefaultValue("false")] bool isStatic)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000474C File Offset: 0x0000294C
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000475C File Offset: 0x0000295C
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, [DefaultValue(null)] string signature)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000476C File Offset: 0x0000296C
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, [DefaultValue(null)] string signature, [DefaultValue("false")] bool isStatic)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000477C File Offset: 0x0000297C
		public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000478C File Offset: 0x0000298C
		public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy)
		{
			GCHandle gchandle;
			IntPtr intPtr = GCHandle.ToIntPtr(gchandle);
			IntPtr intPtr2;
			return intPtr2;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000047B0 File Offset: 0x000029B0
		public static IntPtr ConvertToJNIArray(Array array)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000047C0 File Offset: 0x000029C0
		public static jvalue[] CreateJNIArgArray(object[] args)
		{
			jvalue[] array;
			return array;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000047D0 File Offset: 0x000029D0
		public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs)
		{
			_AndroidJNIHelper.DeleteJNIArgArray(args, jniArgs);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000047E4 File Offset: 0x000029E4
		public static IntPtr GetConstructorID(IntPtr jclass, object[] args)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000047F4 File Offset: 0x000029F4
		public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00004804 File Offset: 0x00002A04
		public static string GetSignature(object obj)
		{
			string text;
			return text;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004814 File Offset: 0x00002A14
		public static string GetSignature(object[] args)
		{
			string text;
			return text;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000353A File Offset: 0x0000173A
		public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000353A File Offset: 0x0000173A
		public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000353A File Offset: 0x0000173A
		public static IntPtr GetFieldID<FieldType>(IntPtr jclass, string fieldName, bool isStatic)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000353A File Offset: 0x0000173A
		public static string GetSignature<ReturnType>(object[] args)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
