using System;
using System.Runtime.CompilerServices;

namespace InControl
{
	// Token: 0x0200002B RID: 43
	public class Logger
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060001C7 RID: 455 RVA: 0x00005908 File Offset: 0x00003B08
		// (remove) Token: 0x060001C8 RID: 456 RVA: 0x00005924 File Offset: 0x00003B24
		public static event Action<LogMessage> OnLogMessage
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate;
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate;
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00005940 File Offset: 0x00003B40
		public static void LogInfo(string text)
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00005950 File Offset: 0x00003B50
		public static void LogWarning(string text)
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00005960 File Offset: 0x00003B60
		public static void LogError(string text)
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00005970 File Offset: 0x00003B70
		public Logger()
		{
		}

		// Token: 0x040001FF RID: 511
		[CompilerGenerated]
		private static Action<LogMessage> OnLogMessage;
	}
}
