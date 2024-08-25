using System;
using System.Collections;

namespace System.Net
{
	// Token: 0x020001EC RID: 492
	internal class HeaderInfoTable
	{
		// Token: 0x06000C0D RID: 3085 RVA: 0x00027120 File Offset: 0x00025320
		private static string[] ParseSingleValue(string value)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00027134 File Offset: 0x00025334
		private static string[] ParseMultiValue(string value)
		{
			/*
An exception occurred when decompiling this method (06000C0E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String[] System.Net.HeaderInfoTable::ParseMultiValue(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_12_1F, call:string(string::Trim, ldloc:string(var_11)))
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

		// Token: 0x06000C0F RID: 3087 RVA: 0x00027164 File Offset: 0x00025364
		static HeaderInfoTable()
		{
			if ("Pragma" == null || "Pragma" != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x17000279 RID: 633
		internal HeaderInfo this[string name]
		{
			get
			{
				if (!true)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x000271A8 File Offset: 0x000253A8
		public HeaderInfoTable()
		{
		}

		// Token: 0x04000A7B RID: 2683
		private static Hashtable HeaderHashTable;

		// Token: 0x04000A7C RID: 2684
		private static HeaderInfo UnknownHeaderInfo;

		// Token: 0x04000A7D RID: 2685
		private static HeaderParser SingleParser;

		// Token: 0x04000A7E RID: 2686
		private static HeaderParser MultiParser;
	}
}
