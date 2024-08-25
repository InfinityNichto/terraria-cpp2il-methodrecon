using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	// Token: 0x02000286 RID: 646
	internal class WebConnectionTunnel
	{
		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x0003764C File Offset: 0x0003584C
		public HttpWebRequest Request
		{
			[CompilerGenerated]
			get
			{
				return this.<Request>k__BackingField;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x00037660 File Offset: 0x00035860
		public global::System.Uri ConnectUri
		{
			[CompilerGenerated]
			get
			{
				return this.<ConnectUri>k__BackingField;
			}
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00037674 File Offset: 0x00035874
		public WebConnectionTunnel(HttpWebRequest request, global::System.Uri connectUri)
		{
			this.Request = request;
			this.ConnectUri = connectUri;
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00037698 File Offset: 0x00035898
		// (set) Token: 0x060011D7 RID: 4567 RVA: 0x000376AC File Offset: 0x000358AC
		public bool Success
		{
			[CompilerGenerated]
			get
			{
				return this.<Success>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x000376BC File Offset: 0x000358BC
		// (set) Token: 0x060011D9 RID: 4569 RVA: 0x000376D0 File Offset: 0x000358D0
		public bool CloseConnection
		{
			[CompilerGenerated]
			get
			{
				return this.<CloseConnection>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x000376E0 File Offset: 0x000358E0
		// (set) Token: 0x060011DB RID: 4571 RVA: 0x000376F4 File Offset: 0x000358F4
		public int StatusCode
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

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x00037708 File Offset: 0x00035908
		// (set) Token: 0x060011DD RID: 4573 RVA: 0x0003771C File Offset: 0x0003591C
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

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x00037730 File Offset: 0x00035930
		// (set) Token: 0x060011DF RID: 4575 RVA: 0x00037744 File Offset: 0x00035944
		public string[] Challenge
		{
			[CompilerGenerated]
			get
			{
				return this.<Challenge>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Challenge>k__BackingField = value;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x00037758 File Offset: 0x00035958
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x0003776C File Offset: 0x0003596C
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

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x00037780 File Offset: 0x00035980
		// (set) Token: 0x060011E3 RID: 4579 RVA: 0x00037794 File Offset: 0x00035994
		public Version ProxyVersion
		{
			[CompilerGenerated]
			get
			{
				return this.<ProxyVersion>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ProxyVersion>k__BackingField = value;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x000377A8 File Offset: 0x000359A8
		// (set) Token: 0x060011E5 RID: 4581 RVA: 0x000377BC File Offset: 0x000359BC
		public byte[] Data
		{
			[CompilerGenerated]
			get
			{
				return this.<Data>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x000377CC File Offset: 0x000359CC
		internal Task Initialize(Stream stream, CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x000377E8 File Offset: 0x000359E8
		private Task<ValueTuple<WebHeaderCollection, byte[], int>> ReadHeaders(Stream stream, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (060011E7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.ValueTuple`3<System.Net.WebHeaderCollection,System.Byte[],System.Int32>> System.Net.WebConnectionTunnel::ReadHeaders(System.IO.Stream,System.Threading.CancellationToken)

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

		// Token: 0x060011E8 RID: 4584 RVA: 0x000377F8 File Offset: 0x000359F8
		private void FlushContents(Stream stream, int contentLength)
		{
		}

		// Token: 0x04000DCC RID: 3532
		[CompilerGenerated]
		private readonly HttpWebRequest <Request>k__BackingField;

		// Token: 0x04000DCD RID: 3533
		[CompilerGenerated]
		private readonly global::System.Uri <ConnectUri>k__BackingField;

		// Token: 0x04000DCE RID: 3534
		private HttpWebRequest connectRequest;

		// Token: 0x04000DCF RID: 3535
		private WebConnectionTunnel.NtlmAuthState ntlmAuthState;

		// Token: 0x04000DD0 RID: 3536
		[CompilerGenerated]
		private bool <Success>k__BackingField;

		// Token: 0x04000DD1 RID: 3537
		[CompilerGenerated]
		private bool <CloseConnection>k__BackingField;

		// Token: 0x04000DD2 RID: 3538
		[CompilerGenerated]
		private int <StatusCode>k__BackingField;

		// Token: 0x04000DD3 RID: 3539
		[CompilerGenerated]
		private string <StatusDescription>k__BackingField;

		// Token: 0x04000DD4 RID: 3540
		[CompilerGenerated]
		private string[] <Challenge>k__BackingField;

		// Token: 0x04000DD5 RID: 3541
		[CompilerGenerated]
		private WebHeaderCollection <Headers>k__BackingField;

		// Token: 0x04000DD6 RID: 3542
		[CompilerGenerated]
		private Version <ProxyVersion>k__BackingField;

		// Token: 0x04000DD7 RID: 3543
		[CompilerGenerated]
		private byte[] <Data>k__BackingField;

		// Token: 0x02000287 RID: 647
		private enum NtlmAuthState
		{
			// Token: 0x04000DD9 RID: 3545
			None,
			// Token: 0x04000DDA RID: 3546
			Challenge,
			// Token: 0x04000DDB RID: 3547
			Response
		}

		// Token: 0x02000288 RID: 648
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <Initialize>d__42 : IAsyncStateMachine
		{
			// Token: 0x060011E9 RID: 4585 RVA: 0x00037808 File Offset: 0x00035A08
			private void MoveNext()
			{
				WebConnectionTunnel webConnectionTunnel = this.<>4__this;
				Task task = this.<>u__2.m_task;
			}

			// Token: 0x060011EA RID: 4586 RVA: 0x00037B44 File Offset: 0x00035D44
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000DDC RID: 3548
			public int <>1__state;

			// Token: 0x04000DDD RID: 3549
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000DDE RID: 3550
			public WebConnectionTunnel <>4__this;

			// Token: 0x04000DDF RID: 3551
			public Stream stream;

			// Token: 0x04000DE0 RID: 3552
			public CancellationToken cancellationToken;

			// Token: 0x04000DE1 RID: 3553
			private bool <have_auth>5__2;

			// Token: 0x04000DE2 RID: 3554
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04000DE3 RID: 3555
			private ConfiguredTaskAwaitable<ValueTuple<WebHeaderCollection, byte[], int>>.ConfiguredTaskAwaiter <>u__2;
		}

		// Token: 0x02000289 RID: 649
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <ReadHeaders>d__43 : IAsyncStateMachine
		{
			// Token: 0x060011EB RID: 4587 RVA: 0x00037B54 File Offset: 0x00035D54
			private void MoveNext()
			{
				WebConnectionTunnel webConnectionTunnel = this.<>4__this;
				int num = 200;
				this.<status>5__3 = num;
			}

			// Token: 0x060011EC RID: 4588 RVA: 0x00037C94 File Offset: 0x00035E94
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000DE4 RID: 3556
			public int <>1__state;

			// Token: 0x04000DE5 RID: 3557
			public AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, byte[], int>> <>t__builder;

			// Token: 0x04000DE6 RID: 3558
			public CancellationToken cancellationToken;

			// Token: 0x04000DE7 RID: 3559
			public Stream stream;

			// Token: 0x04000DE8 RID: 3560
			public WebConnectionTunnel <>4__this;

			// Token: 0x04000DE9 RID: 3561
			private byte[] <retBuffer>5__2;

			// Token: 0x04000DEA RID: 3562
			private int <status>5__3;

			// Token: 0x04000DEB RID: 3563
			private byte[] <buffer>5__4;

			// Token: 0x04000DEC RID: 3564
			private MemoryStream <ms>5__5;

			// Token: 0x04000DED RID: 3565
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
