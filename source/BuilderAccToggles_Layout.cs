using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000195 RID: 405
public class BuilderAccToggles_Layout : LayoutDefinition
{
	// Token: 0x17000121 RID: 289
	// (get) Token: 0x06000B57 RID: 2903 RVA: 0x000021DB File Offset: 0x000003DB
	public static BuilderAccToggles_Layout Instance
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x06000B58 RID: 2904 RVA: 0x000021DB File Offset: 0x000003DB
	public ItemGrid_Layout ToggleOptionsGrid
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000B59 RID: 2905 RVA: 0x000393D4 File Offset: 0x000375D4
	private void Awake()
	{
		bool flag = this.name == "BuilderAccToggles4Page";
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x000393F4 File Offset: 0x000375F4
	public BuilderAccToggles_Layout()
	{
		if (16256 == 0)
		{
		}
		base..ctor();
	}

	// Token: 0x04000C91 RID: 3217
	public static BuilderAccToggles_Layout InstanceNormal;

	// Token: 0x04000C92 RID: 3218
	public static BuilderAccToggles_Layout Instance4Page;

	// Token: 0x04000C93 RID: 3219
	public TransactionButton_Layout ControllerToggleBuilderAccessories;

	// Token: 0x04000C94 RID: 3220
	public TransactionButton_Layout ToggleBuilderAccessories;

	// Token: 0x04000C95 RID: 3221
	public TransactionButton_Layout ToggleBuilderAccessories_Horizontal;

	// Token: 0x04000C96 RID: 3222
	public Vector2 BackingTLOffset;

	// Token: 0x04000C97 RID: 3223
	public Vector2 BackingBROffset;

	// Token: 0x04000C98 RID: 3224
	public Panel_Layout Backing;

	// Token: 0x04000C99 RID: 3225
	public float ToggleScale;

	// Token: 0x04000C9A RID: 3226
	public float ToggleIconScale = (float)16256;

	// Token: 0x04000C9B RID: 3227
	public ItemGrid_Layout ToggleOptions;

	// Token: 0x04000C9C RID: 3228
	public ItemGrid_Layout ToggleOptions_Horizontal;

	// Token: 0x04000C9D RID: 3229
	public TransactionButton_Layout ToggleEntry;

	// Token: 0x04000C9E RID: 3230
	public Texture_Layout AccBackingTexture;

	// Token: 0x04000C9F RID: 3231
	public Color AccBackingColour;

	// Token: 0x04000CA0 RID: 3232
	public Texture_Layout AccHighlightTexture;

	// Token: 0x04000CA1 RID: 3233
	public Color AccHighlightColour;

	// Token: 0x04000CA2 RID: 3234
	public FadeString_Layout TooltipDisplay;
}
