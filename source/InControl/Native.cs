using System;
using System.Runtime.InteropServices;

namespace InControl
{
	// Token: 0x0200003C RID: 60
	internal static class Native
	{
		// Token: 0x06000324 RID: 804 RVA: 0x0000965C File Offset: 0x0000785C
		public static void Init(NativeInputOptions options)
		{
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000966C File Offset: 0x0000786C
		public static void Stop()
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000967C File Offset: 0x0000787C
		public static void GetVersionInfo([Out] NativeVersionInfo versionInfo)
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000968C File Offset: 0x0000788C
		public static bool GetDeviceInfo(uint handle, [Out] InputDeviceInfo deviceInfo)
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000969C File Offset: 0x0000789C
		public static bool GetDeviceState(uint handle, [Out] IntPtr deviceState)
		{
		}

		// Token: 0x06000329 RID: 809 RVA: 0x000096AC File Offset: 0x000078AC
		public static int GetDeviceEvents([Out] IntPtr deviceEvents)
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x000096BC File Offset: 0x000078BC
		public static void SetHapticState(uint handle, byte motor0, byte motor1)
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000096CC File Offset: 0x000078CC
		public static void SetLightColor(uint handle, byte red, byte green, byte blue)
		{
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000096DC File Offset: 0x000078DC
		public static void SetLightFlash(uint handle, byte flashOnDuration, byte flashOffDuration)
		{
		}

		// Token: 0x040002CF RID: 719
		private const string libraryName = "InControlNative";
	}
}
