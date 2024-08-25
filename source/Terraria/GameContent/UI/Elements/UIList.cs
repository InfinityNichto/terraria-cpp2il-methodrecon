using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AC2 RID: 2754
	public class UIList : UIElement, IEnumerable<UIElement>, IEnumerable
	{
		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06005103 RID: 20739 RVA: 0x0027F23C File Offset: 0x0027D43C
		public int Count
		{
			get
			{
				return this._items._size;
			}
		}

		// Token: 0x06005104 RID: 20740 RVA: 0x0027F254 File Offset: 0x0027D454
		public UIList()
		{
			int num = 16544;
			this.ListPadding = (float)num;
			if (num == 0)
			{
			}
			base..ctor();
			UIElement innerList = this._innerList;
			UIElement innerList2 = this._innerList;
			int num2 = 1;
			this.OverflowHidden = num2 != 0;
			UIElement innerList3 = this._innerList;
			base.Append(innerList3);
		}

		// Token: 0x06005105 RID: 20741 RVA: 0x0027F2A0 File Offset: 0x0027D4A0
		public float GetTotalHeight()
		{
			/*
An exception occurred when decompiling this method (06005105)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.UI.Elements.UIList::GetTotalHeight()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(UIList::_innerListHeight, ldloc:UIList(this)))
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

		// Token: 0x06005106 RID: 20742 RVA: 0x0027F2B4 File Offset: 0x0027D4B4
		public void Goto(UIList.ElementSearchMethod searchMethod)
		{
			int size = this._items._size;
			IntPtr method_code = searchMethod.method_code;
			IntPtr invoke_impl = searchMethod.invoke_impl;
			IntPtr method = searchMethod.method;
			int size2 = this._items._size;
		}

		// Token: 0x06005107 RID: 20743 RVA: 0x000021DB File Offset: 0x000003DB
		public virtual void Add(UIElement item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005108 RID: 20744 RVA: 0x0027F318 File Offset: 0x0027D518
		public virtual bool Remove(UIElement item)
		{
			/*
An exception occurred when decompiling this method (06005108)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.Elements.UIList::Remove(Terraria.UI.UIElement)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(UIElement::RemoveChild, ldfld:UIElement(UIList::_innerList, ldloc:UIList(this)), ldloc:UIElement(item))
	call:void(UIList::UpdateOrder, ldloc:UIList(this))
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.UI.UIElement>(var_0_18, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.UI.UIElement>(UIList::_items, ldloc:UIList(this)))
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

		// Token: 0x06005109 RID: 20745 RVA: 0x000021DB File Offset: 0x000003DB
		public virtual void Clear()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600510A RID: 20746 RVA: 0x0027F340 File Offset: 0x0027D540
		public override void Recalculate()
		{
			base.Recalculate();
			if (this._scrollbar != null)
			{
				float height = this._innerDimensions.Height;
				float innerListHeight = this._innerListHeight;
				return;
			}
		}

		// Token: 0x0600510B RID: 20747 RVA: 0x0027F370 File Offset: 0x0027D570
		public override void ScrollWheel(UIScrollWheelEvent evt)
		{
			base.ScrollWheel(evt);
			UIScrollbar scrollbar = this._scrollbar;
			if (scrollbar != null)
			{
				int scrollWheelValue = evt.ScrollWheelValue;
				float viewPosition = scrollbar._viewPosition;
				float maxViewSize = scrollbar._maxViewSize;
				float viewSize = scrollbar._viewSize;
				scrollbar._viewPosition = viewPosition;
			}
		}

		// Token: 0x0600510C RID: 20748 RVA: 0x0027F3B8 File Offset: 0x0027D5B8
		public override void RecalculateChildren()
		{
			base.RecalculateChildren();
			int size = this._items._size;
			float listPadding = this.ListPadding;
			List<UIElement> items = this._items;
			List<UIElement> items2 = this._items;
			int size2 = this._items._size;
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x0027F400 File Offset: 0x0027D600
		private void UpdateScrollbar()
		{
			if (this._scrollbar != null)
			{
				float height = this._innerDimensions.Height;
				float innerListHeight = this._innerListHeight;
				return;
			}
		}

		// Token: 0x0600510E RID: 20750 RVA: 0x0027F42C File Offset: 0x0027D62C
		public void SetScrollbar(UIScrollbar scrollbar)
		{
			this._scrollbar = scrollbar;
			if (scrollbar != null)
			{
				float height = this._innerDimensions.Height;
				float innerListHeight = this._innerListHeight;
				return;
			}
		}

		// Token: 0x0600510F RID: 20751 RVA: 0x0027F458 File Offset: 0x0027D658
		public void UpdateOrder()
		{
			Action<List<UIElement>> manualSortMethod = this.ManualSortMethod;
			List<UIElement> items = this._items;
			if (manualSortMethod != null)
			{
				return;
			}
			if (this._scrollbar != null)
			{
				float height = this._innerDimensions.Height;
				float innerListHeight = this._innerListHeight;
				return;
			}
		}

		// Token: 0x06005110 RID: 20752 RVA: 0x000021DB File Offset: 0x000003DB
		public int SortMethod(UIElement item1, UIElement item2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005111 RID: 20753 RVA: 0x0027F494 File Offset: 0x0027D694
		public override List<SnapPoint> GetSnapPoints()
		{
			List<UIElement> items = this._items;
			throw new OutOfMemoryException();
		}

		// Token: 0x06005112 RID: 20754 RVA: 0x0027F4B8 File Offset: 0x0027D6B8
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			UIScrollbar scrollbar = this._scrollbar;
			if (scrollbar != null)
			{
				UIElement innerList = this._innerList;
				float viewPosition = scrollbar._viewPosition;
			}
		}

		// Token: 0x06005113 RID: 20755 RVA: 0x0027F4E0 File Offset: 0x0027D6E0
		public IEnumerator<UIElement> GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06005113)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<Terraria.UI.UIElement> Terraria.GameContent.UI.Elements.UIList::GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.UI.UIElement>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.UI.UIElement>(UIList::_items, ldloc:UIList(this)))
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

		// Token: 0x06005114 RID: 20756 RVA: 0x0027F4F4 File Offset: 0x0027D6F4
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06005114)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator Terraria.GameContent.UI.Elements.UIList::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.UI.UIElement>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.UI.UIElement>(UIList::_items, ldloc:UIList(this)))
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

		// Token: 0x040089BD RID: 35261
		protected List<UIElement> _items;

		// Token: 0x040089BE RID: 35262
		protected UIScrollbar _scrollbar;

		// Token: 0x040089BF RID: 35263
		private UIElement _innerList;

		// Token: 0x040089C0 RID: 35264
		private float _innerListHeight;

		// Token: 0x040089C1 RID: 35265
		public float ListPadding;

		// Token: 0x040089C2 RID: 35266
		public Action<List<UIElement>> ManualSortMethod;

		// Token: 0x02000AC3 RID: 2755
		public sealed class ElementSearchMethod : MulticastDelegate
		{
			// Token: 0x06005115 RID: 20757 RVA: 0x0027F508 File Offset: 0x0027D708
			public ElementSearchMethod(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06005116 RID: 20758 RVA: 0x0027F568 File Offset: 0x0027D768
			public bool Invoke(UIElement element)
			{
				/*
An exception occurred when decompiling this method (06005116)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.Elements.UIList/ElementSearchMethod::Invoke(Terraria.UI.UIElement)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:ElementSearchMethod[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:ElementSearchMethod[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:ElementSearchMethod[exp:Delegate](this)))
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

			// Token: 0x06005117 RID: 20759 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(UIElement element, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06005118 RID: 20760 RVA: 0x000021DB File Offset: 0x000003DB
			public bool EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x02000AC4 RID: 2756
		private class UIInnerList : UIElement
		{
			// Token: 0x06005119 RID: 20761 RVA: 0x0027F58C File Offset: 0x0027D78C
			public override bool ContainsPoint(Vector2 point)
			{
				return true;
			}

			// Token: 0x0600511A RID: 20762 RVA: 0x0027F59C File Offset: 0x0027D79C
			protected override void DrawChildren(SpriteBatch spriteBatch)
			{
				float x = this.<Parent>k__BackingField._dimensions.X;
				UIElement <Parent>k__BackingField = this.<Parent>k__BackingField;
				float height = <Parent>k__BackingField._dimensions.Height;
				float width = <Parent>k__BackingField._dimensions.Width;
				List<UIElement> elements = this.Elements;
				float x2 = this._dimensions.X;
				float width2 = this._dimensions.Width;
				float height2 = this._dimensions.Height;
				if (<Parent>k__BackingField == null)
				{
				}
			}

			// Token: 0x0600511B RID: 20763 RVA: 0x0027F62C File Offset: 0x0027D82C
			public override Rectangle GetViewCullingArea()
			{
				float x = this.<Parent>k__BackingField._dimensions.X;
				Rectangle rectangle;
				return rectangle;
			}

			// Token: 0x0600511C RID: 20764 RVA: 0x0027F64C File Offset: 0x0027D84C
			public UIInnerList()
			{
				if (!true)
				{
				}
				base..ctor();
			}
		}
	}
}
