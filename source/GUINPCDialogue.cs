using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;

// Token: 0x0200015E RID: 350
public class GUINPCDialogue
{
	// Token: 0x0600098E RID: 2446 RVA: 0x0002BC74 File Offset: 0x00029E74
	public void LoadRegion()
	{
		float y = this.CachedTextSize.Y;
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x0002BC94 File Offset: 0x00029E94
	public bool IsOver(Vector2 cursorPosition)
	{
		/*
An exception occurred when decompiling this method (0600098F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUINPCDialogue::IsOver(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, callgetter:string(GUINPCDialogue::get_DisplayString, ldloc:GUINPCDialogue(this)))
	call:void(GUINPCDialogue::UpdateText, ldloc:GUINPCDialogue(this), ldloc:string(var_0_06))
	stloc:float32(var_1_19, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](GUINPCDialogue::CachedTextSize, ldloc:GUINPCDialogue(this))))
	stloc:bool(var_5_22, callgetter:bool(ControllerActionManager::get_AnyControllerConnected))
	stloc:int32(var_9_2D, ldfld:int32(GUINPCDialogue::NumberOfOptions, ldloc:GUINPCDialogue(this)))
	stloc:int32(var_12_35, ldfld:int32(GUINPCDialogue::NumberOfOptions, ldloc:GUINPCDialogue(this)))
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

	// Token: 0x06000990 RID: 2448 RVA: 0x0002BCDC File Offset: 0x00029EDC
	public void Close()
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		Main.npcChatCornerItem = 0;
		bool editSign = Main.editSign;
		Main.CloseKeyboard();
		Main.editSign = false;
		Main.npcChatText = "";
		Main.clrInput();
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x0002BD2C File Offset: 0x00029F2C
	private void SetupLastLineAddition()
	{
		int num = 1;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (num == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
		int myPlayer3 = Main.myPlayer;
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x0002BD88 File Offset: 0x00029F88
	private void ClearLastLineAddition()
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000993 RID: 2451 RVA: 0x0002BD98 File Offset: 0x00029F98
	private void UpdateText(string textValue)
	{
		bool flag = this.CachedTextValue != textValue;
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x0002BF60 File Offset: 0x0002A160
	private void SetupButtonText(string focusText, Texture2D option1Tex, string focusText3, Texture2D option2Tex, int cost, bool showHappiness)
	{
		int myPlayer = Main.myPlayer;
		bool editSign = Main.editSign;
		string textValue = Language.GetTextValue("LegacyInterface.47");
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x0002C484 File Offset: 0x0002A684
	public void LoadPanelRegion()
	{
		float y = this.CachedTextSize.Y;
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x0002C4A4 File Offset: 0x0002A6A4
	public Rectangle GetRegion()
	{
		float y = this.CachedTextSize.Y;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x0002C4C0 File Offset: 0x0002A6C0
	public void CloseClicked()
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		Main.npcChatCornerItem = 0;
		bool editSign = Main.editSign;
		Main.CloseKeyboard();
		Main.editSign = false;
		Main.npcChatText = "";
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x0002C50C File Offset: 0x0002A70C
	public void Option1Clicked(int healCost)
	{
		int num = 1;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		bool editSign = Main.editSign;
		if (num != 0)
		{
			int myPlayer2 = Main.myPlayer;
			string npcChatText = Main.npcChatText;
			Sign.TextSign(editSign ? 1 : 0, npcChatText);
			Main.editSign = false;
			bool netClient = Main.NetClient;
			Main.clrInput();
			Main.CloseKeyboard();
			return;
		}
		Main.editSign = true;
		Main.clrInput();
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x0002CBBC File Offset: 0x0002ADBC
	public void HappinessClicked()
	{
		if (!true)
		{
		}
		Main.npcChatCornerItem = 0;
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x0002CBE8 File Offset: 0x0002ADE8
	public bool CanDryadPlayStardewAnimation(Player player, NPC npc)
	{
		bool isAir = player.HeldItem.IsAir;
		float[] ai = npc.ai;
		return isAir;
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x0002CC0C File Offset: 0x0002AE0C
	public void Option2Clicked()
	{
		int num = 1;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (num == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
		if (num == 0)
		{
		}
		Main.npcChatText = Lang.GetDryadWorldStatusDialog(true);
		Player localPlayer = Main.LocalPlayer;
		int myPlayer3 = Main.myPlayer;
		Player localPlayer2 = Main.LocalPlayer;
		int num2 = 5275;
		int num3 = 1;
		long num4 = 0L;
		bool flag = localPlayer2.ConsumeItem(num2, num3 != 0, num4 != 0L);
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x0002CE1C File Offset: 0x0002B01C
	private void DrawSign()
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		Tile tile;
		ushort type = tile.type;
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x0002CEA0 File Offset: 0x0002B0A0
	private void DrawNPC()
	{
		int num = 1;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		Rectangle region = this.GetRegion();
		if (num == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x0002CF38 File Offset: 0x0002B138
	private void DrawPartyHat(NPC n, SpriteEffects spriteEffects, Vector2 position, float scale)
	{
		bool flag = n.UsesPartyHat();
		int y = n.frame.Y;
		int height = n.frame.Height;
		if (height == 0)
		{
		}
		PartyHatColor partyHatColor = n.GetPartyHatColor();
		if (height == 0)
		{
		}
		int type = n.type;
		int spriteDirection = n.spriteDirection;
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x0600099F RID: 2463 RVA: 0x0002D02C File Offset: 0x0002B22C
	private string DisplayString
	{
		get
		{
			if (!true)
			{
			}
			string npcChatText = Main.npcChatText;
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
			int myPlayer3 = Main.myPlayer;
			Player localPlayer = Main.LocalPlayer;
			int myPlayer4 = Main.myPlayer;
			return Main.npcChatText;
		}
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x0002D104 File Offset: 0x0002B304
	public void Draw()
	{
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		string displayString = this.DisplayString;
		this.UpdateText(displayString);
		float y = this.CachedTextSize.Y;
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
		GUIControllerNPCDialogue controller = this._controller;
		this._controller.Activate();
		this.DrawNPC();
		float y2 = this.CachedTextSize.Y;
		int myPlayer3 = Main.myPlayer;
		bool editSign = Main.editSign;
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x0002D288 File Offset: 0x0002B488
	public GUINPCDialogue()
	{
	}

	// Token: 0x0400095C RID: 2396
	private float CachedLayoutSize;

	// Token: 0x0400095D RID: 2397
	private float CachedLayoutWrapSize;

	// Token: 0x0400095E RID: 2398
	private int CachedMinTextHeight;

	// Token: 0x0400095F RID: 2399
	private Vector2 CachedTextSize;

	// Token: 0x04000960 RID: 2400
	private string CachedTextValue;

	// Token: 0x04000961 RID: 2401
	private string CachedTextMultilineValue;

	// Token: 0x04000962 RID: 2402
	private string textBlinker;

	// Token: 0x04000963 RID: 2403
	public int NumberOfOptions;

	// Token: 0x04000964 RID: 2404
	public bool ShowHappiness;

	// Token: 0x04000965 RID: 2405
	public GUIControllerNPCDialogue _controller;
}
