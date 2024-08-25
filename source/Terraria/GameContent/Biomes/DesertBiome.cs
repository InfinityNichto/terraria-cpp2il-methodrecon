using System;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using Terraria.GameContent.Biomes.Desert;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x020008E9 RID: 2281
	public class DesertBiome : MicroBiome
	{
		// Token: 0x060045F4 RID: 17908 RVA: 0x0025662C File Offset: 0x0025482C
		public override bool Place(Point origin, StructureMap structures)
		{
			/*
An exception occurred when decompiling this method (060045F4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Biomes.DesertBiome::Place(Microsoft.Xna.Framework.Point,Terraria.WorldBuilding.StructureMap)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0085:
	stloc:UnifiedRandom(var_13_90, callgetter:UnifiedRandom(GenBase::get__random))
	stloc:int32(var_14_93, ldc.i4:int32(4))
	stloc:int32(var_15_9E, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_13_90), ldloc:int32(var_14_93)))
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

		// Token: 0x060045F5 RID: 17909 RVA: 0x002566D8 File Offset: 0x002548D8
		private static void ExportDescriptionToEngine(DesertDescription description)
		{
			int num = 1;
			int x = description.<CombinedArea>k__BackingField.X;
			if (num == 0)
			{
			}
			int x2 = description.<Hive>k__BackingField.X;
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x0025670C File Offset: 0x0025490C
		private static void CleanupArea(Rectangle area)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x00256724 File Offset: 0x00254924
		public DesertBiome()
		{
		}

		// Token: 0x0400824F RID: 33359
		[JsonProperty("ChanceOfEntrance")]
		public double ChanceOfEntrance;
	}
}
