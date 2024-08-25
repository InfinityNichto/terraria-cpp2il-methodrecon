using System;

namespace UnityEngine
{
	// Token: 0x0200003F RID: 63
	public interface ILogHandler
	{
		// Token: 0x06000081 RID: 129
		void LogFormat(LogType logType, Object context, string format, params object[] args);

		// Token: 0x06000082 RID: 130
		void LogException(Exception exception, Object context);
	}
}
