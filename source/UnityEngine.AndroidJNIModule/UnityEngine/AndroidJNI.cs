using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
	[NativeConditional("PLATFORM_ANDROID")]
	public static class AndroidJNI
	{
		// Token: 0x060000DD RID: 221 RVA: 0x00004824 File Offset: 0x00002A24
		[ThreadSafe]
		public static int AttachCurrentThread()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00004838 File Offset: 0x00002A38
		[ThreadSafe]
		public static int DetachCurrentThread()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000484C File Offset: 0x00002A4C
		[ThreadSafe]
		public static int GetVersion()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00004860 File Offset: 0x00002A60
		[ThreadSafe]
		public static IntPtr FindClass(string name)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00004874 File Offset: 0x00002A74
		[ThreadSafe]
		public static IntPtr FromReflectedMethod(IntPtr refMethod)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004888 File Offset: 0x00002A88
		[ThreadSafe]
		public static IntPtr FromReflectedField(IntPtr refField)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000489C File Offset: 0x00002A9C
		[ThreadSafe]
		public static IntPtr ToReflectedMethod(IntPtr clazz, IntPtr methodID, bool isStatic)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000048B0 File Offset: 0x00002AB0
		[ThreadSafe]
		public static IntPtr ToReflectedField(IntPtr clazz, IntPtr fieldID, bool isStatic)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000048C4 File Offset: 0x00002AC4
		[ThreadSafe]
		public static IntPtr GetSuperclass(IntPtr clazz)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000048D8 File Offset: 0x00002AD8
		[ThreadSafe]
		public static bool IsAssignableFrom(IntPtr clazz1, IntPtr clazz2)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000048EC File Offset: 0x00002AEC
		[ThreadSafe]
		public static int Throw(IntPtr obj)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00004900 File Offset: 0x00002B00
		[ThreadSafe]
		public static int ThrowNew(IntPtr clazz, string message)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00004914 File Offset: 0x00002B14
		[ThreadSafe]
		public static IntPtr ExceptionOccurred()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00004928 File Offset: 0x00002B28
		[ThreadSafe]
		public static void ExceptionDescribe()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000493C File Offset: 0x00002B3C
		[ThreadSafe]
		public static void ExceptionClear()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004950 File Offset: 0x00002B50
		[ThreadSafe]
		public static void FatalError(string message)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00004964 File Offset: 0x00002B64
		[ThreadSafe]
		public static int PushLocalFrame(int capacity)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00004978 File Offset: 0x00002B78
		[ThreadSafe]
		public static IntPtr PopLocalFrame(IntPtr ptr)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000498C File Offset: 0x00002B8C
		[ThreadSafe]
		public static IntPtr NewGlobalRef(IntPtr obj)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000049A0 File Offset: 0x00002BA0
		[ThreadSafe]
		public static void DeleteGlobalRef(IntPtr obj)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000049B4 File Offset: 0x00002BB4
		[ThreadSafe]
		public static IntPtr NewWeakGlobalRef(IntPtr obj)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000049C8 File Offset: 0x00002BC8
		[ThreadSafe]
		public static void DeleteWeakGlobalRef(IntPtr obj)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000049DC File Offset: 0x00002BDC
		[ThreadSafe]
		public static IntPtr NewLocalRef(IntPtr obj)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000049F0 File Offset: 0x00002BF0
		[ThreadSafe]
		public static void DeleteLocalRef(IntPtr obj)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00004A04 File Offset: 0x00002C04
		[ThreadSafe]
		public static bool IsSameObject(IntPtr obj1, IntPtr obj2)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00004A18 File Offset: 0x00002C18
		[ThreadSafe]
		public static int EnsureLocalCapacity(int capacity)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00004A2C File Offset: 0x00002C2C
		[ThreadSafe]
		public static IntPtr AllocObject(IntPtr clazz)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00004A40 File Offset: 0x00002C40
		[ThreadSafe]
		public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00004A54 File Offset: 0x00002C54
		[ThreadSafe]
		public static IntPtr GetObjectClass(IntPtr obj)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00004A68 File Offset: 0x00002C68
		[ThreadSafe]
		public static bool IsInstanceOf(IntPtr obj, IntPtr clazz)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00004A7C File Offset: 0x00002C7C
		[ThreadSafe]
		public static IntPtr GetMethodID(IntPtr clazz, string name, string sig)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00004A90 File Offset: 0x00002C90
		[ThreadSafe]
		public static IntPtr GetFieldID(IntPtr clazz, string name, string sig)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00004AA4 File Offset: 0x00002CA4
		[ThreadSafe]
		public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[ThreadSafe]
		public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004ACC File Offset: 0x00002CCC
		public static IntPtr NewString(string chars)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00004AE0 File Offset: 0x00002CE0
		[ThreadSafe]
		private static IntPtr NewStringFromStr(string chars)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004AF4 File Offset: 0x00002CF4
		[ThreadSafe]
		public static IntPtr NewString(char[] chars)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004B08 File Offset: 0x00002D08
		[ThreadSafe]
		public static IntPtr NewStringUTF(string bytes)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00004B1C File Offset: 0x00002D1C
		[ThreadSafe]
		public static string GetStringChars(IntPtr str)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00004B30 File Offset: 0x00002D30
		[ThreadSafe]
		public static int GetStringLength(IntPtr str)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00004B44 File Offset: 0x00002D44
		[ThreadSafe]
		public static int GetStringUTFLength(IntPtr str)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00004B58 File Offset: 0x00002D58
		[ThreadSafe]
		public static string GetStringUTFChars(IntPtr str)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00004B6C File Offset: 0x00002D6C
		[ThreadSafe]
		public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00004B80 File Offset: 0x00002D80
		[ThreadSafe]
		public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00004B94 File Offset: 0x00002D94
		[ThreadSafe]
		public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00004BA8 File Offset: 0x00002DA8
		[ThreadSafe]
		public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00004BBC File Offset: 0x00002DBC
		[ThreadSafe]
		public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00004BD0 File Offset: 0x00002DD0
		[Obsolete("AndroidJNI.CallByteMethod is obsolete. Use AndroidJNI.CallSByteMethod method instead")]
		public static byte CallByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00004BE4 File Offset: 0x00002DE4
		[ThreadSafe]
		public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00004BF8 File Offset: 0x00002DF8
		[ThreadSafe]
		public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004C0C File Offset: 0x00002E0C
		[ThreadSafe]
		public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00004C20 File Offset: 0x00002E20
		[ThreadSafe]
		public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00004C34 File Offset: 0x00002E34
		[ThreadSafe]
		public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00004C48 File Offset: 0x00002E48
		[ThreadSafe]
		public static void CallVoidMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00004C5C File Offset: 0x00002E5C
		[ThreadSafe]
		public static string GetStringField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00004C70 File Offset: 0x00002E70
		[ThreadSafe]
		public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00004C84 File Offset: 0x00002E84
		[ThreadSafe]
		public static bool GetBooleanField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00004C98 File Offset: 0x00002E98
		[Obsolete("AndroidJNI.GetByteField is obsolete. Use AndroidJNI.GetSByteField method instead")]
		public static byte GetByteField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00004CAC File Offset: 0x00002EAC
		[ThreadSafe]
		public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00004CC0 File Offset: 0x00002EC0
		[ThreadSafe]
		public static char GetCharField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00004CD4 File Offset: 0x00002ED4
		[ThreadSafe]
		public static short GetShortField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00004CE8 File Offset: 0x00002EE8
		[ThreadSafe]
		public static int GetIntField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00004CFC File Offset: 0x00002EFC
		[ThreadSafe]
		public static long GetLongField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00004D10 File Offset: 0x00002F10
		[ThreadSafe]
		public static float GetFloatField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00004D24 File Offset: 0x00002F24
		[ThreadSafe]
		public static double GetDoubleField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004D38 File Offset: 0x00002F38
		[ThreadSafe]
		public static void SetStringField(IntPtr obj, IntPtr fieldID, string val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00004D4C File Offset: 0x00002F4C
		[ThreadSafe]
		public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00004D60 File Offset: 0x00002F60
		[ThreadSafe]
		public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00004D74 File Offset: 0x00002F74
		[Obsolete("AndroidJNI.SetByteField is obsolete. Use AndroidJNI.SetSByteField method instead")]
		public static void SetByteField(IntPtr obj, IntPtr fieldID, byte val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00004D88 File Offset: 0x00002F88
		[ThreadSafe]
		public static void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00004D9C File Offset: 0x00002F9C
		[ThreadSafe]
		public static void SetCharField(IntPtr obj, IntPtr fieldID, char val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00004DB0 File Offset: 0x00002FB0
		[ThreadSafe]
		public static void SetShortField(IntPtr obj, IntPtr fieldID, short val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00004DC4 File Offset: 0x00002FC4
		[ThreadSafe]
		public static void SetIntField(IntPtr obj, IntPtr fieldID, int val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00004DD8 File Offset: 0x00002FD8
		[ThreadSafe]
		public static void SetLongField(IntPtr obj, IntPtr fieldID, long val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00004DEC File Offset: 0x00002FEC
		[ThreadSafe]
		public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00004E00 File Offset: 0x00003000
		[ThreadSafe]
		public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00004E14 File Offset: 0x00003014
		[ThreadSafe]
		public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00004E28 File Offset: 0x00003028
		[ThreadSafe]
		public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00004E3C File Offset: 0x0000303C
		[ThreadSafe]
		public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00004E50 File Offset: 0x00003050
		[ThreadSafe]
		public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00004E64 File Offset: 0x00003064
		[ThreadSafe]
		public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00004E78 File Offset: 0x00003078
		[Obsolete("AndroidJNI.CallStaticByteMethod is obsolete. Use AndroidJNI.CallStaticSByteMethod method instead")]
		public static byte CallStaticByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00004E8C File Offset: 0x0000308C
		[ThreadSafe]
		public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004EA0 File Offset: 0x000030A0
		[ThreadSafe]
		public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004EB4 File Offset: 0x000030B4
		[ThreadSafe]
		public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004EC8 File Offset: 0x000030C8
		[ThreadSafe]
		public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004EDC File Offset: 0x000030DC
		[ThreadSafe]
		public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00004EF0 File Offset: 0x000030F0
		[ThreadSafe]
		public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00004F04 File Offset: 0x00003104
		[ThreadSafe]
		public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00004F18 File Offset: 0x00003118
		[ThreadSafe]
		public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004F2C File Offset: 0x0000312C
		[ThreadSafe]
		public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00004F40 File Offset: 0x00003140
		[Obsolete("AndroidJNI.GetStaticByteField is obsolete. Use AndroidJNI.GetStaticSByteField method instead")]
		public static byte GetStaticByteField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00004F54 File Offset: 0x00003154
		[ThreadSafe]
		public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00004F68 File Offset: 0x00003168
		[ThreadSafe]
		public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00004F7C File Offset: 0x0000317C
		[ThreadSafe]
		public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00004F90 File Offset: 0x00003190
		[ThreadSafe]
		public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00004FA4 File Offset: 0x000031A4
		[ThreadSafe]
		public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00004FB8 File Offset: 0x000031B8
		[ThreadSafe]
		public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00004FCC File Offset: 0x000031CC
		[ThreadSafe]
		public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00004FE0 File Offset: 0x000031E0
		[ThreadSafe]
		public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00004FF4 File Offset: 0x000031F4
		[ThreadSafe]
		public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00005008 File Offset: 0x00003208
		[ThreadSafe]
		public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000501C File Offset: 0x0000321C
		[Obsolete("AndroidJNI.SetStaticByteField is obsolete. Use AndroidJNI.SetStaticSByteField method instead")]
		public static void SetStaticByteField(IntPtr clazz, IntPtr fieldID, byte val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00005030 File Offset: 0x00003230
		[ThreadSafe]
		public static void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00005044 File Offset: 0x00003244
		[ThreadSafe]
		public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00005058 File Offset: 0x00003258
		[ThreadSafe]
		public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000506C File Offset: 0x0000326C
		[ThreadSafe]
		public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00005080 File Offset: 0x00003280
		[ThreadSafe]
		public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00005094 File Offset: 0x00003294
		[ThreadSafe]
		public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000050A8 File Offset: 0x000032A8
		[ThreadSafe]
		public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000050BC File Offset: 0x000032BC
		[ThreadSafe]
		public static IntPtr ToBooleanArray(bool[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000050D0 File Offset: 0x000032D0
		[ThreadSafe]
		[Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
		public static IntPtr ToByteArray(byte[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000050E4 File Offset: 0x000032E4
		[ThreadSafe]
		public static IntPtr ToSByteArray(sbyte[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000050F8 File Offset: 0x000032F8
		[ThreadSafe]
		public static IntPtr ToCharArray(char[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000510C File Offset: 0x0000330C
		[ThreadSafe]
		public static IntPtr ToShortArray(short[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00005120 File Offset: 0x00003320
		[ThreadSafe]
		public static IntPtr ToIntArray(int[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00005134 File Offset: 0x00003334
		[ThreadSafe]
		public static IntPtr ToLongArray(long[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00005148 File Offset: 0x00003348
		[ThreadSafe]
		public static IntPtr ToFloatArray(float[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000515C File Offset: 0x0000335C
		[ThreadSafe]
		public static IntPtr ToDoubleArray(double[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00005170 File Offset: 0x00003370
		[ThreadSafe]
		public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00005184 File Offset: 0x00003384
		public static IntPtr ToObjectArray(IntPtr[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00005198 File Offset: 0x00003398
		[ThreadSafe]
		public static bool[] FromBooleanArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000051AC File Offset: 0x000033AC
		[ThreadSafe]
		[Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
		public static byte[] FromByteArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000051C0 File Offset: 0x000033C0
		[ThreadSafe]
		public static sbyte[] FromSByteArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000051D4 File Offset: 0x000033D4
		[ThreadSafe]
		public static char[] FromCharArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000051E8 File Offset: 0x000033E8
		[ThreadSafe]
		public static short[] FromShortArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000051FC File Offset: 0x000033FC
		[ThreadSafe]
		public static int[] FromIntArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00005210 File Offset: 0x00003410
		[ThreadSafe]
		public static long[] FromLongArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00005224 File Offset: 0x00003424
		[ThreadSafe]
		public static float[] FromFloatArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00005238 File Offset: 0x00003438
		[ThreadSafe]
		public static double[] FromDoubleArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000524C File Offset: 0x0000344C
		[ThreadSafe]
		public static IntPtr[] FromObjectArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00005260 File Offset: 0x00003460
		[ThreadSafe]
		public static int GetArrayLength(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00005274 File Offset: 0x00003474
		[ThreadSafe]
		public static IntPtr NewBooleanArray(int size)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00005288 File Offset: 0x00003488
		[Obsolete("AndroidJNI.NewByteArray is obsolete. Use AndroidJNI.NewSByteArray method instead")]
		public static IntPtr NewByteArray(int size)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000529C File Offset: 0x0000349C
		[ThreadSafe]
		public static IntPtr NewSByteArray(int size)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000052B0 File Offset: 0x000034B0
		[ThreadSafe]
		public static IntPtr NewCharArray(int size)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000052C4 File Offset: 0x000034C4
		[ThreadSafe]
		public static IntPtr NewShortArray(int size)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000052D8 File Offset: 0x000034D8
		[ThreadSafe]
		public static IntPtr NewIntArray(int size)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000052EC File Offset: 0x000034EC
		[ThreadSafe]
		public static IntPtr NewLongArray(int size)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00005300 File Offset: 0x00003500
		[ThreadSafe]
		public static IntPtr NewFloatArray(int size)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00005314 File Offset: 0x00003514
		[ThreadSafe]
		public static IntPtr NewDoubleArray(int size)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00005328 File Offset: 0x00003528
		[ThreadSafe]
		public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000533C File Offset: 0x0000353C
		[ThreadSafe]
		public static bool GetBooleanArrayElement(IntPtr array, int index)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00005350 File Offset: 0x00003550
		[Obsolete("AndroidJNI.GetByteArrayElement is obsolete. Use AndroidJNI.GetSByteArrayElement method instead")]
		public static byte GetByteArrayElement(IntPtr array, int index)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00005364 File Offset: 0x00003564
		[ThreadSafe]
		public static sbyte GetSByteArrayElement(IntPtr array, int index)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00005378 File Offset: 0x00003578
		[ThreadSafe]
		public static char GetCharArrayElement(IntPtr array, int index)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000538C File Offset: 0x0000358C
		[ThreadSafe]
		public static short GetShortArrayElement(IntPtr array, int index)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000053A0 File Offset: 0x000035A0
		[ThreadSafe]
		public static int GetIntArrayElement(IntPtr array, int index)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000053B4 File Offset: 0x000035B4
		[ThreadSafe]
		public static long GetLongArrayElement(IntPtr array, int index)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000053C8 File Offset: 0x000035C8
		[ThreadSafe]
		public static float GetFloatArrayElement(IntPtr array, int index)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000053DC File Offset: 0x000035DC
		[ThreadSafe]
		public static double GetDoubleArrayElement(IntPtr array, int index)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000053F0 File Offset: 0x000035F0
		[ThreadSafe]
		public static IntPtr GetObjectArrayElement(IntPtr array, int index)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00005404 File Offset: 0x00003604
		[Obsolete("AndroidJNI.SetBooleanArrayElement(IntPtr, int, byte) is obsolete. Use AndroidJNI.SetBooleanArrayElement(IntPtr, int, bool) method instead")]
		public static void SetBooleanArrayElement(IntPtr array, int index, byte val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00005418 File Offset: 0x00003618
		[ThreadSafe]
		public static void SetBooleanArrayElement(IntPtr array, int index, bool val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000542C File Offset: 0x0000362C
		[Obsolete("AndroidJNI.SetByteArrayElement is obsolete. Use AndroidJNI.SetSByteArrayElement method instead")]
		public static void SetByteArrayElement(IntPtr array, int index, sbyte val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00005440 File Offset: 0x00003640
		[ThreadSafe]
		public static void SetSByteArrayElement(IntPtr array, int index, sbyte val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00005454 File Offset: 0x00003654
		[ThreadSafe]
		public static void SetCharArrayElement(IntPtr array, int index, char val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00005468 File Offset: 0x00003668
		[ThreadSafe]
		public static void SetShortArrayElement(IntPtr array, int index, short val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000547C File Offset: 0x0000367C
		[ThreadSafe]
		public static void SetIntArrayElement(IntPtr array, int index, int val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00005490 File Offset: 0x00003690
		[ThreadSafe]
		public static void SetLongArrayElement(IntPtr array, int index, long val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000054A4 File Offset: 0x000036A4
		[ThreadSafe]
		public static void SetFloatArrayElement(IntPtr array, int index, float val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000054B8 File Offset: 0x000036B8
		[ThreadSafe]
		public static void SetDoubleArrayElement(IntPtr array, int index, double val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000054CC File Offset: 0x000036CC
		[ThreadSafe]
		public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj)
		{
			throw new MissingMethodException();
		}
	}
}
