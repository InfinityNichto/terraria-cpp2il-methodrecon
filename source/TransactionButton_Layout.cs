using System;
using Controller;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NaughtyAttributes;

// Token: 0x020001C4 RID: 452
[Serializable]
public class TransactionButton_Layout : QuickActionButton_Layout
{
	// Token: 0x06000BE7 RID: 3047 RVA: 0x0003B964 File Offset: 0x00039B64
	private bool IsNotUsingStyle()
	{
		return string.IsNullOrEmpty(this.Style.StyleId);
	}

	// Token: 0x17000146 RID: 326
	// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x0003B984 File Offset: 0x00039B84
	// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x0003B998 File Offset: 0x00039B98
	public ControllerActionButton LinkedActionMapping
	{
		get
		{
			return this._linkedActionMapping;
		}
		set
		{
			this._linkedActionMapping = value;
		}
	}

	// Token: 0x06000BEA RID: 3050 RVA: 0x0003B9AC File Offset: 0x00039BAC
	public TransactionButton_Layout()
	{
		int num = 1;
		this.DrawItem = num != 0;
		this.ClickOnRelease = num != 0;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		if (!true)
		{
		}
		int num2 = 16256;
		this.ForcedIconScale = (float)num2;
		if (true)
		{
			return;
		}
		int num3 = 16256;
		this.ForcedControlIconScale = (float)num3;
		this.ForcedItemScale = (float)num3;
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04000F3E RID: 3902
	[BoxGroup("Style", -1, null, "IsNotUsingStyle")]
	public TransactionButtonStyle_Layout Style;

	// Token: 0x04000F3F RID: 3903
	[BoxGroup("Setup", -1, "Style", null)]
	public bool DrawLabel;

	// Token: 0x04000F40 RID: 3904
	[BoxGroup("Setup", -1, null, null)]
	public bool DrawIcon;

	// Token: 0x04000F41 RID: 3905
	[BoxGroup("Setup", -1, null, null)]
	public bool DrawItem;

	// Token: 0x04000F42 RID: 3906
	[BoxGroup("Setup", -1, null, null)]
	public bool DrawControlsIconOnFocus;

	// Token: 0x04000F43 RID: 3907
	[BoxGroup("Setup", -1, null, null)]
	public bool ClickOnRelease;

	// Token: 0x04000F44 RID: 3908
	[ShowIf("DrawLabel")]
	[BoxGroup("Label", -1, "Style", null)]
	public String_Layout Label;

	// Token: 0x04000F45 RID: 3909
	public bool MouseHoverFade;

	// Token: 0x04000F46 RID: 3910
	[BoxGroup("Label", -1, null, null)]
	[ShowIf("DrawLabel")]
	public Color DisabledLabelColour;

	// Token: 0x04000F47 RID: 3911
	[BoxGroup("Label", -1, null, null)]
	[ShowIf("DrawLabel")]
	public Color PressedLabelColour;

	// Token: 0x04000F48 RID: 3912
	[BoxGroup("Icon", -1, "Style", null)]
	[ShowIf("DrawIcon")]
	public bool DisableIconResize;

	// Token: 0x04000F49 RID: 3913
	[ShowIf("DrawIcon")]
	[BoxGroup("Icon", -1, null, null)]
	public Vector2 IconOffset;

	// Token: 0x04000F4A RID: 3914
	[ShowIf("DrawIcon")]
	[BoxGroup("Icon", -1, null, null)]
	public bool ForceIconScale;

	// Token: 0x04000F4B RID: 3915
	[ShowIf("DrawIcon")]
	[BoxGroup("Icon", -1, null, null)]
	public float ForcedIconScale;

	// Token: 0x04000F4C RID: 3916
	[ShowIf("DrawIcon")]
	public Texture_Layout IconTexture;

	// Token: 0x04000F4D RID: 3917
	[ShowIf("DrawIcon")]
	public Texture_Layout IconTextureHighlight;

	// Token: 0x04000F4E RID: 3918
	[ShowIf("DrawControlsIconOnFocus")]
	[BoxGroup("Controls", -1, "Style", null)]
	public bool DisableIconOnFocus;

	// Token: 0x04000F4F RID: 3919
	[BoxGroup("Controls", -1, "Style", null)]
	[ShowIf("DrawControlsIconOnFocus")]
	public bool DisableItemOnFocus;

	// Token: 0x04000F50 RID: 3920
	[ShowIf("DrawControlsIconOnFocus")]
	public GUIControllerInputButton.LinkedControlType LinkedControl;

	// Token: 0x04000F51 RID: 3921
	private ControllerActionButton _linkedActionMapping;

	// Token: 0x04000F52 RID: 3922
	[BoxGroup("Controls", -1, null, null)]
	[ShowIf("DrawControlsIconOnFocus")]
	public bool DisableControlIconResize;

	// Token: 0x04000F53 RID: 3923
	[BoxGroup("Controls", -1, null, null)]
	[ShowIf("DrawControlsIconOnFocus")]
	public Vector2 ControlIconOffset;

	// Token: 0x04000F54 RID: 3924
	[ShowIf("DrawControlsIconOnFocus")]
	[BoxGroup("Controls", -1, null, null)]
	public bool ForceControlIconScale;

	// Token: 0x04000F55 RID: 3925
	[ShowIf("DrawControlsIconOnFocus")]
	[BoxGroup("Controls", -1, null, null)]
	public float ForcedControlIconScale;

	// Token: 0x04000F56 RID: 3926
	[ShowIf("DrawItem")]
	[BoxGroup("Item", -1, "Style", null)]
	public bool DisableItemResize;

	// Token: 0x04000F57 RID: 3927
	[BoxGroup("Item", -1, null, null)]
	[ShowIf("DrawItem")]
	public bool ForceItemScale;

	// Token: 0x04000F58 RID: 3928
	[ShowIf("DrawItem")]
	[BoxGroup("Item", -1, null, null)]
	public float ForcedItemScale;

	// Token: 0x04000F59 RID: 3929
	[ShowIf("DrawItem")]
	[BoxGroup("Item", -1, null, null)]
	public Vector2 ItemOffset;

	// Token: 0x04000F5A RID: 3930
	[ShowIf("DrawItem")]
	[BoxGroup("Item", -1, null, null)]
	public Texture_Layout DefaultItemTexture;

	// Token: 0x04000F5B RID: 3931
	[BoxGroup("Normal", -1, "Style", null)]
	[ShowIf("DrawItem")]
	public Color ItemColour;

	// Token: 0x04000F5C RID: 3932
	[BoxGroup("Disabled", -1, "Style", null)]
	[ShowIf("DrawItem")]
	public Color DisabledItemColour;

	// Token: 0x04000F5D RID: 3933
	[BoxGroup("Pressed", -1, "Style", null)]
	[ShowIf("DrawItem")]
	public Color PressedItemColour;

	// Token: 0x04000F5E RID: 3934
	[BoxGroup("Setup", -1, null, null)]
	public bool overloadSize;

	// Token: 0x04000F5F RID: 3935
	[BoxGroup("Setup", -1, null, null)]
	[ShowIf("overloadSize")]
	public Vector2 overloadedSize;

	// Token: 0x04000F60 RID: 3936
	[BoxGroup("Highlight", -1, null, null)]
	public Texture_Layout HighlightBackingDisabled;

	// Token: 0x04000F61 RID: 3937
	[BoxGroup("Highlight", -1, null, null)]
	public Color HighlightDisabledColour;

	// Token: 0x04000F62 RID: 3938
	[BoxGroup("Highlight", -1, null, null)]
	public Texture_Layout HighlightBackingNormal;

	// Token: 0x04000F63 RID: 3939
	[BoxGroup("Highlight", -1, null, null)]
	public Color HighlightColour;

	// Token: 0x04000F64 RID: 3940
	[BoxGroup("Highlight", -1, null, null)]
	public Texture_Layout HighlightBackingPressed;

	// Token: 0x04000F65 RID: 3941
	[BoxGroup("Highlight", -1, null, null)]
	public Color HighlightPressedColour;

	// Token: 0x04000F66 RID: 3942
	[BoxGroup("Setup", -1, null, null)]
	public bool DrawDivider;

	// Token: 0x04000F67 RID: 3943
	[BoxGroup("Divider", -1, "Style", null)]
	[ShowIf("DrawDivider")]
	public Panel_Layout Divider;

	// Token: 0x04000F68 RID: 3944
	[ShowIf("DrawDivider")]
	[BoxGroup("Divider", -1, null, null)]
	public bool UseDividerHighlightColours;

	// Token: 0x04000F69 RID: 3945
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	public Color DividerHighlightColour;

	// Token: 0x04000F6A RID: 3946
	[ShowIf("DrawDivider")]
	[BoxGroup("Divider", -1, null, null)]
	public Color DividerHighlightBorderColour;

	// Token: 0x04000F6B RID: 3947
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	public Color DividerPressedColour;

	// Token: 0x04000F6C RID: 3948
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	public Color DividerPressedBorderColour;

	// Token: 0x04000F6D RID: 3949
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	public Color DividerPressedHighlightColour;

	// Token: 0x04000F6E RID: 3950
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	public Color DividerPressedHighlightBorderColour;

	// Token: 0x04000F6F RID: 3951
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	public Color DividerDisabledColour;

	// Token: 0x04000F70 RID: 3952
	[ShowIf("DrawDivider")]
	[BoxGroup("Divider", -1, null, null)]
	public Color DividerDisabledBorderColour;

	// Token: 0x04000F71 RID: 3953
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	public Color DividerDisabledHighlightColour;

	// Token: 0x04000F72 RID: 3954
	[BoxGroup("Divider", -1, null, null)]
	[ShowIf("DrawDivider")]
	public Color DividerDisabledHighlightBorderColour;

	// Token: 0x04000F73 RID: 3955
	[BoxGroup("Disabled", -1, null, null)]
	public Texture_Layout BorderDisabled;

	// Token: 0x04000F74 RID: 3956
	[BoxGroup("Disabled", -1, null, null)]
	public Color DisabledBorderColour;

	// Token: 0x04000F75 RID: 3957
	[BoxGroup("Normal", -1, null, null)]
	public Texture_Layout BorderNormal;

	// Token: 0x04000F76 RID: 3958
	[BoxGroup("Normal", -1, null, null)]
	public Color NormalBorderColour;

	// Token: 0x04000F77 RID: 3959
	[BoxGroup("Pressed", -1, null, null)]
	public Texture_Layout BorderPressed;

	// Token: 0x04000F78 RID: 3960
	[BoxGroup("Pressed", -1, null, null)]
	public Color PressedBorderColour;
}
