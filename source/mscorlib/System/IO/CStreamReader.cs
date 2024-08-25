using System;
using System.Runtime.InteropServices;
using System.Text;

namespace System.IO
{
	// Token: 0x02000571 RID: 1393
	internal class CStreamReader : StreamReader
	{
		// Token: 0x060029F9 RID: 10745 RVA: 0x0005B420 File Offset: 0x00059620
		public CStreamReader(Stream stream, Encoding encoding)
		{
			int num = 1;
			if (num == 0)
			{
			}
			base..ctor(stream, encoding);
			if (num == 0)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x0005B444 File Offset: 0x00059644
		public override int Peek()
		{
			return base.Peek();
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x0005B45C File Offset: 0x0005965C
		public override int Read()
		{
			/*
An exception occurred when decompiling this method (060029FB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.CStreamReader::Read()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:ConsoleKeyInfo(var_1_0A, call:ConsoleKeyInfo(Console::ReadKey))
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

		// Token: 0x060029FC RID: 10748 RVA: 0x0005B478 File Offset: 0x00059678
		public override int Read([In] [Out] char[] dest, int index, int count)
		{
			if (dest != null)
			{
				return this.driver.Read(dest, index, count);
			}
			return "index";
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x0005B4A0 File Offset: 0x000596A0
		public override string ReadLine()
		{
			TermInfoDriver termInfoDriver = this.driver;
			return termInfoDriver.ReadLine();
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x0005B4C0 File Offset: 0x000596C0
		public override string ReadToEnd()
		{
			TermInfoDriver termInfoDriver = this.driver;
			return termInfoDriver.ReadToEnd();
		}

		// Token: 0x04001689 RID: 5769
		private TermInfoDriver driver;
	}
}
