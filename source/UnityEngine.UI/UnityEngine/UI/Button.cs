using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000003 RID: 3
	[AddComponentMenu("UI/Button", 30)]
	public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002164 File Offset: 0x00000364
		protected Button()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000217C File Offset: 0x0000037C
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002190 File Offset: 0x00000390
		public Button.ButtonClickedEvent onClick
		{
			get
			{
				return this.m_OnClick;
			}
			set
			{
				this.m_OnClick = value;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000021A4 File Offset: 0x000003A4
		private void Press()
		{
			UISystemProfilerApi.AddMarker("Button.onClick", this);
			this.m_OnClick.Invoke();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021C8 File Offset: 0x000003C8
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			if (eventData.<button>k__BackingField != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.Press();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000021E4 File Offset: 0x000003E4
		public virtual void OnSubmit(BaseEventData eventData)
		{
			this.Press();
			IEnumerator enumerator = this.OnFinishSubmit();
			Coroutine coroutine = base.StartCoroutine(enumerator);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002207 File Offset: 0x00000407
		private IEnumerator OnFinishSubmit()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400000B RID: 11
		[SerializeField]
		[FormerlySerializedAs("onClick")]
		private Button.ButtonClickedEvent m_OnClick;

		// Token: 0x02000004 RID: 4
		[Serializable]
		public class ButtonClickedEvent : UnityEvent
		{
			// Token: 0x06000013 RID: 19 RVA: 0x00002214 File Offset: 0x00000414
			public ButtonClickedEvent()
			{
			}
		}

		// Token: 0x02000005 RID: 5
		[CompilerGenerated]
		private sealed class <OnFinishSubmit>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000014 RID: 20 RVA: 0x00002228 File Offset: 0x00000428
			[DebuggerHidden]
			public <OnFinishSubmit>d__9(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			// Token: 0x06000015 RID: 21 RVA: 0x00002244 File Offset: 0x00000444
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06000016 RID: 22 RVA: 0x00002254 File Offset: 0x00000454
			private bool MoveNext()
			{
				int num = this.<>1__state;
				Button button = this.<>4__this;
				float num2;
				if (num == 0)
				{
					this.<>1__state = num;
					float fadeDuration = button.m_Colors.m_FadeDuration;
					this.<fadeTime>5__2 = fadeDuration;
					num2 = this.<fadeTime>5__2;
					float num3 = this.<elapsedTime>5__3;
					this.<>1__state = (int)fadeDuration;
					Selectable.SelectionState currentSelectionState = button.currentSelectionState;
				}
				float unscaledDeltaTime = Time.unscaledDeltaTime;
				this.<elapsedTime>5__3 = num2;
				this.<>1__state = 1;
				return true;
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000017 RID: 23 RVA: 0x000022C8 File Offset: 0x000004C8
			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x06000018 RID: 24 RVA: 0x00002207 File Offset: 0x00000407
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000019 RID: 25 RVA: 0x000022DC File Offset: 0x000004DC
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x0400000C RID: 12
			private int <>1__state;

			// Token: 0x0400000D RID: 13
			private object <>2__current;

			// Token: 0x0400000E RID: 14
			public Button <>4__this;

			// Token: 0x0400000F RID: 15
			private float <fadeTime>5__2;

			// Token: 0x04000010 RID: 16
			private float <elapsedTime>5__3;
		}
	}
}
