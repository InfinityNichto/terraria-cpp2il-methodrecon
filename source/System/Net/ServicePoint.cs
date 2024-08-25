using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace System.Net
{
	// Token: 0x0200026E RID: 622
	public class ServicePoint
	{
		// Token: 0x060010C8 RID: 4296 RVA: 0x00034E88 File Offset: 0x00033088
		internal ServicePoint(ServicePointManager.SPKey key, global::System.Uri uri, int connectionLimit, int maxIdleTime)
		{
			this.sendContinue = true;
			base..ctor();
			this.Key = key;
			this.uri = uri;
			this.connectionLimit = connectionLimit;
			this.m_ServerCertificateOrBytes = maxIdleTime;
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x00034EC0 File Offset: 0x000330C0
		internal ServicePointManager.SPKey Key
		{
			[CompilerGenerated]
			get
			{
				return this.<Key>k__BackingField;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060010CA RID: 4298 RVA: 0x00034ED4 File Offset: 0x000330D4
		// (set) Token: 0x060010CB RID: 4299 RVA: 0x00034EE8 File Offset: 0x000330E8
		private ServicePointScheduler Scheduler
		{
			[CompilerGenerated]
			get
			{
				return this.<Scheduler>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Scheduler>k__BackingField = value;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x060010CC RID: 4300 RVA: 0x00034EFC File Offset: 0x000330FC
		public global::System.Uri Address
		{
			get
			{
				return this.uri;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x00034F10 File Offset: 0x00033110
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x00034F24 File Offset: 0x00033124
		public BindIPEndPoint BindIPEndPointDelegate
		{
			get
			{
				return this.endPointCallback;
			}
			set
			{
				this.endPointCallback = value;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x00034F38 File Offset: 0x00033138
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x00034F4C File Offset: 0x0003314C
		public int ConnectionLeaseTimeout
		{
			get
			{
				return this.connectionLeaseTimeout;
			}
			set
			{
				this.connectionLeaseTimeout = value;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x00034F60 File Offset: 0x00033160
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x00034F74 File Offset: 0x00033174
		public int ConnectionLimit
		{
			get
			{
				return this.connectionLimit;
			}
			set
			{
				if (this.disposed)
				{
					return;
				}
				this.<Scheduler>k__BackingField.ConnectionLimit = value;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x00034F98 File Offset: 0x00033198
		public string ConnectionName
		{
			get
			{
				return this.uri.Scheme;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x00034FB0 File Offset: 0x000331B0
		public int CurrentConnections
		{
			get
			{
				while (!this.disposed)
				{
				}
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x00034FC8 File Offset: 0x000331C8
		public DateTime IdleSince
		{
			get
			{
				/*
An exception occurred when decompiling this method (060010D5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.Net.ServicePoint::get_IdleSince()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldloc:bool(var_0_06))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060010D6 RID: 4310 RVA: 0x00034FE4 File Offset: 0x000331E4
		// (set) Token: 0x060010D7 RID: 4311 RVA: 0x00034FF8 File Offset: 0x000331F8
		public int MaxIdleTime
		{
			get
			{
				return this.maxIdleTime;
			}
			set
			{
				bool flag = this.disposed;
				this.maxIdleTime = value;
				if (flag)
				{
					return;
				}
				this.<Scheduler>k__BackingField.MaxIdleTime = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060010D8 RID: 4312 RVA: 0x00035024 File Offset: 0x00033224
		public virtual Version ProtocolVersion
		{
			get
			{
				return this.protocolVersion;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x00035038 File Offset: 0x00033238
		// (set) Token: 0x060010DA RID: 4314 RVA: 0x0003504C File Offset: 0x0003324C
		public int ReceiveBufferSize
		{
			get
			{
				return this.receiveBufferSize;
			}
			set
			{
				this.receiveBufferSize = value;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x00035060 File Offset: 0x00033260
		public bool SupportsPipelining
		{
			get
			{
				if (!true)
				{
				}
				Version version = this.protocolVersion;
				bool flag;
				return flag;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x00035078 File Offset: 0x00033278
		// (set) Token: 0x060010DD RID: 4317 RVA: 0x0003508C File Offset: 0x0003328C
		public bool Expect100Continue
		{
			get
			{
				return this.SendContinue;
			}
			set
			{
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x0003509C File Offset: 0x0003329C
		// (set) Token: 0x060010DF RID: 4319 RVA: 0x000350B0 File Offset: 0x000332B0
		public bool UseNagleAlgorithm
		{
			get
			{
				return this.useNagle;
			}
			set
			{
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x000350C0 File Offset: 0x000332C0
		// (set) Token: 0x060010E1 RID: 4321 RVA: 0x000350F0 File Offset: 0x000332F0
		internal bool SendContinue
		{
			get
			{
				bool flag = this.sendContinue;
				if (flag)
				{
					Version version = this.protocolVersion;
					return true;
				}
				Version version2 = this.protocolVersion;
				if (!flag)
				{
				}
				bool flag2;
				return flag2;
			}
			set
			{
			}
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x00035100 File Offset: 0x00033300
		public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval)
		{
			this.tcp_keepalive_time = keepAliveTime;
			this.disposed = keepAliveInterval != 0;
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0003511C File Offset: 0x0003331C
		internal void KeepAliveSetup(global::System.Net.Sockets.Socket socket)
		{
			if (this.tcp_keepalive)
			{
				bool flag = this.tcp_keepalive;
				int num = this.tcp_keepalive_time;
				int num2 = this.tcp_keepalive_interval;
				return;
			}
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x00035148 File Offset: 0x00033348
		private static void PutBytes(byte[] bytes, uint v, int offset)
		{
			if (!true)
			{
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x0003515C File Offset: 0x0003335C
		// (set) Token: 0x060010E6 RID: 4326 RVA: 0x00035170 File Offset: 0x00033370
		internal bool UsesProxy
		{
			get
			{
				return this.usesProxy;
			}
			set
			{
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x00035180 File Offset: 0x00033380
		// (set) Token: 0x060010E8 RID: 4328 RVA: 0x00035194 File Offset: 0x00033394
		internal bool UseConnect
		{
			get
			{
				return this.useConnect;
			}
			set
			{
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x000351A4 File Offset: 0x000333A4
		private bool HasTimedOut
		{
			get
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				DateTime dateTime = this.lastDnsResolve;
				TimeSpan timeSpan;
				DateTime dateTime2 = dateTime + timeSpan;
				DateTime utcNow = DateTime.UtcNow;
				return dateTime2 < utcNow;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x000351E0 File Offset: 0x000333E0
		internal IPHostEntry HostEntry
		{
			get
			{
				object obj = this.hostE;
				long num = 0L;
				string text = this.uri.Host;
				global::System.UriHostNameType hostNameType = this.uri.HostNameType;
				global::System.UriHostNameType hostNameType2 = this.uri.HostNameType;
				if (this.host == null)
				{
					global::System.UriHostNameType hostNameType3 = this.uri.HostNameType;
					int stringLength = text._stringLength;
					int num2 = 1;
					string text2 = text.Substring(num2, (int)num);
					IPAddress ipaddress = IPAddress.Parse(text2);
					if (ipaddress != null && ipaddress == null)
					{
						throw new ArrayTypeMismatchException();
					}
					IPHostEntry iphostEntry = this.host;
					bool hasTimedOut = this.HasTimedOut;
					if (this.host == null)
					{
						DateTime utcNow = DateTime.UtcNow;
						this.lastDnsResolve = utcNow;
						IPHostEntry iphostEntry2;
						this.host = iphostEntry2;
						return iphostEntry2;
					}
				}
				long num3 = 0L;
				Monitor.Exit(obj);
				if (num3 == 0L)
				{
					return this.host;
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x000352D0 File Offset: 0x000334D0
		internal void SetVersion(Version version)
		{
			this.protocolVersion = version;
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x000352E4 File Offset: 0x000334E4
		internal void SendRequest(WebOperation operation, string groupName)
		{
			bool flag = this.disposed;
			if (flag)
			{
				if (!flag)
				{
				}
				return;
			}
			this.<Scheduler>k__BackingField.SendRequest(operation, groupName);
			long num = 0L;
			if (flag)
			{
				Monitor.Exit(this);
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x0003533C File Offset: 0x0003353C
		public bool CloseConnectionGroup(string connectionGroupName)
		{
			bool flag = this.disposed;
			if (flag)
			{
			}
			ServicePointScheduler servicePointScheduler = this.<Scheduler>k__BackingField;
			long num = 0L;
			if (flag)
			{
				Monitor.Exit(this);
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0003538C File Offset: 0x0003358C
		internal void FreeServicePoint()
		{
			this.disposed = true;
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x000353A0 File Offset: 0x000335A0
		public X509Certificate Certificate
		{
			get
			{
				object serverCertificateOrBytes = this.m_ServerCertificateOrBytes;
				if (serverCertificateOrBytes != null)
				{
					Type type;
					bool flag = serverCertificateOrBytes.GetType() == type;
					if (serverCertificateOrBytes != null)
					{
						throw new InvalidCastException();
					}
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x000353D4 File Offset: 0x000335D4
		internal void UpdateServerCertificate(X509Certificate certificate)
		{
			if (certificate != null)
			{
				return;
			}
			long num = 0L;
			this.m_ServerCertificateOrBytes = num;
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x000353F0 File Offset: 0x000335F0
		public X509Certificate ClientCertificate
		{
			get
			{
				object clientCertificateOrBytes = this.m_ClientCertificateOrBytes;
				if (clientCertificateOrBytes != null)
				{
					Type type;
					bool flag = clientCertificateOrBytes.GetType() == type;
					if (clientCertificateOrBytes != null)
					{
						throw new InvalidCastException();
					}
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00035424 File Offset: 0x00033624
		internal void UpdateClientCertificate(X509Certificate certificate)
		{
			if (certificate != null)
			{
				return;
			}
			long num = 0L;
			this.m_ClientCertificateOrBytes = num;
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00035440 File Offset: 0x00033640
		internal bool CallEndPointDelegate(global::System.Net.Sockets.Socket sock, IPEndPoint remote)
		{
			BindIPEndPoint bindIPEndPoint = this.endPointCallback;
			if (bindIPEndPoint != null)
			{
				IntPtr method_code = bindIPEndPoint.method_code;
				IntPtr invoke_impl = bindIPEndPoint.invoke_impl;
				IntPtr method = bindIPEndPoint.method;
				if (method_code != 0)
				{
					BindIPEndPoint bindIPEndPoint2 = this.endPointCallback;
				}
			}
			throw new OverflowException();
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00035494 File Offset: 0x00033694
		internal ServicePoint()
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000D2C RID: 3372
		private readonly global::System.Uri uri;

		// Token: 0x04000D2D RID: 3373
		private DateTime lastDnsResolve;

		// Token: 0x04000D2E RID: 3374
		private Version protocolVersion;

		// Token: 0x04000D2F RID: 3375
		private IPHostEntry host;

		// Token: 0x04000D30 RID: 3376
		private bool usesProxy;

		// Token: 0x04000D31 RID: 3377
		private bool sendContinue;

		// Token: 0x04000D32 RID: 3378
		private bool useConnect;

		// Token: 0x04000D33 RID: 3379
		private object hostE;

		// Token: 0x04000D34 RID: 3380
		private bool useNagle;

		// Token: 0x04000D35 RID: 3381
		private BindIPEndPoint endPointCallback;

		// Token: 0x04000D36 RID: 3382
		private bool tcp_keepalive;

		// Token: 0x04000D37 RID: 3383
		private int tcp_keepalive_time;

		// Token: 0x04000D38 RID: 3384
		private int tcp_keepalive_interval;

		// Token: 0x04000D39 RID: 3385
		private bool disposed;

		// Token: 0x04000D3A RID: 3386
		private int connectionLeaseTimeout;

		// Token: 0x04000D3B RID: 3387
		private int receiveBufferSize;

		// Token: 0x04000D3C RID: 3388
		[CompilerGenerated]
		private readonly ServicePointManager.SPKey <Key>k__BackingField;

		// Token: 0x04000D3D RID: 3389
		[CompilerGenerated]
		private ServicePointScheduler <Scheduler>k__BackingField;

		// Token: 0x04000D3E RID: 3390
		private int connectionLimit;

		// Token: 0x04000D3F RID: 3391
		private int maxIdleTime;

		// Token: 0x04000D40 RID: 3392
		private object m_ServerCertificateOrBytes;

		// Token: 0x04000D41 RID: 3393
		private object m_ClientCertificateOrBytes;
	}
}
