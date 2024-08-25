using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine.Serialization;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000AA RID: 170
	[AddComponentMenu("Event/Event System")]
	[DisallowMultipleComponent]
	public class EventSystem : UIBehaviour
	{
		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0001173C File Offset: 0x0000F93C
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00011754 File Offset: 0x0000F954
		public static EventSystem current
		{
			get
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				return 1;
			}
			set
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00011778 File Offset: 0x0000F978
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x0001178C File Offset: 0x0000F98C
		public bool sendNavigationEvents
		{
			get
			{
				return this.m_sendNavigationEvents;
			}
			set
			{
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x0001179C File Offset: 0x0000F99C
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x000117B0 File Offset: 0x0000F9B0
		public int pixelDragThreshold
		{
			get
			{
				return this.m_DragThreshold;
			}
			set
			{
				this.m_DragThreshold = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x000117C4 File Offset: 0x0000F9C4
		public BaseInputModule currentInputModule
		{
			get
			{
				return this.m_CurrentInputModule;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x000117D8 File Offset: 0x0000F9D8
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x000117EC File Offset: 0x0000F9EC
		public GameObject firstSelectedGameObject
		{
			get
			{
				return this.m_FirstSelected;
			}
			set
			{
				this.m_FirstSelected = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x00011800 File Offset: 0x0000FA00
		public GameObject currentSelectedGameObject
		{
			get
			{
				return this.m_CurrentSelected;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00011814 File Offset: 0x0000FA14
		[Obsolete("lastSelectedGameObject is no longer supported")]
		public GameObject lastSelectedGameObject
		{
			get
			{
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00011824 File Offset: 0x0000FA24
		public bool isFocused
		{
			get
			{
				return this.m_HasFocus;
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00011838 File Offset: 0x0000FA38
		protected EventSystem()
		{
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00011864 File Offset: 0x0000FA64
		public void UpdateModules()
		{
			List<BaseInputModule> systemInputModules = this.m_SystemInputModules;
			base.GetComponents(systemInputModules);
			int size = this.m_SystemInputModules._size;
			List<BaseInputModule> systemInputModules2 = this.m_SystemInputModules;
			List<BaseInputModule> systemInputModules3 = this.m_SystemInputModules;
			List<BaseInputModule> systemInputModules4 = this.m_SystemInputModules;
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x000118A4 File Offset: 0x0000FAA4
		public bool alreadySelecting
		{
			get
			{
				return this.m_SelectionGuard;
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x000118B8 File Offset: 0x0000FAB8
		public void SetSelectedGameObject(GameObject selected, BaseEventData pointer)
		{
			if (!this.m_SelectionGuard)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				return;
			}
			if (selected != null)
			{
				return;
			}
			if (!true)
			{
			}
			string text;
			Debug.LogError(text);
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x000118E4 File Offset: 0x0000FAE4
		private BaseEventData baseEventDataCache
		{
			get
			{
				/*
An exception occurred when decompiling this method (060005F1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.EventSystems.BaseEventData UnityEngine.EventSystems.EventSystem::get_baseEventDataCache()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:BaseEventData[exp:bool](EventSystem::m_DummyData, ldloc:EventSystem(this)))
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

		// Token: 0x060005F2 RID: 1522 RVA: 0x000118F8 File Offset: 0x0000FAF8
		public void SetSelectedGameObject(GameObject selected)
		{
			BaseEventData baseEventDataCache = this.baseEventDataCache;
			this.SetSelectedGameObject(selected, baseEventDataCache);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00011914 File Offset: 0x0000FB14
		private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs)
		{
			int num = 1;
			BaseRaycaster module = lhs.module;
			if (num == 0)
			{
			}
			BaseRaycaster module2 = lhs.module;
			BaseRaycaster module3 = lhs.module;
			BaseRaycaster module4 = lhs.module;
			int sortingLayer = lhs.sortingLayer;
			int depth = lhs.depth;
			BaseRaycaster rootRaycaster = lhs.module.rootRaycaster;
			if (depth == 0)
			{
			}
			BaseRaycaster baseRaycaster;
			bool flag = baseRaycaster == rootRaycaster;
			int num2;
			return SortingLayer.GetLayerValueFromID(num2);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00002207 File Offset: 0x00000407
		public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x000119AC File Offset: 0x0000FBAC
		public bool IsPointerOverGameObject()
		{
			bool flag;
			return flag;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x000119BC File Offset: 0x0000FBBC
		public bool IsPointerOverGameObject(int pointerId)
		{
			/*
An exception occurred when decompiling this method (060005F6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.EventSystems.EventSystem::IsPointerOverGameObject(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:BaseInputModule(var_2_10, ldfld:BaseInputModule(EventSystem::m_CurrentInputModule, ldloc:EventSystem(this)))
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

		// Token: 0x060005F7 RID: 1527 RVA: 0x000119DC File Offset: 0x0000FBDC
		public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = true, bool createPanelGameObjectsOnStart = true)
		{
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x000119EC File Offset: 0x0000FBEC
		protected override void Start()
		{
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000119FC File Offset: 0x0000FBFC
		protected override void OnDestroy()
		{
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00011A0C File Offset: 0x0000FC0C
		protected override void OnEnable()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00011A20 File Offset: 0x0000FC20
		protected override void OnDisable()
		{
			BaseInputModule currentInputModule = this.m_CurrentInputModule;
			if (!true)
			{
			}
			BaseInputModule currentInputModule2 = this.m_CurrentInputModule;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00011A40 File Offset: 0x0000FC40
		private void TickModules()
		{
			int size = this.m_SystemInputModules._size;
			List<BaseInputModule> systemInputModules = this.m_SystemInputModules;
			List<BaseInputModule> systemInputModules2 = this.m_SystemInputModules;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00011A6C File Offset: 0x0000FC6C
		protected virtual void OnApplicationFocus(bool hasFocus)
		{
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00011A80 File Offset: 0x0000FC80
		protected virtual void Update()
		{
			if (!true)
			{
			}
			bool flag = EventSystem.current != this;
			this.TickModules();
			int size = this.m_SystemInputModules._size;
			List<BaseInputModule> systemInputModules = this.m_SystemInputModules;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00011AE8 File Offset: 0x0000FCE8
		private void ChangeEventModule(BaseInputModule module)
		{
			BaseInputModule currentInputModule = this.m_CurrentInputModule;
			if (!true)
			{
			}
			bool flag = currentInputModule == module;
			BaseInputModule currentInputModule2 = this.m_CurrentInputModule;
			if (!true)
			{
			}
			BaseInputModule currentInputModule3 = this.m_CurrentInputModule;
			this.m_CurrentInputModule = module;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00011B20 File Offset: 0x0000FD20
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06000600)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String UnityEngine.EventSystems.EventSystem::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:BaseInputModule(var_4_0E, ldfld:BaseInputModule(EventSystem::m_CurrentInputModule, ldloc:EventSystem(this)))
	stloc:BaseInputModule(var_6_16, ldfld:BaseInputModule(EventSystem::m_CurrentInputModule, ldloc:EventSystem(this)))
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

		// Token: 0x06000601 RID: 1537 RVA: 0x00011B44 File Offset: 0x0000FD44
		// Note: this type is marked as 'beforefieldinit'.
		static EventSystem()
		{
		}

		// Token: 0x040002B6 RID: 694
		private List<BaseInputModule> m_SystemInputModules;

		// Token: 0x040002B7 RID: 695
		private BaseInputModule m_CurrentInputModule;

		// Token: 0x040002B8 RID: 696
		private static List<EventSystem> m_EventSystems;

		// Token: 0x040002B9 RID: 697
		[FormerlySerializedAs("m_Selected")]
		[SerializeField]
		private GameObject m_FirstSelected;

		// Token: 0x040002BA RID: 698
		[SerializeField]
		private bool m_sendNavigationEvents = true;

		// Token: 0x040002BB RID: 699
		[SerializeField]
		private int m_DragThreshold = 10;

		// Token: 0x040002BC RID: 700
		private GameObject m_CurrentSelected;

		// Token: 0x040002BD RID: 701
		private bool m_HasFocus = true;

		// Token: 0x040002BE RID: 702
		private bool m_SelectionGuard;

		// Token: 0x040002BF RID: 703
		private BaseEventData m_DummyData;

		// Token: 0x040002C0 RID: 704
		private static readonly Comparison<RaycastResult> s_RaycastComparer;
	}
}
