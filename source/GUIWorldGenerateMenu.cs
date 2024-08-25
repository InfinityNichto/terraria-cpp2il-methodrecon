using System;
using Terraria;
using Terraria.WorldBuilding;

// Token: 0x02000286 RID: 646
public class GUIWorldGenerateMenu
{
	// Token: 0x06000EEE RID: 3822 RVA: 0x0004A6C8 File Offset: 0x000488C8
	public void Draw()
	{
		if (!true)
		{
		}
		Main.FlushBatches();
		double num = this.Progress.TotalProgress;
		GenerationProgress generationProgress = this.Progress;
		double value = generationProgress._value;
		if (generationProgress == null)
		{
		}
		if (generationProgress == null)
		{
		}
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x0004A79C File Offset: 0x0004899C
	public GUIWorldGenerateMenu()
	{
	}

	// Token: 0x04001B10 RID: 6928
	public GenerationProgress Progress;

	// Token: 0x04001B11 RID: 6929
	public float totalProgress;

	// Token: 0x04001B12 RID: 6930
	public float progress;
}
