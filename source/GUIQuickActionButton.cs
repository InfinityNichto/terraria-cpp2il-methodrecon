using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameContent.UI;
using UnityEngine;

// Token: 0x02000114 RID: 276
public static class GUIQuickActionButton
{
	// Token: 0x060006E9 RID: 1769 RVA: 0x000175BC File Offset: 0x000157BC
	public static void LoadContent(ContentManager content)
	{
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/VirtualControls/Icon_Jump");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D2 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/SettingsIcons/GrappleStick");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D3 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/SettingsIcons/GrappleButton");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D4 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/VirtualControls/EmptyButton");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D5 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/MapIcons/MapZoomIn");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D6 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/MapIcons/MapZoomOut");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D7 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/MiniMapButton_0");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D8 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/MapIcons/MapZoomIn");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D9 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/MapIcons/MapZoomOut");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D10 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/MapIcons/MiniMapReset");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D11 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/MapIcons/MiniMapPlus");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D12 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/MapIcons/MiniMapMinus");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D13 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/MapIcons/MiniMapReset");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D14 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/VirtualControls/FiringOn");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D15 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/VirtualControls/FiringOff");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D16 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/VirtualControls/TargetLockOn");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D17 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/VirtualControls/TargetIndicator");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D18 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/VirtualControls/SmartCursorOn");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D19 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/VirtualControls/SmartCursorOff");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D20 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/VirtualControls/Icon_Inventory_48");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D21 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/VirtualControls/Icon_InventoryOpen_48");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D22 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/ExtraIcons/InteractIcon");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D23 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/ExtraIcons/AutoSelect");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D24 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/Item_24");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D25 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/PageIcons/Map");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D26 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/PageIcons/MapSelected");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D27 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/VirtualControls/Profile");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D28 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/NPC_Uncollected_Head_1");
		if (texture2D28 == null || texture2D28 != null)
		{
			Microsoft.Xna.Framework.Graphics.Texture2D texture2D29 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/NPC_Uncollected_Head_2");
			if (texture2D29 == null || texture2D29 != null)
			{
				Microsoft.Xna.Framework.Graphics.Texture2D texture2D30 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/NPC_Uncollected_Head_3");
				if (texture2D30 == null || texture2D30 != null)
				{
					Microsoft.Xna.Framework.Graphics.Texture2D texture2D31 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/NPC_Head_8");
					if (texture2D31 == null || texture2D31 != null)
					{
						Microsoft.Xna.Framework.Graphics.Texture2D texture2D32 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/NPC_Head_9");
						if (texture2D32 == null || texture2D32 != null)
						{
							Microsoft.Xna.Framework.Graphics.Texture2D texture2D33 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/NPC_Head_10");
							if (texture2D33 == null || texture2D33 != null)
							{
								Microsoft.Xna.Framework.Graphics.Texture2D texture2D34 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/NPC_Head_20");
								if (texture2D34 == null || texture2D34 != null)
								{
									Microsoft.Xna.Framework.Graphics.Texture2D texture2D35 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/NPC_Head_24");
									if (texture2D35 == null || texture2D35 != null)
									{
										Microsoft.Xna.Framework.Graphics.Texture2D texture2D36 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/NPC_Head_25");
										if (texture2D36 == null || texture2D36 != null)
										{
											texture2D35.PackedEntry = texture2D36;
											return;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x000177FC File Offset: 0x000159FC
	public static NPC GetMouseNPC()
	{
		/*
An exception occurred when decompiling this method (060006EA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.NPC GUIQuickActionButton::GetMouseNPC()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004E:
	stloc:bool(var_17_59, callgetter:bool(Main::get_SmartInteractShowingGenuine))
	stloc:int32(var_19_63, callgetter:int32(Main::get_SmartInteractNPC))
	stloc:int32(var_21_6D, callgetter:int32(Main::get_myPlayer))
	stloc:int32(var_23_77, callgetter:int32(Main::get_myPlayer))
	stloc:int32(var_25_81, callgetter:int32(Player::get_tileRangeX))
	stloc:int32(var_27_8B, callgetter:int32(Main::get_myPlayer))
	stloc:int32(var_29_95, callgetter:int32(Main::get_myPlayer))
	stloc:int32(var_31_9F, callgetter:int32(Player::get_tileRangeY))
	stloc:int32(var_33_A9, callgetter:int32(Player::get_tileRangeX))
	stloc:int32(var_35_B3, callgetter:int32(Player::get_tileRangeY))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x000178C0 File Offset: 0x00015AC0
	public static void DrawAtPosition(QuickActionButton_Layout layout, Microsoft.Xna.Framework.Vector2 position, Microsoft.Xna.Framework.Graphics.Texture2D buttonTexture, GUIQuickActionButton.InteractionState state, float scale)
	{
		int num = 1;
		float scale2 = layout.Scale;
		float pressedScale = layout.PressedScale;
		state.value__ = (int)scale2;
		if (num == 0)
		{
		}
		if (buttonTexture == null)
		{
			Microsoft.Xna.Framework.Graphics.Texture2D texture = layout.BackingDisabled.Texture;
			return;
		}
		Texture_Layout backingNormal = layout.BackingNormal;
		byte a = layout.Color.A;
		Microsoft.Xna.Framework.Graphics.Texture2D texture2 = backingNormal.Texture;
		float scaleSpeed = layout.ScaleSpeed;
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x00017998 File Offset: 0x00015B98
	public static void GetIconFrame(QuickActionButton_Layout.QuickActionControl actionType, [Out] Microsoft.Xna.Framework.Graphics.Texture2D iconTexture, [Out] Rectangle frame)
	{
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x00017A50 File Offset: 0x00015C50
	public static void Draw(QuickActionButton_Layout.QuickActionControl actionType, QuickActionButton_Layout layout, bool pressed, float scale)
	{
		if (layout.Scale == null)
		{
		}
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x00017CCC File Offset: 0x00015ECC
	public static void DrawFrame(QuickActionButton_Layout layout, Microsoft.Xna.Framework.Graphics.Texture2D buttonTexture, Rectangle srcRect, GUIQuickActionButton.InteractionState state, float scale)
	{
		if (!true)
		{
		}
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x00017CDC File Offset: 0x00015EDC
	public static void DrawFrame(QuickActionButton_Layout layout, Microsoft.Xna.Framework.Graphics.Texture2D buttonTexture, Rectangle srcRect, GUIQuickActionButton.InteractionState state, float scale, int itemType, Microsoft.Xna.Framework.Graphics.Color itemColour)
	{
		if (!true)
		{
		}
		float scale2 = layout.Scale;
		float pressedScale = layout.PressedScale;
		itemColour.A = (byte)scale2;
		if (itemType == 0)
		{
			Texture_Layout backingDisabled = layout.BackingDisabled;
			Microsoft.Xna.Framework.Graphics.Color disabledIconColour = layout.DisabledIconColour;
			byte b = layout.DisabledIconColour.B;
			byte r = layout.DisabledIconColour.R;
			byte g = layout.DisabledIconColour.G;
			Microsoft.Xna.Framework.Graphics.Texture2D texture = backingDisabled.Texture;
			return;
		}
		Microsoft.Xna.Framework.Graphics.Color color = layout.Color;
		Texture_Layout backingNormal = layout.BackingNormal;
		Microsoft.Xna.Framework.Graphics.Color iconColour = layout.IconColour;
		byte b2 = layout.IconColour.B;
		byte r2 = layout.IconColour.R;
		byte g2 = layout.IconColour.G;
		Microsoft.Xna.Framework.Graphics.Texture2D texture2 = backingNormal.Texture;
		if (texture2 != null)
		{
			return;
		}
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00017EA0 File Offset: 0x000160A0
	public static void Draw(QuickActionButton_Layout layout, Microsoft.Xna.Framework.Graphics.Texture2D buttonTexture, GUIQuickActionButton.InteractionState state, float scale)
	{
		if (!true)
		{
		}
		float scale2 = layout.Scale;
		float pressedScale = layout.PressedScale;
		if (state == GUIQuickActionButton.InteractionState.Disabled)
		{
			Microsoft.Xna.Framework.Graphics.Texture2D texture = layout.BackingDisabled.Texture;
			return;
		}
		Texture_Layout backingNormal = layout.BackingNormal;
		Microsoft.Xna.Framework.Graphics.Color color = layout.Color;
		Microsoft.Xna.Framework.Graphics.Texture2D texture2 = backingNormal.Texture;
		float scaleSpeed = layout.ScaleSpeed;
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00017FF8 File Offset: 0x000161F8
	private static bool CanInteract(Player player, Item item, Microsoft.Xna.Framework.Graphics.Texture2D iconTexture, Rectangle frame, bool useFrame)
	{
		if (!true)
		{
		}
		bool gameMenu = Main.gameMenu;
		NPC mouseNPC = GUIQuickActionButton.GetMouseNPC();
		int myPlayer = Main.myPlayer;
		int tileTargetX = Player.tileTargetX;
		int tileTargetY = Player.tileTargetY;
		Tile tile;
		ushort type = tile.type;
		int tileTargetX2 = Player.tileTargetX;
		int tileTargetY2 = Player.tileTargetY;
		Tile tile2;
		ushort type2 = tile2.type;
		int tileTargetX3 = Player.tileTargetX;
		int tileTargetY3 = Player.tileTargetY;
		Tile tile3;
		short frameX = tile3.frameX;
		Tile tile4;
		short frameY = tile4.frameY;
		int num = 53;
		int num2 = 54;
		int num3 = TEWeaponsRack.Find(tileTargetX3, tileTargetY3);
		if (num == 0)
		{
		}
		int num7;
		if (num != 0)
		{
			if (num == 0)
			{
			}
			int signHover = Main.signHover;
			if (num == 0)
			{
			}
			int signHover2 = Main.signHover;
			if (num != 0 && num == 0)
			{
				if (num == 0)
				{
				}
				int signHover3 = Main.signHover;
				int signHover4 = Main.signHover;
				Tile tile5;
				ushort type3 = tile5.type;
			}
			int tileTargetX4 = Player.tileTargetX;
			int tileTargetY4 = Player.tileTargetY;
			bool flag = Minecart.CanSwitchTrack(tileTargetX4, tileTargetY4);
			if (num2 == 0)
			{
			}
			int tileTargetX5 = Player.tileTargetX;
			int tileTargetY5 = Player.tileTargetY;
			Tile tile6;
			ushort type4 = tile6.type;
			int tileTargetX6 = Player.tileTargetX;
			int tileTargetY6 = Player.tileTargetY;
			Tile tile7;
			short frameX2 = tile7.frameX;
			Tile tile8;
			short frameY2 = tile8.frameY;
			int num4 = 36409;
			int num5 = TEItemFrame.Find(tileTargetX6, tileTargetY6);
			if (num4 == 0)
			{
			}
			if (num5 != 0)
			{
			}
			if (num2 == 0)
			{
			}
			int tileTargetX7 = Player.tileTargetX;
			int tileTargetY7 = Player.tileTargetY;
			Tile tile9;
			ushort type5 = tile9.type;
			if (num2 == 0)
			{
			}
			int tileTargetX8 = Player.tileTargetX;
			int tileTargetY8 = Player.tileTargetY;
			Tile tile10;
			ushort type6 = tile10.type;
			int num6 = NPC.TypeToDefaultHeadIndex(num7);
		}
		int num8 = NPC.TypeToDefaultHeadIndex(num7);
		if (num2 == 0)
		{
		}
		int tileTargetX9 = Player.tileTargetX;
		int tileTargetY9 = Player.tileTargetY;
		Tile tile11;
		ushort type7 = tile11.type;
		float cursorScale = Main.cursorScale;
		string text = 1.ToString();
		Debug.LogError("Invalid icon type " + text);
		int signHover5 = Main.signHover;
		int signHover6 = Main.signHover;
		Tile tile12;
		ushort type8 = tile12.type;
		bool drawToolModeUI = WiresUI.Settings.DrawToolModeUI;
		WiresUI.Settings.MultiToolMode toolMode = WiresUI.Settings.ToolMode;
		int num9 = 56;
		int num10 = 48;
		if (num9 == 0)
		{
		}
		if (num9 == 0)
		{
		}
		if (num9 == 0)
		{
		}
		int signHover7 = Main.signHover;
		int signHover8 = Main.signHover;
		Tile tile13;
		short frameX3 = tile13.frameX;
		long num11 = 0L;
		if (num11 == 0L)
		{
		}
		if (num11 == 0L)
		{
		}
		if (num10 == 0)
		{
		}
		if (num11 == 0L || num10 == 0)
		{
		}
		int num12 = 1;
		if (num12 == 0)
		{
		}
		VirtualControllerInputState.Category itemCategory = VirtualControllerInputState.GetItemCategory(0);
		if (num12 != 0)
		{
		}
		if (num12 == 0)
		{
		}
		if (num12 == 0)
		{
		}
		if (num12 == 0)
		{
		}
		if (num12 == 0)
		{
		}
		while (num12 != 0)
		{
		}
		if (num12 == 0)
		{
		}
		throw new InvalidCastException();
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x000182C0 File Offset: 0x000164C0
	private static bool CanFire(Player player, Item selectedItem)
	{
		if (player != null)
		{
			return;
		}
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x000182D4 File Offset: 0x000164D4
	public static bool CanHeal(Player player, Item bestHealItem)
	{
		/*
An exception occurred when decompiling this method (060006F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIQuickActionButton::CanHeal(Terraria.Player,Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:Player[exp:bool](player)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x000182E8 File Offset: 0x000164E8
	public static bool CanMana(Player player, Item bestManaItem)
	{
		if (player != null)
		{
		}
		return true;
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x000182FC File Offset: 0x000164FC
	public static bool CanBuff(Player player)
	{
		bool flag;
		return flag;
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x0001830C File Offset: 0x0001650C
	public static bool CanMount(Player player, Item quickMountItem)
	{
		bool flag;
		return player != null || flag;
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x00018324 File Offset: 0x00016524
	public static bool IsMounted(Player player)
	{
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x000021DB File Offset: 0x000003DB
	private static bool CanGrappleSelect(Player player, Item grappleItem)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x00018334 File Offset: 0x00016534
	public static bool IsCursorOverExpanded(Microsoft.Xna.Framework.Vector2 position, QuickActionButton_Layout layout, float expanded)
	{
		bool flag;
		return flag;
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x00018344 File Offset: 0x00016544
	public static bool IsCursorOver(Microsoft.Xna.Framework.Vector2 position, QuickActionButton_Layout layout)
	{
		bool flag;
		return flag;
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00018354 File Offset: 0x00016554
	public static bool IsCursorOverAtPosition(Microsoft.Xna.Framework.Vector2 position, QuickActionButton_Layout layout, Microsoft.Xna.Framework.Vector2 controlPosition)
	{
		bool flag;
		return flag;
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00018364 File Offset: 0x00016564
	public static bool RegisterPickingRegion(QuickActionButton_Layout layout)
	{
		bool flag;
		return flag;
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x00018374 File Offset: 0x00016574
	// Note: this type is marked as 'beforefieldinit'.
	static GUIQuickActionButton()
	{
	}

	// Token: 0x0400056A RID: 1386
	public static bool ForceOverrideState;

	// Token: 0x0400056B RID: 1387
	public static GUIQuickActionButton.InteractionState ForcedState;

	// Token: 0x0400056C RID: 1388
	private static Microsoft.Xna.Framework.Graphics.Texture2D _smallAxisOuter;

	// Token: 0x0400056D RID: 1389
	private static Microsoft.Xna.Framework.Graphics.Texture2D _axisInner;

	// Token: 0x0400056E RID: 1390
	private static Microsoft.Xna.Framework.Graphics.Texture2D _jump;

	// Token: 0x0400056F RID: 1391
	private static Microsoft.Xna.Framework.Graphics.Texture2D _grappleAxis;

	// Token: 0x04000570 RID: 1392
	private static Microsoft.Xna.Framework.Graphics.Texture2D _grappleFire;

	// Token: 0x04000571 RID: 1393
	public static Microsoft.Xna.Framework.Graphics.Texture2D _unbound;

	// Token: 0x04000572 RID: 1394
	public static Microsoft.Xna.Framework.Graphics.Texture2D _zoomIn;

	// Token: 0x04000573 RID: 1395
	public static Microsoft.Xna.Framework.Graphics.Texture2D _zoomOut;

	// Token: 0x04000574 RID: 1396
	public static Microsoft.Xna.Framework.Graphics.Texture2D _zoomDefault;

	// Token: 0x04000575 RID: 1397
	public static Microsoft.Xna.Framework.Graphics.Texture2D _mapZoomIn;

	// Token: 0x04000576 RID: 1398
	public static Microsoft.Xna.Framework.Graphics.Texture2D _mapZoomOut;

	// Token: 0x04000577 RID: 1399
	public static Microsoft.Xna.Framework.Graphics.Texture2D _mapZoomDefault;

	// Token: 0x04000578 RID: 1400
	public static Microsoft.Xna.Framework.Graphics.Texture2D _minimapZoomIn;

	// Token: 0x04000579 RID: 1401
	public static Microsoft.Xna.Framework.Graphics.Texture2D _minimapZoomOut;

	// Token: 0x0400057A RID: 1402
	public static Microsoft.Xna.Framework.Graphics.Texture2D _minimapZoomDefault;

	// Token: 0x0400057B RID: 1403
	public static Microsoft.Xna.Framework.Graphics.Texture2D _smartCursorOn;

	// Token: 0x0400057C RID: 1404
	public static Microsoft.Xna.Framework.Graphics.Texture2D _smartCursorOff;

	// Token: 0x0400057D RID: 1405
	public static Microsoft.Xna.Framework.Graphics.Texture2D _autoFireOn;

	// Token: 0x0400057E RID: 1406
	public static Microsoft.Xna.Framework.Graphics.Texture2D _autoFireOff;

	// Token: 0x0400057F RID: 1407
	private static Microsoft.Xna.Framework.Graphics.Texture2D _autoSelect;

	// Token: 0x04000580 RID: 1408
	private static Microsoft.Xna.Framework.Graphics.Texture2D _interact;

	// Token: 0x04000581 RID: 1409
	private static Microsoft.Xna.Framework.Graphics.Texture2D _fire;

	// Token: 0x04000582 RID: 1410
	public static Microsoft.Xna.Framework.Graphics.Texture2D _map;

	// Token: 0x04000583 RID: 1411
	public static Microsoft.Xna.Framework.Graphics.Texture2D _mapOpen;

	// Token: 0x04000584 RID: 1412
	public static Microsoft.Xna.Framework.Graphics.Texture2D _combatTargetLockOn;

	// Token: 0x04000585 RID: 1413
	public static Microsoft.Xna.Framework.Graphics.Texture2D _combatTargetIndicator;

	// Token: 0x04000586 RID: 1414
	private static Microsoft.Xna.Framework.Graphics.Texture2D _inventory;

	// Token: 0x04000587 RID: 1415
	private static Microsoft.Xna.Framework.Graphics.Texture2D _inventoryOpen;

	// Token: 0x04000588 RID: 1416
	public static Microsoft.Xna.Framework.Graphics.Texture2D _controlsProfile;

	// Token: 0x04000589 RID: 1417
	private static Microsoft.Xna.Framework.Graphics.Texture2D[] _uncollecedHeads;

	// Token: 0x02000115 RID: 277
	public enum InteractionState
	{
		// Token: 0x0400058B RID: 1419
		Disabled,
		// Token: 0x0400058C RID: 1420
		Pressed,
		// Token: 0x0400058D RID: 1421
		Normal
	}
}
