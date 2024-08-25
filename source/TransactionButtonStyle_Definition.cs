using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NaughtyAttributes;

// Token: 0x020001C1 RID: 449
[Serializable]
public class TransactionButtonStyle_Definition
{
	// Token: 0x06000BDA RID: 3034 RVA: 0x0003AFC8 File Offset: 0x000391C8
	public void Apply(TransactionButton_Layout layout)
	{
		float scale = this.Scale;
		Texture_Layout backingDisabled = layout.BackingDisabled;
		layout.Scale = scale;
		Color color = this.Color;
		layout.Color = color;
		bool useCirclePickingRegion = this.UseCirclePickingRegion;
		layout.UseCirclePickingRegion = useCirclePickingRegion;
		string textureId = this.BackingDisabled.TextureId;
		backingDisabled.TextureId = textureId;
		Texture_Layout backingNormal = this.BackingNormal;
		Texture_Layout backingNormal2 = layout.BackingNormal;
		string textureId2 = backingNormal.TextureId;
		backingNormal2.TextureId = textureId2;
		Texture_Layout backingPressed = this.BackingPressed;
		Texture_Layout backingPressed2 = layout.BackingPressed;
		string textureId3 = backingPressed.TextureId;
		backingPressed2.TextureId = textureId3;
		Texture_Layout backingPressedHighlight = this.BackingPressedHighlight;
		Texture_Layout backingPressedHighlight2 = layout.BackingPressedHighlight;
		string textureId4 = backingPressedHighlight.TextureId;
		backingPressedHighlight2.TextureId = textureId4;
		Color backingPressedHighlightColour = this.BackingPressedHighlightColour;
		Texture_Layout overBackingHighlight = layout.OverBackingHighlight;
		layout.BackingPressedHighlightColour = backingPressedHighlightColour;
		string textureId5 = this.OverBackingHighlight.TextureId;
		overBackingHighlight.TextureId = textureId5;
		bool drawLabel = this.DrawLabel;
		String_Layout label = layout.Label;
		layout.DrawLabel = drawLabel;
		bool drawIcon = this.DrawIcon;
		layout.DrawIcon = drawIcon;
		bool drawItem = this.DrawItem;
		layout.DrawItem = drawItem;
		bool drawControlsIconOnFocus = this.DrawControlsIconOnFocus;
		layout.DrawControlsIconOnFocus = drawControlsIconOnFocus;
		String_Layout label2 = this.Label;
		ControlAnchor.ControlId anchorControl = label2.AnchorControl;
		label.AnchorControl = anchorControl;
		Vector2 location = label2.Location;
		label.Location = location;
		Color color2 = label2.Color;
		label.Color = color2;
		String_Layout.FontType renderFont = label2.RenderFont;
		label.RenderFont = renderFont;
		bool multiLineUseAlignment = label2.MultiLineUseAlignment;
		label.MultiLineUseAlignment = multiLineUseAlignment;
		float multilineScale = label2.MultilineScale;
		label.MultilineScale = multilineScale;
		Color disabledLabelColour = this.DisabledLabelColour;
		Color pressedLabelColour = this.PressedLabelColour;
		bool disableIconResize = this.DisableIconResize;
		layout.DisableIconResize = disableIconResize;
		bool forceIconScale = this.ForceIconScale;
		layout.ForceIconScale = forceIconScale;
		float forcedIconScale = this.ForcedIconScale;
		layout.ForcedIconScale = forcedIconScale;
		bool disableIconOnFocus = this.DisableIconOnFocus;
		layout.DisableIconOnFocus = disableIconOnFocus;
		bool disableControlIconResize = this.DisableControlIconResize;
		layout.DisableControlIconResize = disableControlIconResize;
		Vector2 controlIconOffset = this.ControlIconOffset;
		bool forceControlIconScale = this.ForceControlIconScale;
		layout.ForceControlIconScale = forceControlIconScale;
		float forcedControlIconScale = this.ForcedControlIconScale;
		layout.ForcedControlIconScale = forcedControlIconScale;
		bool disableItemResize = this.DisableItemResize;
		layout.DisableItemResize = disableItemResize;
		bool forceItemScale = this.ForceItemScale;
		layout.ForceItemScale = forceItemScale;
		float forcedItemScale = this.ForcedItemScale;
		layout.ForcedItemScale = forcedItemScale;
		Vector2 itemOffset = this.ItemOffset;
		Texture_Layout defaultItemTexture = this.DefaultItemTexture;
		Texture_Layout defaultItemTexture2 = layout.DefaultItemTexture;
		string textureId6 = defaultItemTexture.TextureId;
		defaultItemTexture2.TextureId = textureId6;
		Color itemColour = this.ItemColour;
		Texture_Layout highlightBackingDisabled = layout.HighlightBackingDisabled;
		layout.ItemColour = itemColour;
		Color disabledItemColour = this.DisabledItemColour;
		layout.DisabledItemColour = disabledItemColour;
		Color pressedItemColour = this.PressedItemColour;
		layout.PressedItemColour = pressedItemColour;
		bool flag = this.overloadSize;
		layout.overloadSize = flag;
		Vector2 vector = this.overloadedSize;
		layout.overloadedSize = vector;
		string textureId7 = this.HighlightBackingDisabled.TextureId;
		highlightBackingDisabled.TextureId = textureId7;
		Color highlightDisabledColour = this.HighlightDisabledColour;
		Texture_Layout highlightBackingNormal = layout.HighlightBackingNormal;
		layout.HighlightDisabledColour = highlightDisabledColour;
		string textureId8 = this.HighlightBackingNormal.TextureId;
		highlightBackingNormal.TextureId = textureId8;
		Color highlightColour = this.HighlightColour;
		Texture_Layout highlightBackingPressed = layout.HighlightBackingPressed;
		layout.HighlightColour = highlightColour;
		string textureId9 = this.HighlightBackingPressed.TextureId;
		highlightBackingPressed.TextureId = textureId9;
		Color highlightPressedColour = this.HighlightPressedColour;
		layout.HighlightPressedColour = highlightPressedColour;
		bool drawDivider = this.DrawDivider;
		Panel_Layout divider = layout.Divider;
		layout.DrawDivider = drawDivider;
		Panel_Layout divider2 = this.Divider;
		divider.Copy(divider2);
		bool useDividerHighlightColours = this.UseDividerHighlightColours;
		layout.UseDividerHighlightColours = useDividerHighlightColours;
		Texture_Layout borderDisabled = this.BorderDisabled;
		Texture_Layout borderDisabled2 = layout.BorderDisabled;
		string textureId10 = borderDisabled.TextureId;
		borderDisabled2.TextureId = textureId10;
		Color disabledBorderColour = this.DisabledBorderColour;
		Texture_Layout borderNormal = layout.BorderNormal;
		layout.DisabledBorderColour = disabledBorderColour;
		string textureId11 = this.BorderNormal.TextureId;
		borderNormal.TextureId = textureId11;
		Color normalBorderColour = this.NormalBorderColour;
		Texture_Layout borderPressed = layout.BorderPressed;
		layout.NormalBorderColour = normalBorderColour;
		string textureId12 = this.BorderPressed.TextureId;
		borderPressed.TextureId = textureId12;
		Color pressedBorderColour = this.PressedBorderColour;
		layout.PressedBorderColour = pressedBorderColour;
	}

	// Token: 0x06000BDB RID: 3035 RVA: 0x0003B3F0 File Offset: 0x000395F0
	public void Copy(TransactionButton_Layout layout)
	{
		float scale = layout.Scale;
		Texture_Layout backingDisabled = this.BackingDisabled;
		this.Scale = scale;
		Color color = layout.Color;
		this.Color = color;
		bool useCirclePickingRegion = layout.UseCirclePickingRegion;
		this.UseCirclePickingRegion = useCirclePickingRegion;
		string textureId = layout.BackingDisabled.TextureId;
		backingDisabled.TextureId = textureId;
		Texture_Layout backingNormal = layout.BackingNormal;
		Texture_Layout backingNormal2 = this.BackingNormal;
		string textureId2 = backingNormal.TextureId;
		backingNormal2.TextureId = textureId2;
		Texture_Layout backingPressed = layout.BackingPressed;
		Texture_Layout backingPressed2 = this.BackingPressed;
		string textureId3 = backingPressed.TextureId;
		backingPressed2.TextureId = textureId3;
		Texture_Layout backingPressedHighlight = layout.BackingPressedHighlight;
		Texture_Layout backingPressedHighlight2 = this.BackingPressedHighlight;
		string textureId4 = backingPressedHighlight.TextureId;
		backingPressedHighlight2.TextureId = textureId4;
		Color backingPressedHighlightColour = layout.BackingPressedHighlightColour;
		Texture_Layout overBackingHighlight = this.OverBackingHighlight;
		this.BackingPressedHighlightColour = backingPressedHighlightColour;
		string textureId5 = layout.OverBackingHighlight.TextureId;
		overBackingHighlight.TextureId = textureId5;
		bool drawLabel = layout.DrawLabel;
		this.DrawLabel = drawLabel;
		bool drawIcon = layout.DrawIcon;
		this.DrawIcon = drawIcon;
		bool drawItem = layout.DrawItem;
		this.DrawItem = drawItem;
		bool drawControlsIconOnFocus = layout.DrawControlsIconOnFocus;
		this.DrawControlsIconOnFocus = drawControlsIconOnFocus;
		String_Layout label = layout.Label;
		ControlAnchor.ControlId anchorControl = label.AnchorControl;
		Vector2 location = label.Location;
		Color color2 = label.Color;
		String_Layout.FontType renderFont = label.RenderFont;
		bool multiLineUseAlignment = label.MultiLineUseAlignment;
		float multilineScale = label.MultilineScale;
		Texture_Layout defaultItemTexture = this.DefaultItemTexture;
		this.DisabledLabelColour = multilineScale;
		this.PressedLabelColour = multilineScale;
		bool disableIconResize = layout.DisableIconResize;
		this.DisableIconResize = disableIconResize;
		bool forceIconScale = layout.ForceIconScale;
		this.ForceIconScale = forceIconScale;
		float forcedIconScale = layout.ForcedIconScale;
		this.ForcedIconScale = forcedIconScale;
		bool disableIconOnFocus = layout.DisableIconOnFocus;
		this.DisableIconOnFocus = disableIconOnFocus;
		bool disableControlIconResize = layout.DisableControlIconResize;
		this.DisableControlIconResize = disableControlIconResize;
		this.ControlIconOffset = disableControlIconResize;
		bool forceControlIconScale = layout.ForceControlIconScale;
		this.ForceControlIconScale = forceControlIconScale;
		float forcedControlIconScale = layout.ForcedControlIconScale;
		this.ForcedControlIconScale = forcedControlIconScale;
		bool disableItemResize = layout.DisableItemResize;
		this.DisableItemResize = disableItemResize;
		bool forceItemScale = layout.ForceItemScale;
		this.ForceItemScale = forceItemScale;
		float forcedItemScale = layout.ForcedItemScale;
		this.ForcedItemScale = forcedItemScale;
		this.ItemOffset = forcedItemScale;
		string textureId6 = layout.DefaultItemTexture.TextureId;
		defaultItemTexture.TextureId = textureId6;
		Color itemColour = layout.ItemColour;
		Texture_Layout highlightBackingDisabled = this.HighlightBackingDisabled;
		this.ItemColour = itemColour;
		Color disabledItemColour = layout.DisabledItemColour;
		this.DisabledItemColour = disabledItemColour;
		Color pressedItemColour = layout.PressedItemColour;
		this.PressedItemColour = pressedItemColour;
		bool flag = layout.overloadSize;
		this.overloadSize = flag;
		Vector2 vector = layout.overloadedSize;
		this.overloadedSize = vector;
		string textureId7 = layout.HighlightBackingDisabled.TextureId;
		highlightBackingDisabled.TextureId = textureId7;
		Color highlightDisabledColour = layout.HighlightDisabledColour;
		Texture_Layout highlightBackingNormal = this.HighlightBackingNormal;
		this.HighlightDisabledColour = highlightDisabledColour;
		string textureId8 = layout.HighlightBackingNormal.TextureId;
		highlightBackingNormal.TextureId = textureId8;
		Color highlightColour = layout.HighlightColour;
		Texture_Layout highlightBackingPressed = this.HighlightBackingPressed;
		this.HighlightColour = highlightColour;
		string textureId9 = layout.HighlightBackingPressed.TextureId;
		highlightBackingPressed.TextureId = textureId9;
		Color highlightPressedColour = layout.HighlightPressedColour;
		this.HighlightPressedColour = highlightPressedColour;
		bool drawDivider = layout.DrawDivider;
		this.DrawDivider = drawDivider;
		Panel_Layout divider = layout.Divider;
		bool useDividerHighlightColours = layout.UseDividerHighlightColours;
		this.UseDividerHighlightColours = useDividerHighlightColours;
		Texture_Layout borderDisabled = layout.BorderDisabled;
		Texture_Layout borderDisabled2 = this.BorderDisabled;
		string textureId10 = borderDisabled.TextureId;
		borderDisabled2.TextureId = textureId10;
		Color disabledBorderColour = layout.DisabledBorderColour;
		Texture_Layout borderNormal = this.BorderNormal;
		this.DisabledBorderColour = disabledBorderColour;
		string textureId11 = layout.BorderNormal.TextureId;
		borderNormal.TextureId = textureId11;
		Color normalBorderColour = layout.NormalBorderColour;
		Texture_Layout borderPressed = this.BorderPressed;
		this.NormalBorderColour = normalBorderColour;
		string textureId12 = layout.BorderPressed.TextureId;
		borderPressed.TextureId = textureId12;
		Color pressedBorderColour = layout.PressedBorderColour;
		this.PressedBorderColour = pressedBorderColour;
	}

	// Token: 0x06000BDC RID: 3036 RVA: 0x0003B7C4 File Offset: 0x000399C4
	public TransactionButtonStyle_Definition()
	{
		int num = 16256;
		this.Scale = (float)num;
		if (num == 0)
		{
		}
		long num2 = 16256L;
		this.Color = num;
		this.HighlightPressedColour = num2;
		int num3 = 1;
		this.DrawItem = num3 != 0;
		this.DisabledLabelColour = num3;
		if (true)
		{
			return;
		}
		int num4 = 16256;
		this.ForcedIconScale = (float)num4;
		if (true)
		{
			return;
		}
		int num5 = 16256;
		this.ForcedControlIconScale = (float)num5;
		this.ForcedItemScale = (float)num5;
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04000EEF RID: 3823
	[BoxGroup("Style", -1, null, null)]
	public string StyleId;

	// Token: 0x04000EF0 RID: 3824
	[BoxGroup("Normal", -1, null, null)]
	public float Scale;

	// Token: 0x04000EF1 RID: 3825
	[BoxGroup("Picking", -1, "Style", null)]
	public Vector2 PickBorder;

	// Token: 0x04000EF2 RID: 3826
	[BoxGroup("Picking", -1, null, null)]
	public Vector2 PickOffset;

	// Token: 0x04000EF3 RID: 3827
	[BoxGroup("Normal", -1, null, null)]
	public Color Color;

	// Token: 0x04000EF4 RID: 3828
	[BoxGroup("Picking", -1, null, null)]
	public bool UseCirclePickingRegion;

	// Token: 0x04000EF5 RID: 3829
	[BoxGroup("Disabled", -1, null, null)]
	public Color DisabledColour;

	// Token: 0x04000EF6 RID: 3830
	[BoxGroup("Pressed", -1, null, null)]
	public Color PressedColour;

	// Token: 0x04000EF7 RID: 3831
	[ShowIf("DrawIcon")]
	[BoxGroup("Normal", -1, null, null)]
	public Color IconColour;

	// Token: 0x04000EF8 RID: 3832
	[BoxGroup("Disabled", -1, null, null)]
	[ShowIf("DrawIcon")]
	public Color DisabledIconColour;

	// Token: 0x04000EF9 RID: 3833
	[BoxGroup("Pressed", -1, null, null)]
	[ShowIf("DrawIcon")]
	public Color PressedIconColour;

	// Token: 0x04000EFA RID: 3834
	[BoxGroup("Highlight", -1, "Style", null)]
	public Color LabelHighlightTint;

	// Token: 0x04000EFB RID: 3835
	[BoxGroup("Setup", -1, null, null)]
	public float ScaleSpeed;

	// Token: 0x04000EFC RID: 3836
	[BoxGroup("Disabled", -1, null, null)]
	public float DisabledScale;

	// Token: 0x04000EFD RID: 3837
	[BoxGroup("Pressed", -1, null, null)]
	public float PressedScale;

	// Token: 0x04000EFE RID: 3838
	[BoxGroup("Icon", -1, null, null)]
	[ShowIf("DrawIcon")]
	public int IconMaxSizeInset;

	// Token: 0x04000EFF RID: 3839
	[BoxGroup("Disabled", -1, null, null)]
	public Texture_Layout BackingDisabled;

	// Token: 0x04000F00 RID: 3840
	[BoxGroup("Normal", -1, null, null)]
	public Texture_Layout BackingNormal;

	// Token: 0x04000F01 RID: 3841
	[BoxGroup("Pressed", -1, null, null)]
	public Texture_Layout BackingPressed;

	// Token: 0x04000F02 RID: 3842
	[BoxGroup("Pressed", -1, null, null)]
	public Texture_Layout BackingPressedHighlight;

	// Token: 0x04000F03 RID: 3843
	[BoxGroup("Pressed", -1, null, null)]
	[ShowIf("DrawIcon")]
	public Color BackingPressedHighlightColour;

	// Token: 0x04000F04 RID: 3844
	[BoxGroup("Highlight", -1, null, null)]
	public Texture_Layout OverBackingHighlight;

	// Token: 0x04000F05 RID: 3845
	[BoxGroup("Highlight", -1, null, null)]
	public Texture_Layout HighlightBackingDisabled;

	// Token: 0x04000F06 RID: 3846
	[BoxGroup("Highlight", -1, null, null)]
	public Color HighlightDisabledColour;

	// Token: 0x04000F07 RID: 3847
	[BoxGroup("Highlight", -1, null, null)]
	public Texture_Layout HighlightBackingNormal;

	// Token: 0x04000F08 RID: 3848
	[BoxGroup("Highlight", -1, null, null)]
	public Color HighlightColour;

	// Token: 0x04000F09 RID: 3849
	[BoxGroup("Highlight", -1, null, null)]
	public Texture_Layout HighlightBackingPressed;

	// Token: 0x04000F0A RID: 3850
	[BoxGroup("Highlight", -1, null, null)]
	public Color HighlightPressedColour;

	// Token: 0x04000F0B RID: 3851
	[BoxGroup("Setup", -1, "Style", null)]
	public bool DrawLabel;

	// Token: 0x04000F0C RID: 3852
	[BoxGroup("Setup", -1, null, null)]
	public bool DrawIcon;

	// Token: 0x04000F0D RID: 3853
	[BoxGroup("Setup", -1, null, null)]
	public bool DrawItem;

	// Token: 0x04000F0E RID: 3854
	[BoxGroup("Setup", -1, null, null)]
	public bool DrawControlsIconOnFocus;

	// Token: 0x04000F0F RID: 3855
	[ShowIf("DrawLabel")]
	[BoxGroup("Label", -1, "Style", null)]
	public String_Layout Label;

	// Token: 0x04000F10 RID: 3856
	[ShowIf("DrawLabel")]
	[BoxGroup("Label", -1, null, null)]
	public Color DisabledLabelColour;

	// Token: 0x04000F11 RID: 3857
	[ShowIf("DrawLabel")]
	[BoxGroup("Label", -1, null, null)]
	public Color PressedLabelColour;

	// Token: 0x04000F12 RID: 3858
	[ShowIf("DrawIcon")]
	[BoxGroup("Icon", -1, "Style", null)]
	public bool DisableIconResize;

	// Token: 0x04000F13 RID: 3859
	[BoxGroup("Icon", -1, null, null)]
	[ShowIf("DrawIcon")]
	public Vector2 IconOffset;

	// Token: 0x04000F14 RID: 3860
	[ShowIf("DrawIcon")]
	[BoxGroup("Icon", -1, null, null)]
	public bool ForceIconScale;

	// Token: 0x04000F15 RID: 3861
	[ShowIf("DrawIcon")]
	[BoxGroup("Icon", -1, null, null)]
	public float ForcedIconScale;

	// Token: 0x04000F16 RID: 3862
	[BoxGroup("Controls", -1, "Style", null)]
	[ShowIf("DrawControlsIconOnFocus")]
	public bool DisableIconOnFocus;

	// Token: 0x04000F17 RID: 3863
	[BoxGroup("Controls", -1, null, null)]
	[ShowIf("DrawControlsIconOnFocus")]
	public bool DisableControlIconResize;

	// Token: 0x04000F18 RID: 3864
	[BoxGroup("Controls", -1, null, null)]
	[ShowIf("DrawControlsIconOnFocus")]
	public Vector2 ControlIconOffset;

	// Token: 0x04000F19 RID: 3865
	[BoxGroup("Controls", -1, null, null)]
	[ShowIf("DrawControlsIconOnFocus")]
	public bool ForceControlIconScale;

	// Token: 0x04000F1A RID: 3866
	[BoxGroup("Controls", -1, null, null)]
	[ShowIf("DrawControlsIconOnFocus")]
	public float ForcedControlIconScale;

	// Token: 0x04000F1B RID: 3867
	[BoxGroup("Item", -1, "Style", null)]
	[ShowIf("DrawItem")]
	public bool DisableItemResize;

	// Token: 0x04000F1C RID: 3868
	[BoxGroup("Item", -1, null, null)]
	[ShowIf("DrawItem")]
	public bool ForceItemScale;

	// Token: 0x04000F1D RID: 3869
	[BoxGroup("Item", -1, null, null)]
	[ShowIf("DrawItem")]
	public float ForcedItemScale;

	// Token: 0x04000F1E RID: 3870
	[BoxGroup("Item", -1, null, null)]
	[ShowIf("DrawItem")]
	public Vector2 ItemOffset;

	// Token: 0x04000F1F RID: 3871
	[BoxGroup("Item", -1, null, null)]
	[ShowIf("DrawItem")]
	public Texture_Layout DefaultItemTexture;

	// Token: 0x04000F20 RID: 3872
	[BoxGroup("Normal", -1, "Style", null)]
	[ShowIf("DrawItem")]
	public Color ItemColour;

	// Token: 0x04000F21 RID: 3873
	[BoxGroup("Disabled", -1, "Style", null)]
	[ShowIf("DrawItem")]
	public Color DisabledItemColour;

	// Token: 0x04000F22 RID: 3874
	[BoxGroup("Pressed", -1, "Style", null)]
	[ShowIf("DrawItem")]
	public Color PressedItemColour;

	// Token: 0x04000F23 RID: 3875
	[BoxGroup("Setup", -1, null, null)]
	public bool overloadSize;

	// Token: 0x04000F24 RID: 3876
	[ShowIf("overloadSize")]
	[BoxGroup("Setup", -1, null, null)]
	public Vector2 overloadedSize;

	// Token: 0x04000F25 RID: 3877
	[BoxGroup("Setup", -1, null, null)]
	public bool DrawDivider;

	// Token: 0x04000F26 RID: 3878
	[BoxGroup("Divider", -1, "Style", null)]
	[ShowIf("DrawDivider")]
	public Panel_Layout Divider;

	// Token: 0x04000F27 RID: 3879
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	public bool UseDividerHighlightColours;

	// Token: 0x04000F28 RID: 3880
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	public Color DividerHighlightColour;

	// Token: 0x04000F29 RID: 3881
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	public Color DividerHighlightBorderColour;

	// Token: 0x04000F2A RID: 3882
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	public Color DividerPressedColour;

	// Token: 0x04000F2B RID: 3883
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	public Color DividerPressedBorderColour;

	// Token: 0x04000F2C RID: 3884
	[ShowIf("DrawDivider")]
	[BoxGroup("Divider", -1, null, null)]
	public Color DividerPressedHighlightColour;

	// Token: 0x04000F2D RID: 3885
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	public Color DividerPressedHighlightBorderColour;

	// Token: 0x04000F2E RID: 3886
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	public Color DividerDisabledColour;

	// Token: 0x04000F2F RID: 3887
	[ShowIf("DrawDivider")]
	[BoxGroup("Divider", -1, null, null)]
	public Color DividerDisabledBorderColour;

	// Token: 0x04000F30 RID: 3888
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	public Color DividerDisabledHighlightColour;

	// Token: 0x04000F31 RID: 3889
	[ShowIf("DrawDivider")]
	[BoxGroup("Divider", -1, null, null)]
	public Color DividerDisabledHighlightBorderColour;

	// Token: 0x04000F32 RID: 3890
	[BoxGroup("Disabled", -1, null, null)]
	public Texture_Layout BorderDisabled;

	// Token: 0x04000F33 RID: 3891
	[BoxGroup("Disabled", -1, null, null)]
	public Color DisabledBorderColour;

	// Token: 0x04000F34 RID: 3892
	[BoxGroup("Normal", -1, null, null)]
	public Texture_Layout BorderNormal;

	// Token: 0x04000F35 RID: 3893
	[BoxGroup("Normal", -1, null, null)]
	public Color NormalBorderColour;

	// Token: 0x04000F36 RID: 3894
	[BoxGroup("Pressed", -1, null, null)]
	public Texture_Layout BorderPressed;

	// Token: 0x04000F37 RID: 3895
	[BoxGroup("Pressed", -1, null, null)]
	public Color PressedBorderColour;
}
