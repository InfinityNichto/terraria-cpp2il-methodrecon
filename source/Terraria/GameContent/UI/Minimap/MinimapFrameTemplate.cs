using System;
using Microsoft.Xna.Framework;
using ReLogic.Content;

namespace Terraria.GameContent.UI.Minimap
{
	// Token: 0x02000A8D RID: 2701
	public class MinimapFrameTemplate
	{
		// Token: 0x06004FCF RID: 20431 RVA: 0x0027B648 File Offset: 0x00279848
		public MinimapFrameTemplate(string name, Vector2 frameOffset, Vector2 resetPosition, Vector2 zoomInPosition, Vector2 zoomOutPosition)
		{
			this.name = name;
		}

		// Token: 0x06004FD0 RID: 20432 RVA: 0x0027B664 File Offset: 0x00279864
		public MinimapFrame CreateInstance(AssetRequestMode mode)
		{
			/*
An exception occurred when decompiling this method (06004FD0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.UI.Minimap.MinimapFrame Terraria.GameContent.UI.Minimap.MinimapFrameTemplate::CreateInstance(ReLogic.Content.AssetRequestMode)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(MinimapFrameTemplate::name, ldloc:MinimapFrameTemplate(this)))
	stloc:Asset`1(var_1_1D, call:Asset`1(MinimapFrameTemplate::LoadAsset, call:string(string::Concat, ldstr:string("Images\\UI\\Minimap\\"), ldloc:string(var_0_06), ldstr:string("\\MinimapFrame")), ldloc:AssetRequestMode(mode)))
	stloc:Vector2(var_2_24, ldfld:Vector2(MinimapFrameTemplate::frameOffset, ldloc:MinimapFrameTemplate(this)))
	stloc:string(var_3_2B, ldfld:string(MinimapFrameTemplate::name, ldloc:MinimapFrameTemplate(this)))
	stloc:Asset`1(var_4_42, call:Asset`1(MinimapFrameTemplate::LoadAsset, call:string(string::Concat, ldstr:string("Images\\UI\\Minimap\\"), ldloc:string(var_3_2B), ldstr:string("\\MinimapButton_Reset")), ldloc:AssetRequestMode(mode)))
	stloc:float32(var_5_4F, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](MinimapFrameTemplate::resetPosition, ldloc:MinimapFrameTemplate(this))))
	stloc:float32(var_6_5C, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](MinimapFrameTemplate::resetPosition, ldloc:MinimapFrameTemplate(this))))
	stloc:string(var_7_64, ldfld:string(MinimapFrameTemplate::name, ldloc:MinimapFrameTemplate(this)))
	stloc:Asset`1(var_8_7D, call:Asset`1(MinimapFrameTemplate::LoadAsset, call:string(string::Concat, ldstr:string("Images\\UI\\Minimap\\"), ldloc:string(var_7_64), ldstr:string("\\MinimapButton_ZoomOut")), ldloc:AssetRequestMode(mode)))
	stloc:float32(var_9_8A, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](MinimapFrameTemplate::zoomOutPosition, ldloc:MinimapFrameTemplate(this))))
	stloc:float32(var_10_97, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](MinimapFrameTemplate::zoomOutPosition, ldloc:MinimapFrameTemplate(this))))
	stloc:string(var_11_9F, ldfld:string(MinimapFrameTemplate::name, ldloc:MinimapFrameTemplate(this)))
	stloc:Asset`1(var_12_B8, call:Asset`1(MinimapFrameTemplate::LoadAsset, call:string(string::Concat, ldstr:string("Images\\UI\\Minimap\\"), ldloc:string(var_11_9F), ldstr:string("\\MinimapButton_ZoomIn")), ldloc:AssetRequestMode(mode)))
	stloc:float32(var_13_C5, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](MinimapFrameTemplate::zoomInPosition, ldloc:MinimapFrameTemplate(this))))
	stloc:float32(var_14_D2, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](MinimapFrameTemplate::zoomInPosition, ldloc:MinimapFrameTemplate(this))))
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

		// Token: 0x06004FD1 RID: 20433 RVA: 0x0027B744 File Offset: 0x00279944
		private static Asset<T> LoadAsset<T>(string assetName, AssetRequestMode mode) where T : class
		{
			/*
An exception occurred when decompiling this method (06004FD1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ReLogic.Content.Asset`1<T> Terraria.GameContent.UI.Minimap.MinimapFrameTemplate::LoadAsset<T>(System.String,ReLogic.Content.AssetRequestMode)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x040088A7 RID: 34983
		private string name;

		// Token: 0x040088A8 RID: 34984
		private Vector2 frameOffset;

		// Token: 0x040088A9 RID: 34985
		private Vector2 resetPosition;

		// Token: 0x040088AA RID: 34986
		private Vector2 zoomInPosition;

		// Token: 0x040088AB RID: 34987
		private Vector2 zoomOutPosition;
	}
}
