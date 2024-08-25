using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;
using Terraria.UI;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000ACE RID: 2766
	public class UIText : UIElement
	{
		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x0600515C RID: 20828 RVA: 0x002803F0 File Offset: 0x0027E5F0
		public string Text
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600515C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.GameContent.UI.Elements.UIText::get_Text()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:object(var_0_06, ldfld:object(UIText::_text, ldloc:UIText(this)))
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
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x0600515D RID: 20829 RVA: 0x00280404 File Offset: 0x0027E604
		// (set) Token: 0x0600515E RID: 20830 RVA: 0x00280418 File Offset: 0x0027E618
		public float TextOriginX
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (0600515D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.UI.Elements.UIText::get_TextOriginX()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(UIText::<TextOriginX>k__BackingField, ldloc:UIText(this)))
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

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x0600515F RID: 20831 RVA: 0x00280428 File Offset: 0x0027E628
		// (set) Token: 0x06005160 RID: 20832 RVA: 0x0028043C File Offset: 0x0027E63C
		public float TextOriginY
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (0600515F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.UI.Elements.UIText::get_TextOriginY()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(UIText::<TextOriginY>k__BackingField, ldloc:UIText(this)))
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

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06005161 RID: 20833 RVA: 0x0028044C File Offset: 0x0027E64C
		// (set) Token: 0x06005162 RID: 20834 RVA: 0x00280460 File Offset: 0x0027E660
		public float WrappedTextBottomPadding
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (06005161)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.UI.Elements.UIText::get_WrappedTextBottomPadding()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(UIText::<WrappedTextBottomPadding>k__BackingField, ldloc:UIText(this)))
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

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06005163 RID: 20835 RVA: 0x00280470 File Offset: 0x0027E670
		// (set) Token: 0x06005164 RID: 20836 RVA: 0x00280484 File Offset: 0x0027E684
		public bool IsWrapped
		{
			get
			{
				return this._isWrapped;
			}
			set
			{
				object text = this._text;
				float textScale = this._textScale;
				bool isLarge = this._isLarge;
			}
		}

		// Token: 0x14000065 RID: 101
		// (add) Token: 0x06005165 RID: 20837 RVA: 0x002804A8 File Offset: 0x0027E6A8
		// (remove) Token: 0x06005166 RID: 20838 RVA: 0x002804CC File Offset: 0x0027E6CC
		public event Action OnInternalTextChange
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnInternalTextChange, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnInternalTextChange, value) != null)
				{
				}
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06005167 RID: 20839 RVA: 0x002804F0 File Offset: 0x0027E6F0
		// (set) Token: 0x06005168 RID: 20840 RVA: 0x00280500 File Offset: 0x0027E700
		public Color TextColor
		{
			get
			{
				Color color;
				return color;
			}
			set
			{
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06005169 RID: 20841 RVA: 0x00280510 File Offset: 0x0027E710
		// (set) Token: 0x0600516A RID: 20842 RVA: 0x00280520 File Offset: 0x0027E720
		public Color ShadowColor
		{
			get
			{
				Color color;
				return color;
			}
			set
			{
			}
		}

		// Token: 0x0600516B RID: 20843 RVA: 0x00280530 File Offset: 0x0027E730
		public UIText(string text, float textScale = 1f, bool large = false)
		{
			int num = 16256;
			this._textScale = (float)num;
			this._text = "";
			if ("" == null)
			{
			}
			if (!true)
			{
			}
			base..ctor();
			object text2 = this._text;
			float textScale2 = this._textScale;
			bool isLarge = this._isLarge;
			this.InternalSetText(text2, textScale, isLarge);
			int num2 = 16800;
			this.<WrappedTextBottomPadding>k__BackingField = (float)num2;
			this.InternalSetText(text, textScale, isLarge);
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x0028059C File Offset: 0x0027E79C
		public UIText(LocalizedText text, float textScale = 1f, bool large = false)
		{
			int num = 16256;
			this._textScale = (float)num;
			this._text = "";
			if ("" == null)
			{
			}
			if (!true)
			{
			}
			base..ctor();
			object text2 = this._text;
			float textScale2 = this._textScale;
			bool isLarge = this._isLarge;
			this.InternalSetText(text2, textScale, isLarge);
			int num2 = 16800;
			this.<WrappedTextBottomPadding>k__BackingField = (float)num2;
			this.InternalSetText(text, textScale, isLarge);
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x00280608 File Offset: 0x0027E808
		public override void Recalculate()
		{
			object text = this._text;
			float textScale = this._textScale;
			bool isLarge = this._isLarge;
			base.Recalculate();
		}

		// Token: 0x0600516E RID: 20846 RVA: 0x00280630 File Offset: 0x0027E830
		public void SetText(string text)
		{
			float textScale = this._textScale;
			bool isLarge = this._isLarge;
		}

		// Token: 0x0600516F RID: 20847 RVA: 0x0028064C File Offset: 0x0027E84C
		public void SetText(LocalizedText text)
		{
			float textScale = this._textScale;
			bool isLarge = this._isLarge;
		}

		// Token: 0x06005170 RID: 20848 RVA: 0x00280668 File Offset: 0x0027E868
		public void SetText(string text, float textScale, bool large)
		{
			this.InternalSetText(text, textScale, large);
		}

		// Token: 0x06005171 RID: 20849 RVA: 0x00280680 File Offset: 0x0027E880
		public void SetText(LocalizedText text, float textScale, bool large)
		{
			this.InternalSetText(text, textScale, large);
		}

		// Token: 0x06005172 RID: 20850 RVA: 0x00280698 File Offset: 0x0027E898
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			base.DrawSelf(spriteBatch);
			this.VerifyTextState();
			float x = this._innerDimensions.X;
			bool isLarge = this._isLarge;
			float num = this.<TextOriginX>k__BackingField;
			bool dynamicallyScaleDownToWidth = this.DynamicallyScaleDownToWidth;
			if (dynamicallyScaleDownToWidth)
			{
			}
			if (!dynamicallyScaleDownToWidth)
			{
			}
			string visibleText = this._visibleText;
			Color color = this._color;
			if (!dynamicallyScaleDownToWidth)
			{
			}
			int num2 = 17279;
			if (num2 == 0)
			{
			}
			string visibleText2 = this._visibleText;
			if (num2 == 0)
			{
			}
			TextSnippet[] array;
			ChatManager.ConvertNormalSnippets(array);
		}

		// Token: 0x06005173 RID: 20851 RVA: 0x00280714 File Offset: 0x0027E914
		private void VerifyTextState()
		{
			object text = this._text;
			string lastTextReference = this._lastTextReference;
			object text2 = this._text;
			float textScale = this._textScale;
			bool isLarge = this._isLarge;
		}

		// Token: 0x06005174 RID: 20852 RVA: 0x00280748 File Offset: 0x0027E948
		private void InternalSetText(object text, float textScale, bool large)
		{
			if (!true)
			{
			}
			this._text = text;
			bool isWrapped = this._isWrapped;
			this._lastTextReference = text;
			float width;
			if (isWrapped)
			{
				width = this._innerDimensions.Width;
				float textScale2 = this._textScale;
			}
			string text2;
			this._visibleText = text2;
			if (this._isWrapped)
			{
				float num = this.<WrappedTextBottomPadding>k__BackingField;
				return;
			}
			if (16896 == 0)
			{
			}
			float paddingLeft = this.PaddingLeft;
			float paddingRight = this.PaddingRight;
			this._textSize.X = width;
			float paddingTop = this.PaddingTop;
			float paddingBottom = this.PaddingBottom;
			Action onInternalTextChange = this.OnInternalTextChange;
			if (onInternalTextChange != null)
			{
				IntPtr invoke_impl = onInternalTextChange.invoke_impl;
				IntPtr method_code = onInternalTextChange.method_code;
				IntPtr method = onInternalTextChange.method;
			}
		}

		// Token: 0x040089ED RID: 35309
		private object _text;

		// Token: 0x040089EE RID: 35310
		private float _textScale;

		// Token: 0x040089EF RID: 35311
		private Vector2 _textSize;

		// Token: 0x040089F0 RID: 35312
		private bool _isLarge;

		// Token: 0x040089F1 RID: 35313
		private Color _color;

		// Token: 0x040089F2 RID: 35314
		private Color _shadowColor;

		// Token: 0x040089F3 RID: 35315
		private bool _isWrapped;

		// Token: 0x040089F4 RID: 35316
		[CompilerGenerated]
		private float <TextOriginX>k__BackingField;

		// Token: 0x040089F5 RID: 35317
		[CompilerGenerated]
		private float <TextOriginY>k__BackingField;

		// Token: 0x040089F6 RID: 35318
		[CompilerGenerated]
		private float <WrappedTextBottomPadding>k__BackingField;

		// Token: 0x040089F7 RID: 35319
		public bool DynamicallyScaleDownToWidth;

		// Token: 0x040089F8 RID: 35320
		private string _visibleText;

		// Token: 0x040089F9 RID: 35321
		private string _lastTextReference;

		// Token: 0x040089FA RID: 35322
		[CompilerGenerated]
		private Action OnInternalTextChange;
	}
}
