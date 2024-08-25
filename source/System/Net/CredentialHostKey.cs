using System;
using System.Globalization;

namespace System.Net
{
	// Token: 0x0200018B RID: 395
	internal class CredentialHostKey
	{
		// Token: 0x06000A2E RID: 2606 RVA: 0x000226E8 File Offset: 0x000208E8
		internal CredentialHostKey(string host, int port, string authenticationType)
		{
			this.Port = port;
			this.Host = host;
			this.AuthenticationType = authenticationType;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00022710 File Offset: 0x00020910
		internal bool Match(string host, int port, string authenticationType)
		{
			/*
An exception occurred when decompiling this method (06000A2F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.CredentialHostKey::Match(System.String,System.Int32,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0028:
	stloc:int32(var_2_2E, ldfld:int32(CredentialHostKey::Port, ldloc:CredentialHostKey(this)))
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

		// Token: 0x06000A30 RID: 2608 RVA: 0x0002274C File Offset: 0x0002094C
		public override int GetHashCode()
		{
			if (this.m_ComputedHashCode)
			{
				return this.m_HashCode;
			}
			string text = this.AuthenticationType.ToUpperInvariant();
			string text2 = this.Host.ToUpperInvariant();
			int num = 1;
			int num2;
			this.m_HashCode = num2;
			this.m_ComputedHashCode = num != 0;
			return num2;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00022794 File Offset: 0x00020994
		public override bool Equals(object comparand)
		{
			/*
An exception occurred when decompiling this method (06000A31)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.CredentialHostKey::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	stloc:int32(var_5_20, ldfld:int32(CredentialHostKey::Port, ldloc:CredentialHostKey(this)))
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

		// Token: 0x06000A32 RID: 2610 RVA: 0x000227C4 File Offset: 0x000209C4
		public override string ToString()
		{
			if ("[" == null || "[" != null)
			{
				string host = this.Host;
				int stringLength = host._stringLength;
				NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
				string text;
				if ((text == null || text != null) && ("]:" == null || "]:" != null))
				{
					string host2 = this.Host;
					if ((host2 == null || host2 != null) && (":" == null || ":" != null))
					{
						NumberFormatInfo invariantInfo2 = NumberFormatInfo.InvariantInfo;
						string text2;
						if (text2 != null)
						{
						}
						if (":" == null || ":" != null)
						{
							string text3 = ValidationHelper.ToString(this.AuthenticationType);
							if (text3 == null || text3 != null)
							{
								string text4;
								return text4;
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x040007BF RID: 1983
		internal string Host;

		// Token: 0x040007C0 RID: 1984
		internal string AuthenticationType;

		// Token: 0x040007C1 RID: 1985
		internal int Port;

		// Token: 0x040007C2 RID: 1986
		private int m_HashCode;

		// Token: 0x040007C3 RID: 1987
		private bool m_ComputedHashCode;
	}
}
