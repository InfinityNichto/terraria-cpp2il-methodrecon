using System;

namespace System.Xml
{
	// Token: 0x02000028 RID: 40
	internal class TernaryTreeReadOnly
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x00003F58 File Offset: 0x00002158
		public TernaryTreeReadOnly(byte[] nodeBuffer)
		{
			this.nodeBuffer = nodeBuffer;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00003F74 File Offset: 0x00002174
		public byte FindCaseInsensitiveString(string stringToFind)
		{
			/*
An exception occurred when decompiling this method (060000D6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte System.Xml.TernaryTreeReadOnly::FindCaseInsensitiveString(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, ldfld:uint8[](TernaryTreeReadOnly::nodeBuffer, ldloc:TernaryTreeReadOnly(this)))
	stloc:int64(var_1_08, ldc.i4:int64(0))
	stloc:char(var_2_10, callgetter:char(string::get_Chars, ldloc:string(stringToFind), ldloc:int64[exp:int32](var_1_08)))
	stloc:int64(var_4_14, ldc.i4:int64(0))
	stloc:int32(var_5_1C, ldfld:int32(string::_stringLength, ldloc:string(stringToFind)))
	stloc:char(var_7_29, callgetter:char(string::get_Chars, ldloc:string(stringToFind), ldloc:int64[exp:int32](var_4_14)))
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

		// Token: 0x0400006C RID: 108
		private byte[] nodeBuffer;
	}
}
