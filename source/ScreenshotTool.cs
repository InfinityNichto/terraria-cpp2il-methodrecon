using System;
using UnityEngine;

// Token: 0x02000308 RID: 776
public class ScreenshotTool : MonoBehaviour
{
	// Token: 0x170001AD RID: 429
	// (get) Token: 0x060011FF RID: 4607 RVA: 0x00057C34 File Offset: 0x00055E34
	// (set) Token: 0x06001200 RID: 4608 RVA: 0x00057C48 File Offset: 0x00055E48
	public bool UseControllerInput
	{
		get
		{
			return this.useControllerInput;
		}
		set
		{
		}
	}

	// Token: 0x170001AE RID: 430
	// (get) Token: 0x06001201 RID: 4609 RVA: 0x00057C58 File Offset: 0x00055E58
	public bool TakeScreenShotThisFrame
	{
		get
		{
			if (this.TakeScreenShot)
			{
				float num = this.delayRemaining;
				float deltaTime = Time.deltaTime;
				bool lastTakeShot = this.LastTakeShot;
				float initialDelay = this.InitialDelay;
				this.delayRemaining = initialDelay;
				return;
			}
		}
	}

	// Token: 0x06001202 RID: 4610 RVA: 0x00057C9C File Offset: 0x00055E9C
	private void Awake()
	{
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x06001203 RID: 4611 RVA: 0x00057CAC File Offset: 0x00055EAC
	// (set) Token: 0x06001204 RID: 4612 RVA: 0x00057CC0 File Offset: 0x00055EC0
	public ScreenshotSetup ActiveScreenshot
	{
		get
		{
			return this._activeScreenshot;
		}
		set
		{
			this._activeScreenshot = value;
		}
	}

	// Token: 0x06001205 RID: 4613 RVA: 0x00057CD4 File Offset: 0x00055ED4
	public ScreenshotTool()
	{
	}

	// Token: 0x04002189 RID: 8585
	public static ScreenshotTool Instance;

	// Token: 0x0400218A RID: 8586
	public bool TakeScreenShot;

	// Token: 0x0400218B RID: 8587
	public float InitialDelay;

	// Token: 0x0400218C RID: 8588
	private bool LastTakeShot;

	// Token: 0x0400218D RID: 8589
	private float delayRemaining;

	// Token: 0x0400218E RID: 8590
	private bool useControllerInput;

	// Token: 0x0400218F RID: 8591
	private ScreenshotSetup _activeScreenshot;

	// Token: 0x04002190 RID: 8592
	public ScreenshotSetup[] Definitions;
}
