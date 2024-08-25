using System;
using System.Net.Sockets;

namespace System.Net
{
	// Token: 0x0200018D RID: 397
	public class DnsEndPoint : EndPoint
	{
		// Token: 0x06000A39 RID: 2617 RVA: 0x00022A3C File Offset: 0x00020C3C
		public DnsEndPoint(string host, int port)
		{
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00022A4C File Offset: 0x00020C4C
		public DnsEndPoint(string host, int port, global::System.Net.Sockets.AddressFamily addressFamily)
		{
			if (host != null)
			{
				bool flag = string.IsNullOrEmpty(host);
				this.m_Host = host;
				this.m_Port = port;
				return;
			}
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00022A8C File Offset: 0x00020C8C
		public override bool Equals(object comparand)
		{
			if (comparand != null)
			{
				global::System.Net.Sockets.AddressFamily family = this.m_Family;
				int port = this.m_Port;
				string host = this.m_Host;
				bool flag;
				return flag;
			}
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00022AB8 File Offset: 0x00020CB8
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06000A3C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.DnsEndPoint::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
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

		// Token: 0x06000A3D RID: 2621 RVA: 0x00022ACC File Offset: 0x00020CCC
		public override string ToString()
		{
			global::System.Net.Sockets.AddressFamily family = this.m_Family;
			string text;
			if ((text == null || text != null) && ("/" == null || "/" != null))
			{
				string host = this.m_Host;
				string text2;
				if ((host == null || host != null) && (":" == null || ":" != null) && (text2 == null || text2 != null))
				{
					string text3;
					return text3;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x00022B24 File Offset: 0x00020D24
		public string Host
		{
			get
			{
				return this.m_Host;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00022B38 File Offset: 0x00020D38
		public override global::System.Net.Sockets.AddressFamily AddressFamily
		{
			get
			{
				return this.m_Family;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x00022B4C File Offset: 0x00020D4C
		public int Port
		{
			get
			{
				return this.m_Port;
			}
		}

		// Token: 0x040007C9 RID: 1993
		private string m_Host;

		// Token: 0x040007CA RID: 1994
		private int m_Port;

		// Token: 0x040007CB RID: 1995
		private global::System.Net.Sockets.AddressFamily m_Family;
	}
}
