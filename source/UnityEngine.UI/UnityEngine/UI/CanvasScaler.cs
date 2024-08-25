using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200003A RID: 58
	[DisallowMultipleComponent]
	[AddComponentMenu("Layout/Canvas Scaler", 101)]
	[RequireComponent(typeof(Canvas))]
	[ExecuteAlways]
	public class CanvasScaler : UIBehaviour
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00009240 File Offset: 0x00007440
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00009254 File Offset: 0x00007454
		public CanvasScaler.ScaleMode uiScaleMode
		{
			get
			{
				return this.m_UiScaleMode;
			}
			set
			{
				this.m_UiScaleMode = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00009268 File Offset: 0x00007468
		// (set) Token: 0x06000256 RID: 598 RVA: 0x0000927C File Offset: 0x0000747C
		public float referencePixelsPerUnit
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000255)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.CanvasScaler::get_referencePixelsPerUnit()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(CanvasScaler::m_ReferencePixelsPerUnit, ldloc:CanvasScaler(this)))
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

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000928C File Offset: 0x0000748C
		// (set) Token: 0x06000258 RID: 600 RVA: 0x000092A0 File Offset: 0x000074A0
		public float scaleFactor
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000257)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.CanvasScaler::get_scaleFactor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(CanvasScaler::m_ScaleFactor, ldloc:CanvasScaler(this)))
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

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000259 RID: 601 RVA: 0x000092B0 File Offset: 0x000074B0
		// (set) Token: 0x0600025A RID: 602 RVA: 0x000092D8 File Offset: 0x000074D8
		public Vector2 referenceResolution
		{
			get
			{
				float x = this.m_ReferenceResolution.x;
				float y = this.m_ReferenceResolution.y;
				Vector2 vector;
				return vector;
			}
			set
			{
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600025B RID: 603 RVA: 0x000092E8 File Offset: 0x000074E8
		// (set) Token: 0x0600025C RID: 604 RVA: 0x000092FC File Offset: 0x000074FC
		public CanvasScaler.ScreenMatchMode screenMatchMode
		{
			get
			{
				return this.m_ScreenMatchMode;
			}
			set
			{
				this.m_ScreenMatchMode = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00009310 File Offset: 0x00007510
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00009324 File Offset: 0x00007524
		public float matchWidthOrHeight
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600025D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.CanvasScaler::get_matchWidthOrHeight()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(CanvasScaler::m_MatchWidthOrHeight, ldloc:CanvasScaler(this)))
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

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00009334 File Offset: 0x00007534
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00009348 File Offset: 0x00007548
		public CanvasScaler.Unit physicalUnit
		{
			get
			{
				return this.m_PhysicalUnit;
			}
			set
			{
				this.m_PhysicalUnit = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000261 RID: 609 RVA: 0x0000935C File Offset: 0x0000755C
		// (set) Token: 0x06000262 RID: 610 RVA: 0x00009370 File Offset: 0x00007570
		public float fallbackScreenDPI
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000261)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.CanvasScaler::get_fallbackScreenDPI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(CanvasScaler::m_FallbackScreenDPI, ldloc:CanvasScaler(this)))
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00009380 File Offset: 0x00007580
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00009394 File Offset: 0x00007594
		public float defaultSpriteDPI
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000263)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.CanvasScaler::get_defaultSpriteDPI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(CanvasScaler::m_DefaultSpriteDPI, ldloc:CanvasScaler(this)))
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

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000265 RID: 613 RVA: 0x000093A4 File Offset: 0x000075A4
		// (set) Token: 0x06000266 RID: 614 RVA: 0x000093B8 File Offset: 0x000075B8
		public float dynamicPixelsPerUnit
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000265)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.CanvasScaler::get_dynamicPixelsPerUnit()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(CanvasScaler::m_DynamicPixelsPerUnit, ldloc:CanvasScaler(this)))
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

		// Token: 0x06000267 RID: 615 RVA: 0x000093C8 File Offset: 0x000075C8
		protected CanvasScaler()
		{
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000093F0 File Offset: 0x000075F0
		protected override void OnEnable()
		{
			base.OnEnable();
			Canvas component = base.GetComponent<Canvas>();
			this.m_Canvas = component;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00009414 File Offset: 0x00007614
		private void Canvas_preWillRenderCanvases()
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00009424 File Offset: 0x00007624
		protected override void OnDisable()
		{
			float prevScaleFactor = this.m_PrevScaleFactor;
			Canvas canvas = this.m_Canvas;
			float prevReferencePixelsPerUnit = this.m_PrevReferencePixelsPerUnit;
			Canvas canvas2 = this.m_Canvas;
			this.m_PrevReferencePixelsPerUnit = (float)17096;
			base.OnDisable();
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00009460 File Offset: 0x00007660
		protected virtual void Handle()
		{
			Canvas canvas = this.m_Canvas;
			if (!true)
			{
			}
			bool isRootCanvas = this.m_Canvas.isRootCanvas;
			RenderMode renderMode = this.m_Canvas.renderMode;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000949C File Offset: 0x0000769C
		protected virtual void HandleWorldCanvas()
		{
			float dynamicPixelsPerUnit = this.m_DynamicPixelsPerUnit;
			float prevScaleFactor = this.m_PrevScaleFactor;
			Canvas canvas = this.m_Canvas;
			this.m_PrevScaleFactor = dynamicPixelsPerUnit;
			float referencePixelsPerUnit = this.m_ReferencePixelsPerUnit;
			float prevReferencePixelsPerUnit = this.m_PrevReferencePixelsPerUnit;
			Canvas canvas2 = this.m_Canvas;
			this.m_PrevReferencePixelsPerUnit = referencePixelsPerUnit;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000094E4 File Offset: 0x000076E4
		protected virtual void HandleConstantPixelSize()
		{
			float scaleFactor = this.m_ScaleFactor;
			float prevScaleFactor = this.m_PrevScaleFactor;
			Canvas canvas = this.m_Canvas;
			this.m_PrevScaleFactor = scaleFactor;
			float referencePixelsPerUnit = this.m_ReferencePixelsPerUnit;
			float prevReferencePixelsPerUnit = this.m_PrevReferencePixelsPerUnit;
			Canvas canvas2 = this.m_Canvas;
			this.m_PrevReferencePixelsPerUnit = referencePixelsPerUnit;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000952C File Offset: 0x0000772C
		protected virtual void HandleScaleWithScreenSize()
		{
			int num = 1;
			Vector2 renderingDisplaySize = this.m_Canvas.renderingDisplaySize;
			int targetDisplay = this.m_Canvas.targetDisplay;
			if (num == 0)
			{
			}
			float y;
			if (this.m_ScreenMatchMode == CanvasScaler.ScreenMatchMode.MatchWidthOrHeight)
			{
				float x = this.m_ReferenceResolution.x;
				if (!true)
				{
				}
				y = this.m_ReferenceResolution.y;
				if (!true)
				{
				}
				float matchWidthOrHeight = this.m_MatchWidthOrHeight;
				return;
			}
			float prevScaleFactor = this.m_PrevScaleFactor;
			double num2;
			this.m_Canvas.scaleFactor = (float)num2;
			this.m_PrevScaleFactor = y;
			float referencePixelsPerUnit = this.m_ReferencePixelsPerUnit;
			float prevReferencePixelsPerUnit = this.m_PrevReferencePixelsPerUnit;
			this.m_Canvas.referencePixelsPerUnit = (float)num2;
			this.m_PrevReferencePixelsPerUnit = referencePixelsPerUnit;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00009604 File Offset: 0x00007804
		protected virtual void HandleConstantPhysicalSize()
		{
			float dpi = Screen.dpi;
			float fallbackScreenDPI = this.m_FallbackScreenDPI;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00009658 File Offset: 0x00007858
		protected void SetScaleFactor(float scaleFactor)
		{
			float prevScaleFactor = this.m_PrevScaleFactor;
			this.m_Canvas.scaleFactor = scaleFactor;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00009678 File Offset: 0x00007878
		protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit)
		{
			float prevReferencePixelsPerUnit = this.m_PrevReferencePixelsPerUnit;
			this.m_Canvas.referencePixelsPerUnit = referencePixelsPerUnit;
		}

		// Token: 0x0400012E RID: 302
		[SerializeField]
		[Tooltip("Determines how UI elements in the Canvas are scaled.")]
		private CanvasScaler.ScaleMode m_UiScaleMode;

		// Token: 0x0400012F RID: 303
		[SerializeField]
		[Tooltip("If a sprite has this 'Pixels Per Unit' setting, then one pixel in the sprite will cover one unit in the UI.")]
		protected float m_ReferencePixelsPerUnit;

		// Token: 0x04000130 RID: 304
		[SerializeField]
		[Tooltip("Scales all UI elements in the Canvas by this factor.")]
		protected float m_ScaleFactor;

		// Token: 0x04000131 RID: 305
		[SerializeField]
		[Tooltip("The resolution the UI layout is designed for. If the screen resolution is larger, the UI will be scaled up, and if it's smaller, the UI will be scaled down. This is done in accordance with the Screen Match Mode.")]
		protected Vector2 m_ReferenceResolution;

		// Token: 0x04000132 RID: 306
		[Tooltip("A mode used to scale the canvas area if the aspect ratio of the current resolution doesn't fit the reference resolution.")]
		[SerializeField]
		protected CanvasScaler.ScreenMatchMode m_ScreenMatchMode;

		// Token: 0x04000133 RID: 307
		[Range(0f, 1f)]
		[SerializeField]
		[Tooltip("Determines if the scaling is using the width or height as reference, or a mix in between.")]
		protected float m_MatchWidthOrHeight;

		// Token: 0x04000134 RID: 308
		private const float kLogBase = 2f;

		// Token: 0x04000135 RID: 309
		[SerializeField]
		[Tooltip("The physical unit to specify positions and sizes in.")]
		protected CanvasScaler.Unit m_PhysicalUnit = CanvasScaler.Unit.Points;

		// Token: 0x04000136 RID: 310
		[SerializeField]
		[Tooltip("The DPI to assume if the screen DPI is not known.")]
		protected float m_FallbackScreenDPI;

		// Token: 0x04000137 RID: 311
		[Tooltip("The pixels per inch to use for sprites that have a 'Pixels Per Unit' setting that matches the 'Reference Pixels Per Unit' setting.")]
		[SerializeField]
		protected float m_DefaultSpriteDPI;

		// Token: 0x04000138 RID: 312
		[SerializeField]
		[Tooltip("The amount of pixels per unit to use for dynamically created bitmaps in the UI, such as Text.")]
		protected float m_DynamicPixelsPerUnit = (float)16256;

		// Token: 0x04000139 RID: 313
		private Canvas m_Canvas;

		// Token: 0x0400013A RID: 314
		[NonSerialized]
		private float m_PrevScaleFactor;

		// Token: 0x0400013B RID: 315
		[NonSerialized]
		private float m_PrevReferencePixelsPerUnit;

		// Token: 0x0400013C RID: 316
		[SerializeField]
		protected bool m_PresetInfoIsWorld;

		// Token: 0x0200003B RID: 59
		public enum ScaleMode
		{
			// Token: 0x0400013E RID: 318
			ConstantPixelSize,
			// Token: 0x0400013F RID: 319
			ScaleWithScreenSize,
			// Token: 0x04000140 RID: 320
			ConstantPhysicalSize
		}

		// Token: 0x0200003C RID: 60
		public enum ScreenMatchMode
		{
			// Token: 0x04000142 RID: 322
			MatchWidthOrHeight,
			// Token: 0x04000143 RID: 323
			Expand,
			// Token: 0x04000144 RID: 324
			Shrink
		}

		// Token: 0x0200003D RID: 61
		public enum Unit
		{
			// Token: 0x04000146 RID: 326
			Centimeters,
			// Token: 0x04000147 RID: 327
			Millimeters,
			// Token: 0x04000148 RID: 328
			Inches,
			// Token: 0x04000149 RID: 329
			Points,
			// Token: 0x0400014A RID: 330
			Picas
		}
	}
}
