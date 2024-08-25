using System;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000380 RID: 896
	public interface IGraphicsDeviceService
	{
		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060017BE RID: 6078
		GraphicsDevice GraphicsDevice { get; }

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060017BF RID: 6079
		// (remove) Token: 0x060017C0 RID: 6080
		event EventHandler<EventArgs> DeviceCreated;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060017C1 RID: 6081
		// (remove) Token: 0x060017C2 RID: 6082
		event EventHandler<EventArgs> DeviceDisposing;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x060017C3 RID: 6083
		// (remove) Token: 0x060017C4 RID: 6084
		event EventHandler<EventArgs> DeviceReset;

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x060017C5 RID: 6085
		// (remove) Token: 0x060017C6 RID: 6086
		event EventHandler<EventArgs> DeviceResetting;
	}
}
