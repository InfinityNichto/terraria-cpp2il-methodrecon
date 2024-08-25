using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000081 RID: 129
	[ExecuteAlways]
	public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier
	{
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00010478 File Offset: 0x0000E678
		protected Graphic graphic
		{
			get
			{
				Graphic graphic = this.m_Graphic;
				if (!true)
				{
				}
				Graphic component = base.GetComponent<Graphic>();
				this.m_Graphic = component;
				return component;
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x000104A8 File Offset: 0x0000E6A8
		protected override void OnEnable()
		{
			base.OnEnable();
			Graphic graphic = this.graphic;
			Graphic graphic2 = this.graphic;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000104CC File Offset: 0x0000E6CC
		protected override void OnDisable()
		{
			Graphic graphic = this.graphic;
			Graphic graphic2 = this.graphic;
			base.OnDisable();
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x000104F0 File Offset: 0x0000E6F0
		protected override void OnDidApplyAnimationProperties()
		{
			Graphic graphic = this.graphic;
			Graphic graphic2 = this.graphic;
			base.OnDidApplyAnimationProperties();
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00010514 File Offset: 0x0000E714
		public virtual void ModifyMesh(Mesh mesh)
		{
		}

		// Token: 0x06000529 RID: 1321
		public abstract void ModifyMesh(VertexHelper vh);

		// Token: 0x0600052A RID: 1322 RVA: 0x00010548 File Offset: 0x0000E748
		protected BaseMeshEffect()
		{
		}

		// Token: 0x0400026A RID: 618
		[NonSerialized]
		private Graphic m_Graphic;
	}
}
