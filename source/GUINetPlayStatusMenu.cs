using System;
using Terraria;
using Terraria.Localization;

// Token: 0x02000273 RID: 627
public class GUINetPlayStatusMenu
{
	// Token: 0x06000E0B RID: 3595 RVA: 0x000438F0 File Offset: 0x00041AF0
	public void Draw()
	{
		if (!true)
		{
		}
		long num = 0L;
		Main.ClearVisualPostProcessEffects();
		if (num != 0L)
		{
		}
		this.Quit();
		string textValue = Language.GetTextValue("Net.LostConnection");
		string textValue2 = Language.GetTextValue("Net.LostConnection");
	}

	// Token: 0x06000E0C RID: 3596 RVA: 0x00043954 File Offset: 0x00041B54
	public void Quit()
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num == 0 || num != 0)
		{
		}
	}

	// Token: 0x06000E0D RID: 3597 RVA: 0x00043980 File Offset: 0x00041B80
	private void UpdateServerStatus()
	{
	}

	// Token: 0x06000E0E RID: 3598 RVA: 0x000439A0 File Offset: 0x00041BA0
	private void QuitCallBack(object threadContext)
	{
		if (threadContext != null)
		{
		}
		DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
		PlatformUser currentUser = PlatformUser.CurrentUser;
	}

	// Token: 0x06000E0F RID: 3599 RVA: 0x000439FC File Offset: 0x00041BFC
	public GUINetPlayStatusMenu()
	{
	}

	// Token: 0x040019B9 RID: 6585
	private float scale0;

	// Token: 0x040019BA RID: 6586
	private float scale1;

	// Token: 0x040019BB RID: 6587
	private float scale2;
}
