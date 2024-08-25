using System;
using System.Collections;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000C2 RID: 194
	public abstract class RegexRunner
	{
		// Token: 0x0600046C RID: 1132 RVA: 0x00012AA8 File Offset: 0x00010CA8
		protected internal RegexRunner()
		{
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00012ABC File Offset: 0x00010CBC
		protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout)
		{
			/*
An exception occurred when decompiling this method (0600046D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Text.RegularExpressions.Match System.Text.RegularExpressions.RegexRunner::Scan(System.Text.RegularExpressions.Regex,System.String,System.Int32,System.Int32,System.Int32,System.Int32,System.Boolean,System.TimeSpan)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00ED:
	stloc:int32(var_16_F6, ldfld:int32(RegexRunner::runtextpos, ldloc:RegexRunner(this)))
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

		// Token: 0x0600046E RID: 1134 RVA: 0x00012BC0 File Offset: 0x00010DC0
		private void StartTimeoutWatch()
		{
			if (!this._ignoreTimeout)
			{
				int num = 1000;
				this._timeoutChecksToSkip = num;
				int tickCount = Environment.TickCount;
				int timeout = this._timeout;
				this._timeoutOccursAt = timeout;
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00012BF8 File Offset: 0x00010DF8
		protected void CheckTimeout()
		{
			if (this._ignoreTimeout)
			{
				return;
			}
			this.DoCheckTimeout();
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00012C14 File Offset: 0x00010E14
		private void DoCheckTimeout()
		{
			int timeoutChecksToSkip = this._timeoutChecksToSkip;
			this._timeoutChecksToSkip = timeoutChecksToSkip;
			this._timeoutChecksToSkip = 1000;
			int tickCount = Environment.TickCount;
			int timeoutOccursAt = this._timeoutOccursAt;
		}

		// Token: 0x06000471 RID: 1137
		protected abstract void Go();

		// Token: 0x06000472 RID: 1138
		protected abstract bool FindFirstChar();

		// Token: 0x06000473 RID: 1139
		protected abstract void InitTrackCount();

		// Token: 0x06000474 RID: 1140 RVA: 0x00012C70 File Offset: 0x00010E70
		private void InitMatch()
		{
			Match match = this.runmatch;
			Regex regex = this.runregex;
			if (match != null)
			{
				string text = this.runtext;
				int num = this.runtextbeg;
				int num2 = this.runtextstart;
				int num3 = this.runtextstart;
				return;
			}
			Hashtable caps = regex.caps;
			int capsize = regex.capsize;
			string text2 = this.runtext;
			int num4 = this.runtextbeg;
			int num5 = this.runtextstart;
			int num6 = this.runtextstart;
			if (caps != null)
			{
				return;
			}
			if (this.runcrawl != null)
			{
				int[] array = this.runtrack;
				int[] array2 = this.runstack;
				this.runtrackpos = array;
				this.runstackpos = array;
				return;
			}
			int num7 = this.runtrackcount;
			int num8 = 32;
			this.runtrackpos = regex;
			this.runstackpos = num6;
			this.runcrawlpos = num8;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00012D34 File Offset: 0x00010F34
		private Match TidyMatch(bool quick)
		{
			Match match = this.runmatch;
			int num = this.runtextpos;
			return match;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00012D50 File Offset: 0x00010F50
		protected void EnsureStorage()
		{
			int num = this.runstackpos;
			int num2 = this.runtrackcount;
			this.DoubleStack();
			int num3 = this.runtrackcount;
			int num4 = this.runtrackpos;
			this.DoubleTrack();
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00012D88 File Offset: 0x00010F88
		protected bool IsBoundary(int index, int startpos, int endpos)
		{
			return RegexCharClass.IsWordChar(this.runtext[index]);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00012DC0 File Offset: 0x00010FC0
		protected bool IsECMABoundary(int index, int startpos, int endpos)
		{
			return RegexCharClass.IsECMAWordChar(this.runtext[index]);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00012DF8 File Offset: 0x00010FF8
		protected void DoubleTrack()
		{
			int[] array = this.runtrack;
			int[] array2 = this.runtrack;
			int[] array3 = this.runtrack;
			int num = this.runtrackpos;
			this.runtrackpos = array3;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00012E28 File Offset: 0x00011028
		protected void DoubleStack()
		{
			int[] array = this.runstack;
			int[] array2 = this.runstack;
			int[] array3 = this.runstack;
			int num = this.runstackpos;
			this.runstackpos = array3;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00012E58 File Offset: 0x00011058
		protected void DoubleCrawl()
		{
			int[] array = this.runcrawl;
			int[] array2 = this.runcrawl;
			int[] array3 = this.runcrawl;
			int num = this.runcrawlpos;
			this.runcrawlpos = array3;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00012E88 File Offset: 0x00011088
		protected void Crawl(int i)
		{
			int num;
			if (this.runcrawlpos == 0)
			{
				this.DoubleCrawl();
				num = this.runcrawlpos;
			}
			int[] array = this.runcrawl;
			this.runcrawlpos = num;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00012EB8 File Offset: 0x000110B8
		protected int Popcrawl()
		{
			/*
An exception occurred when decompiling this method (0600047D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.RegexRunner::Popcrawl()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_06, ldfld:int32[](RegexRunner::runcrawl, ldloc:RegexRunner(this)))
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

		// Token: 0x0600047E RID: 1150 RVA: 0x00012ECC File Offset: 0x000110CC
		protected int Crawlpos()
		{
			/*
An exception occurred when decompiling this method (0600047E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.RegexRunner::Crawlpos()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_06, ldfld:int32[](RegexRunner::runcrawl, ldloc:RegexRunner(this)))
	stloc:int32(var_1_0D, ldfld:int32(RegexRunner::runcrawlpos, ldloc:RegexRunner(this)))
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

		// Token: 0x0600047F RID: 1151 RVA: 0x00012EE8 File Offset: 0x000110E8
		protected void Capture(int capnum, int start, int end)
		{
			int num;
			if (this.runcrawlpos == 0)
			{
				this.DoubleCrawl();
				num = this.runcrawlpos;
			}
			int[] array = this.runcrawl;
			this.runcrawlpos = num;
			Match match = this.runmatch;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00012F20 File Offset: 0x00011120
		protected void TransferCapture(int capnum, int uncapnum, int start, int end)
		{
			Match match = this.runmatch;
			Match match2 = this.runmatch;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00012F98 File Offset: 0x00011198
		protected void Uncapture()
		{
			Match match = this.runmatch;
			int[] array = this.runcrawl;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00012FB4 File Offset: 0x000111B4
		protected bool IsMatched(int cap)
		{
			/*
An exception occurred when decompiling this method (06000482)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.RegexRunner::IsMatched(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Match(var_0_06, ldfld:Match(RegexRunner::runmatch, ldloc:RegexRunner(this)))
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

		// Token: 0x06000483 RID: 1155 RVA: 0x00012FC8 File Offset: 0x000111C8
		protected int MatchIndex(int cap)
		{
			/*
An exception occurred when decompiling this method (06000483)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.RegexRunner::MatchIndex(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Match(var_0_06, ldfld:Match(RegexRunner::runmatch, ldloc:RegexRunner(this)))
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

		// Token: 0x06000484 RID: 1156 RVA: 0x00012FDC File Offset: 0x000111DC
		protected int MatchLength(int cap)
		{
			/*
An exception occurred when decompiling this method (06000484)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.RegexRunner::MatchLength(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Match(var_0_06, ldfld:Match(RegexRunner::runmatch, ldloc:RegexRunner(this)))
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

		// Token: 0x0400036B RID: 875
		protected internal int runtextbeg;

		// Token: 0x0400036C RID: 876
		protected internal int runtextend;

		// Token: 0x0400036D RID: 877
		protected internal int runtextstart;

		// Token: 0x0400036E RID: 878
		protected internal string runtext;

		// Token: 0x0400036F RID: 879
		protected internal int runtextpos;

		// Token: 0x04000370 RID: 880
		protected internal int[] runtrack;

		// Token: 0x04000371 RID: 881
		protected internal int runtrackpos;

		// Token: 0x04000372 RID: 882
		protected internal int[] runstack;

		// Token: 0x04000373 RID: 883
		protected internal int runstackpos;

		// Token: 0x04000374 RID: 884
		protected internal int[] runcrawl;

		// Token: 0x04000375 RID: 885
		protected internal int runcrawlpos;

		// Token: 0x04000376 RID: 886
		protected internal int runtrackcount;

		// Token: 0x04000377 RID: 887
		protected internal Match runmatch;

		// Token: 0x04000378 RID: 888
		protected internal Regex runregex;

		// Token: 0x04000379 RID: 889
		private int _timeout;

		// Token: 0x0400037A RID: 890
		private bool _ignoreTimeout;

		// Token: 0x0400037B RID: 891
		private int _timeoutOccursAt;

		// Token: 0x0400037C RID: 892
		private const int TimeoutCheckFrequency = 1000;

		// Token: 0x0400037D RID: 893
		private int _timeoutChecksToSkip;
	}
}
