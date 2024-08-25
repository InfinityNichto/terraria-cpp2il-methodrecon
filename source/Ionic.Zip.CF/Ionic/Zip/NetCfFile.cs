using System;
using System.Runtime.InteropServices;

namespace Ionic.Zip
{
	// Token: 0x02000024 RID: 36
	internal class NetCfFile
	{
		// Token: 0x0600014A RID: 330 RVA: 0x00005634 File Offset: 0x00003834
		public static int SetTimes(string filename, DateTime ctime, DateTime atime, DateTime mtime)
		{
			int num;
			IntPtr intPtr = (IntPtr)num;
			int num2 = (int)intPtr;
			long num3;
			byte[] bytes = BitConverter.GetBytes(num3);
			long num4;
			byte[] bytes2 = BitConverter.GetBytes(num4);
			long num5;
			byte[] bytes3 = BitConverter.GetBytes(num5);
			bool flag = NetCfFile.SetFileTime(intPtr, bytes, bytes2, bytes3);
			bool flag2 = NetCfFile.CloseHandle(intPtr);
			return Marshal.GetLastWin32Error();
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000568C File Offset: 0x0000388C
		public static int SetLastWriteTime(string filename, DateTime mtime)
		{
			int num;
			IntPtr intPtr = (IntPtr)num;
			int num2 = (int)intPtr;
			long num3;
			byte[] bytes = BitConverter.GetBytes(num3);
			bool flag = NetCfFile.CloseHandle(intPtr);
			return Marshal.GetLastWin32Error();
		}

		// Token: 0x0600014C RID: 332
		internal static extern int CreateFileCE(string lpFileName, uint dwDesiredAccess, uint dwShareMode, int lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, int hTemplateFile);

		// Token: 0x0600014D RID: 333
		internal static extern uint GetAttributes(string lpFileName);

		// Token: 0x0600014E RID: 334
		internal static extern bool SetAttributes(string lpFileName, uint dwFileAttributes);

		// Token: 0x0600014F RID: 335
		internal static extern bool SetFileTime(IntPtr hFile, byte[] lpCreationTime, byte[] lpLastAccessTime, byte[] lpLastWriteTime);

		// Token: 0x06000150 RID: 336
		internal static extern bool CloseHandle(IntPtr hObject);

		// Token: 0x06000151 RID: 337 RVA: 0x000056C4 File Offset: 0x000038C4
		public NetCfFile()
		{
		}
	}
}
