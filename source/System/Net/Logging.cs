using System;
using System.Diagnostics;

namespace System.Net
{
	// Token: 0x02000229 RID: 553
	internal static class Logging
	{
		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x0002C6E0 File Offset: 0x0002A8E0
		internal static bool On
		{
			get
			{
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x0002C6F0 File Offset: 0x0002A8F0
		internal static TraceSource Web
		{
			get
			{
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x0002C700 File Offset: 0x0002A900
		internal static TraceSource HttpListener
		{
			get
			{
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x0002C710 File Offset: 0x0002A910
		internal static TraceSource Sockets
		{
			get
			{
			}
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0002C720 File Offset: 0x0002A920
		[Conditional("TRACE")]
		internal static void Enter(TraceSource traceSource, object obj, string method, object paramObject)
		{
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0002C730 File Offset: 0x0002A930
		[Conditional("TRACE")]
		internal static void Enter(TraceSource traceSource, string msg)
		{
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0002C740 File Offset: 0x0002A940
		[Conditional("TRACE")]
		internal static void Enter(TraceSource traceSource, string msg, string parameters)
		{
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0002C750 File Offset: 0x0002A950
		[Conditional("TRACE")]
		internal static void Exception(TraceSource traceSource, object obj, string method, Exception e)
		{
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x0002C760 File Offset: 0x0002A960
		[Conditional("TRACE")]
		internal static void Exit(TraceSource traceSource, object obj, string method, object retObject)
		{
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x0002C770 File Offset: 0x0002A970
		[Conditional("TRACE")]
		internal static void Exit(TraceSource traceSource, string msg)
		{
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0002C780 File Offset: 0x0002A980
		[Conditional("TRACE")]
		internal static void Exit(TraceSource traceSource, string msg, string parameters)
		{
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0002C790 File Offset: 0x0002A990
		[Conditional("TRACE")]
		internal static void PrintInfo(TraceSource traceSource, object obj, string method, string msg)
		{
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x0002C7A0 File Offset: 0x0002A9A0
		[Conditional("TRACE")]
		internal static void PrintInfo(TraceSource traceSource, object obj, string msg)
		{
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0002C7B0 File Offset: 0x0002A9B0
		[Conditional("TRACE")]
		internal static void PrintInfo(TraceSource traceSource, string msg)
		{
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0002C7C0 File Offset: 0x0002A9C0
		[Conditional("TRACE")]
		internal static void PrintWarning(TraceSource traceSource, object obj, string method, string msg)
		{
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0002C7D0 File Offset: 0x0002A9D0
		[Conditional("TRACE")]
		internal static void PrintWarning(TraceSource traceSource, string msg)
		{
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0002C7E0 File Offset: 0x0002A9E0
		[Conditional("TRACE")]
		internal static void PrintError(TraceSource traceSource, string msg)
		{
		}
	}
}
