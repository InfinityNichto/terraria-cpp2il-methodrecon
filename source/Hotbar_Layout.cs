using System;
using Cpp2IlInjected;

// Token: 0x020001D8 RID: 472
public class Hotbar_Layout : LayoutDefinition
{
	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06000C12 RID: 3090 RVA: 0x000021DB File Offset: 0x000003DB
	public static Hotbar_Layout Instance
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000C13 RID: 3091 RVA: 0x0003BE30 File Offset: 0x0003A030
	private void Awake()
	{
		bool flag = this.name == "Hotbar4Page";
	}

	// Token: 0x06000C14 RID: 3092 RVA: 0x0003BE50 File Offset: 0x0003A050
	public Hotbar_Layout()
	{
		if (52429 == 0)
		{
		}
		base..ctor();
	}

	// Token: 0x040010F5 RID: 4341
	public static Hotbar_Layout InstanceNormal;

	// Token: 0x040010F6 RID: 4342
	public static Hotbar_Layout Instance4Page;

	// Token: 0x040010F7 RID: 4343
	public float SelectedScale;

	// Token: 0x040010F8 RID: 4344
	public float NormalScale;

	// Token: 0x040010F9 RID: 4345
	public float ScaleSpeed = (float)52429;

	// Token: 0x040010FA RID: 4346
	public String_Layout Title;

	// Token: 0x040010FB RID: 4347
	public String_Layout HorizontalTitle;

	// Token: 0x040010FC RID: 4348
	public ItemGrid_Layout HotbarGrid;

	// Token: 0x040010FD RID: 4349
	public ItemGrid_Layout HorizontalHotbarGrid;
}
