using System;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	internal class AndroidJNISafe
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static void CheckException()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020AC File Offset: 0x000002AC
		public static void DeleteGlobalRef(IntPtr globalref)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020C0 File Offset: 0x000002C0
		public static void DeleteWeakGlobalRef(IntPtr globalref)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020D4 File Offset: 0x000002D4
		public static void DeleteLocalRef(IntPtr localref)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020E8 File Offset: 0x000002E8
		public static IntPtr NewString(string chars)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000211C File Offset: 0x0000031C
		public static string GetStringChars(IntPtr str)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002150 File Offset: 0x00000350
		public static IntPtr GetObjectClass(IntPtr ptr)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002184 File Offset: 0x00000384
		public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021B8 File Offset: 0x000003B8
		public static IntPtr GetMethodID(IntPtr obj, string name, string sig)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000021EC File Offset: 0x000003EC
		public static IntPtr GetFieldID(IntPtr clazz, string name, string sig)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002220 File Offset: 0x00000420
		public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002254 File Offset: 0x00000454
		public static IntPtr FromReflectedMethod(IntPtr refMethod)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002288 File Offset: 0x00000488
		public static IntPtr FindClass(string name)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000022BC File Offset: 0x000004BC
		public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000022F0 File Offset: 0x000004F0
		public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002328 File Offset: 0x00000528
		public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002360 File Offset: 0x00000560
		public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002398 File Offset: 0x00000598
		public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000023D0 File Offset: 0x000005D0
		public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002408 File Offset: 0x00000608
		public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002440 File Offset: 0x00000640
		public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002478 File Offset: 0x00000678
		public static void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000024B0 File Offset: 0x000006B0
		public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000024E8 File Offset: 0x000006E8
		public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002520 File Offset: 0x00000720
		public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002554 File Offset: 0x00000754
		public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002588 File Offset: 0x00000788
		public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000025BC File Offset: 0x000007BC
		public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000025F0 File Offset: 0x000007F0
		public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002624 File Offset: 0x00000824
		public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002658 File Offset: 0x00000858
		public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000268C File Offset: 0x0000088C
		public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000026C0 File Offset: 0x000008C0
		public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000026F4 File Offset: 0x000008F4
		public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002728 File Offset: 0x00000928
		public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002760 File Offset: 0x00000960
		public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002794 File Offset: 0x00000994
		public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000027C8 File Offset: 0x000009C8
		public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000027FC File Offset: 0x000009FC
		public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002830 File Offset: 0x00000A30
		public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002864 File Offset: 0x00000A64
		public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002898 File Offset: 0x00000A98
		public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000028CC File Offset: 0x00000ACC
		public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002900 File Offset: 0x00000B00
		public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002934 File Offset: 0x00000B34
		public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002968 File Offset: 0x00000B68
		public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000029A0 File Offset: 0x00000BA0
		public static void SetStringField(IntPtr obj, IntPtr fieldID, string val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000029D8 File Offset: 0x00000BD8
		public static void SetCharField(IntPtr obj, IntPtr fieldID, char val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002A10 File Offset: 0x00000C10
		public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002A48 File Offset: 0x00000C48
		public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002A80 File Offset: 0x00000C80
		public static void SetLongField(IntPtr obj, IntPtr fieldID, long val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002AB8 File Offset: 0x00000CB8
		public static void SetShortField(IntPtr obj, IntPtr fieldID, short val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002AF0 File Offset: 0x00000CF0
		public static void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002B28 File Offset: 0x00000D28
		public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002B60 File Offset: 0x00000D60
		public static void SetIntField(IntPtr obj, IntPtr fieldID, int val)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002B98 File Offset: 0x00000D98
		public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002BCC File Offset: 0x00000DCC
		public static string GetStringField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002C00 File Offset: 0x00000E00
		public static char GetCharField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002C34 File Offset: 0x00000E34
		public static double GetDoubleField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002C68 File Offset: 0x00000E68
		public static float GetFloatField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002C98 File Offset: 0x00000E98
		public static long GetLongField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002CCC File Offset: 0x00000ECC
		public static short GetShortField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002D00 File Offset: 0x00000F00
		public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002D34 File Offset: 0x00000F34
		public static bool GetBooleanField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002D68 File Offset: 0x00000F68
		public static int GetIntField(IntPtr obj, IntPtr fieldID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002D9C File Offset: 0x00000F9C
		public static void CallVoidMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002DD4 File Offset: 0x00000FD4
		public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002E08 File Offset: 0x00001008
		public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002E3C File Offset: 0x0000103C
		public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002E70 File Offset: 0x00001070
		public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002EA4 File Offset: 0x000010A4
		public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002ED8 File Offset: 0x000010D8
		public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002F0C File Offset: 0x0000110C
		public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002F40 File Offset: 0x00001140
		public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002F74 File Offset: 0x00001174
		public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002FA8 File Offset: 0x000011A8
		public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002FDC File Offset: 0x000011DC
		public static char[] FromCharArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003010 File Offset: 0x00001210
		public static double[] FromDoubleArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003044 File Offset: 0x00001244
		public static float[] FromFloatArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003078 File Offset: 0x00001278
		public static long[] FromLongArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000030AC File Offset: 0x000012AC
		public static short[] FromShortArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000030E0 File Offset: 0x000012E0
		public static byte[] FromByteArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003114 File Offset: 0x00001314
		public static sbyte[] FromSByteArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003148 File Offset: 0x00001348
		public static bool[] FromBooleanArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000317C File Offset: 0x0000137C
		public static int[] FromIntArray(IntPtr array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000031B0 File Offset: 0x000013B0
		public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000031E4 File Offset: 0x000013E4
		public static IntPtr ToCharArray(char[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003218 File Offset: 0x00001418
		public static IntPtr ToDoubleArray(double[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000324C File Offset: 0x0000144C
		public static IntPtr ToFloatArray(float[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003280 File Offset: 0x00001480
		public static IntPtr ToLongArray(long[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000032B4 File Offset: 0x000014B4
		public static IntPtr ToShortArray(short[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000032E8 File Offset: 0x000014E8
		public static IntPtr ToByteArray(byte[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000331C File Offset: 0x0000151C
		public static IntPtr ToSByteArray(sbyte[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003350 File Offset: 0x00001550
		public static IntPtr ToBooleanArray(bool[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003384 File Offset: 0x00001584
		public static IntPtr ToIntArray(int[] array)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000033B8 File Offset: 0x000015B8
		public static IntPtr GetObjectArrayElement(IntPtr array, int index)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000033EC File Offset: 0x000015EC
		public static int GetArrayLength(IntPtr array)
		{
			throw new MissingMethodException();
		}
	}
}
