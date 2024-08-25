using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI.CoroutineTween;

namespace UnityEngine.UI
{
	// Token: 0x0200001C RID: 28
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	[DisallowMultipleComponent]
	public abstract class Graphic : UIBehaviour, ICanvasElement
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00003DB0 File Offset: 0x00001FB0
		public static Material defaultGraphicMaterial
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Material UnityEngine.UI.Graphic::get_defaultGraphicMaterial()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Material(var_2_0A, call:Material(Canvas::GetDefaultCanvasMaterial))
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

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00003DC8 File Offset: 0x00001FC8
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00003E04 File Offset: 0x00002004
		public virtual Color color
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000E2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Color UnityEngine.UI.Graphic::get_color()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Color::r, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](Graphic::m_Color, ldloc:Graphic(this))))
	stloc:float32(var_1_17, ldfld:float32(Color::g, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](Graphic::m_Color, ldloc:Graphic(this))))
	stloc:float32(var_2_23, ldfld:float32(Color::b, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](Graphic::m_Color, ldloc:Graphic(this))))
	stloc:float32(var_3_2F, ldfld:float32(Color::a, ldfld:Color[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Color&](Graphic::m_Color, ldloc:Graphic(this))))
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

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00003E14 File Offset: 0x00002014
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00003E28 File Offset: 0x00002028
		public virtual bool raycastTarget
		{
			get
			{
				return this.m_RaycastTarget;
			}
			set
			{
				if (this.m_RaycastTarget)
				{
					GraphicRegistry.UnregisterRaycastGraphicForCanvas(this.canvas, this);
				}
				bool isActiveAndEnabled = base.isActiveAndEnabled;
				GraphicRegistry.RegisterRaycastGraphicForCanvas(this.canvas, this);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00003E5C File Offset: 0x0000205C
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00003E9C File Offset: 0x0000209C
		public Vector4 raycastPadding
		{
			get
			{
				float x = this.m_RaycastPadding.x;
				float y = this.m_RaycastPadding.y;
				float z = this.m_RaycastPadding.z;
				float w = this.m_RaycastPadding.w;
				Vector4 vector;
				return vector;
			}
			set
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00003EAC File Offset: 0x000020AC
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00003EC0 File Offset: 0x000020C0
		protected bool useLegacyMeshGeneration
		{
			[CompilerGenerated]
			get
			{
				return this.<useLegacyMeshGeneration>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00003ED0 File Offset: 0x000020D0
		protected Graphic()
		{
			if (this.m_ColorTweenRunner == null)
			{
			}
			this.<useLegacyMeshGeneration>k__BackingField = true;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00003F00 File Offset: 0x00002100
		public virtual void SetAllDirty()
		{
			if (this.m_SkipLayoutUpdate)
			{
				return;
			}
			if (this.m_SkipMaterialUpdate)
			{
				return;
			}
			this.SetRaycastDirty();
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003F28 File Offset: 0x00002128
		public virtual void SetLayoutDirty()
		{
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			UnityAction onDirtyLayoutCallback = this.m_OnDirtyLayoutCallback;
			if (onDirtyLayoutCallback != null)
			{
				IntPtr invoke_impl = onDirtyLayoutCallback.invoke_impl;
				IntPtr method_code = onDirtyLayoutCallback.method_code;
				IntPtr method = onDirtyLayoutCallback.method;
				return;
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003F60 File Offset: 0x00002160
		public virtual void SetVerticesDirty()
		{
			this.m_VertsDirty = true;
			CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(this);
			UnityAction onDirtyVertsCallback = this.m_OnDirtyVertsCallback;
			if (onDirtyVertsCallback != null)
			{
				IntPtr invoke_impl = onDirtyVertsCallback.invoke_impl;
				IntPtr method_code = onDirtyVertsCallback.method_code;
				IntPtr method = onDirtyVertsCallback.method;
				return;
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00003F9C File Offset: 0x0000219C
		public virtual void SetMaterialDirty()
		{
			this.m_MaterialDirty = true;
			CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(this);
			UnityAction onDirtyMaterialCallback = this.m_OnDirtyMaterialCallback;
			if (onDirtyMaterialCallback != null)
			{
				IntPtr invoke_impl = onDirtyMaterialCallback.invoke_impl;
				IntPtr method_code = onDirtyMaterialCallback.method_code;
				IntPtr method = onDirtyMaterialCallback.method;
				return;
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00003FD8 File Offset: 0x000021D8
		public void SetRaycastDirty()
		{
			bool raycastTargetCache = this.m_RaycastTargetCache;
			if (this.m_RaycastTarget)
			{
				bool isActiveAndEnabled = base.isActiveAndEnabled;
				Canvas canvas = this.canvas;
				if (!raycastTargetCache)
				{
				}
				GraphicRegistry.RegisterRaycastGraphicForCanvas(canvas, this);
				return;
			}
			Canvas canvas2 = this.canvas;
			if (!raycastTargetCache)
			{
			}
			GraphicRegistry.UnregisterRaycastGraphicForCanvas(canvas2, this);
			bool raycastTarget = this.m_RaycastTarget;
			this.m_RaycastTargetCache = raycastTarget;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00004038 File Offset: 0x00002238
		protected override void OnRectTransformDimensionsChange()
		{
			bool activeInHierarchy = base.gameObject.activeInHierarchy;
			bool flag = CanvasUpdateRegistry.IsRebuildingLayout();
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00004058 File Offset: 0x00002258
		protected override void OnBeforeTransformParentChanged()
		{
			GraphicRegistry.DisableGraphicForCanvas(this.canvas, this);
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000407C File Offset: 0x0000227C
		protected override void OnTransformParentChanged()
		{
			base.OnTransformParentChanged();
			this.CacheCanvas();
			GraphicRegistry.RegisterGraphicForCanvas(this.canvas, this);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000040A4 File Offset: 0x000022A4
		public int depth
		{
			get
			{
				return this.canvasRenderer.absoluteDepth;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000040BC File Offset: 0x000022BC
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

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000040E0 File Offset: 0x000022E0
		public Canvas canvas
		{
			get
			{
				Canvas canvas = this.m_Canvas;
				if (!true)
				{
				}
				this.CacheCanvas();
				return this.m_Canvas;
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00004104 File Offset: 0x00002304
		private void CacheCanvas()
		{
			if (!true)
			{
			}
			GameObject gameObject = base.gameObject;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00004124 File Offset: 0x00002324
		public CanvasRenderer canvasRenderer
		{
			get
			{
				CanvasRenderer canvasRenderer;
				if (this.m_CanvasRenderer == null)
				{
					CanvasRenderer component = base.GetComponent<CanvasRenderer>();
					this.m_CanvasRenderer = component;
					if (component == null)
					{
						canvasRenderer = base.gameObject.AddComponent<CanvasRenderer>();
						this.m_CanvasRenderer = canvasRenderer;
					}
				}
				return canvasRenderer;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00004160 File Offset: 0x00002360
		public virtual Material defaultMaterial
		{
			get
			{
				if (!true)
				{
				}
				return Graphic.defaultGraphicMaterial;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00004178 File Offset: 0x00002378
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00004198 File Offset: 0x00002398
		public virtual Material material
		{
			get
			{
				Material material = this.m_Material;
				if (!true)
				{
				}
				return this.m_Material;
			}
			set
			{
				Material material = this.m_Material;
				if (!true)
				{
				}
				bool flag = material == value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000041C0 File Offset: 0x000023C0
		public virtual Material materialForRendering
		{
			get
			{
				if (!true)
				{
					return;
				}
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000041D4 File Offset: 0x000023D4
		public virtual Texture mainTexture
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Texture UnityEngine.UI.Graphic::get_mainTexture()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000041E4 File Offset: 0x000023E4
		protected override void OnEnable()
		{
			base.OnEnable();
			this.CacheCanvas();
			GraphicRegistry.RegisterGraphicForCanvas(this.canvas, this);
			Texture2D whiteTexture = Texture2D.whiteTexture;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00004214 File Offset: 0x00002414
		protected override void OnDisable()
		{
			GraphicRegistry.DisableGraphicForCanvas(this.canvas, this);
			CanvasUpdateRegistry.DisableCanvasElementForRebuild(this);
			CanvasRenderer canvasRenderer = this.canvasRenderer;
			this.canvasRenderer.Clear();
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			base.OnDisable();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004258 File Offset: 0x00002458
		protected override void OnDestroy()
		{
			GraphicRegistry.UnregisterGraphicForCanvas(this.canvas, this);
			CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(this);
			bool flag = this.m_CachedMesh;
			Object.Destroy(this.m_CachedMesh);
			base.OnDestroy();
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00004294 File Offset: 0x00002494
		protected override void OnCanvasHierarchyChanged()
		{
			Canvas canvas = this.m_Canvas;
			this.CacheCanvas();
			Canvas canvas2 = this.m_Canvas;
			bool flag = canvas != canvas2;
			GraphicRegistry.UnregisterGraphicForCanvas(canvas, this);
			Canvas canvas3 = this.canvas;
			GraphicRegistry.RegisterGraphicForCanvas(canvas3, this);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000042DC File Offset: 0x000024DC
		public virtual void OnCullingChanged()
		{
			bool cull = this.canvasRenderer.cull;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000430C File Offset: 0x0000250C
		public virtual void Rebuild(CanvasUpdate update)
		{
			CanvasRenderer canvasRenderer = this.canvasRenderer;
			bool cull = this.canvasRenderer.cull;
			if (this.m_VertsDirty)
			{
			}
			if (this.m_MaterialDirty)
			{
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000433C File Offset: 0x0000253C
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000434C File Offset: 0x0000254C
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000435C File Offset: 0x0000255C
		protected virtual void UpdateMaterial()
		{
			this.canvasRenderer.materialCount = 1;
			CanvasRenderer canvasRenderer = this.canvasRenderer;
			CanvasRenderer canvasRenderer2 = this.canvasRenderer;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00004384 File Offset: 0x00002584
		protected virtual void UpdateGeometry()
		{
			if (this.<useLegacyMeshGeneration>k__BackingField)
			{
				this.DoLegacyMeshGeneration();
				return;
			}
			this.DoMeshGeneration();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000043A8 File Offset: 0x000025A8
		private void DoMeshGeneration()
		{
			RectTransform rectTransform = this.rectTransform;
			float width = this.rectTransform.rect.width;
			float height = this.rectTransform.rect.height;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00004410 File Offset: 0x00002610
		private void DoLegacyMeshGeneration()
		{
			RectTransform rectTransform = this.rectTransform;
			float width = this.rectTransform.rect.width;
			float height = this.rectTransform.rect.height;
			Graphic.workerMesh.Clear();
			Mesh workerMesh = Graphic.workerMesh;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00004490 File Offset: 0x00002690
		protected static Mesh workerMesh
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000109)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Mesh UnityEngine.UI.Graphic::get_workerMesh()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000044A0 File Offset: 0x000026A0
		[Obsolete("Use OnPopulateMesh instead.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected virtual void OnFillVBO(List<UIVertex> vbo)
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000044B0 File Offset: 0x000026B0
		[Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", false)]
		protected virtual void OnPopulateMesh(Mesh m)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000044C0 File Offset: 0x000026C0
		protected virtual void OnPopulateMesh(VertexHelper vh)
		{
			Rect pixelAdjustedRect = this.GetPixelAdjustedRect();
			float x = pixelAdjustedRect.x;
			float y = pixelAdjustedRect.y;
			float x2 = pixelAdjustedRect.x;
			float width = pixelAdjustedRect.width;
			float y2 = pixelAdjustedRect.y;
			float height = pixelAdjustedRect.height;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00004530 File Offset: 0x00002730
		protected override void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00004540 File Offset: 0x00002740
		public virtual void SetNativeSize()
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004550 File Offset: 0x00002750
		public virtual bool Raycast(Vector2 sp, Camera eventCamera)
		{
			/*
An exception occurred when decompiling this method (0600010F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.Graphic::Raycast(UnityEngine.Vector2,UnityEngine.Camera)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002A:
	stloc:Material(var_12_30, ldfld:Material(Graphic::m_Material, ldloc:Graphic(this)))
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

		// Token: 0x06000110 RID: 272 RVA: 0x00004594 File Offset: 0x00002794
		public Vector2 PixelAdjustPoint(Vector2 point)
		{
			/*
An exception occurred when decompiling this method (06000110)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector2 UnityEngine.UI.Graphic::PixelAdjustPoint(UnityEngine.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_0B, call:bool(Object::op_Implicit, callgetter:Canvas[exp:Object](Graphic::get_canvas, ldloc:Graphic(this))))
	stloc:RenderMode(var_1_17, callgetter:RenderMode(Canvas::get_renderMode, callgetter:Canvas(Graphic::get_canvas, ldloc:Graphic(this))))
	stloc:float32(var_2_23, callgetter:float32(Canvas::get_scaleFactor, callgetter:Canvas(Graphic::get_canvas, ldloc:Graphic(this))))
	stloc:bool(var_3_2F, callgetter:bool(Canvas::get_pixelPerfect, callgetter:Canvas(Graphic::get_canvas, ldloc:Graphic(this))))
	stloc:Transform(var_4_36, callgetter:Transform(Component::get_transform, ldloc:Graphic[exp:Component](this)))
	stloc:Canvas(var_5_3E, callgetter:Canvas(Graphic::get_canvas, ldloc:Graphic(this)))
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

		// Token: 0x06000111 RID: 273 RVA: 0x000045E0 File Offset: 0x000027E0
		public Rect GetPixelAdjustedRect()
		{
			bool flag = this.canvas;
			RenderMode renderMode = this.canvas.renderMode;
			float scaleFactor = this.canvas.scaleFactor;
			bool pixelPerfect = this.canvas.pixelPerfect;
			RectTransform rectTransform = this.rectTransform;
			Canvas canvas = this.canvas;
			return RectTransformUtility.PixelAdjustRect(rectTransform, canvas);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00004640 File Offset: 0x00002840
		public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00004650 File Offset: 0x00002850
		public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB)
		{
			CanvasRenderer canvasRenderer = this.canvasRenderer;
			Color color = this.canvasRenderer.GetColor();
			this.m_ColorTweenRunner.StopTween();
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002207 File Offset: 0x00000407
		private static Color CreateColorFromAlpha(float alpha)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000469C File Offset: 0x0000289C
		public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000046AC File Offset: 0x000028AC
		public void RegisterDirtyLayoutCallback(UnityAction action)
		{
			Delegate @delegate = Delegate.Combine(this.m_OnDirtyLayoutCallback, action);
			if (@delegate != null)
			{
				this.m_OnDirtyLayoutCallback = @delegate;
				throw new InvalidCastException();
			}
			this.m_OnDirtyLayoutCallback = @delegate;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000046E0 File Offset: 0x000028E0
		public void UnregisterDirtyLayoutCallback(UnityAction action)
		{
			Delegate @delegate = Delegate.Remove(this.m_OnDirtyLayoutCallback, action);
			if (@delegate != null)
			{
				this.m_OnDirtyLayoutCallback = @delegate;
				throw new InvalidCastException();
			}
			this.m_OnDirtyLayoutCallback = @delegate;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00004714 File Offset: 0x00002914
		public void RegisterDirtyVerticesCallback(UnityAction action)
		{
			Delegate @delegate = Delegate.Combine(this.m_OnDirtyVertsCallback, action);
			if (@delegate != null)
			{
				this.m_OnDirtyVertsCallback = @delegate;
				throw new InvalidCastException();
			}
			this.m_OnDirtyVertsCallback = @delegate;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00004748 File Offset: 0x00002948
		public void UnregisterDirtyVerticesCallback(UnityAction action)
		{
			Delegate @delegate = Delegate.Remove(this.m_OnDirtyVertsCallback, action);
			if (@delegate != null)
			{
				this.m_OnDirtyVertsCallback = @delegate;
				throw new InvalidCastException();
			}
			this.m_OnDirtyVertsCallback = @delegate;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000477C File Offset: 0x0000297C
		public void RegisterDirtyMaterialCallback(UnityAction action)
		{
			Delegate @delegate = Delegate.Combine(this.m_OnDirtyMaterialCallback, action);
			if (@delegate != null)
			{
				this.m_OnDirtyMaterialCallback = @delegate;
				throw new InvalidCastException();
			}
			this.m_OnDirtyMaterialCallback = @delegate;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000047B0 File Offset: 0x000029B0
		public void UnregisterDirtyMaterialCallback(UnityAction action)
		{
			Delegate @delegate = Delegate.Remove(this.m_OnDirtyMaterialCallback, action);
			if (@delegate != null)
			{
				this.m_OnDirtyMaterialCallback = @delegate;
				throw new InvalidCastException();
			}
			this.m_OnDirtyMaterialCallback = @delegate;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000047E4 File Offset: 0x000029E4
		// Note: this type is marked as 'beforefieldinit'.
		static Graphic()
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000047F4 File Offset: 0x000029F4
		Transform ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x04000068 RID: 104
		protected static Material s_DefaultUI;

		// Token: 0x04000069 RID: 105
		protected static Texture2D s_WhiteTexture;

		// Token: 0x0400006A RID: 106
		[SerializeField]
		[FormerlySerializedAs("m_Mat")]
		protected Material m_Material;

		// Token: 0x0400006B RID: 107
		[SerializeField]
		private Color m_Color;

		// Token: 0x0400006C RID: 108
		[NonSerialized]
		protected bool m_SkipLayoutUpdate;

		// Token: 0x0400006D RID: 109
		[NonSerialized]
		protected bool m_SkipMaterialUpdate;

		// Token: 0x0400006E RID: 110
		[SerializeField]
		private bool m_RaycastTarget = 257 != 0;

		// Token: 0x0400006F RID: 111
		private bool m_RaycastTargetCache;

		// Token: 0x04000070 RID: 112
		[SerializeField]
		private Vector4 m_RaycastPadding;

		// Token: 0x04000071 RID: 113
		[NonSerialized]
		private RectTransform m_RectTransform;

		// Token: 0x04000072 RID: 114
		[NonSerialized]
		private CanvasRenderer m_CanvasRenderer;

		// Token: 0x04000073 RID: 115
		[NonSerialized]
		private Canvas m_Canvas;

		// Token: 0x04000074 RID: 116
		[NonSerialized]
		private bool m_VertsDirty;

		// Token: 0x04000075 RID: 117
		[NonSerialized]
		private bool m_MaterialDirty;

		// Token: 0x04000076 RID: 118
		[NonSerialized]
		protected UnityAction m_OnDirtyLayoutCallback;

		// Token: 0x04000077 RID: 119
		[NonSerialized]
		protected UnityAction m_OnDirtyVertsCallback;

		// Token: 0x04000078 RID: 120
		[NonSerialized]
		protected UnityAction m_OnDirtyMaterialCallback;

		// Token: 0x04000079 RID: 121
		[NonSerialized]
		protected static Mesh s_Mesh;

		// Token: 0x0400007A RID: 122
		[NonSerialized]
		private static readonly VertexHelper s_VertexHelper;

		// Token: 0x0400007B RID: 123
		[NonSerialized]
		protected Mesh m_CachedMesh;

		// Token: 0x0400007C RID: 124
		[NonSerialized]
		protected Vector2[] m_CachedUvs;

		// Token: 0x0400007D RID: 125
		[NonSerialized]
		private readonly TweenRunner<ColorTween> m_ColorTweenRunner;

		// Token: 0x0400007E RID: 126
		[CompilerGenerated]
		private bool <useLegacyMeshGeneration>k__BackingField;
	}
}
