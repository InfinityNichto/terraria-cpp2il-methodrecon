using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	// Token: 0x020000DF RID: 223
	public class DefaultTraceListener : TraceListener
	{
		// Token: 0x06000522 RID: 1314 RVA: 0x00014C1C File Offset: 0x00012E1C
		static DefaultTraceListener()
		{
			if (!true)
			{
			}
			string environmentVariable = Environment.GetEnvironmentVariable("MONO_TRACE_LISTENER");
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00014C38 File Offset: 0x00012E38
		private static string GetPrefix(string var, string target)
		{
			int stringLength = var._stringLength;
			string text;
			return text;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00014C54 File Offset: 0x00012E54
		public DefaultTraceListener()
		{
			this.indentSize = 4;
			this.needIndent = true;
			base..ctor();
			this.listenerName = "Default";
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00014C80 File Offset: 0x00012E80
		[MonoTODO]
		public string LogFileName
		{
			get
			{
				return this.logFileName;
			}
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00014C94 File Offset: 0x00012E94
		private unsafe static void WriteWindowsDebugString(char* message)
		{
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00014CA4 File Offset: 0x00012EA4
		private void WriteDebugString(string message)
		{
			if (message != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00014CC4 File Offset: 0x00012EC4
		private void WriteMonoTrace(string message)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00014CE8 File Offset: 0x00012EE8
		private void WritePrefix()
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00014D00 File Offset: 0x00012F00
		private void WriteImpl(string message)
		{
			if (this.needIndent)
			{
				this.WritePrefix();
			}
			bool flag = Debugger.IsLogging();
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00014D3C File Offset: 0x00012F3C
		private void WriteLogFile(string message, string logFile)
		{
			if (logFile != null && logFile._stringLength != 0)
			{
				return;
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00014D90 File Offset: 0x00012F90
		public override void Write(string message)
		{
			this.WriteImpl(message);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00014DA4 File Offset: 0x00012FA4
		public override void WriteLine(string message)
		{
			string newLine = Environment.NewLine;
			string text = message + newLine;
			this.WriteImpl(text);
			this.needIndent = true;
		}

		// Token: 0x04000418 RID: 1048
		private static readonly bool OnWin32;

		// Token: 0x04000419 RID: 1049
		private static readonly string MonoTracePrefix;

		// Token: 0x0400041A RID: 1050
		private static readonly string MonoTraceFile;

		// Token: 0x0400041B RID: 1051
		private string logFileName;
	}
}
