using System;
using Cpp2IlInjected;

namespace System.Net.Sockets
{
	// Token: 0x02000308 RID: 776
	public struct UdpReceiveResult : IEquatable<UdpReceiveResult>
	{
		// Token: 0x0600143B RID: 5179 RVA: 0x0003DCC4 File Offset: 0x0003BEC4
		public UdpReceiveResult(byte[] buffer, IPEndPoint remoteEndPoint)
		{
			while (buffer != null)
			{
				if (remoteEndPoint != null)
				{
					this.m_buffer = buffer;
					this.m_remoteEndPoint = remoteEndPoint;
					return;
				}
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x00002050 File Offset: 0x00000250
		public byte[] Buffer
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x0003DCE8 File Offset: 0x0003BEE8
		public IPEndPoint RemoteEndPoint
		{
			get
			{
				return this.m_remoteEndPoint;
			}
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0003DCFC File Offset: 0x0003BEFC
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (0600143E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.Sockets.UdpReceiveResult::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IPEndPoint(var_0_09, ldfld:IPEndPoint(UdpReceiveResult::m_remoteEndPoint, ldloc:valuetype System.Net.Sockets.UdpReceiveResult&(this)))
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

		// Token: 0x0600143F RID: 5183 RVA: 0x0003DD14 File Offset: 0x0003BF14
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0003DD28 File Offset: 0x0003BF28
		public bool Equals(UdpReceiveResult other)
		{
			return object.Equals(this.m_remoteEndPoint, other);
		}

		// Token: 0x040010DF RID: 4319
		private byte[] m_buffer;

		// Token: 0x040010E0 RID: 4320
		private IPEndPoint m_remoteEndPoint;
	}
}
