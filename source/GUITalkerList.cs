using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x02000173 RID: 371
public class GUITalkerList
{
	// Token: 0x06000A85 RID: 2693 RVA: 0x00033374 File Offset: 0x00031574
	public GUITalkerList()
	{
	}

	// Token: 0x06000A86 RID: 2694 RVA: 0x00033384 File Offset: 0x00031584
	public void Draw()
	{
		DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
		if (!true)
		{
		}
		this.RefreshTalkersList();
		List<string> activeTalkers = this.ActiveTalkers;
		GUIItemGrid.GetItemScaleHandler getItemScaleHandler = this.itemScale;
		GUIItemGrid.CursorOver cursorOver = this.itemOver;
		GUIItemGrid.DrawItemHandler drawItemHandler = this.itemDraw;
		int size = activeTalkers._size;
		if (this.lastDrawRegion.Width != 0)
		{
			Rectangle rectangle = this.lastDrawRegion;
			int width = this.lastDrawRegion.Width;
			Vector2 vector = rectangle.TopLeft();
			Rectangle rectangle2 = this.lastDrawRegion;
			int width2 = this.lastDrawRegion.Width;
			Vector2 vector2 = rectangle2.BottomRight();
			return;
		}
		Main.FlushBatches();
	}

	// Token: 0x06000A87 RID: 2695 RVA: 0x000021DB File Offset: 0x000003DB
	public float ItemScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000A88 RID: 2696 RVA: 0x00033424 File Offset: 0x00031624
	public void ItemOver(int index)
	{
	}

	// Token: 0x06000A89 RID: 2697 RVA: 0x00033434 File Offset: 0x00031634
	public void ItemDraw(ItemGrid_Layout gridLayout, int i, Vector2 position, float scale)
	{
		int num = this.itemOffset;
		Texture2D texture2D;
		int width = texture2D.Width;
		int height = texture2D.Height;
		int num2 = 32640;
		int width2 = texture2D.Width;
		int arraySize = texture2D.ArraySize;
		if (this.lastDrawRegion.Width != 0)
		{
			Rectangle rectangle;
			this.lastDrawRegion = rectangle;
			this.lastDrawRegion.Width = texture2D;
			return;
		}
		List<string> activeTalkers = this.ActiveTalkers;
		if (num2 == 0)
		{
		}
	}

	// Token: 0x06000A8A RID: 2698 RVA: 0x000021DB File Offset: 0x000003DB
	public void RefreshTalkersList()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x04000A72 RID: 2674
	private List<string> ActiveTalkers;

	// Token: 0x04000A73 RID: 2675
	private Rectangle lastDrawRegion;

	// Token: 0x04000A74 RID: 2676
	private GUIItemGrid.GetItemScaleHandler itemScale;

	// Token: 0x04000A75 RID: 2677
	private GUIItemGrid.CursorOver itemOver;

	// Token: 0x04000A76 RID: 2678
	private GUIItemGrid.DrawItemHandler itemDraw;

	// Token: 0x04000A77 RID: 2679
	private int itemOffset;
}
