using System;

namespace System.Net
{
	// Token: 0x020001F1 RID: 497
	internal class BaseLoggingObject
	{
		// Token: 0x06000C30 RID: 3120 RVA: 0x000275EC File Offset: 0x000257EC
		internal BaseLoggingObject()
		{
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00027600 File Offset: 0x00025800
		internal virtual void EnterFunc(string funcname)
		{
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00027610 File Offset: 0x00025810
		internal virtual void LeaveFunc(string funcname)
		{
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00027620 File Offset: 0x00025820
		internal virtual void DumpArrayToConsole()
		{
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00027630 File Offset: 0x00025830
		internal virtual void PrintLine(string msg)
		{
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00027640 File Offset: 0x00025840
		internal virtual void DumpArray(bool shouldClose)
		{
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00027650 File Offset: 0x00025850
		internal virtual void DumpArrayToFile(bool shouldClose)
		{
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00027660 File Offset: 0x00025860
		internal virtual void Flush()
		{
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00027670 File Offset: 0x00025870
		internal virtual void Flush(bool close)
		{
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00027680 File Offset: 0x00025880
		internal virtual void LoggingMonitorTick()
		{
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00027690 File Offset: 0x00025890
		internal virtual void Dump(byte[] buffer)
		{
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x000276A0 File Offset: 0x000258A0
		internal virtual void Dump(byte[] buffer, int length)
		{
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x000276B0 File Offset: 0x000258B0
		internal virtual void Dump(byte[] buffer, int offset, int length)
		{
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x000276C0 File Offset: 0x000258C0
		internal virtual void Dump(IntPtr pBuffer, int offset, int length)
		{
		}
	}
}
