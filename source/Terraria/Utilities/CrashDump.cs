using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;

namespace Terraria.Utilities
{
	// Token: 0x020004F2 RID: 1266
	public static class CrashDump
	{
		// Token: 0x060030AA RID: 12458 RVA: 0x001F6BEC File Offset: 0x001F4DEC
		public static bool WriteException(CrashDump.Options options, string outputDirectory = ".")
		{
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x001F6BFC File Offset: 0x001F4DFC
		public static bool Write(CrashDump.Options options, string outputDirectory = ".")
		{
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x001F6C0C File Offset: 0x001F4E0C
		private static string CreateDumpName()
		{
			if (!true)
			{
			}
			DateTime dateTime = DateTime.Now.ToLocalTime();
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			if (text == null || text != null)
			{
				int managedThreadId = Thread.CurrentThread.ManagedThreadId;
				string text2;
				return text2;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x001F6C50 File Offset: 0x001F4E50
		private static bool Write(CrashDump.Options options, CrashDump.ExceptionInfo exceptionInfo, string outputDirectory)
		{
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x001F6C60 File Offset: 0x001F4E60
		private static bool Write(SafeHandle fileHandle, CrashDump.Options options, CrashDump.ExceptionInfo exceptionInfo)
		{
		}

		// Token: 0x020004F3 RID: 1267
		[Flags]
		public enum Options : uint
		{
			// Token: 0x04003AA7 RID: 15015
			Normal = 0U,
			// Token: 0x04003AA8 RID: 15016
			WithDataSegs = 1U,
			// Token: 0x04003AA9 RID: 15017
			WithFullMemory = 2U,
			// Token: 0x04003AAA RID: 15018
			WithHandleData = 4U,
			// Token: 0x04003AAB RID: 15019
			FilterMemory = 8U,
			// Token: 0x04003AAC RID: 15020
			ScanMemory = 16U,
			// Token: 0x04003AAD RID: 15021
			WithUnloadedModules = 32U,
			// Token: 0x04003AAE RID: 15022
			WithIndirectlyReferencedMemory = 64U,
			// Token: 0x04003AAF RID: 15023
			FilterModulePaths = 128U,
			// Token: 0x04003AB0 RID: 15024
			WithProcessThreadData = 256U,
			// Token: 0x04003AB1 RID: 15025
			WithPrivateReadWriteMemory = 512U,
			// Token: 0x04003AB2 RID: 15026
			WithoutOptionalData = 1024U,
			// Token: 0x04003AB3 RID: 15027
			WithFullMemoryInfo = 2048U,
			// Token: 0x04003AB4 RID: 15028
			WithThreadInfo = 4096U,
			// Token: 0x04003AB5 RID: 15029
			WithCodeSegs = 8192U,
			// Token: 0x04003AB6 RID: 15030
			WithoutAuxiliaryState = 16384U,
			// Token: 0x04003AB7 RID: 15031
			WithFullAuxiliaryState = 32768U,
			// Token: 0x04003AB8 RID: 15032
			WithPrivateWriteCopyMemory = 65536U,
			// Token: 0x04003AB9 RID: 15033
			IgnoreInaccessibleMemory = 131072U,
			// Token: 0x04003ABA RID: 15034
			ValidTypeFlags = 262143U
		}

		// Token: 0x020004F4 RID: 1268
		private enum ExceptionInfo
		{
			// Token: 0x04003ABC RID: 15036
			None,
			// Token: 0x04003ABD RID: 15037
			Present
		}

		// Token: 0x020004F5 RID: 1269
		[StructLayout(0, Pack = 4, Size = 16)]
		private struct MiniDumpExceptionInformation
		{
			// Token: 0x04003ABE RID: 15038
			public uint ThreadId;

			// Token: 0x04003ABF RID: 15039
			public IntPtr ExceptionPointers;

			// Token: 0x04003AC0 RID: 15040
			public bool ClientPointers;
		}
	}
}
