using System;

namespace Mono.Security.X509.Extensions
{
	// Token: 0x02000034 RID: 52
	public class AuthorityKeyIdentifierExtension : X509Extension
	{
		// Token: 0x06000198 RID: 408 RVA: 0x00007A9C File Offset: 0x00005C9C
		public AuthorityKeyIdentifierExtension(X509Extension extension)
			: base(extension)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00007AB0 File Offset: 0x00005CB0
		protected override void Decode()
		{
			byte[] value = this.extnValue.Value;
			ASN1 asn;
			byte nTag = asn.m_nTag;
			byte[] value2 = asn.Value;
			this.aki = value2;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00007AE4 File Offset: 0x00005CE4
		protected override void Encode()
		{
			while (this.aki == null)
			{
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00007AFC File Offset: 0x00005CFC
		public override string Name
		{
			get
			{
				return "Authority Key Identifier";
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00007B10 File Offset: 0x00005D10
		public byte[] Identifier
		{
			get
			{
				object obj;
				if (this.aki == null || obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00007B30 File Offset: 0x00005D30
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (0600019D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Mono.Security.X509.Extensions.AuthorityKeyIdentifierExtension::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0018:
	stloc:CultureInfo(var_4_1F, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:uint8[](var_8_27, ldfld:uint8[](AuthorityKeyIdentifierExtension::aki, ldloc:AuthorityKeyIdentifierExtension(this)))
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

		// Token: 0x040000BD RID: 189
		private byte[] aki;
	}
}
