using System;
using Microsoft.Xna.Framework.Graphics;
using NaughtyAttributes;
using Newtonsoft.Json;

// Token: 0x020001B7 RID: 439
[JsonObject(MemberSerialization.Fields)]
[Serializable]
public class QuickActionButton_Layout : Button_Layout
{
	// Token: 0x06000BC3 RID: 3011 RVA: 0x0003AAB8 File Offset: 0x00038CB8
	public QuickActionButton_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04000E71 RID: 3697
	[BoxGroup("Disabled", -1, null, null)]
	public Color DisabledColour;

	// Token: 0x04000E72 RID: 3698
	[BoxGroup("Pressed", -1, null, null)]
	public Color PressedColour;

	// Token: 0x04000E73 RID: 3699
	[ShowIf("DrawIcon")]
	[BoxGroup("Normal", -1, null, null)]
	public Color IconColour;

	// Token: 0x04000E74 RID: 3700
	[BoxGroup("Disabled", -1, null, null)]
	[ShowIf("DrawIcon")]
	public Color DisabledIconColour;

	// Token: 0x04000E75 RID: 3701
	[BoxGroup("Pressed", -1, null, null)]
	[ShowIf("DrawIcon")]
	public Color PressedIconColour;

	// Token: 0x04000E76 RID: 3702
	[BoxGroup("Highlight", -1, "Style", null)]
	public Color LabelHighlightTint;

	// Token: 0x04000E77 RID: 3703
	[BoxGroup("Setup", -1, null, null)]
	public float ScaleSpeed;

	// Token: 0x04000E78 RID: 3704
	[BoxGroup("Disabled", -1, null, null)]
	public float DisabledScale;

	// Token: 0x04000E79 RID: 3705
	[BoxGroup("Pressed", -1, null, null)]
	public float PressedScale;

	// Token: 0x04000E7A RID: 3706
	[BoxGroup("Icon", -1, null, null)]
	[ShowIf("DrawIcon")]
	public int IconMaxSizeInset;

	// Token: 0x04000E7B RID: 3707
	[BoxGroup("Disabled", -1, null, null)]
	public Texture_Layout BackingDisabled;

	// Token: 0x04000E7C RID: 3708
	[BoxGroup("Normal", -1, null, null)]
	public Texture_Layout BackingNormal;

	// Token: 0x04000E7D RID: 3709
	[BoxGroup("Pressed", -1, null, null)]
	public Texture_Layout BackingPressed;

	// Token: 0x04000E7E RID: 3710
	[BoxGroup("Pressed", -1, null, null)]
	public Texture_Layout BackingPressedHighlight;

	// Token: 0x04000E7F RID: 3711
	[BoxGroup("Pressed", -1, null, null)]
	public Color BackingPressedHighlightColour;

	// Token: 0x04000E80 RID: 3712
	[BoxGroup("Highlight", -1, null, null)]
	public Texture_Layout OverBackingHighlight;

	// Token: 0x020001B8 RID: 440
	public enum QuickActionControl
	{
		// Token: 0x04000E82 RID: 3714
		Heal,
		// Token: 0x04000E83 RID: 3715
		Mana,
		// Token: 0x04000E84 RID: 3716
		Mount,
		// Token: 0x04000E85 RID: 3717
		Buff,
		// Token: 0x04000E86 RID: 3718
		Grapple,
		// Token: 0x04000E87 RID: 3719
		Jump,
		// Token: 0x04000E88 RID: 3720
		Fire,
		// Token: 0x04000E89 RID: 3721
		SmartCursor,
		// Token: 0x04000E8A RID: 3722
		AutoFire,
		// Token: 0x04000E8B RID: 3723
		ZoomIn,
		// Token: 0x04000E8C RID: 3724
		ZoomOut,
		// Token: 0x04000E8D RID: 3725
		ZoomDefault,
		// Token: 0x04000E8E RID: 3726
		MapZoomIn,
		// Token: 0x04000E8F RID: 3727
		MapZoomOut,
		// Token: 0x04000E90 RID: 3728
		MapZoomDefault,
		// Token: 0x04000E91 RID: 3729
		MinimapZoomIn,
		// Token: 0x04000E92 RID: 3730
		MinimapZoomOut,
		// Token: 0x04000E93 RID: 3731
		MinimapZoomDefault,
		// Token: 0x04000E94 RID: 3732
		Interact,
		// Token: 0x04000E95 RID: 3733
		Inventory,
		// Token: 0x04000E96 RID: 3734
		Reforge,
		// Token: 0x04000E97 RID: 3735
		AutoSelect,
		// Token: 0x04000E98 RID: 3736
		GrappleFire,
		// Token: 0x04000E99 RID: 3737
		Map,
		// Token: 0x04000E9A RID: 3738
		TargetLockOn,
		// Token: 0x04000E9B RID: 3739
		ProfileSwitch,
		// Token: 0x04000E9C RID: 3740
		Settings,
		// Token: 0x04000E9D RID: 3741
		Loadout1,
		// Token: 0x04000E9E RID: 3742
		Loadout2,
		// Token: 0x04000E9F RID: 3743
		Loadout3,
		// Token: 0x04000EA0 RID: 3744
		LoadoutCycle,
		// Token: 0x04000EA1 RID: 3745
		Unbound
	}
}
