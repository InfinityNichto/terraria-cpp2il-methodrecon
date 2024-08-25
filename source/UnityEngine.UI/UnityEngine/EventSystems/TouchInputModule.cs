using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000B9 RID: 185
	[Obsolete("TouchInputModule is no longer required as Touch input is now handled in StandaloneInputModule.")]
	[AddComponentMenu("Event/Touch Input Module")]
	public class TouchInputModule : PointerInputModule
	{
		// Token: 0x060006B6 RID: 1718 RVA: 0x00013234 File Offset: 0x00011434
		protected TouchInputModule()
		{
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00013248 File Offset: 0x00011448
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x0001325C File Offset: 0x0001145C
		[Obsolete("allowActivationOnStandalone has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
		public bool allowActivationOnStandalone
		{
			get
			{
				return this.m_ForceModuleActive;
			}
			set
			{
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x0001326C File Offset: 0x0001146C
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x00013280 File Offset: 0x00011480
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

		// Token: 0x060006BB RID: 1723 RVA: 0x00013290 File Offset: 0x00011490
		public override void UpdateModule()
		{
			if (!this.m_EventSystem.m_HasFocus)
			{
				PointerEventData inputPointerEvent = this.m_InputPointerEvent;
				if (inputPointerEvent != null)
				{
					GameObject <pointerDrag>k__BackingField = inputPointerEvent.<pointerDrag>k__BackingField;
					PointerEventData inputPointerEvent2 = this.m_InputPointerEvent;
					bool <dragging>k__BackingField = inputPointerEvent2.<dragging>k__BackingField;
					if (<dragging>k__BackingField)
					{
						GameObject <pointerDrag>k__BackingField2 = inputPointerEvent2.<pointerDrag>k__BackingField;
						if (!<dragging>k__BackingField)
						{
						}
						if (!true)
						{
						}
					}
				}
			}
			Vector2 mousePosition = this.m_MousePosition;
			this.m_LastMousePosition = mousePosition;
			BaseInput input = base.input;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x000132F8 File Offset: 0x000114F8
		public override bool IsModuleSupported()
		{
			while (!this.m_ForceModuleActive)
			{
			}
			return true;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00013310 File Offset: 0x00011510
		public override bool ShouldActivateModule()
		{
			/*
An exception occurred when decompiling this method (060006BD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.EventSystems.TouchInputModule::ShouldActivateModule()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	stloc:BaseInput(var_1_19, callgetter:BaseInput(BaseInputModule::get_input, ldloc:TouchInputModule[exp:BaseInputModule](this)))
	stloc:BaseInput(var_2_20, callgetter:BaseInput(BaseInputModule::get_input, ldloc:TouchInputModule[exp:BaseInputModule](this)))
	stloc:float32(var_3_2C, ldfld:float32(Vector2::x, ldfld:Vector2[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector2&](TouchInputModule::m_LastMousePosition, ldloc:TouchInputModule(this))))
	stloc:float32(var_4_38, ldfld:float32(Vector2::y, ldfld:Vector2[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector2&](TouchInputModule::m_LastMousePosition, ldloc:TouchInputModule(this))))
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

		// Token: 0x060006BE RID: 1726 RVA: 0x00013358 File Offset: 0x00011558
		private bool UseFakeInput()
		{
			/*
An exception occurred when decompiling this method (060006BE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.EventSystems.TouchInputModule::UseFakeInput()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:BaseInput(var_0_06, callgetter:BaseInput(BaseInputModule::get_input, ldloc:TouchInputModule[exp:BaseInputModule](this)))
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

		// Token: 0x060006BF RID: 1727 RVA: 0x0001336C File Offset: 0x0001156C
		public override void Process()
		{
			BaseInput input = base.input;
			this.ProcessTouchEvents();
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00013390 File Offset: 0x00011590
		private void FakeTouches()
		{
			PointerInputModule.ButtonState buttonState;
			PointerInputModule.MouseButtonEventData eventData = buttonState.m_EventData;
			PointerEventData.FramePressState buttonState2 = eventData.buttonState;
			PointerEventData buttonData = eventData.buttonData;
			PointerEventData.FramePressState buttonState3 = eventData.buttonState;
			PointerEventData buttonData2 = eventData.buttonData;
			BaseInput input = base.input;
			PointerEventData buttonData3 = eventData.buttonData;
			PointerEventData buttonData4 = eventData.buttonData;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x000133DC File Offset: 0x000115DC
		private void ProcessTouchEvents()
		{
			BaseInput input = base.input;
			BaseInput input2 = base.input;
			PointerEventData pointerEventData;
			base.RemovePointerData(pointerEventData);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0001340C File Offset: 0x0001160C
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

		// Token: 0x060006C3 RID: 1731 RVA: 0x0001357C File Offset: 0x0001177C
		public override void DeactivateModule()
		{
			base.ClearSelection();
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00013590 File Offset: 0x00011790
		public override string ToString()
		{
			BaseInput input = base.input;
			BaseInput input2 = base.input;
			Dictionary<int, PointerEventData> pointerData = this.m_PointerData;
			bool flag;
			if (flag)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0400030C RID: 780
		private Vector2 m_LastMousePosition;

		// Token: 0x0400030D RID: 781
		private Vector2 m_MousePosition;

		// Token: 0x0400030E RID: 782
		private PointerEventData m_InputPointerEvent;

		// Token: 0x0400030F RID: 783
		[SerializeField]
		[FormerlySerializedAs("m_AllowActivationOnStandalone")]
		private bool m_ForceModuleActive;
	}
}
