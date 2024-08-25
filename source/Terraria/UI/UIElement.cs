using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;

namespace Terraria.UI
{
	// Token: 0x0200071D RID: 1821
	public class UIElement : IComparable
	{
		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06003C34 RID: 15412 RVA: 0x00235B7C File Offset: 0x00233D7C
		// (set) Token: 0x06003C35 RID: 15413 RVA: 0x00235B90 File Offset: 0x00233D90
		public UIElement Parent
		{
			[CompilerGenerated]
			get
			{
				return this.<Parent>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Parent>k__BackingField = value;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06003C36 RID: 15414 RVA: 0x00235BA4 File Offset: 0x00233DA4
		// (set) Token: 0x06003C37 RID: 15415 RVA: 0x00235BB8 File Offset: 0x00233DB8
		public int UniqueId
		{
			[CompilerGenerated]
			get
			{
				return this.<UniqueId>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<UniqueId>k__BackingField = value;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06003C38 RID: 15416 RVA: 0x00235BCC File Offset: 0x00233DCC
		public IEnumerable<UIElement> Children
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003C38)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<Terraria.UI.UIElement> Terraria.UI.UIElement::get_Children()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.UI.UIElement>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.UI.UIElement>(UIElement::Elements, ldloc:UIElement(this)))
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

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x06003C39 RID: 15417 RVA: 0x00235BE0 File Offset: 0x00233DE0
		// (remove) Token: 0x06003C3A RID: 15418 RVA: 0x00235C04 File Offset: 0x00233E04
		public event UIElement.MouseEvent OnLeftMouseDown
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnLeftMouseDown, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnLeftMouseDown, value) != null)
				{
				}
			}
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x06003C3B RID: 15419 RVA: 0x00235C28 File Offset: 0x00233E28
		// (remove) Token: 0x06003C3C RID: 15420 RVA: 0x00235C4C File Offset: 0x00233E4C
		public event UIElement.MouseEvent OnLeftMouseUp
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnLeftMouseUp, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnLeftMouseUp, value) != null)
				{
				}
			}
		}

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x06003C3D RID: 15421 RVA: 0x00235C70 File Offset: 0x00233E70
		// (remove) Token: 0x06003C3E RID: 15422 RVA: 0x00235C94 File Offset: 0x00233E94
		public event UIElement.MouseEvent OnLeftClick
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnLeftClick, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnLeftClick, value) != null)
				{
				}
			}
		}

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x06003C3F RID: 15423 RVA: 0x00235CB8 File Offset: 0x00233EB8
		// (remove) Token: 0x06003C40 RID: 15424 RVA: 0x00235CDC File Offset: 0x00233EDC
		public event UIElement.MouseEvent OnLeftDoubleClick
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnLeftDoubleClick, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnLeftDoubleClick, value) != null)
				{
				}
			}
		}

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x06003C41 RID: 15425 RVA: 0x00235D00 File Offset: 0x00233F00
		// (remove) Token: 0x06003C42 RID: 15426 RVA: 0x00235D24 File Offset: 0x00233F24
		public event UIElement.MouseEvent OnRightMouseDown
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnRightMouseDown, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnRightMouseDown, value) != null)
				{
				}
			}
		}

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x06003C43 RID: 15427 RVA: 0x00235D48 File Offset: 0x00233F48
		// (remove) Token: 0x06003C44 RID: 15428 RVA: 0x00235D6C File Offset: 0x00233F6C
		public event UIElement.MouseEvent OnRightMouseUp
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnRightMouseUp, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnRightMouseUp, value) != null)
				{
				}
			}
		}

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x06003C45 RID: 15429 RVA: 0x00235D90 File Offset: 0x00233F90
		// (remove) Token: 0x06003C46 RID: 15430 RVA: 0x00235DB4 File Offset: 0x00233FB4
		public event UIElement.MouseEvent OnRightClick
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnRightClick, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnRightClick, value) != null)
				{
				}
			}
		}

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x06003C47 RID: 15431 RVA: 0x00235DD8 File Offset: 0x00233FD8
		// (remove) Token: 0x06003C48 RID: 15432 RVA: 0x00235DFC File Offset: 0x00233FFC
		public event UIElement.MouseEvent OnRightDoubleClick
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnRightDoubleClick, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnRightDoubleClick, value) != null)
				{
				}
			}
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x06003C49 RID: 15433 RVA: 0x00235E20 File Offset: 0x00234020
		// (remove) Token: 0x06003C4A RID: 15434 RVA: 0x00235E44 File Offset: 0x00234044
		public event UIElement.MouseEvent OnMouseOver
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnMouseOver, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnMouseOver, value) != null)
				{
				}
			}
		}

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x06003C4B RID: 15435 RVA: 0x00235E68 File Offset: 0x00234068
		// (remove) Token: 0x06003C4C RID: 15436 RVA: 0x00235E8C File Offset: 0x0023408C
		public event UIElement.MouseEvent OnMouseOut
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnMouseOut, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnMouseOut, value) != null)
				{
				}
			}
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x06003C4D RID: 15437 RVA: 0x00235EB0 File Offset: 0x002340B0
		// (remove) Token: 0x06003C4E RID: 15438 RVA: 0x00235ED4 File Offset: 0x002340D4
		public event UIElement.ScrollWheelEvent OnScrollWheel
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnScrollWheel, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnScrollWheel, value) != null)
				{
				}
			}
		}

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x06003C4F RID: 15439 RVA: 0x00235EF8 File Offset: 0x002340F8
		// (remove) Token: 0x06003C50 RID: 15440 RVA: 0x00235F1C File Offset: 0x0023411C
		public event UIElement.ElementEvent OnUpdate
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.OnUpdate, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.OnUpdate, value) != null)
				{
				}
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06003C51 RID: 15441 RVA: 0x00235F40 File Offset: 0x00234140
		// (set) Token: 0x06003C52 RID: 15442 RVA: 0x00235F54 File Offset: 0x00234154
		public bool IsMouseHovering
		{
			[CompilerGenerated]
			get
			{
				return this.<IsMouseHovering>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x00235F64 File Offset: 0x00234164
		public UIElement()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x00235F7C File Offset: 0x0023417C
		public void SetSnapPoint(string name, int id, [Optional] Vector2? anchor, [Optional] Vector2? offset)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x00235F90 File Offset: 0x00234190
		public bool GetSnapPoint([Out] SnapPoint point)
		{
			/*
An exception occurred when decompiling this method (06003C55)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.UI.UIElement::GetSnapPoint(Terraria.UI.SnapPoint)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(SnapPoint::Calculate, ldloc:SnapPoint(var_1_0D), ldloc:UIElement(this))
	stloc:SnapPoint(var_2_1E, ldfld:SnapPoint(UIElement::_snapPoint, ldloc:UIElement(this)))
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

		// Token: 0x06003C56 RID: 15446 RVA: 0x00235FBC File Offset: 0x002341BC
		public virtual void ExecuteRecursively(UIElement.UIElementAction action)
		{
			IntPtr invoke_impl = action.invoke_impl;
			IntPtr method_code = action.method_code;
			IntPtr method = action.method;
			List<UIElement> elements = this.Elements;
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x00235FFC File Offset: 0x002341FC
		protected virtual void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x0023600C File Offset: 0x0023420C
		protected virtual void DrawChildren(SpriteBatch spriteBatch)
		{
			List<UIElement> elements = this.Elements;
		}

		// Token: 0x06003C59 RID: 15449 RVA: 0x000021DB File Offset: 0x000003DB
		public void Append(UIElement element)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x00236034 File Offset: 0x00234234
		public void Remove()
		{
			UIElement uielement = this.<Parent>k__BackingField;
			if (uielement != null)
			{
				uielement.RemoveChild(this);
				return;
			}
		}

		// Token: 0x06003C5B RID: 15451 RVA: 0x00236054 File Offset: 0x00234254
		public void RemoveChild(UIElement child)
		{
			List<UIElement> elements = this.Elements;
		}

		// Token: 0x06003C5C RID: 15452 RVA: 0x000021DB File Offset: 0x000003DB
		public void RemoveAllChildren()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003C5D RID: 15453 RVA: 0x00236068 File Offset: 0x00234268
		public virtual void Draw(SpriteBatch spriteBatch)
		{
			bool overflowHidden = this.OverflowHidden;
			GraphicsDevice graphicsDevice = spriteBatch.graphicsDevice;
			bool useImmediateMode = this.UseImmediateMode;
			RasterizerState rasterizerState = graphicsDevice._rasterizerState;
			Rectangle scissorRectangle = graphicsDevice._scissorRectangle;
			int width = graphicsDevice._scissorRectangle.Width;
			if (!overflowHidden)
			{
			}
			if (useImmediateMode || this.OverrideSamplerState != null)
			{
				spriteBatch.End();
				if (width == 0)
				{
				}
				SamplerState overrideSamplerState = this.OverrideSamplerState;
				if (!overflowHidden)
				{
				}
				if (overrideSamplerState == null)
				{
				}
				if (!true)
				{
				}
				spriteBatch.End();
				if (!true)
				{
				}
				if (true)
				{
					spriteBatch.End();
					Rectangle clippingRectangle = this.GetClippingRectangle(spriteBatch);
					spriteBatch.graphicsDevice.ScissorRectangle = clippingRectangle;
					GraphicsDevice graphicsDevice2 = spriteBatch.graphicsDevice;
					if (!true)
					{
					}
					if (!true)
					{
					}
					if (overrideSamplerState == null)
					{
					}
					if (!true)
					{
					}
					spriteBatch.End();
					GraphicsDevice graphicsDevice3 = spriteBatch.graphicsDevice;
					GraphicsDevice graphicsDevice4 = spriteBatch.graphicsDevice;
					return;
				}
			}
			else
			{
				GraphicsDevice graphicsDevice2;
				while (graphicsDevice2 == null)
				{
				}
			}
		}

		// Token: 0x06003C5E RID: 15454 RVA: 0x00236134 File Offset: 0x00234334
		public virtual void Update(GameTime gameTime)
		{
			UIElement.ElementEvent onUpdate = this.OnUpdate;
			if (onUpdate != null)
			{
				IntPtr invoke_impl = onUpdate.invoke_impl;
				IntPtr method_code = onUpdate.method_code;
				IntPtr method = onUpdate.method;
			}
			List<UIElement> elements = this.Elements;
		}

		// Token: 0x06003C5F RID: 15455 RVA: 0x00236180 File Offset: 0x00234380
		public Rectangle GetClippingRectangle(SpriteBatch spriteBatch)
		{
			/*
An exception occurred when decompiling this method (06003C5F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.UI.UIElement::GetClippingRectangle(Microsoft.Xna.Framework.Graphics.SpriteBatch)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0063:
	stloc:GraphicsDevice(var_13_69, ldfld:GraphicsDevice(GraphicsResource::graphicsDevice, ldloc:SpriteBatch[exp:GraphicsResource](spriteBatch)))
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

		// Token: 0x06003C60 RID: 15456 RVA: 0x002361F8 File Offset: 0x002343F8
		public virtual List<SnapPoint> GetSnapPoints()
		{
			SnapPoint snapPoint = this._snapPoint;
			if (snapPoint != null)
			{
				snapPoint.Calculate(this);
				SnapPoint snapPoint2 = this._snapPoint;
			}
			if (snapPoint != null)
			{
				snapPoint.<Position>k__BackingField.Y = snapPoint;
			}
			List<UIElement> elements = this.Elements;
			throw new OutOfMemoryException();
		}

		// Token: 0x06003C61 RID: 15457 RVA: 0x00236244 File Offset: 0x00234444
		public virtual void Recalculate()
		{
			UIElement uielement = this.<Parent>k__BackingField;
			float x;
			float y;
			float width;
			float height;
			if (uielement != null)
			{
				x = uielement._innerDimensions.X;
				y = uielement._innerDimensions.Y;
				width = uielement._innerDimensions.Width;
				height = uielement._innerDimensions.Height;
				return;
			}
			if (uielement == null)
			{
			}
			if (this.<Parent>k__BackingField != null)
			{
			}
			float marginTop = this.MarginTop;
			float marginLeft = this.MarginLeft;
			float marginRight = this.MarginRight;
			float marginBottom = this.MarginBottom;
			this._outerDimensions.X = x;
			this._outerDimensions.Y = y;
			this._outerDimensions.Width = width;
			float paddingTop = this.PaddingTop;
			float paddingLeft = this.PaddingLeft;
			float paddingRight = this.PaddingRight;
			this._outerDimensions.Height = height;
			float paddingBottom = this.PaddingBottom;
			this._dimensions.X = x;
			this._dimensions.Y = y;
			this._dimensions.Width = width;
			this._dimensions.Height = height;
			this._innerDimensions.X = x;
			this._innerDimensions.Y = y;
			this._innerDimensions.Width = width;
			this._innerDimensions.Height = height;
		}

		// Token: 0x06003C62 RID: 15458 RVA: 0x0023636C File Offset: 0x0023456C
		private CalculatedStyle GetDimensionsBasedOnParentDimensions(CalculatedStyle parentDimensions)
		{
			/*
An exception occurred when decompiling this method (06003C62)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.CalculatedStyle Terraria.UI.UIElement::GetDimensionsBasedOnParentDimensions(Terraria.UI.CalculatedStyle)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(StyleDimension::Pixels, ldfld:StyleDimension[exp:valuetype Terraria.UI.StyleDimension&](UIElement::Left, ldloc:UIElement(this))))
	stloc:float32(var_1_17, ldfld:float32(StyleDimension::Precent, ldfld:StyleDimension[exp:valuetype Terraria.UI.StyleDimension&](UIElement::Left, ldloc:UIElement(this))))
	stloc:float32(var_2_23, ldfld:float32(StyleDimension::Pixels, ldfld:StyleDimension[exp:valuetype Terraria.UI.StyleDimension&](UIElement::Top, ldloc:UIElement(this))))
	stloc:float32(var_3_2F, ldfld:float32(StyleDimension::Precent, ldfld:StyleDimension[exp:valuetype Terraria.UI.StyleDimension&](UIElement::Top, ldloc:UIElement(this))))
	stloc:float32(var_4_3B, ldfld:float32(StyleDimension::Pixels, ldfld:StyleDimension[exp:valuetype Terraria.UI.StyleDimension&](UIElement::MinWidth, ldloc:UIElement(this))))
	stloc:float32(var_5_48, ldfld:float32(StyleDimension::Precent, ldfld:StyleDimension[exp:valuetype Terraria.UI.StyleDimension&](UIElement::MinWidth, ldloc:UIElement(this))))
	stloc:float32(var_6_55, ldfld:float32(StyleDimension::Pixels, ldfld:StyleDimension[exp:valuetype Terraria.UI.StyleDimension&](UIElement::MaxWidth, ldloc:UIElement(this))))
	stloc:float32(var_7_62, ldfld:float32(StyleDimension::Precent, ldfld:StyleDimension[exp:valuetype Terraria.UI.StyleDimension&](UIElement::MaxWidth, ldloc:UIElement(this))))
	stloc:float32(var_8_6F, ldfld:float32(StyleDimension::Pixels, ldfld:StyleDimension[exp:valuetype Terraria.UI.StyleDimension&](UIElement::MinHeight, ldloc:UIElement(this))))
	stloc:float32(var_9_7C, ldfld:float32(StyleDimension::Precent, ldfld:StyleDimension[exp:valuetype Terraria.UI.StyleDimension&](UIElement::MinHeight, ldloc:UIElement(this))))
	stloc:float32(var_10_89, ldfld:float32(StyleDimension::Pixels, ldfld:StyleDimension[exp:valuetype Terraria.UI.StyleDimension&](UIElement::Width, ldloc:UIElement(this))))
	stloc:float32(var_11_96, ldfld:float32(StyleDimension::Precent, ldfld:StyleDimension[exp:valuetype Terraria.UI.StyleDimension&](UIElement::Width, ldloc:UIElement(this))))
	stloc:float32(var_12_A3, ldfld:float32(StyleDimension::Pixels, ldfld:StyleDimension[exp:valuetype Terraria.UI.StyleDimension&](UIElement::MaxHeight, ldloc:UIElement(this))))
	stloc:float32(var_13_B0, ldfld:float32(StyleDimension::Precent, ldfld:StyleDimension[exp:valuetype Terraria.UI.StyleDimension&](UIElement::MaxHeight, ldloc:UIElement(this))))
	stloc:float32(var_16_C0, ldfld:float32(StyleDimension::Pixels, ldfld:StyleDimension[exp:valuetype Terraria.UI.StyleDimension&](UIElement::Height, ldloc:UIElement(this))))
	stloc:float32(var_17_CD, ldfld:float32(StyleDimension::Precent, ldfld:StyleDimension[exp:valuetype Terraria.UI.StyleDimension&](UIElement::Height, ldloc:UIElement(this))))
	stloc:float32(var_20_D8, ldfld:float32(UIElement::MarginTop, ldloc:UIElement(this)))
	stloc:float32(var_21_E0, ldfld:float32(UIElement::MarginLeft, ldloc:UIElement(this)))
	stloc:float32(var_22_E8, ldfld:float32(UIElement::MarginRight, ldloc:UIElement(this)))
	stloc:float32(var_23_F0, ldfld:float32(UIElement::MarginBottom, ldloc:UIElement(this)))
	stloc:float32(var_24_F8, ldfld:float32(UIElement::HAlign, ldloc:UIElement(this)))
	stloc:float32(var_25_100, ldfld:float32(UIElement::VAlign, ldloc:UIElement(this)))
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

		// Token: 0x06003C63 RID: 15459 RVA: 0x0023647C File Offset: 0x0023467C
		public UIElement GetElementAt(Vector2 point)
		{
			/*
An exception occurred when decompiling this method (06003C63)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.UIElement Terraria.UI.UIElement::GetElementAt(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000D:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.UI.UIElement>(var_0_13, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.UI.UIElement>(UIElement::Elements, ldloc:UIElement(this)))
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

		// Token: 0x06003C64 RID: 15460 RVA: 0x002364A0 File Offset: 0x002346A0
		public virtual bool ContainsPoint(Vector2 point)
		{
			/*
An exception occurred when decompiling this method (06003C64)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.UI.UIElement::ContainsPoint(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(CalculatedStyle::X, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_dimensions, ldloc:UIElement(this))))
	stloc:float32(var_1_17, ldfld:float32(CalculatedStyle::Y, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_dimensions, ldloc:UIElement(this))))
	stloc:float32(var_2_23, ldfld:float32(CalculatedStyle::Width, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_dimensions, ldloc:UIElement(this))))
	stloc:float32(var_3_2F, ldfld:float32(CalculatedStyle::Height, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_dimensions, ldloc:UIElement(this))))
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

		// Token: 0x06003C65 RID: 15461 RVA: 0x002364E0 File Offset: 0x002346E0
		public virtual Rectangle GetViewCullingArea()
		{
			Rectangle rectangle;
			return rectangle;
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x002364F0 File Offset: 0x002346F0
		public void SetPadding(float pixels)
		{
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x00236500 File Offset: 0x00234700
		public virtual void RecalculateChildren()
		{
			List<UIElement> elements = this.Elements;
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x00236528 File Offset: 0x00234728
		public CalculatedStyle GetInnerDimensions()
		{
			/*
An exception occurred when decompiling this method (06003C68)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.CalculatedStyle Terraria.UI.UIElement::GetInnerDimensions()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(CalculatedStyle::X, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_innerDimensions, ldloc:UIElement(this))))
	stloc:float32(var_1_17, ldfld:float32(CalculatedStyle::Y, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_innerDimensions, ldloc:UIElement(this))))
	stloc:float32(var_2_23, ldfld:float32(CalculatedStyle::Width, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_innerDimensions, ldloc:UIElement(this))))
	stloc:float32(var_3_2F, ldfld:float32(CalculatedStyle::Height, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_innerDimensions, ldloc:UIElement(this))))
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

		// Token: 0x06003C69 RID: 15465 RVA: 0x00236564 File Offset: 0x00234764
		public CalculatedStyle GetDimensions()
		{
			/*
An exception occurred when decompiling this method (06003C69)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.CalculatedStyle Terraria.UI.UIElement::GetDimensions()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(CalculatedStyle::X, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_dimensions, ldloc:UIElement(this))))
	stloc:float32(var_1_17, ldfld:float32(CalculatedStyle::Y, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_dimensions, ldloc:UIElement(this))))
	stloc:float32(var_2_23, ldfld:float32(CalculatedStyle::Width, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_dimensions, ldloc:UIElement(this))))
	stloc:float32(var_3_2F, ldfld:float32(CalculatedStyle::Height, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_dimensions, ldloc:UIElement(this))))
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

		// Token: 0x06003C6A RID: 15466 RVA: 0x002365A0 File Offset: 0x002347A0
		public CalculatedStyle GetOuterDimensions()
		{
			/*
An exception occurred when decompiling this method (06003C6A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.CalculatedStyle Terraria.UI.UIElement::GetOuterDimensions()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(CalculatedStyle::X, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_outerDimensions, ldloc:UIElement(this))))
	stloc:float32(var_1_17, ldfld:float32(CalculatedStyle::Y, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_outerDimensions, ldloc:UIElement(this))))
	stloc:float32(var_2_23, ldfld:float32(CalculatedStyle::Width, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_outerDimensions, ldloc:UIElement(this))))
	stloc:float32(var_3_2F, ldfld:float32(CalculatedStyle::Height, ldfld:CalculatedStyle[exp:valuetype Terraria.UI.CalculatedStyle&](UIElement::_outerDimensions, ldloc:UIElement(this))))
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

		// Token: 0x06003C6B RID: 15467 RVA: 0x002365DC File Offset: 0x002347DC
		public void CopyStyle(UIElement element)
		{
			float halign = element.HAlign;
			this.HAlign = halign;
		}

		// Token: 0x06003C6C RID: 15468 RVA: 0x002365F8 File Offset: 0x002347F8
		public virtual void LeftMouseDown(UIMouseEvent evt)
		{
			UIElement.MouseEvent onLeftMouseDown = this.OnLeftMouseDown;
			if (onLeftMouseDown != null)
			{
				IntPtr invoke_impl = onLeftMouseDown.invoke_impl;
				IntPtr method_code = onLeftMouseDown.method_code;
				IntPtr method = onLeftMouseDown.method;
			}
			if (this.<Parent>k__BackingField != null)
			{
				return;
			}
		}

		// Token: 0x06003C6D RID: 15469 RVA: 0x00236630 File Offset: 0x00234830
		public virtual void LeftMouseUp(UIMouseEvent evt)
		{
			UIElement.MouseEvent onLeftMouseUp = this.OnLeftMouseUp;
			if (onLeftMouseUp != null)
			{
				IntPtr invoke_impl = onLeftMouseUp.invoke_impl;
				IntPtr method_code = onLeftMouseUp.method_code;
				IntPtr method = onLeftMouseUp.method;
			}
			if (this.<Parent>k__BackingField != null)
			{
				return;
			}
		}

		// Token: 0x06003C6E RID: 15470 RVA: 0x00236668 File Offset: 0x00234868
		public virtual void LeftClick(UIMouseEvent evt)
		{
			UIElement.MouseEvent onLeftClick = this.OnLeftClick;
			if (onLeftClick != null)
			{
				IntPtr invoke_impl = onLeftClick.invoke_impl;
				IntPtr method_code = onLeftClick.method_code;
				IntPtr method = onLeftClick.method;
			}
			if (this.<Parent>k__BackingField != null)
			{
				return;
			}
		}

		// Token: 0x06003C6F RID: 15471 RVA: 0x002366A0 File Offset: 0x002348A0
		public virtual void LeftDoubleClick(UIMouseEvent evt)
		{
			UIElement.MouseEvent onLeftDoubleClick = this.OnLeftDoubleClick;
			if (onLeftDoubleClick != null)
			{
				IntPtr invoke_impl = onLeftDoubleClick.invoke_impl;
				IntPtr method_code = onLeftDoubleClick.method_code;
				IntPtr method = onLeftDoubleClick.method;
			}
			if (this.<Parent>k__BackingField != null)
			{
				return;
			}
		}

		// Token: 0x06003C70 RID: 15472 RVA: 0x002366D8 File Offset: 0x002348D8
		public virtual void RightMouseDown(UIMouseEvent evt)
		{
			UIElement.MouseEvent onRightMouseDown = this.OnRightMouseDown;
			if (onRightMouseDown != null)
			{
				IntPtr invoke_impl = onRightMouseDown.invoke_impl;
				IntPtr method_code = onRightMouseDown.method_code;
				IntPtr method = onRightMouseDown.method;
			}
			if (this.<Parent>k__BackingField != null)
			{
				return;
			}
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x00236710 File Offset: 0x00234910
		public virtual void RightMouseUp(UIMouseEvent evt)
		{
			UIElement.MouseEvent onRightMouseUp = this.OnRightMouseUp;
			if (onRightMouseUp != null)
			{
				IntPtr invoke_impl = onRightMouseUp.invoke_impl;
				IntPtr method_code = onRightMouseUp.method_code;
				IntPtr method = onRightMouseUp.method;
			}
			if (this.<Parent>k__BackingField != null)
			{
				return;
			}
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x00236748 File Offset: 0x00234948
		public virtual void RightClick(UIMouseEvent evt)
		{
			UIElement.MouseEvent onRightClick = this.OnRightClick;
			if (onRightClick != null)
			{
				IntPtr invoke_impl = onRightClick.invoke_impl;
				IntPtr method_code = onRightClick.method_code;
				IntPtr method = onRightClick.method;
			}
			if (this.<Parent>k__BackingField != null)
			{
				return;
			}
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x00236780 File Offset: 0x00234980
		public virtual void RightDoubleClick(UIMouseEvent evt)
		{
			UIElement.MouseEvent onRightDoubleClick = this.OnRightDoubleClick;
			if (onRightDoubleClick != null)
			{
				IntPtr invoke_impl = onRightDoubleClick.invoke_impl;
				IntPtr method_code = onRightDoubleClick.method_code;
				IntPtr method = onRightDoubleClick.method;
			}
			if (this.<Parent>k__BackingField != null)
			{
				return;
			}
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x002367B8 File Offset: 0x002349B8
		public virtual void MouseOver(UIMouseEvent evt)
		{
			UIElement.MouseEvent onMouseOver = this.OnMouseOver;
			this.<IsMouseHovering>k__BackingField = true;
			if (onMouseOver != null)
			{
				IntPtr invoke_impl = onMouseOver.invoke_impl;
				IntPtr method_code = onMouseOver.method_code;
				IntPtr method = onMouseOver.method;
			}
			if (this.<Parent>k__BackingField != null)
			{
				return;
			}
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x002367F4 File Offset: 0x002349F4
		public virtual void MouseOut(UIMouseEvent evt)
		{
			UIElement.MouseEvent onMouseOut = this.OnMouseOut;
			if (onMouseOut != null)
			{
				IntPtr invoke_impl = onMouseOut.invoke_impl;
				IntPtr method_code = onMouseOut.method_code;
				IntPtr method = onMouseOut.method;
			}
			if (this.<Parent>k__BackingField != null)
			{
				return;
			}
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x0023682C File Offset: 0x00234A2C
		public virtual void ScrollWheel(UIScrollWheelEvent evt)
		{
			UIElement.ScrollWheelEvent onScrollWheel = this.OnScrollWheel;
			if (onScrollWheel != null)
			{
				IntPtr invoke_impl = onScrollWheel.invoke_impl;
				IntPtr method_code = onScrollWheel.method_code;
				IntPtr method = onScrollWheel.method;
			}
			if (this.<Parent>k__BackingField != null)
			{
				return;
			}
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x00236864 File Offset: 0x00234A64
		public void Activate()
		{
			if (!this._isInitialized)
			{
				this._isInitialized = true;
			}
			List<UIElement> elements = this.Elements;
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x0023689C File Offset: 0x00234A9C
		public virtual void OnActivate()
		{
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x002368AC File Offset: 0x00234AAC
		[Conditional("ENABLE_DEBUG")]
		[Conditional("UNITY_EDITOR")]
		public void DrawDebugHitbox(BasicDebugDrawer drawer, float colorIntensity = 0f)
		{
			bool flag = this.<IsMouseHovering>k__BackingField;
			float x = this._innerDimensions.X;
			if (!flag)
			{
			}
			List<UIElement> elements = this.Elements;
		}

		// Token: 0x06003C7A RID: 15482 RVA: 0x00236900 File Offset: 0x00234B00
		public void Deactivate()
		{
			List<UIElement> elements = this.Elements;
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x00236928 File Offset: 0x00234B28
		public virtual void OnDeactivate()
		{
		}

		// Token: 0x06003C7C RID: 15484 RVA: 0x00236938 File Offset: 0x00234B38
		public void Initialize()
		{
			this._isInitialized = true;
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x0023694C File Offset: 0x00234B4C
		public virtual void OnInitialize()
		{
		}

		// Token: 0x06003C7E RID: 15486 RVA: 0x0023695C File Offset: 0x00234B5C
		public virtual int CompareTo(object obj)
		{
		}

		// Token: 0x06003C7F RID: 15487 RVA: 0x0023696C File Offset: 0x00234B6C
		// Note: this type is marked as 'beforefieldinit'.
		static UIElement()
		{
		}

		// Token: 0x04007B86 RID: 31622
		[CompilerGenerated]
		private UIElement <Parent>k__BackingField;

		// Token: 0x04007B87 RID: 31623
		protected readonly List<UIElement> Elements;

		// Token: 0x04007B88 RID: 31624
		[CompilerGenerated]
		private int <UniqueId>k__BackingField;

		// Token: 0x04007B89 RID: 31625
		public StyleDimension Top;

		// Token: 0x04007B8A RID: 31626
		public StyleDimension Left;

		// Token: 0x04007B8B RID: 31627
		public StyleDimension Width;

		// Token: 0x04007B8C RID: 31628
		public StyleDimension Height;

		// Token: 0x04007B8D RID: 31629
		public StyleDimension MaxWidth;

		// Token: 0x04007B8E RID: 31630
		public StyleDimension MaxHeight;

		// Token: 0x04007B8F RID: 31631
		public StyleDimension MinWidth;

		// Token: 0x04007B90 RID: 31632
		public StyleDimension MinHeight;

		// Token: 0x04007B91 RID: 31633
		[CompilerGenerated]
		private UIElement.MouseEvent OnLeftMouseDown;

		// Token: 0x04007B92 RID: 31634
		[CompilerGenerated]
		private UIElement.MouseEvent OnLeftMouseUp;

		// Token: 0x04007B93 RID: 31635
		[CompilerGenerated]
		private UIElement.MouseEvent OnLeftClick;

		// Token: 0x04007B94 RID: 31636
		[CompilerGenerated]
		private UIElement.MouseEvent OnLeftDoubleClick;

		// Token: 0x04007B95 RID: 31637
		[CompilerGenerated]
		private UIElement.MouseEvent OnRightMouseDown;

		// Token: 0x04007B96 RID: 31638
		[CompilerGenerated]
		private UIElement.MouseEvent OnRightMouseUp;

		// Token: 0x04007B97 RID: 31639
		[CompilerGenerated]
		private UIElement.MouseEvent OnRightClick;

		// Token: 0x04007B98 RID: 31640
		[CompilerGenerated]
		private UIElement.MouseEvent OnRightDoubleClick;

		// Token: 0x04007B99 RID: 31641
		[CompilerGenerated]
		private UIElement.MouseEvent OnMouseOver;

		// Token: 0x04007B9A RID: 31642
		[CompilerGenerated]
		private UIElement.MouseEvent OnMouseOut;

		// Token: 0x04007B9B RID: 31643
		[CompilerGenerated]
		private UIElement.ScrollWheelEvent OnScrollWheel;

		// Token: 0x04007B9C RID: 31644
		[CompilerGenerated]
		private UIElement.ElementEvent OnUpdate;

		// Token: 0x04007B9D RID: 31645
		private bool _isInitialized;

		// Token: 0x04007B9E RID: 31646
		public bool IgnoresMouseInteraction;

		// Token: 0x04007B9F RID: 31647
		public bool OverflowHidden;

		// Token: 0x04007BA0 RID: 31648
		public SamplerState OverrideSamplerState;

		// Token: 0x04007BA1 RID: 31649
		public float PaddingTop;

		// Token: 0x04007BA2 RID: 31650
		public float PaddingLeft;

		// Token: 0x04007BA3 RID: 31651
		public float PaddingRight;

		// Token: 0x04007BA4 RID: 31652
		public float PaddingBottom;

		// Token: 0x04007BA5 RID: 31653
		public float MarginTop;

		// Token: 0x04007BA6 RID: 31654
		public float MarginLeft;

		// Token: 0x04007BA7 RID: 31655
		public float MarginRight;

		// Token: 0x04007BA8 RID: 31656
		public float MarginBottom;

		// Token: 0x04007BA9 RID: 31657
		public float HAlign;

		// Token: 0x04007BAA RID: 31658
		public float VAlign;

		// Token: 0x04007BAB RID: 31659
		private CalculatedStyle _innerDimensions;

		// Token: 0x04007BAC RID: 31660
		private CalculatedStyle _dimensions;

		// Token: 0x04007BAD RID: 31661
		private CalculatedStyle _outerDimensions;

		// Token: 0x04007BAE RID: 31662
		private static readonly RasterizerState OverflowHiddenRasterizerState;

		// Token: 0x04007BAF RID: 31663
		public bool UseImmediateMode;

		// Token: 0x04007BB0 RID: 31664
		private SnapPoint _snapPoint;

		// Token: 0x04007BB1 RID: 31665
		[CompilerGenerated]
		private bool <IsMouseHovering>k__BackingField;

		// Token: 0x04007BB2 RID: 31666
		private static int _idCounter;

		// Token: 0x0200071E RID: 1822
		public sealed class MouseEvent : MulticastDelegate
		{
			// Token: 0x06003C80 RID: 15488 RVA: 0x0023697C File Offset: 0x00234B7C
			public MouseEvent(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06003C81 RID: 15489 RVA: 0x002369DC File Offset: 0x00234BDC
			public void Invoke(UIMouseEvent evt, UIElement listeningElement)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06003C82 RID: 15490 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(UIMouseEvent evt, UIElement listeningElement, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003C83 RID: 15491 RVA: 0x00236A00 File Offset: 0x00234C00
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x0200071F RID: 1823
		public sealed class ScrollWheelEvent : MulticastDelegate
		{
			// Token: 0x06003C84 RID: 15492 RVA: 0x00236A10 File Offset: 0x00234C10
			public ScrollWheelEvent(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06003C85 RID: 15493 RVA: 0x00236A70 File Offset: 0x00234C70
			public void Invoke(UIScrollWheelEvent evt, UIElement listeningElement)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06003C86 RID: 15494 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(UIScrollWheelEvent evt, UIElement listeningElement, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003C87 RID: 15495 RVA: 0x00236A94 File Offset: 0x00234C94
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x02000720 RID: 1824
		public sealed class ElementEvent : MulticastDelegate
		{
			// Token: 0x06003C88 RID: 15496 RVA: 0x00236AA4 File Offset: 0x00234CA4
			public ElementEvent(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06003C89 RID: 15497 RVA: 0x00236B04 File Offset: 0x00234D04
			public void Invoke(UIElement affectedElement)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06003C8A RID: 15498 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(UIElement affectedElement, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003C8B RID: 15499 RVA: 0x00236B28 File Offset: 0x00234D28
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x02000721 RID: 1825
		public sealed class UIElementAction : MulticastDelegate
		{
			// Token: 0x06003C8C RID: 15500 RVA: 0x00236B38 File Offset: 0x00234D38
			public UIElementAction(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06003C8D RID: 15501 RVA: 0x00236B98 File Offset: 0x00234D98
			public void Invoke(UIElement element)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06003C8E RID: 15502 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(UIElement element, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003C8F RID: 15503 RVA: 0x00236BBC File Offset: 0x00234DBC
			public void EndInvoke(IAsyncResult result)
			{
			}
		}
	}
}
