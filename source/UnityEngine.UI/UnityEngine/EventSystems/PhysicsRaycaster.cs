using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000BE RID: 190
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Event/Physics Raycaster")]
	public class PhysicsRaycaster : BaseRaycaster
	{
		// Token: 0x060006D7 RID: 1751 RVA: 0x00013778 File Offset: 0x00011978
		protected PhysicsRaycaster()
		{
			LayerMask layerMask;
			this.m_EventMask = layerMask;
			base..ctor();
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00013794 File Offset: 0x00011994
		public override Camera eventCamera
		{
			get
			{
				Camera eventCamera = this.m_EventCamera;
				if (!true)
				{
				}
				Camera component = base.GetComponent<Camera>();
				this.m_EventCamera = component;
				if (component != null)
				{
					return component;
				}
				return Camera.main;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00002207 File Offset: 0x00000407
		public virtual int depth
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x000137CC File Offset: 0x000119CC
		public int finalEventMask
		{
			get
			{
				return this.m_EventMask;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x000137E8 File Offset: 0x000119E8
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x000137FC File Offset: 0x000119FC
		public LayerMask eventMask
		{
			get
			{
				return this.m_EventMask;
			}
			set
			{
				this.m_EventMask = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00013810 File Offset: 0x00011A10
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x00013824 File Offset: 0x00011A24
		public int maxRayIntersections
		{
			get
			{
				return this.m_MaxRayIntersections;
			}
			set
			{
				this.m_MaxRayIntersections = value;
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00013838 File Offset: 0x00011A38
		protected bool ComputeRayAndDistance(PointerEventData eventData, Ray ray, int eventDisplayIndex, float distanceToClipPlane)
		{
			float x = eventData.<position>k__BackingField.x;
			float y = eventData.<position>k__BackingField.y;
			eventDisplayIndex.m_value = eventData;
			float x2 = eventData.<position>k__BackingField.x;
			float y2 = eventData.<position>k__BackingField.y;
			ray.m_Origin = distanceToClipPlane;
			Vector3 direction = ray.direction;
			return true;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00002207 File Offset: 0x00000407
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000319 RID: 793
		protected const int kNoEventMaskSet = -1;

		// Token: 0x0400031A RID: 794
		protected Camera m_EventCamera;

		// Token: 0x0400031B RID: 795
		[SerializeField]
		protected LayerMask m_EventMask;

		// Token: 0x0400031C RID: 796
		[SerializeField]
		protected int m_MaxRayIntersections;

		// Token: 0x0400031D RID: 797
		protected int m_LastMaxRayIntersections;

		// Token: 0x0400031E RID: 798
		private RaycastHit[] m_Hits;

		// Token: 0x020000BF RID: 191
		private class RaycastHitComparer : IComparer<RaycastHit>
		{
			// Token: 0x060006E1 RID: 1761 RVA: 0x00013894 File Offset: 0x00011A94
			public int Compare(RaycastHit x, RaycastHit y)
			{
				float distance = x.distance;
				float distance2 = y.distance;
				int num;
				return num;
			}

			// Token: 0x060006E2 RID: 1762 RVA: 0x000138B0 File Offset: 0x00011AB0
			public RaycastHitComparer()
			{
			}

			// Token: 0x060006E3 RID: 1763 RVA: 0x000138C4 File Offset: 0x00011AC4
			// Note: this type is marked as 'beforefieldinit'.
			static RaycastHitComparer()
			{
			}

			// Token: 0x0400031F RID: 799
			public static PhysicsRaycaster.RaycastHitComparer instance;
		}
	}
}
