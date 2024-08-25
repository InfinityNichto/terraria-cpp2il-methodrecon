using System;
using System.Collections.Generic;
using System.ComponentModel;
using Cpp2IlInjected;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000AB RID: 171
	[AddComponentMenu("Event/Event Trigger")]
	public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler
	{
		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00011B54 File Offset: 0x0000FD54
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x00011B68 File Offset: 0x0000FD68
		[Obsolete("Please use triggers instead (UnityUpgradable) -> triggers", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public List<EventTrigger.Entry> delegates
		{
			get
			{
				return this.triggers;
			}
			set
			{
				this.m_Delegates = value;
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00011B7C File Offset: 0x0000FD7C
		protected EventTrigger()
		{
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00011B90 File Offset: 0x0000FD90
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x00011BA4 File Offset: 0x0000FDA4
		public List<EventTrigger.Entry> triggers
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000605)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<UnityEngine.EventSystems.EventTrigger/Entry> UnityEngine.EventSystems.EventTrigger::get_triggers()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:class [mscorlib]System.Collections.Generic.List`1<class UnityEngine.EventSystems.EventTrigger/Entry>[exp:bool](EventTrigger::m_Delegates, ldloc:EventTrigger(this)))
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
				this.m_Delegates = value;
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00002207 File Offset: 0x00000407
		private void Execute(EventTriggerType id, BaseEventData eventData)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00011BB8 File Offset: 0x0000FDB8
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00011BC8 File Offset: 0x0000FDC8
		public virtual void OnPointerExit(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.PointerExit, eventData);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00011BE0 File Offset: 0x0000FDE0
		public virtual void OnDrag(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.Drag, eventData);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		public virtual void OnDrop(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.Drop, eventData);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00011C10 File Offset: 0x0000FE10
		public virtual void OnPointerDown(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.PointerDown, eventData);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00011C28 File Offset: 0x0000FE28
		public virtual void OnPointerUp(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.PointerUp, eventData);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00011C40 File Offset: 0x0000FE40
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.PointerClick, eventData);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00011C58 File Offset: 0x0000FE58
		public virtual void OnSelect(BaseEventData eventData)
		{
			this.Execute(EventTriggerType.Select, eventData);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00011C70 File Offset: 0x0000FE70
		public virtual void OnDeselect(BaseEventData eventData)
		{
			this.Execute(EventTriggerType.Deselect, eventData);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00011C88 File Offset: 0x0000FE88
		public virtual void OnScroll(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.Scroll, eventData);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00011CA0 File Offset: 0x0000FEA0
		public virtual void OnMove(AxisEventData eventData)
		{
			this.Execute(EventTriggerType.Move, eventData);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00011CB8 File Offset: 0x0000FEB8
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
			this.Execute(EventTriggerType.UpdateSelected, eventData);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00011CD0 File Offset: 0x0000FED0
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.InitializePotentialDrag, eventData);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00011CE8 File Offset: 0x0000FEE8
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.BeginDrag, eventData);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00011D00 File Offset: 0x0000FF00
		public virtual void OnEndDrag(PointerEventData eventData)
		{
			this.Execute(EventTriggerType.EndDrag, eventData);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00011D18 File Offset: 0x0000FF18
		public virtual void OnSubmit(BaseEventData eventData)
		{
			this.Execute(EventTriggerType.Submit, eventData);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00011D30 File Offset: 0x0000FF30
		public virtual void OnCancel(BaseEventData eventData)
		{
			this.Execute(EventTriggerType.Cancel, eventData);
		}

		// Token: 0x040002C1 RID: 705
		[SerializeField]
		[FormerlySerializedAs("delegates")]
		private List<EventTrigger.Entry> m_Delegates;

		// Token: 0x020000AC RID: 172
		[Serializable]
		public class TriggerEvent : UnityEvent<BaseEventData>
		{
			// Token: 0x06000619 RID: 1561 RVA: 0x00011D48 File Offset: 0x0000FF48
			public TriggerEvent()
			{
			}
		}

		// Token: 0x020000AD RID: 173
		[Serializable]
		public class Entry
		{
			// Token: 0x0600061A RID: 1562 RVA: 0x00011D58 File Offset: 0x0000FF58
			public Entry()
			{
			}

			// Token: 0x040002C2 RID: 706
			public EventTriggerType eventID = EventTriggerType.PointerClick;

			// Token: 0x040002C3 RID: 707
			public EventTrigger.TriggerEvent callback;
		}
	}
}
