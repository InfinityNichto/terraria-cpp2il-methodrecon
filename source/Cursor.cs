using System;
using UnityEngine;

// Token: 0x02000013 RID: 19
public class Cursor
{
	// Token: 0x06000055 RID: 85 RVA: 0x000028CC File Offset: 0x00000ACC
	public Cursor()
	{
	}

	// Token: 0x0400003A RID: 58
	public Vector2 Position;

	// Token: 0x0400003B RID: 59
	public Vector2 OldPosition;

	// Token: 0x0400003C RID: 60
	public int Id;

	// Token: 0x0400003D RID: 61
	public bool Down;

	// Token: 0x0400003E RID: 62
	public bool WasDown;

	// Token: 0x0400003F RID: 63
	public Vector2 CursorScroll;

	// Token: 0x04000040 RID: 64
	public bool Dead;

	// Token: 0x04000041 RID: 65
	public bool IgnoreForWorld;

	// Token: 0x04000042 RID: 66
	public bool Ignore;

	// Token: 0x04000043 RID: 67
	public CursorInputLayer InputLayer;

	// Token: 0x04000044 RID: 68
	public object InputLayerData;

	// Token: 0x04000045 RID: 69
	public DateTime LastUpdate;
}
