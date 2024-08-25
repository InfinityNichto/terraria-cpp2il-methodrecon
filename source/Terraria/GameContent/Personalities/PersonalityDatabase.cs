using System;
using System.Collections.Generic;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x0200082F RID: 2095
	public class PersonalityDatabase
	{
		// Token: 0x060042E9 RID: 17129 RVA: 0x0024CD90 File Offset: 0x0024AF90
		public PersonalityDatabase()
		{
		}

		// Token: 0x060042EA RID: 17130 RVA: 0x0024CDA4 File Offset: 0x0024AFA4
		public void Register(int npcId, IShopPersonalityTrait trait)
		{
			Dictionary<int, PersonalityProfile> personalityProfiles = this._personalityProfiles;
			Dictionary<int, PersonalityProfile> personalityProfiles2 = this._personalityProfiles;
			int[] buckets = this._personalityProfiles._buckets;
		}

		// Token: 0x060042EB RID: 17131 RVA: 0x0024CDCC File Offset: 0x0024AFCC
		public void Register(IShopPersonalityTrait trait, params int[] npcIds)
		{
		}

		// Token: 0x060042EC RID: 17132 RVA: 0x0024CDE0 File Offset: 0x0024AFE0
		public PersonalityProfile GetByNPCID(int npcId)
		{
			/*
An exception occurred when decompiling this method (060042EC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Personalities.PersonalityProfile Terraria.GameContent.Personalities.PersonalityDatabase::GetByNPCID(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, class Terraria.GameContent.Personalities.PersonalityProfile>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, class Terraria.GameContent.Personalities.PersonalityProfile>(PersonalityDatabase::_personalityProfiles, ldloc:PersonalityDatabase(this)))
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

		// Token: 0x04008131 RID: 33073
		private Dictionary<int, PersonalityProfile> _personalityProfiles;

		// Token: 0x04008132 RID: 33074
		private PersonalityProfile _trashEntry;
	}
}
