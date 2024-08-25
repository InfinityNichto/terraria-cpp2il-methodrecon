using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200005E RID: 94
	[AddComponentMenu("UI/Scrollbar", 36)]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0000BA2C File Offset: 0x00009C2C
		// (set) Token: 0x0600038B RID: 907 RVA: 0x0000BA40 File Offset: 0x00009C40
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

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0000BA5C File Offset: 0x00009C5C
		// (set) Token: 0x0600038D RID: 909 RVA: 0x0000BA70 File Offset: 0x00009C70
		public Scrollbar.Direction direction
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

		// Token: 0x0600038E RID: 910 RVA: 0x0000BA84 File Offset: 0x00009C84
		protected Scrollbar()
		{
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0000BAA4 File Offset: 0x00009CA4
		// (set) Token: 0x06000390 RID: 912 RVA: 0x0000BAC8 File Offset: 0x00009CC8
		public float value
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600038F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Scrollbar::get_value()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Scrollbar::m_NumberOfSteps, ldloc:Scrollbar(this)))
	stloc:float32(var_1_0D, ldfld:float32(Scrollbar::m_Value, ldloc:Scrollbar(this)))
	stloc:int32(var_2_14, ldfld:int32(Scrollbar::m_NumberOfSteps, ldloc:Scrollbar(this)))
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
				this.Set(value, true);
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000BAE0 File Offset: 0x00009CE0
		public virtual void SetValueWithoutNotify(float input)
		{
			long num = 0L;
			this.Set(input, num != 0L);
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0000BAF8 File Offset: 0x00009CF8
		// (set) Token: 0x06000393 RID: 915 RVA: 0x0000BB0C File Offset: 0x00009D0C
		public float size
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000392)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Scrollbar::get_size()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Scrollbar::m_Size, ldloc:Scrollbar(this)))
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
				this.UpdateVisuals();
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0000BB20 File Offset: 0x00009D20
		// (set) Token: 0x06000395 RID: 917 RVA: 0x0000BB34 File Offset: 0x00009D34
		public int numberOfSteps
		{
			get
			{
				return this.m_NumberOfSteps;
			}
			set
			{
				float value2 = this.m_Value;
				this.UpdateVisuals();
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0000BB50 File Offset: 0x00009D50
		// (set) Token: 0x06000397 RID: 919 RVA: 0x0000BB64 File Offset: 0x00009D64
		public Scrollbar.ScrollEvent onValueChanged
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

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0000BB78 File Offset: 0x00009D78
		private float stepSize
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000398)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Scrollbar::get_stepSize()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Scrollbar::m_NumberOfSteps, ldloc:Scrollbar(this)))
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

		// Token: 0x06000399 RID: 921 RVA: 0x0000BB8C File Offset: 0x00009D8C
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000BB9C File Offset: 0x00009D9C
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000BBAC File Offset: 0x00009DAC
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000BBBC File Offset: 0x00009DBC
		protected override void OnEnable()
		{
			base.OnEnable();
			this.UpdateCachedReferences();
			float value = this.m_Value;
			this.UpdateVisuals();
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000BBE4 File Offset: 0x00009DE4
		protected override void OnDisable()
		{
			base.OnDisable();
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		protected virtual void Update()
		{
			if (this.m_DelayedUpdateVisuals)
			{
				this.UpdateVisuals();
				return;
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000BC14 File Offset: 0x00009E14
		private void UpdateCachedReferences()
		{
			RectTransform handleRect = this.m_HandleRect;
			if (!true)
			{
			}
			bool flag = handleRect;
			Transform parent = this.m_HandleRect.parent;
			RectTransform component = this.m_HandleRect.parent.GetComponent<RectTransform>();
			this.m_ContainerRect = component;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000BC5C File Offset: 0x00009E5C
		private void Set(float input, bool sendCallback = true)
		{
			float value = this.m_Value;
			float value2 = this.value;
			this.UpdateVisuals();
			UISystemProfilerApi.AddMarker("Scrollbar.value", this);
			Scrollbar.ScrollEvent onValueChanged = this.m_OnValueChanged;
			float value3 = this.value;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000BC98 File Offset: 0x00009E98
		protected override void OnRectTransformDimensionsChange()
		{
			base.OnRectTransformDimensionsChange();
			this.UpdateVisuals();
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		private Scrollbar.Axis axis
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003A2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.UI.Scrollbar/Axis UnityEngine.UI.Scrollbar::get_axis()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Direction(var_0_06, ldfld:Direction(Scrollbar::m_Direction, ldloc:Scrollbar(this)))
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

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0000BCC8 File Offset: 0x00009EC8
		private bool reverseValue
		{
			get
			{
				/*
An exception occurred when decompiling this method (060003A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.Scrollbar::get_reverseValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Direction(var_0_06, ldfld:Direction(Scrollbar::m_Direction, ldloc:Scrollbar(this)))
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

		// Token: 0x060003A4 RID: 932 RVA: 0x0000BCDC File Offset: 0x00009EDC
		private void UpdateVisuals()
		{
			int num = 1;
			RectTransform containerRect = this.m_ContainerRect;
			if (num == 0)
			{
			}
			RectTransform handleRect = this.m_HandleRect;
			float value = this.value;
			float size = this.m_Size;
			Scrollbar.Direction direction = this.m_Direction;
			RectTransform handleRect2 = this.m_HandleRect;
			RectTransform handleRect3 = this.m_HandleRect;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000BD28 File Offset: 0x00009F28
		private void UpdateDrag(PointerEventData eventData)
		{
			if (eventData.<button>k__BackingField == PointerEventData.InputButton.Left)
			{
				RectTransform containerRect = this.m_ContainerRect;
				RectTransform containerRect2 = this.m_ContainerRect;
				Camera pressEventCamera = eventData.pressEventCamera;
				RectTransform containerRect3 = this.m_ContainerRect;
				float x = this.m_Offset.x;
				float y = this.m_Offset.y;
				Vector2 position = containerRect3.rect.position;
				Vector2 size = this.m_HandleRect.rect.size;
				Vector2 sizeDelta = this.m_HandleRect.sizeDelta;
				RectTransform containerRect4 = this.m_ContainerRect;
				Scrollbar.Direction direction = this.m_Direction;
				Rect rect = containerRect4.rect;
				float width = rect.width;
				return;
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000BDDC File Offset: 0x00009FDC
		private void DoUpdateDrag(Vector2 handleCorner, float remainingSize)
		{
			Scrollbar.Direction direction = this.m_Direction;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000BE00 File Offset: 0x0000A000
		private bool MayDrag(PointerEventData eventData)
		{
			/*
An exception occurred when decompiling this method (060003A7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.Scrollbar::MayDrag(UnityEngine.EventSystems.PointerEventData)

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

		// Token: 0x060003A8 RID: 936 RVA: 0x0000BE18 File Offset: 0x0000A018
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
			if (eventData.<button>k__BackingField == PointerEventData.InputButton.Left)
			{
				RectTransform containerRect = this.m_ContainerRect;
				RectTransform handleRect = this.m_HandleRect;
				float x = eventData.<pointerPressRaycast>k__BackingField.screenPosition.x;
				float y = eventData.<pointerPressRaycast>k__BackingField.screenPosition.y;
				Camera enterEventCamera = eventData.enterEventCamera;
				RectTransform handleRect2 = this.m_HandleRect;
				float x2 = eventData.<pointerPressRaycast>k__BackingField.screenPosition.x;
				float y2 = eventData.<pointerPressRaycast>k__BackingField.screenPosition.y;
				Camera pressEventCamera = eventData.pressEventCamera;
				Vector2 center = this.m_HandleRect.rect.center;
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000BEAC File Offset: 0x0000A0AC
		public virtual void OnDrag(PointerEventData eventData)
		{
			if (eventData.<button>k__BackingField == PointerEventData.InputButton.Left)
			{
				RectTransform containerRect = this.m_ContainerRect;
				this.UpdateDrag(eventData);
				return;
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000BED0 File Offset: 0x0000A0D0
		public override void OnPointerDown(PointerEventData eventData)
		{
			if (eventData.<button>k__BackingField == PointerEventData.InputButton.Left)
			{
				base.OnPointerDown(eventData);
				this.isPointerDownAndNotDragging = true;
				float x = eventData.<pointerPressRaycast>k__BackingField.screenPosition.x;
				float y = eventData.<pointerPressRaycast>k__BackingField.screenPosition.y;
				Camera enterEventCamera = eventData.enterEventCamera;
				IEnumerator enumerator;
				Coroutine coroutine = base.StartCoroutine(enumerator);
				this.m_PointerDownRepeat = coroutine;
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000BF30 File Offset: 0x0000A130
		protected IEnumerator ClickRepeat(PointerEventData eventData)
		{
			float x = eventData.<pointerPressRaycast>k__BackingField.screenPosition.x;
			float y = eventData.<pointerPressRaycast>k__BackingField.screenPosition.y;
			Camera enterEventCamera = eventData.enterEventCamera;
			IEnumerator enumerator;
			return enumerator;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002207 File Offset: 0x00000407
		protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000BF68 File Offset: 0x0000A168
		public override void OnPointerUp(PointerEventData eventData)
		{
			if (eventData.<button>k__BackingField == PointerEventData.InputButton.Left)
			{
				base.EvaluateAndTransitionToSelectionState();
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000BF84 File Offset: 0x0000A184
		public override void OnMove(AxisEventData eventData)
		{
			MoveDirection <moveDir>k__BackingField = eventData.<moveDir>k__BackingField;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000C01C File Offset: 0x0000A21C
		public override Selectable FindSelectableOnLeft()
		{
			Navigation navigation = this.m_Navigation;
			Scrollbar.Direction direction = this.m_Direction;
			return base.FindSelectableOnLeft();
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000C040 File Offset: 0x0000A240
		public override Selectable FindSelectableOnRight()
		{
			Navigation navigation = this.m_Navigation;
			Scrollbar.Direction direction = this.m_Direction;
			return base.FindSelectableOnRight();
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000C064 File Offset: 0x0000A264
		public override Selectable FindSelectableOnUp()
		{
			Navigation navigation = this.m_Navigation;
			Scrollbar.Direction direction = this.m_Direction;
			return base.FindSelectableOnUp();
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000C088 File Offset: 0x0000A288
		public override Selectable FindSelectableOnDown()
		{
			Navigation navigation = this.m_Navigation;
			Scrollbar.Direction direction = this.m_Direction;
			return base.FindSelectableOnDown();
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000C0AC File Offset: 0x0000A2AC
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000C0BC File Offset: 0x0000A2BC
		public void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts)
		{
			Scrollbar.Direction direction2 = this.m_Direction;
			this.direction = direction;
			Scrollbar.Direction direction3 = this.m_Direction;
			Transform transform = base.transform;
			if (transform != null)
			{
				return;
			}
			Scrollbar.Direction direction4 = this.m_Direction;
			Transform transform2 = base.transform;
			Scrollbar.Direction direction5 = this.m_Direction;
			if (transform2 != null)
			{
				return;
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000C114 File Offset: 0x0000A314
		Transform ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x040001BB RID: 443
		[SerializeField]
		private RectTransform m_HandleRect;

		// Token: 0x040001BC RID: 444
		[SerializeField]
		private Scrollbar.Direction m_Direction;

		// Token: 0x040001BD RID: 445
		[SerializeField]
		[Range(0f, 1f)]
		private float m_Value;

		// Token: 0x040001BE RID: 446
		[SerializeField]
		[Range(0f, 1f)]
		private float m_Size = (float)52429;

		// Token: 0x040001BF RID: 447
		[Range(0f, 11f)]
		[SerializeField]
		private int m_NumberOfSteps;

		// Token: 0x040001C0 RID: 448
		[Space(6f)]
		[SerializeField]
		private Scrollbar.ScrollEvent m_OnValueChanged;

		// Token: 0x040001C1 RID: 449
		private RectTransform m_ContainerRect;

		// Token: 0x040001C2 RID: 450
		private Vector2 m_Offset;

		// Token: 0x040001C3 RID: 451
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x040001C4 RID: 452
		private Coroutine m_PointerDownRepeat;

		// Token: 0x040001C5 RID: 453
		private bool isPointerDownAndNotDragging;

		// Token: 0x040001C6 RID: 454
		private bool m_DelayedUpdateVisuals;

		// Token: 0x0200005F RID: 95
		public enum Direction
		{
			// Token: 0x040001C8 RID: 456
			LeftToRight,
			// Token: 0x040001C9 RID: 457
			RightToLeft,
			// Token: 0x040001CA RID: 458
			BottomToTop,
			// Token: 0x040001CB RID: 459
			TopToBottom
		}

		// Token: 0x02000060 RID: 96
		[Serializable]
		public class ScrollEvent : UnityEvent<float>
		{
			// Token: 0x060003B6 RID: 950 RVA: 0x0000C128 File Offset: 0x0000A328
			public ScrollEvent()
			{
			}
		}

		// Token: 0x02000061 RID: 97
		private enum Axis
		{
			// Token: 0x040001CD RID: 461
			Horizontal,
			// Token: 0x040001CE RID: 462
			Vertical
		}

		// Token: 0x02000062 RID: 98
		[CompilerGenerated]
		private sealed class <ClickRepeat>d__58 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060003B7 RID: 951 RVA: 0x0000C138 File Offset: 0x0000A338
			[DebuggerHidden]
			public <ClickRepeat>d__58(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x0000C154 File Offset: 0x0000A354
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060003B9 RID: 953 RVA: 0x0000C164 File Offset: 0x0000A364
			private bool MoveNext()
			{
				int num = this.<>1__state;
				Scrollbar scrollbar = this.<>4__this;
				this.<>1__state = num;
				bool isPointerDownAndNotDragging = scrollbar.isPointerDownAndNotDragging;
				float value3;
				if (isPointerDownAndNotDragging)
				{
					RectTransform handleRect = scrollbar.m_HandleRect;
					float x = this.screenPosition.x;
					float y = this.screenPosition.y;
					Camera camera = this.camera;
					if (!isPointerDownAndNotDragging)
					{
					}
					RectTransform handleRect2 = scrollbar.m_HandleRect;
					float x2 = this.screenPosition.x;
					float y2 = this.screenPosition.y;
					Camera camera2 = this.camera;
					if (!isPointerDownAndNotDragging)
					{
					}
					Scrollbar.Direction direction = scrollbar.m_Direction;
					float size = scrollbar.m_Size;
					float value = scrollbar.value;
					Scrollbar.Direction direction2 = scrollbar.m_Direction;
					scrollbar.Set(value, true);
					float value2 = scrollbar.value;
					scrollbar.Set(value2, true);
					value3 = scrollbar.value;
				}
				Coroutine pointerDownRepeat = scrollbar.m_PointerDownRepeat;
				scrollbar.StopCoroutine(pointerDownRepeat);
				scrollbar.Set(value3, true);
				this.<>1__state = 1;
				return true;
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x060003BA RID: 954 RVA: 0x0000C254 File Offset: 0x0000A454
			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060003BB RID: 955 RVA: 0x00002207 File Offset: 0x00000407
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x060003BC RID: 956 RVA: 0x0000C268 File Offset: 0x0000A468
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x040001CF RID: 463
			private int <>1__state;

			// Token: 0x040001D0 RID: 464
			private object <>2__current;

			// Token: 0x040001D1 RID: 465
			public Scrollbar <>4__this;

			// Token: 0x040001D2 RID: 466
			public Vector2 screenPosition;

			// Token: 0x040001D3 RID: 467
			public Camera camera;
		}
	}
}
