using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000239 RID: 569
public class RubbleMakerUI_Layout : LayoutDefinition
{
	// Token: 0x1700016D RID: 365
	// (get) Token: 0x06000D0E RID: 3342 RVA: 0x000021DB File Offset: 0x000003DB
	public static RubbleMakerUI_Layout Instance
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000D0F RID: 3343 RVA: 0x0003EB18 File Offset: 0x0003CD18
	private void Awake()
	{
		bool flag = this.name == "RubbleMakerUI4Page";
	}

	// Token: 0x06000D10 RID: 3344 RVA: 0x0003EB38 File Offset: 0x0003CD38
	public RubbleMakerUI_Layout()
	{
		if (!true)
		{
		}
		this.DisabledBackingColor = 1;
		base..ctor();
	}

	// Token: 0x04001751 RID: 5969
	public static RubbleMakerUI_Layout InstanceNormal;

	// Token: 0x04001752 RID: 5970
	public static RubbleMakerUI_Layout Instance4Page;

	// Token: 0x04001753 RID: 5971
	public Panel_Layout Backing;

	// Token: 0x04001754 RID: 5972
	public ItemGrid_Layout MaterialOptions;

	// Token: 0x04001755 RID: 5973
	public ItemGrid_Layout RubbleOptions;

	// Token: 0x04001756 RID: 5974
	public Panel_Layout MenuDivider;

	// Token: 0x04001757 RID: 5975
	public bool DrawEmptySlots = true;

	// Token: 0x04001758 RID: 5976
	public Texture_Layout DisabledBacking;

	// Token: 0x04001759 RID: 5977
	public Color DisabledBackingColor;

	// Token: 0x0400175A RID: 5978
	public Texture_Layout DisabledBackingIcon;

	// Token: 0x0400175B RID: 5979
	public Color DisabledBackingIconColor;

	// Token: 0x0400175C RID: 5980
	public Vector2 TouchPanelOffset;

	// Token: 0x0400175D RID: 5981
	public TransactionButton_Layout SizeToggle;

	// Token: 0x0400175E RID: 5982
	public TransactionButton_Layout MaterialToggle;

	// Token: 0x0400175F RID: 5983
	public float MaterialScale;

	// Token: 0x04001760 RID: 5984
	public float HighlightedMaterialScale;

	// Token: 0x04001761 RID: 5985
	public float RubbleScale;

	// Token: 0x04001762 RID: 5986
	public float HighlightedRubbleScale;

	// Token: 0x04001763 RID: 5987
	public Vector2 SmallRubblePreviewScaleOffset;

	// Token: 0x04001764 RID: 5988
	public float SmallRubblePreviewScale;

	// Token: 0x04001765 RID: 5989
	public Vector2 MediumRubblePreviewScaleOffset;

	// Token: 0x04001766 RID: 5990
	public float MediumRubblePreviewScale;

	// Token: 0x04001767 RID: 5991
	public Vector2 LargeRubblePreviewScaleOffset;

	// Token: 0x04001768 RID: 5992
	public float LargeRubblePreviewScale;

	// Token: 0x04001769 RID: 5993
	public Panel_Layout MaterialBacking;

	// Token: 0x0400176A RID: 5994
	public Vector2 MaterialBackingTLOffset;

	// Token: 0x0400176B RID: 5995
	public Vector2 MaterialBackingBROffset;

	// Token: 0x0400176C RID: 5996
	public FadeString_Layout TooltipDisplay;
}
