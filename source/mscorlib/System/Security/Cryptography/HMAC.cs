using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002DA RID: 730
	[ComVisible(true)]
	public abstract class HMAC : KeyedHashAlgorithm
	{
		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06001899 RID: 6297 RVA: 0x00034A18 File Offset: 0x00032C18
		// (set) Token: 0x0600189A RID: 6298 RVA: 0x00034A2C File Offset: 0x00032C2C
		protected int BlockSizeValue
		{
			get
			{
				return this.blockSizeValue;
			}
			set
			{
				this.blockSizeValue = value;
			}
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00034A40 File Offset: 0x00032C40
		private void UpdateIOPadBuffers()
		{
			if (this.m_inner == null)
			{
				int num = this.blockSizeValue;
			}
			if (this.m_outer == null)
			{
				int num2 = this.blockSizeValue;
			}
			int num3 = this.blockSizeValue;
			int num4 = 54;
			int num5 = 92;
			this.m_inner.m_value = (byte)num4;
			this.m_outer.m_value = (byte)num5;
			byte[] keyValue = this.KeyValue;
			this.m_inner.m_value = keyValue;
			byte[] outer = this.m_outer;
			byte[] keyValue2 = this.KeyValue;
			outer.m_value = keyValue2;
			byte[] keyValue3 = this.KeyValue;
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00034AD0 File Offset: 0x00032CD0
		internal void InitializeKey(byte[] key)
		{
			int num = this.blockSizeValue;
			byte[] array = this.m_hash1.ComputeHash(key);
			this.KeyValue = array;
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x00034B18 File Offset: 0x00032D18
		// (set) Token: 0x0600189E RID: 6302 RVA: 0x00034B38 File Offset: 0x00032D38
		public override byte[] Key
		{
			get
			{
				byte[] keyValue = this.KeyValue;
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
			set
			{
				/*
An exception occurred when decompiling this method (0600189E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Security.Cryptography.HMAC::set_Key(System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	stloc:string(var_0_1A, call:string(Environment::GetResourceString, ldstr:string("Hash key cannot be changed after the first write to the stream.")))
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

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x00034B60 File Offset: 0x00032D60
		// (set) Token: 0x060018A0 RID: 6304 RVA: 0x00034B74 File Offset: 0x00032D74
		public string HashName
		{
			get
			{
				return this.m_hashName;
			}
			set
			{
				/*
An exception occurred when decompiling this method (060018A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Security.Cryptography.HMAC::set_HashName(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0033:
	stloc:string(var_3_3D, call:string(Environment::GetResourceString, ldstr:string("Hash name cannot be changed after the first write to the stream.")))
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

		// Token: 0x060018A1 RID: 6305 RVA: 0x0000207A File Offset: 0x0000027A
		public new static HMAC Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00034BC0 File Offset: 0x00032DC0
		public new static HMAC Create(string algorithmName)
		{
			if (!true)
			{
			}
			object obj;
			if (obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00034BD8 File Offset: 0x00032DD8
		public override void Initialize()
		{
			HashAlgorithm hash = this.m_hash1;
			HashAlgorithm hash2 = this.m_hash2;
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00034BF4 File Offset: 0x00032DF4
		protected override void HashCore(byte[] rgb, int ib, int cb)
		{
			if (!this.m_hashing)
			{
				byte[] inner = this.m_inner;
				HashAlgorithm hash = this.m_hash1;
				this.m_hashing = true;
			}
			HashAlgorithm hash2 = this.m_hash1;
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x00034C28 File Offset: 0x00032E28
		protected override byte[] HashFinal()
		{
			if (!this.m_hashing)
			{
				byte[] inner = this.m_inner;
				HashAlgorithm hash = this.m_hash1;
				this.m_hashing = true;
			}
			HashAlgorithm hash2 = this.m_hash1;
			if (!true)
			{
			}
			long num = 0L;
			byte[] outer = this.m_outer;
			HashAlgorithm hash3 = this.m_hash1;
			HashAlgorithm hash4 = this.m_hash2;
			long num2 = 0L;
			long num3 = 0L;
			byte[] hashValue = hash3.HashValue;
			int num4 = hash4.TransformBlock(outer, (int)num2, (int)num, outer, (int)num3);
			HashAlgorithm hash5 = this.m_hash2;
			long num5 = 0L;
			long num6 = 0L;
			int num7 = hash5.TransformBlock(hashValue, (int)num5, (int)num, hashValue, (int)num6);
			HashAlgorithm hash6 = this.m_hash2;
			return this.m_hash2.HashValue;
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00034CD0 File Offset: 0x00032ED0
		protected override void Dispose(bool disposing)
		{
			if (this.m_hash1 != null)
			{
				return;
			}
			long num;
			if (this.m_hash2 != null)
			{
				num = 0L;
				return;
			}
			byte[] inner = this.m_inner;
			if (inner != null)
			{
				long num2 = 0L;
				Array.Clear(inner, (int)num2, (int)num);
			}
			byte[] outer = this.m_outer;
			if (outer != null)
			{
				long num3 = 0L;
				Array.Clear(outer, (int)num3, (int)num);
			}
			byte[] keyValue = this.KeyValue;
			if (keyValue != null)
			{
				long num4 = 0L;
				Array.Clear(keyValue, (int)num4, (int)num);
			}
			int num5 = 1;
			this._disposed = num5 != 0;
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00034D40 File Offset: 0x00032F40
		internal static HashAlgorithm GetHashAlgorithmWithFipsFallback(Func<HashAlgorithm> createStandardHashAlgorithmCallback, Func<HashAlgorithm> createFipsHashAlgorithmCallback)
		{
			/*
An exception occurred when decompiling this method (060018A7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.HashAlgorithm System.Security.Cryptography.HMAC::GetHashAlgorithmWithFipsFallback(System.Func`1<System.Security.Cryptography.HashAlgorithm>,System.Func`1<System.Security.Cryptography.HashAlgorithm>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_0A, callgetter:bool(CryptoConfig::get_AllowOnlyFipsAlgorithms))
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

		// Token: 0x060018A8 RID: 6312 RVA: 0x00034D5C File Offset: 0x00032F5C
		protected HMAC()
		{
		}

		// Token: 0x04000CB1 RID: 3249
		private int blockSizeValue = 64;

		// Token: 0x04000CB2 RID: 3250
		internal string m_hashName;

		// Token: 0x04000CB3 RID: 3251
		internal HashAlgorithm m_hash1;

		// Token: 0x04000CB4 RID: 3252
		internal HashAlgorithm m_hash2;

		// Token: 0x04000CB5 RID: 3253
		private byte[] m_inner;

		// Token: 0x04000CB6 RID: 3254
		private byte[] m_outer;

		// Token: 0x04000CB7 RID: 3255
		private bool m_hashing;
	}
}
