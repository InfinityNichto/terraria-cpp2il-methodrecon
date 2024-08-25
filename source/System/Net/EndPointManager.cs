using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Net
{
	// Token: 0x02000242 RID: 578
	internal sealed class EndPointManager
	{
		// Token: 0x06000E8B RID: 3723 RVA: 0x0002E2D4 File Offset: 0x0002C4D4
		private EndPointManager()
		{
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0002E2E8 File Offset: 0x0002C4E8
		public static void AddListener(HttpListener listener)
		{
			if (!true)
			{
			}
			listener.CheckDisposed();
			IEnumerator<string> enumerator = listener.prefixes.GetEnumerator();
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x0002E3A4 File Offset: 0x0002C5A4
		public static void AddPrefix(string prefix, HttpListener listener)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			EndPointManager.AddPrefixInternal(prefix, listener);
			long num = 0L;
			if (true)
			{
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0002E3E4 File Offset: 0x0002C5E4
		private static void AddPrefixInternal(string p, HttpListener listener)
		{
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0002E3F4 File Offset: 0x0002C5F4
		private static EndPointListener GetEPListener(string host, int port, HttpListener listener, bool secure)
		{
			IPHostEntry iphostEntry;
			do
			{
				bool flag = "*" == "*";
			}
			while (iphostEntry == null);
			if (iphostEntry.addressList == null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x0002E42C File Offset: 0x0002C62C
		public static void RemoveEndPoint(EndPointListener epl, IPEndPoint ep)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			IPAddress address = ep._address;
			int port = ep._port;
			IPAddress address2 = ep._address;
			epl.Close();
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x0002E490 File Offset: 0x0002C690
		public static void RemoveListener(HttpListener listener)
		{
			if (!true)
			{
			}
			listener.CheckDisposed();
			IEnumerator<string> enumerator = listener.prefixes.GetEnumerator();
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x0002E50C File Offset: 0x0002C70C
		public static void RemovePrefix(string prefix, HttpListener listener)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			EndPointManager.RemovePrefixInternal(prefix, listener);
			long num2 = 0L;
			if (num != 0)
			{
			}
			if (num2 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0002E550 File Offset: 0x0002C750
		private static void RemovePrefixInternal(string prefix, HttpListener listener)
		{
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0002E560 File Offset: 0x0002C760
		// Note: this type is marked as 'beforefieldinit'.
		static EndPointManager()
		{
		}

		// Token: 0x04000BE1 RID: 3041
		private static Hashtable ip_to_endpoints;
	}
}
