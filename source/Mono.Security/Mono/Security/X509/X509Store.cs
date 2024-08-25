using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Mono.Security.X509
{
	// Token: 0x0200001D RID: 29
	public class X509Store
	{
		// Token: 0x0600014D RID: 333 RVA: 0x00006BD4 File Offset: 0x00004DD4
		internal X509Store(string path, bool crl, bool newFormat)
		{
			this._storePath = path;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00006BF0 File Offset: 0x00004DF0
		public X509CertificateCollection Certificates
		{
			get
			{
				X509CertificateCollection x509CertificateCollection;
				if (this._certificates == null)
				{
					string storePath = this._storePath;
					x509CertificateCollection = this.BuildCertificatesCollection(storePath);
					this._certificates = x509CertificateCollection;
				}
				return x509CertificateCollection;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00006C1C File Offset: 0x00004E1C
		public ArrayList Crls
		{
			get
			{
				while (!this._crl)
				{
				}
				ArrayList arrayList;
				if (this._crls == null)
				{
					string storePath = this._storePath;
					arrayList = this.BuildCrlsCollection(storePath);
					this._crls = arrayList;
				}
				return arrayList;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00006C50 File Offset: 0x00004E50
		public string Name
		{
			get
			{
				int num = 1;
				string text;
				if (this._name == null)
				{
					string storePath = this._storePath;
					if (num == 0)
					{
					}
					string storePath2 = this._storePath;
					this._name = text;
				}
				return text;
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00006C84 File Offset: 0x00004E84
		public void Clear()
		{
			X509CertificateCollection certificates = this._certificates;
			if (certificates != null)
			{
				certificates.Clear();
			}
			if (this._crls != null)
			{
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00006CAC File Offset: 0x00004EAC
		private void ClearCertificates()
		{
			X509CertificateCollection certificates = this._certificates;
			if (certificates != null)
			{
				certificates.Clear();
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00006CCC File Offset: 0x00004ECC
		private void ClearCrls()
		{
			if (this._crls != null)
			{
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00006CE4 File Offset: 0x00004EE4
		public void Import(X509Certificate certificate)
		{
			string storePath = this._storePath;
			if (this._newFormat)
			{
				this.ImportNewFormat(certificate);
				return;
			}
			string text2;
			string text = Path.Combine(this._storePath, text2);
			bool flag = File.Exists(text);
			string text4;
			string text3 = Path.Combine(this._storePath, text4);
			X509Certificate x509Certificate = this.LoadCertificate(text);
			string text5;
			string text6;
			bool flag2 = text5 != text6;
			FileStream fileStream = File.Create(text3);
			byte[] encodedcert = certificate.m_encodedcert;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00006DD4 File Offset: 0x00004FD4
		public void Import(X509Crl crl)
		{
			string storePath = this._storePath;
			if (!this._newFormat)
			{
				string storePath2 = this._storePath;
				string uniqueName = this.GetUniqueName(crl);
				string text = Path.Combine(storePath2, uniqueName);
				bool flag = File.Exists(text);
				FileStream fileStream = File.Create(text);
				byte[] rawData = crl.RawData;
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00006E68 File Offset: 0x00005068
		public void Remove(X509Certificate certificate)
		{
			if (this._newFormat)
			{
				this.RemoveNewFormat(certificate);
				return;
			}
			string text;
			bool flag = File.Exists(Path.Combine(this._storePath, text));
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00006EC8 File Offset: 0x000050C8
		public void Remove(X509Crl crl)
		{
			while (this._newFormat)
			{
			}
			string storePath = this._storePath;
			string uniqueName = this.GetUniqueName(crl);
			string text = Path.Combine(storePath, uniqueName);
			bool flag = File.Exists(text);
			File.Delete(text);
			if (this._crls != null)
			{
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00006F0C File Offset: 0x0000510C
		private void ImportNewFormat(X509Certificate certificate)
		{
			string text2;
			string text = Path.Combine(this._storePath, text2);
			bool flag = File.Exists(text);
			FileStream fileStream = File.Create(text);
			long num = 0L;
			int num2 = 3;
			if (fileStream != null)
			{
				return;
			}
			if (num != 0L)
			{
				throw new OutOfMemoryException();
			}
			if (num2 == 0)
			{
				X509CertificateCollection certificates = this._certificates;
				if (certificates != null)
				{
					certificates.Clear();
				}
				return;
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00006FB4 File Offset: 0x000051B4
		private void RemoveNewFormat(X509Certificate certificate)
		{
			string text2;
			string text = Path.Combine(this._storePath, text2);
			bool flag = File.Exists(text);
			File.Delete(text);
			X509CertificateCollection certificates = this._certificates;
			if (certificates != null)
			{
				certificates.Clear();
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00007018 File Offset: 0x00005218
		private string GetUniqueNameWithSerial(X509Certificate certificate)
		{
			string text;
			return text;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00007028 File Offset: 0x00005228
		private string GetUniqueName(X509Certificate certificate, [Optional] byte[] serial)
		{
			X509ExtensionCollection extensions = certificate.extensions;
			byte[] array;
			if (array != null)
			{
			}
			byte[] hash = certificate.Hash;
			string text;
			return text;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00007048 File Offset: 0x00005248
		private string GetUniqueName(X509Crl crl)
		{
			X509ExtensionCollection extensions = crl.extensions;
			byte[] array;
			if (array != null)
			{
			}
			byte[] hash = crl.Hash;
			string text;
			return text;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00007068 File Offset: 0x00005268
		private byte[] GetUniqueName(X509ExtensionCollection extensions, [Optional] byte[] serial)
		{
			/*
An exception occurred when decompiling this method (0600015D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Mono.Security.X509.X509Store::GetUniqueName(Mono.Security.X509.X509ExtensionCollection,System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, logicnot:bool(ldloc:uint8[][exp:bool](serial)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x0600015E RID: 350 RVA: 0x00007084 File Offset: 0x00005284
		private string GetUniqueName(string method, byte[] name, string fileExtension)
		{
			/*
An exception occurred when decompiling this method (0600015E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Mono.Security.X509.X509Store::GetUniqueName(System.String,System.Byte[],System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0007:
	stloc:CultureInfo(var_4_0E, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

		// Token: 0x0600015F RID: 351 RVA: 0x000070A0 File Offset: 0x000052A0
		private byte[] Load(string filename)
		{
			FileStream fileStream = File.OpenRead(filename);
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
		private X509Certificate LoadCertificate(string filename)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		private X509Crl LoadCrl(string filename)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000070DC File Offset: 0x000052DC
		private bool CheckStore(string path, bool throwException)
		{
			bool flag = Directory.Exists(path);
			DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
			return Directory.Exists(path);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00007118 File Offset: 0x00005318
		private X509CertificateCollection BuildCertificatesCollection(string storeName)
		{
			int num = 1;
			string storePath = this._storePath;
			if (num == 0)
			{
			}
			string text = Path.Combine(storePath, storeName);
			bool newFormat = this._newFormat;
			string[] array;
			if (array == null || newFormat)
			{
				return;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00007150 File Offset: 0x00005350
		private ArrayList BuildCrlsCollection(string storeName)
		{
			int num = 1;
			string storePath = this._storePath;
			if (num == 0)
			{
			}
			string text = Path.Combine(storePath, storeName);
			if (Directory.GetFiles(text, "*.crl") == null || "*.crl" != null)
			{
				return;
			}
		}

		// Token: 0x0400009F RID: 159
		private string _storePath;

		// Token: 0x040000A0 RID: 160
		private X509CertificateCollection _certificates;

		// Token: 0x040000A1 RID: 161
		private ArrayList _crls;

		// Token: 0x040000A2 RID: 162
		private bool _crl;

		// Token: 0x040000A3 RID: 163
		private bool _newFormat;

		// Token: 0x040000A4 RID: 164
		private string _name;
	}
}
