using System;
using Microsoft.Xna.Framework;

// Token: 0x0200018E RID: 398
[Serializable]
public class AchievementIcon
{
	// Token: 0x06000B49 RID: 2889 RVA: 0x00039254 File Offset: 0x00037454
	private void Awake()
	{
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x00039264 File Offset: 0x00037464
	public AchievementIcon()
	{
	}

	// Token: 0x04000C16 RID: 3094
	public static AchievementIcon Instance;

	// Token: 0x04000C17 RID: 3095
	public string SpriteTextureID;

	// Token: 0x04000C18 RID: 3096
	public string BorderTextureID;

	// Token: 0x04000C19 RID: 3097
	public Panel_Layout Backing;

	// Token: 0x04000C1A RID: 3098
	public int SpriteIconSize;

	// Token: 0x04000C1B RID: 3099
	public int SpriteIconSizeWithSpace;

	// Token: 0x04000C1C RID: 3100
	public int SpriteIconsPerRow = 8;

	// Token: 0x04000C1D RID: 3101
	public Vector2 BorderLocation;

	// Token: 0x04000C1E RID: 3102
	public Vector2 IconLocation;

	// Token: 0x04000C1F RID: 3103
	public float IconScale = (float)16256;
}
