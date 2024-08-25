using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001D4 RID: 468
public class Events_Layout : LayoutDefinition
{
	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000C0A RID: 3082 RVA: 0x000021DB File Offset: 0x000003DB
	public static Events_Layout Instance
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000C0B RID: 3083 RVA: 0x0003BD44 File Offset: 0x00039F44
	private void Awake()
	{
		bool flag = this.name.Contains("Mobile");
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x0003BD64 File Offset: 0x00039F64
	public Events_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x040010B2 RID: 4274
	public static Events_Layout _instance;

	// Token: 0x040010B3 RID: 4275
	public static Events_Layout _instanceMobile;

	// Token: 0x040010B4 RID: 4276
	public Panel_Layout Backing;

	// Token: 0x040010B5 RID: 4277
	public String_Layout InvasionTitle;

	// Token: 0x040010B6 RID: 4278
	public TransactionButton_Layout InvasionIcon;

	// Token: 0x040010B7 RID: 4279
	public Panel_Layout BarBacking;

	// Token: 0x040010B8 RID: 4280
	public Panel_Layout BarFill;

	// Token: 0x040010B9 RID: 4281
	public Panel_Layout InfiniteBarBacking;

	// Token: 0x040010BA RID: 4282
	public Panel_Layout InfiniteBarFill;

	// Token: 0x040010BB RID: 4283
	public String_Layout Waves;

	// Token: 0x040010BC RID: 4284
	public Color MaxWaveColour;

	// Token: 0x040010BD RID: 4285
	public String_Layout Progress;
}
