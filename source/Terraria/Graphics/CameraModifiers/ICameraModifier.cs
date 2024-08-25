using System;

namespace Terraria.Graphics.CameraModifiers
{
	// Token: 0x02000770 RID: 1904
	public interface ICameraModifier
	{
		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06003E6C RID: 15980
		string UniqueIdentity { get; }

		// Token: 0x06003E6D RID: 15981
		void Update(CameraInfo cameraPosition);

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06003E6E RID: 15982
		bool Finished { get; }
	}
}
