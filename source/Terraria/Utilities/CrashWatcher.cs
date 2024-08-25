using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading;
using Cpp2IlInjected;

namespace Terraria.Utilities
{
	// Token: 0x020004F6 RID: 1270
	public static class CrashWatcher
	{
		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060030AF RID: 12463 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060030B0 RID: 12464 RVA: 0x001F6C70 File Offset: 0x001F4E70
		public static bool LogAllExceptions
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x060030B1 RID: 12465 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060030B2 RID: 12466 RVA: 0x001F6C80 File Offset: 0x001F4E80
		public static bool DumpOnException
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060030B3 RID: 12467 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060030B4 RID: 12468 RVA: 0x001F6C90 File Offset: 0x001F4E90
		public static bool DumpOnCrash
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x060030B5 RID: 12469 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060030B6 RID: 12470 RVA: 0x001F6CA0 File Offset: 0x001F4EA0
		public static CrashDump.Options CrashDumpOptions
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060030B7 RID: 12471 RVA: 0x001F6CB0 File Offset: 0x001F4EB0
		private static string DumpPath
		{
			get
			{
				if (!true)
				{
				}
				return Path.Combine(Main.SavePath, "Dumps");
			}
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x001F6CD4 File Offset: 0x001F4ED4
		public static void Inititialize()
		{
			if (!true)
			{
			}
			Console.WriteLine("Error Logging Enabled.");
			AppDomain currentDomain = AppDomain.CurrentDomain;
			AppDomain currentDomain2 = AppDomain.CurrentDomain;
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x001F6D00 File Offset: 0x001F4F00
		private static string PrintException(Exception ex)
		{
			string text2;
			string text = "\nHResult: " + "\nHResult: " + text2;
			string text3;
			return text + "\n+--> " + text3;
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x001F6D50 File Offset: 0x001F4F50
		public static void EnableCrashDumps(CrashDump.Options options)
		{
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x001F6D60 File Offset: 0x001F4F60
		public static void DisableCrashDumps()
		{
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x001F6D70 File Offset: 0x001F4F70
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_DEBUG")]
		private static void HookDebugExceptionDialog()
		{
		}

		// Token: 0x04003AC1 RID: 15041
		[CompilerGenerated]
		private static bool <LogAllExceptions>k__BackingField;

		// Token: 0x04003AC2 RID: 15042
		[CompilerGenerated]
		private static bool <DumpOnException>k__BackingField;

		// Token: 0x04003AC3 RID: 15043
		[CompilerGenerated]
		private static bool <DumpOnCrash>k__BackingField;

		// Token: 0x04003AC4 RID: 15044
		[CompilerGenerated]
		private static CrashDump.Options <CrashDumpOptions>k__BackingField;

		// Token: 0x020004F7 RID: 1271
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060030BD RID: 12477 RVA: 0x001F6D80 File Offset: 0x001F4F80
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060030BE RID: 12478 RVA: 0x001F6D90 File Offset: 0x001F4F90
			public <>c()
			{
			}

			// Token: 0x060030BF RID: 12479 RVA: 0x001F6DA4 File Offset: 0x001F4FA4
			internal void <Inititialize>b__18_0(object sender, FirstChanceExceptionEventArgs exceptionArgs)
			{
				string text = CrashWatcher.PrintException(exceptionArgs.<Exception>k__BackingField);
				DateTime now = DateTime.Now;
				int managedThreadId = Thread.CurrentThread.ManagedThreadId;
				string name = Thread.CurrentThread.Name;
				if (name == null || name != null)
				{
					CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
					if ((currentCulture == null || currentCulture != null) && (text == null || text != null))
					{
						string text2;
						Console.Write("================\r\n" + text2 + "================\r\n\r\n");
						string dumpPath = CrashWatcher.DumpPath;
						return;
					}
				}
				throw new ArrayTypeMismatchException();
			}

			// Token: 0x060030C0 RID: 12480 RVA: 0x001F6E30 File Offset: 0x001F5030
			internal void <Inititialize>b__18_1(object sender, UnhandledExceptionEventArgs exceptionArgs)
			{
				if (exceptionArgs._exception != null)
				{
				}
				DateTime now = DateTime.Now;
				int managedThreadId = Thread.CurrentThread.ManagedThreadId;
				string name = Thread.CurrentThread.Name;
				if (name == null || name != null)
				{
					CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
					string text;
					if ((currentCulture == null || currentCulture != null) && (text == null || text != null))
					{
						string text2;
						Console.Write("================\r\n" + text2 + "================\r\n");
						string dumpPath = CrashWatcher.DumpPath;
						return;
					}
				}
				throw new ArrayTypeMismatchException();
			}

			// Token: 0x04003AC5 RID: 15045
			public static readonly CrashWatcher.<>c <>9;

			// Token: 0x04003AC6 RID: 15046
			public static EventHandler<FirstChanceExceptionEventArgs> <>9__18_0;

			// Token: 0x04003AC7 RID: 15047
			public static UnhandledExceptionEventHandler <>9__18_1;
		}
	}
}
