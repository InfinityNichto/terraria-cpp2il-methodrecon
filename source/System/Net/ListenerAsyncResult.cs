using System;
using System.IO;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000261 RID: 609
	internal class ListenerAsyncResult : IAsyncResult
	{
		// Token: 0x06001062 RID: 4194 RVA: 0x00033BC8 File Offset: 0x00031DC8
		public ListenerAsyncResult(AsyncCallback cb, object state)
		{
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00033BE4 File Offset: 0x00031DE4
		internal void Complete(Exception exc)
		{
			ListenerAsyncResult listenerAsyncResult = this.forward;
			if (listenerAsyncResult != null)
			{
				listenerAsyncResult.Complete(exc);
				return;
			}
			bool inGet = this.InGet;
			this.exception = exc;
			int num;
			if (inGet && exc != null)
			{
				num = 500;
			}
			object obj = this.locker;
			Monitor.Enter(obj, num != 0);
			ManualResetEvent manualResetEvent = this.handle;
			int num2 = 1;
			this.completed = num2 != 0;
			if (manualResetEvent != null)
			{
				bool flag = manualResetEvent.Set();
			}
			AsyncCallback asyncCallback = this.cb;
			if (asyncCallback != null)
			{
				if (asyncCallback == null)
				{
				}
				return;
			}
			long num3 = 0L;
			if (asyncCallback != null)
			{
				Monitor.Exit(obj);
			}
			if (num3 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00033C98 File Offset: 0x00031E98
		private static void InvokeCallback(object o)
		{
			if (o != null)
			{
			}
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00033CB4 File Offset: 0x00031EB4
		internal void Complete(HttpListenerContext context)
		{
			long num = 0L;
			this.Complete(context, num != 0L);
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00033CCC File Offset: 0x00031ECC
		internal void Complete(HttpListenerContext context, bool synch)
		{
			int num = 1;
			ListenerAsyncResult listenerAsyncResult = this.forward;
			if (listenerAsyncResult != null)
			{
				listenerAsyncResult.Complete(context, synch);
				return;
			}
			object obj = this.locker;
			this.synch = num != 0;
			this.context = context;
			AuthenticationSchemes authenticationSchemes = context.Listener.SelectAuthenticationScheme(context);
			AuthenticationSchemes auth_schemes = context.Listener.auth_schemes;
			if (context.request.headers["Authorization"] == null)
			{
				HttpListenerResponse response = context.response;
				int num2 = 401;
				response.StatusCode = num2;
				WebHeaderCollection headers = context.response.headers;
				string realm = context.Listener.realm;
				string text2;
				string text = text2 + " realm=\"" + realm + "\"";
				headers["WWW-Authenticate"] = text;
				Stream outputStream = context.response.OutputStream;
				HttpListener listener = context.Listener;
				Monitor.Enter(headers, true);
				return;
			}
			ManualResetEvent manualResetEvent = this.handle;
			int num3 = 256;
			this.synch = num3 != 0;
			if (manualResetEvent != null)
			{
				bool flag = manualResetEvent.Set();
			}
			AsyncCallback asyncCallback = this.cb;
			if (asyncCallback != null)
			{
				if (asyncCallback == null)
				{
				}
				return;
			}
			long num4 = 0L;
			Monitor.Exit(obj);
			if (num4 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00033E60 File Offset: 0x00032060
		internal HttpListenerContext GetContext()
		{
			while (this.forward != null || this.exception != null)
			{
			}
			return this.context;
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x00033E84 File Offset: 0x00032084
		public object AsyncState
		{
			get
			{
				while (this.forward != null)
				{
				}
				return this.state;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x00033EA0 File Offset: 0x000320A0
		public WaitHandle AsyncWaitHandle
		{
			get
			{
				ListenerAsyncResult listenerAsyncResult = this.forward;
				if (listenerAsyncResult != null)
				{
					return listenerAsyncResult.AsyncWaitHandle;
				}
				object obj = this.locker;
				if (this.handle != null)
				{
				}
				bool flag = this.completed;
				long num = 0L;
				Monitor.Exit(obj);
				if (num == 0L)
				{
					ManualResetEvent manualResetEvent = this.handle;
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x00033F08 File Offset: 0x00032108
		public bool CompletedSynchronously
		{
			get
			{
				while (this.forward != null)
				{
				}
				return this.synch;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x00033F24 File Offset: 0x00032124
		public bool IsCompleted
		{
			get
			{
				ListenerAsyncResult listenerAsyncResult = this.forward;
				bool isCompleted;
				if (listenerAsyncResult != null)
				{
					isCompleted = listenerAsyncResult.IsCompleted;
					return isCompleted;
				}
				long num = 0L;
				Monitor.Exit(isCompleted);
				if (num == 0L)
				{
					return isCompleted;
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00033F74 File Offset: 0x00032174
		// Note: this type is marked as 'beforefieldinit'.
		static ListenerAsyncResult()
		{
		}

		// Token: 0x04000CE2 RID: 3298
		private ManualResetEvent handle;

		// Token: 0x04000CE3 RID: 3299
		private bool synch;

		// Token: 0x04000CE4 RID: 3300
		private bool completed;

		// Token: 0x04000CE5 RID: 3301
		private AsyncCallback cb = cb;

		// Token: 0x04000CE6 RID: 3302
		private object state = state;

		// Token: 0x04000CE7 RID: 3303
		private Exception exception;

		// Token: 0x04000CE8 RID: 3304
		private HttpListenerContext context;

		// Token: 0x04000CE9 RID: 3305
		private object locker;

		// Token: 0x04000CEA RID: 3306
		private ListenerAsyncResult forward;

		// Token: 0x04000CEB RID: 3307
		internal bool EndCalled;

		// Token: 0x04000CEC RID: 3308
		internal bool InGet;

		// Token: 0x04000CED RID: 3309
		private static WaitCallback InvokeCB;
	}
}
