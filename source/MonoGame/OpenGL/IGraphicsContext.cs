using System;

namespace MonoGame.OpenGL
{
	// Token: 0x0200031C RID: 796
	internal interface IGraphicsContext
	{
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06001287 RID: 4743
		// (set) Token: 0x06001288 RID: 4744
		int SwapInterval { get; set; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06001289 RID: 4745
		bool IsDisposed { get; }

		// Token: 0x0600128A RID: 4746
		void MakeCurrent(IWindowInfo info);

		// Token: 0x0600128B RID: 4747
		void SwapBuffers();

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600128C RID: 4748
		bool IsCurrent { get; }
	}
}
