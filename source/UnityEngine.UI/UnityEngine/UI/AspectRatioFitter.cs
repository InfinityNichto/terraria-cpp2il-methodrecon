using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000038 RID: 56
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("Layout/Aspect Ratio Fitter", 142)]
	[ExecuteAlways]
	public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00008EE4 File Offset: 0x000070E4
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00008EF8 File Offset: 0x000070F8
		public AspectRatioFitter.AspectMode aspectMode
		{
			get
			{
				return this.m_AspectMode;
			}
			set
			{
				this.UpdateRect();
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00008F0C File Offset: 0x0000710C
		// (set) Token: 0x06000241 RID: 577 RVA: 0x00008F20 File Offset: 0x00007120
		public float aspectRatio
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000240)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.AspectRatioFitter::get_aspectRatio()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(AspectRatioFitter::m_AspectRatio, ldloc:AspectRatioFitter(this)))
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
				this.UpdateRect();
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00008F34 File Offset: 0x00007134
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

		// Token: 0x06000243 RID: 579 RVA: 0x00008F64 File Offset: 0x00007164
		protected AspectRatioFitter()
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00008F84 File Offset: 0x00007184
		protected override void OnEnable()
		{
			base.OnEnable();
			bool flag = this.rectTransform.parent;
			this.UpdateRect();
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00008FB0 File Offset: 0x000071B0
		protected override void Start()
		{
			base.Start();
			bool flag = this.IsComponentValidOnObject();
			if (!this.m_DoesParentExist)
			{
				AspectRatioFitter.AspectMode aspectMode = this.m_AspectMode;
				long num = 0L;
				base.enabled = num != 0L;
				return;
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00008FE4 File Offset: 0x000071E4
		protected override void OnDisable()
		{
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			base.OnDisable();
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00009004 File Offset: 0x00007204
		protected override void OnTransformParentChanged()
		{
			base.OnTransformParentChanged();
			bool flag = this.rectTransform.parent;
			this.UpdateRect();
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00009030 File Offset: 0x00007230
		protected virtual void Update()
		{
			if (this.m_DelayedSetDirty)
			{
				this.UpdateRect();
				return;
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000904C File Offset: 0x0000724C
		protected override void OnRectTransformDimensionsChange()
		{
			this.UpdateRect();
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00009060 File Offset: 0x00007260
		private void UpdateRect()
		{
			bool flag = this.IsComponentValidOnObject();
			AspectRatioFitter.AspectMode aspectMode = this.m_AspectMode;
			RectTransform rectTransform = this.rectTransform;
			RectTransform rectTransform2 = this.rectTransform;
			float height = this.rectTransform.rect.height;
			float aspectRatio = this.m_AspectRatio;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000913C File Offset: 0x0000733C
		private float GetSizeDeltaToProduceSize(float size, int axis)
		{
			/*
An exception occurred when decompiling this method (0600024B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.AspectRatioFitter::GetSizeDeltaToProduceSize(System.Single,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0022:
	stloc:Vector2(var_3_2D, callgetter:Vector2(RectTransform::get_anchorMax, callgetter:RectTransform(AspectRatioFitter::get_rectTransform, ldloc:AspectRatioFitter(this))))
	stloc:Vector2(var_5_35, callgetter:Vector2(RectTransform::get_anchorMin, ldloc:RectTransform(var_4)))
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

		// Token: 0x0600024C RID: 588 RVA: 0x00009180 File Offset: 0x00007380
		private Vector2 GetParentSize()
		{
			/*
An exception occurred when decompiling this method (0600024C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector2 UnityEngine.UI.AspectRatioFitter::GetParentSize()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000D:
	stloc:Vector2(var_3_15, callgetter:Vector2(Rect::get_size, ldloc:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](var_2)))
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

		// Token: 0x0600024D RID: 589 RVA: 0x000091A4 File Offset: 0x000073A4
		public virtual void SetLayoutHorizontal()
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000091B4 File Offset: 0x000073B4
		public virtual void SetLayoutVertical()
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000091C4 File Offset: 0x000073C4
		protected void SetDirty()
		{
			this.UpdateRect();
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000091D8 File Offset: 0x000073D8
		public bool IsComponentValidOnObject()
		{
			Canvas component = base.gameObject.GetComponent<Canvas>();
			bool flag = component;
			bool isRootCanvas = component.isRootCanvas;
			RenderMode renderMode = component.renderMode;
			return true;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000920C File Offset: 0x0000740C
		public bool IsAspectModeValid()
		{
			if (!this.m_DoesParentExist)
			{
				AspectRatioFitter.AspectMode aspectMode = this.m_AspectMode;
				return;
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000922C File Offset: 0x0000742C
		private bool DoesParentExists()
		{
			return this.m_DoesParentExist;
		}

		// Token: 0x04000122 RID: 290
		[SerializeField]
		private AspectRatioFitter.AspectMode m_AspectMode;

		// Token: 0x04000123 RID: 291
		[SerializeField]
		private float m_AspectRatio = (float)16256;

		// Token: 0x04000124 RID: 292
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x04000125 RID: 293
		private bool m_DelayedSetDirty;

		// Token: 0x04000126 RID: 294
		private bool m_DoesParentExist;

		// Token: 0x04000127 RID: 295
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x02000039 RID: 57
		public enum AspectMode
		{
			// Token: 0x04000129 RID: 297
			None,
			// Token: 0x0400012A RID: 298
			WidthControlsHeight,
			// Token: 0x0400012B RID: 299
			HeightControlsWidth,
			// Token: 0x0400012C RID: 300
			FitInParent,
			// Token: 0x0400012D RID: 301
			EnvelopeParent
		}
	}
}
