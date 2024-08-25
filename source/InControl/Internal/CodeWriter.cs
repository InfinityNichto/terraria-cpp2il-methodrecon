using System;
using System.Text;
using System.Text.RegularExpressions;

namespace InControl.Internal
{
	// Token: 0x02000074 RID: 116
	public class CodeWriter
	{
		// Token: 0x06000566 RID: 1382 RVA: 0x00010C20 File Offset: 0x0000EE20
		public CodeWriter()
		{
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00010C34 File Offset: 0x0000EE34
		public void IncreaseIndent()
		{
			int num = this.indent;
			this.indent = num;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00010C50 File Offset: 0x0000EE50
		public void DecreaseIndent()
		{
			int num = this.indent;
			this.indent = num;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00010C6C File Offset: 0x0000EE6C
		public void Append(string code)
		{
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00010C7C File Offset: 0x0000EE7C
		public void Append(bool trim, string code)
		{
			int num = 1;
			string text = code.Trim();
			if (num == 0)
			{
			}
			string[] array = Regex.Split(text, "\\r?\\n|\\n");
			StringBuilder stringBuilder = this.stringBuilder;
			int num2 = this.indent;
			int num3 = 9;
			StringBuilder stringBuilder2 = stringBuilder.Append((char)num3, num2);
			StringBuilder stringBuilder3 = this.stringBuilder.Append(text);
			StringBuilder stringBuilder4 = this.stringBuilder;
			int num4 = 10;
			StringBuilder stringBuilder5 = stringBuilder4.Append((char)num4);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00010CEC File Offset: 0x0000EEEC
		public void AppendLine(string code)
		{
			long num = 0L;
			this.Append(num != 0L, code);
			StringBuilder stringBuilder = this.stringBuilder;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00010D0C File Offset: 0x0000EF0C
		public void AppendLine(int count)
		{
			StringBuilder stringBuilder = this.stringBuilder;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00010D20 File Offset: 0x0000EF20
		public void AppendFormat(string format, params object[] args)
		{
			string text = string.Format(format, args);
			long num = 0L;
			this.Append(num != 0L, text);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00010D40 File Offset: 0x0000EF40
		public void AppendLineFormat(string format, params object[] args)
		{
			string text = string.Format(format, args);
			long num = 0L;
			this.Append(num != 0L, text);
			StringBuilder stringBuilder = this.stringBuilder;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00010D68 File Offset: 0x0000EF68
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (0600056F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String InControl.Internal.CodeWriter::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:StringBuilder(var_0_06, ldfld:StringBuilder(CodeWriter::stringBuilder, ldloc:CodeWriter(this)))
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

		// Token: 0x04000409 RID: 1033
		private const char newLine = '\n';

		// Token: 0x0400040A RID: 1034
		private int indent;

		// Token: 0x0400040B RID: 1035
		private readonly StringBuilder stringBuilder;
	}
}
