using System;

// Token: 0x0200018F RID: 399
public class AchievementToast_Layout : LayoutDefinition
{
	// Token: 0x06000B4B RID: 2891 RVA: 0x0003928C File Offset: 0x0003748C
	private void Awake()
	{
	}

	// Token: 0x06000B4C RID: 2892 RVA: 0x0003929C File Offset: 0x0003749C
	public AchievementToast_Layout()
	{
	}

	// Token: 0x04000C20 RID: 3104
	public static AchievementToast_Layout Instance;

	// Token: 0x04000C21 RID: 3105
	public Panel_Layout achievementBacking;

	// Token: 0x04000C22 RID: 3106
	public String_Layout achievementTitle;

	// Token: 0x04000C23 RID: 3107
	public StringButton_Layout achievementIcon;

	// Token: 0x04000C24 RID: 3108
	public int ToastsSpacing;

	// Token: 0x04000C25 RID: 3109
	public int ToastsTime;

	// Token: 0x04000C26 RID: 3110
	public bool ReverseOrder;
}
