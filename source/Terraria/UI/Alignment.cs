using System;
using Microsoft.Xna.Framework;

namespace Terraria.UI
{
	// Token: 0x020006DA RID: 1754
	public struct Alignment
	{
		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06003AF0 RID: 15088 RVA: 0x002333CC File Offset: 0x002315CC
		public Vector2 OffsetMultiplier
		{
			get
			{
				float verticalOffsetMultiplier = this.VerticalOffsetMultiplier;
				float horizontalOffsetMultiplier = this.HorizontalOffsetMultiplier;
				Vector2 vector;
				return vector;
			}
		}

		// Token: 0x06003AF1 RID: 15089 RVA: 0x002333E8 File Offset: 0x002315E8
		private Alignment(float horizontal, float vertical)
		{
		}

		// Token: 0x06003AF2 RID: 15090 RVA: 0x002333F8 File Offset: 0x002315F8
		// Note: this type is marked as 'beforefieldinit'.
		static Alignment()
		{
		}

		// Token: 0x04007AD1 RID: 31441
		public static readonly Alignment TopLeft;

		// Token: 0x04007AD2 RID: 31442
		public static readonly Alignment Top;

		// Token: 0x04007AD3 RID: 31443
		public static readonly Alignment TopRight;

		// Token: 0x04007AD4 RID: 31444
		public static readonly Alignment Left;

		// Token: 0x04007AD5 RID: 31445
		public static readonly Alignment Center;

		// Token: 0x04007AD6 RID: 31446
		public static readonly Alignment Right;

		// Token: 0x04007AD7 RID: 31447
		public static readonly Alignment BottomLeft;

		// Token: 0x04007AD8 RID: 31448
		public static readonly Alignment Bottom;

		// Token: 0x04007AD9 RID: 31449
		public static readonly Alignment BottomRight;

		// Token: 0x04007ADA RID: 31450
		public readonly float VerticalOffsetMultiplier;

		// Token: 0x04007ADB RID: 31451
		public readonly float HorizontalOffsetMultiplier;
	}
}
