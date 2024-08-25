using System;
using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000BC RID: 188
	public abstract class BaseRaycaster : UIBehaviour
	{
		// Token: 0x060006C9 RID: 1737
		public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060006CA RID: 1738
		public abstract Camera eventCamera { get; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00013614 File Offset: 0x00011814
		[Obsolete("Please use sortOrderPriority and renderOrderPriority", false)]
		public virtual int priority
		{
			get
			{
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x00013624 File Offset: 0x00011824
		public virtual int sortOrderPriority
		{
			get
			{
				return 32768;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00013638 File Offset: 0x00011838
		public virtual int renderOrderPriority
		{
			get
			{
				return 32768;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x0001364C File Offset: 0x0001184C
		public BaseRaycaster rootRaycaster
		{
			get
			{
				int num = 1;
				BaseRaycaster rootRaycaster = this.m_RootRaycaster;
				if (num == 0)
				{
				}
				BaseRaycaster rootRaycaster2 = base.GetComponentsInParent<BaseRaycaster>().m_RootRaycaster;
				if (rootRaycaster2 != null)
				{
					this.m_RootRaycaster = rootRaycaster2;
				}
				return this.m_RootRaycaster;
			}
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00013684 File Offset: 0x00011884
		public override string ToString()
		{
			if ("Name: " == null || "Name: " != null)
			{
				GameObject gameObject = base.gameObject;
				if (gameObject == null || gameObject == null || gameObject == null)
				{
				}
				if ("\neventCamera: " == null || "\neventCamera: " != null)
				{
					if (this == null || this == null || this == null)
					{
					}
					string text;
					string text2;
					if (("\nsortOrderPriority: " == null || "\nsortOrderPriority: " != null) && (text == null || text != null) && ("\nrenderOrderPriority: " == null || "\nrenderOrderPriority: " != null) && (text2 == null || text2 != null))
					{
						string text3;
						return text3;
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x000136F8 File Offset: 0x000118F8
		protected override void OnEnable()
		{
			if (!true)
			{
			}
			RaycasterManager.AddRaycaster(this);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00013710 File Offset: 0x00011910
		protected override void OnDisable()
		{
			if (!true)
			{
			}
			RaycasterManager.RemoveRaycasters(this);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00013728 File Offset: 0x00011928
		protected override void OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00013738 File Offset: 0x00011938
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00013748 File Offset: 0x00011948
		protected BaseRaycaster()
		{
		}

		// Token: 0x04000317 RID: 791
		private BaseRaycaster m_RootRaycaster;
	}
}
