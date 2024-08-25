using System;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003B8 RID: 952
	public interface IPackedVector
	{
		// Token: 0x060019B6 RID: 6582
		void PackFromVector4(Vector4 vector);

		// Token: 0x060019B7 RID: 6583
		Vector4 ToVector4();
	}
}
