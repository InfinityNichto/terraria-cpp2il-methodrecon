using System;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000C1 RID: 193
	public abstract class UIBehaviour : MonoBehaviour
	{
		// Token: 0x060006E9 RID: 1769 RVA: 0x00013AB0 File Offset: 0x00011CB0
		protected virtual void Awake()
		{
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00013AC0 File Offset: 0x00011CC0
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00013AD0 File Offset: 0x00011CD0
		protected virtual void Start()
		{
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00013AE0 File Offset: 0x00011CE0
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00013AF0 File Offset: 0x00011CF0
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00013B00 File Offset: 0x00011D00
		public virtual bool IsActive()
		{
			return base.isActiveAndEnabled;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00013B14 File Offset: 0x00011D14
		protected virtual void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00013B24 File Offset: 0x00011D24
		protected virtual void OnBeforeTransformParentChanged()
		{
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00013B34 File Offset: 0x00011D34
		protected virtual void OnTransformParentChanged()
		{
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00013B44 File Offset: 0x00011D44
		protected virtual void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00013B54 File Offset: 0x00011D54
		protected virtual void OnCanvasGroupChanged()
		{
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00013B64 File Offset: 0x00011D64
		protected virtual void OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00013B74 File Offset: 0x00011D74
		public bool IsDestroyed()
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00013B88 File Offset: 0x00011D88
		protected UIBehaviour()
		{
		}
	}
}
