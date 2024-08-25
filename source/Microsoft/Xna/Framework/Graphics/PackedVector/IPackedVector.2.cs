using System;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003B9 RID: 953
	public interface IPackedVector<TPacked> : IPackedVector
	{
		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060019B8 RID: 6584
		// (set) Token: 0x060019B9 RID: 6585
		TPacked PackedValue { get; set; }
	}
}
