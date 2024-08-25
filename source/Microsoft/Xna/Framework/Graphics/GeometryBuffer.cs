using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200036F RID: 879
	public class GeometryBuffer
	{
		// Token: 0x060016E5 RID: 5861 RVA: 0x000640A4 File Offset: 0x000622A4
		public GeometryBuffer(bool dynamic)
		{
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x000021DB File Offset: 0x000003DB
		private T[] Clone<T>(T[] srcArray, int Count)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x000640B8 File Offset: 0x000622B8
		public void RenderAndFlush()
		{
			if (!true)
			{
			}
			int offset = this._current._offset;
			Material material;
			this._current._meshRenderer.material = material;
		}

		// Token: 0x04002579 RID: 9593
		public static int RenderLayer;

		// Token: 0x0400257A RID: 9594
		private GeometryBufferInstance _current;
	}
}
