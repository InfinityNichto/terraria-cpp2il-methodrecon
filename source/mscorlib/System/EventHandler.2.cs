using System;

namespace System
{
	// Token: 0x020000A5 RID: 165
	public sealed class EventHandler<TEventArgs> : MulticastDelegate
	{
		// Token: 0x06000676 RID: 1654 RVA: 0x0000F9A4 File Offset: 0x0000DBA4
		public EventHandler(object @object, IntPtr method)
		{
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0000F9C4 File Offset: 0x0000DBC4
		public void Invoke(object sender, TEventArgs e)
		{
		}
	}
}
