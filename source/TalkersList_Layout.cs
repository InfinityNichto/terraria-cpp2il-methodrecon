using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000242 RID: 578
public class TalkersList_Layout : LayoutDefinition
{
	// Token: 0x06000D2B RID: 3371 RVA: 0x0003F080 File Offset: 0x0003D280
	private void Awake()
	{
	}

	// Token: 0x06000D2C RID: 3372 RVA: 0x0003F090 File Offset: 0x0003D290
	public TalkersList_Layout()
	{
		if (16256 == 0)
		{
		}
		this.IconColour = 16256;
		if (16256 == 0)
		{
		}
		base..ctor();
	}

	// Token: 0x04001801 RID: 6145
	public static TalkersList_Layout Instance;

	// Token: 0x04001802 RID: 6146
	public ItemGrid_Layout IconGrid;

	// Token: 0x04001803 RID: 6147
	public String_Layout ItemText;

	// Token: 0x04001804 RID: 6148
	public float ItemScale = (float)16256;

	// Token: 0x04001805 RID: 6149
	public Color IconColour;

	// Token: 0x04001806 RID: 6150
	public Texture_Layout Icon;

	// Token: 0x04001807 RID: 6151
	public Panel_Layout Backing;

	// Token: 0x04001808 RID: 6152
	public Vector2 BackingTLOffset;

	// Token: 0x04001809 RID: 6153
	public Vector2 BackingBROffset;
}
