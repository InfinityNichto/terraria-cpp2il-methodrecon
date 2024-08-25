using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002E7 RID: 743
	[ComVisible(true)]
	public class PasswordDeriveBytes : DeriveBytes
	{
		// Token: 0x060018E5 RID: 6373 RVA: 0x0003556C File Offset: 0x0003376C
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt)
		{
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x0003557C File Offset: 0x0003377C
		public PasswordDeriveBytes(byte[] password, byte[] salt)
		{
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0003558C File Offset: 0x0003378C
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations)
		{
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0003559C File Offset: 0x0003379C
		public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations)
		{
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x000355AC File Offset: 0x000337AC
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, CspParameters cspParams)
		{
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x000355BC File Offset: 0x000337BC
		public PasswordDeriveBytes(byte[] password, byte[] salt, CspParameters cspParams)
		{
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x000355CC File Offset: 0x000337CC
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations, CspParameters cspParams)
		{
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x000355DC File Offset: 0x000337DC
		public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations, CspParameters cspParams)
		{
			this.IterationCount = iterations;
			this.Salt = salt;
			this.HashName = hashName;
			this._password = password;
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x0003560C File Offset: 0x0003380C
		// (set) Token: 0x060018EE RID: 6382 RVA: 0x00035620 File Offset: 0x00033820
		public string HashName
		{
			get
			{
				return this._hashName;
			}
			set
			{
				if (this._baseValue != null)
				{
					throw new ArrayTypeMismatchException();
				}
				this._hashName = value;
				object obj = CryptoConfig.CreateFromName(value);
				if (obj != null)
				{
					this._hash = obj;
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x0003565C File Offset: 0x0003385C
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x00035670 File Offset: 0x00033870
		public int IterationCount
		{
			get
			{
				return this._iterations;
			}
			set
			{
				if (this._baseValue == null)
				{
					this._iterations = value;
					return;
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x000356A0 File Offset: 0x000338A0
		// (set) Token: 0x060018F2 RID: 6386 RVA: 0x000356C0 File Offset: 0x000338C0
		public byte[] Salt
		{
			get
			{
				object obj;
				if (this._salt == null || obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
			set
			{
				if (this._baseValue == null)
				{
					object obj;
					if (value != null && obj != null)
					{
						if (obj == null)
						{
							throw new InvalidCastException();
						}
						this._salt = obj;
						if (obj == null)
						{
							throw new InvalidCastException();
						}
					}
					return;
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x000356FC File Offset: 0x000338FC
		[Obsolete("Rfc2898DeriveBytes replaces PasswordDeriveBytes for deriving key material from a password and is preferred in new applications.")]
		public override byte[] GetBytes(int cb)
		{
			/*
An exception occurred when decompiling this method (060018F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.PasswordDeriveBytes::GetBytes(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001E:
	stloc:uint8[](var_4_27, call:uint8[](PasswordDeriveBytes::ComputeBytes, ldloc:PasswordDeriveBytes(this), ldloc:int32(var_0)))
	stfld:uint8[](PasswordDeriveBytes::_extra, ldloc:PasswordDeriveBytes(this), ldloc:uint8[](var_4_27))
	stloc:int32(var_7_37, ldfld:int32(PasswordDeriveBytes::_extraCount, ldloc:PasswordDeriveBytes(this)))
	stfld:int32(PasswordDeriveBytes::_extraCount, ldloc:PasswordDeriveBytes(this), ldloc:int32(var_7_37))
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

		// Token: 0x060018F4 RID: 6388 RVA: 0x0003574C File Offset: 0x0003394C
		public override void Reset()
		{
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x0003575C File Offset: 0x0003395C
		protected override void Dispose(bool disposing)
		{
			HashAlgorithm hash = this._hash;
			if (hash != null)
			{
				hash.Dispose();
			}
			if (this._baseValue != null)
			{
			}
			if (this._extra != null)
			{
			}
			if (this._password != null)
			{
			}
			if (this._salt != null)
			{
				return;
			}
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x0003579C File Offset: 0x0003399C
		public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV)
		{
			/*
An exception occurred when decompiling this method (060018F6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.PasswordDeriveBytes::CryptDeriveKey(System.String,System.String,System.Int32,System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0A, call:string(Environment::GetResourceString, ldstr:string("Specified key is not a valid size for this algorithm.")))
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

		// Token: 0x060018F7 RID: 6391 RVA: 0x000357B4 File Offset: 0x000339B4
		private byte[] ComputeBaseValue()
		{
			/*
An exception occurred when decompiling this method (060018F7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.PasswordDeriveBytes::ComputeBaseValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0025:
	stloc:HashAlgorithm(var_6_2B, ldfld:HashAlgorithm(PasswordDeriveBytes::_hash, ldloc:PasswordDeriveBytes(this)))
	stloc:HashAlgorithm(var_8_33, ldfld:HashAlgorithm(PasswordDeriveBytes::_hash, ldloc:PasswordDeriveBytes(this)))
	stloc:HashAlgorithm(var_9_3B, ldfld:HashAlgorithm(PasswordDeriveBytes::_hash, ldloc:PasswordDeriveBytes(this)))
	stfld:uint8[](PasswordDeriveBytes::_baseValue, ldloc:PasswordDeriveBytes(this), ldloc:HashAlgorithm[exp:uint8[]](var_8_33))
	stloc:int32(var_10_4B, ldfld:int32(PasswordDeriveBytes::_iterations, ldloc:PasswordDeriveBytes(this)))
	stloc:uint8[](var_11_53, ldfld:uint8[](PasswordDeriveBytes::_baseValue, ldloc:PasswordDeriveBytes(this)))
	stloc:uint8[](var_13_65, call:uint8[](HashAlgorithm::ComputeHash, ldfld:HashAlgorithm(PasswordDeriveBytes::_hash, ldloc:PasswordDeriveBytes(this)), ldloc:uint8[](var_11_53)))
	stloc:HashAlgorithm(var_14_6D, ldfld:HashAlgorithm(PasswordDeriveBytes::_hash, ldloc:PasswordDeriveBytes(this)))
	stloc:int32(var_15_75, ldfld:int32(PasswordDeriveBytes::_iterations, ldloc:PasswordDeriveBytes(this)))
	stfld:uint8[](PasswordDeriveBytes::_baseValue, ldloc:PasswordDeriveBytes(this), ldloc:HashAlgorithm[exp:uint8[]](var_14_6D))
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

		// Token: 0x060018F8 RID: 6392 RVA: 0x00035840 File Offset: 0x00033A40
		private byte[] ComputeBytes(int cb)
		{
			HashAlgorithm hash = this._hash;
			HashAlgorithm hash2 = this._hash;
			HashAlgorithm hash3 = this._hash;
			byte[] baseValue = this._baseValue;
			if (false)
			{
				throw new OutOfMemoryException();
			}
			HashAlgorithm hash4 = this._hash;
			HashAlgorithm hash5 = this._hash;
			HashAlgorithm hash6 = this._hash;
			byte[] baseValue2 = this._baseValue;
			long num = 0L;
			int num2 = 5;
			if (num != 0L)
			{
				throw new OutOfMemoryException();
			}
			if (num2 == 0)
			{
				HashAlgorithm hash7 = this._hash;
			}
			if (false)
			{
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x000358D0 File Offset: 0x00033AD0
		private void HashPrefix(CryptoStream cs)
		{
			int prefix = this._prefix;
		}

		// Token: 0x04000CC5 RID: 3269
		private int _extraCount;

		// Token: 0x04000CC6 RID: 3270
		private int _prefix;

		// Token: 0x04000CC7 RID: 3271
		private int _iterations;

		// Token: 0x04000CC8 RID: 3272
		private byte[] _baseValue;

		// Token: 0x04000CC9 RID: 3273
		private byte[] _extra;

		// Token: 0x04000CCA RID: 3274
		private byte[] _salt;

		// Token: 0x04000CCB RID: 3275
		private string _hashName;

		// Token: 0x04000CCC RID: 3276
		private byte[] _password;

		// Token: 0x04000CCD RID: 3277
		private HashAlgorithm _hash;
	}
}
