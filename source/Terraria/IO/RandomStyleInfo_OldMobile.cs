using System;
using System.IO;

namespace Terraria.IO
{
	// Token: 0x02000572 RID: 1394
	public class RandomStyleInfo_OldMobile
	{
		// Token: 0x060033DF RID: 13279 RVA: 0x00200E6C File Offset: 0x001FF06C
		public bool Load(BinaryReader reader, int release)
		{
			/*
An exception occurred when decompiling this method (060033DF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.IO.RandomStyleInfo_OldMobile::Load(System.IO.BinaryReader,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:uint8(uint8::m_value, ldfld:uint8[][exp:uint8&](RandomStyleInfo_OldMobile::style, ldloc:RandomStyleInfo_OldMobile(this)), ldloc:BinaryReader[exp:uint8](reader))
	stfld:uint16(uint16::m_value, ldfld:uint16[][exp:uint16&](RandomStyleInfo_OldMobile::X, ldloc:RandomStyleInfo_OldMobile(this)), ldloc:BinaryReader[exp:uint16](reader))
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

		// Token: 0x060033E0 RID: 13280 RVA: 0x00200E98 File Offset: 0x001FF098
		public RandomStyleInfo_OldMobile()
		{
		}

		// Token: 0x04003E34 RID: 15924
		public byte[] style;

		// Token: 0x04003E35 RID: 15925
		public ushort[] X;
	}
}
