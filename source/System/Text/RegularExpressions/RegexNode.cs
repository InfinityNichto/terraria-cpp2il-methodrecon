using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000BD RID: 189
	internal sealed class RegexNode
	{
		// Token: 0x06000400 RID: 1024 RVA: 0x000107EC File Offset: 0x0000E9EC
		public RegexNode(int type, RegexOptions options)
		{
			this.NType = type;
			this.Options = options;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00010810 File Offset: 0x0000EA10
		public RegexNode(int type, RegexOptions options, char ch)
		{
			this.NType = type;
			this.Options = options;
			this.Ch = ch;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00010838 File Offset: 0x0000EA38
		public RegexNode(int type, RegexOptions options, string str)
		{
			this.NType = type;
			this.Options = options;
			this.Str = str;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00010860 File Offset: 0x0000EA60
		public RegexNode(int type, RegexOptions options, int m)
		{
			this.NType = type;
			this.Options = options;
			this.M = m;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00010888 File Offset: 0x0000EA88
		public RegexNode(int type, RegexOptions options, int m, int n)
		{
			this.NType = type;
			this.N = n;
			this.Next = options;
			this.M = m;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000108B8 File Offset: 0x0000EAB8
		public bool UseOptionR()
		{
			/*
An exception occurred when decompiling this method (06000405)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.RegexNode::UseOptionR()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RegexOptions(var_0_06, ldfld:RegexOptions(RegexNode::Options, ldloc:RegexNode(this)))
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

		// Token: 0x06000406 RID: 1030 RVA: 0x000108CC File Offset: 0x0000EACC
		public RegexNode ReverseLeft()
		{
			RegexOptions options = this.Options;
			int ntype = this.NType;
			List<RegexNode> children = this.Children;
			if (children != null)
			{
				int size = children._size;
			}
			return this;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000108FC File Offset: 0x0000EAFC
		private void MakeRep(int type, int min, int max)
		{
			int ntype = this.NType;
			this.M = min;
			this.Options = (RegexOptions)max;
			this.NType = ntype;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00010928 File Offset: 0x0000EB28
		private RegexNode Reduce()
		{
			int ntype = this.NType;
			return this;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0001097C File Offset: 0x0000EB7C
		private RegexNode StripEnation(int emptyType)
		{
			List<RegexNode> children = this.Children;
			if (children == null || children._size == 0)
			{
				RegexOptions options = this.Options;
			}
			RegexNode regexNode;
			return regexNode;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x000109A8 File Offset: 0x0000EBA8
		private RegexNode ReduceGroup()
		{
			int ntype = this.NType;
			long num = 0L;
			return this.Child((int)num);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000109CC File Offset: 0x0000EBCC
		private RegexNode ReduceRep()
		{
			/*
An exception occurred when decompiling this method (0600040B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Text.RegularExpressions.RegexNode System.Text.RegularExpressions.RegexNode::ReduceRep()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_006E:
	stloc:RegexOptions(var_10_74, ldfld:RegexOptions(RegexNode::Options, ldloc:RegexNode(this)))
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

		// Token: 0x0600040C RID: 1036 RVA: 0x00010A50 File Offset: 0x0000EC50
		private RegexNode ReduceSet()
		{
			int num = 1;
			string str = this.Str;
			if (num == 0)
			{
			}
			bool flag = RegexCharClass.IsEmpty(str);
			int num2 = 22;
			this.NType = num2;
			string str2 = this.Str;
			if (num2 == 0)
			{
			}
			bool flag2 = RegexCharClass.IsSingleton(str2);
			char c = RegexCharClass.SingletonChar(this.Str);
			int ntype = this.NType;
			this.Ch = c;
			string str3 = this.Str;
			if (ntype == 0)
			{
			}
			char c2 = RegexCharClass.SingletonChar(str3);
			int ntype2 = this.NType;
			this.Ch = c2;
			this.NType = ntype2;
			return this;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00002050 File Offset: 0x00000250
		private RegexNode ReduceAlternation()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002050 File Offset: 0x00000250
		private RegexNode ReduceConcatenation()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00010ADC File Offset: 0x0000ECDC
		public RegexNode MakeQuantifier(bool lazy, int min, int max)
		{
			/*
An exception occurred when decompiling this method (0600040F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Text.RegularExpressions.RegexNode System.Text.RegularExpressions.RegexNode::MakeQuantifier(System.Boolean,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(RegexNode::NType, ldloc:RegexNode(this)))
	stfld:int32(RegexNode::M, ldloc:RegexNode(this), ldloc:int32(min))
	stfld:RegexOptions(RegexNode::Options, ldloc:RegexNode(this), ldloc:int32[exp:RegexOptions](max))
	stloc:RegexOptions(var_1_1B, ldfld:RegexOptions(RegexNode::Options, ldloc:RegexNode(this)))
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

		// Token: 0x06000410 RID: 1040 RVA: 0x00002050 File Offset: 0x00000250
		public void AddChild(RegexNode newChild)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00010B04 File Offset: 0x0000ED04
		public RegexNode Child(int i)
		{
			/*
An exception occurred when decompiling this method (06000411)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Text.RegularExpressions.RegexNode System.Text.RegularExpressions.RegexNode::Child(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class System.Text.RegularExpressions.RegexNode>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class System.Text.RegularExpressions.RegexNode>(RegexNode::Children, ldloc:RegexNode(this)))
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

		// Token: 0x06000412 RID: 1042 RVA: 0x00010B18 File Offset: 0x0000ED18
		public int ChildCount()
		{
			List<RegexNode> children = this.Children;
			if (children != null)
			{
				return children._size;
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00010B38 File Offset: 0x0000ED38
		public int Type()
		{
			return this.NType;
		}

		// Token: 0x04000339 RID: 825
		public int NType;

		// Token: 0x0400033A RID: 826
		public List<RegexNode> Children;

		// Token: 0x0400033B RID: 827
		public string Str;

		// Token: 0x0400033C RID: 828
		public char Ch;

		// Token: 0x0400033D RID: 829
		public int M;

		// Token: 0x0400033E RID: 830
		public int N;

		// Token: 0x0400033F RID: 831
		public readonly RegexOptions Options;

		// Token: 0x04000340 RID: 832
		public RegexNode Next;
	}
}
