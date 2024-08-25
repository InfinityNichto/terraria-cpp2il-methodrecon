using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000B3 RID: 179
	public abstract class PointerInputModule : BaseInputModule
	{
		// Token: 0x06000675 RID: 1653 RVA: 0x00012588 File Offset: 0x00010788
		protected bool GetPointerData(int id, [Out] PointerEventData data, bool create)
		{
			Dictionary<int, PointerEventData> pointerData = this.m_PointerData;
			EventSystem eventSystem = this.m_EventSystem;
			Dictionary<int, PointerEventData> pointerData2 = this.m_PointerData;
			return true;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000125AC File Offset: 0x000107AC
		protected void RemovePointerData(PointerEventData data)
		{
			Dictionary<int, PointerEventData> pointerData = this.m_PointerData;
			int <pointerId>k__BackingField = data.<pointerId>k__BackingField;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00002207 File Offset: 0x00000407
		protected PointerEventData GetTouchPointerEventData(Touch input, [Out] bool pressed, [Out] bool released)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000125C8 File Offset: 0x000107C8
		protected void CopyFromTo(PointerEventData from, PointerEventData to)
		{
			Vector2 <position>k__BackingField = from.<position>k__BackingField;
			to.<position>k__BackingField = <position>k__BackingField;
			Vector2 <delta>k__BackingField = from.<delta>k__BackingField;
			to.<delta>k__BackingField = <delta>k__BackingField;
			Vector2 <scrollDelta>k__BackingField = from.<scrollDelta>k__BackingField;
			to.<scrollDelta>k__BackingField = <scrollDelta>k__BackingField;
			GameObject <pointerEnter>k__BackingField = from.<pointerEnter>k__BackingField;
			to.<pointerEnter>k__BackingField = <pointerEnter>k__BackingField;
			float <twist>k__BackingField = from.<twist>k__BackingField;
			to.<twist>k__BackingField = <twist>k__BackingField;
			Vector2 <radius>k__BackingField = from.<radius>k__BackingField;
			float y = from.<radius>k__BackingField.y;
			to.<radius>k__BackingField = <radius>k__BackingField;
			to.<radius>k__BackingField.y = y;
			Vector2 <radiusVariance>k__BackingField = from.<radiusVariance>k__BackingField;
			float y2 = from.<radiusVariance>k__BackingField.y;
			to.<radiusVariance>k__BackingField = <radiusVariance>k__BackingField;
			to.<radiusVariance>k__BackingField.y = y2;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00012674 File Offset: 0x00010874
		protected PointerEventData.FramePressState StateForMouseButton(int buttonId)
		{
			/*
An exception occurred when decompiling this method (06000679)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.EventSystems.PointerEventData/FramePressState UnityEngine.EventSystems.PointerInputModule::StateForMouseButton(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:BaseInput(var_0_06, callgetter:BaseInput(BaseInputModule::get_input, ldloc:PointerInputModule[exp:BaseInputModule](this)))
	stloc:BaseInput(var_1_0D, callgetter:BaseInput(BaseInputModule::get_input, ldloc:PointerInputModule[exp:BaseInputModule](this)))
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

		// Token: 0x0600067A RID: 1658 RVA: 0x00002207 File Offset: 0x00000407
		protected virtual PointerInputModule.MouseState GetMousePointerEventData()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00002207 File Offset: 0x00000407
		protected virtual PointerInputModule.MouseState GetMousePointerEventData(int id)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00002207 File Offset: 0x00000407
		protected PointerEventData GetLastPointerEventData(int id)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00012690 File Offset: 0x00010890
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return true;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x000126A0 File Offset: 0x000108A0
		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
			CursorLockMode lockState = Cursor.lockState;
			RaycastResult <pointerCurrentRaycast>k__BackingField = pointerEvent.<pointerCurrentRaycast>k__BackingField;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x000126BC File Offset: 0x000108BC
		protected virtual void ProcessDrag(PointerEventData pointerEvent)
		{
			float x = pointerEvent.<delta>k__BackingField.x;
			float y = pointerEvent.<delta>k__BackingField.y;
			CursorLockMode lockState = Cursor.lockState;
			GameObject <pointerDrag>k__BackingField = pointerEvent.<pointerDrag>k__BackingField;
			if (!true)
			{
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00012780 File Offset: 0x00010980
		public override bool IsPointerOverGameObject(int pointerId)
		{
			if (true)
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00012794 File Offset: 0x00010994
		protected void ClearSelection()
		{
			Dictionary<int, PointerEventData> pointerData = this.m_PointerData;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x000127D0 File Offset: 0x000109D0
		public override string ToString()
		{
			if (base.GetType() != null)
			{
			}
			Dictionary<int, PointerEventData> pointerData = this.m_PointerData;
			while (this == null)
			{
			}
			string text2;
			string text = "<B>Pointer:</b> " + text2;
			throw new OutOfMemoryException();
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0001280C File Offset: 0x00010A0C
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
			if (!true)
			{
			}
			GameObject eventHandler = ExecuteEvents.GetEventHandler(currentOverGo);
			EventSystem eventSystem = this.m_EventSystem;
			bool flag = eventHandler != currentOverGo;
			EventSystem eventSystem2 = this.m_EventSystem;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0001283C File Offset: 0x00010A3C
		protected PointerInputModule()
		{
		}

		// Token: 0x040002F0 RID: 752
		public const int kMouseLeftId = -1;

		// Token: 0x040002F1 RID: 753
		public const int kMouseRightId = -2;

		// Token: 0x040002F2 RID: 754
		public const int kMouseMiddleId = -3;

		// Token: 0x040002F3 RID: 755
		public const int kFakeTouchesId = -4;

		// Token: 0x040002F4 RID: 756
		protected Dictionary<int, PointerEventData> m_PointerData;

		// Token: 0x040002F5 RID: 757
		private readonly PointerInputModule.MouseState m_MouseState;

		// Token: 0x020000B4 RID: 180
		protected class ButtonState
		{
			// Token: 0x170001B8 RID: 440
			// (get) Token: 0x06000685 RID: 1669 RVA: 0x00012850 File Offset: 0x00010A50
			// (set) Token: 0x06000686 RID: 1670 RVA: 0x00012864 File Offset: 0x00010A64
			public PointerInputModule.MouseButtonEventData eventData
			{
				get
				{
					return this.m_EventData;
				}
				set
				{
					this.m_EventData = value;
				}
			}

			// Token: 0x170001B9 RID: 441
			// (get) Token: 0x06000687 RID: 1671 RVA: 0x00012878 File Offset: 0x00010A78
			// (set) Token: 0x06000688 RID: 1672 RVA: 0x0001288C File Offset: 0x00010A8C
			public PointerEventData.InputButton button
			{
				get
				{
					return this.m_Button;
				}
				set
				{
					this.m_Button = value;
				}
			}

			// Token: 0x06000689 RID: 1673 RVA: 0x000128A0 File Offset: 0x00010AA0
			public ButtonState()
			{
			}

			// Token: 0x040002F6 RID: 758
			private PointerEventData.InputButton m_Button;

			// Token: 0x040002F7 RID: 759
			private PointerInputModule.MouseButtonEventData m_EventData;
		}

		// Token: 0x020000B5 RID: 181
		protected class MouseState
		{
			// Token: 0x0600068A RID: 1674 RVA: 0x000128B4 File Offset: 0x00010AB4
			public bool AnyPressesThisFrame()
			{
				/*
An exception occurred when decompiling this method (0600068A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.EventSystems.PointerInputModule/MouseState::AnyPressesThisFrame()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class UnityEngine.EventSystems.PointerInputModule/ButtonState>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class UnityEngine.EventSystems.PointerInputModule/ButtonState>(MouseState::m_TrackedButtons, ldloc:MouseState(this)))
	stloc:int32(var_1_0D, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class UnityEngine.EventSystems.PointerInputModule/ButtonState>[exp:List`1](var_0_06)))
	stloc:int32(var_2_14, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class UnityEngine.EventSystems.PointerInputModule/ButtonState>[exp:List`1](var_0_06)))
	stloc:int32(var_4_22, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class UnityEngine.EventSystems.PointerInputModule/ButtonState>[exp:List`1](MouseState::m_TrackedButtons, ldloc:MouseState(this))))
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

			// Token: 0x0600068B RID: 1675 RVA: 0x000128EC File Offset: 0x00010AEC
			public bool AnyReleasesThisFrame()
			{
				/*
An exception occurred when decompiling this method (0600068B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.EventSystems.PointerInputModule/MouseState::AnyReleasesThisFrame()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class UnityEngine.EventSystems.PointerInputModule/ButtonState>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class UnityEngine.EventSystems.PointerInputModule/ButtonState>(MouseState::m_TrackedButtons, ldloc:MouseState(this)))
	stloc:int32(var_1_0D, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class UnityEngine.EventSystems.PointerInputModule/ButtonState>[exp:List`1](var_0_06)))
	stloc:int32(var_2_14, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class UnityEngine.EventSystems.PointerInputModule/ButtonState>[exp:List`1](var_0_06)))
	stloc:int32(var_4_22, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class UnityEngine.EventSystems.PointerInputModule/ButtonState>[exp:List`1](MouseState::m_TrackedButtons, ldloc:MouseState(this))))
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

			// Token: 0x0600068C RID: 1676 RVA: 0x00002207 File Offset: 0x00000407
			public PointerInputModule.ButtonState GetButtonState(PointerEventData.InputButton button)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600068D RID: 1677 RVA: 0x00012924 File Offset: 0x00010B24
			public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data)
			{
				PointerInputModule.MouseButtonEventData eventData = this.GetButtonState(button).m_EventData;
				eventData.buttonState = stateForMouseButton;
				eventData.buttonData = data;
			}

			// Token: 0x0600068E RID: 1678 RVA: 0x0001294C File Offset: 0x00010B4C
			public MouseState()
			{
			}

			// Token: 0x040002F8 RID: 760
			private List<PointerInputModule.ButtonState> m_TrackedButtons;
		}

		// Token: 0x020000B6 RID: 182
		public class MouseButtonEventData
		{
			// Token: 0x0600068F RID: 1679 RVA: 0x00012960 File Offset: 0x00010B60
			public bool PressedThisFrame()
			{
				/*
An exception occurred when decompiling this method (0600068F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.EventSystems.PointerInputModule/MouseButtonEventData::PressedThisFrame()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:FramePressState(var_0_06, ldfld:FramePressState(MouseButtonEventData::buttonState, ldloc:MouseButtonEventData(this)))
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

			// Token: 0x06000690 RID: 1680 RVA: 0x00012974 File Offset: 0x00010B74
			public bool ReleasedThisFrame()
			{
				/*
An exception occurred when decompiling this method (06000690)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.EventSystems.PointerInputModule/MouseButtonEventData::ReleasedThisFrame()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:FramePressState(var_0_06, ldfld:FramePressState(MouseButtonEventData::buttonState, ldloc:MouseButtonEventData(this)))
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

			// Token: 0x06000691 RID: 1681 RVA: 0x00012988 File Offset: 0x00010B88
			public MouseButtonEventData()
			{
			}

			// Token: 0x040002F9 RID: 761
			public PointerEventData.FramePressState buttonState;

			// Token: 0x040002FA RID: 762
			public PointerEventData buttonData;
		}
	}
}
