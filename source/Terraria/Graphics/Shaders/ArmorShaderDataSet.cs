using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x02000746 RID: 1862
	public class ArmorShaderDataSet
	{
		// Token: 0x06003D5A RID: 15706 RVA: 0x000021DB File Offset: 0x000003DB
		public T BindShader<T>(int itemId, T shaderData) where T : ArmorShaderData
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x00239000 File Offset: 0x00237200
		public void Apply(int shaderId, Entity entity, [Optional] DrawData? drawData)
		{
			int shaderDataCount = this._shaderDataCount;
			EffectTechnique <CurrentTechnique>k__BackingField = Main.pixelShader.<CurrentTechnique>k__BackingField;
			long num = 0L;
			EffectPass effectPass = <CurrentTechnique>k__BackingField.<Passes>k__BackingField[(int)num];
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x0023903C File Offset: 0x0023723C
		public void ApplySecondary(int shaderId, Entity entity, [Optional] DrawData? drawData)
		{
			int shaderDataCount = this._shaderDataCount;
			EffectTechnique <CurrentTechnique>k__BackingField = Main.pixelShader.<CurrentTechnique>k__BackingField;
			long num = 0L;
			EffectPass effectPass = <CurrentTechnique>k__BackingField.<Passes>k__BackingField[(int)num];
		}

		// Token: 0x06003D5D RID: 15709 RVA: 0x00239078 File Offset: 0x00237278
		public ArmorShaderData GetShaderFromItemId(int type)
		{
			/*
An exception occurred when decompiling this method (06003D5D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Graphics.Shaders.ArmorShaderData Terraria.Graphics.Shaders.ArmorShaderDataSet::GetShaderFromItemId(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, int32>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, int32>(ArmorShaderDataSet::_shaderLookupDictionary, ldloc:ArmorShaderDataSet(this)))
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.Graphics.Shaders.ArmorShaderData>(var_1_0D, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.Graphics.Shaders.ArmorShaderData>(ArmorShaderDataSet::_shaderData, ldloc:ArmorShaderDataSet(this)))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, int32>(var_2_14, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, int32>(ArmorShaderDataSet::_shaderLookupDictionary, ldloc:ArmorShaderDataSet(this)))
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

		// Token: 0x06003D5E RID: 15710 RVA: 0x0023909C File Offset: 0x0023729C
		public int GetShaderIdFromItemId(int type)
		{
			/*
An exception occurred when decompiling this method (06003D5E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Graphics.Shaders.ArmorShaderDataSet::GetShaderIdFromItemId(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, int32>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, int32>(ArmorShaderDataSet::_shaderLookupDictionary, ldloc:ArmorShaderDataSet(this)))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, int32>(var_1_0D, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, int32>(ArmorShaderDataSet::_shaderLookupDictionary, ldloc:ArmorShaderDataSet(this)))
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

		// Token: 0x06003D5F RID: 15711 RVA: 0x002390B8 File Offset: 0x002372B8
		public ArmorShaderData GetSecondaryShader(int id, Player player)
		{
			if (id == 0)
			{
				return;
			}
			int shaderDataCount = this._shaderDataCount;
			if (this._shaderData != null)
			{
				List<ArmorShaderData> shaderData = this._shaderData;
				return;
			}
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x002390E0 File Offset: 0x002372E0
		public ArmorShaderDataSet()
		{
		}

		// Token: 0x04007C40 RID: 31808
		protected List<ArmorShaderData> _shaderData;

		// Token: 0x04007C41 RID: 31809
		protected Dictionary<int, int> _shaderLookupDictionary;

		// Token: 0x04007C42 RID: 31810
		protected int _shaderDataCount;
	}
}
