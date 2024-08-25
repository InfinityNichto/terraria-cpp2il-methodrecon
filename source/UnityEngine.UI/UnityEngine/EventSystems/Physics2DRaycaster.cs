using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000BD RID: 189
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Event/Physics 2D Raycaster")]
	public class Physics2DRaycaster : PhysicsRaycaster
	{
		// Token: 0x060006D5 RID: 1749 RVA: 0x0001375C File Offset: 0x0001195C
		protected Physics2DRaycaster()
		{
			LayerMask layerMask;
			this.m_EventMask = layerMask;
			base..ctor();
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00002207 File Offset: 0x00000407
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000318 RID: 792
		private RaycastHit2D[] m_Hits;
	}
}
