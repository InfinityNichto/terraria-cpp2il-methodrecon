using System;

namespace UnityEngine
{
	// Token: 0x0200003E RID: 62
	public interface ILogger : ILogHandler
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600007C RID: 124
		ILogHandler logHandler { get; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600007D RID: 125
		bool logEnabled { get; }

		// Token: 0x0600007E RID: 126
		void Log(LogType logType, object message);

		// Token: 0x0600007F RID: 127
		void Log(LogType logType, object message, Object context);

		// Token: 0x06000080 RID: 128
		void LogError(string tag, object message);
	}
}
