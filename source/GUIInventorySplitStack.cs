using System;
using Controller;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria;

// Token: 0x0200014C RID: 332
public class GUIInventorySplitStack
{
	// Token: 0x06000909 RID: 2313 RVA: 0x00027134 File Offset: 0x00025334
	public GUIInventorySplitStack()
	{
		GUIInputRegionExclusive guiinputRegionExclusive;
		this.PickingInterceptor = guiinputRegionExclusive;
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x00027160 File Offset: 0x00025360
	public static void LoadContent(ContentManager content)
	{
		Texture2D texture2D = content.Load<Texture2D>("Images/UI/PageIcons/SplitStack");
		Texture2D texture2D2 = content.Load<Texture2D>("Images/UI/PageIcons/SplitStackSelected");
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x00027188 File Offset: 0x00025388
	public void Open()
	{
		Item item;
		int stack = item.stack;
		this.RefreshItemToSplit();
		int num = 1;
		this.open = num != 0;
	}

	// Token: 0x0600090C RID: 2316 RVA: 0x000271AC File Offset: 0x000253AC
	private void RefreshItemToSplit()
	{
		Item splitItem = this.SplitItem;
		Item item;
		int type = item.type;
		splitItem.type = type;
		Color color = item.color;
		splitItem.color = color;
		Item itemToSplit = this.ItemToSplit;
		int type2 = item.type;
		itemToSplit.type = type2;
		Color color2 = item.color;
		itemToSplit.color = color2;
		int stack = item.stack;
		float num = this.splitSlider;
		Item splitItem2 = this.SplitItem;
		int num2;
		splitItem2.stack = num2;
		Item itemToSplit2 = this.ItemToSplit;
		int stack2 = this.SplitItem.stack;
		itemToSplit2.stack = stack2;
	}

	// Token: 0x0600090D RID: 2317 RVA: 0x00027248 File Offset: 0x00025448
	public bool IsOpen()
	{
		return this.open;
	}

	// Token: 0x0600090E RID: 2318 RVA: 0x0002725C File Offset: 0x0002545C
	public void Close()
	{
	}

	// Token: 0x0600090F RID: 2319 RVA: 0x0002726C File Offset: 0x0002546C
	public bool IsOver(Vector2 cursorPosition)
	{
		if (!true)
		{
		}
		bool gameMenu = Main.gameMenu;
		bool flag = this.open;
		if (flag)
		{
			if (!flag)
			{
			}
			bool playerInventory = Main.playerInventory;
		}
		!0 instance = PageControllerLayoutDefinition.Instance;
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		bool flag2;
		return flag2;
	}

	// Token: 0x06000910 RID: 2320 RVA: 0x000272B4 File Offset: 0x000254B4
	public void RightClickSplit()
	{
		if (!true)
		{
		}
		DateTime now = DateTime.Now;
		this.lastSplitTime = now;
		if (!true)
		{
		}
		int mouseX = Main.mouseX;
		int mouseY = Main.mouseY;
		this.lastSplitPosition = 1;
	}

	// Token: 0x06000911 RID: 2321 RVA: 0x000272F0 File Offset: 0x000254F0
	public bool WasSplit()
	{
		if (!true)
		{
		}
		DateTime now = DateTime.Now;
		DateTime dateTime = this.lastSplitTime;
		double totalSeconds = (now - dateTime).TotalSeconds;
		Vector2 uicursorPosition = Mouse.GetUICursorPosition();
		float x = this.lastSplitPosition.X;
		float y = this.lastSplitPosition.Y;
		Vector2 vector;
		float num = vector.Length();
		return true;
	}

	// Token: 0x06000912 RID: 2322 RVA: 0x00027350 File Offset: 0x00025550
	public void Draw()
	{
		GUIInputRegionExclusive pickingInterceptor = this.PickingInterceptor;
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (this.open)
		{
			bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		}
		int myPlayer = Main.myPlayer;
		Item item;
		if (item.type != 0)
		{
			Item item2;
			int stack = item2.stack;
			return;
		}
		if (true)
		{
			return;
		}
		bool anyControllerConnected2 = ControllerActionManager.AnyControllerConnected;
		Item item3;
		if (item3.type != 0)
		{
			Item item4;
			int stack2 = item4.stack;
		}
		bool flag = this.open;
		int num = 544;
		if (this.open)
		{
			if (num == 0)
			{
			}
			bool flag2 = this.open;
			return;
		}
	}

	// Token: 0x06000913 RID: 2323 RVA: 0x00027480 File Offset: 0x00025680
	public void DrawOverlay()
	{
		GUIInputRegionExclusive pickingInterceptor = this.PickingInterceptor;
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (this.open)
		{
			this.RefreshItemToSplit();
			return;
		}
		GUIInputRegionExclusive pickingInterceptor2 = this.PickingInterceptor;
		int num = 1;
		pickingInterceptor2.Active = num != 0;
	}

	// Token: 0x04000879 RID: 2169
	public static Texture2D SplitStackIcon;

	// Token: 0x0400087A RID: 2170
	public static Texture2D SplitStackIconOpen;

	// Token: 0x0400087B RID: 2171
	public GUIInputRegionExclusive PickingInterceptor;

	// Token: 0x0400087C RID: 2172
	private bool open;

	// Token: 0x0400087D RID: 2173
	private float splitSlider = (float)16128;

	// Token: 0x0400087E RID: 2174
	private GUISlider.DragState dragState;

	// Token: 0x0400087F RID: 2175
	private Item ItemToSplit;

	// Token: 0x04000880 RID: 2176
	private Item SplitItem;

	// Token: 0x04000881 RID: 2177
	private float splitScale;

	// Token: 0x04000882 RID: 2178
	private float itemScale;

	// Token: 0x04000883 RID: 2179
	private float mainScale;

	// Token: 0x04000884 RID: 2180
	private DateTime lastSplitTime;

	// Token: 0x04000885 RID: 2181
	private Vector2 lastSplitPosition;

	// Token: 0x04000886 RID: 2182
	public GUITransactionButton.InputState splitButtonState = GUITransactionButton.InputState.None;
}
