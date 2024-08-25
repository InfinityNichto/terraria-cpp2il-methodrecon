using System;
using System.Collections.Generic;
using System.Globalization;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.Graphics;
using Terraria.IO;

// Token: 0x02000279 RID: 633
public class GUIPlayerSelectMenu
{
	// Token: 0x06000E43 RID: 3651 RVA: 0x00045A2C File Offset: 0x00043C2C
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return true;
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x00045A3C File Offset: 0x00043C3C
	public static void LoadContent(ContentManager content)
	{
		Texture2D texture2D = content.Load<Texture2D>("Images/UI/Divider");
		Texture2D texture2D2 = content.Load<Texture2D>("Images/UI/ButtonCloudActive");
		Texture2D texture2D3 = content.Load<Texture2D>("Images/UI/ButtonCloudInactive");
		Texture2D texture2D4 = content.Load<Texture2D>("Images/UI/ButtonFavoriteActive");
		Texture2D texture2D5 = content.Load<Texture2D>("Images/UI/ButtonFavoriteInactive");
		Texture2D texture2D6 = content.Load<Texture2D>("Images/UI/ButtonPlay");
		Texture2D texture2D7 = content.Load<Texture2D>("Images/UI/ButtonDelete");
	}

	// Token: 0x06000E45 RID: 3653 RVA: 0x00045AA0 File Offset: 0x00043CA0
	public void ActionNew()
	{
		Main.menuMode = 2;
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x06000E46 RID: 3654 RVA: 0x00045AB4 File Offset: 0x00043CB4
	private GUIContollerTransactionButtonList PlayerListOptionsController
	{
		get
		{
			GUIContollerTransactionButtonList playerListOptionsController = this._playerListOptionsController;
			if (playerListOptionsController != null || (playerListOptionsController != null && playerListOptionsController == null) || playerListOptionsController == null || playerListOptionsController != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}
	}

	// Token: 0x06000E47 RID: 3655 RVA: 0x00045ADC File Offset: 0x00043CDC
	private void DrawPlayerSync()
	{
		if (!true)
		{
		}
		if (6899 == 0)
		{
		}
	}

	// Token: 0x06000E48 RID: 3656 RVA: 0x00045AF4 File Offset: 0x00043CF4
	private bool DrawMenuButton(string label, TransactionButton_Layout buttonLayout, float scale, bool disabled)
	{
		/*
An exception occurred when decompiling this method (06000E48)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIPlayerSelectMenu::DrawMenuButton(System.String,TransactionButton_Layout,System.Single,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0029:
	call:void(SpriteBatchItem::DisabledClipping)
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

	// Token: 0x06000E49 RID: 3657 RVA: 0x000021DB File Offset: 0x000003DB
	private bool DrawMenuButton(ControllerActionButton action, string label, TransactionButton_Layout buttonLayout, float scale, bool disabled)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000E4A RID: 3658 RVA: 0x00045B34 File Offset: 0x00043D34
	public Vector2 ItemSize(int index)
	{
		/*
An exception occurred when decompiling this method (06000E4A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 GUIPlayerSelectMenu::ItemSize(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GUIPlayerSelectMenu::SelectedItem, ldloc:GUIPlayerSelectMenu(this)))
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

	// Token: 0x06000E4B RID: 3659 RVA: 0x000021DB File Offset: 0x000003DB
	public void SelectAndHighlight(PlayerFileData playerData)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x000021DB File Offset: 0x000003DB
	public void Draw()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000E4D RID: 3661 RVA: 0x00045B48 File Offset: 0x00043D48
	public void Back()
	{
		bool flag = this.CloseNameEditIf();
		GUIControllerPlayerSelect controllerInput = this._controllerInput;
		Main.menuMode = 0;
		if (controllerInput != null)
		{
			if (controllerInput == null)
			{
			}
			if (controllerInput == null)
			{
			}
			return;
		}
	}

	// Token: 0x06000E4E RID: 3662 RVA: 0x00045B74 File Offset: 0x00043D74
	private void UpdateAnim(Player player, bool animated)
	{
		if (!true)
		{
		}
		int num = 9363;
		int miscCounter = player.miscCounter;
		int legs = player.legs;
		player.headFrame.Y = num;
		player.legFrame.Y = num;
		player.bodyFrame.Y = num;
		player.miscCounter = num;
		int height = player.legFrame.Height;
		float y = player.velocity.Y;
		int num2 = true.ToInt();
		player.legFrame.Y = 1;
		int y2 = player.bodyFrame.Y;
		int height2 = player.bodyFrame.Height;
		if (miscCounter == 0)
		{
		}
		int height3 = player.legFrame.Height;
		player.legFrame.Y = height3;
	}

	// Token: 0x06000E4F RID: 3663 RVA: 0x00045C3C File Offset: 0x00043E3C
	private void DrawPlayer(Player player, Projectile pet, bool animated)
	{
		if (player.dead)
		{
			player.PlayerFrame();
		}
		float x = this.CharacterOffset.X;
		float y = this.CharacterOffset.Y;
		if (pet != null)
		{
			int height = player.height;
		}
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x00045C80 File Offset: 0x00043E80
	public void DrawPet(Player player, Projectile proj, Vector2 playerPosition, bool animated)
	{
		if (!true)
		{
		}
		if (proj.height == 0)
		{
		}
		Vector2 screenPosition = Main.screenPosition;
		int num = 1;
		proj.direction = num;
		int myPlayer = Main.myPlayer;
		proj.owner = myPlayer;
		int myPlayer2 = Main.myPlayer;
		int myPlayer3 = Main.myPlayer;
		if (player == null || player != null)
		{
			Vector2 oldPosition = player.oldPosition;
			int myPlayer4 = Main.myPlayer;
			if (playerPosition == null || playerPosition != null)
			{
				return;
			}
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x00045D04 File Offset: 0x00043F04
	public void DrawPlayerUI(Player player, Vector2 origin, Vector2 size)
	{
		int num = 17004;
		int width = player.width;
		int height = player.height;
		if (num == 0)
		{
		}
		player.UpdateDyes();
		int body = player.body;
		bool male = player.Male;
		int num2 = 24;
		if (player.sitting == null)
		{
			int cBody = player.cBody;
			player.back = (sbyte)num2;
			player.cBack = cBody;
		}
		if (num2 == 0)
		{
		}
		int cBody2 = player.cBody;
		player.front = (sbyte)num2;
		player.cFront = cBody2;
		if (num2 == 0)
		{
		}
		sbyte back = player.back;
		sbyte front = player.front;
		PlayerSittingHelper sitting = player.sitting;
		if (sitting == null)
		{
			player.front = back;
			int cBody3 = player.cBody;
			player.cFront = cBody3;
			player.back = sitting;
			player.cBack = cBody3;
		}
		Item[] inventory = player.inventory;
		int heldProj = player.heldProj;
		Item blankItem = this._blankItem;
		if (blankItem == null || blankItem != null)
		{
			Camera camera = Main.Camera;
			Vector2 screenPosition = Main.screenPosition;
			if (!true)
			{
			}
			bool isSitting = sitting.isSitting;
			float x = sitting.offsetForSeat.X;
			if (sitting != null)
			{
			}
			return;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x06000E52 RID: 3666 RVA: 0x00045E50 File Offset: 0x00044050
	public void RefreshPlayers()
	{
		if (!true)
		{
		}
		PlayerFileData activePlayerFileData = Main.ActivePlayerFileData;
		int num = 1;
		string fileName = activePlayerFileData.GetFileName(num != 0);
		Main.LoadPlayers();
		int size = this.SortedPlayerData._size;
		string text;
		bool flag = text == fileName;
		List<PlayerFileData> sortedPlayerData = this.SortedPlayerData;
		int size2 = this.SortedPlayerData._size;
	}

	// Token: 0x06000E53 RID: 3667 RVA: 0x00045EAC File Offset: 0x000440AC
	private void OpenNameEdit()
	{
		List<PlayerFileData> sortedPlayerData = this.SortedPlayerData;
		int selectedItem = this.SelectedItem;
		int selectedItem2 = this.SelectedItem;
		this.SelectedItemForTextEdit = selectedItem2;
	}

	// Token: 0x06000E54 RID: 3668 RVA: 0x00045ED8 File Offset: 0x000440D8
	private void CloseNameEditAndSave()
	{
		string text;
		int stringLength = text._stringLength;
		List<PlayerFileData> sortedPlayerData = this.SortedPlayerData;
		int selectedItem = this.SelectedItem;
		List<PlayerFileData> sortedPlayerData2 = this.SortedPlayerData;
		int selectedItem2 = this.SelectedItem;
		List<PlayerFileData> sortedPlayerData3 = this.SortedPlayerData;
		int selectedItem3 = this.SelectedItem;
	}

	// Token: 0x06000E55 RID: 3669 RVA: 0x00045F1C File Offset: 0x0004411C
	private bool CloseNameEditIf()
	{
		return true;
	}

	// Token: 0x06000E56 RID: 3670 RVA: 0x00045F2C File Offset: 0x0004412C
	private void CloseNameEdit()
	{
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x00045F3C File Offset: 0x0004413C
	private void PlayerDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		int selectedItem = this.SelectedItem;
		int selectedItem2 = this.SelectedItem;
		int num = this.playerOver;
	}

	// Token: 0x06000E58 RID: 3672 RVA: 0x000021DB File Offset: 0x000003DB
	public void SortPlayers()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000E59 RID: 3673 RVA: 0x0004628C File Offset: 0x0004448C
	private int SortEntry(PlayerFileData a, PlayerFileData b)
	{
		bool isFavorite = a._isFavorite;
		bool isFavorite2 = b._isFavorite;
		if ((!isFavorite || !isFavorite2) && isFavorite2)
		{
			return 1;
		}
		string name = a.Name;
		string name2 = b.Name;
		int num;
		return num;
	}

	// Token: 0x06000E5A RID: 3674 RVA: 0x000021DB File Offset: 0x000003DB
	private float PlayerScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000E5B RID: 3675 RVA: 0x000462C4 File Offset: 0x000444C4
	private void PlayerOver(int index)
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		this.playerOver = index;
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x000462E8 File Offset: 0x000444E8
	public int CompareNatural(string strA, string strB)
	{
		if (!true)
		{
		}
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		int num;
		return num;
	}

	// Token: 0x06000E5D RID: 3677 RVA: 0x00046304 File Offset: 0x00044504
	public int CompareNatural(string strA, string strB, CultureInfo culture, CompareOptions options)
	{
		long num2;
		for (;;)
		{
			int stringLength = strB._stringLength;
			int stringLength2 = strA._stringLength;
			long num = 0L;
			num2 = 0L;
			char c = strA[(int)num];
			if (stringLength2 == 0)
			{
			}
			bool flag = char.IsDigit(c);
			bool flag2 = char.IsDigit(strB[(int)num2]);
			char c2 = strA[(int)num];
			char c3 = strA[(int)num];
			if (stringLength2 == 0)
			{
			}
			double numericValue = char.GetNumericValue(c3);
			char c4 = strB[(int)num2];
			double numericValue2 = char.GetNumericValue(strB[(int)num2]);
			int stringLength3 = strA._stringLength;
			char c5 = strA[(int)num];
			int stringLength4 = strA._stringLength;
			int stringLength5 = strB._stringLength;
			char c6 = strB[(int)num2];
			int stringLength6 = strB._stringLength;
			int stringLength7 = strA._stringLength;
			char c7 = strA[(int)num2];
			if (stringLength2 == 0)
			{
			}
			bool flag3 = char.IsDigit(c7);
			long num3 = 0L;
			int stringLength8 = strB._stringLength;
			char c8 = strB[(int)num2];
			if (stringLength2 == 0)
			{
			}
			bool flag4 = char.IsDigit(c8);
			if (num3 != 0L)
			{
				goto IL_00EF;
			}
			if (c4 != '\0')
			{
				goto IL_010F;
			}
			long num4;
			if (num3 == 0L)
			{
				num4 = 0L;
				while (num3 == 0L)
				{
				}
				goto IL_00EF;
			}
			goto IL_0130;
			IL_0139:
			string text5;
			if (num4 != 0L)
			{
				char c9 = strB[(int)num2];
				int num5 = 1;
				int stringLength9 = strA._stringLength;
				char c10 = strA[(int)num];
				if (stringLength9 == 0)
				{
				}
				bool flag5 = char.IsDigit(c10);
				int stringLength10 = strB._stringLength;
				char c11 = strB[(int)num2];
				if (stringLength9 == 0)
				{
				}
				bool flag6 = char.IsDigit(c11);
				int stringLength11 = strB._stringLength;
				if (num4 == 0L)
				{
					goto IL_01EA;
				}
				string text = strA.Substring((int)num, num5);
				string text2 = strB.Substring((int)num3, (int)c11);
				string text3 = text + "1";
				string text4 = text2 + "2";
				text5 = text + "2";
				string text6 = text2 + "1";
			}
			if (text5 != null)
			{
				continue;
			}
			IL_01EA:
			int stringLength12 = strB._stringLength;
			int stringLength13 = strA._stringLength;
			if (stringLength12 != 0)
			{
				break;
			}
			continue;
			IL_010F:
			char c12 = strB[(int)num2];
			int num6;
			if (num6 == 0)
			{
			}
			double numericValue3 = char.GetNumericValue(c12);
			if (num3 == 0L)
			{
				goto IL_0139;
			}
			IL_0130:
			char c13 = strA[(int)num];
			goto IL_0139;
			IL_00EF:
			char c14 = strA[(int)num];
			if (stringLength2 == 0)
			{
			}
			double numericValue4 = char.GetNumericValue(c14);
			num6 = 32768;
			while (num4 == 0L)
			{
			}
			goto IL_010F;
		}
		while (num2 == 0L)
		{
		}
		return 1;
	}

	// Token: 0x06000E5E RID: 3678 RVA: 0x00046518 File Offset: 0x00044718
	public GUIPlayerSelectMenu()
	{
		if ("" == null)
		{
		}
		this.LastTouchTime = "";
		if ("" == null)
		{
		}
		if (!true)
		{
		}
		this.LastTouchMouse = 1;
		this.CharacterOffset = 1;
		this.playerOver = 1;
		base..ctor();
	}

	// Token: 0x04001A0E RID: 6670
	private const double DOUBLE_CLICK_TIME = 500.0;

	// Token: 0x04001A0F RID: 6671
	private const double SINGLE_CLICK_TIME = 350.0;

	// Token: 0x04001A10 RID: 6672
	private const float SINGLE_CLICK_DISTANCE = 30f;

	// Token: 0x04001A11 RID: 6673
	private float TitleScale;

	// Token: 0x04001A12 RID: 6674
	private float BackScale;

	// Token: 0x04001A13 RID: 6675
	private float NewScale;

	// Token: 0x04001A14 RID: 6676
	private float PlayScale;

	// Token: 0x04001A15 RID: 6677
	private float EditNameScale;

	// Token: 0x04001A16 RID: 6678
	private float OptionsScale;

	// Token: 0x04001A17 RID: 6679
	private float DeleteScale;

	// Token: 0x04001A18 RID: 6680
	private float FavoriteScale;

	// Token: 0x04001A19 RID: 6681
	public float ScrollOffset;

	// Token: 0x04001A1A RID: 6682
	private float ScrollMomentum;

	// Token: 0x04001A1B RID: 6683
	private int ScrollDragging;

	// Token: 0x04001A1C RID: 6684
	private Vector2 DragOffset;

	// Token: 0x04001A1D RID: 6685
	public bool SyncingPlayers;

	// Token: 0x04001A1E RID: 6686
	private static Texture2D _dividerTexture;

	// Token: 0x04001A1F RID: 6687
	private static Texture2D _buttonCloudActiveTexture;

	// Token: 0x04001A20 RID: 6688
	private static Texture2D _buttonCloudInactiveTexture;

	// Token: 0x04001A21 RID: 6689
	private static Texture2D _buttonFavoriteActiveTexture;

	// Token: 0x04001A22 RID: 6690
	private static Texture2D _buttonFavoriteInactiveTexture;

	// Token: 0x04001A23 RID: 6691
	private static Texture2D _buttonPlayTexture;

	// Token: 0x04001A24 RID: 6692
	private static Texture2D _buttonDeleteTexture;

	// Token: 0x04001A25 RID: 6693
	private int _playerCount;

	// Token: 0x04001A26 RID: 6694
	public List<PlayerFileData> SortedPlayerData;

	// Token: 0x04001A27 RID: 6695
	private Rectangle SelectedItemRegion;

	// Token: 0x04001A28 RID: 6696
	public int SelectedItem = 1;

	// Token: 0x04001A29 RID: 6697
	public string SelectedItemPlayer = "";

	// Token: 0x04001A2A RID: 6698
	private DateTime LastSelectTime;

	// Token: 0x04001A2B RID: 6699
	private DateTime LastTouchTime;

	// Token: 0x04001A2C RID: 6700
	private Vector2 LastTouchMouse;

	// Token: 0x04001A2D RID: 6701
	private float NameScale;

	// Token: 0x04001A2E RID: 6702
	public bool allowItemClicking;

	// Token: 0x04001A2F RID: 6703
	private GUIControllerPlayerSelect _controllerInput;

	// Token: 0x04001A30 RID: 6704
	private GUIContollerTransactionButtonList _playerListOptionsController;

	// Token: 0x04001A31 RID: 6705
	private Rectangle fullClipRegion;

	// Token: 0x04001A32 RID: 6706
	private Rectangle dragClipRegion;

	// Token: 0x04001A33 RID: 6707
	private Vector2 CharacterOffset;

	// Token: 0x04001A34 RID: 6708
	private Item _blankItem;

	// Token: 0x04001A35 RID: 6709
	private int SelectedItemForTextEdit;

	// Token: 0x04001A36 RID: 6710
	private int playerOver;
}
