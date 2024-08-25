using System;
using Controller;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria;

// Token: 0x0200012B RID: 299
public class GUIChestSplitStack
{
	// Token: 0x060007BD RID: 1981 RVA: 0x0001DAF0 File Offset: 0x0001BCF0
	public GUIChestSplitStack()
	{
		GUIInputRegionExclusive guiinputRegionExclusive;
		this.PickingInterceptor = guiinputRegionExclusive;
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x0001DB20 File Offset: 0x0001BD20
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

	// Token: 0x060007BF RID: 1983 RVA: 0x0001DB68 File Offset: 0x0001BD68
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

	// Token: 0x060007C0 RID: 1984 RVA: 0x0001DBA4 File Offset: 0x0001BDA4
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

	// Token: 0x060007C1 RID: 1985 RVA: 0x0001DC04 File Offset: 0x0001BE04
	public bool IsOpen()
	{
		return this.open;
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x0001DC18 File Offset: 0x0001BE18
	public void Open()
	{
		Item item;
		int stack = item.stack;
		long num = 0L;
		this.RefreshItemToSplit(num != 0L);
		int num2 = 1;
		this.open = num2 != 0;
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x0001DC40 File Offset: 0x0001BE40
	private void RefreshItemToSplit(bool SliderConsoleRightDirection = false)
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
		this.ItemToSplit.stack = itemToSplit;
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x0001DCCC File Offset: 0x0001BECC
	public void Close()
	{
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x0001DCDC File Offset: 0x0001BEDC
	public void Draw()
	{
		if (this.PickingInterceptor == null)
		{
		}
		!0 instance = PageControllerLayoutDefinition.Instance;
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		bool anyControllerConnected2 = ControllerActionManager.AnyControllerConnected;
		if (this.open)
		{
			int selectedItemInitial = this.SelectedItemInitial;
			Item itemToSplit = this.ItemToSplit;
			Item splitItem = this.SplitItem;
			int stack = itemToSplit.stack;
			int stack2 = splitItem.stack;
		}
	}

	// Token: 0x0400064D RID: 1613
	public GUIInputRegionExclusive PickingInterceptor;

	// Token: 0x0400064E RID: 1614
	private int SelectedItemInitial;

	// Token: 0x0400064F RID: 1615
	private bool open;

	// Token: 0x04000650 RID: 1616
	private float splitSlider = (float)16128;

	// Token: 0x04000651 RID: 1617
	private GUISlider.DragState dragState;

	// Token: 0x04000652 RID: 1618
	private Item ItemToSplit;

	// Token: 0x04000653 RID: 1619
	private Item SplitItem;

	// Token: 0x04000654 RID: 1620
	private float splitScale;

	// Token: 0x04000655 RID: 1621
	private float itemScale;

	// Token: 0x04000656 RID: 1622
	private float mainScale;

	// Token: 0x04000657 RID: 1623
	private DateTime lastSplitTime;

	// Token: 0x04000658 RID: 1624
	private Vector2 lastSplitPosition;

	// Token: 0x04000659 RID: 1625
	public GUITransactionButton.InputState splitButtonState = GUITransactionButton.InputState.None;
}
