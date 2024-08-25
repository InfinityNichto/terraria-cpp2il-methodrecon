using System;
using Microsoft.Xna.Framework;
using UnityEngine;

// Token: 0x0200022D RID: 557
public class PageIcons_Layout : LayoutDefinition
{
	// Token: 0x06000CF2 RID: 3314 RVA: 0x0003E840 File Offset: 0x0003CA40
	private void Awake()
	{
	}

	// Token: 0x06000CF3 RID: 3315 RVA: 0x0003E850 File Offset: 0x0003CA50
	public PageIcons_Layout()
	{
		if (39322 == 0)
		{
		}
		base..ctor();
	}

	// Token: 0x04001633 RID: 5683
	public static PageIcons_Layout Instance;

	// Token: 0x04001634 RID: 5684
	public Stretched_Layout Backing1;

	// Token: 0x04001635 RID: 5685
	public Stretched_Layout Backing1Pressed;

	// Token: 0x04001636 RID: 5686
	public Stretched_Layout Backing2;

	// Token: 0x04001637 RID: 5687
	public Stretched_Layout Backing2Pressed;

	// Token: 0x04001638 RID: 5688
	public ItemGrid_Layout LeftItems;

	// Token: 0x04001639 RID: 5689
	public ItemGrid_Layout RightItems;

	// Token: 0x0400163A RID: 5690
	public Stretched_Layout Backing1_Horizontal;

	// Token: 0x0400163B RID: 5691
	public Stretched_Layout Backing1_HorizontalPressed;

	// Token: 0x0400163C RID: 5692
	public Stretched_Layout Backing2_Horizontal;

	// Token: 0x0400163D RID: 5693
	public Stretched_Layout Backing2_HorizontalPressed;

	// Token: 0x0400163E RID: 5694
	public ItemGrid_Layout LeftItems_Horizontal;

	// Token: 0x0400163F RID: 5695
	public ItemGrid_Layout RightItems_Horizontal;

	// Token: 0x04001640 RID: 5696
	public ItemGrid_Layout LeftItems_Controller;

	// Token: 0x04001641 RID: 5697
	public ItemGrid_Layout RightItems_Controller;

	// Token: 0x04001642 RID: 5698
	public ItemGrid_Layout LeftItems_MouseKeyboard;

	// Token: 0x04001643 RID: 5699
	public ItemGrid_Layout RightItems_MouseKeyboard;

	// Token: 0x04001644 RID: 5700
	public Stretched_Layout Backing1_Top;

	// Token: 0x04001645 RID: 5701
	public Stretched_Layout Backing1_TopPressed;

	// Token: 0x04001646 RID: 5702
	public Stretched_Layout Backing2_Top;

	// Token: 0x04001647 RID: 5703
	public Stretched_Layout Backing2_TopPressed;

	// Token: 0x04001648 RID: 5704
	public ItemGrid_Layout LeftItems_Top;

	// Token: 0x04001649 RID: 5705
	public ItemGrid_Layout RightItems_Top;

	// Token: 0x0400164A RID: 5706
	public float ItemScale;

	// Token: 0x0400164B RID: 5707
	public float ItemHighlightScale;

	// Token: 0x0400164C RID: 5708
	public float ScaleSpeed = (float)52429;

	// Token: 0x0400164D RID: 5709
	public TransactionButton_Layout LeftMenuButton;

	// Token: 0x0400164E RID: 5710
	public TransactionButton_Layout LeftMenuButton_Horizontal;

	// Token: 0x0400164F RID: 5711
	public TransactionButton_Layout LeftMenuButton_Top;

	// Token: 0x04001650 RID: 5712
	public AnimationCurve ItemDragPulseScale;

	// Token: 0x04001651 RID: 5713
	public String_Layout LeftPageTitle;

	// Token: 0x04001652 RID: 5714
	public String_Layout LeftPageTitle_Top;

	// Token: 0x04001653 RID: 5715
	public String_Layout LeftPageTitle_Bottom;

	// Token: 0x04001654 RID: 5716
	public String_Layout RightPageTitle;

	// Token: 0x04001655 RID: 5717
	public String_Layout RightPageTitle_Top;

	// Token: 0x04001656 RID: 5718
	public String_Layout RightPageTitle_Bottom;

	// Token: 0x04001657 RID: 5719
	public TransactionButton_Layout LeftOptions;

	// Token: 0x04001658 RID: 5720
	public Panel_Layout LeftOptionsBacking;

	// Token: 0x04001659 RID: 5721
	public Microsoft.Xna.Framework.Vector2 LeftOptionsBackingTLOffset;

	// Token: 0x0400165A RID: 5722
	public Microsoft.Xna.Framework.Vector2 LeftOptionsBackingBROffset;

	// Token: 0x0400165B RID: 5723
	public Panel_Layout OptionsGreyout;

	// Token: 0x0400165C RID: 5724
	public ControlAnchor.ControlId LeftGlobalOptionPositionAnchorControl;

	// Token: 0x0400165D RID: 5725
	public LayoutCalculator.AnchorType LeftGlobalOptionPositionAnchor = LayoutCalculator.AnchorType.TopLeft;

	// Token: 0x0400165E RID: 5726
	public Microsoft.Xna.Framework.Vector2 LeftGlobalOptionPosition;

	// Token: 0x0400165F RID: 5727
	public Microsoft.Xna.Framework.Vector2 LeftGlobalOptionSpacing;

	// Token: 0x04001660 RID: 5728
	public ControlAnchor.ControlId LeftOptionPositionAnchorControl;

	// Token: 0x04001661 RID: 5729
	public LayoutCalculator.AnchorType LeftOptionPositionAnchor = LayoutCalculator.AnchorType.TopLeft;

	// Token: 0x04001662 RID: 5730
	public Microsoft.Xna.Framework.Vector2 LeftOptionPosition;

	// Token: 0x04001663 RID: 5731
	public Microsoft.Xna.Framework.Vector2 LeftOptionSpacing;

	// Token: 0x04001664 RID: 5732
	public Microsoft.Xna.Framework.Vector2 LeftMenuTextOffset;

	// Token: 0x04001665 RID: 5733
	public Microsoft.Xna.Framework.Vector2 LeftTextOffset;

	// Token: 0x04001666 RID: 5734
	public TransactionButton_Layout RightOptions;

	// Token: 0x04001667 RID: 5735
	public Panel_Layout RightOptionsBacking;

	// Token: 0x04001668 RID: 5736
	public Panel_Layout RightOptionsBackingChest;

	// Token: 0x04001669 RID: 5737
	public Panel_Layout RightOptionsBackingShop;

	// Token: 0x0400166A RID: 5738
	public Panel_Layout RightOptionsBackingEquipment;

	// Token: 0x0400166B RID: 5739
	public Microsoft.Xna.Framework.Vector2 RightOptionsBackingTLOffset;

	// Token: 0x0400166C RID: 5740
	public Microsoft.Xna.Framework.Vector2 RightOptionsBackingBROffset;

	// Token: 0x0400166D RID: 5741
	public ControlAnchor.ControlId RightGlobalOptionPositionAnchorControl;

	// Token: 0x0400166E RID: 5742
	public LayoutCalculator.AnchorType RightGlobalOptionPositionAnchor = LayoutCalculator.AnchorType.TopLeft;

	// Token: 0x0400166F RID: 5743
	public Microsoft.Xna.Framework.Vector2 RightGlobalOptionPosition;

	// Token: 0x04001670 RID: 5744
	public Microsoft.Xna.Framework.Vector2 RightGlobalOptionSpacing;

	// Token: 0x04001671 RID: 5745
	public ControlAnchor.ControlId RightOptionPositionAnchorControl;

	// Token: 0x04001672 RID: 5746
	public LayoutCalculator.AnchorType RightOptionPositionAnchor = LayoutCalculator.AnchorType.TopLeft;

	// Token: 0x04001673 RID: 5747
	public Microsoft.Xna.Framework.Vector2 RightOptionPosition;

	// Token: 0x04001674 RID: 5748
	public Microsoft.Xna.Framework.Vector2 RightOptionSpacing;

	// Token: 0x04001675 RID: 5749
	public Microsoft.Xna.Framework.Vector2 RightMenuTextOffset;

	// Token: 0x04001676 RID: 5750
	public Microsoft.Xna.Framework.Vector2 RightTextOffset;

	// Token: 0x04001677 RID: 5751
	public AnimatedTexture_Layout LeftMenuTimer;

	// Token: 0x04001678 RID: 5752
	public AnimatedTexture_Layout RightMenuTimer;
}
