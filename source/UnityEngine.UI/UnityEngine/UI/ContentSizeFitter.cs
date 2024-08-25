using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200003E RID: 62
	[RequireComponent(typeof(RectTransform))]
	[ExecuteAlways]
	[AddComponentMenu("Layout/Content Size Fitter", 141)]
	public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00009698 File Offset: 0x00007898
		// (set) Token: 0x06000273 RID: 627 RVA: 0x000096AC File Offset: 0x000078AC
		public ContentSizeFitter.FitMode horizontalFit
		{
			get
			{
				return this.m_HorizontalFit;
			}
			set
			{
				this.SetDirty();
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000274 RID: 628 RVA: 0x000096C0 File Offset: 0x000078C0
		// (set) Token: 0x06000275 RID: 629 RVA: 0x000096D4 File Offset: 0x000078D4
		public ContentSizeFitter.FitMode verticalFit
		{
			get
			{
				return this.m_VerticalFit;
			}
			set
			{
				this.SetDirty();
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000276 RID: 630 RVA: 0x000096E8 File Offset: 0x000078E8
		private RectTransform rectTransform
		{
			get
			{
				RectTransform rect = this.m_Rect;
				if (!true)
				{
				}
				RectTransform component = base.GetComponent<RectTransform>();
				this.m_Rect = component;
				return component;
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00009718 File Offset: 0x00007918
		protected ContentSizeFitter()
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000972C File Offset: 0x0000792C
		protected override void OnEnable()
		{
			base.OnEnable();
			this.SetDirty();
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00009748 File Offset: 0x00007948
		protected override void OnDisable()
		{
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
			base.OnDisable();
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00009768 File Offset: 0x00007968
		protected override void OnRectTransformDimensionsChange()
		{
			this.SetDirty();
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000977C File Offset: 0x0000797C
		private void HandleSelfFittingAlongAxis(int axis)
		{
			RectTransform rectTransform = this.rectTransform;
			RectTransform rectTransform2 = this.rectTransform;
			RectTransform rect = this.m_Rect;
			if (axis != 0)
			{
				float minHeight = LayoutUtility.GetMinHeight(rect);
				return;
			}
			float minWidth = LayoutUtility.GetMinWidth(rect);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000097C8 File Offset: 0x000079C8
		public virtual void SetLayoutHorizontal()
		{
			long num = 0L;
			this.HandleSelfFittingAlongAxis((int)num);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000097E0 File Offset: 0x000079E0
		public virtual void SetLayoutVertical()
		{
			this.HandleSelfFittingAlongAxis(1);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000097F4 File Offset: 0x000079F4
		protected void SetDirty()
		{
			LayoutRebuilder.MarkLayoutForRebuild(this.rectTransform);
		}

		// Token: 0x0400014B RID: 331
		[SerializeField]
		protected ContentSizeFitter.FitMode m_HorizontalFit;

		// Token: 0x0400014C RID: 332
		[SerializeField]
		protected ContentSizeFitter.FitMode m_VerticalFit;

		// Token: 0x0400014D RID: 333
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x0400014E RID: 334
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x0200003F RID: 63
		public enum FitMode
		{
			// Token: 0x04000150 RID: 336
			Unconstrained,
			// Token: 0x04000151 RID: 337
			MinSize,
			// Token: 0x04000152 RID: 338
			PreferredSize
		}
	}
}
