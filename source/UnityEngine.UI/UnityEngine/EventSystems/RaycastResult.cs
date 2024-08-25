using System;
using Cpp2IlInjected;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000C0 RID: 192
	public struct RaycastResult
	{
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x00002207 File Offset: 0x00000407
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x000138D4 File Offset: 0x00011AD4
		public GameObject gameObject
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this.m_GameObject = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x000138E8 File Offset: 0x00011AE8
		public bool isValid
		{
			get
			{
				BaseRaycaster baseRaycaster = this.module;
				if (!true)
				{
				}
				if (!true)
				{
				}
				bool flag;
				return flag;
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00013908 File Offset: 0x00011B08
		public void Clear()
		{
			this.worldPosition.z = (float)1;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00013924 File Offset: 0x00011B24
		public override string ToString()
		{
			bool isValid = this.isValid;
			if ("Name: " == null || "Name: " != null)
			{
				return "";
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04000320 RID: 800
		private GameObject m_GameObject;

		// Token: 0x04000321 RID: 801
		public BaseRaycaster module;

		// Token: 0x04000322 RID: 802
		public float distance;

		// Token: 0x04000323 RID: 803
		public float index;

		// Token: 0x04000324 RID: 804
		public int depth;

		// Token: 0x04000325 RID: 805
		public int sortingLayer;

		// Token: 0x04000326 RID: 806
		public int sortingOrder;

		// Token: 0x04000327 RID: 807
		public Vector3 worldPosition;

		// Token: 0x04000328 RID: 808
		public Vector3 worldNormal;

		// Token: 0x04000329 RID: 809
		public Vector2 screenPosition;

		// Token: 0x0400032A RID: 810
		public int displayIndex;
	}
}
