using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001B3 RID: 435
[Serializable]
public class Panel_Layout
{
	// Token: 0x06000BBE RID: 3006 RVA: 0x0003A8BC File Offset: 0x00038ABC
	public void Copy(Panel_Layout other)
	{
		ControlAnchor.ControlId anchorControl = other.AnchorControl;
		Texture_Layout backing = this.Backing;
		this.AnchorControl = anchorControl;
		Vector2 location = other.Location;
		this.Location = location;
		Vector2 size = other.Size;
		this.Size = size;
		bool anchorForSize = other.AnchorForSize;
		this.AnchorForSize = anchorForSize;
		Color backingColor = other.BackingColor;
		this.BackingColor = backingColor;
		Color borderColor = other.BorderColor;
		this.BorderColor = borderColor;
		Color highlightColor = other.HighlightColor;
		this.HighlightColor = highlightColor;
		string textureId = other.Backing.TextureId;
		backing.TextureId = textureId;
		Texture_Layout border = other.Border;
		Texture_Layout border2 = this.Border;
		string textureId2 = border.TextureId;
		border2.TextureId = textureId2;
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x0003A974 File Offset: 0x00038B74
	public Panel_Layout()
	{
		if (17146 == 0)
		{
		}
		this.BackingColor = 17146;
		this.BorderColor = 17146;
		this.HighlightColor = 17146;
		base..ctor();
	}

	// Token: 0x04000E4D RID: 3661
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000E4E RID: 3662
	public LayoutCalculator.AnchorType Anchor = LayoutCalculator.AnchorType.BottomLeft;

	// Token: 0x04000E4F RID: 3663
	public Vector2 Location = 17146;

	// Token: 0x04000E50 RID: 3664
	public Vector2 Size;

	// Token: 0x04000E51 RID: 3665
	public bool AnchorForSize;

	// Token: 0x04000E52 RID: 3666
	public ControlAnchor.ControlId SizeAnchorControl;

	// Token: 0x04000E53 RID: 3667
	public LayoutCalculator.AnchorType SizeAnchor = LayoutCalculator.AnchorType.BottomLeft;

	// Token: 0x04000E54 RID: 3668
	public Vector2 SizeLocation;

	// Token: 0x04000E55 RID: 3669
	public Vector2 PickBorder;

	// Token: 0x04000E56 RID: 3670
	public Vector2 PickOffset;

	// Token: 0x04000E57 RID: 3671
	public Color BackingColor;

	// Token: 0x04000E58 RID: 3672
	public Color BorderColor;

	// Token: 0x04000E59 RID: 3673
	public Color HighlightColor;

	// Token: 0x04000E5A RID: 3674
	public Texture_Layout Backing;

	// Token: 0x04000E5B RID: 3675
	public Texture_Layout Border;

	// Token: 0x04000E5C RID: 3676
	public Texture_Layout CursorHighlight;
}
