using System;

namespace UnityEngine.UI
{
	// Token: 0x02000083 RID: 131
	public interface IMeshModifier
	{
		// Token: 0x0600052C RID: 1324
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts) instead", false)]
		void ModifyMesh(Mesh mesh);

		// Token: 0x0600052D RID: 1325
		void ModifyMesh(VertexHelper verts);
	}
}
