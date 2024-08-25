using System;
using System.Collections;
using System.Globalization;
using Cpp2IlInjected;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000106 RID: 262
	public class X509Certificate2Collection : X509CertificateCollection
	{
		// Token: 0x060005D1 RID: 1489 RVA: 0x000168FC File Offset: 0x00014AFC
		public X509Certificate2Collection()
		{
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00016910 File Offset: 0x00014B10
		public X509Certificate2Collection(X509Certificate2Collection certificates)
		{
			this.AddRange(certificates);
		}

		// Token: 0x17000128 RID: 296
		public X509Certificate2 this[int index]
		{
			get
			{
				ArrayList list = this._list;
				if (this._list != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00016954 File Offset: 0x00014B54
		public int Add(X509Certificate2 certificate)
		{
			/*
An exception occurred when decompiling this method (060005D4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Security.Cryptography.X509Certificates.X509Certificate2Collection::Add(System.Security.Cryptography.X509Certificates.X509Certificate2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ArrayList(var_0_09, ldfld:ArrayList(CollectionBase::_list, ldloc:X509Certificate2Collection[exp:CollectionBase](this)))
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

		// Token: 0x060005D5 RID: 1493 RVA: 0x0001696C File Offset: 0x00014B6C
		[MonoTODO("Method isn't transactional (like documented)")]
		public void AddRange(X509Certificate2Collection certificates)
		{
			while (certificates == null)
			{
			}
			ArrayList list = this._list;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00016984 File Offset: 0x00014B84
		public bool Contains(X509Certificate2 certificate)
		{
			if (certificate != null)
			{
				ArrayList list = this._list;
				long num = 0L;
				if (list != null)
				{
				}
				if (num == 0L)
				{
					throw new InvalidCastException();
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x000169BC File Offset: 0x00014BBC
		private string GetKeyIdentifier(X509Certificate2 x)
		{
			if (x.Extensions["2.5.29.14"] != null)
			{
			}
			PublicKey publicKey = x.PublicKey;
			string text;
			return text;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x000169E8 File Offset: 0x00014BE8
		[MonoTODO("Does not support X509FindType.FindByTemplateName, FindByApplicationPolicy and FindByCertificatePolicy")]
		public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly)
		{
			if (findValue == null)
			{
				throw new ArrayTypeMismatchException();
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			ArrayList list = this._list;
			if (list != null)
			{
			}
			int num;
			X509ExtensionCollection x509ExtensionCollection;
			if (num != 0 && x509ExtensionCollection["2.5.29.15"] != null)
			{
				X509ExtensionCollection x509ExtensionCollection2;
				int count = x509ExtensionCollection2.Count;
				int num2;
				while (num2 != 0)
				{
				}
				X509Extension x509Extension;
				while (x509Extension == null)
				{
				}
			}
			long num3 = 0L;
			if (list != null)
			{
			}
			if (num3 == 0L)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00002050 File Offset: 0x00000250
		public new X509Certificate2Enumerator GetEnumerator()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00016AC4 File Offset: 0x00014CC4
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate2Collection()
		{
			string newLine = Environment.NewLine;
			if (newLine == null || newLine != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x040004FD RID: 1277
		private static string[] newline_split;
	}
}
