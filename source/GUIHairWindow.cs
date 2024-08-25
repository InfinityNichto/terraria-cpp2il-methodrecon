using System;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using UnityEngine;

// Token: 0x02000143 RID: 323
public class GUIHairWindow
{
	// Token: 0x060008B0 RID: 2224 RVA: 0x000242BC File Offset: 0x000224BC
	public void LoadRegion()
	{
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
	}

	// Token: 0x060008B1 RID: 2225 RVA: 0x000242D0 File Offset: 0x000224D0
	public void Draw()
	{
		Main.FlushBatches();
		int num = 1;
		bool flag = Main.npcChatText != "";
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (num == 0)
		{
		}
		if (Main.npcShop != 0)
		{
			if (num == 0)
			{
			}
			Main.CancelHairWindow();
			return;
		}
		if (num == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
		if (num == 0)
		{
		}
		bool inGuideCraftMenu = Main.InGuideCraftMenu;
		GUIControllerHairStylist controller = this._controller;
		this._controller.Activate();
		int num2 = 154;
		this.unlockedMaxHair = num2;
		if (num2 == 0)
		{
		}
		int num3 = this.unlockedMaxHair;
		this.unlockedMaxHair = num3;
		if (num3 == 0)
		{
		}
		int num4 = this.unlockedMaxHair;
		this.unlockedMaxHair = num4;
		if (num4 == 0)
		{
		}
		int myPlayer3 = Main.myPlayer;
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
		bool drawSliders;
		if (!this.DrawSliders)
		{
			this.DrawHairGrid();
			drawSliders = this.DrawSliders;
			if (!drawSliders)
			{
				goto IL_00DA;
			}
		}
		this.DrawHSLSlider();
		IL_00DA:
		if (!drawSliders)
		{
		}
		Main.FlushBatches();
		this.DrawPlayer();
		Main.FlushBatches();
		this.DrawCategoryButtons();
		this.DrawButtons();
	}

	// Token: 0x060008B2 RID: 2226 RVA: 0x000243E0 File Offset: 0x000225E0
	private void DrawCategoryButtons()
	{
		int num = 1;
		if (num == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (num == 0)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		int num2 = 17096;
		this.TimeSinceItemChange = (float)num2;
		bool drawSliders = this.DrawSliders;
		GUIControllerHairStylist controller = this._controller;
		int num3 = 2;
		this.DrawSliders = drawSliders;
		controller.selectedControl = (GUIControllerHairStylist.Controls)num3;
		controller.Activate();
		if (num3 == 0)
		{
		}
		if (num3 == 0)
		{
		}
		Microsoft.Xna.Framework.Graphics.Color selColor = Main.selColor;
		bool drawSliders2 = this.DrawSliders;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
		}
		if (!drawSliders2)
		{
		}
		if (!drawSliders2)
		{
		}
		Microsoft.Xna.Framework.Graphics.Color selColor2 = Main.selColor;
		bool drawSliders3 = this.DrawSliders;
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
			int num4 = 1;
			this.DrawSliders = num4 != 0;
		}
		bool drawSliders4 = this.DrawSliders;
		if (drawSliders4)
		{
			if (!drawSliders4)
			{
			}
			return;
		}
		if (!drawSliders4)
		{
		}
		float timeSinceItemChange = this.TimeSinceItemChange;
		float deltaTime = Time.deltaTime;
	}

	// Token: 0x060008B3 RID: 2227 RVA: 0x000244D8 File Offset: 0x000226D8
	private void DrawCancelButton()
	{
		GUITransactionButton.InputState inputState;
		if (inputState != GUITransactionButton.InputState.Clicked)
		{
			return;
		}
		Main.CancelHairWindow();
	}

	// Token: 0x060008B4 RID: 2228 RVA: 0x000244F0 File Offset: 0x000226F0
	private void DrawSelectedHair(Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		int myPlayer3 = Main.myPlayer;
		Microsoft.Xna.Framework.Graphics.Color selColor = Main.selColor;
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x00024560 File Offset: 0x00022760
	public int GetPrice()
	{
		if (!true)
		{
		}
		int oldHairStyle = Main.oldHairStyle;
		return Main.myPlayer;
	}

	// Token: 0x060008B6 RID: 2230 RVA: 0x000245B0 File Offset: 0x000227B0
	public void DrawPlayerUI(Player player, Microsoft.Xna.Framework.Vector2 origin, Microsoft.Xna.Framework.Vector2 size)
	{
	}

	// Token: 0x060008B7 RID: 2231 RVA: 0x000245C0 File Offset: 0x000227C0
	private void DrawPlayer()
	{
		Player player = this.clonePlayer;
		if (player == null)
		{
		}
		int myPlayer = Main.myPlayer;
		Player player2 = this.clonePlayer;
		Player player3 = this.clonePlayer;
		player3.hair = player;
		player3.skinColor = player;
		this.clonePlayer.hairColor = player;
		this.clonePlayer.eyeColor = player;
		this.clonePlayer.shirtColor = player;
		this.clonePlayer.underShirtColor = player;
		this.clonePlayer.pantsColor = player;
		Player player4 = this.clonePlayer;
		player4.shoeColor = player;
		Player player5 = this.clonePlayer;
		Item[] armor = player5.armor;
		player5.skinVariant = player4;
		long entityId = armor.entityId;
		Item blankItem = this._blankItem;
		if (blankItem == null || blankItem != null)
		{
			Player player6 = this.clonePlayer;
			Item[] armor2 = player6.armor;
			player6.PlayerFrame();
			Main.gameMenu = true;
			Player player7 = this.clonePlayer;
			float x = this.CharacterDrawOffset.X;
			float y = this.CharacterDrawOffset.Y;
			if (player == null)
			{
			}
			Main.gameMenu = false;
			return;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x000246D4 File Offset: 0x000228D4
	public void DrawBuyButton()
	{
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		int num = 16992;
		if (num == 0)
		{
		}
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			if (num == 0)
			{
			}
			Main.BuyHairWindow();
		}
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		int num2 = 200;
		if (num2 == 0)
		{
		}
		Main.FlushBatches();
		if (num2 == 0)
		{
		}
		Main.FlushBatches();
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x00024738 File Offset: 0x00022938
	public bool IsOverPanel(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		return true;
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x00024754 File Offset: 0x00022954
	private void DrawButtons()
	{
		Main.FlushBatches();
		this.DrawBuyButton();
		Main.FlushBatches();
		this.DrawCancelButton();
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x00024780 File Offset: 0x00022980
	private void DrawHairGrid()
	{
		int num = 1;
		this.hairOver = num;
		int num2 = this.unlockedMaxHair;
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x000021DB File Offset: 0x000003DB
	public float HairScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x000247A0 File Offset: 0x000229A0
	public void HairOver(int index)
	{
		int num = 1;
		this.hairOver = index;
		if (num == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (num == 0)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		int offset = this.Offset;
		float actionButtonScale = this.ActionButtonScale;
		if (offset == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		int offset2 = this.Offset;
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x00024814 File Offset: 0x00022A14
	public void HairDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		int offset = this.Offset;
		float actionButtonScale = this.ActionButtonScale;
		if (offset == 0)
		{
		}
		if (this.hairOver == 0)
		{
		}
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x00024928 File Offset: 0x00022B28
	private void DrawHSLSlider()
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x00024C10 File Offset: 0x00022E10
	public GUIHairWindow()
	{
	}

	// Token: 0x0400077B RID: 1915
	private int Offset;

	// Token: 0x0400077C RID: 1916
	private int unlockedMaxHair;

	// Token: 0x0400077D RID: 1917
	private float ActionButtonScale = (float)16256;

	// Token: 0x0400077E RID: 1918
	public bool DrawSliders;

	// Token: 0x0400077F RID: 1919
	private GUIControllerHairStylist _controller;

	// Token: 0x04000780 RID: 1920
	private float TimeSinceItemChange = (float)17096;

	// Token: 0x04000781 RID: 1921
	private float closeScale;

	// Token: 0x04000782 RID: 1922
	private Item _blankItem;

	// Token: 0x04000783 RID: 1923
	private Player clonePlayer;

	// Token: 0x04000784 RID: 1924
	private Microsoft.Xna.Framework.Vector2 CharacterDrawOffset = 17096;

	// Token: 0x04000785 RID: 1925
	private float hairButtonScale;

	// Token: 0x04000786 RID: 1926
	private float colourButtonScale;

	// Token: 0x04000787 RID: 1927
	private float TitleScale;

	// Token: 0x04000788 RID: 1928
	public float hairScrollOffset;

	// Token: 0x04000789 RID: 1929
	private float hairScrollMomentum;

	// Token: 0x0400078A RID: 1930
	private int hairScrollDragging;

	// Token: 0x0400078B RID: 1931
	private Microsoft.Xna.Framework.Vector2 hairDragOffset;

	// Token: 0x0400078C RID: 1932
	private int hairOver;

	// Token: 0x0400078D RID: 1933
	private GUISlider.DragState hueDragState;

	// Token: 0x0400078E RID: 1934
	private GUISlider.DragState satDragState;

	// Token: 0x0400078F RID: 1935
	private GUISlider.DragState lightDragState;
}
