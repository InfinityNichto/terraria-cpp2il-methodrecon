using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000A94 RID: 2708
	public class UIBestiaryEntryButton : UIElement
	{
		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06004FF6 RID: 20470 RVA: 0x0027BEAC File Offset: 0x0027A0AC
		// (set) Token: 0x06004FF7 RID: 20471 RVA: 0x0027BEC0 File Offset: 0x0027A0C0
		public BestiaryEntry Entry
		{
			[CompilerGenerated]
			get
			{
				return this.<Entry>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Entry>k__BackingField = value;
			}
		}

		// Token: 0x06004FF8 RID: 20472 RVA: 0x0027BED4 File Offset: 0x0027A0D4
		public UIBestiaryEntryButton(BestiaryEntry entry, bool isAPrettyPortrait)
		{
			if (!true)
			{
			}
			base..ctor();
			int num = 17040;
			this.Entry = entry;
			int num2 = 257;
			if (num == 0)
			{
			}
			if (num2 != 0)
			{
			}
		}

		// Token: 0x06004FF9 RID: 20473 RVA: 0x0027BF38 File Offset: 0x0027A138
		private Asset<Texture2D> TryGettingBackgroundImageProvider(BestiaryEntry entry)
		{
			int num = 1;
			List<IBestiaryInfoElement> <Info>k__BackingField = entry.<Info>k__BackingField;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			IEnumerable enumerable = Enumerable.OfType(entry.<Info>k__BackingField);
			while (<Info>k__BackingField == null)
			{
			}
			long num2;
			int num3;
			if (<Info>k__BackingField == null)
			{
				num2 = 0L;
				num3 = 7;
				if (<Info>k__BackingField != null)
				{
				}
			}
			if (num2 == 0L && num3 == 0)
			{
				while (<Info>k__BackingField == null)
				{
				}
				long num4;
				if (<Info>k__BackingField == null)
				{
					num4 = 0L;
					if (<Info>k__BackingField != null)
					{
					}
				}
				if (num4 != 0L)
				{
					throw new OutOfMemoryException();
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06004FFA RID: 20474 RVA: 0x0027BFD8 File Offset: 0x0027A1D8
		private int? TryGettingDisplayIndex(BestiaryEntry entry)
		{
			/*
An exception occurred when decompiling this method (06004FFA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<System.Int32> Terraria.GameContent.UI.Elements.UIBestiaryEntryButton::TryGettingDisplayIndex(Terraria.GameContent.Bestiary.BestiaryEntry)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	brtrue(IL_0000, logicnot:bool(ldloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Bestiary.IBestiaryInfoElement>[exp:bool](var_1_08)))
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

		// Token: 0x06004FFB RID: 20475 RVA: 0x0027BFF8 File Offset: 0x0027A1F8
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			bool <IsMouseHovering>k__BackingField = this.<IsMouseHovering>k__BackingField;
			if (<IsMouseHovering>k__BackingField)
			{
				if (!<IsMouseHovering>k__BackingField)
				{
				}
				string hoverText = this._icon.GetHoverText();
			}
		}

		// Token: 0x06004FFC RID: 20476 RVA: 0x0027C020 File Offset: 0x0027A220
		private void MouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
			UIImage borders = this._borders;
			base.RemoveChild(borders);
			UIImage bordersGlow = this._bordersGlow;
			base.RemoveChild(bordersGlow);
			UIImage bordersOverlay = this._bordersOverlay;
			base.RemoveChild(bordersOverlay);
			UIImage borders2 = this._borders;
			base.Append(borders2);
			UIImage bordersGlow2 = this._bordersGlow;
			base.Append(bordersGlow2);
			this._icon.ForceHover = true;
		}

		// Token: 0x06004FFD RID: 20477 RVA: 0x0027C084 File Offset: 0x0027A284
		private void MouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
			UIImage borders = this._borders;
			base.RemoveChild(borders);
			UIImage bordersGlow = this._bordersGlow;
			base.RemoveChild(bordersGlow);
			UIImage bordersOverlay = this._bordersOverlay;
			base.RemoveChild(bordersOverlay);
			UIImage bordersOverlay2 = this._bordersOverlay;
			base.Append(bordersOverlay2);
			UIImage borders2 = this._borders;
			base.Append(borders2);
			UIBestiaryEntryIcon icon = this._icon;
		}

		// Token: 0x040088DD RID: 35037
		[CompilerGenerated]
		private BestiaryEntry <Entry>k__BackingField;

		// Token: 0x040088DE RID: 35038
		private UIImage _bordersGlow;

		// Token: 0x040088DF RID: 35039
		private UIImage _bordersOverlay;

		// Token: 0x040088E0 RID: 35040
		private UIImage _borders;

		// Token: 0x040088E1 RID: 35041
		private UIBestiaryEntryIcon _icon;

		// Token: 0x02000A95 RID: 2709
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06004FFE RID: 20478 RVA: 0x0027C0E4 File Offset: 0x0027A2E4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x06004FFF RID: 20479 RVA: 0x0027C0F8 File Offset: 0x0027A2F8
			internal bool <TryGettingBackgroundImageProvider>b__2(IBestiaryBackgroundImagePathAndColorProvider provider)
			{
				IEnumerable<IPreferenceProviderElement> enumerable = this.preferences;
				bool flag;
				return flag;
			}

			// Token: 0x040088E2 RID: 35042
			public IEnumerable<IPreferenceProviderElement> preferences;
		}

		// Token: 0x02000A96 RID: 2710
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_1
		{
			// Token: 0x06005000 RID: 20480 RVA: 0x0027C110 File Offset: 0x0027A310
			public <>c__DisplayClass9_1()
			{
			}

			// Token: 0x06005001 RID: 20481 RVA: 0x0027C124 File Offset: 0x0027A324
			internal bool <TryGettingBackgroundImageProvider>b__3(IPreferenceProviderElement preference)
			{
				/*
An exception occurred when decompiling this method (06005001)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.Elements.UIBestiaryEntryButton/<>c__DisplayClass9_1::<TryGettingBackgroundImageProvider>b__3(Terraria.GameContent.Bestiary.IPreferenceProviderElement)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IBestiaryBackgroundImagePathAndColorProvider(var_0_06, ldfld:IBestiaryBackgroundImagePathAndColorProvider('<>c__DisplayClass9_1'::provider, ldloc:'<>c__DisplayClass9_1'(this)))
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

			// Token: 0x040088E3 RID: 35043
			public IBestiaryBackgroundImagePathAndColorProvider provider;
		}

		// Token: 0x02000A97 RID: 2711
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005002 RID: 20482 RVA: 0x0027C138 File Offset: 0x0027A338
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06005003 RID: 20483 RVA: 0x0027C148 File Offset: 0x0027A348
			public <>c()
			{
			}

			// Token: 0x06005004 RID: 20484 RVA: 0x000021DB File Offset: 0x000003DB
			internal bool <TryGettingBackgroundImageProvider>b__9_0(IBestiaryInfoElement x)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06005005 RID: 20485 RVA: 0x000021DB File Offset: 0x000003DB
			internal IBestiaryBackgroundImagePathAndColorProvider <TryGettingBackgroundImageProvider>b__9_1(IBestiaryInfoElement x)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06005006 RID: 20486 RVA: 0x000021DB File Offset: 0x000003DB
			internal bool <TryGettingDisplayIndex>b__10_0(IBestiaryInfoElement x)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x040088E4 RID: 35044
			public static readonly UIBestiaryEntryButton.<>c <>9;

			// Token: 0x040088E5 RID: 35045
			public static Func<IBestiaryInfoElement, bool> <>9__9_0;

			// Token: 0x040088E6 RID: 35046
			public static Func<IBestiaryInfoElement, IBestiaryBackgroundImagePathAndColorProvider> <>9__9_1;

			// Token: 0x040088E7 RID: 35047
			public static Func<IBestiaryInfoElement, bool> <>9__10_0;
		}
	}
}
