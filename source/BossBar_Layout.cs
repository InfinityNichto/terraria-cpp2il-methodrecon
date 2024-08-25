using System;

// Token: 0x02000192 RID: 402
public class BossBar_Layout : LayoutDefinition
{
	// Token: 0x06000B50 RID: 2896 RVA: 0x00039324 File Offset: 0x00037524
	private void Awake()
	{
		bool flag = this.name.Contains("Mobile");
	}

	// Token: 0x06000B51 RID: 2897 RVA: 0x00039344 File Offset: 0x00037544
	public BossBar_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04000C6F RID: 3183
	public static BossBar_Layout Instance;

	// Token: 0x04000C70 RID: 3184
	public static BossBar_Layout InstanceMobile;

	// Token: 0x04000C71 RID: 3185
	public Panel_Layout BarBacking;

	// Token: 0x04000C72 RID: 3186
	public Panel_Layout BarFrame;

	// Token: 0x04000C73 RID: 3187
	public TransactionButton_Layout BossIcon;

	// Token: 0x04000C74 RID: 3188
	public Panel_Layout ControllerBarBacking;

	// Token: 0x04000C75 RID: 3189
	public Panel_Layout ControllerBarFrame;

	// Token: 0x04000C76 RID: 3190
	public TransactionButton_Layout ControllerBossIcon;

	// Token: 0x04000C77 RID: 3191
	public Texture_Layout LifeCap;

	// Token: 0x04000C78 RID: 3192
	public Texture_Layout LifeFill;

	// Token: 0x04000C79 RID: 3193
	public Texture_Layout ShieldCap;

	// Token: 0x04000C7A RID: 3194
	public Texture_Layout ShieldFill;

	// Token: 0x04000C7B RID: 3195
	public bool RemainingOnly;

	// Token: 0x04000C7C RID: 3196
	public String_Layout HealthAmount;
}
