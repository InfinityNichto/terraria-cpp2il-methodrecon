using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000194 RID: 404
public class Buffs_Layout : LayoutDefinition
{
	// Token: 0x17000120 RID: 288
	// (get) Token: 0x06000B54 RID: 2900 RVA: 0x000021DB File Offset: 0x000003DB
	public static Buffs_Layout Instance
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x00039384 File Offset: 0x00037584
	private void Awake()
	{
		bool flag = this.name == "Buffs4Page";
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x000393A4 File Offset: 0x000375A4
	public Buffs_Layout()
	{
		if (16976 == 0)
		{
		}
		this.SelectedColour = 16976;
		base..ctor();
	}

	// Token: 0x04000C85 RID: 3205
	public static Buffs_Layout InstanceNormal;

	// Token: 0x04000C86 RID: 3206
	public static Buffs_Layout Instance4Page;

	// Token: 0x04000C87 RID: 3207
	public ItemGrid_Layout BuffsGrid;

	// Token: 0x04000C88 RID: 3208
	public ItemGrid_Layout HorizontalBuffsGrid;

	// Token: 0x04000C89 RID: 3209
	public float ItemScale;

	// Token: 0x04000C8A RID: 3210
	public float SelectedScale;

	// Token: 0x04000C8B RID: 3211
	public float BaseTextScale = (float)52429;

	// Token: 0x04000C8C RID: 3212
	public Vector2 TextOffset;

	// Token: 0x04000C8D RID: 3213
	public Color SelectedColour;

	// Token: 0x04000C8E RID: 3214
	public Color NormalColour;

	// Token: 0x04000C8F RID: 3215
	public Color SelectedTextColour;

	// Token: 0x04000C90 RID: 3216
	public Color NormalTextColour;
}
