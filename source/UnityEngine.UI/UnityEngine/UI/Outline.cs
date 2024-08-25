using System;

namespace UnityEngine.UI
{
	// Token: 0x02000084 RID: 132
	[AddComponentMenu("UI/Effects/Outline", 81)]
	public class Outline : Shadow
	{
		// Token: 0x0600052E RID: 1326 RVA: 0x0001055C File Offset: 0x0000E75C
		protected Outline()
		{
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00010570 File Offset: 0x0000E770
		public override void ModifyMesh(VertexHelper vh)
		{
			float r = this.m_EffectColor.r;
			float g = this.m_EffectColor.g;
			float b = this.m_EffectColor.b;
			float a = this.m_EffectColor.a;
		}
	}
}
