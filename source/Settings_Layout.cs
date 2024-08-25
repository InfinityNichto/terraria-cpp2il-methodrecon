using System;
using Cpp2IlInjected;

// Token: 0x02000240 RID: 576
public class Settings_Layout : LayoutDefinition
{
	// Token: 0x1700016E RID: 366
	// (get) Token: 0x06000D27 RID: 3367 RVA: 0x000021DB File Offset: 0x000003DB
	public static Settings_Layout Instance
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000D28 RID: 3368 RVA: 0x0003EFF0 File Offset: 0x0003D1F0
	private void Awake()
	{
		bool flag = this.name == "Settings4Page";
	}

	// Token: 0x06000D29 RID: 3369 RVA: 0x0003F010 File Offset: 0x0003D210
	public Settings_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x040017DD RID: 6109
	public static Settings_Layout InstanceNormal;

	// Token: 0x040017DE RID: 6110
	public static Settings_Layout Instance4Page;

	// Token: 0x040017DF RID: 6111
	public TransactionButton_Layout SettingsButton;

	// Token: 0x040017E0 RID: 6112
	public TransactionButton_Layout SettingsButton_Horizontal;

	// Token: 0x040017E1 RID: 6113
	public TransactionButton_Layout SettingsButton_Top;

	// Token: 0x040017E2 RID: 6114
	public TransactionButton_Layout JMSettingsButton;

	// Token: 0x040017E3 RID: 6115
	public TransactionButton_Layout BestiaryButton;

	// Token: 0x040017E4 RID: 6116
	public TransactionButton_Layout MapButton;

	// Token: 0x040017E5 RID: 6117
	public TransactionButton_Layout HousingMenuButton;

	// Token: 0x040017E6 RID: 6118
	public TransactionButton_Layout ChatButton;

	// Token: 0x040017E7 RID: 6119
	public TransactionButton_Layout EmotesButton;

	// Token: 0x040017E8 RID: 6120
	public TransactionButton_Layout ReturnTouch_HUD;

	// Token: 0x040017E9 RID: 6121
	public TransactionButton_Layout ReturnTouch_Menu;

	// Token: 0x040017EA RID: 6122
	public Panel_Layout ReturnTouch_Backing;

	// Token: 0x040017EB RID: 6123
	public Panel_Layout ReturnTouch_MenuDivider;

	// Token: 0x040017EC RID: 6124
	public String_Layout ReturnTouch_Prompt;

	// Token: 0x040017ED RID: 6125
	public TransactionButton_Layout ReturnTouch_Accept;

	// Token: 0x040017EE RID: 6126
	public TransactionButton_Layout ReturnTouch_Cancel;
}
