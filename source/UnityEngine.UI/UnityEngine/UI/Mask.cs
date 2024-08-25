using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000053 RID: 83
	[AddComponentMenu("UI/Mask", 13)]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	[DisallowMultipleComponent]
	public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0000AA18 File Offset: 0x00008C18
		public RectTransform rectTransform
		{
			get
			{
				RectTransform component;
				if (this.m_RectTransform == null)
				{
					component = base.GetComponent<RectTransform>();
					this.m_RectTransform = component;
				}
				return component;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000AA3C File Offset: 0x00008C3C
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0000AA50 File Offset: 0x00008C50
		public bool showMaskGraphic
		{
			get
			{
				return this.m_ShowMaskGraphic;
			}
			set
			{
				bool showMaskGraphic = this.m_ShowMaskGraphic;
				Graphic graphic = this.graphic;
				Graphic graphic2 = this.graphic;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0000AA74 File Offset: 0x00008C74
		public Graphic graphic
		{
			get
			{
				Graphic component;
				if (this.m_Graphic == null)
				{
					component = base.GetComponent<Graphic>();
					this.m_Graphic = component;
				}
				return component;
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000AA98 File Offset: 0x00008C98
		protected Mask()
		{
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000AAB4 File Offset: 0x00008CB4
		public virtual bool MaskEnabled()
		{
			Graphic graphic = this.graphic;
			bool flag;
			return flag;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000AACC File Offset: 0x00008CCC
		[Obsolete("Not used anymore.")]
		public virtual void OnSiblingGraphicEnabledDisabled()
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000AADC File Offset: 0x00008CDC
		protected override void OnEnable()
		{
			base.OnEnable();
			Graphic graphic = this.graphic;
			CanvasRenderer canvasRenderer = this.graphic.canvasRenderer;
			int num = 1;
			canvasRenderer.hasPopInstruction = num != 0;
			Graphic graphic2 = this.graphic;
			if (this.graphic != null)
			{
				if (this.graphic != null)
				{
				}
				return;
			}
			MaskUtilities.NotifyStencilStateChanged(this);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000AB30 File Offset: 0x00008D30
		protected override void OnDisable()
		{
			base.OnDisable();
			Graphic graphic = this.graphic;
			Graphic graphic2 = this.graphic;
			CanvasRenderer canvasRenderer = this.graphic.canvasRenderer;
			long num = 0L;
			canvasRenderer.hasPopInstruction = num != 0L;
			CanvasRenderer canvasRenderer2 = this.graphic.canvasRenderer;
			long num2 = 0L;
			canvasRenderer2.popMaterialCount = (int)num2;
			long num3;
			if (this.graphic != null)
			{
				if (this.graphic != null)
				{
				}
				num3 = 0L;
				return;
			}
			Material maskMaterial = this.m_MaskMaterial;
			if (num3 == 0L)
			{
			}
			StencilMaterial.Remove(maskMaterial);
			StencilMaterial.Remove(this.m_UnmaskMaterial);
			MaskUtilities.NotifyStencilStateChanged(this);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000ABBC File Offset: 0x00008DBC
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			bool isActiveAndEnabled = base.isActiveAndEnabled;
			RectTransform rectTransform = this.rectTransform;
			bool flag;
			return flag;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000ABDC File Offset: 0x00008DDC
		public virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			Transform transform = MaskUtilities.FindRootSortOverrideCanvas(base.transform);
			int stencilDepth = MaskUtilities.GetStencilDepth(base.transform, transform);
			bool showMaskGraphic = this.m_ShowMaskGraphic;
			StencilMaterial.Remove(this.m_MaskMaterial);
			Material material;
			this.m_MaskMaterial = material;
			CanvasRenderer canvasRenderer = this.graphic.canvasRenderer;
			int num = 1;
			canvasRenderer.hasPopInstruction = num != 0;
			Material material2;
			return material2;
		}

		// Token: 0x04000192 RID: 402
		[NonSerialized]
		private RectTransform m_RectTransform;

		// Token: 0x04000193 RID: 403
		[SerializeField]
		private bool m_ShowMaskGraphic = true;

		// Token: 0x04000194 RID: 404
		[NonSerialized]
		private Graphic m_Graphic;

		// Token: 0x04000195 RID: 405
		[NonSerialized]
		private Material m_MaskMaterial;

		// Token: 0x04000196 RID: 406
		[NonSerialized]
		private Material m_UnmaskMaterial;
	}
}
