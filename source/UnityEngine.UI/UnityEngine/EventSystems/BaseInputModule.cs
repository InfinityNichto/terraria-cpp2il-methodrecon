using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000B2 RID: 178
	[RequireComponent(typeof(EventSystem))]
	public abstract class BaseInputModule : UIBehaviour
	{
		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x00012320 File Offset: 0x00010520
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x00012334 File Offset: 0x00010534
		internal bool sendPointerHoverToParent
		{
			get
			{
				return this.m_SendPointerHoverToParent;
			}
			set
			{
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x00012344 File Offset: 0x00010544
		public BaseInput input
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600065F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.EventSystems.BaseInput UnityEngine.EventSystems.BaseInputModule::get_input()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:class UnityEngine.EventSystems.BaseInput[](var_5_1C, call:class UnityEngine.EventSystems.BaseInput[](Component::GetComponents, ldloc:BaseInputModule[exp:Component](this)))
	stloc:bool(var_9_2F, call:bool(Type::op_Equality, call:Type(object::GetType, ldloc:bool[exp:object](var_7)), ldloc:Type(var_8)))
	stloc:BaseInput(var_11_3C, call:BaseInput(GameObject::AddComponent, callgetter:GameObject(Component::get_gameObject, ldloc:BaseInputModule[exp:Component](this))))
	stfld:BaseInput(BaseInputModule::m_DefaultInput, ldloc:BaseInputModule(this), ldloc:BaseInput(var_11_3C))
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

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00012398 File Offset: 0x00010598
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x000123AC File Offset: 0x000105AC
		public BaseInput inputOverride
		{
			get
			{
				return this.m_InputOverride;
			}
			set
			{
				this.m_InputOverride = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x000123C0 File Offset: 0x000105C0
		protected EventSystem eventSystem
		{
			get
			{
				return this.m_EventSystem;
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x000123D4 File Offset: 0x000105D4
		protected override void OnEnable()
		{
			EventSystem component = base.GetComponent<EventSystem>();
			this.m_EventSystem = component;
			component.UpdateModules();
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x000123F8 File Offset: 0x000105F8
		protected override void OnDisable()
		{
			this.m_EventSystem.UpdateModules();
		}

		// Token: 0x06000665 RID: 1637
		public abstract void Process();

		// Token: 0x06000666 RID: 1638 RVA: 0x00012410 File Offset: 0x00010610
		protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates)
		{
			/*
An exception occurred when decompiling this method (06000666)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.EventSystems.RaycastResult UnityEngine.EventSystems.BaseInputModule::FindFirstRaycast(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_1_01, ldc.i4:int32(1))
	stloc:int32(var_2_08, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<valuetype UnityEngine.EventSystems.RaycastResult>[exp:List`1](candidates)))
	brtrue(IL_0000, ldloc:int32[exp:bool](var_1_01))
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

		// Token: 0x06000667 RID: 1639 RVA: 0x0001242C File Offset: 0x0001062C
		protected static MoveDirection DetermineMoveDirection(float x, float y)
		{
			return MoveDirection.None;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0001243C File Offset: 0x0001063C
		protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone)
		{
			return MoveDirection.None;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0001244C File Offset: 0x0001064C
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			Transform transform = g1.transform;
			if (!true)
			{
			}
			if (!true)
			{
			}
			Transform transform2;
			bool flag = transform2 == transform;
			Transform parent = transform.parent;
			Transform parent2 = transform2.parent;
			throw new MissingMethodException();
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00002207 File Offset: 0x00000407
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0001249C File Offset: 0x0001069C
		protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone)
		{
			AxisEventData axisEventData = this.m_AxisEventData;
			if (axisEventData == null)
			{
				EventSystem eventSystem = this.m_EventSystem;
				this.m_AxisEventData = axisEventData;
			}
			AxisEventData axisEventData2 = this.m_AxisEventData;
			return this.m_AxisEventData;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x000124D4 File Offset: 0x000106D4
		protected virtual BaseEventData GetBaseEventData()
		{
			if (this.m_BaseEventData == null)
			{
				EventSystem eventSystem = this.m_EventSystem;
			}
			return this.m_BaseEventData;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x000124F8 File Offset: 0x000106F8
		public virtual bool IsPointerOverGameObject(int pointerId)
		{
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00012508 File Offset: 0x00010708
		public virtual bool ShouldActivateModule()
		{
			bool enabled = base.enabled;
			return base.gameObject.activeInHierarchy;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0001252C File Offset: 0x0001072C
		public virtual void DeactivateModule()
		{
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0001253C File Offset: 0x0001073C
		public virtual void ActivateModule()
		{
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0001254C File Offset: 0x0001074C
		public virtual void UpdateModule()
		{
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0001255C File Offset: 0x0001075C
		public virtual bool IsModuleSupported()
		{
			return true;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00002207 File Offset: 0x00000407
		public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0001256C File Offset: 0x0001076C
		protected BaseInputModule()
		{
		}

		// Token: 0x040002E9 RID: 745
		[NonSerialized]
		protected List<RaycastResult> m_RaycastResultCache;

		// Token: 0x040002EA RID: 746
		[SerializeField]
		private bool m_SendPointerHoverToParent = true;

		// Token: 0x040002EB RID: 747
		private AxisEventData m_AxisEventData;

		// Token: 0x040002EC RID: 748
		private EventSystem m_EventSystem;

		// Token: 0x040002ED RID: 749
		private BaseEventData m_BaseEventData;

		// Token: 0x040002EE RID: 750
		protected BaseInput m_InputOverride;

		// Token: 0x040002EF RID: 751
		private BaseInput m_DefaultInput;
	}
}
