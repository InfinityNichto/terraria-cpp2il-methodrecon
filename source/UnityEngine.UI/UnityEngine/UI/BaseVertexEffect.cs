using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UnityEngine.UI
{
	// Token: 0x02000080 RID: 128
	[Obsolete("Use BaseMeshEffect instead", true)]
	public abstract class BaseVertexEffect
	{
		// Token: 0x06000522 RID: 1314
		[Obsolete("Use BaseMeshEffect.ModifyMeshes instead", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public abstract void ModifyVertices(List<UIVertex> vertices);

		// Token: 0x06000523 RID: 1315 RVA: 0x00010464 File Offset: 0x0000E664
		protected BaseVertexEffect()
		{
		}
	}
}
