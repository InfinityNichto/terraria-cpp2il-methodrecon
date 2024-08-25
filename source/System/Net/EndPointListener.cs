using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000241 RID: 577
	internal sealed class EndPointListener
	{
		// Token: 0x06000E7B RID: 3707 RVA: 0x0002DE38 File Offset: 0x0002C038
		public EndPointListener(HttpListener listener, IPAddress addr, int port, bool secure)
		{
			this.listener = listener;
			this.secure = true;
			X509Certificate x509Certificate;
			this.cert = x509Certificate;
			global::System.Net.Sockets.AddressFamily addressFamily = addr.AddressFamily;
			IPEndPoint ipendPoint = this.endpoint;
			this.sock.Listen(500);
			global::System.Net.Sockets.Socket socket = this.sock;
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x0002DE88 File Offset: 0x0002C088
		internal HttpListener Listener
		{
			get
			{
				return this.listener;
			}
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0002DE9C File Offset: 0x0002C09C
		private static void Accept(global::System.Net.Sockets.Socket socket, global::System.Net.Sockets.SocketAsyncEventArgs e, global::System.Net.Sockets.Socket accepted)
		{
			bool flag = socket.AcceptAsync(e);
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x0002DEC0 File Offset: 0x0002C0C0
		private static void ProcessAccept(global::System.Net.Sockets.SocketAsyncEventArgs args)
		{
			if (args.<SocketError>k__BackingField == global::System.Net.Sockets.SocketError.Success)
			{
				global::System.Net.Sockets.Socket <AcceptSocket>k__BackingField = args.<AcceptSocket>k__BackingField;
			}
			if (args.<UserToken>k__BackingField != null)
			{
			}
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x0002DF0C File Offset: 0x0002C10C
		private static void OnAccept(object sender, global::System.Net.Sockets.SocketAsyncEventArgs e)
		{
			EndPointListener.ProcessAccept(e);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x0002DF20 File Offset: 0x0002C120
		internal void RemoveConnection(HttpConnection conn)
		{
			Dictionary<HttpConnection, HttpConnection> dictionary = this.unregistered;
			Dictionary<HttpConnection, HttpConnection> dictionary2 = this.unregistered;
			long num = 0L;
			Monitor.Exit(dictionary);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x0002DF6C File Offset: 0x0002C16C
		public bool BindContext(HttpListenerContext context)
		{
			global::System.Uri url = context.request.url;
			HttpListener httpListener;
			if (httpListener != null)
			{
				context.Listener = httpListener;
				HttpConnection cnc = context.cnc;
			}
			return true;
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0002DF98 File Offset: 0x0002C198
		public void UnbindContext(HttpListenerContext context)
		{
			if (context != null && context.request != null)
			{
				context.Listener.UnregisterContext(context);
				return;
			}
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0002DFC0 File Offset: 0x0002C1C0
		private HttpListener SearchListener(global::System.Uri uri, [Out] ListenerPrefix prefix)
		{
			if (!true)
			{
			}
			string host = uri.Host;
			int port = uri.Port;
			string absolutePath = uri.AbsolutePath;
			long num = 0L;
			string text = WebUtility.UrlDecode(absolutePath);
			int stringLength = text._stringLength;
			char c = text[(int)num];
			string text2 = text + "/";
			HttpListener httpListener;
			if (host != null)
			{
				bool flag = host != "";
				Hashtable hashtable = this.prefixes;
				if (this != null)
				{
				}
				Hashtable hashtable2 = this.prefixes;
				Hashtable.bucket[] buckets = hashtable2._buckets;
				IPEndPoint ipendPoint = this.endpoint;
				global::System.Net.Sockets.Socket socket = this.sock;
				Hashtable.bucket[] buckets2 = hashtable2._buckets;
				bool flag2;
				if (flag2)
				{
				}
				long num2 = 0L;
				int num3 = 9;
				if (this != null)
				{
				}
				if (num2 != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (num3 != 0)
				{
					return httpListener;
				}
			}
			ArrayList arrayList = this.unhandled;
			HttpListener httpListener2;
			if (httpListener2 == null)
			{
			}
			if (httpListener == null)
			{
				ArrayList arrayList2 = this.all;
				HttpListener httpListener3;
				while (httpListener3 != null)
				{
				}
				HttpListener httpListener4;
				return httpListener4;
			}
			return httpListener;
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0002E0B4 File Offset: 0x0002C2B4
		private HttpListener MatchFromList(string host, string path, ArrayList list, [Out] ListenerPrefix prefix)
		{
			if (list != null)
			{
				if (list != null)
				{
				}
				long num = 0L;
				if (list != null)
				{
				}
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0002E0EC File Offset: 0x0002C2EC
		private void AddSpecial(ArrayList coll, ListenerPrefix prefix)
		{
			if (coll != null)
			{
				return;
			}
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0002E144 File Offset: 0x0002C344
		private bool RemoveSpecial(ArrayList coll, ListenerPrefix prefix)
		{
			if (coll != null)
			{
				if (coll != null)
				{
				}
				string path = prefix.path;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0002E16C File Offset: 0x0002C36C
		private void CheckIfRemove()
		{
			Hashtable hashtable = this.prefixes;
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x0002E1A0 File Offset: 0x0002C3A0
		public void Close()
		{
			global::System.Net.Sockets.Socket socket = this.sock;
			long num = 0L;
			socket.Close();
			Dictionary<HttpConnection, HttpConnection> dictionary = this.unregistered;
			Monitor.Enter(dictionary, num != 0L);
			Dictionary<HttpConnection, HttpConnection> dictionary2 = this.unregistered;
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0002E224 File Offset: 0x0002C424
		public void AddPrefix(ListenerPrefix prefix, HttpListener listener)
		{
			bool flag = prefix.host == "*";
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0002E278 File Offset: 0x0002C478
		public void RemovePrefix(ListenerPrefix prefix, HttpListener listener)
		{
			bool flag = prefix.host == "*";
			if ("*" != null && "*" != null)
			{
				return;
			}
		}

		// Token: 0x04000BD8 RID: 3032
		private HttpListener listener;

		// Token: 0x04000BD9 RID: 3033
		private IPEndPoint endpoint;

		// Token: 0x04000BDA RID: 3034
		private global::System.Net.Sockets.Socket sock;

		// Token: 0x04000BDB RID: 3035
		private Hashtable prefixes;

		// Token: 0x04000BDC RID: 3036
		private ArrayList unhandled;

		// Token: 0x04000BDD RID: 3037
		private ArrayList all;

		// Token: 0x04000BDE RID: 3038
		private X509Certificate cert;

		// Token: 0x04000BDF RID: 3039
		private bool secure;

		// Token: 0x04000BE0 RID: 3040
		private Dictionary<HttpConnection, HttpConnection> unregistered;
	}
}
