using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002E3 RID: 739
	[ComVisible(true)]
	public class MACTripleDES : KeyedHashAlgorithm
	{
		// Token: 0x060018C8 RID: 6344 RVA: 0x00035100 File Offset: 0x00033300
		public MACTripleDES()
		{
			int num = 1;
			base..ctor();
			if (num == 0)
			{
			}
			RNGCryptoServiceProvider staticRandomNumberGenerator = Utils.StaticRandomNumberGenerator;
			byte[] keyValue = this.KeyValue;
			TripleDES tripleDES = TripleDES.Create();
			this.des = tripleDES;
			TripleDES tripleDES2 = this.des;
			this.HashSizeValue = tripleDES;
			this.m_bytesPerBlock = keyValue;
			TripleDES tripleDES3 = this.des;
			TripleDES tripleDES4 = this.des;
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x00035168 File Offset: 0x00033368
		public MACTripleDES(byte[] rgbKey)
		{
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x00035178 File Offset: 0x00033378
		public MACTripleDES(string strTripleDES, byte[] rgbKey)
		{
			do
			{
				base..ctor();
			}
			while (rgbKey == null);
			if (strTripleDES != null)
			{
				TripleDES tripleDES = TripleDES.Create(strTripleDES);
				return;
			}
			TripleDES tripleDES2 = TripleDES.Create();
			this.des = tripleDES2;
			this.HashSizeValue = tripleDES2;
			object obj;
			if (obj != null)
			{
				if (obj != null)
				{
					this.KeyValue = obj;
					if (obj != null)
					{
						goto IL_0043;
					}
				}
				throw new InvalidCastException();
			}
			IL_0043:
			TripleDES tripleDES3 = this.des;
			TripleDES tripleDES4 = this.des;
			TripleDES tripleDES5 = this.des;
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x000351E0 File Offset: 0x000333E0
		public override void Initialize()
		{
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x000351F0 File Offset: 0x000333F0
		// (set) Token: 0x060018CD RID: 6349 RVA: 0x00035204 File Offset: 0x00033404
		[ComVisible(false)]
		public PaddingMode Padding
		{
			get
			{
				/*
An exception occurred when decompiling this method (060018CC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.PaddingMode System.Security.Cryptography.MACTripleDES::get_Padding()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TripleDES(var_0_06, ldfld:TripleDES(MACTripleDES::des, ldloc:MACTripleDES(this)))
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
				TripleDES tripleDES = this.des;
			}
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x00035224 File Offset: 0x00033424
		protected override void HashCore(byte[] rgbData, int ibStart, int cbSize)
		{
			if (this.m_encryptor != null)
			{
				CryptoStream cs = this._cs;
				return;
			}
			TripleDES tripleDES = this.des;
			TripleDES tripleDES2 = this.des;
			TripleDES tripleDES3 = this.des;
			this.m_encryptor = tripleDES2;
			ICryptoTransform encryptor = this.m_encryptor;
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x00035268 File Offset: 0x00033468
		protected override byte[] HashFinal()
		{
			if (this.m_encryptor != null)
			{
				CryptoStream cs = this._cs;
			}
			TripleDES tripleDES = this.des;
			TripleDES tripleDES2 = this.des;
			TripleDES tripleDES3 = this.des;
			this.m_encryptor = tripleDES2;
			ICryptoTransform encryptor = this.m_encryptor;
			return this._ts.Buffer;
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x000352B4 File Offset: 0x000334B4
		protected override void Dispose(bool disposing)
		{
			TripleDES tripleDES = this.des;
			if (tripleDES != null)
			{
				tripleDES.Clear();
			}
			long num;
			if (this.m_encryptor != null)
			{
				num = 0L;
				return;
			}
			CryptoStream cs = this._cs;
			if (cs != null)
			{
				cs.Clear();
			}
			if (this._ts != null)
			{
			}
			byte[] keyValue = this.KeyValue;
			if (keyValue != null)
			{
				long num2 = 0L;
				Array.Clear(keyValue, (int)num2, (int)num);
			}
			int num3 = 1;
			this._disposed = num3 != 0;
		}

		// Token: 0x04000CBB RID: 3259
		private ICryptoTransform m_encryptor;

		// Token: 0x04000CBC RID: 3260
		private CryptoStream _cs;

		// Token: 0x04000CBD RID: 3261
		private TailStream _ts;

		// Token: 0x04000CBE RID: 3262
		private const int m_bitsPerByte = 8;

		// Token: 0x04000CBF RID: 3263
		private int m_bytesPerBlock;

		// Token: 0x04000CC0 RID: 3264
		private TripleDES des;
	}
}
