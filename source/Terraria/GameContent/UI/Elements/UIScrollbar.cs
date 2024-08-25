using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000ACA RID: 2762
	public class UIScrollbar : UIElement
	{
		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06005130 RID: 20784 RVA: 0x0027FA9C File Offset: 0x0027DC9C
		// (set) Token: 0x06005131 RID: 20785 RVA: 0x0027FAB0 File Offset: 0x0027DCB0
		public float ViewPosition
		{
			get
			{
				/*
An exception occurred when decompiling this method (06005130)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.UI.Elements.UIScrollbar::get_ViewPosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(UIScrollbar::_viewPosition, ldloc:UIScrollbar(this)))
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
			set
			{
				float maxViewSize = this._maxViewSize;
				float viewSize = this._viewSize;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06005132 RID: 20786 RVA: 0x0027FAD0 File Offset: 0x0027DCD0
		public bool CanScroll
		{
			get
			{
				/*
An exception occurred when decompiling this method (06005132)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.Elements.UIScrollbar::get_CanScroll()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(UIScrollbar::_maxViewSize, ldloc:UIScrollbar(this)))
	stloc:float32(var_1_0D, ldfld:float32(UIScrollbar::_viewSize, ldloc:UIScrollbar(this)))
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

		// Token: 0x06005133 RID: 20787 RVA: 0x0027FAEC File Offset: 0x0027DCEC
		public void GoToBottom()
		{
			float maxViewSize = this._maxViewSize;
			float viewSize = this._viewSize;
			this._viewPosition = maxViewSize;
		}

		// Token: 0x06005134 RID: 20788 RVA: 0x0027FB10 File Offset: 0x0027DD10
		public UIScrollbar()
		{
		}

		// Token: 0x06005135 RID: 20789 RVA: 0x0027FB48 File Offset: 0x0027DD48
		public void SetView(float viewSize, float maxViewSize)
		{
			float num = MathHelper.Clamp(viewSize, maxViewSize, maxViewSize);
			float viewPosition = this._viewPosition;
			float num2 = MathHelper.Clamp(num, maxViewSize, maxViewSize);
		}

		// Token: 0x06005136 RID: 20790 RVA: 0x0027FB74 File Offset: 0x0027DD74
		public float GetValue()
		{
			/*
An exception occurred when decompiling this method (06005136)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.UI.Elements.UIScrollbar::GetValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(UIScrollbar::_viewPosition, ldloc:UIScrollbar(this)))
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

		// Token: 0x06005137 RID: 20791 RVA: 0x0027FB88 File Offset: 0x0027DD88
		private Rectangle GetHandleRectangle()
		{
			/*
An exception occurred when decompiling this method (06005137)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.GameContent.UI.Elements.UIScrollbar::GetHandleRectangle()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(UIScrollbar::_maxViewSize, ldloc:UIScrollbar(this)))
	stloc:float32(var_1_12, ldfld:float32(CalculatedStyle::X, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_innerDimensions, ldloc:UIScrollbar[exp:UIElement](this))))
	stloc:float32(var_2_1E, ldfld:float32(CalculatedStyle::Y, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_innerDimensions, ldloc:UIScrollbar[exp:UIElement](this))))
	stloc:float32(var_3_2A, ldfld:float32(CalculatedStyle::Height, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_innerDimensions, ldloc:UIScrollbar[exp:UIElement](this))))
	stloc:float32(var_4_31, ldfld:float32(UIScrollbar::_viewSize, ldloc:UIScrollbar(this)))
	stloc:float32(var_5_39, ldfld:float32(UIScrollbar::_viewPosition, ldloc:UIScrollbar(this)))
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

		// Token: 0x06005138 RID: 20792 RVA: 0x0027FBD0 File Offset: 0x0027DDD0
		private void DrawBar(SpriteBatch spriteBatch, Texture2D texture, Rectangle dimensions, Color color)
		{
			int width = texture.Width;
			int width2 = texture.Width;
			int width3 = texture.Width;
			int arraySize = texture.ArraySize;
		}

		// Token: 0x06005139 RID: 20793 RVA: 0x0027FC14 File Offset: 0x0027DE14
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			float x = this._dimensions.X;
			bool isDragging = this._isDragging;
			if (isDragging)
			{
				float y = this._innerDimensions.Y;
				float height = this._innerDimensions.Height;
				if (!isDragging)
				{
				}
				float dragYOffset = this._dragYOffset;
				float maxViewSize = this._maxViewSize;
				float viewSize = this._viewSize;
			}
			if (this.GetHandleRectangle() == null)
			{
			}
			if (!this._isHoveringOverHandle)
			{
			}
			if (this._texture == null)
			{
			}
			Asset<Texture2D> innerTexture = this._innerTexture;
			bool isHoveringOverHandle;
			if (!this._isDragging)
			{
				isHoveringOverHandle = this._isHoveringOverHandle;
				if (!isHoveringOverHandle)
				{
					return;
				}
			}
			if (!isHoveringOverHandle)
			{
			}
		}

		// Token: 0x0600513A RID: 20794 RVA: 0x0027FCA8 File Offset: 0x0027DEA8
		public override void LeftMouseDown(UIMouseEvent evt)
		{
			base.LeftMouseDown(evt);
			UIElement target = evt.Target;
			Rectangle handleRectangle = this.GetHandleRectangle();
			float x = evt.MousePosition.X;
			float y = evt.MousePosition.Y;
			this._isDragging = true;
			float y2 = evt.MousePosition.Y;
			this._dragYOffset = x;
		}

		// Token: 0x0600513B RID: 20795 RVA: 0x0027FD38 File Offset: 0x0027DF38
		public override void LeftMouseUp(UIMouseEvent evt)
		{
			base.LeftMouseUp(evt);
		}

		// Token: 0x040089D2 RID: 35282
		private float _viewPosition;

		// Token: 0x040089D3 RID: 35283
		private float _viewSize = 0f;

		// Token: 0x040089D4 RID: 35284
		private float _maxViewSize;

		// Token: 0x040089D5 RID: 35285
		private bool _isDragging;

		// Token: 0x040089D6 RID: 35286
		private bool _isHoveringOverHandle;

		// Token: 0x040089D7 RID: 35287
		private float _dragYOffset;

		// Token: 0x040089D8 RID: 35288
		private Asset<Texture2D> _texture;

		// Token: 0x040089D9 RID: 35289
		private Asset<Texture2D> _innerTexture;
	}
}
