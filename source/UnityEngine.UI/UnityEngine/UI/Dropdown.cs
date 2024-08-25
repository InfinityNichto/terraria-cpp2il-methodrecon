using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI.CoroutineTween;

namespace UnityEngine.UI
{
	// Token: 0x02000013 RID: 19
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Legacy/Dropdown", 102)]
	public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0000310C File Offset: 0x0000130C
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00003120 File Offset: 0x00001320
		public RectTransform template
		{
			get
			{
				return this.m_Template;
			}
			set
			{
				this.m_Template = value;
				this.RefreshShownValue();
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000313C File Offset: 0x0000133C
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00003150 File Offset: 0x00001350
		public Text captionText
		{
			get
			{
				return this.m_CaptionText;
			}
			set
			{
				this.m_CaptionText = value;
				this.RefreshShownValue();
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000316C File Offset: 0x0000136C
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00003180 File Offset: 0x00001380
		public Image captionImage
		{
			get
			{
				return this.m_CaptionImage;
			}
			set
			{
				this.m_CaptionImage = value;
				this.RefreshShownValue();
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000319C File Offset: 0x0000139C
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000031B0 File Offset: 0x000013B0
		public Text itemText
		{
			get
			{
				return this.m_ItemText;
			}
			set
			{
				this.m_ItemText = value;
				this.RefreshShownValue();
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000031CC File Offset: 0x000013CC
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000031E0 File Offset: 0x000013E0
		public Image itemImage
		{
			get
			{
				return this.m_ItemImage;
			}
			set
			{
				this.m_ItemImage = value;
				this.RefreshShownValue();
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000031FC File Offset: 0x000013FC
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00003214 File Offset: 0x00001414
		public List<Dropdown.OptionData> options
		{
			get
			{
				return this.m_Options.m_Options;
			}
			set
			{
				this.m_Options.m_Options = value;
				this.RefreshShownValue();
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00003234 File Offset: 0x00001434
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00003248 File Offset: 0x00001448
		public Dropdown.DropdownEvent onValueChanged
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

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000325C File Offset: 0x0000145C
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00003270 File Offset: 0x00001470
		public float alphaFadeSpeed
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600007E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.UI.Dropdown::get_alphaFadeSpeed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Dropdown::m_AlphaFadeSpeed, ldloc:Dropdown(this)))
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

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00003280 File Offset: 0x00001480
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00003294 File Offset: 0x00001494
		public int value
		{
			get
			{
				return this.m_Value;
			}
			set
			{
				this.Set(value, true);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000032AC File Offset: 0x000014AC
		public void SetValueWithoutNotify(int input)
		{
			long num = 0L;
			this.Set(input, num != 0L);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000032C4 File Offset: 0x000014C4
		private void Set(int value, bool sendCallback = true)
		{
			bool isPlaying = Application.isPlaying;
			int value2 = this.m_Value;
			if (this.m_Options.m_Options._size == 0)
			{
				return;
			}
			int num;
			this.m_Value = num;
			this.RefreshShownValue();
			UISystemProfilerApi.AddMarker("Dropdown.value", this);
			Dropdown.DropdownEvent onValueChanged = this.m_OnValueChanged;
			int value3 = this.m_Value;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003330 File Offset: 0x00001530
		protected Dropdown()
		{
			if (39322 == 0)
			{
			}
			base..ctor();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003358 File Offset: 0x00001558
		protected override void Awake()
		{
			Image captionImage = this.m_CaptionImage;
			if (!true)
			{
			}
			long num = 0L;
			bool flag = captionImage;
			Image captionImage2 = this.m_CaptionImage;
			Sprite sprite = captionImage2.m_Sprite;
			if (!true)
			{
			}
			captionImage2.enabled = num != 0L;
			RectTransform template = this.m_Template;
			if (!true)
			{
			}
			bool flag2 = template;
			GameObject gameObject = this.m_Template.gameObject;
			long num2 = 0L;
			gameObject.SetActive(num2 != 0L);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000033C0 File Offset: 0x000015C0
		protected override void Start()
		{
			base.Start();
			this.RefreshShownValue();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000033DC File Offset: 0x000015DC
		protected override void OnDisable()
		{
			this.ImmediateDestroyDropdownList();
			GameObject blocker = this.m_Blocker;
			if (!true)
			{
			}
			GameObject blocker2 = this.m_Blocker;
			base.OnDisable();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002207 File Offset: 0x00000407
		public void RefreshShownValue()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003408 File Offset: 0x00001608
		public void AddOptions(List<Dropdown.OptionData> options)
		{
			List<Dropdown.OptionData> options2 = this.m_Options.m_Options;
			this.RefreshShownValue();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002207 File Offset: 0x00000407
		public void AddOptions(List<string> options)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003428 File Offset: 0x00001628
		public void AddOptions(List<Sprite> options)
		{
			int size = options._size;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002207 File Offset: 0x00000407
		public void ClearOptions()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003440 File Offset: 0x00001640
		private void SetupTemplate(Canvas rootCanvas)
		{
			int num = 1;
			RectTransform template = this.m_Template;
			if (num == 0)
			{
			}
			bool flag = template;
			GameObject gameObject = this.m_Template.gameObject;
			int num2 = 1;
			int num3 = 1;
			gameObject.SetActive(num2 != 0);
			Toggle componentInChildren = this.m_Template.GetComponentInChildren<Toggle>();
			this.validTemplate = num3 != 0;
			bool flag2 = componentInChildren;
			Transform transform = componentInChildren.transform;
			RectTransform template2 = this.m_Template;
			bool flag3 = transform == template2;
			RectTransform template3 = this.m_Template;
			Debug.LogError("The dropdown template is not valid. The template must have a child GameObject with a Toggle component serving as the item.", template3);
			if (this.validTemplate)
			{
				Dropdown.DropdownItem dropdownItem = componentInChildren.gameObject.AddComponent<Dropdown.DropdownItem>();
				Text itemText = this.m_ItemText;
				dropdownItem.m_Toggle = componentInChildren;
				Transform transform2 = componentInChildren.transform;
				if (transform2 != null)
				{
				}
				dropdownItem.m_RectTransform = transform2;
				Canvas component = this.m_Template.parent.GetComponent<Canvas>();
				Canvas canvas = gameObject.AddComponent<Canvas>();
				int num4 = 1;
				canvas.overrideSorting = num4 != 0;
				int num5 = 30000;
				canvas.sortingOrder = num5;
				int sortingLayerID = rootCanvas.sortingLayerID;
				canvas.sortingLayerID = sortingLayerID;
				BaseRaycaster rootRaycaster = component.GetComponents<BaseRaycaster>().m_RootRaycaster;
				Type type;
				Component component2 = gameObject.GetComponent(type);
				Component component3 = gameObject.AddComponent(type);
				return;
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002207 File Offset: 0x00000407
		private static T GetOrAddComponent<T>(GameObject go) where T : Component
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003604 File Offset: 0x00001804
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			this.Show();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003618 File Offset: 0x00001818
		public virtual void OnSubmit(BaseEventData eventData)
		{
			this.Show();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000362C File Offset: 0x0000182C
		public virtual void OnCancel(BaseEventData eventData)
		{
			this.Hide();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002207 File Offset: 0x00000407
		public void Show()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003640 File Offset: 0x00001840
		protected virtual GameObject CreateBlocker(Canvas rootCanvas)
		{
			/*
An exception occurred when decompiling this method (06000093)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.GameObject UnityEngine.UI.Dropdown::CreateBlocker(UnityEngine.Canvas)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Transform(var_1_06, callgetter:Transform(Component::get_transform, ldloc:Canvas[exp:Component](rootCanvas)))
	stloc:int64(var_2_08, ldc.i4:int64(0))
	call:void(Transform::SetParent, ldloc:RectTransform[exp:Transform](var_0), ldloc:Transform(var_1_06), ldloc:int64[exp:bool](var_2_08))
	stloc:int32(var_4_12, ldc.i4:int32(1))
	callsetter:bool(Canvas::set_overrideSorting, ldloc:Canvas(var_3), ldloc:int32[exp:bool](var_4_12))
	stloc:Canvas(var_5_27, call:Canvas(GameObject::GetComponent, ldfld:GameObject(Dropdown::m_Dropdown, ldloc:Dropdown(this))))
	stloc:int32(var_6_30, callgetter:int32(Canvas::get_sortingLayerID, ldloc:Canvas(var_5_27)))
	callsetter:int32(Canvas::set_sortingLayerID, ldloc:Canvas(var_3), ldloc:int32(var_6_30))
	stloc:int64(var_7_3B, ldc.i4:int64(0))
	stloc:int32(var_8_44, callgetter:int32(Canvas::get_sortingOrder, ldloc:Canvas(var_5_27)))
	callsetter:int32(Canvas::set_sortingOrder, ldloc:Canvas(var_3), ldloc:int64[exp:int32](var_7_3B))
	stloc:BaseRaycaster(var_12_68, ldfld:BaseRaycaster(BaseRaycaster::m_RootRaycaster, call:class UnityEngine.EventSystems.BaseRaycaster[][exp:BaseRaycaster](Component::GetComponents, call:Canvas[exp:Component](Component::GetComponent, callgetter:Transform[exp:Component](Transform::get_parent, ldfld:RectTransform[exp:Transform](Dropdown::m_Template, ldloc:Dropdown(this)))))))
	stloc:ButtonClickedEvent(var_21_74, ldfld:ButtonClickedEvent(Button::m_OnClick, ldloc:Button(var_20)))
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

		// Token: 0x06000094 RID: 148 RVA: 0x000036C4 File Offset: 0x000018C4
		protected virtual void DestroyBlocker(GameObject blocker)
		{
			if (!true)
			{
			}
			Object.Destroy(blocker);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000036DC File Offset: 0x000018DC
		protected virtual GameObject CreateDropdownList(GameObject template)
		{
			if (!true)
			{
			}
			GameObject gameObject;
			return gameObject;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000036F0 File Offset: 0x000018F0
		protected virtual void DestroyDropdownList(GameObject dropdownList)
		{
			if (!true)
			{
			}
			Object.Destroy(dropdownList);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003708 File Offset: 0x00001908
		protected virtual Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate)
		{
			if (!true)
			{
			}
			Dropdown.DropdownItem dropdownItem;
			return dropdownItem;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000371C File Offset: 0x0000191C
		protected virtual void DestroyItem(Dropdown.DropdownItem item)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002207 File Offset: 0x00000407
		private Dropdown.DropdownItem AddItem(Dropdown.OptionData data, bool selected, Dropdown.DropdownItem itemTemplate, List<Dropdown.DropdownItem> items)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000372C File Offset: 0x0000192C
		private void AlphaFadeList(float duration, float alpha)
		{
			float alpha2 = this.m_Dropdown.GetComponent<CanvasGroup>().alpha;
			this.AlphaFadeList(duration, alpha2, alpha);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003754 File Offset: 0x00001954
		private void AlphaFadeList(float duration, float start, float end)
		{
			TweenRunner<FloatTween> alphaTweenRunner = this.m_AlphaTweenRunner;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003768 File Offset: 0x00001968
		private void SetAlpha(float alpha)
		{
			GameObject dropdown = this.m_Dropdown;
			if (!true)
			{
			}
			bool flag = dropdown;
			this.m_Dropdown.GetComponent<CanvasGroup>().alpha = alpha;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00003798 File Offset: 0x00001998
		public void Hide()
		{
			GameObject dropdown = this.m_Dropdown;
			if (!true)
			{
			}
			float alphaFadeSpeed = this.m_AlphaFadeSpeed;
			float alphaFadeSpeed2 = this.m_AlphaFadeSpeed;
			IEnumerator enumerator;
			Coroutine coroutine = base.StartCoroutine(enumerator);
			GameObject blocker = this.m_Blocker;
			GameObject blocker2 = this.m_Blocker;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002207 File Offset: 0x00000407
		private IEnumerator DelayedDestroyDropdownList(float delay)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002207 File Offset: 0x00000407
		private void ImmediateDestroyDropdownList()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000037D8 File Offset: 0x000019D8
		private void OnSelectItem(Toggle toggle)
		{
			if (!toggle.m_IsOn)
			{
				int num = 1;
				toggle.isOn = num != 0;
			}
			Transform transform = toggle.transform;
			Transform parent = transform.parent;
			long num2 = 0L;
			int childCount = parent.childCount;
			bool flag = parent.GetChild((int)num2) == transform;
			int childCount2 = parent.childCount;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003840 File Offset: 0x00001A40
		// Note: this type is marked as 'beforefieldinit'.
		static Dropdown()
		{
		}

		// Token: 0x0400003E RID: 62
		[SerializeField]
		private RectTransform m_Template;

		// Token: 0x0400003F RID: 63
		[SerializeField]
		private Text m_CaptionText;

		// Token: 0x04000040 RID: 64
		[SerializeField]
		private Image m_CaptionImage;

		// Token: 0x04000041 RID: 65
		[SerializeField]
		[Space]
		private Text m_ItemText;

		// Token: 0x04000042 RID: 66
		[SerializeField]
		private Image m_ItemImage;

		// Token: 0x04000043 RID: 67
		[SerializeField]
		[Space]
		private int m_Value;

		// Token: 0x04000044 RID: 68
		[Space]
		[SerializeField]
		private Dropdown.OptionDataList m_Options;

		// Token: 0x04000045 RID: 69
		[Space]
		[SerializeField]
		private Dropdown.DropdownEvent m_OnValueChanged;

		// Token: 0x04000046 RID: 70
		[SerializeField]
		private float m_AlphaFadeSpeed = (float)39322;

		// Token: 0x04000047 RID: 71
		private GameObject m_Dropdown;

		// Token: 0x04000048 RID: 72
		private GameObject m_Blocker;

		// Token: 0x04000049 RID: 73
		private List<Dropdown.DropdownItem> m_Items;

		// Token: 0x0400004A RID: 74
		private TweenRunner<FloatTween> m_AlphaTweenRunner;

		// Token: 0x0400004B RID: 75
		private bool validTemplate;

		// Token: 0x0400004C RID: 76
		private const int kHighSortingLayer = 30000;

		// Token: 0x0400004D RID: 77
		private static Dropdown.OptionData s_NoOptionData;

		// Token: 0x02000014 RID: 20
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
		{
			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000A2 RID: 162 RVA: 0x00003850 File Offset: 0x00001A50
			// (set) Token: 0x060000A3 RID: 163 RVA: 0x00003864 File Offset: 0x00001A64
			public Text text
			{
				get
				{
					return this.m_Text;
				}
				set
				{
					this.m_Text = value;
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000A4 RID: 164 RVA: 0x00003878 File Offset: 0x00001A78
			// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000388C File Offset: 0x00001A8C
			public Image image
			{
				get
				{
					return this.m_Image;
				}
				set
				{
					this.m_Image = value;
				}
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000A6 RID: 166 RVA: 0x000038A0 File Offset: 0x00001AA0
			// (set) Token: 0x060000A7 RID: 167 RVA: 0x000038B4 File Offset: 0x00001AB4
			public RectTransform rectTransform
			{
				get
				{
					return this.m_RectTransform;
				}
				set
				{
					this.m_RectTransform = value;
				}
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000A8 RID: 168 RVA: 0x000038C8 File Offset: 0x00001AC8
			// (set) Token: 0x060000A9 RID: 169 RVA: 0x000038DC File Offset: 0x00001ADC
			public Toggle toggle
			{
				get
				{
					return this.m_Toggle;
				}
				set
				{
					this.m_Toggle = value;
				}
			}

			// Token: 0x060000AA RID: 170 RVA: 0x000038F0 File Offset: 0x00001AF0
			public virtual void OnPointerEnter(PointerEventData eventData)
			{
				if (!true)
				{
				}
				EventSystem current = EventSystem.current;
				GameObject gameObject = base.gameObject;
				current.SetSelectedGameObject(gameObject);
			}

			// Token: 0x060000AB RID: 171 RVA: 0x00003918 File Offset: 0x00001B18
			public virtual void OnCancel(BaseEventData eventData)
			{
				Dropdown componentInParent = base.GetComponentInParent<Dropdown>();
				bool flag = componentInParent;
				componentInParent.Hide();
			}

			// Token: 0x060000AC RID: 172 RVA: 0x0000393C File Offset: 0x00001B3C
			public DropdownItem()
			{
			}

			// Token: 0x0400004E RID: 78
			[SerializeField]
			private Text m_Text;

			// Token: 0x0400004F RID: 79
			[SerializeField]
			private Image m_Image;

			// Token: 0x04000050 RID: 80
			[SerializeField]
			private RectTransform m_RectTransform;

			// Token: 0x04000051 RID: 81
			[SerializeField]
			private Toggle m_Toggle;
		}

		// Token: 0x02000015 RID: 21
		[Serializable]
		public class OptionData
		{
			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000AD RID: 173 RVA: 0x00003950 File Offset: 0x00001B50
			// (set) Token: 0x060000AE RID: 174 RVA: 0x00003964 File Offset: 0x00001B64
			public string text
			{
				get
				{
					return this.m_Text;
				}
				set
				{
					this.m_Text = value;
				}
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000AF RID: 175 RVA: 0x00003978 File Offset: 0x00001B78
			// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000398C File Offset: 0x00001B8C
			public Sprite image
			{
				get
				{
					return this.m_Image;
				}
				set
				{
					this.m_Image = value;
				}
			}

			// Token: 0x060000B1 RID: 177 RVA: 0x000039A0 File Offset: 0x00001BA0
			public OptionData()
			{
			}

			// Token: 0x060000B2 RID: 178 RVA: 0x000039B4 File Offset: 0x00001BB4
			public OptionData(string text)
			{
				this.m_Text = text;
			}

			// Token: 0x060000B3 RID: 179 RVA: 0x000039D0 File Offset: 0x00001BD0
			public OptionData(Sprite image)
			{
				this.m_Image = image;
			}

			// Token: 0x060000B4 RID: 180 RVA: 0x000039EC File Offset: 0x00001BEC
			public OptionData(string text, Sprite image)
			{
				this.m_Text = text;
				this.m_Image = image;
			}

			// Token: 0x04000052 RID: 82
			[SerializeField]
			private string m_Text;

			// Token: 0x04000053 RID: 83
			[SerializeField]
			private Sprite m_Image;
		}

		// Token: 0x02000016 RID: 22
		[Serializable]
		public class OptionDataList
		{
			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000B5 RID: 181 RVA: 0x00003A10 File Offset: 0x00001C10
			// (set) Token: 0x060000B6 RID: 182 RVA: 0x00003A24 File Offset: 0x00001C24
			public List<Dropdown.OptionData> options
			{
				get
				{
					return this.m_Options;
				}
				set
				{
					this.m_Options = value;
				}
			}

			// Token: 0x060000B7 RID: 183 RVA: 0x00003A38 File Offset: 0x00001C38
			public OptionDataList()
			{
			}

			// Token: 0x04000054 RID: 84
			[SerializeField]
			private List<Dropdown.OptionData> m_Options;
		}

		// Token: 0x02000017 RID: 23
		[Serializable]
		public class DropdownEvent : UnityEvent<int>
		{
			// Token: 0x060000B8 RID: 184 RVA: 0x00003A4C File Offset: 0x00001C4C
			public DropdownEvent()
			{
			}
		}

		// Token: 0x02000018 RID: 24
		[CompilerGenerated]
		private sealed class <>c__DisplayClass63_0
		{
			// Token: 0x060000B9 RID: 185 RVA: 0x00003A5C File Offset: 0x00001C5C
			public <>c__DisplayClass63_0()
			{
			}

			// Token: 0x060000BA RID: 186 RVA: 0x00003A70 File Offset: 0x00001C70
			internal void <Show>b__0(bool x)
			{
				Dropdown.DropdownItem dropdownItem = this.item;
				Dropdown dropdown = this.<>4__this;
				Toggle toggle = dropdownItem.m_Toggle;
				dropdown.OnSelectItem(toggle);
			}

			// Token: 0x04000055 RID: 85
			public Dropdown.DropdownItem item;

			// Token: 0x04000056 RID: 86
			public Dropdown <>4__this;
		}

		// Token: 0x02000019 RID: 25
		[CompilerGenerated]
		private sealed class <DelayedDestroyDropdownList>d__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060000BB RID: 187 RVA: 0x00003A9C File Offset: 0x00001C9C
			[DebuggerHidden]
			public <DelayedDestroyDropdownList>d__75(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			// Token: 0x060000BC RID: 188 RVA: 0x00003AB8 File Offset: 0x00001CB8
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x060000BD RID: 189 RVA: 0x00003AC8 File Offset: 0x00001CC8
			private bool MoveNext()
			{
				if (this.<>1__state == 0)
				{
					float num = this.delay;
					this.<>1__state = 1;
					return true;
				}
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060000BE RID: 190 RVA: 0x00003AFC File Offset: 0x00001CFC
			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060000BF RID: 191 RVA: 0x00002207 File Offset: 0x00000407
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060000C0 RID: 192 RVA: 0x00003B10 File Offset: 0x00001D10
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x04000057 RID: 87
			private int <>1__state;

			// Token: 0x04000058 RID: 88
			private object <>2__current;

			// Token: 0x04000059 RID: 89
			public float delay;

			// Token: 0x0400005A RID: 90
			public Dropdown <>4__this;
		}
	}
}
