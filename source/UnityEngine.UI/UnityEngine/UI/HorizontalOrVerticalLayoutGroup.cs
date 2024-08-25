using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnityEngine.UI
{
	// Token: 0x02000045 RID: 69
	[ExecuteAlways]
	public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup
	{
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00009D18 File Offset: 0x00007F18
		// (set) Token: 0x06000297 RID: 663 RVA: 0x00009D2C File Offset: 0x00007F2C
		public float spacing
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000296)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.HorizontalOrVerticalLayoutGroup::get_spacing()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(HorizontalOrVerticalLayoutGroup::m_Spacing, ldloc:HorizontalOrVerticalLayoutGroup(this)))
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00009D3C File Offset: 0x00007F3C
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00009D50 File Offset: 0x00007F50
		public bool childForceExpandWidth
		{
			get
			{
				return this.m_ChildForceExpandWidth;
			}
			set
			{
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00009D60 File Offset: 0x00007F60
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00009D74 File Offset: 0x00007F74
		public bool childForceExpandHeight
		{
			get
			{
				return this.m_ChildForceExpandHeight;
			}
			set
			{
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00009D84 File Offset: 0x00007F84
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00009D98 File Offset: 0x00007F98
		public bool childControlWidth
		{
			get
			{
				return this.m_ChildControlWidth;
			}
			set
			{
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00009DA8 File Offset: 0x00007FA8
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00009DBC File Offset: 0x00007FBC
		public bool childControlHeight
		{
			get
			{
				return this.m_ChildControlHeight;
			}
			set
			{
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00009DCC File Offset: 0x00007FCC
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x00009DE0 File Offset: 0x00007FE0
		public bool childScaleWidth
		{
			get
			{
				return this.m_ChildScaleWidth;
			}
			set
			{
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00009DF0 File Offset: 0x00007FF0
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00009E04 File Offset: 0x00008004
		public bool childScaleHeight
		{
			get
			{
				return this.m_ChildScaleHeight;
			}
			set
			{
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00009E14 File Offset: 0x00008014
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x00009E28 File Offset: 0x00008028
		public bool reverseArrangement
		{
			get
			{
				return this.m_ReverseArrangement;
			}
			set
			{
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00009E38 File Offset: 0x00008038
		protected void CalcAlongAxis(int axis, bool isVertical)
		{
			RectOffset padding = this.m_Padding;
			if (axis != 0)
			{
				int vertical = padding.vertical;
				return;
			}
			int size = this.m_RectChildren._size;
			if (axis != 0)
			{
				return;
			}
			List<RectTransform> rectChildren = this.m_RectChildren;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00009E94 File Offset: 0x00008094
		protected void SetChildrenAlongAxis(int axis, bool isVertical)
		{
			Vector2 size = base.rectTransform.rect.size;
			if (axis != 0)
			{
				return;
			}
			TextAnchor childAlignment = this.m_ChildAlignment;
			if (axis != 0)
			{
				return;
			}
			List<RectTransform> rectChildren = this.m_RectChildren;
			bool reverseArrangement = this.m_ReverseArrangement;
			RectOffset padding = this.m_Padding;
			int size2 = rectChildren._size;
			if (axis != 0)
			{
				int vertical = padding.vertical;
				return;
			}
			bool reverseArrangement2 = this.m_ReverseArrangement;
			List<RectTransform> rectChildren2 = this.m_RectChildren;
			if (axis != 0)
			{
				return;
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00009FB8 File Offset: 0x000081B8
		private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, [Out] float min, [Out] float preferred, [Out] float flexible)
		{
			if (axis != 0)
			{
				float minHeight = LayoutUtility.GetMinHeight(child);
				float preferredHeight = LayoutUtility.GetPreferredHeight(child);
				float flexibleHeight = LayoutUtility.GetFlexibleHeight(child);
				return;
			}
			float preferredWidth = LayoutUtility.GetPreferredWidth(child);
			float flexibleWidth = LayoutUtility.GetFlexibleWidth(child);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00009FFC File Offset: 0x000081FC
		protected HorizontalOrVerticalLayoutGroup()
		{
			long num = 16843009L;
			this.m_ChildForceExpandWidth = num != 0L;
			base..ctor();
		}

		// Token: 0x04000165 RID: 357
		[SerializeField]
		protected float m_Spacing;

		// Token: 0x04000166 RID: 358
		[SerializeField]
		protected bool m_ChildForceExpandWidth;

		// Token: 0x04000167 RID: 359
		[SerializeField]
		protected bool m_ChildForceExpandHeight;

		// Token: 0x04000168 RID: 360
		[SerializeField]
		protected bool m_ChildControlWidth;

		// Token: 0x04000169 RID: 361
		[SerializeField]
		protected bool m_ChildControlHeight;

		// Token: 0x0400016A RID: 362
		[SerializeField]
		protected bool m_ChildScaleWidth;

		// Token: 0x0400016B RID: 363
		[SerializeField]
		protected bool m_ChildScaleHeight;

		// Token: 0x0400016C RID: 364
		[SerializeField]
		protected bool m_ReverseArrangement;
	}
}
