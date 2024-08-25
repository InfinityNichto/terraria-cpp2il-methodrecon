using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200095C RID: 2396
	public class SpawnConditionBestiaryInfoElement : FilterProviderInfoElement, IBestiaryBackgroundImagePathAndColorProvider, IBestiaryPrioritizedElement
	{
		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060047F0 RID: 18416 RVA: 0x0025F8B4 File Offset: 0x0025DAB4
		// (set) Token: 0x060047F1 RID: 18417 RVA: 0x0025F8C8 File Offset: 0x0025DAC8
		public float OrderPriority
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (060047F0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Bestiary.SpawnConditionBestiaryInfoElement::get_OrderPriority()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(SpawnConditionBestiaryInfoElement::<OrderPriority>k__BackingField, ldloc:SpawnConditionBestiaryInfoElement(this)))
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

		// Token: 0x060047F2 RID: 18418 RVA: 0x0025F8D8 File Offset: 0x0025DAD8
		public SpawnConditionBestiaryInfoElement(string nameLanguageKey, int filterIconFrame, [Optional] string backgroundImagePath, [Optional] Color? backgroundColor)
		{
			this._key = nameLanguageKey;
			this._backgroundImagePath = backgroundImagePath;
			this._backgroundColor = backgroundColor;
		}

		// Token: 0x060047F3 RID: 18419 RVA: 0x0025F904 File Offset: 0x0025DB04
		public Asset<Texture2D> GetBackgroundImage()
		{
			int num = 1;
			if (this._backgroundImagePath != null && num == 0)
			{
				string backgroundImagePath = this._backgroundImagePath;
				return;
			}
		}

		// Token: 0x060047F4 RID: 18420 RVA: 0x0025F928 File Offset: 0x0025DB28
		public Color? GetBackgroundColor()
		{
			return this._backgroundColor;
		}

		// Token: 0x04008396 RID: 33686
		private string _backgroundImagePath;

		// Token: 0x04008397 RID: 33687
		private Color? _backgroundColor;

		// Token: 0x04008398 RID: 33688
		[CompilerGenerated]
		private float <OrderPriority>k__BackingField;
	}
}
