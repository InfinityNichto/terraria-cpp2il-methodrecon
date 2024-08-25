using System;
using UnityEngine.Serialization;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000B7 RID: 183
	[AddComponentMenu("Event/Standalone Input Module")]
	public class StandaloneInputModule : PointerInputModule
	{
		// Token: 0x06000692 RID: 1682 RVA: 0x0001299C File Offset: 0x00010B9C
		protected StandaloneInputModule()
		{
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x000129DC File Offset: 0x00010BDC
		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public StandaloneInputModule.InputMode inputMode
		{
			get
			{
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x000129EC File Offset: 0x00010BEC
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x00012A00 File Offset: 0x00010C00
		[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
		public bool allowActivationOnMobileDevice
		{
			get
			{
				return this.m_ForceModuleActive;
			}
			set
			{
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x00012A10 File Offset: 0x00010C10
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x00012A24 File Offset: 0x00010C24
		[Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
		public bool forceModuleActive
		{
			get
			{
				return this.m_ForceModuleActive;
			}
			set
			{
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x00012A34 File Offset: 0x00010C34
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x00012A48 File Offset: 0x00010C48
		public float inputActionsPerSecond
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000698)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.EventSystems.StandaloneInputModule::get_inputActionsPerSecond()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(StandaloneInputModule::m_InputActionsPerSecond, ldloc:StandaloneInputModule(this)))
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

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x00012A58 File Offset: 0x00010C58
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x00012A6C File Offset: 0x00010C6C
		public float repeatDelay
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600069A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.EventSystems.StandaloneInputModule::get_repeatDelay()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(StandaloneInputModule::m_RepeatDelay, ldloc:StandaloneInputModule(this)))
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

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x00012A7C File Offset: 0x00010C7C
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x00012A90 File Offset: 0x00010C90
		public string horizontalAxis
		{
			get
			{
				return this.m_HorizontalAxis;
			}
			set
			{
				this.m_HorizontalAxis = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00012AA4 File Offset: 0x00010CA4
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x00012AB8 File Offset: 0x00010CB8
		public string verticalAxis
		{
			get
			{
				return this.m_VerticalAxis;
			}
			set
			{
				this.m_VerticalAxis = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00012ACC File Offset: 0x00010CCC
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x00012AE0 File Offset: 0x00010CE0
		public string submitButton
		{
			get
			{
				return this.m_SubmitButton;
			}
			set
			{
				this.m_SubmitButton = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00012AF4 File Offset: 0x00010CF4
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x00012B08 File Offset: 0x00010D08
		public string cancelButton
		{
			get
			{
				return this.m_CancelButton;
			}
			set
			{
				this.m_CancelButton = value;
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00012B1C File Offset: 0x00010D1C
		private bool ShouldIgnoreEventsOnNoFocus()
		{
			return true;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00012B2C File Offset: 0x00010D2C
		public override void UpdateModule()
		{
			if (this.m_EventSystem.m_HasFocus)
			{
				Vector2 mousePosition = this.m_MousePosition;
				this.m_LastMousePosition = mousePosition;
				BaseInput input = base.input;
				return;
			}
			PointerEventData inputPointerEvent = this.m_InputPointerEvent;
			if (inputPointerEvent != null)
			{
				GameObject <pointerDrag>k__BackingField = inputPointerEvent.<pointerDrag>k__BackingField;
				PointerEventData inputPointerEvent2 = this.m_InputPointerEvent;
				if (inputPointerEvent2.<dragging>k__BackingField)
				{
					RaycastResult <pointerCurrentRaycast>k__BackingField = inputPointerEvent2.<pointerCurrentRaycast>k__BackingField;
				}
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00012B88 File Offset: 0x00010D88
		private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo)
		{
			GameObject pointerPress = pointerEvent.m_PointerPress;
			if (!true)
			{
			}
			if (!true)
			{
			}
			GameObject eventHandler = ExecuteEvents.GetEventHandler(currentOverGo);
			bool flag = pointerEvent.<pointerClick>k__BackingField == eventHandler;
			bool <eligibleForClick>k__BackingField = pointerEvent.<eligibleForClick>k__BackingField;
			if (<eligibleForClick>k__BackingField)
			{
				GameObject <pointerClick>k__BackingField = pointerEvent.<pointerClick>k__BackingField;
				if (!<eligibleForClick>k__BackingField)
				{
				}
				if (!true)
				{
				}
			}
			GameObject <pointerDrag>k__BackingField = pointerEvent.<pointerDrag>k__BackingField;
			if (!true)
			{
			}
			bool <dragging>k__BackingField = pointerEvent.<dragging>k__BackingField;
			if (<dragging>k__BackingField)
			{
				if (!<dragging>k__BackingField)
				{
				}
				if (!true)
				{
				}
			}
			GameObject <pointerDrag>k__BackingField2 = pointerEvent.<pointerDrag>k__BackingField;
			if (!true)
			{
			}
			bool <dragging>k__BackingField2 = pointerEvent.<dragging>k__BackingField;
			if (<dragging>k__BackingField2)
			{
				GameObject <pointerDrag>k__BackingField3 = pointerEvent.<pointerDrag>k__BackingField;
				if (!<dragging>k__BackingField2)
				{
				}
				if (!true)
				{
				}
			}
			GameObject <pointerEnter>k__BackingField = pointerEvent.<pointerEnter>k__BackingField;
			if (!true)
			{
			}
			bool flag2 = currentOverGo != <pointerEnter>k__BackingField;
			base.HandlePointerExitAndEnter(pointerEvent, currentOverGo);
			this.m_InputPointerEvent = pointerEvent;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00012C3C File Offset: 0x00010E3C
		public override bool ShouldActivateModule()
		{
			/*
An exception occurred when decompiling this method (060006A7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.EventSystems.StandaloneInputModule::ShouldActivateModule()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, call:bool(BaseInputModule::ShouldActivateModule, ldloc:StandaloneInputModule[exp:BaseInputModule](this)))
	stloc:bool(var_1_0D, ldfld:bool(StandaloneInputModule::m_ForceModuleActive, ldloc:StandaloneInputModule(this)))
	stloc:BaseInput(var_2_14, callgetter:BaseInput(BaseInputModule::get_input, ldloc:StandaloneInputModule[exp:BaseInputModule](this)))
	stloc:string(var_3_1B, ldfld:string(StandaloneInputModule::m_SubmitButton, ldloc:StandaloneInputModule(this)))
	stloc:BaseInput(var_4_22, callgetter:BaseInput(BaseInputModule::get_input, ldloc:StandaloneInputModule[exp:BaseInputModule](this)))
	stloc:string(var_5_2A, ldfld:string(StandaloneInputModule::m_CancelButton, ldloc:StandaloneInputModule(this)))
	stloc:BaseInput(var_6_32, callgetter:BaseInput(BaseInputModule::get_input, ldloc:StandaloneInputModule[exp:BaseInputModule](this)))
	stloc:string(var_7_3A, ldfld:string(StandaloneInputModule::m_HorizontalAxis, ldloc:StandaloneInputModule(this)))
	stloc:BaseInput(var_8_42, callgetter:BaseInput(BaseInputModule::get_input, ldloc:StandaloneInputModule[exp:BaseInputModule](this)))
	stloc:string(var_9_4A, ldfld:string(StandaloneInputModule::m_VerticalAxis, ldloc:StandaloneInputModule(this)))
	stloc:float32(var_10_57, ldfld:float32(Vector2::x, ldfld:Vector2[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector2&](StandaloneInputModule::m_LastMousePosition, ldloc:StandaloneInputModule(this))))
	stloc:float32(var_11_64, ldfld:float32(Vector2::y, ldfld:Vector2[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector2&](StandaloneInputModule::m_LastMousePosition, ldloc:StandaloneInputModule(this))))
	stloc:BaseInput(var_12_6C, callgetter:BaseInput(BaseInputModule::get_input, ldloc:StandaloneInputModule[exp:BaseInputModule](this)))
	stloc:BaseInput(var_13_74, callgetter:BaseInput(BaseInputModule::get_input, ldloc:StandaloneInputModule[exp:BaseInputModule](this)))
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

		// Token: 0x060006A8 RID: 1704 RVA: 0x00012CC0 File Offset: 0x00010EC0
		public override void ActivateModule()
		{
			if (this.m_EventSystem.m_HasFocus)
			{
				BaseInput input = base.input;
				BaseInput input2 = base.input;
				GameObject currentSelected = this.m_EventSystem.m_CurrentSelected;
				GameObject firstSelected = this.m_EventSystem.m_FirstSelected;
				return;
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00012D04 File Offset: 0x00010F04
		public override void DeactivateModule()
		{
			base.ClearSelection();
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00012D18 File Offset: 0x00010F18
		public override void Process()
		{
			if (this.m_EventSystem.m_HasFocus)
			{
				bool flag = this.SendUpdateEventToSelectedObject();
				bool flag2 = this.ProcessTouchEvents();
				BaseInput input = base.input;
				long num = 0L;
				this.ProcessMouseEvent((int)num);
				bool sendNavigationEvents = this.m_EventSystem.m_sendNavigationEvents;
				bool flag3 = this.SendMoveEventToSelectedObject();
			}
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00012D70 File Offset: 0x00010F70
		private bool ProcessTouchEvents()
		{
			/*
An exception occurred when decompiling this method (060006AB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.EventSystems.StandaloneInputModule::ProcessTouchEvents()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:BaseInput(var_0_06, callgetter:BaseInput(BaseInputModule::get_input, ldloc:StandaloneInputModule[exp:BaseInputModule](this)))
	stloc:BaseInput(var_1_0D, callgetter:BaseInput(BaseInputModule::get_input, ldloc:StandaloneInputModule[exp:BaseInputModule](this)))
	stloc:BaseInput(var_5_16, callgetter:BaseInput(BaseInputModule::get_input, ldloc:StandaloneInputModule[exp:BaseInputModule](this)))
	stloc:BaseInput(var_6_1E, callgetter:BaseInput(BaseInputModule::get_input, ldloc:StandaloneInputModule[exp:BaseInputModule](this)))
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

		// Token: 0x060006AC RID: 1708 RVA: 0x00012D9C File Offset: 0x00010F9C
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
			RaycastResult <pointerCurrentRaycast>k__BackingField = pointerEvent.<pointerCurrentRaycast>k__BackingField;
			int num = 1;
			pointerEvent.<eligibleForClick>k__BackingField = num != 0;
			Vector2 <position>k__BackingField = pointerEvent.<position>k__BackingField;
			pointerEvent.<useDragThreshold>k__BackingField = num != 0;
			pointerEvent.<pressPosition>k__BackingField = <position>k__BackingField;
			GameObject <pointerEnter>k__BackingField = pointerEvent.<pointerEnter>k__BackingField;
			pointerEvent.<pointerEnter>k__BackingField = <pointerCurrentRaycast>k__BackingField;
			if (!true)
			{
			}
			if (<position>k__BackingField == null)
			{
			}
			float unscaledTime = Time.unscaledTime;
			GameObject <lastPress>k__BackingField = pointerEvent.<lastPress>k__BackingField;
			GameObject gameObject;
			bool flag = gameObject == <lastPress>k__BackingField;
			float <clickTime>k__BackingField = pointerEvent.<clickTime>k__BackingField;
			int <clickCount>k__BackingField = pointerEvent.<clickCount>k__BackingField;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00012F0C File Offset: 0x0001110C
		protected bool SendSubmitEventToSelectedObject()
		{
			/*
An exception occurred when decompiling this method (060006AD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.EventSystems.StandaloneInputModule::SendSubmitEventToSelectedObject()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002D:
	stloc:BaseInput(var_7_33, callgetter:BaseInput(BaseInputModule::get_input, ldloc:StandaloneInputModule[exp:BaseInputModule](this)))
	stloc:string(var_8_3B, ldfld:string(StandaloneInputModule::m_CancelButton, ldloc:StandaloneInputModule(this)))
	stloc:GameObject(var_9_48, ldfld:GameObject(EventSystem::m_CurrentSelected, ldfld:EventSystem(BaseInputModule::m_EventSystem, ldloc:StandaloneInputModule[exp:BaseInputModule](this))))
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

		// Token: 0x060006AE RID: 1710 RVA: 0x00012F68 File Offset: 0x00011168
		private Vector2 GetRawMoveVector()
		{
			/*
An exception occurred when decompiling this method (060006AE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector2 UnityEngine.EventSystems.StandaloneInputModule::GetRawMoveVector()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:BaseInput(var_0_06, callgetter:BaseInput(BaseInputModule::get_input, ldloc:StandaloneInputModule[exp:BaseInputModule](this)))
	stloc:string(var_1_0D, ldfld:string(StandaloneInputModule::m_HorizontalAxis, ldloc:StandaloneInputModule(this)))
	stloc:BaseInput(var_2_14, callgetter:BaseInput(BaseInputModule::get_input, ldloc:StandaloneInputModule[exp:BaseInputModule](this)))
	stloc:string(var_3_1B, ldfld:string(StandaloneInputModule::m_VerticalAxis, ldloc:StandaloneInputModule(this)))
	stloc:BaseInput(var_4_22, callgetter:BaseInput(BaseInputModule::get_input, ldloc:StandaloneInputModule[exp:BaseInputModule](this)))
	stloc:string(var_5_2A, ldfld:string(StandaloneInputModule::m_HorizontalAxis, ldloc:StandaloneInputModule(this)))
	stloc:BaseInput(var_6_32, callgetter:BaseInput(BaseInputModule::get_input, ldloc:StandaloneInputModule[exp:BaseInputModule](this)))
	stloc:string(var_7_3A, ldfld:string(StandaloneInputModule::m_VerticalAxis, ldloc:StandaloneInputModule(this)))
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

		// Token: 0x060006AF RID: 1711 RVA: 0x00012FB0 File Offset: 0x000111B0
		protected bool SendMoveEventToSelectedObject()
		{
			float unscaledTime = Time.unscaledTime;
			Vector2 rawMoveVector = this.GetRawMoveVector();
			float x = this.m_LastMoveVector.x;
			float y = this.m_LastMoveVector.y;
			int consecutiveMoveCount = this.m_ConsecutiveMoveCount;
			float prevActionTime = this.m_PrevActionTime;
			float repeatDelay = this.m_RepeatDelay;
			float inputActionsPerSecond = this.m_InputActionsPerSecond;
			float prevActionTime2 = this.m_PrevActionTime;
			AxisEventData axisEventData = this.m_AxisEventData;
			GameObject currentSelected = this.m_EventSystem.m_CurrentSelected;
			if (!true)
			{
			}
			int consecutiveMoveCount2 = this.m_ConsecutiveMoveCount;
			bool flag;
			return flag;
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00013040 File Offset: 0x00011240
		protected void ProcessMouseEvent()
		{
			long num = 0L;
			this.ProcessMouseEvent((int)num);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00013058 File Offset: 0x00011258
		[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
		protected virtual bool ForceAutoSelect()
		{
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00013068 File Offset: 0x00011268
		protected void ProcessMouseEvent(int id)
		{
			PointerInputModule.ButtonState buttonState;
			PointerInputModule.MouseButtonEventData eventData = buttonState.m_EventData;
			RaycastResult <pointerCurrentRaycast>k__BackingField = eventData.buttonData.<pointerCurrentRaycast>k__BackingField;
			this.m_CurrentFocusedGameObject = <pointerCurrentRaycast>k__BackingField;
			this.ProcessMousePress(eventData);
			PointerEventData buttonData = eventData.buttonData;
			PointerEventData buttonData2 = eventData.buttonData;
			PointerInputModule.ButtonState buttonState2;
			PointerInputModule.MouseButtonEventData eventData2 = buttonState2.m_EventData;
			this.ProcessMousePress(eventData2);
			PointerInputModule.ButtonState buttonState3;
			PointerEventData buttonData3 = buttonState3.m_EventData.buttonData;
			PointerInputModule.ButtonState buttonState4;
			PointerInputModule.MouseButtonEventData eventData3 = buttonState4.m_EventData;
			this.ProcessMousePress(eventData3);
			PointerInputModule.ButtonState buttonState5;
			PointerEventData buttonData4 = buttonState5.m_EventData.buttonData;
			PointerEventData buttonData5 = eventData.buttonData;
			float x = buttonData5.<scrollDelta>k__BackingField.x;
			float y = buttonData5.<scrollDelta>k__BackingField.y;
			RaycastResult <pointerCurrentRaycast>k__BackingField2 = eventData.buttonData.<pointerCurrentRaycast>k__BackingField;
			PointerEventData buttonData6 = eventData.buttonData;
			if (!true)
			{
			}
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00013120 File Offset: 0x00011320
		protected bool SendUpdateEventToSelectedObject()
		{
			/*
An exception occurred when decompiling this method (060006B3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.EventSystems.StandaloneInputModule::SendUpdateEventToSelectedObject()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:GameObject(var_0_0B, ldfld:GameObject(EventSystem::m_CurrentSelected, ldfld:EventSystem(BaseInputModule::m_EventSystem, ldloc:StandaloneInputModule[exp:BaseInputModule](this))))
	stloc:GameObject(var_3_19, ldfld:GameObject(EventSystem::m_CurrentSelected, ldfld:EventSystem(BaseInputModule::m_EventSystem, ldloc:StandaloneInputModule[exp:BaseInputModule](this))))
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

		// Token: 0x060006B4 RID: 1716 RVA: 0x0001314C File Offset: 0x0001134C
		protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data)
		{
			PointerEventData buttonData = data.buttonData;
			PointerEventData.FramePressState buttonState = data.buttonState;
			RaycastResult <pointerCurrentRaycast>k__BackingField = buttonData.<pointerCurrentRaycast>k__BackingField;
			int num = 1;
			buttonData.<eligibleForClick>k__BackingField = num != 0;
			Vector2 <position>k__BackingField = buttonData.<position>k__BackingField;
			buttonData.<useDragThreshold>k__BackingField = num != 0;
			buttonData.<pressPosition>k__BackingField = <position>k__BackingField;
			if (!true)
			{
			}
			if (<position>k__BackingField == null)
			{
			}
			float unscaledTime = Time.unscaledTime;
			GameObject <lastPress>k__BackingField = buttonData.<lastPress>k__BackingField;
			GameObject gameObject;
			bool flag = gameObject == <lastPress>k__BackingField;
			float <clickTime>k__BackingField = buttonData.<clickTime>k__BackingField;
			int <clickCount>k__BackingField = buttonData.<clickCount>k__BackingField;
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00013220 File Offset: 0x00011420
		protected GameObject GetCurrentFocusedGameObject()
		{
			return this.m_CurrentFocusedGameObject;
		}

		// Token: 0x040002FB RID: 763
		private float m_PrevActionTime;

		// Token: 0x040002FC RID: 764
		private Vector2 m_LastMoveVector;

		// Token: 0x040002FD RID: 765
		private int m_ConsecutiveMoveCount;

		// Token: 0x040002FE RID: 766
		private Vector2 m_LastMousePosition;

		// Token: 0x040002FF RID: 767
		private Vector2 m_MousePosition;

		// Token: 0x04000300 RID: 768
		private GameObject m_CurrentFocusedGameObject;

		// Token: 0x04000301 RID: 769
		private PointerEventData m_InputPointerEvent;

		// Token: 0x04000302 RID: 770
		[SerializeField]
		private string m_HorizontalAxis = "Horizontal";

		// Token: 0x04000303 RID: 771
		[SerializeField]
		private string m_VerticalAxis = "Vertical";

		// Token: 0x04000304 RID: 772
		[SerializeField]
		private string m_SubmitButton = "Submit";

		// Token: 0x04000305 RID: 773
		[SerializeField]
		private string m_CancelButton = "Cancel";

		// Token: 0x04000306 RID: 774
		[SerializeField]
		private float m_InputActionsPerSecond;

		// Token: 0x04000307 RID: 775
		[SerializeField]
		private float m_RepeatDelay;

		// Token: 0x04000308 RID: 776
		[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
		[HideInInspector]
		[SerializeField]
		private bool m_ForceModuleActive;

		// Token: 0x020000B8 RID: 184
		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public enum InputMode
		{
			// Token: 0x0400030A RID: 778
			Mouse,
			// Token: 0x0400030B RID: 779
			Buttons
		}
	}
}
