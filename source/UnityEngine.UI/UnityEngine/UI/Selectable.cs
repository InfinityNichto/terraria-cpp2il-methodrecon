using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000067 RID: 103
	[ExecuteAlways]
	[AddComponentMenu("UI/Selectable", 35)]
	[SelectionBase]
	[DisallowMultipleComponent]
	public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
	{
		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0000D5DC File Offset: 0x0000B7DC
		public static Selectable[] allSelectablesArray
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000419)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.UI.Selectable[] UnityEngine.UI.Selectable::get_allSelectablesArray()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0000D5EC File Offset: 0x0000B7EC
		public static int allSelectableCount
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600041A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 UnityEngine.UI.Selectable::get_allSelectableCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0000D5FC File Offset: 0x0000B7FC
		[Obsolete("Replaced with allSelectablesArray to have better performance when disabling a element", false)]
		public static List<Selectable> allSelectables
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600041B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<UnityEngine.UI.Selectable> UnityEngine.UI.Selectable::get_allSelectables()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:class UnityEngine.UI.Selectable[](var_0_08, callgetter:class UnityEngine.UI.Selectable[](Selectable::get_allSelectablesArray))
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

		// Token: 0x0600041C RID: 1052 RVA: 0x0000D614 File Offset: 0x0000B814
		public static int AllSelectablesNoAlloc(Selectable[] selectables)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0000D628 File Offset: 0x0000B828
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x0000D670 File Offset: 0x0000B870
		public Navigation navigation
		{
			get
			{
				Selectable selectOnRight = this.m_Navigation.m_SelectOnRight;
				Navigation.Mode mode = this.m_Navigation.m_Mode;
				bool wrapAround = this.m_Navigation.m_WrapAround;
				Navigation navigation;
				navigation.m_SelectOnRight = selectOnRight;
				navigation.m_Mode = mode;
				navigation.m_WrapAround = wrapAround;
				return navigation;
			}
			set
			{
				Selectable selectOnRight = value.m_SelectOnRight;
				Navigation.Mode mode = value.m_Mode;
				bool wrapAround = value.m_WrapAround;
				this.OnSetProperty();
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0000D698 File Offset: 0x0000B898
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x0000D6AC File Offset: 0x0000B8AC
		public Selectable.Transition transition
		{
			get
			{
				return this.m_Transition;
			}
			set
			{
				this.OnSetProperty();
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0000D6C0 File Offset: 0x0000B8C0
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x0000D6D0 File Offset: 0x0000B8D0
		public ColorBlock colors
		{
			get
			{
				ColorBlock colorBlock;
				return colorBlock;
			}
			set
			{
				this.OnSetProperty();
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x0000D6E4 File Offset: 0x0000B8E4
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x0000D6F4 File Offset: 0x0000B8F4
		public SpriteState spriteState
		{
			get
			{
				SpriteState spriteState;
				return spriteState;
			}
			set
			{
				Sprite highlightedSprite = value.m_HighlightedSprite;
				this.OnSetProperty();
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x0000D710 File Offset: 0x0000B910
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x0000D724 File Offset: 0x0000B924
		public AnimationTriggers animationTriggers
		{
			get
			{
				return this.m_AnimationTriggers;
			}
			set
			{
				this.OnSetProperty();
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x0000D738 File Offset: 0x0000B938
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x0000D74C File Offset: 0x0000B94C
		public Graphic targetGraphic
		{
			get
			{
				return this.m_TargetGraphic;
			}
			set
			{
				this.OnSetProperty();
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x0000D760 File Offset: 0x0000B960
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x0000D774 File Offset: 0x0000B974
		public bool interactable
		{
			get
			{
				return this.m_Interactable;
			}
			set
			{
				EventSystem current = EventSystem.current;
				GameObject currentSelected = EventSystem.current.m_CurrentSelected;
				GameObject gameObject = base.gameObject;
				bool flag = currentSelected == gameObject;
				EventSystem current2 = EventSystem.current;
				this.OnSetProperty();
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0000D7BC File Offset: 0x0000B9BC
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		private bool isPointerInside
		{
			[CompilerGenerated]
			get
			{
				return this.<isPointerInside>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x0000D7E0 File Offset: 0x0000B9E0
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x0000D7F4 File Offset: 0x0000B9F4
		private bool isPointerDown
		{
			[CompilerGenerated]
			get
			{
				return this.<isPointerDown>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x0000D804 File Offset: 0x0000BA04
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x0000D818 File Offset: 0x0000BA18
		private bool hasSelection
		{
			[CompilerGenerated]
			get
			{
				return this.<hasSelection>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0000D828 File Offset: 0x0000BA28
		protected Selectable()
		{
			int num = 3;
			long num2 = 1L;
			this.m_Navigation = num;
			if (num == 0)
			{
			}
			int num3 = 1;
			this.m_Interactable = num3 != 0;
			this.m_GroupsAllowInteraction = num3 != 0;
			this.m_CurrentIndex = (int)num2;
			base..ctor();
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0000D860 File Offset: 0x0000BA60
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x0000D878 File Offset: 0x0000BA78
		public Image image
		{
			get
			{
				if (this.m_TargetGraphic != null)
				{
					return;
				}
			}
			set
			{
				this.m_TargetGraphic = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0000D88C File Offset: 0x0000BA8C
		public Animator animator
		{
			get
			{
				return base.GetComponent<Animator>();
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000D8A0 File Offset: 0x0000BAA0
		protected override void Awake()
		{
			Graphic targetGraphic = this.m_TargetGraphic;
			if (!true)
			{
			}
			Graphic component = base.GetComponent<Graphic>();
			this.m_TargetGraphic = component;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0000D8C8 File Offset: 0x0000BAC8
		protected override void OnCanvasGroupChanged()
		{
			int num = 1;
			Transform transform = base.transform;
			if (num == 0)
			{
			}
			List<CanvasGroup> canvasGroupCache = this.m_CanvasGroupCache;
			transform.GetComponents(canvasGroupCache);
			int size = this.m_CanvasGroupCache._size;
			List<CanvasGroup> canvasGroupCache2 = this.m_CanvasGroupCache;
			List<CanvasGroup> canvasGroupCache3 = this.m_CanvasGroupCache;
			int size2 = this.m_CanvasGroupCache._size;
			Transform parent = transform.parent;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000D93C File Offset: 0x0000BB3C
		public virtual bool IsInteractable()
		{
			if (this.m_GroupsAllowInteraction)
			{
				bool interactable = this.m_Interactable;
				return;
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000D95C File Offset: 0x0000BB5C
		protected override void OnDidApplyAnimationProperties()
		{
			this.OnSetProperty();
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0000D970 File Offset: 0x0000BB70
		protected override void OnEnable()
		{
			bool enableCalled = this.m_EnableCalled;
			if (enableCalled)
			{
				return;
			}
			base.OnEnable();
			if (!enableCalled)
			{
			}
			if (!enableCalled)
			{
			}
			bool flag = EventSystem.current;
			GameObject currentSelected = EventSystem.current.m_CurrentSelected;
			GameObject gameObject = base.gameObject;
			bool flag2 = currentSelected == gameObject;
			int num = 1;
			this.<hasSelection>k__BackingField = num != 0;
			if (num == 0)
			{
			}
			this.m_CurrentIndex = currentSelected;
			if (this == null)
			{
				throw new ArrayTypeMismatchException();
			}
			if (this.<isPointerDown>k__BackingField)
			{
				return;
			}
			if (this.<hasSelection>k__BackingField)
			{
				return;
			}
			bool flag3 = this.<isPointerInside>k__BackingField;
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0000DA0C File Offset: 0x0000BC0C
		protected override void OnTransformParentChanged()
		{
			base.OnTransformParentChanged();
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0000DA20 File Offset: 0x0000BC20
		private void OnSetProperty()
		{
			if (this.<isPointerDown>k__BackingField)
			{
				return;
			}
			if (this.<hasSelection>k__BackingField)
			{
				return;
			}
			bool flag = this.<isPointerInside>k__BackingField;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0000DA48 File Offset: 0x0000BC48
		protected override void OnDisable()
		{
			bool enableCalled = this.m_EnableCalled;
			if (enableCalled)
			{
				if (!enableCalled)
				{
				}
				int currentIndex = this.m_CurrentIndex;
				base.OnDisable();
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0000DA78 File Offset: 0x0000BC78
		private void OnApplicationFocus(bool hasFocus)
		{
			if (this.<isPointerDown>k__BackingField)
			{
				return;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0000DA90 File Offset: 0x0000BC90
		protected Selectable.SelectionState currentSelectionState
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600043E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.UI.Selectable/SelectionState UnityEngine.UI.Selectable::get_currentSelectionState()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:bool(var_0_1C, ldfld:bool(Selectable::<isPointerInside>k__BackingField, ldloc:Selectable(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x0600043F RID: 1087 RVA: 0x0000DABC File Offset: 0x0000BCBC
		protected virtual void InstantClearState()
		{
			AnimationTriggers animationTriggers = this.m_AnimationTriggers;
			Selectable.Transition transition = this.m_Transition;
			string normalTrigger = animationTriggers.m_NormalTrigger;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000DAE4 File Offset: 0x0000BCE4
		protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			bool activeInHierarchy = base.gameObject.activeInHierarchy;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000DB70 File Offset: 0x0000BD70
		public Selectable FindSelectable(Vector3 dir)
		{
			for (;;)
			{
				Quaternion rotation = base.transform.rotation;
				Quaternion quaternion = Quaternion.Inverse(0);
				Transform transform = base.transform;
				if (base.transform != null)
				{
				}
				if (this.m_Navigation.m_WrapAround)
				{
					Navigation navigation = this.m_Navigation;
				}
				long num = 0L;
				int num2 = 65408;
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
				}
				Transform transform2;
				if (transform2 != null)
				{
				}
				Rect rect;
				Vector2 center = rect.center;
				if (num != 0L)
				{
					return;
				}
			}
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0000DBE8 File Offset: 0x0000BDE8
		private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir)
		{
			/*
An exception occurred when decompiling this method (06000442)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector3 UnityEngine.UI.Selectable::GetPointOnRectEdge(UnityEngine.RectTransform,UnityEngine.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Vector2(var_2_09, callgetter:Vector2(Rect::get_center, ldloc:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](var_1)))
	stloc:Vector2(var_4_10, callgetter:Vector2(Rect::get_size, ldloc:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](var_3)))
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

		// Token: 0x06000443 RID: 1091 RVA: 0x0000DC08 File Offset: 0x0000BE08
		private void Navigate(AxisEventData eventData, Selectable sel)
		{
			if (!true)
			{
			}
			GameObject gameObject = sel.gameObject;
			eventData.selectedObject = gameObject;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000DC28 File Offset: 0x0000BE28
		public virtual Selectable FindSelectableOnLeft()
		{
			Navigation navigation = this.m_Navigation;
			return this.m_Navigation.m_SelectOnLeft;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000DC5C File Offset: 0x0000BE5C
		public virtual Selectable FindSelectableOnRight()
		{
			Navigation navigation = this.m_Navigation;
			return this.m_Navigation.m_SelectOnRight;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000DC90 File Offset: 0x0000BE90
		public virtual Selectable FindSelectableOnUp()
		{
			Navigation navigation = this.m_Navigation;
			return this.m_Navigation.m_SelectOnUp;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000DCC4 File Offset: 0x0000BEC4
		public virtual Selectable FindSelectableOnDown()
		{
			Navigation navigation = this.m_Navigation;
			return this.m_Navigation.m_SelectOnDown;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		public virtual void OnMove(AxisEventData eventData)
		{
			MoveDirection <moveDir>k__BackingField = eventData.<moveDir>k__BackingField;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000DD1C File Offset: 0x0000BF1C
		private void StartColorTween(Color targetColor, bool instant)
		{
			Graphic targetGraphic = this.m_TargetGraphic;
			if (!true)
			{
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000DD48 File Offset: 0x0000BF48
		private void DoSpriteSwap(Sprite newSprite)
		{
			Image image = this.image;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000DD6C File Offset: 0x0000BF6C
		private void TriggerAnimation(string triggername)
		{
			Selectable.Transition transition = this.m_Transition;
			Animator animator = this.animator;
			bool isActiveAndEnabled = this.animator.isActiveAndEnabled;
			bool hasBoundPlayables = this.animator.hasBoundPlayables;
			bool flag = string.IsNullOrEmpty(triggername);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000DE4C File Offset: 0x0000C04C
		protected bool IsHighlighted()
		{
			/*
An exception occurred when decompiling this method (0600044C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.Selectable::IsHighlighted()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0012:
	stloc:bool(var_1_18, ldfld:bool(Selectable::<hasSelection>k__BackingField, ldloc:Selectable(this)))
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

		// Token: 0x0600044D RID: 1101 RVA: 0x0000DE74 File Offset: 0x0000C074
		protected bool IsPressed()
		{
			/*
An exception occurred when decompiling this method (0600044D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean UnityEngine.UI.Selectable::IsPressed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(Selectable::<isPointerDown>k__BackingField, ldloc:Selectable(this)))
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

		// Token: 0x0600044E RID: 1102 RVA: 0x0000DE8C File Offset: 0x0000C08C
		private void EvaluateAndTransitionToSelectionState()
		{
			if (this.<isPointerDown>k__BackingField)
			{
				return;
			}
			if (this.<hasSelection>k__BackingField)
			{
				return;
			}
			bool flag = this.<isPointerInside>k__BackingField;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000DEB4 File Offset: 0x0000C0B4
		public virtual void OnPointerDown(PointerEventData eventData)
		{
			if (eventData.<button>k__BackingField != PointerEventData.InputButton.Left)
			{
				return;
			}
			Navigation navigation = this.m_Navigation;
			if (navigation != null)
			{
				if (navigation == null)
				{
				}
				EventSystem current = EventSystem.current;
				EventSystem current2 = EventSystem.current;
				GameObject gameObject = base.gameObject;
				current2.SetSelectedGameObject(gameObject, eventData);
			}
			this.<isPointerDown>k__BackingField = true;
			this.EvaluateAndTransitionToSelectionState();
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000DF08 File Offset: 0x0000C108
		public virtual void OnPointerUp(PointerEventData eventData)
		{
			if (eventData.<button>k__BackingField != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.EvaluateAndTransitionToSelectionState();
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000DF24 File Offset: 0x0000C124
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
			this.<isPointerInside>k__BackingField = true;
			this.EvaluateAndTransitionToSelectionState();
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000DF40 File Offset: 0x0000C140
		public virtual void OnPointerExit(PointerEventData eventData)
		{
			this.EvaluateAndTransitionToSelectionState();
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000DF54 File Offset: 0x0000C154
		public virtual void OnSelect(BaseEventData eventData)
		{
			this.<hasSelection>k__BackingField = true;
			this.EvaluateAndTransitionToSelectionState();
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0000DF70 File Offset: 0x0000C170
		public virtual void OnDeselect(BaseEventData eventData)
		{
			this.EvaluateAndTransitionToSelectionState();
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000DF84 File Offset: 0x0000C184
		public virtual void Select()
		{
			if (!true)
			{
			}
			EventSystem current = EventSystem.current;
			bool selectionGuard = EventSystem.current.m_SelectionGuard;
			if (selectionGuard)
			{
				return;
			}
			if (!selectionGuard)
			{
			}
			EventSystem current2 = EventSystem.current;
			GameObject gameObject = base.gameObject;
			current2.SetSelectedGameObject(gameObject);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0000DFD0 File Offset: 0x0000C1D0
		// Note: this type is marked as 'beforefieldinit'.
		static Selectable()
		{
		}

		// Token: 0x04000201 RID: 513
		protected static Selectable[] s_Selectables;

		// Token: 0x04000202 RID: 514
		protected static int s_SelectableCount;

		// Token: 0x04000203 RID: 515
		private bool m_EnableCalled;

		// Token: 0x04000204 RID: 516
		[SerializeField]
		[FormerlySerializedAs("navigation")]
		private Navigation m_Navigation;

		// Token: 0x04000205 RID: 517
		[SerializeField]
		[FormerlySerializedAs("transition")]
		private Selectable.Transition m_Transition;

		// Token: 0x04000206 RID: 518
		[SerializeField]
		[FormerlySerializedAs("colors")]
		private ColorBlock m_Colors;

		// Token: 0x04000207 RID: 519
		[SerializeField]
		[FormerlySerializedAs("spriteState")]
		private SpriteState m_SpriteState;

		// Token: 0x04000208 RID: 520
		[SerializeField]
		[FormerlySerializedAs("animationTriggers")]
		private AnimationTriggers m_AnimationTriggers;

		// Token: 0x04000209 RID: 521
		[SerializeField]
		[Tooltip("Can the Selectable be interacted with?")]
		private bool m_Interactable;

		// Token: 0x0400020A RID: 522
		[FormerlySerializedAs("m_HighlightGraphic")]
		[SerializeField]
		[FormerlySerializedAs("highlightGraphic")]
		private Graphic m_TargetGraphic;

		// Token: 0x0400020B RID: 523
		private bool m_GroupsAllowInteraction;

		// Token: 0x0400020C RID: 524
		protected int m_CurrentIndex;

		// Token: 0x0400020D RID: 525
		[CompilerGenerated]
		private bool <isPointerInside>k__BackingField;

		// Token: 0x0400020E RID: 526
		[CompilerGenerated]
		private bool <isPointerDown>k__BackingField;

		// Token: 0x0400020F RID: 527
		[CompilerGenerated]
		private bool <hasSelection>k__BackingField;

		// Token: 0x04000210 RID: 528
		private readonly List<CanvasGroup> m_CanvasGroupCache;

		// Token: 0x02000068 RID: 104
		public enum Transition
		{
			// Token: 0x04000212 RID: 530
			None,
			// Token: 0x04000213 RID: 531
			ColorTint,
			// Token: 0x04000214 RID: 532
			SpriteSwap,
			// Token: 0x04000215 RID: 533
			Animation
		}

		// Token: 0x02000069 RID: 105
		protected enum SelectionState
		{
			// Token: 0x04000217 RID: 535
			Normal,
			// Token: 0x04000218 RID: 536
			Highlighted,
			// Token: 0x04000219 RID: 537
			Pressed,
			// Token: 0x0400021A RID: 538
			Selected,
			// Token: 0x0400021B RID: 539
			Disabled
		}
	}
}
