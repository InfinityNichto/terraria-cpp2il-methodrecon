using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	// Token: 0x02000040 RID: 64
	public class Logger : ILogger, ILogHandler
	{
		// Token: 0x06000083 RID: 131 RVA: 0x000029D4 File Offset: 0x00000BD4
		public Logger(ILogHandler logHandler)
		{
			this.logHandler = logHandler;
			this.<logEnabled>k__BackingField = true;
			this.filterLogType = LogType.Log;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000029FC File Offset: 0x00000BFC
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002A10 File Offset: 0x00000C10
		public ILogHandler logHandler
		{
			[CompilerGenerated]
			get
			{
				return this.<logHandler>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<logHandler>k__BackingField = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002A24 File Offset: 0x00000C24
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002A38 File Offset: 0x00000C38
		public bool logEnabled
		{
			[CompilerGenerated]
			get
			{
				return this.<logEnabled>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00002A48 File Offset: 0x00000C48
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002A5C File Offset: 0x00000C5C
		public LogType filterLogType
		{
			[CompilerGenerated]
			get
			{
				return this.<filterLogType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<filterLogType>k__BackingField = value;
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002A70 File Offset: 0x00000C70
		public bool IsLogTypeAllowed(LogType logType)
		{
			if (this.<logEnabled>k__BackingField)
			{
				return true;
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002A88 File Offset: 0x00000C88
		private static string GetString(object message)
		{
			if ("Null" != null)
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				return "Null";
			}
			return "Null";
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002AB8 File Offset: 0x00000CB8
		public void Log(LogType logType, object message)
		{
			if (!this.<logEnabled>k__BackingField)
			{
				return;
			}
			LogType logType2 = this.<filterLogType>k__BackingField;
			ILogHandler logHandler = this.<logHandler>k__BackingField;
			string @string = Logger.GetString(message);
			if (@string == null || @string != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002AF4 File Offset: 0x00000CF4
		public void Log(LogType logType, object message, Object context)
		{
			if (!this.<logEnabled>k__BackingField)
			{
				return;
			}
			LogType logType2 = this.<filterLogType>k__BackingField;
			ILogHandler logHandler = this.<logHandler>k__BackingField;
			string @string = Logger.GetString(message);
			if (@string == null || @string != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002B30 File Offset: 0x00000D30
		public void LogError(string tag, object message)
		{
			if (!this.<logEnabled>k__BackingField)
			{
				return;
			}
			LogType logType = this.<filterLogType>k__BackingField;
			ILogHandler logHandler = this.<logHandler>k__BackingField;
			if (tag != null)
			{
			}
			string @string = Logger.GetString(message);
			if (@string == null || @string != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002B70 File Offset: 0x00000D70
		public void LogException(Exception exception, Object context)
		{
			if (this.<logEnabled>k__BackingField)
			{
				ILogHandler logHandler = this.<logHandler>k__BackingField;
				return;
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002B90 File Offset: 0x00000D90
		public void LogFormat(LogType logType, Object context, string format, params object[] args)
		{
			if (this.<logEnabled>k__BackingField)
			{
				LogType logType2 = this.<filterLogType>k__BackingField;
				ILogHandler logHandler = this.<logHandler>k__BackingField;
				return;
			}
		}

		// Token: 0x040000BF RID: 191
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ILogHandler <logHandler>k__BackingField;

		// Token: 0x040000C0 RID: 192
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <logEnabled>k__BackingField;

		// Token: 0x040000C1 RID: 193
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private LogType <filterLogType>k__BackingField;
	}
}
