using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200010D RID: 269
	internal class X509CertificateImplCollection : IDisposable
	{
		// Token: 0x06000620 RID: 1568 RVA: 0x00017238 File Offset: 0x00015438
		public X509CertificateImplCollection()
		{
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00002050 File Offset: 0x00000250
		private X509CertificateImplCollection(X509CertificateImplCollection other)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x0001724C File Offset: 0x0001544C
		public int Count
		{
			get
			{
				return this.list._size;
			}
		}

		// Token: 0x1700014B RID: 331
		public X509CertificateImpl this[int index]
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000623)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.X509Certificates.X509CertificateImpl System.Security.Cryptography.X509Certificates.X509CertificateImplCollection::get_Item(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class [mscorlib]System.Security.Cryptography.X509Certificates.X509CertificateImpl>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class [mscorlib]System.Security.Cryptography.X509Certificates.X509CertificateImpl>(X509CertificateImplCollection::list, ldloc:X509CertificateImplCollection(this)))
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

		// Token: 0x06000624 RID: 1572 RVA: 0x00002050 File Offset: 0x00000250
		public void Add(X509CertificateImpl impl, bool takeOwnership)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00002050 File Offset: 0x00000250
		public X509CertificateImplCollection Clone()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00017278 File Offset: 0x00015478
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual void Dispose(bool disposing)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0001728C File Offset: 0x0001548C
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x04000506 RID: 1286
		private List<X509CertificateImpl> list;
	}
}
