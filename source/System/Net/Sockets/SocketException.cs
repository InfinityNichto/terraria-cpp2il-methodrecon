using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Net.Sockets
{
	// Token: 0x020002F6 RID: 758
	[Serializable]
	public class SocketException : global::System.ComponentModel.Win32Exception
	{
		// Token: 0x06001400 RID: 5120 RVA: 0x00002050 File Offset: 0x00000250
		private static int WSAGetLastError_icall()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x0003D3A8 File Offset: 0x0003B5A8
		public SocketException()
		{
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0003D3B8 File Offset: 0x0003B5B8
		internal SocketException(int error, string message)
			: base(error, message)
		{
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x0003D3D0 File Offset: 0x0003B5D0
		public SocketException(int errorCode)
			: base(errorCode)
		{
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0003D3E4 File Offset: 0x0003B5E4
		internal SocketException(SocketError socketError)
		{
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x0003D3F4 File Offset: 0x0003B5F4
		protected SocketException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: base(serializationInfo, streamingContext)
		{
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x0003D40C File Offset: 0x0003B60C
		public override int ErrorCode
		{
			get
			{
				return this.nativeErrorCode;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x0003D420 File Offset: 0x0003B620
		public override string Message
		{
			get
			{
				EndPoint endPoint = this.m_EndPoint;
				string message = base.Message;
				if (endPoint != null)
				{
					EndPoint endPoint2 = this.m_EndPoint;
					string text;
					return text;
				}
				return message;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x0003D448 File Offset: 0x0003B648
		public SocketError SocketErrorCode
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001408)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.Sockets.SocketError System.Net.Sockets.SocketException::get_SocketErrorCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Win32Exception::nativeErrorCode, ldloc:SocketException[exp:Win32Exception](this)))
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

		// Token: 0x04000FE1 RID: 4065
		[NonSerialized]
		private EndPoint m_EndPoint;
	}
}
