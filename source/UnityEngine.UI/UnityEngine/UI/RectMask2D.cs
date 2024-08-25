using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200005D RID: 93
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[AddComponentMenu("UI/Rect Mask 2D", 14)]
	[RequireComponent(typeof(RectTransform))]
	public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter
	{
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0000B5E8 File Offset: 0x000097E8
		// (set) Token: 0x06000378 RID: 888 RVA: 0x0000B628 File Offset: 0x00009828
		public Vector4 padding
		{
			get
			{
				float x = this.m_Padding.x;
				float y = this.m_Padding.y;
				float z = this.m_Padding.z;
				float w = this.m_Padding.w;
				Vector4 vector;
				return vector;
			}
			set
			{
				MaskUtilities.Notify2DMaskStateChanged(this);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0000B63C File Offset: 0x0000983C
		// (set) Token: 0x0600037A RID: 890 RVA: 0x0000B64C File Offset: 0x0000984C
		public Vector2Int softness
		{
			get
			{
				Vector2Int vector2Int;
				return vector2Int;
			}
			set
			{
				MaskUtilities.Notify2DMaskStateChanged(this);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0000B660 File Offset: 0x00009860
		internal Canvas Canvas
		{
			get
			{
				Canvas canvas = this.m_Canvas;
				if (!true)
				{
				}
				if (!true)
				{
				}
				GameObject gameObject = base.gameObject;
				return this.m_Canvas;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600037C RID: 892 RVA: 0x0000B688 File Offset: 0x00009888
		public Rect canvasRect
		{
			get
			{
				RectangularVertexClipper vertexClipper = this.m_VertexClipper;
				RectTransform rectTransform = this.rectTransform;
				Canvas canvas = this.Canvas;
				return vertexClipper.GetCanvasRect(rectTransform, canvas);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600037D RID: 893 RVA: 0x0000B6B4 File Offset: 0x000098B4
		public RectTransform rectTransform
		{
			get
			{
				RectTransform component;
				if (this.m_RectTransform == null)
				{
					component = base.GetComponent<RectTransform>();
					this.m_RectTransform = component;
				}
				return component;
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000B6D8 File Offset: 0x000098D8
		protected RectMask2D()
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000B6EC File Offset: 0x000098EC
		protected override void OnEnable()
		{
			base.OnEnable();
			this.m_ShouldRecalculateClipRects = true;
			ClipperRegistry.Register(this);
			MaskUtilities.Notify2DMaskStateChanged(this);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00002207 File Offset: 0x00000407
		protected override void OnDisable()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000B714 File Offset: 0x00009914
		protected override void OnDestroy()
		{
			ClipperRegistry.Unregister(this);
			base.OnDestroy();
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000B730 File Offset: 0x00009930
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			bool isActiveAndEnabled = base.isActiveAndEnabled;
			RectTransform rectTransform = this.rectTransform;
			float x = this.m_Padding.x;
			float y = this.m_Padding.y;
			float z = this.m_Padding.z;
			float w = this.m_Padding.w;
			bool flag;
			return flag;
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000383 RID: 899 RVA: 0x0000B784 File Offset: 0x00009984
		private Rect rootCanvasRect
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000383)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Rect UnityEngine.UI.RectMask2D::get_rootCanvasRect()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0043:
	stloc:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3[](var_8_49, ldfld:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3[](RectMask2D::m_Corners, ldloc:RectMask2D(this)))
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

		// Token: 0x06000384 RID: 900 RVA: 0x0000B7DC File Offset: 0x000099DC
		public virtual void PerformClipping()
		{
			if (this.Canvas != null)
			{
				if (this.m_ShouldRecalculateClipRects)
				{
					List<RectMask2D> clippers = this.m_Clippers;
					MaskUtilities.GetRectMasksForClip(this, clippers);
				}
				List<RectMask2D> clippers2 = this.m_Clippers;
				RenderMode renderMode = this.Canvas.rootCanvas.renderMode;
				Rect rootCanvasRect = this.rootCanvasRect;
				Rect zero = Rect.zero;
				float xmin = this.m_LastClipRectCanvasSpace.m_XMin;
				float ymin = this.m_LastClipRectCanvasSpace.m_YMin;
				float width = this.m_LastClipRectCanvasSpace.m_Width;
				float height = this.m_LastClipRectCanvasSpace.m_Height;
				HashSet<IClippable> clipTargets = this.m_ClipTargets;
				return;
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000B908 File Offset: 0x00009B08
		public virtual void UpdateClipSoftness()
		{
			if (this.Canvas != null)
			{
				HashSet<IClippable> clipTargets = this.m_ClipTargets;
				int x = this.m_Softness.m_X;
				int y = this.m_Softness.m_Y;
				return;
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000B98C File Offset: 0x00009B8C
		public void AddClippable(IClippable clippable)
		{
			if (clippable != null)
			{
				int num = 1;
				this.m_ShouldRecalculateClipRects = num != 0;
				return;
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000B9BC File Offset: 0x00009BBC
		public void RemoveClippable(IClippable clippable)
		{
			if (clippable != null)
			{
				int num = 1;
				this.m_ShouldRecalculateClipRects = num != 0;
				return;
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000B9F4 File Offset: 0x00009BF4
		protected override void OnTransformParentChanged()
		{
			base.OnTransformParentChanged();
			this.m_ShouldRecalculateClipRects = true;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000BA10 File Offset: 0x00009C10
		protected override void OnCanvasHierarchyChanged()
		{
			base.OnCanvasHierarchyChanged();
			this.m_ShouldRecalculateClipRects = true;
		}

		// Token: 0x040001AF RID: 431
		[NonSerialized]
		private readonly RectangularVertexClipper m_VertexClipper;

		// Token: 0x040001B0 RID: 432
		[NonSerialized]
		private RectTransform m_RectTransform;

		// Token: 0x040001B1 RID: 433
		[NonSerialized]
		private HashSet<MaskableGraphic> m_MaskableTargets;

		// Token: 0x040001B2 RID: 434
		[NonSerialized]
		private HashSet<IClippable> m_ClipTargets;

		// Token: 0x040001B3 RID: 435
		[NonSerialized]
		private bool m_ShouldRecalculateClipRects;

		// Token: 0x040001B4 RID: 436
		[NonSerialized]
		private List<RectMask2D> m_Clippers;

		// Token: 0x040001B5 RID: 437
		[NonSerialized]
		private Rect m_LastClipRectCanvasSpace;

		// Token: 0x040001B6 RID: 438
		[NonSerialized]
		private bool m_ForceClip;

		// Token: 0x040001B7 RID: 439
		[SerializeField]
		private Vector4 m_Padding;

		// Token: 0x040001B8 RID: 440
		[SerializeField]
		private Vector2Int m_Softness;

		// Token: 0x040001B9 RID: 441
		[NonSerialized]
		private Canvas m_Canvas;

		// Token: 0x040001BA RID: 442
		private Vector3[] m_Corners;
	}
}
