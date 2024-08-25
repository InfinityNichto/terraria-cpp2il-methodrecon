using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000073 RID: 115
	[AddComponentMenu("UI/Toggle", 30)]
	[RequireComponent(typeof(RectTransform))]
	public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement
	{
		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x0000F2F0 File Offset: 0x0000D4F0
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x0000F304 File Offset: 0x0000D504
		public ToggleGroup group
		{
			get
			{
				return this.m_Group;
			}
			set
			{
				this.SetToggleGroup(value, true);
				this.PlayEffect(true);
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0000F320 File Offset: 0x0000D520
		protected Toggle()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0000F340 File Offset: 0x0000D540
		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0000F350 File Offset: 0x0000D550
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0000F360 File Offset: 0x0000D560
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0000F370 File Offset: 0x0000D570
		protected override void OnDestroy()
		{
			ToggleGroup group = this.m_Group;
			if (!true)
			{
			}
			this.m_Group.EnsureValidState();
			base.OnDestroy();
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0000F398 File Offset: 0x0000D598
		protected override void OnEnable()
		{
			base.OnEnable();
			ToggleGroup group = this.m_Group;
			long num = 0L;
			this.SetToggleGroup(group, num != 0L);
			this.PlayEffect(true);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0000F3C4 File Offset: 0x0000D5C4
		protected override void OnDisable()
		{
			base.OnDisable();
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		protected override void OnDidApplyAnimationProperties()
		{
			Graphic graphic = this.graphic;
			if (!true)
			{
			}
			CanvasRenderer canvasRenderer = this.graphic.canvasRenderer;
			long num = 0L;
			Color color = canvasRenderer.GetColor();
			bool isOn = this.m_IsOn;
			this.Set(num != 0L, true);
			base.OnSetProperty();
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0000F41C File Offset: 0x0000D61C
		private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue)
		{
			ToggleGroup group = this.m_Group;
			if (!true)
			{
			}
			this.m_Group.UnregisterToggle(this);
			this.m_Group = newGroup;
			if (!true)
			{
			}
			newGroup.RegisterToggle(this);
			if (this.m_IsOn)
			{
				newGroup.NotifyToggleOn(this, true);
				return;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x0000F464 File Offset: 0x0000D664
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x0000F478 File Offset: 0x0000D678
		public bool isOn
		{
			get
			{
				return this.m_IsOn;
			}
			set
			{
				this.Set(value, true);
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0000F490 File Offset: 0x0000D690
		public void SetIsOnWithoutNotify(bool value)
		{
			long num = 0L;
			this.Set(value, num != 0L);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0000F4A8 File Offset: 0x0000D6A8
		private void Set(bool value, bool sendCallback = true)
		{
			long num;
			ToggleGroup group2;
			for (;;)
			{
				bool isOn = this.m_IsOn;
				ToggleGroup group = this.m_Group;
				num = 0L;
				bool isActiveAndEnabled = this.m_Group.isActiveAndEnabled;
				bool isOn2 = this.m_IsOn;
				group2 = this.m_Group;
				if (isOn2)
				{
					break;
				}
				bool flag = group2.AnyTogglesOn();
				if (this.m_Group.m_AllowSwitchOff)
				{
					goto Block_1;
				}
			}
			this.m_IsOn = true;
			group2.NotifyToggleOn(this, num != 0L);
			return;
			Block_1:
			Toggle.ToggleTransition toggleTransition = this.toggleTransition;
			UISystemProfilerApi.AddMarker("Toggle.value", this);
			Toggle.ToggleEvent toggleEvent = this.onValueChanged;
			bool isOn3 = this.m_IsOn;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0000F534 File Offset: 0x0000D734
		private void PlayEffect(bool instant)
		{
			Graphic graphic = this.graphic;
			if (!true)
			{
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0000F55C File Offset: 0x0000D75C
		protected override void Start()
		{
			this.PlayEffect(true);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0000F570 File Offset: 0x0000D770
		private void InternalToggle()
		{
			bool isOn = this.m_IsOn;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0000F588 File Offset: 0x0000D788
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			if (eventData.<button>k__BackingField != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.InternalToggle();
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0000F5A4 File Offset: 0x0000D7A4
		public virtual void OnSubmit(BaseEventData eventData)
		{
			this.InternalToggle();
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
		Transform ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x0400024A RID: 586
		public Toggle.ToggleTransition toggleTransition = Toggle.ToggleTransition.Fade;

		// Token: 0x0400024B RID: 587
		public Graphic graphic;

		// Token: 0x0400024C RID: 588
		[SerializeField]
		private ToggleGroup m_Group;

		// Token: 0x0400024D RID: 589
		public Toggle.ToggleEvent onValueChanged;

		// Token: 0x0400024E RID: 590
		[Tooltip("Is the toggle currently on or off?")]
		[SerializeField]
		private bool m_IsOn;

		// Token: 0x02000074 RID: 116
		public enum ToggleTransition
		{
			// Token: 0x04000250 RID: 592
			None,
			// Token: 0x04000251 RID: 593
			Fade
		}

		// Token: 0x02000075 RID: 117
		[Serializable]
		public class ToggleEvent : UnityEvent<bool>
		{
			// Token: 0x060004E1 RID: 1249 RVA: 0x0000F5CC File Offset: 0x0000D7CC
			public ToggleEvent()
			{
			}
		}
	}
}
