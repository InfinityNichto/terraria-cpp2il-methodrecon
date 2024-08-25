using System;
using UnityEngine;

// Token: 0x02000254 RID: 596
public class WorldOperationProgress_Layout : LayoutDefinition
{
	// Token: 0x06000D56 RID: 3414 RVA: 0x0003FBA8 File Offset: 0x0003DDA8
	private void Awake()
	{
	}

	// Token: 0x06000D57 RID: 3415 RVA: 0x0003FBB8 File Offset: 0x0003DDB8
	public WorldOperationProgress_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x040018A0 RID: 6304
	public static WorldOperationProgress_Layout Instance;

	// Token: 0x040018A1 RID: 6305
	public bool Enabled = true;

	// Token: 0x040018A2 RID: 6306
	public bool FullHMStatus;

	// Token: 0x040018A3 RID: 6307
	public Panel_Layout Backing;

	// Token: 0x040018A4 RID: 6308
	public Button_Layout ProgressIcon;

	// Token: 0x040018A5 RID: 6309
	public AnimationCurve HMIconScale;

	// Token: 0x040018A6 RID: 6310
	public AnimationCurve HMIconAlpha;

	// Token: 0x040018A7 RID: 6311
	public TransactionButton_Layout HMConversionIcon;
}
