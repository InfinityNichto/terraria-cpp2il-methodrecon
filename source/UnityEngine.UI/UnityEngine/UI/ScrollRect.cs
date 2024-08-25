using System;
using Cpp2IlInjected;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000063 RID: 99
	[SelectionBase]
	[ExecuteAlways]
	[AddComponentMenu("UI/Scroll Rect", 37)]
	[RequireComponent(typeof(RectTransform))]
	[DisallowMultipleComponent]
	public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController
	{
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000C27C File Offset: 0x0000A47C
		// (set) Token: 0x060003BE RID: 958 RVA: 0x0000C290 File Offset: 0x0000A490
		public RectTransform content
		{
			get
			{
				return this.m_Content;
			}
			set
			{
				this.m_Content = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0000C2A4 File Offset: 0x0000A4A4
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
		public bool horizontal
		{
			get
			{
				return this.m_Horizontal;
			}
			set
			{
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0000C2C8 File Offset: 0x0000A4C8
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x0000C2DC File Offset: 0x0000A4DC
		public bool vertical
		{
			get
			{
				return this.m_Vertical;
			}
			set
			{
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x0000C2EC File Offset: 0x0000A4EC
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x0000C300 File Offset: 0x0000A500
		public ScrollRect.MovementType movementType
		{
			get
			{
				return this.m_MovementType;
			}
			set
			{
				this.m_MovementType = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x0000C314 File Offset: 0x0000A514
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x0000C328 File Offset: 0x0000A528
		public float elasticity
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003C5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.ScrollRect::get_elasticity()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(ScrollRect::m_Elasticity, ldloc:ScrollRect(this)))
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
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x0000C338 File Offset: 0x0000A538
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x0000C34C File Offset: 0x0000A54C
		public bool inertia
		{
			get
			{
				return this.m_Inertia;
			}
			set
			{
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0000C35C File Offset: 0x0000A55C
		// (set) Token: 0x060003CA RID: 970 RVA: 0x0000C370 File Offset: 0x0000A570
		public float decelerationRate
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.ScrollRect::get_decelerationRate()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(ScrollRect::m_DecelerationRate, ldloc:ScrollRect(this)))
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
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0000C380 File Offset: 0x0000A580
		// (set) Token: 0x060003CC RID: 972 RVA: 0x0000C394 File Offset: 0x0000A594
		public float scrollSensitivity
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003CB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.ScrollRect::get_scrollSensitivity()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(ScrollRect::m_ScrollSensitivity, ldloc:ScrollRect(this)))
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
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
		// (set) Token: 0x060003CE RID: 974 RVA: 0x0000C3B8 File Offset: 0x0000A5B8
		public RectTransform viewport
		{
			get
			{
				return this.m_Viewport;
			}
			set
			{
				this.m_Viewport = value;
				this.SetDirtyCaching();
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x0000C3E8 File Offset: 0x0000A5E8
		public Scrollbar horizontalScrollbar
		{
			get
			{
				return this.m_HorizontalScrollbar;
			}
			set
			{
				Scrollbar horizontalScrollbar = this.m_HorizontalScrollbar;
				if (!true)
				{
				}
				bool flag = horizontalScrollbar;
				Scrollbar horizontalScrollbar2 = this.m_HorizontalScrollbar;
				Scrollbar.ScrollEvent onValueChanged = horizontalScrollbar2.m_OnValueChanged;
				this.m_HorizontalScrollbar = value;
				if (horizontalScrollbar2 == null)
				{
				}
				bool flag2 = value;
				Scrollbar.ScrollEvent onValueChanged2 = this.m_HorizontalScrollbar.m_OnValueChanged;
				this.SetDirtyCaching();
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0000C43C File Offset: 0x0000A63C
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x0000C450 File Offset: 0x0000A650
		public Scrollbar verticalScrollbar
		{
			get
			{
				return this.m_VerticalScrollbar;
			}
			set
			{
				Scrollbar verticalScrollbar = this.m_VerticalScrollbar;
				if (!true)
				{
				}
				bool flag = verticalScrollbar;
				Scrollbar verticalScrollbar2 = this.m_VerticalScrollbar;
				Scrollbar.ScrollEvent onValueChanged = verticalScrollbar2.m_OnValueChanged;
				this.m_VerticalScrollbar = value;
				if (verticalScrollbar2 == null)
				{
				}
				bool flag2 = value;
				Scrollbar.ScrollEvent onValueChanged2 = this.m_VerticalScrollbar.m_OnValueChanged;
				this.SetDirtyCaching();
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x0000C4A4 File Offset: 0x0000A6A4
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x0000C4B8 File Offset: 0x0000A6B8
		public ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility
		{
			get
			{
				return this.m_HorizontalScrollbarVisibility;
			}
			set
			{
				this.m_HorizontalScrollbarVisibility = value;
				this.SetDirtyCaching();
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x0000C4D4 File Offset: 0x0000A6D4
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x0000C4E8 File Offset: 0x0000A6E8
		public ScrollRect.ScrollbarVisibility verticalScrollbarVisibility
		{
			get
			{
				return this.m_VerticalScrollbarVisibility;
			}
			set
			{
				this.m_VerticalScrollbarVisibility = value;
				this.SetDirtyCaching();
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0000C504 File Offset: 0x0000A704
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x0000C518 File Offset: 0x0000A718
		public float horizontalScrollbarSpacing
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003D7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.ScrollRect::get_horizontalScrollbarSpacing()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(ScrollRect::m_HorizontalScrollbarSpacing, ldloc:ScrollRect(this)))
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
				this.SetDirty();
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x0000C52C File Offset: 0x0000A72C
		// (set) Token: 0x060003DA RID: 986 RVA: 0x0000C540 File Offset: 0x0000A740
		public float verticalScrollbarSpacing
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003D9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.ScrollRect::get_verticalScrollbarSpacing()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(ScrollRect::m_VerticalScrollbarSpacing, ldloc:ScrollRect(this)))
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
				this.SetDirty();
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003DB RID: 987 RVA: 0x0000C554 File Offset: 0x0000A754
		// (set) Token: 0x060003DC RID: 988 RVA: 0x0000C568 File Offset: 0x0000A768
		public ScrollRect.ScrollRectEvent onValueChanged
		{
			get
			{
				return this.m_OnValueChanged;
			}
			set
			{
				this.m_OnValueChanged = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0000C57C File Offset: 0x0000A77C
		protected RectTransform viewRect
		{
			get
			{
				RectTransform viewRect = this.m_ViewRect;
				if (!true)
				{
				}
				RectTransform viewport = this.m_Viewport;
				this.m_ViewRect = viewport;
				RectTransform viewRect2 = this.m_ViewRect;
				if (!true)
				{
				}
				Transform transform = base.transform;
				if (transform != null)
				{
					this.m_ViewRect = transform;
					throw new InvalidCastException();
				}
				RectTransform rectTransform;
				this.m_ViewRect = rectTransform;
				return rectTransform;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0000C5DC File Offset: 0x0000A7DC
		// (set) Token: 0x060003DF RID: 991 RVA: 0x0000C604 File Offset: 0x0000A804
		public Vector2 velocity
		{
			get
			{
				float x = this.m_Velocity.x;
				float y = this.m_Velocity.y;
				Vector2 vector;
				return vector;
			}
			set
			{
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0000C614 File Offset: 0x0000A814
		private RectTransform rectTransform
		{
			get
			{
				RectTransform rect = this.m_Rect;
				if (!true)
				{
				}
				RectTransform component = base.GetComponent<RectTransform>();
				this.m_Rect = component;
				return component;
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000C644 File Offset: 0x0000A844
		protected ScrollRect()
		{
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000C66C File Offset: 0x0000A86C
		public virtual void Rebuild(CanvasUpdate executing)
		{
			if (executing == CanvasUpdate.Prelayout)
			{
				this.UpdateCachedData();
				return;
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000C698 File Offset: 0x0000A898
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000C6B8 File Offset: 0x0000A8B8
		private void UpdateCachedData()
		{
			Transform transform = base.transform;
			Scrollbar horizontalScrollbar = this.m_HorizontalScrollbar;
			if (this.m_HorizontalScrollbar.transform != null)
			{
				return;
			}
			long num = 0L;
			this.m_HorizontalScrollbarRect = num;
			Scrollbar verticalScrollbar = this.m_VerticalScrollbar;
			if (num == 0L)
			{
			}
			if (this.m_VerticalScrollbar.transform != null)
			{
				return;
			}
			long num2 = 0L;
			this.m_VerticalScrollbarRect = num2;
			bool flag = this.viewRect.parent == transform;
			bool flag2 = this.m_HorizontalScrollbarRect;
			bool flag3 = this.m_HorizontalScrollbarRect.parent == transform;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
		protected override void OnEnable()
		{
			base.OnEnable();
			Scrollbar horizontalScrollbar = this.m_HorizontalScrollbar;
			if (!true)
			{
			}
			bool flag = horizontalScrollbar;
			Scrollbar horizontalScrollbar2 = this.m_HorizontalScrollbar;
			Scrollbar.ScrollEvent onValueChanged = horizontalScrollbar2.m_OnValueChanged;
			Scrollbar verticalScrollbar = this.m_VerticalScrollbar;
			if (horizontalScrollbar2 == null)
			{
			}
			bool flag2 = verticalScrollbar;
			Scrollbar verticalScrollbar2 = this.m_VerticalScrollbar;
			Scrollbar.ScrollEvent onValueChanged2 = verticalScrollbar2.m_OnValueChanged;
			if (verticalScrollbar2 == null)
			{
			}
			CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild(this);
			this.SetDirty();
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000C85C File Offset: 0x0000AA5C
		protected override void OnDisable()
		{
			int num = 1;
			if (num == 0)
			{
			}
			CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(this);
			Scrollbar horizontalScrollbar = this.m_HorizontalScrollbar;
			if (num == 0)
			{
			}
			bool flag = horizontalScrollbar;
			Scrollbar horizontalScrollbar2 = this.m_HorizontalScrollbar;
			Scrollbar.ScrollEvent onValueChanged = horizontalScrollbar2.m_OnValueChanged;
			Scrollbar verticalScrollbar = this.m_VerticalScrollbar;
			if (horizontalScrollbar2 == null)
			{
			}
			bool flag2 = verticalScrollbar;
			Scrollbar.ScrollEvent onValueChanged2 = this.m_VerticalScrollbar.m_OnValueChanged;
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			base.OnDisable();
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000C8C8 File Offset: 0x0000AAC8
		public override bool IsActive()
		{
			bool flag = base.IsActive();
			RectTransform content = this.m_Content;
			bool flag2;
			return flag2;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		private void EnsureLayoutHasRebuilt()
		{
			if (!this.m_HasRebuiltLayout)
			{
				bool flag = CanvasUpdateRegistry.IsRebuildingLayout();
			}
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000C910 File Offset: 0x0000AB10
		public virtual void StopMovement()
		{
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000C920 File Offset: 0x0000AB20
		public virtual void OnScroll(PointerEventData data)
		{
			this.EnsureLayoutHasRebuilt();
			this.UpdateBounds();
			float y = data.<scrollDelta>k__BackingField.y;
			float x = data.<scrollDelta>k__BackingField.x;
			bool vertical = this.m_Vertical;
			bool horizontal = this.m_Horizontal;
			if (vertical)
			{
				if (horizontal)
				{
					return;
				}
				return;
			}
			else
			{
				if (!vertical && horizontal)
				{
					return;
				}
				bool flag = data.IsScrolling();
				int num = 1;
				this.m_Scrolling = num != 0;
				Vector2 anchoredPosition = this.m_Content.anchoredPosition;
				float scrollSensitivity = this.m_ScrollSensitivity;
				ScrollRect.MovementType movementType = this.m_MovementType;
				Vector2 anchoredPosition2 = this.m_Content.anchoredPosition;
				bool horizontal2 = this.m_Horizontal;
				bool vertical2 = this.m_Vertical;
				ScrollRect.MovementType movementType2 = this.m_MovementType;
				this.UpdateBounds();
				return;
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000C9CC File Offset: 0x0000ABCC
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			if (eventData.<button>k__BackingField == PointerEventData.InputButton.Left)
			{
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000C9E4 File Offset: 0x0000ABE4
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
			if (eventData.<button>k__BackingField == PointerEventData.InputButton.Left)
			{
				this.UpdateBounds();
				RectTransform viewRect = this.viewRect;
				float x = eventData.<position>k__BackingField.x;
				float y = eventData.<position>k__BackingField.y;
				Camera pressEventCamera = eventData.pressEventCamera;
				Vector2 anchoredPosition = this.m_Content.anchoredPosition;
				this.m_Dragging = true;
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000CA3C File Offset: 0x0000AC3C
		public virtual void OnEndDrag(PointerEventData eventData)
		{
			if (eventData.<button>k__BackingField != PointerEventData.InputButton.Left)
			{
				return;
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000CA54 File Offset: 0x0000AC54
		public virtual void OnDrag(PointerEventData eventData)
		{
			if (this.m_Dragging && eventData.<button>k__BackingField == PointerEventData.InputButton.Left)
			{
				RectTransform viewRect = this.viewRect;
				float x = eventData.<position>k__BackingField.x;
				float y = eventData.<position>k__BackingField.y;
				Camera pressEventCamera = eventData.pressEventCamera;
				this.UpdateBounds();
				float x2 = this.m_PointerStartLocalCursor.x;
				float y2 = this.m_PointerStartLocalCursor.y;
				Vector2 anchoredPosition = this.m_Content.anchoredPosition;
				bool horizontal = this.m_Horizontal;
				bool vertical = this.m_Vertical;
				ScrollRect.MovementType movementType = this.m_MovementType;
				ScrollRect.MovementType movementType2 = this.m_MovementType;
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000CAE4 File Offset: 0x0000ACE4
		protected virtual void SetContentAnchoredPosition(Vector2 position)
		{
			if (!this.m_Horizontal)
			{
				Vector2 anchoredPosition = this.m_Content.anchoredPosition;
			}
			if (!this.m_Vertical)
			{
				Vector2 anchoredPosition2 = this.m_Content.anchoredPosition;
			}
			Vector2 anchoredPosition3 = this.m_Content.anchoredPosition;
			RectTransform content = this.m_Content;
			this.UpdateBounds();
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000CB34 File Offset: 0x0000AD34
		protected virtual void LateUpdate()
		{
			int num = 1;
			RectTransform content = this.m_Content;
			if (num == 0)
			{
			}
			bool flag = content;
			this.EnsureLayoutHasRebuilt();
			this.UpdateBounds();
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			bool horizontal = this.m_Horizontal;
			bool vertical = this.m_Vertical;
			ScrollRect.MovementType movementType = this.m_MovementType;
			if (this.m_Dragging)
			{
				if (this.m_Inertia)
				{
					Vector2 anchoredPosition = this.m_Content.anchoredPosition;
					float x = this.m_Velocity.x;
					float num2;
					this.m_Velocity.x = num2;
				}
				IntPtr cachedPtr = content.m_CachedPtr;
				Vector2 anchoredPosition2 = this.m_Content.anchoredPosition;
				float x2 = this.m_PrevPosition.x;
				float y = this.m_PrevPosition.y;
				UISystemProfilerApi.AddMarker("ScrollRect.value", this);
				ScrollRect.ScrollRectEvent onValueChanged = this.m_OnValueChanged;
				float horizontalNormalizedPosition = this.horizontalNormalizedPosition;
				float verticalNormalizedPosition = this.verticalNormalizedPosition;
				this.UpdatePrevData();
				this.UpdateScrollbarVisibility();
				return;
			}
			float x3 = this.m_Velocity.x;
			float y2 = this.m_Velocity.y;
			Vector2 anchoredPosition3 = this.m_Content.anchoredPosition;
			ScrollRect.MovementType movementType2 = this.m_MovementType;
			if (!this.m_Inertia)
			{
				return;
			}
			float decelerationRate = this.m_DecelerationRate;
			float x4 = this.m_Velocity.x;
			this.m_Velocity.x = decelerationRate;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000CD84 File Offset: 0x0000AF84
		protected void UpdatePrevData()
		{
			RectTransform content = this.m_Content;
			if (!true)
			{
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000CDD8 File Offset: 0x0000AFD8
		private void UpdateScrollbars(Vector2 offset)
		{
			int num = 1;
			Scrollbar horizontalScrollbar = this.m_HorizontalScrollbar;
			if (num == 0)
			{
			}
			bool flag = horizontalScrollbar;
			Scrollbar horizontalScrollbar2 = this.m_HorizontalScrollbar;
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0000CE64 File Offset: 0x0000B064
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x0000CE80 File Offset: 0x0000B080
		public Vector2 normalizedPosition
		{
			get
			{
				float horizontalNormalizedPosition = this.horizontalNormalizedPosition;
				float verticalNormalizedPosition = this.verticalNormalizedPosition;
				Vector2 vector;
				return vector;
			}
			set
			{
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0000CE90 File Offset: 0x0000B090
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x0000CEA4 File Offset: 0x0000B0A4
		public float horizontalNormalizedPosition
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003F6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.ScrollRect::get_horizontalNormalizedPosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ScrollRect::UpdateBounds, ldloc:ScrollRect(this))
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
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0000CEB4 File Offset: 0x0000B0B4
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x0000CEC8 File Offset: 0x0000B0C8
		public float verticalNormalizedPosition
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003F8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.ScrollRect::get_verticalNormalizedPosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ScrollRect::UpdateBounds, ldloc:ScrollRect(this))
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
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000CED8 File Offset: 0x0000B0D8
		private void SetHorizontalNormalizedPosition(float value)
		{
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		private void SetVerticalNormalizedPosition(float value)
		{
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000CEF8 File Offset: 0x0000B0F8
		protected virtual void SetNormalizedPosition(float value, int axis)
		{
			this.EnsureLayoutHasRebuilt();
			this.UpdateBounds();
			if (axis != 0)
			{
				Vector2 anchoredPosition = this.m_Content.anchoredPosition;
				Vector2 anchoredPosition2 = this.m_Content.anchoredPosition;
				return;
			}
			Vector2 anchoredPosition3 = this.m_Content.anchoredPosition;
			Vector2 anchoredPosition4 = this.m_Content.anchoredPosition;
			if (axis != 0)
			{
				RectTransform content = this.m_Content;
				return;
			}
			RectTransform content2 = this.m_Content;
			this.UpdateBounds();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00002207 File Offset: 0x00000407
		private static float RubberDelta(float overStretching, float viewSize)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000CF74 File Offset: 0x0000B174
		protected override void OnRectTransformDimensionsChange()
		{
			this.SetDirty();
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0000CF88 File Offset: 0x0000B188
		private bool hScrollingNeeded
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003FF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.ScrollRect::get_hScrollingNeeded()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_1_07, callgetter:bool(Application::get_isPlaying))
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0000CFA0 File Offset: 0x0000B1A0
		private bool vScrollingNeeded
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000400)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.ScrollRect::get_vScrollingNeeded()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_1_07, callgetter:bool(Application::get_isPlaying))
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

		// Token: 0x06000401 RID: 1025 RVA: 0x0000CFB8 File Offset: 0x0000B1B8
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000CFC8 File Offset: 0x0000B1C8
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x00002207 File Offset: 0x00000407
		public virtual float minWidth
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00002207 File Offset: 0x00000407
		public virtual float preferredWidth
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00002207 File Offset: 0x00000407
		public virtual float flexibleWidth
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00002207 File Offset: 0x00000407
		public virtual float minHeight
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x00002207 File Offset: 0x00000407
		public virtual float preferredHeight
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00002207 File Offset: 0x00000407
		public virtual float flexibleHeight
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x00002207 File Offset: 0x00000407
		public virtual int layoutPriority
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
		public virtual void SetLayoutHorizontal()
		{
			this.UpdateCachedData();
			if (this.m_HSliderExpand || this.m_VSliderExpand)
			{
				RectTransform viewRect = this.viewRect;
				RectTransform viewRect2 = this.viewRect;
				RectTransform viewRect3 = this.viewRect;
				RectTransform viewRect4 = this.viewRect;
				RectTransform viewRect5 = this.viewRect;
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.m_Content);
				Vector2 center = this.viewRect.rect.center;
				Vector2 size = this.viewRect.rect.size;
				Bounds bounds = this.GetBounds();
				bool vsliderExpand = this.m_VSliderExpand;
				if (vsliderExpand)
				{
					bool vScrollingNeeded = this.vScrollingNeeded;
					RectTransform viewRect6 = this.viewRect;
					float vsliderWidth = this.m_VSliderWidth;
					float verticalScrollbarSpacing = this.m_VerticalScrollbarSpacing;
					Vector2 sizeDelta = this.viewRect.sizeDelta;
					RectTransform content = this.m_Content;
					if (!vsliderExpand)
					{
					}
					LayoutRebuilder.ForceRebuildLayoutImmediate(content);
					Vector2 center2 = this.viewRect.rect.center;
					Vector2 size2 = this.viewRect.rect.size;
					this.m_ViewBounds.m_Extents.y = vsliderExpand;
					Bounds bounds2 = this.GetBounds();
					this.m_ContentBounds.m_Extents.y = vsliderExpand;
					return;
				}
			}
			bool hsliderExpand = this.m_HSliderExpand;
			if (hsliderExpand)
			{
				bool hScrollingNeeded = this.hScrollingNeeded;
				RectTransform viewRect7 = this.viewRect;
				Vector2 sizeDelta2 = this.viewRect.sizeDelta;
				float hsliderHeight = this.m_HSliderHeight;
				float horizontalScrollbarSpacing = this.m_HorizontalScrollbarSpacing;
				Vector2 center3 = this.viewRect.rect.center;
				Vector2 size3 = this.viewRect.rect.size;
				this.m_ViewBounds.m_Extents.y = hsliderExpand;
				Bounds bounds3 = this.GetBounds();
				this.m_ContentBounds.m_Extents.y = hsliderExpand;
			}
			bool vScrollingNeeded2 = this.vScrollingNeeded;
			Vector2 sizeDelta3 = this.viewRect.sizeDelta;
			Vector2 sizeDelta4 = this.viewRect.sizeDelta;
			RectTransform viewRect8 = this.viewRect;
			float vsliderWidth2 = this.m_VSliderWidth;
			float verticalScrollbarSpacing2 = this.m_VerticalScrollbarSpacing;
			Vector2 sizeDelta5 = this.viewRect.sizeDelta;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000D1CC File Offset: 0x0000B3CC
		public virtual void SetLayoutVertical()
		{
			this.UpdateScrollbarLayout();
			Vector2 center = this.viewRect.rect.center;
			Vector2 size = this.viewRect.rect.size;
			Bounds bounds = this.GetBounds();
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000D208 File Offset: 0x0000B408
		private void UpdateScrollbarVisibility()
		{
			bool vScrollingNeeded = this.vScrollingNeeded;
			bool vertical = this.m_Vertical;
			ScrollRect.ScrollbarVisibility verticalScrollbarVisibility = this.m_VerticalScrollbarVisibility;
			Scrollbar verticalScrollbar = this.m_VerticalScrollbar;
			ScrollRect.UpdateOneScrollbarVisibility(vScrollingNeeded, vertical, verticalScrollbarVisibility, verticalScrollbar);
			bool hScrollingNeeded = this.hScrollingNeeded;
			bool horizontal = this.m_Horizontal;
			ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility = this.m_HorizontalScrollbarVisibility;
			Scrollbar horizontalScrollbar = this.m_HorizontalScrollbar;
			ScrollRect.UpdateOneScrollbarVisibility(hScrollingNeeded, horizontal, horizontalScrollbarVisibility, horizontalScrollbar);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000D268 File Offset: 0x0000B468
		private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar)
		{
			if (!true)
			{
			}
			bool flag = scrollbar;
			bool activeSelf = scrollbar.gameObject.activeSelf;
			if (scrollbarVisibility != ScrollRect.ScrollbarVisibility.Permanent)
			{
				GameObject gameObject = scrollbar.gameObject;
				return;
			}
			long num = 0L;
			scrollbar.gameObject.SetActive(num != 0L);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		private void UpdateScrollbarLayout()
		{
			bool vsliderExpand = this.m_VSliderExpand;
			if (vsliderExpand)
			{
				Scrollbar horizontalScrollbar = this.m_HorizontalScrollbar;
				if (!vsliderExpand)
				{
				}
				bool flag = horizontalScrollbar;
				RectTransform horizontalScrollbarRect = this.m_HorizontalScrollbarRect;
				Vector2 anchorMin = this.m_HorizontalScrollbarRect.anchorMin;
				Vector2 anchorMax = this.m_HorizontalScrollbarRect.anchorMax;
				Vector2 anchoredPosition = this.m_HorizontalScrollbarRect.anchoredPosition;
				bool vScrollingNeeded = this.vScrollingNeeded;
				RectTransform horizontalScrollbarRect2 = this.m_HorizontalScrollbarRect;
				float vsliderWidth = this.m_VSliderWidth;
				float verticalScrollbarSpacing = this.m_VerticalScrollbarSpacing;
				Vector2 sizeDelta = horizontalScrollbarRect2.sizeDelta;
				return;
			}
			bool hsliderExpand = this.m_HSliderExpand;
			if (hsliderExpand)
			{
				Scrollbar verticalScrollbar = this.m_VerticalScrollbar;
				if (!hsliderExpand)
				{
				}
				bool flag2 = verticalScrollbar;
				RectTransform verticalScrollbarRect = this.m_VerticalScrollbarRect;
				Vector2 anchorMin2 = this.m_VerticalScrollbarRect.anchorMin;
				Vector2 anchorMax2 = this.m_VerticalScrollbarRect.anchorMax;
				Vector2 anchoredPosition2 = this.m_VerticalScrollbarRect.anchoredPosition;
				bool hScrollingNeeded = this.hScrollingNeeded;
				Vector2 sizeDelta2 = this.m_VerticalScrollbarRect.sizeDelta;
				float hsliderHeight = this.m_HSliderHeight;
				float horizontalScrollbarSpacing = this.m_HorizontalScrollbarSpacing;
				return;
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000D3A8 File Offset: 0x0000B5A8
		protected void UpdateBounds()
		{
			int num = 1;
			Vector2 center = this.viewRect.rect.center;
			Vector2 size = this.viewRect.rect.size;
			this.m_ViewBounds.m_Extents.y = (float)num;
			Bounds bounds = this.GetBounds();
			this.m_ContentBounds.m_Extents.y = (float)num;
			RectTransform content = this.m_Content;
			if (num == 0)
			{
			}
			Vector2 pivot = this.m_Content.pivot;
			ScrollRect.MovementType movementType = this.m_MovementType;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000D468 File Offset: 0x0000B668
		internal static void AdjustBounds(Bounds viewBounds, Vector2 contentPivot, Vector3 contentSize, Vector3 contentPos)
		{
			Vector3 size = viewBounds.size;
			float x = contentSize.x;
			float y = contentSize.y;
			Vector3 size2 = viewBounds.size;
			float y2 = contentPivot.y;
			float y3 = contentPos.y;
			contentPos.y = y2;
			Vector3 size3 = viewBounds.size;
			contentSize.y = y3;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000D4BC File Offset: 0x0000B6BC
		private Bounds GetBounds()
		{
			RectTransform content = this.m_Content;
			if (!true)
			{
			}
			RectTransform content2 = this.m_Content;
			Vector3[] corners = this.m_Corners;
			content2.GetWorldCorners(corners);
			Matrix4x4 worldToLocalMatrix = this.viewRect.worldToLocalMatrix;
			Vector3[] corners2 = this.m_Corners;
			Bounds bounds;
			return bounds;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000D500 File Offset: 0x0000B700
		internal static Bounds InternalGetBounds(Vector3[] corners, Matrix4x4 viewWorldToLocalMatrix)
		{
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000D510 File Offset: 0x0000B710
		private Vector2 CalculateOffset(Vector2 delta)
		{
			bool horizontal = this.m_Horizontal;
			bool vertical = this.m_Vertical;
			ScrollRect.MovementType movementType = this.m_MovementType;
			Vector2 vector;
			return vector;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000D534 File Offset: 0x0000B734
		internal static Vector2 InternalCalculateOffset(Bounds viewBounds, Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, Vector2 delta)
		{
			/*
An exception occurred when decompiling this method (06000414)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector2 UnityEngine.UI.ScrollRect::InternalCalculateOffset(UnityEngine.Bounds,UnityEngine.Bounds,System.Boolean,System.Boolean,UnityEngine.UI.ScrollRect/MovementType,UnityEngine.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0020:
	stloc:float32(var_4_27, ldfld:float32(Vector2::y, ldloc:Vector2[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector2&](delta)))
	stloc:Vector3(var_5_2F, callgetter:Vector3(Bounds::get_max, ldloc:Bounds[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Bounds&](viewBounds)))
	stloc:Vector3(var_6_37, callgetter:Vector3(Bounds::get_min, ldloc:Bounds[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Bounds&](viewBounds)))
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

		// Token: 0x06000415 RID: 1045 RVA: 0x0000D57C File Offset: 0x0000B77C
		protected void SetDirty()
		{
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000D598 File Offset: 0x0000B798
		protected void SetDirtyCaching()
		{
			CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild(this);
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000D5B8 File Offset: 0x0000B7B8
		Transform ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x040001D4 RID: 468
		[SerializeField]
		private RectTransform m_Content;

		// Token: 0x040001D5 RID: 469
		[SerializeField]
		private bool m_Horizontal = 257 != 0;

		// Token: 0x040001D6 RID: 470
		[SerializeField]
		private bool m_Vertical;

		// Token: 0x040001D7 RID: 471
		[SerializeField]
		private ScrollRect.MovementType m_MovementType;

		// Token: 0x040001D8 RID: 472
		[SerializeField]
		private float m_Elasticity;

		// Token: 0x040001D9 RID: 473
		[SerializeField]
		private bool m_Inertia = true;

		// Token: 0x040001DA RID: 474
		[SerializeField]
		private float m_DecelerationRate;

		// Token: 0x040001DB RID: 475
		[SerializeField]
		private float m_ScrollSensitivity;

		// Token: 0x040001DC RID: 476
		[SerializeField]
		private RectTransform m_Viewport;

		// Token: 0x040001DD RID: 477
		[SerializeField]
		private Scrollbar m_HorizontalScrollbar;

		// Token: 0x040001DE RID: 478
		[SerializeField]
		private Scrollbar m_VerticalScrollbar;

		// Token: 0x040001DF RID: 479
		[SerializeField]
		private ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility;

		// Token: 0x040001E0 RID: 480
		[SerializeField]
		private ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility;

		// Token: 0x040001E1 RID: 481
		[SerializeField]
		private float m_HorizontalScrollbarSpacing;

		// Token: 0x040001E2 RID: 482
		[SerializeField]
		private float m_VerticalScrollbarSpacing;

		// Token: 0x040001E3 RID: 483
		[SerializeField]
		private ScrollRect.ScrollRectEvent m_OnValueChanged;

		// Token: 0x040001E4 RID: 484
		private Vector2 m_PointerStartLocalCursor;

		// Token: 0x040001E5 RID: 485
		protected Vector2 m_ContentStartPosition;

		// Token: 0x040001E6 RID: 486
		private RectTransform m_ViewRect;

		// Token: 0x040001E7 RID: 487
		protected Bounds m_ContentBounds;

		// Token: 0x040001E8 RID: 488
		private Bounds m_ViewBounds;

		// Token: 0x040001E9 RID: 489
		private Vector2 m_Velocity;

		// Token: 0x040001EA RID: 490
		private bool m_Dragging;

		// Token: 0x040001EB RID: 491
		private bool m_Scrolling;

		// Token: 0x040001EC RID: 492
		private Vector2 m_PrevPosition;

		// Token: 0x040001ED RID: 493
		private Bounds m_PrevContentBounds;

		// Token: 0x040001EE RID: 494
		private Bounds m_PrevViewBounds;

		// Token: 0x040001EF RID: 495
		[NonSerialized]
		private bool m_HasRebuiltLayout;

		// Token: 0x040001F0 RID: 496
		private bool m_HSliderExpand;

		// Token: 0x040001F1 RID: 497
		private bool m_VSliderExpand;

		// Token: 0x040001F2 RID: 498
		private float m_HSliderHeight;

		// Token: 0x040001F3 RID: 499
		private float m_VSliderWidth;

		// Token: 0x040001F4 RID: 500
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x040001F5 RID: 501
		private RectTransform m_HorizontalScrollbarRect;

		// Token: 0x040001F6 RID: 502
		private RectTransform m_VerticalScrollbarRect;

		// Token: 0x040001F7 RID: 503
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x040001F8 RID: 504
		private readonly Vector3[] m_Corners;

		// Token: 0x02000064 RID: 100
		public enum MovementType
		{
			// Token: 0x040001FA RID: 506
			Unrestricted,
			// Token: 0x040001FB RID: 507
			Elastic,
			// Token: 0x040001FC RID: 508
			Clamped
		}

		// Token: 0x02000065 RID: 101
		public enum ScrollbarVisibility
		{
			// Token: 0x040001FE RID: 510
			Permanent,
			// Token: 0x040001FF RID: 511
			AutoHide,
			// Token: 0x04000200 RID: 512
			AutoHideAndExpandViewport
		}

		// Token: 0x02000066 RID: 102
		[Serializable]
		public class ScrollRectEvent : UnityEvent<Vector2>
		{
			// Token: 0x06000418 RID: 1048 RVA: 0x0000D5CC File Offset: 0x0000B7CC
			public ScrollRectEvent()
			{
			}
		}
	}
}
