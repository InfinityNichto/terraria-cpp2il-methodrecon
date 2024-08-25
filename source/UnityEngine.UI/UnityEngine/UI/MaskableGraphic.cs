using System;
using System.ComponentModel;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	// Token: 0x02000054 RID: 84
	public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier
	{
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0000AC78 File Offset: 0x00008E78
		// (set) Token: 0x0600033D RID: 829 RVA: 0x0000AC8C File Offset: 0x00008E8C
		public MaskableGraphic.CullStateChangedEvent onCullStateChanged
		{
			get
			{
				return this.m_OnCullStateChanged;
			}
			set
			{
				this.m_OnCullStateChanged = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0000ACA0 File Offset: 0x00008EA0
		// (set) Token: 0x0600033F RID: 831 RVA: 0x0000ACB4 File Offset: 0x00008EB4
		public bool maskable
		{
			get
			{
				return this.m_Maskable;
			}
			set
			{
				bool maskable = this.m_Maskable;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000ACD0 File Offset: 0x00008ED0
		// (set) Token: 0x06000341 RID: 833 RVA: 0x0000ACE4 File Offset: 0x00008EE4
		public bool isMaskingGraphic
		{
			get
			{
				return this.m_IsMaskingGraphic;
			}
			set
			{
				bool isMaskingGraphic = this.m_IsMaskingGraphic;
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		public virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			if (this.m_ShouldRecalculateStencil && this.m_Maskable)
			{
				Transform transform = MaskUtilities.FindRootSortOverrideCanvas(base.transform);
				int stencilDepth = MaskUtilities.GetStencilDepth(base.transform, transform);
			}
			long num = 0L;
			this.m_StencilValue = (int)num;
			Material maskMaterial;
			if (!this.m_IsMaskingGraphic)
			{
				maskMaterial = this.m_MaskMaterial;
				StencilMaterial.Remove(maskMaterial);
				Material material;
				this.m_MaskMaterial = material;
			}
			return maskMaterial;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000AD58 File Offset: 0x00008F58
		public virtual void Cull(Rect clipRect, bool validRect)
		{
			Rect rootCanvasRect = this.rootCanvasRect;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000AD74 File Offset: 0x00008F74
		private void UpdateCull(bool cull)
		{
			bool cull2 = base.canvasRenderer.cull;
			base.canvasRenderer.cull = cull;
			UISystemProfilerApi.AddMarker("MaskableGraphic.cullingChanged", this);
			MaskableGraphic.CullStateChangedEvent onCullStateChanged = this.m_OnCullStateChanged;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000ADAC File Offset: 0x00008FAC
		public virtual void SetClipRect(Rect clipRect, bool validRect)
		{
			CanvasRenderer canvasRenderer = base.canvasRenderer;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000ADC8 File Offset: 0x00008FC8
		public virtual void SetClipSoftness(Vector2 clipSoftness)
		{
			CanvasRenderer canvasRenderer = base.canvasRenderer;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000ADDC File Offset: 0x00008FDC
		protected override void OnEnable()
		{
			base.OnEnable();
			this.m_ShouldRecalculateStencil = true;
			this.UpdateClipParent();
			if (this.m_IsMaskingGraphic)
			{
				MaskUtilities.NotifyStencilStateChanged(this);
				return;
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000AE0C File Offset: 0x0000900C
		protected override void OnDisable()
		{
			base.OnDisable();
			this.UpdateClipParent();
			StencilMaterial.Remove(this.m_MaskMaterial);
			if (this.m_IsMaskingGraphic)
			{
				MaskUtilities.NotifyStencilStateChanged(this);
				return;
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000AE40 File Offset: 0x00009040
		protected override void OnTransformParentChanged()
		{
			base.OnTransformParentChanged();
			bool isActiveAndEnabled = base.isActiveAndEnabled;
			this.m_ShouldRecalculateStencil = true;
			this.UpdateClipParent();
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000AE68 File Offset: 0x00009068
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Not used anymore.", true)]
		public virtual void ParentMaskStateChanged()
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000AE78 File Offset: 0x00009078
		protected override void OnCanvasHierarchyChanged()
		{
			base.OnCanvasHierarchyChanged();
			bool isActiveAndEnabled = base.isActiveAndEnabled;
			this.m_ShouldRecalculateStencil = true;
			this.UpdateClipParent();
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0000AEA0 File Offset: 0x000090A0
		private Rect rootCanvasRect
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600034C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Rect UnityEngine.UI.MaskableGraphic::get_rootCanvasRect()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RectTransform(var_0_06, callgetter:RectTransform(Graphic::get_rectTransform, ldloc:MaskableGraphic[exp:Graphic](this)))
	stloc:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3[](var_1_0D, ldfld:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3[](MaskableGraphic::m_Corners, ldloc:MaskableGraphic(this)))
	call:void(RectTransform::GetWorldCorners, ldloc:RectTransform(var_0_06), ldloc:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3[](var_1_0D))
	stloc:bool(var_2_20, call:bool(Object::op_Implicit, callgetter:Canvas[exp:Object](Graphic::get_canvas, ldloc:MaskableGraphic[exp:Graphic](this))))
	stloc:Matrix4x4(var_3_36, callgetter:Matrix4x4(Transform::get_worldToLocalMatrix, callgetter:Transform(Component::get_transform, callgetter:Canvas[exp:Component](Canvas::get_rootCanvas, callgetter:Canvas(Graphic::get_canvas, ldloc:MaskableGraphic[exp:Graphic](this))))))
	stloc:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3[](var_5_40, ldfld:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3[](MaskableGraphic::m_Corners, ldloc:MaskableGraphic(this)))
	stloc:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3[](var_7_48, ldfld:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3[](MaskableGraphic::m_Corners, ldloc:MaskableGraphic(this)))
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

		// Token: 0x0600034D RID: 845 RVA: 0x0000AEFC File Offset: 0x000090FC
		private void UpdateClipParent()
		{
			if (this.m_Maskable)
			{
				RectMask2D rectMaskForClippable = MaskUtilities.GetRectMaskForClippable(this);
				return;
			}
			long num = 0L;
			RectMask2D parentMask = this.m_ParentMask;
			RectMask2D parentMask2 = this.m_ParentMask;
			this.m_ParentMask.RemoveClippable(this);
			long num2 = 0L;
			this.UpdateCull(num2 != 0L);
			this.m_ParentMask = num;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000AF48 File Offset: 0x00009148
		public virtual void RecalculateClipping()
		{
			this.UpdateClipParent();
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000AF5C File Offset: 0x0000915C
		public virtual void RecalculateMasking()
		{
			Material maskMaterial = this.m_MaskMaterial;
			if (!true)
			{
			}
			StencilMaterial.Remove(maskMaterial);
			this.m_ShouldRecalculateStencil = true;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000AF80 File Offset: 0x00009180
		protected MaskableGraphic()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000AFAC File Offset: 0x000091AC
		GameObject IClippable.get_gameObject()
		{
			return base.gameObject;
		}

		// Token: 0x04000197 RID: 407
		[NonSerialized]
		protected bool m_ShouldRecalculateStencil = true;

		// Token: 0x04000198 RID: 408
		[NonSerialized]
		protected Material m_MaskMaterial;

		// Token: 0x04000199 RID: 409
		[NonSerialized]
		private RectMask2D m_ParentMask;

		// Token: 0x0400019A RID: 410
		[SerializeField]
		private bool m_Maskable = true;

		// Token: 0x0400019B RID: 411
		private bool m_IsMaskingGraphic;

		// Token: 0x0400019C RID: 412
		[Obsolete("Not used anymore.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[NonSerialized]
		protected bool m_IncludeForMasking;

		// Token: 0x0400019D RID: 413
		[SerializeField]
		private MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged;

		// Token: 0x0400019E RID: 414
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Not used anymore", true)]
		[NonSerialized]
		protected bool m_ShouldRecalculate = true;

		// Token: 0x0400019F RID: 415
		[NonSerialized]
		protected int m_StencilValue;

		// Token: 0x040001A0 RID: 416
		private readonly Vector3[] m_Corners;

		// Token: 0x02000055 RID: 85
		[Serializable]
		public class CullStateChangedEvent : UnityEvent<bool>
		{
			// Token: 0x06000352 RID: 850 RVA: 0x0000AFC0 File Offset: 0x000091C0
			public CullStateChangedEvent()
			{
			}
		}
	}
}
