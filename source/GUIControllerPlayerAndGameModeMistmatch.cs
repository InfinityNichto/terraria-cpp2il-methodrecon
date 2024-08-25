using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x0200009F RID: 159
public class GUIControllerPlayerAndGameModeMistmatch : GUIControllerItem
{
	// Token: 0x060003CD RID: 973 RVA: 0x0000C858 File Offset: 0x0000AA58
	public void Activate()
	{
	}

	// Token: 0x060003CE RID: 974 RVA: 0x000021DB File Offset: 0x000003DB
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060003CF RID: 975 RVA: 0x0000C868 File Offset: 0x0000AA68
	public Rectangle GetSelectedItemRegion()
	{
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
		Rectangle rectangle2;
		return rectangle2;
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x0000C87C File Offset: 0x0000AA7C
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x0000C88C File Offset: 0x0000AA8C
	public GUIControllerPlayerAndGameModeMistmatch()
	{
	}

	// Token: 0x040003B3 RID: 947
	public GUIControllerPlayerAndGameModeMistmatch.Controls selectedControl;

	// Token: 0x020000A0 RID: 160
	public enum Controls
	{
		// Token: 0x040003B5 RID: 949
		Cancel
	}
}
