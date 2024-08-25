using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200095E RID: 2398
	public class SpawnConditionDecorativeOverlayInfoElement : IBestiaryInfoElement, IBestiaryBackgroundOverlayAndColorProvider
	{
		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060047FC RID: 18428 RVA: 0x0025F9E8 File Offset: 0x0025DBE8
		// (set) Token: 0x060047FD RID: 18429 RVA: 0x0025F9FC File Offset: 0x0025DBFC
		public float DisplayPriority
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (060047FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Bestiary.SpawnConditionDecorativeOverlayInfoElement::get_DisplayPriority()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(SpawnConditionDecorativeOverlayInfoElement::<DisplayPriority>k__BackingField, ldloc:SpawnConditionDecorativeOverlayInfoElement(this)))
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
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060047FE RID: 18430 RVA: 0x0025FA0C File Offset: 0x0025DC0C
		public SpawnConditionDecorativeOverlayInfoElement([Optional] string overlayImagePath, [Optional] Color? overlayColor)
		{
			this._overlayImagePath = overlayImagePath;
			this._overlayColor = overlayColor;
		}

		// Token: 0x060047FF RID: 18431 RVA: 0x0025FA30 File Offset: 0x0025DC30
		public Asset<Texture2D> GetBackgroundOverlayImage()
		{
			int num = 1;
			if (this._overlayImagePath != null && num == 0)
			{
				string overlayImagePath = this._overlayImagePath;
				return;
			}
		}

		// Token: 0x06004800 RID: 18432 RVA: 0x0025FA54 File Offset: 0x0025DC54
		public Color? GetBackgroundOverlayColor()
		{
			return this._overlayColor;
		}

		// Token: 0x06004801 RID: 18433 RVA: 0x0025FA68 File Offset: 0x0025DC68
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
		}

		// Token: 0x0400839D RID: 33693
		private string _overlayImagePath;

		// Token: 0x0400839E RID: 33694
		private Color? _overlayColor;

		// Token: 0x0400839F RID: 33695
		[CompilerGenerated]
		private float <DisplayPriority>k__BackingField;
	}
}
