using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x02000737 RID: 1847
	public struct VertexColors
	{
		// Token: 0x06003D11 RID: 15633 RVA: 0x00238488 File Offset: 0x00236688
		public VertexColors(Color color)
		{
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x00238498 File Offset: 0x00236698
		public VertexColors(Color topLeft, Color topRight, Color bottomRight, Color bottomLeft)
		{
			this.TopLeftColor = topLeft;
			this.BottomLeftColor = topRight;
			this.BottomLeftColor = bottomLeft;
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x000021DB File Offset: 0x000003DB
		public static implicit operator VertexColors(Color color)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04007C05 RID: 31749
		public Color TopLeftColor;

		// Token: 0x04007C06 RID: 31750
		public Color TopRightColor;

		// Token: 0x04007C07 RID: 31751
		public Color BottomLeftColor;

		// Token: 0x04007C08 RID: 31752
		public Color BottomRightColor;
	}
}
