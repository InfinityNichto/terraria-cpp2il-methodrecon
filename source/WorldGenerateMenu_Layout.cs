using System;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000223 RID: 547
public class WorldGenerateMenu_Layout : LayoutDefinition
{
	// Token: 0x06000CD9 RID: 3289 RVA: 0x0003E5AC File Offset: 0x0003C7AC
	private void Awake()
	{
	}

	// Token: 0x06000CDA RID: 3290 RVA: 0x0003E5BC File Offset: 0x0003C7BC
	public WorldGenerateMenu_Layout()
	{
		if (!true)
		{
		}
		this.FillingColorCorrupt = 1;
		this.FillingColorCrimson = 1;
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001551 RID: 5457
	public static WorldGenerateMenu_Layout Instance;

	// Token: 0x04001552 RID: 5458
	public String_Layout Status;

	// Token: 0x04001553 RID: 5459
	public ProgressBar_Layout Progress;

	// Token: 0x04001554 RID: 5460
	public ProgressBar_Layout StageProgress;

	// Token: 0x04001555 RID: 5461
	public Texture_Layout BackingCorrupt;

	// Token: 0x04001556 RID: 5462
	public Texture_Layout BackingCrimson;

	// Token: 0x04001557 RID: 5463
	public Color FillingColorCorrupt;

	// Token: 0x04001558 RID: 5464
	public Color FillingColorCrimson;

	// Token: 0x04001559 RID: 5465
	public String_Layout GameTip;
}
