using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000034 RID: 52
	[NativeHeader("Runtime/Utilities/PlayerPrefs.h")]
	public class PlayerPrefs
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00002400 File Offset: 0x00000600
		[NativeMethod("SetInt")]
		private static bool TrySetInt(string key, int value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002414 File Offset: 0x00000614
		[NativeMethod("SetFloat")]
		private static bool TrySetFloat(string key, float value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002428 File Offset: 0x00000628
		[NativeMethod("SetString")]
		private static bool TrySetSetString(string key, string value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000243C File Offset: 0x0000063C
		public static void SetInt(string key, int value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002450 File Offset: 0x00000650
		public static int GetInt(string key, int defaultValue)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002464 File Offset: 0x00000664
		public static int GetInt(string key)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002478 File Offset: 0x00000678
		public static void SetFloat(string key, float value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000248C File Offset: 0x0000068C
		public static float GetFloat(string key, float defaultValue)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000024A0 File Offset: 0x000006A0
		public static float GetFloat(string key)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000024B4 File Offset: 0x000006B4
		public static void SetString(string key, string value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000024C8 File Offset: 0x000006C8
		public static string GetString(string key, string defaultValue)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000024DC File Offset: 0x000006DC
		public static string GetString(string key)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000024F0 File Offset: 0x000006F0
		public static bool HasKey(string key)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002504 File Offset: 0x00000704
		public static void DeleteKey(string key)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002518 File Offset: 0x00000718
		[NativeMethod("DeleteAllWithCallback")]
		public static void DeleteAll()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000252C File Offset: 0x0000072C
		[NativeMethod("Sync")]
		public static void Save()
		{
			throw new MissingMethodException();
		}
	}
}
