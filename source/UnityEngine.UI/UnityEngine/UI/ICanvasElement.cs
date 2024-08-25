using System;

namespace UnityEngine.UI
{
	// Token: 0x02000007 RID: 7
	public interface ICanvasElement
	{
		// Token: 0x0600001A RID: 26
		void Rebuild(CanvasUpdate executing);

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001B RID: 27
		Transform transform { get; }

		// Token: 0x0600001C RID: 28
		void LayoutComplete();

		// Token: 0x0600001D RID: 29
		void GraphicUpdateComplete();

		// Token: 0x0600001E RID: 30
		bool IsDestroyed();
	}
}
