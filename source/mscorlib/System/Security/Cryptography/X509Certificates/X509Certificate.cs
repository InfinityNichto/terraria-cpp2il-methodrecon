using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using Cpp2IlInjected;
using Internal.Cryptography;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000322 RID: 802
	[Serializable]
	public class X509Certificate : IDisposable, IDeserializationCallback, ISerializable
	{
		// Token: 0x06001B0A RID: 6922 RVA: 0x0003A428 File Offset: 0x00038628
		public virtual void Reset()
		{
			X509CertificateImpl x509CertificateImpl = this.impl;
			if (x509CertificateImpl != null)
			{
				x509CertificateImpl.Dispose();
			}
			if (!true)
			{
			}
			this.lazyNotBefore = 1;
			this.lazyNotAfter = 1;
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x0003A458 File Offset: 0x00038658
		public X509Certificate()
		{
			if (!true)
			{
			}
			this.lazyNotBefore = 1;
			this.lazyNotAfter = 1;
			base..ctor();
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x0003A47C File Offset: 0x0003867C
		public X509Certificate(byte[] data)
		{
			if (!true)
			{
			}
			this.lazyNotBefore = 1;
			this.lazyNotAfter = 1;
			base..ctor();
			if (data != null && true)
			{
				X509CertificateImpl x509CertificateImpl = X509Helper.Import(data);
				this.impl = x509CertificateImpl;
			}
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x0003A4B4 File Offset: 0x000386B4
		internal X509Certificate(X509CertificateImpl impl)
		{
			if (!true)
			{
			}
			this.lazyNotBefore = 1;
			this.lazyNotAfter = 1;
			base..ctor();
			if (impl != null)
			{
				return;
			}
			long num = 0L;
			this.impl = num;
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x0003A4E8 File Offset: 0x000386E8
		public X509Certificate(string fileName)
		{
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x0003A4F8 File Offset: 0x000386F8
		public X509Certificate(string fileName, string password, X509KeyStorageFlags keyStorageFlags)
		{
			int num = 1;
			if (num == 0)
			{
			}
			this.lazyNotBefore = num;
			this.lazyNotAfter = num;
			base..ctor();
			if (fileName != null)
			{
				X509Certificate.ValidateKeyStorageFlags(keyStorageFlags);
				byte[] array = File.ReadAllBytes(fileName);
				X509CertificateImpl x509CertificateImpl;
				this.impl = x509CertificateImpl;
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x0003A558 File Offset: 0x00038758
		public X509Certificate(X509Certificate cert)
		{
			do
			{
				if (!true)
				{
				}
				this.lazyNotBefore = 1;
				this.lazyNotAfter = 1;
				base..ctor();
			}
			while (cert == null);
			X509CertificateImpl x509CertificateImpl = X509Helper.InitFromCertificate(cert);
			this.impl = x509CertificateImpl;
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x0000207A File Offset: 0x0000027A
		public X509Certificate(SerializationInfo info, StreamingContext context)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x0000207A File Offset: 0x0000027A
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0000207A File Offset: 0x0000027A
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x0003A590 File Offset: 0x00038790
		public string Issuer
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001B14)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Security.Cryptography.X509Certificates.X509Certificate::get_Issuer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:X509CertificateImpl(var_0_19, ldfld:X509CertificateImpl(X509Certificate::impl, ldloc:X509Certificate(this)))
	stfld:string(X509Certificate::lazyIssuer, ldloc:X509Certificate(this), ldloc:X509CertificateImpl[exp:string](var_0_19))
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

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06001B15 RID: 6933 RVA: 0x0003A5C0 File Offset: 0x000387C0
		public string Subject
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001B15)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Security.Cryptography.X509Certificates.X509Certificate::get_Subject()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:X509CertificateImpl(var_0_19, ldfld:X509CertificateImpl(X509Certificate::impl, ldloc:X509Certificate(this)))
	stfld:string(X509Certificate::lazySubject, ldloc:X509Certificate(this), ldloc:X509CertificateImpl[exp:string](var_0_19))
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

		// Token: 0x06001B16 RID: 6934 RVA: 0x0003A5F0 File Offset: 0x000387F0
		public void Dispose()
		{
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x0003A600 File Offset: 0x00038800
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x0003A610 File Offset: 0x00038810
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0003A624 File Offset: 0x00038824
		public virtual bool Equals(X509Certificate other)
		{
			/*
An exception occurred when decompiling this method (06001B19)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Security.Cryptography.X509Certificates.X509Certificate::Equals(System.Security.Cryptography.X509Certificates.X509Certificate)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0033:
	stloc:X509CertificateImpl(var_6_39, ldfld:X509CertificateImpl(X509Certificate::impl, ldloc:X509Certificate(other)))
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

		// Token: 0x06001B1A RID: 6938 RVA: 0x0003A66C File Offset: 0x0003886C
		public virtual byte[] GetCertHash()
		{
			X509Helper.ThrowIfContextInvalid(this.impl);
			return this.GetRawCertHash().CloneByteArray();
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x0003A690 File Offset: 0x00038890
		public virtual string GetCertHashString()
		{
			X509Helper.ThrowIfContextInvalid(this.impl);
			return this.GetRawCertHash().ToHexStringUpper();
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0003A6B4 File Offset: 0x000388B4
		private byte[] GetRawCertHash()
		{
			/*
An exception occurred when decompiling this method (06001B1C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.X509Certificates.X509Certificate::GetRawCertHash()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:X509CertificateImpl(var_0_0E, ldfld:X509CertificateImpl(X509Certificate::impl, ldloc:X509Certificate(this)))
	stfld:uint8[](X509Certificate::lazyCertHash, ldloc:X509Certificate(this), ldloc:X509CertificateImpl[exp:uint8[]](var_0_0E))
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

		// Token: 0x06001B1D RID: 6941 RVA: 0x0003A6D8 File Offset: 0x000388D8
		public virtual byte[] GetRawCertData()
		{
			X509Helper.ThrowIfContextInvalid(this.impl);
			X509CertificateImpl x509CertificateImpl = this.impl;
			byte[] array;
			return array;
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x0003A6F8 File Offset: 0x000388F8
		public override int GetHashCode()
		{
			if (this.impl != null)
			{
				byte[] rawCertHash = this.GetRawCertHash();
				return;
			}
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0003A71C File Offset: 0x0003891C
		public virtual string GetKeyAlgorithm()
		{
			/*
An exception occurred when decompiling this method (06001B1F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Security.Cryptography.X509Certificates.X509Certificate::GetKeyAlgorithm()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:X509CertificateImpl(var_0_19, ldfld:X509CertificateImpl(X509Certificate::impl, ldloc:X509Certificate(this)))
	stfld:string(X509Certificate::lazyKeyAlgorithm, ldloc:X509Certificate(this), ldloc:X509CertificateImpl[exp:string](var_0_19))
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

		// Token: 0x06001B20 RID: 6944 RVA: 0x0003A74C File Offset: 0x0003894C
		public virtual byte[] GetKeyAlgorithmParameters()
		{
			X509Helper.ThrowIfContextInvalid(this.impl);
			if (this.lazyKeyAlgorithmParameters == null)
			{
				X509CertificateImpl x509CertificateImpl = this.impl;
				this.lazyKeyAlgorithmParameters = x509CertificateImpl;
			}
			byte[] array;
			return array;
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0003A77C File Offset: 0x0003897C
		public virtual byte[] GetPublicKey()
		{
			X509Helper.ThrowIfContextInvalid(this.impl);
			if (this.lazyPublicKey == null)
			{
				X509CertificateImpl x509CertificateImpl = this.impl;
				this.lazyPublicKey = x509CertificateImpl;
			}
			byte[] array;
			return array;
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0003A7AC File Offset: 0x000389AC
		public virtual byte[] GetSerialNumber()
		{
			X509Helper.ThrowIfContextInvalid(this.impl);
			return this.GetRawSerialNumber().CloneByteArray();
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x0003A7D0 File Offset: 0x000389D0
		public virtual string GetSerialNumberString()
		{
			X509Helper.ThrowIfContextInvalid(this.impl);
			return this.GetRawSerialNumber().ToHexStringUpper();
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0003A7F4 File Offset: 0x000389F4
		private byte[] GetRawSerialNumber()
		{
			/*
An exception occurred when decompiling this method (06001B24)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.X509Certificates.X509Certificate::GetRawSerialNumber()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:X509CertificateImpl(var_0_0E, ldfld:X509CertificateImpl(X509Certificate::impl, ldloc:X509Certificate(this)))
	stfld:uint8[](X509Certificate::lazySerialNumber, ldloc:X509Certificate(this), ldloc:X509CertificateImpl[exp:uint8[]](var_0_0E))
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

		// Token: 0x06001B25 RID: 6949 RVA: 0x0000207A File Offset: 0x0000027A
		public override string ToString()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x0003A818 File Offset: 0x00038A18
		public virtual string ToString(bool fVerbose)
		{
			if (this.impl != null)
			{
				string subject = this.Subject;
				string issuer = this.Issuer;
				string text = X509Certificate.FormatDate(this.GetNotBefore());
				string text2 = X509Certificate.FormatDate(this.GetNotAfter());
				char[] array = this.GetRawCertHash().ToHexArrayUpper();
			}
			return base.ToString();
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x0003A86C File Offset: 0x00038A6C
		internal DateTime GetNotAfter()
		{
			/*
An exception occurred when decompiling this method (06001B27)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.Security.Cryptography.X509Certificates.X509Certificate::GetNotAfter()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0015:
	stloc:X509CertificateImpl(var_2_1B, ldfld:X509CertificateImpl(X509Certificate::impl, ldloc:X509Certificate(this)))
	stfld:DateTime(X509Certificate::lazyNotAfter, ldloc:X509Certificate(this), ldloc:X509CertificateImpl[exp:DateTime](var_2_1B))
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

		// Token: 0x06001B28 RID: 6952 RVA: 0x0003A89C File Offset: 0x00038A9C
		internal DateTime GetNotBefore()
		{
			/*
An exception occurred when decompiling this method (06001B28)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.Security.Cryptography.X509Certificates.X509Certificate::GetNotBefore()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0015:
	stloc:X509CertificateImpl(var_2_1B, ldfld:X509CertificateImpl(X509Certificate::impl, ldloc:X509Certificate(this)))
	stfld:DateTime(X509Certificate::lazyNotBefore, ldloc:X509Certificate(this), ldloc:X509CertificateImpl[exp:DateTime](var_2_1B))
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

		// Token: 0x06001B29 RID: 6953 RVA: 0x0003A8CC File Offset: 0x00038ACC
		protected static string FormatDate(DateTime date)
		{
			if (!true)
			{
			}
			string territory = CultureInfo.CurrentCulture.territory;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return text;
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x0003A8F8 File Offset: 0x00038AF8
		internal static void ValidateKeyStorageFlags(X509KeyStorageFlags keyStorageFlags)
		{
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x0003A908 File Offset: 0x00038B08
		internal void ImportHandle(X509CertificateImpl impl)
		{
			this.impl = impl;
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06001B2C RID: 6956 RVA: 0x0003A91C File Offset: 0x00038B1C
		internal X509CertificateImpl Impl
		{
			get
			{
				return this.impl;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x0003A930 File Offset: 0x00038B30
		internal bool IsValid
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001B2D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Security.Cryptography.X509Certificates.X509Certificate::get_IsValid()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:X509CertificateImpl[exp:bool](X509Certificate::impl, ldloc:X509Certificate(this))))
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
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x0003A944 File Offset: 0x00038B44
		internal void ThrowIfInvalid()
		{
			X509Helper.ThrowIfContextInvalid(this.impl);
		}

		// Token: 0x04000DD5 RID: 3541
		private X509CertificateImpl impl;

		// Token: 0x04000DD6 RID: 3542
		private byte[] lazyCertHash;

		// Token: 0x04000DD7 RID: 3543
		private byte[] lazySerialNumber;

		// Token: 0x04000DD8 RID: 3544
		private string lazyIssuer;

		// Token: 0x04000DD9 RID: 3545
		private string lazySubject;

		// Token: 0x04000DDA RID: 3546
		private string lazyKeyAlgorithm;

		// Token: 0x04000DDB RID: 3547
		private byte[] lazyKeyAlgorithmParameters;

		// Token: 0x04000DDC RID: 3548
		private byte[] lazyPublicKey;

		// Token: 0x04000DDD RID: 3549
		private DateTime lazyNotBefore;

		// Token: 0x04000DDE RID: 3550
		private DateTime lazyNotAfter;
	}
}
