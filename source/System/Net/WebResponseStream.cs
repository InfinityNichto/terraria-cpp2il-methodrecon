using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	// Token: 0x02000298 RID: 664
	internal class WebResponseStream : WebConnectionStream
	{
		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x00039240 File Offset: 0x00037440
		public WebRequestStream RequestStream
		{
			[CompilerGenerated]
			get
			{
				return this.<RequestStream>k__BackingField;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x00039254 File Offset: 0x00037454
		// (set) Token: 0x06001256 RID: 4694 RVA: 0x00039268 File Offset: 0x00037468
		public WebHeaderCollection Headers
		{
			[CompilerGenerated]
			get
			{
				return this.<Headers>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Headers>k__BackingField = value;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x0003927C File Offset: 0x0003747C
		// (set) Token: 0x06001258 RID: 4696 RVA: 0x00039290 File Offset: 0x00037490
		public HttpStatusCode StatusCode
		{
			[CompilerGenerated]
			get
			{
				return this.<StatusCode>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<StatusCode>k__BackingField = value;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x000392A4 File Offset: 0x000374A4
		// (set) Token: 0x0600125A RID: 4698 RVA: 0x000392B8 File Offset: 0x000374B8
		public string StatusDescription
		{
			[CompilerGenerated]
			get
			{
				return this.<StatusDescription>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<StatusDescription>k__BackingField = value;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x000392CC File Offset: 0x000374CC
		// (set) Token: 0x0600125C RID: 4700 RVA: 0x000392E0 File Offset: 0x000374E0
		public Version Version
		{
			[CompilerGenerated]
			get
			{
				return this.<Version>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Version>k__BackingField = value;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x000392F4 File Offset: 0x000374F4
		// (set) Token: 0x0600125E RID: 4702 RVA: 0x00039308 File Offset: 0x00037508
		public bool KeepAlive
		{
			[CompilerGenerated]
			get
			{
				return this.<KeepAlive>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00039318 File Offset: 0x00037518
		public WebResponseStream(WebRequestStream request)
		{
			WebConnection <Connection>k__BackingField = request.<Connection>k__BackingField;
			WebOperation <Operation>k__BackingField = request.<Operation>k__BackingField;
			base..ctor(<Connection>k__BackingField, <Operation>k__BackingField);
			this.RequestStream = request;
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x00039344 File Offset: 0x00037544
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x00039354 File Offset: 0x00037554
		public override bool CanWrite
		{
			get
			{
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x00039364 File Offset: 0x00037564
		// (set) Token: 0x06001263 RID: 4707 RVA: 0x00039378 File Offset: 0x00037578
		private bool ChunkedRead
		{
			[CompilerGenerated]
			get
			{
				return this.<ChunkedRead>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00039388 File Offset: 0x00037588
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (06001264)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Int32> System.Net.WebResponseStream::ReadAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x06001265 RID: 4709 RVA: 0x00039398 File Offset: 0x00037598
		private Task<int> ProcessRead(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			bool flag = this.read_eof;
			if (flag)
			{
				if (!flag)
				{
				}
			}
			if (!flag)
			{
			}
			Task task;
			return task;
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x000393BC File Offset: 0x000375BC
		protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, [Out] int result)
		{
			if (!this.bufferedEntireContent || this.innerStream != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x000393DC File Offset: 0x000375DC
		private bool CheckAuthHeader(string headerName)
		{
			/*
An exception occurred when decompiling this method (06001267)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.WebResponseStream::CheckAuthHeader(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_1C, call:int32(string::IndexOf, ldloc:string(var_0_0C), ldstr:string("NTLM"), ldc.i4:StringComparison(4)))
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

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x00039408 File Offset: 0x00037608
		private bool ExpectContent
		{
			get
			{
				HttpWebRequest <Request>k__BackingField = this.<Request>k__BackingField;
				HttpStatusCode httpStatusCode = this.<StatusCode>k__BackingField;
				bool flag;
				return flag;
			}
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00039428 File Offset: 0x00037628
		private void Initialize(BufferOffsetSize buffer)
		{
			string text = this.<Headers>k__BackingField["Transfer-Encoding"];
			if (text != null)
			{
				int num = text.IndexOf("chunked", StringComparison.OrdinalIgnoreCase);
				return;
			}
			long num2 = 0L;
			string text2 = this.<Headers>k__BackingField["Content-Length"];
			if (num2 == 0L)
			{
				long num3 = 0L;
				bool flag = string.IsNullOrEmpty(text2);
				bool flag2 = long.TryParse(text2, num3);
			}
			bool expectContent = this.ExpectContent;
			string text3 = this.<Headers>k__BackingField["Transfer-Encoding"];
			if (text3 != null)
			{
				int num4 = text3.IndexOf("chunked", StringComparison.OrdinalIgnoreCase);
				return;
			}
			long num5 = 0L;
			this.<ChunkedRead>k__BackingField = num5 != 0L;
			Version version = this.<Version>k__BackingField;
			if (num5 == 0L)
			{
			}
			if (this.<RequestStream>k__BackingField.<KeepAlive>k__BackingField)
			{
				WebHeaderCollection webHeaderCollection = this.<Headers>k__BackingField;
				this.<KeepAlive>k__BackingField = true;
				bool usesProxy = base.ServicePoint.usesProxy;
				string text4;
				if (text4 != null)
				{
					string text5 = text4.ToLower();
					int num6 = text5.IndexOf("keep-alive", StringComparison.Ordinal);
					this.<KeepAlive>k__BackingField = usesProxy;
					int num7 = text5.IndexOf("close", StringComparison.Ordinal);
				}
				if (!this.<ChunkedRead>k__BackingField)
				{
				}
			}
			bool expectContent2 = this.ExpectContent;
			if (!this.<ChunkedRead>k__BackingField)
			{
			}
			WebRequestStream webRequestStream = this.<RequestStream>k__BackingField;
			WebOperation <Operation>k__BackingField = this.<Operation>k__BackingField;
			Stream <InnerStream>k__BackingField = webRequestStream.<InnerStream>k__BackingField;
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x0003963C File Offset: 0x0003783C
		private Task<byte[]> ReadAllAsyncInner(CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (0600126A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Byte[]> System.Net.WebResponseStream::ReadAllAsyncInner(System.Threading.CancellationToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x0600126B RID: 4715 RVA: 0x0003964C File Offset: 0x0003784C
		internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00039668 File Offset: 0x00037868
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			Task task;
			return task;
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x0003967C File Offset: 0x0003787C
		protected override void Close_internal(bool disposed)
		{
			if (this.closed || this.nextReadCalled)
			{
				return;
			}
			bool flag = this.read_eof;
			this.nextReadCalled = true;
			if (flag || this.bufferedEntireContent)
			{
				disposed.m_value = true;
				WebReadStream webReadStream = this.innerStream;
				if (webReadStream != null)
				{
					webReadStream.Dispose();
				}
				WebOperation <Operation>k__BackingField = this.<Operation>k__BackingField;
				return;
			}
			this.closed = true;
			WebOperation <Operation>k__BackingField2 = this.<Operation>k__BackingField;
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x000396E0 File Offset: 0x000378E0
		private WebException GetReadException(WebExceptionStatus status, Exception error, string where)
		{
			while (base.GetException(error) == null)
			{
			}
			bool aborted = this.<Operation>k__BackingField.Aborted;
			return HttpWebRequest.CreateRequestAbortedException();
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0003970C File Offset: 0x0003790C
		internal Task InitReadAsync(CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00039728 File Offset: 0x00037928
		private bool GetResponse(BufferOffsetSize buffer, int pos, ReadState state)
		{
			return " " != null;
		}

		// Token: 0x04000E5B RID: 3675
		private WebReadStream innerStream;

		// Token: 0x04000E5C RID: 3676
		private bool nextReadCalled;

		// Token: 0x04000E5D RID: 3677
		private bool bufferedEntireContent;

		// Token: 0x04000E5E RID: 3678
		private WebCompletionSource pendingRead;

		// Token: 0x04000E5F RID: 3679
		private object locker;

		// Token: 0x04000E60 RID: 3680
		private int nestedRead;

		// Token: 0x04000E61 RID: 3681
		private bool read_eof;

		// Token: 0x04000E62 RID: 3682
		[CompilerGenerated]
		private readonly WebRequestStream <RequestStream>k__BackingField;

		// Token: 0x04000E63 RID: 3683
		[CompilerGenerated]
		private WebHeaderCollection <Headers>k__BackingField;

		// Token: 0x04000E64 RID: 3684
		[CompilerGenerated]
		private HttpStatusCode <StatusCode>k__BackingField;

		// Token: 0x04000E65 RID: 3685
		[CompilerGenerated]
		private string <StatusDescription>k__BackingField;

		// Token: 0x04000E66 RID: 3686
		[CompilerGenerated]
		private Version <Version>k__BackingField;

		// Token: 0x04000E67 RID: 3687
		[CompilerGenerated]
		private bool <KeepAlive>k__BackingField;

		// Token: 0x04000E68 RID: 3688
		internal readonly string ME;

		// Token: 0x04000E69 RID: 3689
		[CompilerGenerated]
		private bool <ChunkedRead>k__BackingField;

		// Token: 0x02000299 RID: 665
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <ReadAsync>d__40 : IAsyncStateMachine
		{
			// Token: 0x06001271 RID: 4721 RVA: 0x00039878 File Offset: 0x00037A78
			private void MoveNext()
			{
				WebResponseStream webResponseStream = this.<>4__this;
				if (this.buffer != null)
				{
					int num = this.offset;
					int num2 = this.count;
					int num3 = 1;
					long num4 = 0L;
					if (Interlocked.CompareExchange(-1073741824, num3, (int)num4) == 0)
					{
						return;
					}
				}
			}

			// Token: 0x06001272 RID: 4722 RVA: 0x00039A10 File Offset: 0x00037C10
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000E6A RID: 3690
			public int <>1__state;

			// Token: 0x04000E6B RID: 3691
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04000E6C RID: 3692
			public CancellationToken cancellationToken;

			// Token: 0x04000E6D RID: 3693
			public byte[] buffer;

			// Token: 0x04000E6E RID: 3694
			public int offset;

			// Token: 0x04000E6F RID: 3695
			public int count;

			// Token: 0x04000E70 RID: 3696
			public WebResponseStream <>4__this;

			// Token: 0x04000E71 RID: 3697
			private WebCompletionSource <completion>5__2;

			// Token: 0x04000E72 RID: 3698
			private int <nbytes>5__3;

			// Token: 0x04000E73 RID: 3699
			private Exception <throwMe>5__4;

			// Token: 0x04000E74 RID: 3700
			private ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04000E75 RID: 3701
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__2;
		}

		// Token: 0x0200029A RID: 666
		[CompilerGenerated]
		private sealed class <>c__DisplayClass41_0
		{
			// Token: 0x06001273 RID: 4723 RVA: 0x00039A20 File Offset: 0x00037C20
			public <>c__DisplayClass41_0()
			{
			}

			// Token: 0x06001274 RID: 4724 RVA: 0x00039A34 File Offset: 0x00037C34
			internal Task<int> <ProcessRead>b__0(CancellationToken ct)
			{
				/*
An exception occurred when decompiling this method (06001274)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Int32> System.Net.WebResponseStream/<>c__DisplayClass41_0::<ProcessRead>b__0(System.Threading.CancellationToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:WebResponseStream(var_0_06, ldfld:WebResponseStream('<>c__DisplayClass41_0'::<>4__this, ldloc:'<>c__DisplayClass41_0'(this)))
	stloc:uint8[](var_1_0D, ldfld:uint8[]('<>c__DisplayClass41_0'::buffer, ldloc:'<>c__DisplayClass41_0'(this)))
	stloc:int32(var_2_14, ldfld:int32('<>c__DisplayClass41_0'::offset, ldloc:'<>c__DisplayClass41_0'(this)))
	stloc:WebReadStream(var_3_1B, ldfld:WebReadStream(WebResponseStream::innerStream, ldloc:WebResponseStream(var_0_06)))
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

			// Token: 0x06001275 RID: 4725 RVA: 0x00039A5C File Offset: 0x00037C5C
			internal void <ProcessRead>b__1()
			{
				this.<>4__this.<Operation>k__BackingField.Abort();
				this.<>4__this.innerStream.Dispose();
			}

			// Token: 0x06001276 RID: 4726 RVA: 0x00039A8C File Offset: 0x00037C8C
			internal bool <ProcessRead>b__2()
			{
				return this.<>4__this.<Operation>k__BackingField.Aborted;
			}

			// Token: 0x04000E76 RID: 3702
			public WebResponseStream <>4__this;

			// Token: 0x04000E77 RID: 3703
			public byte[] buffer;

			// Token: 0x04000E78 RID: 3704
			public int offset;

			// Token: 0x04000E79 RID: 3705
			public int size;
		}

		// Token: 0x0200029B RID: 667
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <ReadAllAsyncInner>d__47 : IAsyncStateMachine
		{
			// Token: 0x06001277 RID: 4727 RVA: 0x00039AAC File Offset: 0x00037CAC
			private void MoveNext()
			{
				int num = 1;
				WebResponseStream webResponseStream = this.<>4__this;
				if (num == 0)
				{
				}
				int num2 = 1;
				if (num2 == 0)
				{
				}
				this.<maximumSize>5__2 = (long)num2;
			}

			// Token: 0x06001278 RID: 4728 RVA: 0x00039B68 File Offset: 0x00037D68
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000E7A RID: 3706
			public int <>1__state;

			// Token: 0x04000E7B RID: 3707
			public AsyncTaskMethodBuilder<byte[]> <>t__builder;

			// Token: 0x04000E7C RID: 3708
			public CancellationToken cancellationToken;

			// Token: 0x04000E7D RID: 3709
			public WebResponseStream <>4__this;

			// Token: 0x04000E7E RID: 3710
			private long <maximumSize>5__2;

			// Token: 0x04000E7F RID: 3711
			private MemoryStream <ms>5__3;

			// Token: 0x04000E80 RID: 3712
			private byte[] <buffer>5__4;

			// Token: 0x04000E81 RID: 3713
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200029C RID: 668
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <ReadAllAsync>d__48 : IAsyncStateMachine
		{
			// Token: 0x06001279 RID: 4729 RVA: 0x00039B78 File Offset: 0x00037D78
			private void MoveNext()
			{
				WebResponseStream webResponseStream = this.<>4__this;
				Task task = this.<>u__2.m_task;
				WebOperation <Operation>k__BackingField = webResponseStream.<Operation>k__BackingField;
				int num = 257;
				webResponseStream.nextReadCalled = num != 0;
				WebCompletionSource webCompletionSource = this.<completion>5__2;
				long num2 = 0L;
				int num3 = 24;
				if (num2 != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (num3 == 0)
				{
					WebOperation <Operation>k__BackingField2 = webResponseStream.<Operation>k__BackingField;
					return;
				}
			}

			// Token: 0x0600127A RID: 4730 RVA: 0x00039D74 File Offset: 0x00037F74
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000E82 RID: 3714
			public int <>1__state;

			// Token: 0x04000E83 RID: 3715
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000E84 RID: 3716
			public WebResponseStream <>4__this;

			// Token: 0x04000E85 RID: 3717
			public CancellationToken cancellationToken;

			// Token: 0x04000E86 RID: 3718
			public bool resending;

			// Token: 0x04000E87 RID: 3719
			private WebCompletionSource <completion>5__2;

			// Token: 0x04000E88 RID: 3720
			private CancellationTokenSource <timeoutCts>5__3;

			// Token: 0x04000E89 RID: 3721
			private Task <timeoutTask>5__4;

			// Token: 0x04000E8A RID: 3722
			private ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04000E8B RID: 3723
			private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter <>u__2;
		}

		// Token: 0x0200029D RID: 669
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <InitReadAsync>d__52 : IAsyncStateMachine
		{
			// Token: 0x0600127B RID: 4731 RVA: 0x00039D84 File Offset: 0x00037F84
			private void MoveNext()
			{
				WebResponseStream webResponseStream = this.<>4__this;
			}

			// Token: 0x0600127C RID: 4732 RVA: 0x00039ECC File Offset: 0x000380CC
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000E8C RID: 3724
			public int <>1__state;

			// Token: 0x04000E8D RID: 3725
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000E8E RID: 3726
			public WebResponseStream <>4__this;

			// Token: 0x04000E8F RID: 3727
			public CancellationToken cancellationToken;

			// Token: 0x04000E90 RID: 3728
			private BufferOffsetSize <buffer>5__2;

			// Token: 0x04000E91 RID: 3729
			private ReadState <state>5__3;

			// Token: 0x04000E92 RID: 3730
			private int <position>5__4;

			// Token: 0x04000E93 RID: 3731
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
