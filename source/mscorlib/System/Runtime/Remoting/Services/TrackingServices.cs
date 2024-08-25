using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Services
{
	// Token: 0x02000358 RID: 856
	[ComVisible(true)]
	public class TrackingServices
	{
		// Token: 0x06001C8B RID: 7307 RVA: 0x0003E170 File Offset: 0x0003C370
		internal static void NotifyMarshaledObject(object obj, ObjRef or)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x0003E1A8 File Offset: 0x0003C3A8
		internal static void NotifyUnmarshaledObject(object obj, ObjRef or)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x0003E1E0 File Offset: 0x0003C3E0
		internal static void NotifyDisconnectedObject(object obj)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x0003E218 File Offset: 0x0003C418
		// Note: this type is marked as 'beforefieldinit'.
		static TrackingServices()
		{
		}

		// Token: 0x04000E7A RID: 3706
		private static ArrayList _handlers;
	}
}
