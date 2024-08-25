using System;

// Token: 0x020001E1 RID: 481
[Serializable]
public class FavoriteIcons
{
	// Token: 0x06000C47 RID: 3143 RVA: 0x0003D2F8 File Offset: 0x0003B4F8
	public FavoriteIcons()
	{
	}

	// Token: 0x04001139 RID: 4409
	public static FavoriteIcons Instance;

	// Token: 0x0400113A RID: 4410
	public Texture_Layout Normal;

	// Token: 0x0400113B RID: 4411
	public Texture_Layout NormalSelected;

	// Token: 0x0400113C RID: 4412
	public Texture_Layout Favorite;

	// Token: 0x0400113D RID: 4413
	public Texture_Layout FavoriteSelected;

	// Token: 0x0400113E RID: 4414
	public Texture_Layout Disabled;
}
