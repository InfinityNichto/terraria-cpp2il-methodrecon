using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UnityEngine.UI
{
	// Token: 0x02000082 RID: 130
	[Obsolete("Use IMeshModifier instead", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface IVertexModifier
	{
		// Token: 0x0600052B RID: 1323
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", true)]
		void ModifyVertices(List<UIVertex> verts);
	}
}
