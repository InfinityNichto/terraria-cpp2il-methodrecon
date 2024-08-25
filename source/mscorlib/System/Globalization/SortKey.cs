using System;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	// Token: 0x020005B6 RID: 1462
	[ComVisible(true)]
	[Serializable]
	[StructLayout(0)]
	public class SortKey
	{
		// Token: 0x06002C8D RID: 11405 RVA: 0x000623A8 File Offset: 0x000605A8
		public static int Compare(SortKey sortkey1, SortKey sortkey2)
		{
			while (sortkey1 == null)
			{
			}
			byte[] array = sortkey1.key;
			byte[] array2 = sortkey1.key;
			return "sortkey1";
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x000623D0 File Offset: 0x000605D0
		internal SortKey(int lcid, string source, CompareOptions opt)
		{
			this.options = opt;
			this.source = source;
			int stringLength = source._stringLength;
			long num = 0L;
			char c = source[(int)num];
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x00062404 File Offset: 0x00060604
		internal SortKey(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength)
		{
			this.options = opt;
			this.source = source;
			this.key = buffer;
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x00062430 File Offset: 0x00060630
		internal SortKey(string localeName, string str, CompareOptions options, byte[] keyData)
		{
			/*
An exception occurred when decompiling this method (06002C90)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Globalization.SortKey::.ctor(System.String,System.String,System.Globalization.CompareOptions,System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(object::.ctor, ldloc:SortKey[exp:object](this))
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

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06002C91 RID: 11409 RVA: 0x00062444 File Offset: 0x00060644
		public virtual string OriginalString
		{
			get
			{
				return this.source;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06002C92 RID: 11410 RVA: 0x00062458 File Offset: 0x00060658
		public virtual byte[] KeyData
		{
			get
			{
				return this.key;
			}
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x0006246C File Offset: 0x0006066C
		public override bool Equals(object value)
		{
			if (value == null)
			{
				return;
			}
			int num = this.lcid;
			CompareOptions compareOptions = this.options;
			int num2;
			if (num2 != 0)
			{
				return;
			}
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x00062494 File Offset: 0x00060694
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06002C94)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.SortKey::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, ldfld:uint8[](SortKey::key, ldloc:SortKey(this)))
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

		// Token: 0x06002C95 RID: 11413 RVA: 0x000624AC File Offset: 0x000606AC
		public override string ToString()
		{
			string text;
			if (("SortKey - " == null || "SortKey - " != null) && (text == null || text != null) && (", " == null || ", " != null))
			{
				CompareOptions compareOptions = this.options;
				string text2;
				if ((text2 == null || text2 != null) && (", " == null || ", " != null))
				{
					string text3 = this.source;
					if (text3 == null || text3 != null)
					{
						string text4;
						return text4;
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x00062510 File Offset: 0x00060710
		internal SortKey()
		{
			throw new NotSupportedException();
		}

		// Token: 0x040018B9 RID: 6329
		private readonly string source;

		// Token: 0x040018BA RID: 6330
		private readonly byte[] key;

		// Token: 0x040018BB RID: 6331
		private readonly CompareOptions options;

		// Token: 0x040018BC RID: 6332
		private readonly int lcid;
	}
}
