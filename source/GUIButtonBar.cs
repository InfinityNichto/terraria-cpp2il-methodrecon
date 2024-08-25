using System;
using System.Runtime.InteropServices;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x02000127 RID: 295
public class GUIButtonBar
{
	// Token: 0x060007A2 RID: 1954 RVA: 0x0001D0E4 File Offset: 0x0001B2E4
	public GUIButtonBar()
	{
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x0001D0F8 File Offset: 0x0001B2F8
	private void AddAction(GUIButtonBar.Action action, ControllerActionButton bannerAction)
	{
		ControllerActionButton[] itemsActions = this.ItemsActions;
		int itemCount = this.ItemCount;
		if (bannerAction == null)
		{
			GUIButtonBar.Action[] items = this.Items;
			int itemCount2 = this.ItemCount;
			this.ItemCount = itemCount2;
			return;
		}
		if (bannerAction != null)
		{
			int itemCount3 = this.ItemCount;
			return;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x0001D140 File Offset: 0x0001B340
	private void RefreshItems()
	{
		ControllerActionButton[] itemsActions = this.ItemsActions;
		GUIButtonBar.Action[] items = this.Items;
		int itemCount = this.ItemCount;
		this.ItemCount = itemCount;
		bool expanded = this.Expanded;
		if (expanded || expanded)
		{
			ControllerActionButton[] itemsActions2 = this.ItemsActions;
			GUIButtonBar.Action[] items2 = this.Items;
			int itemCount2 = this.ItemCount;
			this.ItemCount = itemCount2;
			if (itemCount2 == 0)
			{
			}
			int gameMode = Main.GameMode;
			ControllerActionButton[] itemsActions3 = this.ItemsActions;
			GUIButtonBar.Action[] items3 = this.Items;
			int itemCount3 = this.ItemCount;
			ControllerActionButton[] itemsActions4 = this.ItemsActions;
			GUIButtonBar.Action[] items4 = this.Items;
			int itemCount4 = this.ItemCount;
			this.ItemCount = itemCount4;
			return;
		}
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x000021DB File Offset: 0x000003DB
	public float ItemScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x0001D26C File Offset: 0x0001B46C
	private void ItemOver(int index)
	{
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x0001D27C File Offset: 0x0001B47C
	private Texture2D GetButtonSetup(GUIButtonBar.Action action, int entry, [Out] bool disabled, [Out] string actionString, [Out] TransactionButton_Layout buttonLayout)
	{
		if (entry != 0)
		{
			int itemCount = this.ItemCount;
		}
		if (this.Expanded)
		{
			if (72 == 0)
			{
			}
			bool mapEnabled = Main.mapEnabled;
			bool mapReady = Main.mapReady;
			bool mapEnabled2 = Main.mapEnabled;
			bool mapReady2 = Main.mapReady;
			int num = 1;
			disabled.m_value = num != 0;
			if (num == 0)
			{
			}
			int num2 = 1;
			disabled.m_value = num2 != 0;
			if (num2 == 0)
			{
			}
			Texture2D texture2D;
			return texture2D;
		}
		Texture2D texture2D2;
		return texture2D2;
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x0001D2E8 File Offset: 0x0001B4E8
	private void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		GUITransactionButton.InputState inputState;
		do
		{
			if (!true)
			{
			}
			GUIButtonBar.Action[] items = this.Items;
			ControllerActionButton[] itemsActions = this.ItemsActions;
			float[] scale2 = this.Scale;
			ControllerActionButton linkedAction = itemsActions.LinkedAction;
		}
		while (inputState != GUITransactionButton.InputState.Clicked);
		if (this.Items == null)
		{
		}
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x0001D324 File Offset: 0x0001B524
	private void PerformAction(GUIButtonBar.Action action)
	{
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x0001D378 File Offset: 0x0001B578
	public void Draw()
	{
		int num = 1;
		if (num == 0)
		{
		}
		bool mapFullscreen = Main.mapFullscreen;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (num == 0)
		{
			this.RefreshItems();
			GUIItemGrid.GetItemScaleHandler getItemScaleHandler = this.itemScale;
			int itemCount = this.ItemCount;
			GUIItemGrid.GetItemScaleHandler getItemScaleHandler2 = this.itemScale;
			GUIItemGrid.CursorOver cursorOver = this.itemOver;
			GUIItemGrid.DrawItemHandler drawItemHandler = this.itemDraw;
			int itemCount2 = this.ItemCount;
		}
	}

	// Token: 0x0400061F RID: 1567
	private int ItemCount;

	// Token: 0x04000620 RID: 1568
	public GUIButtonBar.Action[] Items;

	// Token: 0x04000621 RID: 1569
	public ControllerActionButton[] ItemsActions;

	// Token: 0x04000622 RID: 1570
	public float[] Scale;

	// Token: 0x04000623 RID: 1571
	private bool Expanded;

	// Token: 0x04000624 RID: 1572
	private GUIItemGrid.GetItemScaleHandler itemScale;

	// Token: 0x04000625 RID: 1573
	private GUIItemGrid.CursorOver itemOver;

	// Token: 0x04000626 RID: 1574
	private GUIItemGrid.DrawItemHandler itemDraw;

	// Token: 0x02000128 RID: 296
	public enum Action
	{
		// Token: 0x04000628 RID: 1576
		ButtonBarToggle,
		// Token: 0x04000629 RID: 1577
		Chat,
		// Token: 0x0400062A RID: 1578
		Tutorial,
		// Token: 0x0400062B RID: 1579
		JourneyModeSettings,
		// Token: 0x0400062C RID: 1580
		Housing,
		// Token: 0x0400062D RID: 1581
		PVP,
		// Token: 0x0400062E RID: 1582
		Bestiary,
		// Token: 0x0400062F RID: 1583
		MiniMapToggle,
		// Token: 0x04000630 RID: 1584
		Map,
		// Token: 0x04000631 RID: 1585
		Duplication,
		// Token: 0x04000632 RID: 1586
		Count
	}
}
