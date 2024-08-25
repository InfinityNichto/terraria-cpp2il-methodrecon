using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000957 RID: 2391
	public class FilterProviderInfoElement : IFilterInfoProvider, IProvideSearchFilterString, IBestiaryInfoElement
	{
		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060047D5 RID: 18389 RVA: 0x0025F624 File Offset: 0x0025D824
		// (set) Token: 0x060047D6 RID: 18390 RVA: 0x0025F638 File Offset: 0x0025D838
		public int DisplayTextPriority
		{
			[CompilerGenerated]
			get
			{
				return this.<DisplayTextPriority>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DisplayTextPriority>k__BackingField = value;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060047D7 RID: 18391 RVA: 0x0025F64C File Offset: 0x0025D84C
		// (set) Token: 0x060047D8 RID: 18392 RVA: 0x0025F660 File Offset: 0x0025D860
		public bool HideInPortraitInfo
		{
			[CompilerGenerated]
			get
			{
				return this.<HideInPortraitInfo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x0025F670 File Offset: 0x0025D870
		public FilterProviderInfoElement(string nameLanguageKey, int filterIconFrame)
		{
			this._key = nameLanguageKey;
		}

		// Token: 0x060047DA RID: 18394 RVA: 0x0025F68C File Offset: 0x0025D88C
		public UIElement GetFilterImage()
		{
			/*
An exception occurred when decompiling this method (060047DA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.UIElement Terraria.GameContent.Bestiary.FilterProviderInfoElement::GetFilterImage()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Point(var_0_09, ldfld:Point(FilterProviderInfoElement::_filterIconFrame, ldloc:FilterProviderInfoElement(this)))
	stloc:string(var_1_10, ldfld:string(FilterProviderInfoElement::_key, ldloc:FilterProviderInfoElement(this)))
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

		// Token: 0x060047DB RID: 18395 RVA: 0x0025F6AC File Offset: 0x0025D8AC
		public string GetSearchString(BestiaryUICollectionInfo info)
		{
			if (info.UnlockState != BestiaryEntryUnlockState.NotKnownAtAll_0)
			{
				return Language.GetText(this._key).<Value>k__BackingField;
			}
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x0025F6D4 File Offset: 0x0025D8D4
		public string GetDisplayNameKey()
		{
			return this._key;
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x0025F6E8 File Offset: 0x0025D8E8
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			/*
An exception occurred when decompiling this method (060047DD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.UIElement Terraria.GameContent.Bestiary.FilterProviderInfoElement::ProvideUIElement(Terraria.GameContent.Bestiary.BestiaryUICollectionInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0020:
	stloc:UIElement(var_5_26, call:UIElement(FilterProviderInfoElement::GetFilterImage, ldloc:FilterProviderInfoElement(this)))
	stloc:LocalizedText(var_6_33, call:LocalizedText(Language::GetText, ldfld:string(FilterProviderInfoElement::_key, ldloc:FilterProviderInfoElement(this))))
	brtrue(IL_0000, logicnot:bool(ldloc:UIElement[exp:bool](var_5_26)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x060047DE RID: 18398 RVA: 0x0025F730 File Offset: 0x0025D930
		public void GetDisplay([Out] Texture2D texture, [Out] Rectangle frame)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060047DF RID: 18399 RVA: 0x0025F768 File Offset: 0x0025D968
		private void AddOnHover(UIElement button)
		{
		}

		// Token: 0x060047E0 RID: 18400 RVA: 0x0025F778 File Offset: 0x0025D978
		private void ShowButtonName(UIElement element)
		{
			if (element.<IsMouseHovering>k__BackingField)
			{
				string textValue = Language.GetTextValue(this._key);
			}
		}

		// Token: 0x060047E1 RID: 18401 RVA: 0x0025F79C File Offset: 0x0025D99C
		[CompilerGenerated]
		private void <AddOnHover>b__18_0(UIElement e)
		{
			this.ShowButtonName(e);
		}

		// Token: 0x0400838D RID: 33677
		private const int framesPerRow = 16;

		// Token: 0x0400838E RID: 33678
		private const int framesPerColumn = 5;

		// Token: 0x0400838F RID: 33679
		public Point _filterIconFrame;

		// Token: 0x04008390 RID: 33680
		private string _key;

		// Token: 0x04008391 RID: 33681
		[CompilerGenerated]
		private int <DisplayTextPriority>k__BackingField;

		// Token: 0x04008392 RID: 33682
		[CompilerGenerated]
		private bool <HideInPortraitInfo>k__BackingField;
	}
}
