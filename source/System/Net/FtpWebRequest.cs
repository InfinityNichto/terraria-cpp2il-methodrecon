using System;
using System.Diagnostics;
using System.IO;
using System.Net.Cache;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000151 RID: 337
	public sealed class FtpWebRequest : WebRequest
	{
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x0001CF34 File Offset: 0x0001B134
		internal FtpMethodInfo MethodInfo
		{
			get
			{
				return this._methodInfo;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x0001CF48 File Offset: 0x0001B148
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x0001CF60 File Offset: 0x0001B160
		public new static global::System.Net.Cache.RequestCachePolicy DefaultCachePolicy
		{
			get
			{
				if (!true)
				{
				}
				return WebRequest.DefaultCachePolicy;
			}
			set
			{
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x0001CF70 File Offset: 0x0001B170
		public override string Method
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				bool flag = string.IsNullOrEmpty(value);
				if (!this._getRequestStreamStarted && !this._getResponseStarted)
				{
					FtpMethodInfo methodInfo = FtpMethodInfo.GetMethodInfo(value);
					this._methodInfo = methodInfo;
					return;
				}
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x0001CFA8 File Offset: 0x0001B1A8
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x0001CFBC File Offset: 0x0001B1BC
		public string RenameTo
		{
			get
			{
				return this._renameTo;
			}
			set
			{
				if (!this._getRequestStreamStarted && !this._getResponseStarted)
				{
					bool flag = string.IsNullOrEmpty(value);
					this._renameTo = value;
					return;
				}
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x0001CFE8 File Offset: 0x0001B1E8
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x0001CFFC File Offset: 0x0001B1FC
		public override ICredentials Credentials
		{
			get
			{
				return this._authInfo;
			}
			set
			{
				if (this._getRequestStreamStarted || this._getResponseStarted)
				{
					return;
				}
				if (value != null)
				{
					if (!true)
					{
					}
					this._authInfo = value;
					return;
				}
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x0001D028 File Offset: 0x0001B228
		public override global::System.Uri RequestUri
		{
			get
			{
				return this._uri;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x0001D03C File Offset: 0x0001B23C
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x0001D050 File Offset: 0x0001B250
		public override int Timeout
		{
			get
			{
				return this._timeout;
			}
			set
			{
				if (!this._getRequestStreamStarted && !this._getResponseStarted)
				{
					int timeout = this._timeout;
					this._timeout = value;
					return;
				}
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x0001D07C File Offset: 0x0001B27C
		internal int RemainingTimeout
		{
			get
			{
				return this._remainingTimeout;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x0001D090 File Offset: 0x0001B290
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x0001D0A4 File Offset: 0x0001B2A4
		public int ReadWriteTimeout
		{
			get
			{
				return this._readWriteTimeout;
			}
			set
			{
				if (!this._getResponseStarted)
				{
					this._readWriteTimeout = value;
					return;
				}
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x0001D0C4 File Offset: 0x0001B2C4
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x0001D0D8 File Offset: 0x0001B2D8
		public long ContentOffset
		{
			get
			{
				return this._contentOffset;
			}
			set
			{
				if (!this._getRequestStreamStarted && !this._getResponseStarted)
				{
					this._contentOffset = value;
					return;
				}
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x0001D100 File Offset: 0x0001B300
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x0001D114 File Offset: 0x0001B314
		public override long ContentLength
		{
			get
			{
				return this._contentLength;
			}
			set
			{
				this._contentLength = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x0001D128 File Offset: 0x0001B328
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x0001D138 File Offset: 0x0001B338
		public override IWebProxy Proxy
		{
			get
			{
			}
			set
			{
				while (this._getRequestStreamStarted || this._getResponseStarted)
				{
				}
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x0001D158 File Offset: 0x0001B358
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x0001D16C File Offset: 0x0001B36C
		public override string ConnectionGroupName
		{
			get
			{
				return this._connectionGroupName;
			}
			set
			{
				while (this._getRequestStreamStarted || this._getResponseStarted)
				{
				}
				this._connectionGroupName = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x0001D190 File Offset: 0x0001B390
		public ServicePoint ServicePoint
		{
			get
			{
				ServicePoint servicePoint;
				if (this._servicePoint == null)
				{
					global::System.Uri uri = this._uri;
					this._servicePoint = servicePoint;
				}
				return servicePoint;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x0001D1B4 File Offset: 0x0001B3B4
		internal bool Aborted
		{
			get
			{
				return this._aborted;
			}
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0001D1C8 File Offset: 0x0001B3C8
		internal FtpWebRequest(global::System.Uri uri)
		{
			int num = 34464;
			int num2 = 257;
			this._timeout = num;
			this._passive = num2 != 0;
			if (num == 0)
			{
			}
			int num3 = 37856;
			this._readWriteTimeout = num3;
			this._timerQueue = num;
			if (num == 0)
			{
			}
			base..ctor();
			if (num == 0)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (num == 0)
			{
			}
			NetEventSource.Info(this, uri, ".ctor");
			if (num3 == 0)
			{
			}
			this._uri = uri;
			FtpMethodInfo methodInfo = FtpMethodInfo.GetMethodInfo("RETR");
			global::System.Uri uri2 = this._uri;
			this._methodInfo = methodInfo;
			int stringLength;
			if (uri2.UserInfo != null && this._uri.UserInfo._stringLength != 0)
			{
				string userInfo = this._uri.UserInfo;
				int num4 = 58;
				int num5 = userInfo.IndexOf((char)num4);
				long num6 = 0L;
				string text = userInfo.Substring((int)num6, num5);
				if (num3 == 0)
				{
				}
				long num7 = 0L;
				string text2 = global::System.Uri.UnescapeDataString(text);
				stringLength = userInfo._stringLength;
				string text3 = global::System.Uri.UnescapeDataString(userInfo.Substring((int)num7, num5));
			}
			if (stringLength == 0)
			{
			}
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0001D2C8 File Offset: 0x0001B4C8
		public override WebResponse GetResponse()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (num == 0)
			{
			}
			bool isEnabled2 = NetEventSource.IsEnabled;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool isEnabled3 = NetEventSource.IsEnabled;
			string method = this._methodInfo.Method;
			if (method != null && method == null)
			{
				throw new ArrayTypeMismatchException();
			}
			if (!true)
			{
			}
			DateTime utcNow = DateTime.UtcNow;
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan timeSpan;
			double totalMilliseconds = timeSpan.TotalMilliseconds;
			long num2 = 32752L;
			WebException timeoutException = ExceptionHelper.TimeoutException;
			int num3 = 1;
			FtpWebRequest.RequestStage requestStage;
			Monitor.Enter(requestStage, num3 != 0);
			long num4 = 0L;
			int num5 = 15;
			if (num4 == 0L)
			{
				if (num5 == 0)
				{
					object obj;
					if (obj != null)
					{
					}
					long num6 = 0L;
					int num7 = 19;
					bool isEnabled4 = NetEventSource.IsEnabled;
					if (num2 == 0L)
					{
					}
					if (num6 == 0L)
					{
						if (num7 == 0)
						{
						}
					}
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0001D3F0 File Offset: 0x0001B5F0
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (num == 0)
			{
			}
			string method = this._methodInfo.Method;
			if (method == null || method != null)
			{
				FormattableString formattableString;
				NetEventSource.Info(this, formattableString, "BeginGetResponse");
				if (this._ftpWebResponse != null)
				{
					FtpWebResponse ftpWebResponse = this._ftpWebResponse;
				}
				if (!this._getResponseStarted)
				{
					Exception exception = this._exception;
					int num2 = 1;
					this._getResponseStarted = num2 != 0;
					if (exception != null)
					{
						ExceptionDispatchInfo.Throw(exception);
					}
					long num3 = 0L;
					object syncObject = this._syncObject;
					Monitor.Enter(syncObject, num3 != 0L);
					FtpWebRequest.RequestStage requestStage = this._requestStage;
					long num4 = 0L;
					int num5 = 10;
					if (requestStage != FtpWebRequest.RequestStage.CheckForError)
					{
						Monitor.Exit(syncObject);
					}
					if (num4 == 0L)
					{
						int num10;
						if (num5 == 0)
						{
							LazyAsyncResult readAsyncResult = this._readAsyncResult;
							if (readAsyncResult != null)
							{
							}
							bool internalPeekCompleted = readAsyncResult.InternalPeekCompleted;
							readAsyncResult.InvokeCallback();
							long num6 = 0L;
							object obj;
							Monitor.Enter(obj, num6 != 0L);
							int num7 = 1;
							this.SubmitRequest(num7 != 0);
							long num8 = 0L;
							int num9 = 13;
							Monitor.Exit(syncObject);
							if (num8 != 0L)
							{
								throw new OutOfMemoryException();
							}
							if (num9 == 0)
							{
								num10 = 14;
							}
						}
						long num11 = 0L;
						bool isEnabled2 = NetEventSource.IsEnabled;
						if (num11 != 0L || num10 == 0)
						{
						}
						throw new OutOfMemoryException();
					}
					throw new OutOfMemoryException();
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x0001D584 File Offset: 0x0001B784
		public override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (num == 0)
			{
			}
			if (asyncResult != null)
			{
				int num2 = 1;
				Exception exception = this._exception;
				if (exception != null)
				{
					ExceptionDispatchInfo.Throw(exception);
				}
				long num3 = 0L;
				int num4 = 12;
				if (num2 == 0)
				{
				}
				bool isEnabled2 = NetEventSource.IsEnabled;
				if (num2 == 0)
				{
				}
				if (num3 != 0L)
				{
					goto IL_0063;
				}
				if (num4 == 0)
				{
					FtpWebResponse ftpWebResponse = this._ftpWebResponse;
				}
			}
			string text = SR.Format("{0} can only be called once for each asynchronous operation.", "EndGetResponse");
			IL_0063:
			throw new OutOfMemoryException();
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x0001D61C File Offset: 0x0001B81C
		public override Stream GetRequestStream()
		{
			int num6;
			do
			{
				int num = 1;
				if (num == 0)
				{
				}
				bool isEnabled = NetEventSource.IsEnabled;
				if (num == 0)
				{
				}
				string method = this._methodInfo.Method;
				if (method != null && method == null)
				{
					goto IL_0138;
				}
				FormattableString formattableString;
				NetEventSource.Info(this, formattableString, "GetRequestStream");
				if (this._getRequestStreamStarted)
				{
					goto IL_0128;
				}
				FtpMethodInfo methodInfo = this._methodInfo;
				int num2 = 1;
				this._getRequestStreamStarted = num2 != 0;
				FtpMethodFlags flags = methodInfo.Flags;
				Exception exception = this._exception;
				if (exception != null)
				{
					ExceptionDispatchInfo.Throw(exception);
				}
				if (flags == FtpMethodFlags.None)
				{
				}
				DateTime utcNow = DateTime.UtcNow;
				this._startTime = utcNow;
				this._remainingTimeout = this;
				DateTime utcNow2 = DateTime.UtcNow;
				DateTime startTime = this._startTime;
				double totalMilliseconds = (utcNow2 - startTime).TotalMilliseconds;
				int num3 = 32768;
				this._remainingTimeout = num3;
				long num4 = 0L;
				this.SubmitRequest(num4 != 0L);
				Exception exception2 = this._exception;
				if (exception2 != null)
				{
					ExceptionDispatchInfo.Throw(exception2);
				}
				Stream stream = this._stream;
				Stream stream2 = this._stream;
				int readWriteTimeout = this._readWriteTimeout;
				Stream stream3 = this._stream;
				int readWriteTimeout2 = this._readWriteTimeout;
				long num5 = 0L;
				num6 = 13;
				bool isEnabled2 = NetEventSource.IsEnabled;
				if (num5 != 0L)
				{
					goto IL_0128;
				}
			}
			while (num6 != 0);
			return this._stream;
			IL_0128:
			throw new OutOfMemoryException();
			IL_0138:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0001D790 File Offset: 0x0001B990
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (num == 0)
			{
			}
			string method = this._methodInfo.Method;
			if (method == null || method != null)
			{
				FormattableString formattableString;
				NetEventSource.Info(this, formattableString, "BeginGetRequestStream");
				if (!this._getRequestStreamStarted)
				{
					FtpMethodInfo methodInfo = this._methodInfo;
					int num2 = 1;
					this._getRequestStreamStarted = num2 != 0;
					FtpMethodFlags flags = methodInfo.Flags;
					Exception exception = this._exception;
					if (exception != null)
					{
						ExceptionDispatchInfo.Throw(exception);
					}
					long num3 = 0L;
					object obj;
					Monitor.Enter(obj, num3 != 0L);
					int num4 = 1;
					this.SubmitRequest(num4 != 0);
					long num5 = 0L;
					int num6 = 9;
					Monitor.Exit(obj);
					if (num5 != 0L)
					{
						throw new OutOfMemoryException();
					}
					if (num6 == 0)
					{
					}
					long num7 = 0L;
					bool isEnabled2 = NetEventSource.IsEnabled;
					if (num7 == 0L)
					{
					}
				}
				throw new OutOfMemoryException();
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x0001D8B0 File Offset: 0x0001BAB0
		public override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (num == 0)
			{
			}
			if (asyncResult != null)
			{
				Exception exception = this._exception;
				if (exception != null)
				{
					ExceptionDispatchInfo.Throw(exception);
				}
				Stream stream = this._stream;
				int readWriteTimeout = this._readWriteTimeout;
				int readWriteTimeout2 = this._readWriteTimeout;
				long num2 = 0L;
				bool isEnabled2 = NetEventSource.IsEnabled;
				if (num2 == 0L)
				{
					return stream;
				}
			}
			else
			{
				string text = SR.Format("{0} can only be called once for each asynchronous operation.", "EndGetResponse");
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0001D94C File Offset: 0x0001BB4C
		private void SubmitRequest(bool isAsync)
		{
			if (this._connection != null)
			{
				return;
			}
			FtpControlStream ftpControlStream = this.CreateConnection();
			this._connection = ftpControlStream;
			DateTime utcNow = DateTime.UtcNow;
			DateTime startTime = this._startTime;
			double totalMilliseconds = (utcNow - startTime).TotalMilliseconds;
			bool isEnabled = NetEventSource.IsEnabled;
			NetEventSource.Info(this, "Request being submitted", "SubmitRequest");
			global::System.Net.Sockets.NetworkStream networkStream = ftpControlStream._networkStream;
			int remainingTimeout = this._remainingTimeout;
			global::System.Net.Sockets.NetworkStream networkStream2 = ftpControlStream._networkStream;
			Stream stream = this.TimedSubmitRequestHelper(remainingTimeout != 0);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0001DA40 File Offset: 0x0001BC40
		private Exception TranslateConnectException(Exception e)
		{
			while (e == null)
			{
			}
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0001DA58 File Offset: 0x0001BC58
		private void CreateConnectionAsync()
		{
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0001DA70 File Offset: 0x0001BC70
		private FtpControlStream CreateConnection()
		{
			/*
An exception occurred when decompiling this method (0600086B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.FtpControlStream System.Net.FtpWebRequest::CreateConnection()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0B, callgetter:string(Uri::get_Host, ldfld:Uri(FtpWebRequest::_uri, ldloc:FtpWebRequest(this))))
	stloc:int32(var_1_17, callgetter:int32(Uri::get_Port, ldfld:Uri(FtpWebRequest::_uri, ldloc:FtpWebRequest(this))))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0001DA98 File Offset: 0x0001BC98
		private Stream TimedSubmitRequestHelper(bool isAsync)
		{
			if (this._requestCompleteAsyncResult == null)
			{
			}
			FtpControlStream connection = this._connection;
			int num = 1;
			int num2 = 1;
			return connection.SubmitRequest(this, num != 0, num2 != 0);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0001DB70 File Offset: 0x0001BD70
		private void TimerCallback(TimerThread.Timer timer, int timeNoticed, object context)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			FtpControlStream connection = this._connection;
			if (connection != null)
			{
				if (!true)
				{
				}
				bool isEnabled2 = NetEventSource.IsEnabled;
				if (!true)
				{
				}
				NetEventSource.Info(this, "aborting connection", "TimerCallback");
				connection.AbortConnect();
				return;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x0001DBBC File Offset: 0x0001BDBC
		private TimerThread.Queue TimerQueue
		{
			get
			{
				TimerThread.Queue orCreateQueue;
				if (this._timerQueue == null)
				{
					orCreateQueue = TimerThread.GetOrCreateQueue(this._remainingTimeout);
					this._timerQueue = orCreateQueue;
				}
				return orCreateQueue;
			}
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0001DBE8 File Offset: 0x0001BDE8
		private bool AttemptedRecovery(Exception e)
		{
			FtpControlStream connection;
			do
			{
				if (e != null)
				{
				}
				if (this._onceFailed || this._aborted || this._timedOut)
				{
				}
				connection = this._connection;
				while (connection == null)
				{
				}
			}
			while (!connection._recoverableFailure);
			object syncObject = this._syncObject;
			int num = 1;
			this._onceFailed = num != 0;
			FtpControlStream connection2 = this._connection;
			long num2;
			if (connection2 != null)
			{
				global::System.Net.Sockets.NetworkStream networkStream = connection2._networkStream;
				connection2._client.Dispose();
				bool isEnabled = NetEventSource.IsEnabled;
				FtpControlStream connection3 = this._connection;
				if (connection3 != null && connection3 == null)
				{
					throw new ArrayTypeMismatchException();
				}
				if ("Releasing connection: {0}" == null)
				{
				}
				FormattableString formattableString;
				NetEventSource.Info(this, formattableString, "AttemptedRecovery");
				num2 = 0L;
			}
			if ("AttemptedRecovery" != null)
			{
				Monitor.Exit(syncObject);
			}
			if (num2 == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0001DCC8 File Offset: 0x0001BEC8
		private void SetException(Exception exception)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (num == 0)
			{
			}
			if (exception != null)
			{
			}
			if (this._exception == null)
			{
				FtpControlStream connection = this._connection;
				if (exception != null)
				{
				}
				if (connection != null && connection.StatusCode != FtpStatusCode.Undefined)
				{
					string statusLine = connection.StatusLine;
					string text = SR.Format("The remote server returned an error: {0}.", statusLine);
					FtpWebResponse ftpWebResponse = this._ftpWebResponse;
					return;
				}
				if (connection == null)
				{
					return;
				}
				FtpWebResponse ftpWebResponse2 = this._ftpWebResponse;
				if (ftpWebResponse2 != null)
				{
					FtpStatusCode statusCode = connection.StatusCode;
					string statusLine2 = connection.StatusLine;
					string exitMessage = connection.ExitMessage;
					ftpWebResponse2._statusCode = statusCode;
					ftpWebResponse2._statusLine = statusLine2;
					ftpWebResponse2._exitMessage = exitMessage;
				}
			}
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0001DD90 File Offset: 0x0001BF90
		private void CheckError()
		{
			Exception exception = this._exception;
			if (exception != null)
			{
				ExceptionDispatchInfo.Throw(exception);
				return;
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0001DDB0 File Offset: 0x0001BFB0
		internal void RequestCallback(object obj)
		{
			if (this._async)
			{
				this.AsyncRequestCallback(obj);
				return;
			}
			this.SyncRequestCallback(obj);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0001DDD4 File Offset: 0x0001BFD4
		private void SyncRequestCallback(object obj)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (num == 0)
			{
			}
			NetEventSource.Enter(this, obj, "SyncRequestCallback");
			if (obj != null)
			{
			}
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0001DE4C File Offset: 0x0001C04C
		private void AsyncRequestCallback(object obj)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (num == 0)
			{
			}
			NetEventSource.Enter(this, obj, "AsyncRequestCallback");
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0001E0F8 File Offset: 0x0001C2F8
		private FtpWebRequest.RequestStage FinishRequestStage(FtpWebRequest.RequestStage stage)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			long num = 0L;
			long num2 = 0L;
			if (num == 0L)
			{
				if (5 == 0)
				{
					if (num2 != 0L)
					{
					}
					if (13 == 0)
					{
					}
				}
				return FtpWebRequest.RequestStage.ReleaseConnection;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0001E150 File Offset: 0x0001C350
		public override void Abort()
		{
			bool aborted = this._aborted;
			if (!aborted)
			{
				if (!aborted)
				{
				}
				bool isEnabled = NetEventSource.IsEnabled;
				if (!aborted)
				{
				}
				long num = 0L;
				object syncObject = this._syncObject;
				Monitor.Enter(syncObject, num != 0L);
				FtpWebRequest.RequestStage requestStage = this._requestStage;
				FtpControlStream connection = this._connection;
				Stream stream = this._stream;
				int num2 = 1;
				this._aborted = num2 != 0;
				WebException requestAbortedException = ExceptionHelper.RequestAbortedException;
				this._exception = requestAbortedException;
				return;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x0001E294 File Offset: 0x0001C494
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x0001E2A4 File Offset: 0x0001C4A4
		public bool KeepAlive
		{
			get
			{
				return true;
			}
			set
			{
				while (this._getRequestStreamStarted || this._getResponseStarted)
				{
				}
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x0001E2C4 File Offset: 0x0001C4C4
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x0001E2DC File Offset: 0x0001C4DC
		public override global::System.Net.Cache.RequestCachePolicy CachePolicy
		{
			get
			{
				if (!true)
				{
				}
				return FtpWebRequest.DefaultCachePolicy;
			}
			set
			{
				while (this._getRequestStreamStarted || this._getResponseStarted)
				{
				}
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x0001E2FC File Offset: 0x0001C4FC
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x0001E310 File Offset: 0x0001C510
		public bool UseBinary
		{
			get
			{
				return this._binary;
			}
			set
			{
				bool getResponseStarted;
				for (;;)
				{
					if (!this._getRequestStreamStarted)
					{
						getResponseStarted = this._getResponseStarted;
						if (!getResponseStarted)
						{
							break;
						}
					}
				}
				this._binary = getResponseStarted;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x0001E338 File Offset: 0x0001C538
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x0001E34C File Offset: 0x0001C54C
		public bool UsePassive
		{
			get
			{
				return this._passive;
			}
			set
			{
				bool getResponseStarted;
				do
				{
					getResponseStarted = this._getResponseStarted;
				}
				while (getResponseStarted);
				this._passive = getResponseStarted;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x0001E36C File Offset: 0x0001C56C
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x0001E384 File Offset: 0x0001C584
		public global::System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates
		{
			get
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				global::System.Security.Cryptography.X509Certificates.X509CertificateCollection x509CertificateCollection;
				return x509CertificateCollection;
			}
			set
			{
				while (value == null)
				{
				}
				this._clientCertificates = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x0001E39C File Offset: 0x0001C59C
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x0001E3B0 File Offset: 0x0001C5B0
		public bool EnableSsl
		{
			get
			{
				return this._enableSsl;
			}
			set
			{
				bool getResponseStarted;
				for (;;)
				{
					if (!this._getRequestStreamStarted)
					{
						getResponseStarted = this._getResponseStarted;
						if (!getResponseStarted)
						{
							break;
						}
					}
				}
				this._enableSsl = getResponseStarted;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x0001E3D8 File Offset: 0x0001C5D8
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x0001E3EC File Offset: 0x0001C5EC
		public override WebHeaderCollection Headers
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000883)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.WebHeaderCollection System.Net.FtpWebRequest::get_Headers()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:WebHeaderCollection[exp:bool](FtpWebRequest::_ftpRequestHeaders, ldloc:FtpWebRequest(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				this._ftpRequestHeaders = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x0001E400 File Offset: 0x0001C600
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x0001E414 File Offset: 0x0001C614
		public override string ContentType
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000885)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.FtpWebRequest::get_ContentType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NotSupportedException(var_1_07, callgetter:NotSupportedException(ExceptionHelper::get_PropertyNotSupportedException))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				/*
An exception occurred when decompiling this method (06000886)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.FtpWebRequest::set_ContentType(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NotSupportedException(var_1_07, callgetter:NotSupportedException(ExceptionHelper::get_PropertyNotSupportedException))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x0001E428 File Offset: 0x0001C628
		// (set) Token: 0x06000888 RID: 2184 RVA: 0x0001E43C File Offset: 0x0001C63C
		public override bool UseDefaultCredentials
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000887)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.FtpWebRequest::get_UseDefaultCredentials()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NotSupportedException(var_1_07, callgetter:NotSupportedException(ExceptionHelper::get_PropertyNotSupportedException))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				/*
An exception occurred when decompiling this method (06000888)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.FtpWebRequest::set_UseDefaultCredentials(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NotSupportedException(var_1_07, callgetter:NotSupportedException(ExceptionHelper::get_PropertyNotSupportedException))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x0001E450 File Offset: 0x0001C650
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x0001E464 File Offset: 0x0001C664
		public override bool PreAuthenticate
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000889)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.FtpWebRequest::get_PreAuthenticate()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NotSupportedException(var_1_07, callgetter:NotSupportedException(ExceptionHelper::get_PropertyNotSupportedException))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				/*
An exception occurred when decompiling this method (0600088A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.FtpWebRequest::set_PreAuthenticate(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NotSupportedException(var_1_07, callgetter:NotSupportedException(ExceptionHelper::get_PropertyNotSupportedException))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x0001E478 File Offset: 0x0001C678
		private bool InUse
		{
			get
			{
				return !this._getRequestStreamStarted || true;
			}
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0001E490 File Offset: 0x0001C690
		private void EnsureFtpWebResponse(Exception exception)
		{
			FtpWebResponse ftpWebResponse = this._ftpWebResponse;
			long contentLength;
			if (ftpWebResponse == null || (ftpWebResponse != null && this._stream != null))
			{
				object syncObject = this._syncObject;
				FtpWebResponse ftpWebResponse2 = this._ftpWebResponse;
				Stream stream;
				if (ftpWebResponse2 != null)
				{
					if (ftpWebResponse2 == null)
					{
						goto IL_0090;
					}
					if (ftpWebResponse2 == null)
					{
						return;
					}
				}
				else
				{
					stream = this._stream;
				}
				FtpMethodFlags flags = this._methodInfo.Flags;
				if (stream != null)
				{
					Stream stream2 = this._stream;
					Stream stream3 = this._stream;
					int readWriteTimeout = this._readWriteTimeout;
					Stream stream4 = this._stream;
					int readWriteTimeout2 = this._readWriteTimeout;
				}
				FtpControlStream connection = this._connection;
				if (connection != null)
				{
					contentLength = connection._contentLength;
					return;
				}
				if (this._ftpWebResponse == null)
				{
					if (connection != null)
					{
						global::System.Uri responseUri = connection._responseUri;
						FtpStatusCode statusCode = connection.StatusCode;
						string statusLine = connection.StatusLine;
						DateTime lastModified = connection._lastModified;
						string bannerMessage = connection.BannerMessage;
						string welcomeMessage = connection.WelcomeMessage;
						string exitMessage = connection.ExitMessage;
						return;
					}
					global::System.Uri uri = this._uri;
					DateTime now = DateTime.Now;
					return;
				}
				IL_0090:
				long num = 0L;
				if (contentLength != 0L)
				{
					Monitor.Exit(syncObject);
				}
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (3 != 0)
				{
					return;
				}
			}
			if (contentLength == 0L)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			FtpWebResponse ftpWebResponse3 = this._ftpWebResponse;
			if (ftpWebResponse3 == null || ftpWebResponse3 != null)
			{
				Stream responseStream = this._ftpWebResponse._responseStream;
				if (responseStream == null || responseStream != null)
				{
					FormattableString formattableString;
					NetEventSource.Info(this, formattableString, "EnsureFtpWebResponse");
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0001E610 File Offset: 0x0001C810
		internal void DataStreamClosed(CloseExState closeState)
		{
			FtpControlStream ftpControlStream;
			if (this._async)
			{
				object obj = this._requestCompleteAsyncResult.InternalWaitForCompletion();
				Exception exception = this._exception;
				if (exception != null)
				{
					ExceptionDispatchInfo.Throw(exception);
					return;
				}
			}
			else if (ftpControlStream._lastModified != null)
			{
				return;
			}
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0001E660 File Offset: 0x0001C860
		// Note: this type is marked as 'beforefieldinit'.
		static FtpWebRequest()
		{
			TimerThread.Queue orCreateQueue = TimerThread.GetOrCreateQueue(34464);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0001E678 File Offset: 0x0001C878
		internal FtpWebRequest()
		{
			throw new NotSupportedException();
		}

		// Token: 0x040006BD RID: 1725
		private object _syncObject;

		// Token: 0x040006BE RID: 1726
		private ICredentials _authInfo;

		// Token: 0x040006BF RID: 1727
		private readonly global::System.Uri _uri;

		// Token: 0x040006C0 RID: 1728
		private FtpMethodInfo _methodInfo;

		// Token: 0x040006C1 RID: 1729
		private string _renameTo;

		// Token: 0x040006C2 RID: 1730
		private bool _getRequestStreamStarted;

		// Token: 0x040006C3 RID: 1731
		private bool _getResponseStarted;

		// Token: 0x040006C4 RID: 1732
		private DateTime _startTime;

		// Token: 0x040006C5 RID: 1733
		private int _timeout;

		// Token: 0x040006C6 RID: 1734
		private int _remainingTimeout;

		// Token: 0x040006C7 RID: 1735
		private long _contentLength;

		// Token: 0x040006C8 RID: 1736
		private long _contentOffset;

		// Token: 0x040006C9 RID: 1737
		private global::System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates;

		// Token: 0x040006CA RID: 1738
		private bool _passive;

		// Token: 0x040006CB RID: 1739
		private bool _binary;

		// Token: 0x040006CC RID: 1740
		private string _connectionGroupName;

		// Token: 0x040006CD RID: 1741
		private ServicePoint _servicePoint;

		// Token: 0x040006CE RID: 1742
		private bool _async;

		// Token: 0x040006CF RID: 1743
		private bool _aborted;

		// Token: 0x040006D0 RID: 1744
		private bool _timedOut;

		// Token: 0x040006D1 RID: 1745
		private Exception _exception;

		// Token: 0x040006D2 RID: 1746
		private TimerThread.Queue _timerQueue;

		// Token: 0x040006D3 RID: 1747
		private TimerThread.Callback _timerCallback;

		// Token: 0x040006D4 RID: 1748
		private bool _enableSsl;

		// Token: 0x040006D5 RID: 1749
		private FtpControlStream _connection;

		// Token: 0x040006D6 RID: 1750
		private Stream _stream;

		// Token: 0x040006D7 RID: 1751
		private FtpWebRequest.RequestStage _requestStage;

		// Token: 0x040006D8 RID: 1752
		private bool _onceFailed;

		// Token: 0x040006D9 RID: 1753
		private WebHeaderCollection _ftpRequestHeaders;

		// Token: 0x040006DA RID: 1754
		private FtpWebResponse _ftpWebResponse;

		// Token: 0x040006DB RID: 1755
		private int _readWriteTimeout;

		// Token: 0x040006DC RID: 1756
		private ContextAwareResult _writeAsyncResult;

		// Token: 0x040006DD RID: 1757
		private LazyAsyncResult _readAsyncResult;

		// Token: 0x040006DE RID: 1758
		private LazyAsyncResult _requestCompleteAsyncResult;

		// Token: 0x040006DF RID: 1759
		private static readonly NetworkCredential s_defaultFtpNetworkCredential;

		// Token: 0x040006E0 RID: 1760
		private const int s_DefaultTimeout = 100000;

		// Token: 0x040006E1 RID: 1761
		private static readonly TimerThread.Queue s_DefaultTimerQueue;

		// Token: 0x02000152 RID: 338
		private enum RequestStage
		{
			// Token: 0x040006E3 RID: 1763
			CheckForError,
			// Token: 0x040006E4 RID: 1764
			RequestStarted,
			// Token: 0x040006E5 RID: 1765
			WriteReady,
			// Token: 0x040006E6 RID: 1766
			ReadReady,
			// Token: 0x040006E7 RID: 1767
			ReleaseConnection
		}

		// Token: 0x02000153 RID: 339
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <CreateConnectionAsync>d__86 : IAsyncStateMachine
		{
			// Token: 0x06000890 RID: 2192 RVA: 0x0001E68C File Offset: 0x0001C88C
			private void MoveNext()
			{
				FtpWebRequest ftpWebRequest = this.<>4__this;
				string host = ftpWebRequest._uri.Host;
				int port = ftpWebRequest._uri.Port;
				long num = 0L;
				Task task;
				ConfiguredTaskAwaitable configuredTaskAwaitable = task.ConfigureAwait(num != 0L);
			}

			// Token: 0x06000891 RID: 2193 RVA: 0x0001E6E8 File Offset: 0x0001C8E8
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040006E8 RID: 1768
			public int <>1__state;

			// Token: 0x040006E9 RID: 1769
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040006EA RID: 1770
			public FtpWebRequest <>4__this;

			// Token: 0x040006EB RID: 1771
			private global::System.Net.Sockets.TcpClient <client>5__2;

			// Token: 0x040006EC RID: 1772
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000154 RID: 340
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000892 RID: 2194 RVA: 0x0001E6F8 File Offset: 0x0001C8F8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06000893 RID: 2195 RVA: 0x0001E708 File Offset: 0x0001C908
			public <>c()
			{
			}

			// Token: 0x06000894 RID: 2196 RVA: 0x00002050 File Offset: 0x00000250
			internal global::System.Security.Cryptography.X509Certificates.X509CertificateCollection <get_ClientCertificates>b__114_0()
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x040006ED RID: 1773
			public static readonly FtpWebRequest.<>c <>9;

			// Token: 0x040006EE RID: 1774
			public static Func<global::System.Security.Cryptography.X509Certificates.X509CertificateCollection> <>9__114_0;
		}
	}
}
