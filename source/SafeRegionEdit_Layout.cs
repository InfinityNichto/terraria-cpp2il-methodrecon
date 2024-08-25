using System;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000210 RID: 528
public class SafeRegionEdit_Layout : LayoutDefinition
{
	// Token: 0x06000CBE RID: 3262 RVA: 0x0003E290 File Offset: 0x0003C490
	private void Awake()
	{
	}

	// Token: 0x06000CBF RID: 3263 RVA: 0x0003E2A0 File Offset: 0x0003C4A0
	public SafeRegionEdit_Layout()
	{
		if (55050 == 0)
		{
		}
		base..ctor();
	}

	// Token: 0x040013A5 RID: 5029
	public static SafeRegionEdit_Layout Instance;

	// Token: 0x040013A6 RID: 5030
	public float ButtonEdgeInset;

	// Token: 0x040013A7 RID: 5031
	public float MaxEdgeMovementScale;

	// Token: 0x040013A8 RID: 5032
	public float ControllerDragSpeed = (float)55050;

	// Token: 0x040013A9 RID: 5033
	public Color DefaultLinkColor;

	// Token: 0x040013AA RID: 5034
	public Color DraggingLinkColor;

	// Token: 0x040013AB RID: 5035
	public Panel_Layout ScreenBacking;

	// Token: 0x040013AC RID: 5036
	public Panel_Layout ScreenEdge;

	// Token: 0x040013AD RID: 5037
	public Panel_Layout ScreenEdgeTop;

	// Token: 0x040013AE RID: 5038
	public Panel_Layout ScreenEdgeLeft;

	// Token: 0x040013AF RID: 5039
	public Panel_Layout ScreenEdgeRight;

	// Token: 0x040013B0 RID: 5040
	public Panel_Layout ScreenEdgeBottom;

	// Token: 0x040013B1 RID: 5041
	public TransactionButton_Layout Left;

	// Token: 0x040013B2 RID: 5042
	public Panel_Layout LeftLink;

	// Token: 0x040013B3 RID: 5043
	public TransactionButton_Layout Right;

	// Token: 0x040013B4 RID: 5044
	public Panel_Layout RightLink;

	// Token: 0x040013B5 RID: 5045
	public TransactionButton_Layout Top;

	// Token: 0x040013B6 RID: 5046
	public Panel_Layout TopLink;

	// Token: 0x040013B7 RID: 5047
	public TransactionButton_Layout Bottom;

	// Token: 0x040013B8 RID: 5048
	public Panel_Layout BottomLink;

	// Token: 0x040013B9 RID: 5049
	public TransactionButton_Layout Finish;

	// Token: 0x040013BA RID: 5050
	public TransactionButton_Layout Reset;
}
