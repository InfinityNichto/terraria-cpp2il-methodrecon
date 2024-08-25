using System;
using System.Globalization;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000BB RID: 187
	internal sealed class RegexInterpreter : RegexRunner
	{
		// Token: 0x060003D1 RID: 977 RVA: 0x0000EA44 File Offset: 0x0000CC44
		public RegexInterpreter(RegexCode code, CultureInfo culture)
		{
			this._code = code;
			this._culture = culture;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000EA68 File Offset: 0x0000CC68
		protected override void InitTrackCount()
		{
			int trackCount = this._code.TrackCount;
			this.runtrackcount = trackCount;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000EA88 File Offset: 0x0000CC88
		private void Advance(int i)
		{
			int codepos = this._codepos;
			RegexCode code = this._code;
			this._codepos = codepos;
			int[] codes = code.Codes;
			this._caseInsensitive = codes != null;
			this._rightToLeft = codepos != 0;
			this._operator = codes;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000EAC8 File Offset: 0x0000CCC8
		private void Goto(int newpos)
		{
			int codepos = this._codepos;
			base.EnsureStorage();
			int[] codes = this._code.Codes;
			this._operator = codes;
			this._rightToLeft = newpos != 0;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000EAFC File Offset: 0x0000CCFC
		private void Textto(int newpos)
		{
			this.runtextpos = newpos;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000EB10 File Offset: 0x0000CD10
		private void Trackto(int newpos)
		{
			int[] runtrack = this.runtrack;
			this.runtrackpos = runtrack;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000EB2C File Offset: 0x0000CD2C
		private int Textstart()
		{
			return this.runtextstart;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000EB40 File Offset: 0x0000CD40
		private int Textpos()
		{
			return this.runtextpos;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000EB54 File Offset: 0x0000CD54
		private int Trackpos()
		{
			/*
An exception occurred when decompiling this method (060003D9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.RegexInterpreter::Trackpos()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_06, ldfld:int32[](RegexRunner::runtrack, ldloc:RegexInterpreter[exp:RegexRunner](this)))
	stloc:int32(var_1_0D, ldfld:int32(RegexRunner::runtrackpos, ldloc:RegexInterpreter[exp:RegexRunner](this)))
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

		// Token: 0x060003DA RID: 986 RVA: 0x0000EB70 File Offset: 0x0000CD70
		private void TrackPush()
		{
			int runtrackpos = this.runtrackpos;
			int[] runtrack = this.runtrack;
			int codepos = this._codepos;
			this.runtrackpos = runtrackpos;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000EB9C File Offset: 0x0000CD9C
		private void TrackPush(int I1)
		{
			int runtrackpos = this.runtrackpos;
			int[] runtrack = this.runtrack;
			this.runtrackpos = runtrackpos;
			runtrack.m_value = I1;
			int runtrackpos2 = this.runtrackpos;
			int codepos = this._codepos;
			this.runtrackpos = runtrackpos2;
			runtrack.m_value = codepos;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000EBE4 File Offset: 0x0000CDE4
		private void TrackPush(int I1, int I2)
		{
			int runtrackpos = this.runtrackpos;
			int[] runtrack = this.runtrack;
			this.runtrackpos = runtrackpos;
			runtrack.m_value = I1;
			int runtrackpos2 = this.runtrackpos;
			this.runtrackpos = runtrackpos2;
			runtrack.m_value = I2;
			int runtrackpos3 = this.runtrackpos;
			int codepos = this._codepos;
			this.runtrackpos = runtrackpos3;
			runtrack.m_value = codepos;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000EC40 File Offset: 0x0000CE40
		private void TrackPush(int I1, int I2, int I3)
		{
			int runtrackpos = this.runtrackpos;
			int[] runtrack = this.runtrack;
			this.runtrackpos = runtrackpos;
			runtrack.m_value = I1;
			int runtrackpos2 = this.runtrackpos;
			this.runtrackpos = runtrackpos2;
			runtrack.m_value = I2;
			int runtrackpos3 = this.runtrackpos;
			this.runtrackpos = runtrackpos3;
			runtrack.m_value = I3;
			int runtrackpos4 = this.runtrackpos;
			int codepos = this._codepos;
			this.runtrackpos = runtrackpos4;
			runtrack.m_value = codepos;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000ECB4 File Offset: 0x0000CEB4
		private void TrackPush2(int I1)
		{
			int runtrackpos = this.runtrackpos;
			int[] runtrack = this.runtrack;
			this.runtrackpos = runtrackpos;
			runtrack.m_value = I1;
			int runtrackpos2 = this.runtrackpos;
			int codepos = this._codepos;
			this.runtrackpos = runtrackpos2;
			runtrack.m_value = codepos;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000ECFC File Offset: 0x0000CEFC
		private void TrackPush2(int I1, int I2)
		{
			int runtrackpos = this.runtrackpos;
			int[] runtrack = this.runtrack;
			this.runtrackpos = runtrackpos;
			runtrack.m_value = I1;
			int runtrackpos2 = this.runtrackpos;
			this.runtrackpos = runtrackpos2;
			runtrack.m_value = I2;
			int runtrackpos3 = this.runtrackpos;
			int codepos = this._codepos;
			this.runtrackpos = runtrackpos3;
			runtrack.m_value = codepos;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000ED58 File Offset: 0x0000CF58
		private void Backtrack()
		{
			int[] runtrack = this.runtrack;
			int[] codes = this._code.Codes;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000EDB4 File Offset: 0x0000CFB4
		private void SetOperator(int op)
		{
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000EDC4 File Offset: 0x0000CFC4
		private void TrackPop()
		{
			int runtrackpos = this.runtrackpos;
			this.runtrackpos = runtrackpos;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000EDE0 File Offset: 0x0000CFE0
		private void TrackPop(int framesize)
		{
			int runtrackpos = this.runtrackpos;
			this.runtrackpos = runtrackpos;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000EDFC File Offset: 0x0000CFFC
		private int TrackPeek()
		{
			/*
An exception occurred when decompiling this method (060003E4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.RegexInterpreter::TrackPeek()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(RegexRunner::runtrackpos, ldloc:RegexInterpreter[exp:RegexRunner](this)))
	stloc:int32[](var_1_0D, ldfld:int32[](RegexRunner::runtrack, ldloc:RegexInterpreter[exp:RegexRunner](this)))
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

		// Token: 0x060003E5 RID: 997 RVA: 0x0000EE18 File Offset: 0x0000D018
		private int TrackPeek(int i)
		{
			/*
An exception occurred when decompiling this method (060003E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.RegexInterpreter::TrackPeek(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(RegexRunner::runtrackpos, ldloc:RegexInterpreter[exp:RegexRunner](this)))
	stloc:int32[](var_1_0D, ldfld:int32[](RegexRunner::runtrack, ldloc:RegexInterpreter[exp:RegexRunner](this)))
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

		// Token: 0x060003E6 RID: 998 RVA: 0x0000EE34 File Offset: 0x0000D034
		private void StackPush(int I1)
		{
			int runstackpos = this.runstackpos;
			int[] runstack = this.runstack;
			this.runstackpos = runstackpos;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000EE58 File Offset: 0x0000D058
		private void StackPush(int I1, int I2)
		{
			int runstackpos = this.runstackpos;
			int[] runstack = this.runstack;
			this.runstackpos = runstackpos;
			runstack.m_value = I1;
			int runstackpos2 = this.runstackpos;
			this.runstackpos = runstackpos2;
			runstack.m_value = I2;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000EE98 File Offset: 0x0000D098
		private void StackPop()
		{
			int runstackpos = this.runstackpos;
			this.runstackpos = runstackpos;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000EEB4 File Offset: 0x0000D0B4
		private void StackPop(int framesize)
		{
			int runstackpos = this.runstackpos;
			this.runstackpos = runstackpos;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000EED0 File Offset: 0x0000D0D0
		private int StackPeek()
		{
			/*
An exception occurred when decompiling this method (060003EA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.RegexInterpreter::StackPeek()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(RegexRunner::runstackpos, ldloc:RegexInterpreter[exp:RegexRunner](this)))
	stloc:int32[](var_1_0D, ldfld:int32[](RegexRunner::runstack, ldloc:RegexInterpreter[exp:RegexRunner](this)))
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

		// Token: 0x060003EB RID: 1003 RVA: 0x0000EEEC File Offset: 0x0000D0EC
		private int StackPeek(int i)
		{
			/*
An exception occurred when decompiling this method (060003EB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.RegexInterpreter::StackPeek(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(RegexRunner::runstackpos, ldloc:RegexInterpreter[exp:RegexRunner](this)))
	stloc:int32[](var_1_0D, ldfld:int32[](RegexRunner::runstack, ldloc:RegexInterpreter[exp:RegexRunner](this)))
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

		// Token: 0x060003EC RID: 1004 RVA: 0x0000EF08 File Offset: 0x0000D108
		private int Operator()
		{
			return this._operator;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000EF1C File Offset: 0x0000D11C
		private int Operand(int i)
		{
			/*
An exception occurred when decompiling this method (060003ED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.RegexInterpreter::Operand(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RegexCode(var_0_06, ldfld:RegexCode(RegexInterpreter::_code, ldloc:RegexInterpreter(this)))
	stloc:int32(var_1_0D, ldfld:int32(RegexInterpreter::_codepos, ldloc:RegexInterpreter(this)))
	stloc:int32[](var_2_14, ldfld:int32[](RegexCode::Codes, ldloc:RegexCode(var_0_06)))
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

		// Token: 0x060003EE RID: 1006 RVA: 0x0000EF40 File Offset: 0x0000D140
		private int Leftchars()
		{
			/*
An exception occurred when decompiling this method (060003EE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.RegexInterpreter::Leftchars()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(RegexRunner::runtextpos, ldloc:RegexInterpreter[exp:RegexRunner](this)))
	stloc:int32(var_1_0D, ldfld:int32(RegexRunner::runtextbeg, ldloc:RegexInterpreter[exp:RegexRunner](this)))
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

		// Token: 0x060003EF RID: 1007 RVA: 0x0000EF5C File Offset: 0x0000D15C
		private int Rightchars()
		{
			/*
An exception occurred when decompiling this method (060003EF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.RegexInterpreter::Rightchars()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(RegexRunner::runtextend, ldloc:RegexInterpreter[exp:RegexRunner](this)))
	stloc:int32(var_1_0D, ldfld:int32(RegexRunner::runtextpos, ldloc:RegexInterpreter[exp:RegexRunner](this)))
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

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000EF78 File Offset: 0x0000D178
		private int Bump()
		{
			/*
An exception occurred when decompiling this method (060003F0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.RegexInterpreter::Bump()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(RegexInterpreter::_rightToLeft, ldloc:RegexInterpreter(this)))
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

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000EF8C File Offset: 0x0000D18C
		private int Forwardchars()
		{
			/*
An exception occurred when decompiling this method (060003F1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.RegexInterpreter::Forwardchars()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(RegexInterpreter::_rightToLeft, ldloc:RegexInterpreter(this)))
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

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		private char Forwardcharnext()
		{
			int runtextpos = this.runtextpos;
			bool rightToLeft = this._rightToLeft;
			string runtext = this.runtext;
			this.runtextpos = (rightToLeft ? 1 : 0);
			if (this._caseInsensitive)
			{
				CultureInfo culture = this._culture;
			}
			char c;
			return c;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000EFDC File Offset: 0x0000D1DC
		private bool Stringmatch(string str)
		{
			/*
An exception occurred when decompiling this method (060003F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.RegexInterpreter::Stringmatch(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_007D:
	stfld:int32(RegexRunner::runtextpos, ldloc:RegexInterpreter[exp:RegexRunner](this), ldloc:int32(var_0))
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

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000F070 File Offset: 0x0000D270
		private bool Refmatch(int index, int len)
		{
			/*
An exception occurred when decompiling this method (060003F4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.RegexInterpreter::Refmatch(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_007E:
	stloc:bool(var_11_84, ldfld:bool(RegexInterpreter::_rightToLeft, ldloc:RegexInterpreter(this)))
	stfld:int32(RegexRunner::runtextpos, ldloc:RegexInterpreter[exp:RegexRunner](this), ldloc:bool[exp:int32](var_11_84))
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

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000F110 File Offset: 0x0000D310
		private void Backwardnext()
		{
			bool rightToLeft = this._rightToLeft;
			int runtextpos = this.runtextpos;
			this.runtextpos = (rightToLeft ? 1 : 0);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000F134 File Offset: 0x0000D334
		private char CharAt(int j)
		{
			return this.runtext[j];
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000F150 File Offset: 0x0000D350
		protected override bool FindFirstChar()
		{
			RegexCode code = this._code;
			int anchors = code.Anchors;
			int num2;
			if (code.RightToLeft)
			{
				int runtextpos = this.runtextpos;
				int runtextend = this.runtextend;
				int runtextpos2 = this.runtextpos;
				int runtextstart = this.runtextstart;
				int runtextpos3 = this.runtextpos;
				int runtextbeg = this.runtextbeg;
				RegexBoyerMoore bmprefix = code.BMPrefix;
				if (bmprefix == null)
				{
					goto IL_00F2;
				}
				string runtext = this.runtext;
				int runtextpos4 = this.runtextpos;
				int runtextbeg2 = this.runtextbeg;
				int runtextstart2 = this.runtextstart;
				int num = bmprefix.Scan(runtext, runtextpos4, runtextbeg2, runtextstart2);
				this.runtextpos = num;
				RegexCode code2 = this._code;
				num2 = 16;
				bool rightToLeft = code2.RightToLeft;
			}
			int runtextpos5 = this.runtextpos;
			int runtextbeg3 = this.runtextbeg;
			int runtextpos6 = this.runtextpos;
			int runtextstart3 = this.runtextstart;
			int runtextend2 = this.runtextend;
			int runtextend3 = this.runtextend;
			int runtextpos7 = this.runtextpos;
			int runtextbeg4 = this.runtextbeg;
			this.runtextpos = runtextbeg4;
			IL_00F2:
			if (num2 == 0)
			{
				return;
			}
			this._rightToLeft = num2 != 0;
			this._caseInsensitive = num2 != 0;
			if (num2 == 0)
			{
			}
			if (runtextbeg4 == 0)
			{
			}
			bool rightToLeft2 = this._rightToLeft;
			char c = this.Forwardcharnext();
			long num3 = 0L;
			int runtextend4 = this.runtextend;
			int runtextpos8 = this.runtextpos;
			this.runtextpos = runtextend4;
			int runtextpos9 = this.runtextpos;
			int runtextend5 = this.runtextend;
			this.runtextpos = runtextend5;
			if (num3 != 0L)
			{
				string runtext2 = this.runtext;
				int runtextpos10 = this.runtextpos;
				int runtextbeg5 = this.runtextbeg;
				int runtextstart4 = this.runtextstart;
				bool flag;
				return flag;
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000F328 File Offset: 0x0000D528
		protected override void Go()
		{
			long num = 0L;
			this.Goto((int)num);
		}

		// Token: 0x04000330 RID: 816
		private readonly RegexCode _code;

		// Token: 0x04000331 RID: 817
		private readonly CultureInfo _culture;

		// Token: 0x04000332 RID: 818
		private int _operator;

		// Token: 0x04000333 RID: 819
		private int _codepos;

		// Token: 0x04000334 RID: 820
		private bool _rightToLeft;

		// Token: 0x04000335 RID: 821
		private bool _caseInsensitive;
	}
}
