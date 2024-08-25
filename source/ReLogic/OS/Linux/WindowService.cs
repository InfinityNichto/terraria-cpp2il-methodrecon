using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace ReLogic.OS.Linux
{
	// Token: 0x02000B2C RID: 2860
	internal class WindowService : IWindowService
	{
		// Token: 0x0600536C RID: 21356 RVA: 0x002848FC File Offset: 0x00282AFC
		public void SetUnicodeTitle(GameWindow window, string title)
		{
			window.Title = title;
		}

		// Token: 0x0600536D RID: 21357 RVA: 0x00284910 File Offset: 0x00282B10
		public void StartFlashingIcon(GameWindow window)
		{
		}

		// Token: 0x0600536E RID: 21358 RVA: 0x00284920 File Offset: 0x00282B20
		public void StopFlashingIcon(GameWindow window)
		{
		}

		// Token: 0x0600536F RID: 21359 RVA: 0x000021DB File Offset: 0x000003DB
		public float GetScaling()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005370 RID: 21360 RVA: 0x00284930 File Offset: 0x00282B30
		public void SetQuickEditEnabled(bool enabled)
		{
		}

		// Token: 0x06005371 RID: 21361 RVA: 0x00284940 File Offset: 0x00282B40
		public WindowService()
		{
		}
	}
}
