using System;

namespace InControl
{
	// Token: 0x0200001D RID: 29
	public interface IInputControl
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600012B RID: 299
		bool HasChanged { get; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600012C RID: 300
		bool IsPressed { get; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600012D RID: 301
		bool WasPressed { get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600012E RID: 302
		bool WasReleased { get; }

		// Token: 0x0600012F RID: 303
		void ClearInputState();
	}
}
