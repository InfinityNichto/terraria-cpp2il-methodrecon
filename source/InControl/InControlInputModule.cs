using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace InControl
{
	// Token: 0x02000038 RID: 56
	[AddComponentMenu("Event/InControl Input Module")]
	public class InControlInputModule : PointerInputModule
	{
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00008314 File Offset: 0x00006514
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00008328 File Offset: 0x00006528
		public PlayerAction SubmitAction
		{
			[CompilerGenerated]
			get
			{
				return this.<SubmitAction>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SubmitAction>k__BackingField = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000833C File Offset: 0x0000653C
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00008350 File Offset: 0x00006550
		public PlayerAction CancelAction
		{
			[CompilerGenerated]
			get
			{
				return this.<CancelAction>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CancelAction>k__BackingField = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00008364 File Offset: 0x00006564
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00008378 File Offset: 0x00006578
		public PlayerTwoAxisAction MoveAction
		{
			[CompilerGenerated]
			get
			{
				return this.<MoveAction>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<MoveAction>k__BackingField = value;
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000838C File Offset: 0x0000658C
		protected InControlInputModule()
		{
			this.submitButton.value__ = (int)2.7E-44f;
			this.allowTouchInput = true;
			base..ctor();
			float num = this.analogMoveThreshold;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000083D0 File Offset: 0x000065D0
		public override void UpdateModule()
		{
			Vector3 vector = this.thisMousePosition;
			float z = this.thisMousePosition.z;
			this.lastMousePosition.z = z;
			Vector3 mousePosition = Input.mousePosition;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00008404 File Offset: 0x00006604
		public override bool IsModuleSupported()
		{
			if (!this.forceModuleActive)
			{
				bool mousePresent = Input.mousePresent;
			}
			return true;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000842C File Offset: 0x0000662C
		public override bool ShouldActivateModule()
		{
			/*
An exception occurred when decompiling this method (060002B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.InControlInputModule::ShouldActivateModule()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_3:
	stloc:int32(var_10_89, callgetter:int32(Input::get_touchCount))
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

		// Token: 0x060002B2 RID: 690 RVA: 0x000084C4 File Offset: 0x000066C4
		public override void ActivateModule()
		{
			base.ActivateModule();
			Vector3 mousePosition = Input.mousePosition;
			Vector3 mousePosition2 = Input.mousePosition;
			GameObject currentSelected = this.m_EventSystem.m_CurrentSelected;
			GameObject firstSelected = this.m_EventSystem.m_FirstSelected;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00008504 File Offset: 0x00006704
		public override void Process()
		{
			bool flag = this.SendUpdateEventToSelectedObject();
			if (this.m_EventSystem.m_sendNavigationEvents)
			{
				bool flag2 = this.SendVectorEventToSelectedObject();
				bool flag3 = this.SendButtonEventToSelectedObject();
			}
			if (this.allowTouchInput)
			{
				bool flag4 = this.ProcessTouchEvents();
			}
			if (this.allowMouseInput)
			{
				long num = 0L;
				this.ProcessMouseEvent((int)num);
				return;
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00008558 File Offset: 0x00006758
		private bool ProcessTouchEvents()
		{
			/*
An exception occurred when decompiling this method (060002B4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.InControlInputModule::ProcessTouchEvents()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_07, callgetter:int32(Input::get_touchCount))
	stloc:TouchType(var_2_13, callgetter:TouchType(Touch::get_type, call:Touch[exp:valuetype [UnityEngine.InputLegacyModule]UnityEngine.Touch&](Input::GetTouch, ldc.i4:int32(0))))
	call:void(PointerInputModule::RemovePointerData, ldloc:InControlInputModule[exp:PointerInputModule](this), ldloc:PointerEventData(var_3))
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

		// Token: 0x060002B5 RID: 693 RVA: 0x00008580 File Offset: 0x00006780
		private bool SendButtonEventToSelectedObject()
		{
			GameObject currentSelected = this.m_EventSystem.m_CurrentSelected;
			if (this.thisSubmitState)
			{
				bool flag = this.lastSubmitState;
				GameObject currentSelected2 = this.m_EventSystem.m_CurrentSelected;
				if (!flag)
				{
				}
				if (!true)
				{
				}
			}
			if (this.thisCancelState)
			{
				bool flag2 = this.lastCancelState;
				GameObject currentSelected3 = this.m_EventSystem.m_CurrentSelected;
				if (!flag2)
				{
				}
				if (!true)
				{
				}
			}
			bool flag3;
			return flag3;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000085E4 File Offset: 0x000067E4
		private bool SendVectorEventToSelectedObject()
		{
			/*
An exception occurred when decompiling this method (060002B6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.InControlInputModule::SendVectorEventToSelectedObject()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0053:
	stloc:float32(var_11_59, ldfld:float32(InControlInputModule::nextMoveRepeatTime, ldloc:InControlInputModule(this)))
	stloc:float32(var_13_63, callgetter:float32(Time::get_realtimeSinceStartup))
	stloc:float32(var_14_6B, ldfld:float32(InControlInputModule::moveRepeatDelayDuration, ldloc:InControlInputModule(this)))
	stfld:float32(InControlInputModule::nextMoveRepeatTime, ldloc:InControlInputModule(this), ldloc:float32(var_1_12))
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

		// Token: 0x060002B7 RID: 695 RVA: 0x00008664 File Offset: 0x00006864
		protected override void ProcessMove(PointerEventData pointerEvent)
		{
			GameObject <pointerEnter>k__BackingField = pointerEvent.<pointerEnter>k__BackingField;
			base.ProcessMove(pointerEvent);
			if (this.focusOnMouseHover)
			{
				GameObject <pointerEnter>k__BackingField2 = pointerEvent.<pointerEnter>k__BackingField;
				bool flag = <pointerEnter>k__BackingField != <pointerEnter>k__BackingField2;
				GameObject eventHandler = ExecuteEvents.GetEventHandler(pointerEvent.<pointerEnter>k__BackingField);
				this.m_EventSystem.SetSelectedGameObject(eventHandler, pointerEvent);
				return;
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000086B0 File Offset: 0x000068B0
		private void Update()
		{
			TwoAxisInputControl twoAxisInputControl = this.direction;
			TwoAxisInputControl twoAxisInputControl2 = this.Device.Direction;
			float deltaTime = Time.deltaTime;
			twoAxisInputControl.Filter(twoAxisInputControl2, deltaTime);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000086E0 File Offset: 0x000068E0
		private void UpdateInputState()
		{
			Vector2 vector = this.thisVectorState;
			this.lastVectorState = vector;
			TwoAxisInputControl twoAxisInputControl;
			if (this.<MoveAction>k__BackingField == null)
			{
				twoAxisInputControl = this.direction;
			}
			float <X>k__BackingField = twoAxisInputControl.<X>k__BackingField;
			float num = this.analogMoveThreshold;
			float <X>k__BackingField2 = twoAxisInputControl.<X>k__BackingField;
			this.thisVectorState.x = <X>k__BackingField2;
			float <Y>k__BackingField = twoAxisInputControl.<Y>k__BackingField;
			float num2 = this.analogMoveThreshold;
			float <Y>k__BackingField2 = twoAxisInputControl.<Y>k__BackingField;
			this.thisVectorState.y = <Y>k__BackingField2;
			bool vectorIsReleased = this.VectorIsReleased;
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00008830 File Offset: 0x00006A30
		// (set) Token: 0x060002BA RID: 698 RVA: 0x0000881C File Offset: 0x00006A1C
		public InputDevice Device
		{
			get
			{
				InputDevice inputDevice = this.inputDevice;
				if (inputDevice != null)
				{
					return inputDevice;
				}
				return InputManager.ActiveDevice;
			}
			set
			{
				this.inputDevice = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00008850 File Offset: 0x00006A50
		private InputControl SubmitButton
		{
			get
			{
				InputDevice device = this.Device;
				InControlInputModule.Button button = this.submitButton;
				InputControl inputControl;
				return inputControl;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0000886C File Offset: 0x00006A6C
		private InputControl CancelButton
		{
			get
			{
				InputDevice device = this.Device;
				InControlInputModule.Button button = this.cancelButton;
				InputControl inputControl;
				return inputControl;
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00008888 File Offset: 0x00006A88
		private void SetVectorRepeatTimer()
		{
			float num = this.nextMoveRepeatTime;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			float num2 = this.moveRepeatDelayDuration;
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002BF RID: 703 RVA: 0x000088AC File Offset: 0x00006AAC
		private bool VectorIsPressed
		{
			get
			{
				/*
An exception occurred when decompiling this method (060002BF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.InControlInputModule::get_VectorIsPressed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector2::x, ldfld:Vector2[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector2&](InControlInputModule::thisVectorState, ldloc:InControlInputModule(this))))
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

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x000088C4 File Offset: 0x00006AC4
		private bool VectorIsReleased
		{
			get
			{
				/*
An exception occurred when decompiling this method (060002C0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.InControlInputModule::get_VectorIsReleased()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector2::x, ldfld:Vector2[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector2&](InControlInputModule::thisVectorState, ldloc:InControlInputModule(this))))
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

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x000088DC File Offset: 0x00006ADC
		private bool VectorHasChanged
		{
			get
			{
				/*
An exception occurred when decompiling this method (060002C1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.InControlInputModule::get_VectorHasChanged()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector2::x, ldfld:Vector2[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector2&](InControlInputModule::thisVectorState, ldloc:InControlInputModule(this))))
	stloc:float32(var_1_17, ldfld:float32(Vector2::y, ldfld:Vector2[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector2&](InControlInputModule::thisVectorState, ldloc:InControlInputModule(this))))
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

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00008900 File Offset: 0x00006B00
		private bool VectorWasPressed
		{
			get
			{
				if (this.moveWasRepeated)
				{
					return true;
				}
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00008918 File Offset: 0x00006B18
		private bool SubmitWasPressed
		{
			get
			{
				if (this.thisSubmitState)
				{
					bool flag = this.lastSubmitState;
					return;
				}
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00008938 File Offset: 0x00006B38
		private bool SubmitWasReleased
		{
			get
			{
				while (!this.thisSubmitState)
				{
				}
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00008950 File Offset: 0x00006B50
		private bool CancelWasPressed
		{
			get
			{
				if (this.thisCancelState)
				{
					bool flag = this.lastCancelState;
					return;
				}
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00008970 File Offset: 0x00006B70
		private bool MouseHasMoved
		{
			get
			{
				/*
An exception occurred when decompiling this method (060002C6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.InControlInputModule::get_MouseHasMoved()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector3::x, ldfld:Vector3[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3&](InControlInputModule::thisMousePosition, ldloc:InControlInputModule(this))))
	stloc:float32(var_1_17, ldfld:float32(Vector3::x, ldfld:Vector3[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3&](InControlInputModule::lastMousePosition, ldloc:InControlInputModule(this))))
	stloc:float32(var_2_23, ldfld:float32(Vector3::y, ldfld:Vector3[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3&](InControlInputModule::lastMousePosition, ldloc:InControlInputModule(this))))
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
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x000089A0 File Offset: 0x00006BA0
		private bool MouseButtonIsPressed
		{
			get
			{
				return Input.GetMouseButtonDown(0);
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000089B4 File Offset: 0x00006BB4
		protected bool SendUpdateEventToSelectedObject()
		{
			/*
An exception occurred when decompiling this method (060002C8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.InControlInputModule::SendUpdateEventToSelectedObject()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:GameObject(var_0_0B, ldfld:GameObject(EventSystem::m_CurrentSelected, ldfld:EventSystem(BaseInputModule::m_EventSystem, ldloc:InControlInputModule[exp:BaseInputModule](this))))
	stloc:GameObject(var_3_19, ldfld:GameObject(EventSystem::m_CurrentSelected, ldfld:EventSystem(BaseInputModule::m_EventSystem, ldloc:InControlInputModule[exp:BaseInputModule](this))))
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

		// Token: 0x060002C9 RID: 713 RVA: 0x000089E0 File Offset: 0x00006BE0
		protected void ProcessMouseEvent()
		{
			long num = 0L;
			this.ProcessMouseEvent((int)num);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000089F8 File Offset: 0x00006BF8
		protected void ProcessMouseEvent(int id)
		{
			PointerInputModule.ButtonState buttonState;
			PointerInputModule.MouseButtonEventData eventData = buttonState.m_EventData;
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
			RaycastResult <pointerCurrentRaycast>k__BackingField = eventData.buttonData.<pointerCurrentRaycast>k__BackingField;
			PointerEventData buttonData6 = eventData.buttonData;
			if (!true)
			{
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00008A9C File Offset: 0x00006C9C
		protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data)
		{
			PointerEventData buttonData = data.buttonData;
			RaycastResult <pointerCurrentRaycast>k__BackingField = buttonData.<pointerCurrentRaycast>k__BackingField;
			bool flag = data.PressedThisFrame();
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
			bool flag2 = gameObject == <lastPress>k__BackingField;
			float <clickTime>k__BackingField = buttonData.<clickTime>k__BackingField;
			int <clickCount>k__BackingField = buttonData.<clickCount>k__BackingField;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00008C08 File Offset: 0x00006E08
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

		// Token: 0x04000289 RID: 649
		public InControlInputModule.Button submitButton;

		// Token: 0x0400028A RID: 650
		public InControlInputModule.Button cancelButton;

		// Token: 0x0400028B RID: 651
		[Range(0.1f, 0.9f)]
		public float analogMoveThreshold;

		// Token: 0x0400028C RID: 652
		public float moveRepeatFirstDuration;

		// Token: 0x0400028D RID: 653
		public float moveRepeatDelayDuration = (float)52429;

		// Token: 0x0400028E RID: 654
		[FormerlySerializedAs("allowMobileDevice")]
		public bool forceModuleActive;

		// Token: 0x0400028F RID: 655
		public bool allowMouseInput = true;

		// Token: 0x04000290 RID: 656
		public bool focusOnMouseHover;

		// Token: 0x04000291 RID: 657
		public bool allowTouchInput;

		// Token: 0x04000292 RID: 658
		private InputDevice inputDevice;

		// Token: 0x04000293 RID: 659
		private Vector3 thisMousePosition;

		// Token: 0x04000294 RID: 660
		private Vector3 lastMousePosition;

		// Token: 0x04000295 RID: 661
		private Vector2 thisVectorState;

		// Token: 0x04000296 RID: 662
		private Vector2 lastVectorState;

		// Token: 0x04000297 RID: 663
		private bool thisSubmitState;

		// Token: 0x04000298 RID: 664
		private bool lastSubmitState;

		// Token: 0x04000299 RID: 665
		private bool thisCancelState;

		// Token: 0x0400029A RID: 666
		private bool lastCancelState;

		// Token: 0x0400029B RID: 667
		private bool moveWasRepeated;

		// Token: 0x0400029C RID: 668
		private float nextMoveRepeatTime;

		// Token: 0x0400029D RID: 669
		private TwoAxisInputControl direction;

		// Token: 0x0400029E RID: 670
		[CompilerGenerated]
		private PlayerAction <SubmitAction>k__BackingField;

		// Token: 0x0400029F RID: 671
		[CompilerGenerated]
		private PlayerAction <CancelAction>k__BackingField;

		// Token: 0x040002A0 RID: 672
		[CompilerGenerated]
		private PlayerTwoAxisAction <MoveAction>k__BackingField;

		// Token: 0x02000039 RID: 57
		public enum Button
		{
			// Token: 0x040002A2 RID: 674
			Action1 = 19,
			// Token: 0x040002A3 RID: 675
			Action2,
			// Token: 0x040002A4 RID: 676
			Action3,
			// Token: 0x040002A5 RID: 677
			Action4
		}
	}
}
