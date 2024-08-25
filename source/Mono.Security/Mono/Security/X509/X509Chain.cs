using System;

namespace Mono.Security.X509
{
	// Token: 0x02000019 RID: 25
	public class X509Chain
	{
		// Token: 0x0600011B RID: 283 RVA: 0x00006220 File Offset: 0x00004420
		public X509Chain()
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00006234 File Offset: 0x00004434
		public X509Chain(X509CertificateCollection chain)
		{
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00006244 File Offset: 0x00004444
		public X509CertificateCollection Chain
		{
			get
			{
				return this._chain;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00006258 File Offset: 0x00004458
		public X509Certificate Root
		{
			get
			{
				return this._root;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000626C File Offset: 0x0000446C
		public X509ChainStatusFlags Status
		{
			get
			{
				return this._status;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00006280 File Offset: 0x00004480
		// (set) Token: 0x06000121 RID: 289 RVA: 0x000062A4 File Offset: 0x000044A4
		public X509CertificateCollection TrustAnchors
		{
			get
			{
				while (this.roots != null)
				{
				}
				X509CertificateCollection trustedRootCertificates = X509StoreManager.TrustedRootCertificates;
				return this.roots;
			}
			set
			{
				this.roots = value;
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000062B8 File Offset: 0x000044B8
		public void LoadCertificate(X509Certificate x509)
		{
			int num = this.certs.Add(x509);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000062D4 File Offset: 0x000044D4
		public void LoadCertificates(X509CertificateCollection collection)
		{
			this.certs.AddRange(collection);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000062F0 File Offset: 0x000044F0
		public X509Certificate FindByIssuerName(string issuerName)
		{
			X509CertificateCollection.X509CertificateEnumerator enumerator = this.certs.GetEnumerator();
			bool flag = enumerator.MoveNext();
			X509Certificate x509Certificate = enumerator.Current;
			long num = 0L;
			if (enumerator != null)
			{
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000633C File Offset: 0x0000453C
		public bool Build(X509Certificate leaf)
		{
			X509CertificateCollection chain = this._chain;
			if (chain != null)
			{
				int count = chain.Count;
				X509CertificateCollection chain2 = this._chain;
				long num = 0L;
				X509Certificate x509Certificate = chain2[(int)num];
				bool flag = this.IsParent(leaf, x509Certificate);
				int num2 = 1;
				X509CertificateCollection chain3 = this._chain;
				X509Certificate x509Certificate2 = this._chain[num2];
				X509Certificate x509Certificate3;
				return this.IsParent(x509Certificate3, x509Certificate2);
			}
			if (leaf != null)
			{
				bool isSelfSigned = leaf.IsSelfSigned;
				int num3 = this._chain.Add(leaf);
				X509Certificate x509Certificate4 = this.FindCertificateParent(leaf);
				if (x509Certificate4 != null)
				{
					return x509Certificate4.IsSelfSigned;
				}
			}
			X509Certificate x509Certificate5;
			this._root = x509Certificate5;
			X509CertificateCollection chain4 = this._chain;
			if (chain4 == null || this._status != X509ChainStatusFlags.NoError)
			{
				X509ChainStatusFlags status = this._status;
			}
			X509CertificateCollection.X509CertificateEnumerator enumerator = chain4.GetEnumerator();
			bool flag2 = enumerator.MoveNext();
			X509Certificate x509Certificate6 = enumerator.Current;
			return this.IsValid(x509Certificate6);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000647C File Offset: 0x0000467C
		public void Reset()
		{
			this.certs.Clear();
			X509CertificateCollection chain = this._chain;
			if (chain != null)
			{
				chain.Clear();
				return;
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000064A8 File Offset: 0x000046A8
		private bool IsValid(X509Certificate cert)
		{
			bool isCurrent = cert.IsCurrent;
			if (!true)
			{
			}
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000064C8 File Offset: 0x000046C8
		private X509Certificate FindCertificateParent(X509Certificate child)
		{
			X509CertificateCollection.X509CertificateEnumerator enumerator = this.certs.GetEnumerator();
			bool flag = enumerator.MoveNext();
			X509Certificate x509Certificate = enumerator.Current;
			bool flag2 = this.IsParent(child, x509Certificate);
			long num = 0L;
			if (enumerator != null)
			{
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000651C File Offset: 0x0000471C
		private X509Certificate FindCertificateRoot(X509Certificate potentialRoot)
		{
			if (potentialRoot != null)
			{
				int num = this.TrustAnchors.IndexOf(potentialRoot);
				X509CertificateCollection.X509CertificateEnumerator enumerator = this.TrustAnchors.GetEnumerator();
				bool flag = enumerator.MoveNext();
				X509Certificate x509Certificate = enumerator.Current;
				bool flag2 = this.IsParent(potentialRoot, x509Certificate);
				long num2 = 0L;
				int num3 = 7;
				if (enumerator != null)
				{
				}
				if (num2 == 0L && num3 == 0)
				{
					bool isSelfSigned = potentialRoot.IsSelfSigned;
					int num4 = 32;
					this._status = (X509ChainStatusFlags)num4;
					throw new OutOfMemoryException();
				}
			}
			else
			{
				int num5 = 1;
				this._status = (X509ChainStatusFlags)num5;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000065B0 File Offset: 0x000047B0
		private bool IsTrusted(X509Certificate potentialTrusted)
		{
			/*
An exception occurred when decompiling this method (0600012A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Security.X509.X509Chain::IsTrusted(Mono.Security.X509.X509Certificate)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0C, call:int32(X509CertificateCollection::IndexOf, callgetter:X509CertificateCollection(X509Chain::get_TrustAnchors, ldloc:X509Chain(this)), ldloc:X509Certificate(potentialTrusted)))
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

		// Token: 0x0600012B RID: 299 RVA: 0x000065CC File Offset: 0x000047CC
		private bool IsParent(X509Certificate child, X509Certificate parent)
		{
			int version = parent.version;
			int num = this.TrustAnchors.IndexOf(parent);
			if (parent.extensions["2.5.29.19"] != null)
			{
			}
			this._status = X509ChainStatusFlags.InvalidBasicConstraints;
			return true;
		}

		// Token: 0x0400008E RID: 142
		private X509CertificateCollection roots;

		// Token: 0x0400008F RID: 143
		private X509CertificateCollection certs;

		// Token: 0x04000090 RID: 144
		private X509Certificate _root;

		// Token: 0x04000091 RID: 145
		private X509CertificateCollection _chain;

		// Token: 0x04000092 RID: 146
		private X509ChainStatusFlags _status;
	}
}
