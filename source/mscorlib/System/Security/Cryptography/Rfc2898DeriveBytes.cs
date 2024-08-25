using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;
using Internal.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x020002B2 RID: 690
	public class Rfc2898DeriveBytes : DeriveBytes
	{
		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x000322B8 File Offset: 0x000304B8
		public HashAlgorithmName HashAlgorithm
		{
			[CompilerGenerated]
			get
			{
				return this.<HashAlgorithm>k__BackingField;
			}
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x000322CC File Offset: 0x000304CC
		public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations)
		{
			HashAlgorithmName sha = HashAlgorithmName.SHA1;
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x000322E4 File Offset: 0x000304E4
		public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations, HashAlgorithmName hashAlgorithm)
		{
			do
			{
				base..ctor();
				if (salt == null)
				{
					return;
				}
			}
			while (password == null);
			byte[] array = salt.CloneByteArray();
			this._salt = array;
			this._iterations = (uint)iterations;
			byte[] array2 = password.CloneByteArray();
			this._password = array2;
			this.HashAlgorithm = hashAlgorithm;
			HMAC hmac = this.OpenHmac();
			this._hmac = hmac;
			this.Initialize();
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x00032340 File Offset: 0x00030540
		public Rfc2898DeriveBytes(string password, byte[] salt)
		{
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00032350 File Offset: 0x00030550
		public Rfc2898DeriveBytes(string password, byte[] salt, int iterations)
		{
			HashAlgorithmName sha = HashAlgorithmName.SHA1;
			Encoding utf = Encoding.UTF8;
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x0003236C File Offset: 0x0003056C
		public Rfc2898DeriveBytes(string password, byte[] salt, int iterations, HashAlgorithmName hashAlgorithm)
		{
			Encoding utf = Encoding.UTF8;
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x00032380 File Offset: 0x00030580
		public Rfc2898DeriveBytes(string password, int saltSize)
		{
			HashAlgorithmName sha = HashAlgorithmName.SHA1;
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00032398 File Offset: 0x00030598
		public Rfc2898DeriveBytes(string password, int saltSize, int iterations)
		{
			HashAlgorithmName sha = HashAlgorithmName.SHA1;
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x000323B0 File Offset: 0x000305B0
		public Rfc2898DeriveBytes(string password, int saltSize, int iterations, HashAlgorithmName hashAlgorithm)
		{
			byte[] array = Helpers.GenerateRandom(saltSize);
			this._salt = array;
			this._iterations = (uint)iterations;
			Encoding utf = Encoding.UTF8;
			this._password = utf;
			this.HashAlgorithm = hashAlgorithm;
			HMAC hmac = this.OpenHmac();
			this._hmac = hmac;
			this.Initialize();
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x00032404 File Offset: 0x00030604
		// (set) Token: 0x06001775 RID: 6005 RVA: 0x00032418 File Offset: 0x00030618
		public int IterationCount
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001774)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Security.Cryptography.Rfc2898DeriveBytes::get_IterationCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint32(var_0_06, ldfld:uint32(Rfc2898DeriveBytes::_iterations, ldloc:Rfc2898DeriveBytes(this)))
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
			set
			{
				this._iterations = (uint)value;
				this.Initialize();
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06001776 RID: 6006 RVA: 0x00032434 File Offset: 0x00030634
		// (set) Token: 0x06001777 RID: 6007 RVA: 0x0003244C File Offset: 0x0003064C
		public byte[] Salt
		{
			get
			{
				return this._salt.CloneByteArray();
			}
			set
			{
				if (value != null)
				{
					byte[] array = value.CloneByteArray();
					this._salt = array;
					this.Initialize();
					return;
				}
			}
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00032474 File Offset: 0x00030674
		protected override void Dispose(bool disposing)
		{
			HMAC hmac = this._hmac;
			if (hmac != null)
			{
				hmac.Dispose();
			}
			if (this._buffer != null)
			{
			}
			if (this._password != null)
			{
			}
			long num;
			if (this._salt != null)
			{
				num = 0L;
			}
			base.Dispose(num != 0L);
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x000324B4 File Offset: 0x000306B4
		public override byte[] GetBytes(int cb)
		{
			int startIndex = this._startIndex;
			byte[] buffer = this._buffer;
			int startIndex2 = this._startIndex;
			this._startIndex = startIndex2;
			return buffer;
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x0000207A File Offset: 0x0000027A
		public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x00032544 File Offset: 0x00030744
		public override void Reset()
		{
			this.Initialize();
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00032558 File Offset: 0x00030758
		private HMAC OpenHmac()
		{
			/*
An exception occurred when decompiling this method (0600177C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.HMAC System.Security.Cryptography.Rfc2898DeriveBytes::OpenHmac()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:HashAlgorithmName(var_0_06, ldfld:HashAlgorithmName(Rfc2898DeriveBytes::<HashAlgorithm>k__BackingField, ldloc:Rfc2898DeriveBytes(this)))
	stloc:HashAlgorithmName(var_3_0E, callgetter:HashAlgorithmName(HashAlgorithmName::get_SHA1))
	stloc:bool(var_4_16, call:bool(HashAlgorithmName::op_Equality, ldloc:HashAlgorithmName(var_0_06), ldloc:HashAlgorithmName(var_3_0E)))
	stloc:uint8[](var_5_1E, ldfld:uint8[](Rfc2898DeriveBytes::_password, ldloc:Rfc2898DeriveBytes(this)))
	stloc:HashAlgorithmName(var_7_28, callgetter:HashAlgorithmName(HashAlgorithmName::get_SHA256))
	stloc:HashAlgorithmName(var_10_32, callgetter:HashAlgorithmName(HashAlgorithmName::get_SHA384))
	stloc:HashAlgorithmName(var_13_3C, callgetter:HashAlgorithmName(HashAlgorithmName::get_SHA512))
	stloc:string(var_15_4A, call:string(SR::Format, ldstr:string("'{0}' is not a known hash algorithm."), ldloc:uint8[][exp:object](var_5_1E)))
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

		// Token: 0x0600177D RID: 6013 RVA: 0x000325B0 File Offset: 0x000307B0
		private void Initialize()
		{
			if (this._buffer != null)
			{
			}
			int blockSize = this._blockSize;
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x000325CC File Offset: 0x000307CC
		private byte[] Func()
		{
			/*
An exception occurred when decompiling this method (0600177E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.Rfc2898DeriveBytes::Func()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0049:
	call:void(Span`1::CopyTo, ldloc:Span`1[exp:valuetype System.Span`1&](var_11), ldloc:Span`1(var_11))
	stloc:ReadOnlySpan`1(var_12_59, call:ReadOnlySpan`1(Span`1::op_Implicit, ldloc:Span`1(var_11)))
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

		// Token: 0x04000C0F RID: 3087
		private const int MinimumSaltSize = 8;

		// Token: 0x04000C10 RID: 3088
		private readonly byte[] _password;

		// Token: 0x04000C11 RID: 3089
		private byte[] _salt;

		// Token: 0x04000C12 RID: 3090
		private uint _iterations;

		// Token: 0x04000C13 RID: 3091
		private HMAC _hmac;

		// Token: 0x04000C14 RID: 3092
		private int _blockSize;

		// Token: 0x04000C15 RID: 3093
		private byte[] _buffer;

		// Token: 0x04000C16 RID: 3094
		private uint _block;

		// Token: 0x04000C17 RID: 3095
		private int _startIndex;

		// Token: 0x04000C18 RID: 3096
		private int _endIndex;

		// Token: 0x04000C19 RID: 3097
		[CompilerGenerated]
		private readonly HashAlgorithmName <HashAlgorithm>k__BackingField;
	}
}
