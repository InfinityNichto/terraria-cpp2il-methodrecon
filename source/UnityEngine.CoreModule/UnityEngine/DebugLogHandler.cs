using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000037 RID: 55
	[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
	internal sealed class DebugLogHandler : ILogHandler
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00002750 File Offset: 0x00000950
		[ThreadAndSerializationSafe]
		internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002764 File Offset: 0x00000964
		[ThreadAndSerializationSafe]
		internal static void Internal_LogException(Exception ex, Object obj)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002778 File Offset: 0x00000978
		public void LogFormat(LogType logType, Object context, string format, params object[] args)
		{
			string text = string.Format(format, args);
			throw new MissingMethodException();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002794 File Offset: 0x00000994
		public void LogException(Exception exception, Object context)
		{
			while (exception == null)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000027AC File Offset: 0x000009AC
		public DebugLogHandler()
		{
		}
	}
}
