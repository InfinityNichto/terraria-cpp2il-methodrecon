using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x02000253 RID: 595
public class WireUI_Layout : LayoutDefinition
{
	// Token: 0x17000173 RID: 371
	// (get) Token: 0x06000D53 RID: 3411 RVA: 0x000021DB File Offset: 0x000003DB
	public static WireUI_Layout Instance
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000D54 RID: 3412 RVA: 0x0003FB64 File Offset: 0x0003DD64
	private void Awake()
	{
		bool flag = this.name == "WiringUI4Page";
	}

	// Token: 0x06000D55 RID: 3413 RVA: 0x0003FB84 File Offset: 0x0003DD84
	public WireUI_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001894 RID: 6292
	public static WireUI_Layout InstanceNormal;

	// Token: 0x04001895 RID: 6293
	public static WireUI_Layout Instance4Page;

	// Token: 0x04001896 RID: 6294
	public Vector2 BackingTLOffset;

	// Token: 0x04001897 RID: 6295
	public Vector2 BackingBROffset;

	// Token: 0x04001898 RID: 6296
	public Panel_Layout Backing;

	// Token: 0x04001899 RID: 6297
	public Panel_Layout CutterBacking;

	// Token: 0x0400189A RID: 6298
	public ItemGrid_Layout ToolOptions;

	// Token: 0x0400189B RID: 6299
	public Vector2 CursorPanelOffset = 1;

	// Token: 0x0400189C RID: 6300
	public Vector2 TouchPanelOffset = 1;

	// Token: 0x0400189D RID: 6301
	public TransactionButton_Layout PlacementBacking;

	// Token: 0x0400189E RID: 6302
	public TransactionButton_Layout RemovalBacking;

	// Token: 0x0400189F RID: 6303
	public FadeString_Layout TooltipDisplay;
}
