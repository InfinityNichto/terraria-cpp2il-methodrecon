using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000B9 RID: 185
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal ref struct RegexFCD
	{
		// Token: 0x060003BA RID: 954 RVA: 0x0000E5EC File Offset: 0x0000C7EC
		private RegexFCD(Span<int> intStack)
		{
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000E5FC File Offset: 0x0000C7FC
		public static RegexPrefix? FirstChars(RegexTree t)
		{
			/*
An exception occurred when decompiling this method (060003BB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<System.Text.RegularExpressions.RegexPrefix> System.Text.RegularExpressions.RegexFCD::FirstChars(System.Text.RegularExpressions.RegexTree)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000D:
	stloc:CultureInfo(var_3_14, callgetter:CultureInfo(CultureInfo::get_CurrentCulture))
	stloc:CultureInfo(var_4_1A, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_5_24, call:string(RegexFC::GetFirstChars, ldloc:RegexFC(var_1), ldloc:CultureInfo(var_4_1A)))
	stloc:bool(var_6_2C, ldfld:bool(RegexFC::<CaseInsensitive>k__BackingField, ldloc:RegexFC(var_1)))
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

		// Token: 0x060003BC RID: 956 RVA: 0x0000E638 File Offset: 0x0000C838
		public static RegexPrefix Prefix(RegexTree tree)
		{
			/*
An exception occurred when decompiling this method (060003BC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Text.RegularExpressions.RegexPrefix System.Text.RegularExpressions.RegexFCD::Prefix(System.Text.RegularExpressions.RegexTree)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002B:
	stloc:int32(var_9_32, ldfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_8)))
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

		// Token: 0x060003BD RID: 957 RVA: 0x0000E678 File Offset: 0x0000C878
		public static int Anchors(RegexTree tree)
		{
			RegexNode regexNode;
			List<RegexNode> children = regexNode.Children;
			long num;
			if (children != null)
			{
				int size = children._size;
				num = 0L;
			}
			if (regexNode != null)
			{
				List<RegexNode> children2 = regexNode.Children;
				if (children2 != null)
				{
					int size2 = children2._size;
				}
				RegexNode regexNode2 = regexNode.Child((int)num);
				int num2;
				return num2;
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000E6C4 File Offset: 0x0000C8C4
		private static int AnchorFromType(int type)
		{
			return 8;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000E6EC File Offset: 0x0000C8EC
		private void PushInt(int i)
		{
			this._intStack._span = i;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00002050 File Offset: 0x00000250
		private bool IntIsEmpty()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000E708 File Offset: 0x0000C908
		private int PopInt()
		{
			/*
An exception occurred when decompiling this method (060003C1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.RegexFCD::PopInt()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype System.Collections.Generic.ValueListBuilder`1<int32>(var_1_08, ldfld:valuetype System.Collections.Generic.ValueListBuilder`1<int32>(RegexFCD::_intStack, ldloc:valuetype System.Text.RegularExpressions.RegexFCD&(this)))
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

		// Token: 0x060003C2 RID: 962 RVA: 0x0000E720 File Offset: 0x0000C920
		private void PushFC(RegexFC fc)
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002050 File Offset: 0x00000250
		private bool FCIsEmpty()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000E730 File Offset: 0x0000C930
		private RegexFC PopFC()
		{
			return this.TopFC();
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002050 File Offset: 0x00000250
		private RegexFC TopFC()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000E744 File Offset: 0x0000C944
		public void Dispose()
		{
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000E754 File Offset: 0x0000C954
		private RegexFC RegexFCFromRegexTree(RegexTree tree)
		{
			RegexNode root;
			long num;
			do
			{
				root = tree.Root;
				num = 0L;
				List<RegexNode> children = root.Children;
				if (children == null)
				{
					break;
				}
				int size = children._size;
				if (this._skipAllChildren)
				{
					goto IL_0050;
				}
				int ntype = root.NType;
				if (!this._skipchild)
				{
					goto IL_007C;
				}
			}
			while (root.Children != null);
			int ntype2 = root.NType;
			long num2 = 0L;
			this.CalculateFC(ntype2, root, (int)num2);
			IL_0050:
			RegexNode next = root.Next;
			global::System.Collections.Generic.ValueListBuilder<int> intStack = this._intStack;
			int ntype3 = next.NType;
			this.CalculateFC(ntype2, next, (int)num);
			if (!this._failed)
			{
			}
			IL_007C:
			List<RegexNode> children2 = next.Children;
			this.PushInt((int)num);
			return this.PopFC();
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000E7F8 File Offset: 0x0000C9F8
		private void SkipChild()
		{
			this._skipchild = true;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000E80C File Offset: 0x0000CA0C
		private void CalculateFC(int NodeType, RegexNode node, int CurIndex)
		{
		}

		// Token: 0x04000328 RID: 808
		private readonly List<RegexFC> _fcStack;

		// Token: 0x04000329 RID: 809
		private global::System.Collections.Generic.ValueListBuilder<int> _intStack;

		// Token: 0x0400032A RID: 810
		private bool _skipAllChildren;

		// Token: 0x0400032B RID: 811
		private bool _skipchild;

		// Token: 0x0400032C RID: 812
		private bool _failed;
	}
}
