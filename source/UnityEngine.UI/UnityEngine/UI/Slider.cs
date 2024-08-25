using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200006B RID: 107
	[ExecuteAlways]
	[AddComponentMenu("UI/Slider", 34)]
	[RequireComponent(typeof(RectTransform))]
	public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
	{
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0000E010 File Offset: 0x0000C210
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x0000E024 File Offset: 0x0000C224
		public RectTransform fillRect
		{
			get
			{
				return this.m_FillRect;
			}
			set
			{
				this.UpdateCachedReferences();
				this.UpdateVisuals();
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x0000E040 File Offset: 0x0000C240
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x0000E054 File Offset: 0x0000C254
		public RectTransform handleRect
		{
			get
			{
				return this.m_HandleRect;
			}
			set
			{
				this.UpdateCachedReferences();
				this.UpdateVisuals();
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x0000E070 File Offset: 0x0000C270
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x0000E084 File Offset: 0x0000C284
		public Slider.Direction direction
		{
			get
			{
				return this.m_Direction;
			}
			set
			{
				this.UpdateVisuals();
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0000E098 File Offset: 0x0000C298
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x0000E0AC File Offset: 0x0000C2AC
		public float minValue
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000460)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Slider::get_minValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Slider::m_MinValue, ldloc:Slider(this)))
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
				float value2 = this.m_Value;
				this.UpdateVisuals();
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0000E0C8 File Offset: 0x0000C2C8
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x0000E0DC File Offset: 0x0000C2DC
		public float maxValue
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000462)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Slider::get_maxValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Slider::m_MaxValue, ldloc:Slider(this)))
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
				float value2 = this.m_Value;
				this.UpdateVisuals();
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0000E0F8 File Offset: 0x0000C2F8
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x0000E10C File Offset: 0x0000C30C
		public bool wholeNumbers
		{
			get
			{
				return this.m_WholeNumbers;
			}
			set
			{
				float value2 = this.m_Value;
				this.UpdateVisuals();
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0000E128 File Offset: 0x0000C328
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x0000E148 File Offset: 0x0000C348
		public virtual float value
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000466)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Slider::get_value()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:bool(var_0_06, ldfld:bool(Slider::m_WholeNumbers, ldloc:Slider(this)))
	stloc:float32(var_1_0D, ldfld:float32(Slider::m_Value, ldloc:Slider(this)))
	brtrue(IL_0000, logicnot:bool(ldloc:bool(var_0_06)))
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
			set
			{
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0000E158 File Offset: 0x0000C358
		public virtual void SetValueWithoutNotify(float input)
		{
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x0000E168 File Offset: 0x0000C368
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x0000E190 File Offset: 0x0000C390
		public float normalizedValue
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000469)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Slider::get_normalizedValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Slider::m_MinValue, ldloc:Slider(this)))
	stloc:float32(var_1_0D, ldfld:float32(Slider::m_MaxValue, ldloc:Slider(this)))
	stloc:float32(var_2_14, ldfld:float32(Slider::m_MinValue, ldloc:Slider(this)))
	stloc:float32(var_3_1B, ldfld:float32(Slider::m_MaxValue, ldloc:Slider(this)))
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
				float minValue = this.m_MinValue;
				float maxValue = this.m_MaxValue;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x0000E1AC File Offset: 0x0000C3AC
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
		public Slider.SliderEvent onValueChanged
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

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0000E1D4 File Offset: 0x0000C3D4
		private float stepSize
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600046D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Slider::get_stepSize()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:float32(var_0_0E, ldfld:float32(Slider::m_MaxValue, ldloc:Slider(this)))
	stloc:float32(var_1_15, ldfld:float32(Slider::m_MinValue, ldloc:Slider(this)))
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

		// Token: 0x0600046E RID: 1134 RVA: 0x0000E1F8 File Offset: 0x0000C3F8
		protected Slider()
		{
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0000E218 File Offset: 0x0000C418
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000E228 File Offset: 0x0000C428
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0000E238 File Offset: 0x0000C438
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0000E248 File Offset: 0x0000C448
		protected override void OnEnable()
		{
			base.OnEnable();
			this.UpdateCachedReferences();
			float value = this.m_Value;
			this.UpdateVisuals();
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0000E270 File Offset: 0x0000C470
		protected override void OnDisable()
		{
			base.OnDisable();
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0000E284 File Offset: 0x0000C484
		protected virtual void Update()
		{
			if (this.m_DelayedUpdateVisuals)
			{
				float value = this.m_Value;
				this.UpdateVisuals();
				return;
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0000E2A8 File Offset: 0x0000C4A8
		protected override void OnDidApplyAnimationProperties()
		{
			float value = this.m_Value;
			this.m_Value = value;
			float normalizedValue = this.normalizedValue;
			RectTransform fillContainerRect = this.m_FillContainerRect;
			if (!true)
			{
			}
			Image fillImage = this.m_FillImage;
			if (!true)
			{
			}
			Image fillImage2 = this.m_FillImage;
			Image.Type type = fillImage2.m_Type;
			float fillAmount = fillImage2.m_FillAmount;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0000E374 File Offset: 0x0000C574
		private void UpdateCachedReferences()
		{
			RectTransform fillRect = this.m_FillRect;
			if (!true)
			{
			}
			bool flag = fillRect;
			RectTransform fillRect2 = this.m_FillRect;
			Transform transform = base.transform;
			if (transform == null)
			{
				return;
			}
			bool flag2 = fillRect2 != transform;
			Transform transform2 = this.m_FillRect.transform;
			this.m_FillTransform = transform2;
			Image component = this.m_FillRect.GetComponent<Image>();
			Transform fillTransform = this.m_FillTransform;
			this.m_FillImage = component;
			Transform parent = fillTransform.parent;
			RectTransform component2 = this.m_FillTransform.parent.GetComponent<RectTransform>();
			this.m_FillContainerRect = component2;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0000E478 File Offset: 0x0000C678
		private float ClampValue(float input)
		{
			/*
An exception occurred when decompiling this method (06000477)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Slider::ClampValue(System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:float32(var_0_06, ldfld:float32(Slider::m_MaxValue, ldloc:Slider(this)))
	stloc:float32(var_1_0D, ldfld:float32(Slider::m_MinValue, ldloc:Slider(this)))
	brtrue(IL_0000, logicnot:bool(ldfld:bool(Slider::m_WholeNumbers, ldloc:Slider(this))))
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

		// Token: 0x06000478 RID: 1144 RVA: 0x0000E49C File Offset: 0x0000C69C
		protected virtual void Set(float input, bool sendCallback = true)
		{
			float num = this.ClampValue(input);
			float value = this.m_Value;
			this.UpdateVisuals();
			UISystemProfilerApi.AddMarker("Slider.value", this);
			Slider.SliderEvent onValueChanged = this.m_OnValueChanged;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000E4D4 File Offset: 0x0000C6D4
		protected override void OnRectTransformDimensionsChange()
		{
			base.OnRectTransformDimensionsChange();
			this.UpdateVisuals();
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
		private Slider.Axis axis
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600047A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.UI.Slider/Axis UnityEngine.UI.Slider::get_axis()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Direction(var_0_06, ldfld:Direction(Slider::m_Direction, ldloc:Slider(this)))
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

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x0000E504 File Offset: 0x0000C704
		private bool reverseValue
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600047B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.Slider::get_reverseValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Direction(var_0_06, ldfld:Direction(Slider::m_Direction, ldloc:Slider(this)))
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

		// Token: 0x0600047C RID: 1148 RVA: 0x0000E518 File Offset: 0x0000C718
		private void UpdateVisuals()
		{
			int num = 1;
			RectTransform fillContainerRect = this.m_FillContainerRect;
			if (num == 0)
			{
			}
			RectTransform fillRect = this.m_FillRect;
			Image fillImage = this.m_FillImage;
			Image fillImage2 = this.m_FillImage;
			Image.Type type = fillImage2.m_Type;
			float normalizedValue = this.normalizedValue;
			fillImage2.fillAmount = normalizedValue;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0000E5BC File Offset: 0x0000C7BC
		private void UpdateDrag(PointerEventData eventData, Camera cam)
		{
			RectTransform fillContainerRect;
			if (this.m_HandleContainerRect == null)
			{
				fillContainerRect = this.m_FillContainerRect;
			}
			Vector2 size = fillContainerRect.rect.size;
			Slider.Direction direction = this.m_Direction;
			Vector2 position = fillContainerRect.rect.position;
			float x = this.m_Offset.x;
			float y = this.m_Offset.y;
			Slider.Direction direction2 = this.m_Direction;
			Vector2 size2 = fillContainerRect.rect.size;
			Slider.Direction direction3 = this.m_Direction;
			float minValue = this.m_MinValue;
			float maxValue = this.m_MaxValue;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0000E640 File Offset: 0x0000C840
		private bool MayDrag(PointerEventData eventData)
		{
			/*
An exception occurred when decompiling this method (0600047E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.Slider::MayDrag(UnityEngine.EventSystems.PointerEventData)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:InputButton(var_0_06, ldfld:InputButton(PointerEventData::<button>k__BackingField, ldloc:PointerEventData(eventData)))
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

		// Token: 0x0600047F RID: 1151 RVA: 0x0000E658 File Offset: 0x0000C858
		public override void OnPointerDown(PointerEventData eventData)
		{
			if (eventData.<button>k__BackingField == PointerEventData.InputButton.Left)
			{
				base.OnPointerDown(eventData);
				RectTransform handleContainerRect = this.m_HandleContainerRect;
				RectTransform handleRect = this.m_HandleRect;
				float x = eventData.<pointerPressRaycast>k__BackingField.screenPosition.x;
				float y = eventData.<pointerPressRaycast>k__BackingField.screenPosition.y;
				Camera enterEventCamera = eventData.enterEventCamera;
				RectTransform handleRect2 = this.m_HandleRect;
				float x2 = eventData.<pointerPressRaycast>k__BackingField.screenPosition.x;
				float y2 = eventData.<pointerPressRaycast>k__BackingField.screenPosition.y;
				Camera pressEventCamera = eventData.pressEventCamera;
				return;
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0000E6E4 File Offset: 0x0000C8E4
		public virtual void OnDrag(PointerEventData eventData)
		{
			if (eventData.<button>k__BackingField != PointerEventData.InputButton.Left)
			{
				return;
			}
			Camera pressEventCamera = eventData.pressEventCamera;
			this.UpdateDrag(eventData, pressEventCamera);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0000E70C File Offset: 0x0000C90C
		public override void OnMove(AxisEventData eventData)
		{
			MoveDirection <moveDir>k__BackingField = eventData.<moveDir>k__BackingField;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0000E790 File Offset: 0x0000C990
		public override Selectable FindSelectableOnLeft()
		{
			Navigation navigation = this.m_Navigation;
			Slider.Direction direction = this.m_Direction;
			return base.FindSelectableOnLeft();
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0000E7B4 File Offset: 0x0000C9B4
		public override Selectable FindSelectableOnRight()
		{
			Navigation navigation = this.m_Navigation;
			Slider.Direction direction = this.m_Direction;
			return base.FindSelectableOnRight();
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
		public override Selectable FindSelectableOnUp()
		{
			Navigation navigation = this.m_Navigation;
			Slider.Direction direction = this.m_Direction;
			return base.FindSelectableOnUp();
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0000E7FC File Offset: 0x0000C9FC
		public override Selectable FindSelectableOnDown()
		{
			Navigation navigation = this.m_Navigation;
			Slider.Direction direction = this.m_Direction;
			return base.FindSelectableOnDown();
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0000E820 File Offset: 0x0000CA20
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0000E830 File Offset: 0x0000CA30
		public void SetDirection(Slider.Direction direction, bool includeRectLayouts)
		{
			Slider.Direction direction2 = this.m_Direction;
			this.direction = direction;
			Slider.Direction direction3 = this.m_Direction;
			Transform transform = base.transform;
			if (transform != null)
			{
				return;
			}
			Slider.Direction direction4 = this.m_Direction;
			Transform transform2 = base.transform;
			Slider.Direction direction5 = this.m_Direction;
			if (transform2 != null)
			{
				return;
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0000E888 File Offset: 0x0000CA88
		Transform ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x0400021C RID: 540
		[SerializeField]
		private RectTransform m_FillRect;

		// Token: 0x0400021D RID: 541
		[SerializeField]
		private RectTransform m_HandleRect;

		// Token: 0x0400021E RID: 542
		[SerializeField]
		[Space]
		private Slider.Direction m_Direction;

		// Token: 0x0400021F RID: 543
		[SerializeField]
		private float m_MinValue;

		// Token: 0x04000220 RID: 544
		[SerializeField]
		private float m_MaxValue = (float)16256;

		// Token: 0x04000221 RID: 545
		[SerializeField]
		private bool m_WholeNumbers;

		// Token: 0x04000222 RID: 546
		[SerializeField]
		protected float m_Value;

		// Token: 0x04000223 RID: 547
		[SerializeField]
		[Space]
		private Slider.SliderEvent m_OnValueChanged;

		// Token: 0x04000224 RID: 548
		private Image m_FillImage;

		// Token: 0x04000225 RID: 549
		private Transform m_FillTransform;

		// Token: 0x04000226 RID: 550
		private RectTransform m_FillContainerRect;

		// Token: 0x04000227 RID: 551
		private Transform m_HandleTransform;

		// Token: 0x04000228 RID: 552
		private RectTransform m_HandleContainerRect;

		// Token: 0x04000229 RID: 553
		private Vector2 m_Offset;

		// Token: 0x0400022A RID: 554
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x0400022B RID: 555
		private bool m_DelayedUpdateVisuals;

		// Token: 0x0200006C RID: 108
		public enum Direction
		{
			// Token: 0x0400022D RID: 557
			LeftToRight,
			// Token: 0x0400022E RID: 558
			RightToLeft,
			// Token: 0x0400022F RID: 559
			BottomToTop,
			// Token: 0x04000230 RID: 560
			TopToBottom
		}

		// Token: 0x0200006D RID: 109
		[Serializable]
		public class SliderEvent : UnityEvent<float>
		{
			// Token: 0x06000489 RID: 1161 RVA: 0x0000E89C File Offset: 0x0000CA9C
			public SliderEvent()
			{
			}
		}

		// Token: 0x0200006E RID: 110
		private enum Axis
		{
			// Token: 0x04000232 RID: 562
			Horizontal,
			// Token: 0x04000233 RID: 563
			Vertical
		}
	}
}
