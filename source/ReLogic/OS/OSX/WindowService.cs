using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace ReLogic.OS.OSX
{
	// Token: 0x02000B29 RID: 2857
	internal class WindowService : IWindowService
	{
		// Token: 0x06005360 RID: 21344 RVA: 0x000021DB File Offset: 0x000003DB
		public float GetScaling()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005361 RID: 21345 RVA: 0x0028475C File Offset: 0x0028295C
		public void SetQuickEditEnabled(bool enabled)
		{
		}

		// Token: 0x06005362 RID: 21346 RVA: 0x0028476C File Offset: 0x0028296C
		public void SetUnicodeTitle(GameWindow window, string title)
		{
			window.Title = title;
		}

		// Token: 0x06005363 RID: 21347 RVA: 0x00284780 File Offset: 0x00282980
		public void StartFlashingIcon(GameWindow window)
		{
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x00284790 File Offset: 0x00282990
		public void StopFlashingIcon(GameWindow window)
		{
		}

		// Token: 0x06005365 RID: 21349 RVA: 0x002847A0 File Offset: 0x002829A0
		public WindowService()
		{
		}
	}
}
