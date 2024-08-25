using System;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.UI;
using Terraria.Localization;
using Terraria.UI;

// Token: 0x0200028C RID: 652
public class GUIPageOptions
{
	// Token: 0x06000F15 RID: 3861 RVA: 0x0004B410 File Offset: 0x00049610
	public void PushLeft()
	{
	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x0004B420 File Offset: 0x00049620
	public void PopLeft()
	{
	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x0004B430 File Offset: 0x00049630
	public void PushRight()
	{
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x0004B440 File Offset: 0x00049640
	public void PopRight()
	{
	}

	// Token: 0x17000186 RID: 390
	// (get) Token: 0x06000F19 RID: 3865 RVA: 0x0004B450 File Offset: 0x00049650
	private bool canDepositAllValue
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000F19)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIPageOptions::get_canDepositAllValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0012:
	stloc:bool(var_4_18, call:bool(ChestUI::CanBeDepositied, ldloc:int64[exp:int32](var_3_0E)))
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
	}

	// Token: 0x06000F1A RID: 3866 RVA: 0x0004B47C File Offset: 0x0004967C
	public void RefreshLangStrings()
	{
		int num = this.lastLang;
		int legacyId = Language.ActiveCulture.LegacyId;
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		bool flag = this.usingController;
		ItemTooltip.InvalidateTooltips();
		int legacyId2 = Language.ActiveCulture.LegacyId;
		this.lastLang = legacyId2;
		bool anyControllerConnected2 = ControllerActionManager.AnyControllerConnected;
		this.usingController = legacyId2 != 0;
		string textValue = Language.GetTextValue("ControllerMappings.ChestRename");
		if (textValue == null || textValue != null)
		{
			string textValue2 = Language.GetTextValue("ControllerMappings.ChestRestock");
			if (textValue2 == null || textValue2 != null)
			{
				string textValue3 = Language.GetTextValue("ControllerMappings.ChestQuickStack");
				if (textValue3 == null || textValue3 != null)
				{
					string textValue4 = Language.GetTextValue("ControllerMappings.ChestDepositAll");
					if (textValue4 == null || textValue4 != null)
					{
						string textValue5 = Language.GetTextValue("ControllerMappings.ChestLootAll");
						return;
					}
				}
			}
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x0004B5B0 File Offset: 0x000497B0
	public void DrawFavouriteOption()
	{
		int num = 1;
		this.LoadLeftItemRegion();
		if (num != 0)
		{
			return;
		}
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		int myPlayer3 = Main.myPlayer;
		int myPlayer4 = Main.myPlayer;
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (this != null)
		{
			!0 instance2 = PageControllerLayoutDefinition.Instance;
			return;
		}
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		!0 instance4 = PageControllerLayoutDefinition.Instance;
		if (PageControllerLayoutDefinition.Instance == null)
		{
		}
		int num2 = 1;
		int num3 = 1;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		long num7 = 0L;
		Texture2D texture2D;
		Rectangle rectangle = texture2D.Frame(num2, num3, (int)num4, (int)num5, (int)num6, (int)num7);
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x0004B690 File Offset: 0x00049890
	public void DrawQuickStack()
	{
		this.LoadLeftItemRegion();
		!0 instance = PageControllerLayoutDefinition.Instance;
		int num = 40;
		bool useCollpasedCoinsAmmo = RightSideHUDAnchorUpdator.UseCollpasedCoinsAmmo;
		string[] array = this.options;
		if (num != 0)
		{
			return;
		}
		bool splitKeyPressed = this.SplitKeyPressed;
		long num2 = 0L;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			bool splitKeyPressed2 = this.SplitKeyPressed;
		}
		bool useCollpasedCoinsAmmo2 = RightSideHUDAnchorUpdator.UseCollpasedCoinsAmmo;
		if (num2 == 0L)
		{
			return;
		}
		int myPlayer = Main.myPlayer;
		if (Main.npcShop != 0)
		{
			int myPlayer2 = Main.myPlayer;
			Recipe.FindRecipes(false);
			return;
		}
		int myPlayer3 = Main.myPlayer;
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x0004B71C File Offset: 0x0004991C
	public void DrawSort()
	{
		this.LoadLeftItemRegion();
		!0 instance = PageControllerLayoutDefinition.Instance;
		bool useCollpasedCoinsAmmo = RightSideHUDAnchorUpdator.UseCollpasedCoinsAmmo;
	}

	// Token: 0x06000F1E RID: 3870 RVA: 0x0004B788 File Offset: 0x00049988
	public void DrawDepositAll()
	{
		this.LoadLeftItemRegion();
		bool canDepositAllValue = this.canDepositAllValue;
	}

	// Token: 0x06000F1F RID: 3871 RVA: 0x0004B828 File Offset: 0x00049A28
	public void DrawSplitStack()
	{
		this.LoadLeftItemRegion();
		bool splitInvKeyPressed = this.SplitInvKeyPressed;
		if (splitInvKeyPressed)
		{
			if (!splitInvKeyPressed)
			{
			}
			bool mouseLeft = Main.mouseLeft;
			if (!splitInvKeyPressed)
			{
			}
			bool mouseLeftRelease = Main.mouseLeftRelease;
			if (this.SplitInvKeyPressed)
			{
				return;
			}
		}
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x0004B868 File Offset: 0x00049A68
	private void LeftItemRegionInitialise()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle;
		Vector2 vector = rectangle.Size();
		bool displayLeftOptionsGlobal = this._displayLeftOptionsGlobal;
		if (displayLeftOptionsGlobal)
		{
			if (!displayLeftOptionsGlobal)
			{
			}
			return;
		}
		if (!displayLeftOptionsGlobal)
		{
		}
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x0004B89C File Offset: 0x00049A9C
	private void LoadLeftItemRegion()
	{
		int num = this.leftItemIndex;
		float x = this.leftItemSpacing.X;
		float y = this.leftItemSpacing.Y;
		if (num == 0)
		{
		}
		float x2 = this.leftItemPosition.X;
		float y2 = this.leftItemPosition.Y;
		float x3 = this.leftItemSize.X;
		float y3 = this.leftItemSize.Y;
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x0004B904 File Offset: 0x00049B04
	private void RightItemRegionInitialise()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle;
		Vector2 vector = rectangle.Size();
		bool displayRightOptionsGlobal = this._displayRightOptionsGlobal;
		if (displayRightOptionsGlobal)
		{
			if (!displayRightOptionsGlobal)
			{
			}
			return;
		}
		if (!displayRightOptionsGlobal)
		{
		}
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x0004B938 File Offset: 0x00049B38
	private void LoadRightItemRegion()
	{
		int num = this.rightItemIndex;
		float x = this.rightItemSpacing.X;
		float y = this.rightItemSpacing.Y;
		if (num == 0)
		{
		}
		float x2 = this.rightItemPosition.X;
		float y2 = this.rightItemPosition.Y;
		float x3 = this.rightItemSize.X;
		float y3 = this.rightItemSize.Y;
	}

	// Token: 0x17000187 RID: 391
	// (get) Token: 0x06000F24 RID: 3876 RVA: 0x000021DB File Offset: 0x000003DB
	public int NumLeftOptions
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x0004B9A0 File Offset: 0x00049BA0
	private bool CanBeOpened(Item SelectedItem)
	{
		/*
An exception occurred when decompiling this method (06000F25)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIPageOptions::CanBeOpened(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Item::type, ldloc:Item(SelectedItem)))
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

	// Token: 0x06000F26 RID: 3878 RVA: 0x0004BA1C File Offset: 0x00049C1C
	public void DrawEquipButton()
	{
		Item item;
		int type = item.type;
		bool accessory = item.accessory;
		if (accessory)
		{
			int stack = item.stack;
			return;
		}
		int stack2 = item.stack;
		this.LoadLeftItemRegion();
		bool drawToolModeUI = WiresUI.Settings.DrawToolModeUI;
		if (accessory)
		{
		}
		this.DrawDepositButton();
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
	}

	// Token: 0x06000F27 RID: 3879 RVA: 0x0004BC24 File Offset: 0x00049E24
	public void DrawDepositButton()
	{
		this.LoadLeftItemRegion();
		!0 instance = PageControllerLayoutDefinition.Instance;
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		if (PageControllerLayoutDefinition.Instance == null)
		{
		}
	}

	// Token: 0x06000F28 RID: 3880 RVA: 0x0004BC94 File Offset: 0x00049E94
	public void ThrowItem(int additionalVelocity = 0)
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		int type = Main.mouseItem.type;
		int stack = Main.mouseItem.stack;
		byte prefix = Main.mouseItem.prefix;
		int num = 32640;
		Main.mouseItem.position = num;
		Item mouseItem = Main.mouseItem;
		if (mouseItem == null || mouseItem != null)
		{
			bool netHost = Main.NetHost;
			int myPlayer2 = Main.myPlayer;
			bool netClient = Main.NetClient;
			Main.mouseItemSourceIndex = 0;
			Recipe.FindRecipes(false);
			return;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x0004BD3C File Offset: 0x00049F3C
	public void DrawLeftThrow()
	{
		bool favorited = Main.mouseItem.favorited;
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x0004BD60 File Offset: 0x00049F60
	public void DrawLeftTrash()
	{
		if (Main.mouseItemSource != null)
		{
			bool favorited = Main.mouseItem.favorited;
			return;
		}
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x0004BDA8 File Offset: 0x00049FA8
	public void DrawLeftDeposit()
	{
		GUITransactionButton.InputState inputState;
		if (inputState != GUITransactionButton.InputState.Clicked)
		{
			return;
		}
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x0004BDBC File Offset: 0x00049FBC
	public void DrawSellButton()
	{
		int myPlayer = Main.myPlayer;
		Item item;
		int type = item.type;
		Item item2;
		int stack = item2.stack;
		Item item3;
		int type2 = item3.type;
		Item item4;
		int type3 = item4.type;
	}

	// Token: 0x06000F2D RID: 3885 RVA: 0x0004BE60 File Offset: 0x0004A060
	public void DrawChestSort()
	{
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x0004BEC4 File Offset: 0x0004A0C4
	public void DrawChestSplitStack()
	{
		this.LoadRightItemRegion();
		bool splitChestKeyPressed = this.SplitChestKeyPressed;
		if (splitChestKeyPressed)
		{
			if (!splitChestKeyPressed)
			{
			}
			bool mouseLeft = Main.mouseLeft;
			if (!splitChestKeyPressed)
			{
			}
			bool mouseLeftRelease = Main.mouseLeftRelease;
			if (this.SplitChestKeyPressed)
			{
				return;
			}
		}
	}

	// Token: 0x06000F2F RID: 3887 RVA: 0x0004BF04 File Offset: 0x0004A104
	public void DrawChestRestock()
	{
		this.LoadRightItemRegion();
		!0 instance = PageControllerLayoutDefinition.Instance;
		int num = 104;
		string[] array = this.options;
		if (num != 0)
		{
			return;
		}
		bool splitKeyPressed = this.SplitKeyPressed;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			bool splitKeyPressed2 = this.SplitKeyPressed;
			if (!splitKeyPressed2)
			{
				if (!splitKeyPressed2)
				{
				}
				Main.mouseLeftRelease = false;
				if (!splitKeyPressed2)
				{
				}
				ChestUI.Restock();
				if (!splitKeyPressed2)
				{
				}
				Recipe.FindRecipes(false);
				return;
			}
		}
	}

	// Token: 0x17000188 RID: 392
	// (get) Token: 0x06000F30 RID: 3888 RVA: 0x0004BF6C File Offset: 0x0004A16C
	private bool CanLootAll
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000F30)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIPageOptions::get_CanLootAll()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003E:
	stloc:int32(var_13_46, callgetter:int32(Main::get_myPlayer))
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
	}

	// Token: 0x06000F31 RID: 3889 RVA: 0x0004BFC8 File Offset: 0x0004A1C8
	public void DrawChestLootAll()
	{
		this.LoadRightItemRegion();
		bool canLootAll = this.CanLootAll;
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x0004C02C File Offset: 0x0004A22C
	public void DrawChestRename()
	{
		int num = 1;
		this.LoadRightItemRegion();
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		!0 instance = PageControllerLayoutDefinition.Instance;
		int num2 = 88;
		string[] array = this.options;
		if (num2 != 0)
		{
			return;
		}
		bool splitKeyPressed = this.SplitKeyPressed;
		GUITransactionButton.InputState inputState;
		if (inputState != GUITransactionButton.InputState.Clicked || this.SplitKeyPressed)
		{
			return;
		}
		ChestUI.RenameChest();
		Recipe.FindRecipes(false);
	}

	// Token: 0x06000F33 RID: 3891 RVA: 0x0004C090 File Offset: 0x0004A290
	public void DrawChestLoot()
	{
		this.LoadRightItemRegion();
		Item item;
		int type = item.type;
		if (item.stack == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
	}

	// Token: 0x06000F34 RID: 3892 RVA: 0x0004C0F8 File Offset: 0x0004A2F8
	public void DrawChestFavourite()
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		Item item;
		int type = item.type;
		bool favorited = item.favorited;
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (favorited)
		{
			!0 instance2 = PageControllerLayoutDefinition.Instance;
			return;
		}
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		!0 instance4 = PageControllerLayoutDefinition.Instance;
		if (PageControllerLayoutDefinition.Instance == null)
		{
		}
		int num = 1;
		int num2 = 1;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		Texture2D texture2D;
		Rectangle rectangle = texture2D.Frame(num, num2, (int)num3, (int)num4, (int)num5, (int)num6);
		int num7 = 1;
		int num8 = 1;
		long num9 = 0L;
		long num10 = 0L;
		long num11 = 0L;
		long num12 = 0L;
		Texture2D texture2D2;
		Rectangle rectangle2 = texture2D2.Frame(num7, num8, (int)num9, (int)num10, (int)num11, (int)num12);
	}

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x06000F35 RID: 3893 RVA: 0x0004C1B0 File Offset: 0x0004A3B0
	public int NumRightOptions
	{
		get
		{
			return 2;
		}
	}

	// Token: 0x06000F36 RID: 3894 RVA: 0x0004C1C0 File Offset: 0x0004A3C0
	public void DrawRightThrow()
	{
		Item mouseItem = Main.mouseItem;
		bool favorited = mouseItem.favorited;
		if (mouseItem == null)
		{
		}
		GUITransactionButton.InputState inputState;
		if (inputState != GUITransactionButton.InputState.Clicked)
		{
			return;
		}
	}

	// Token: 0x06000F37 RID: 3895 RVA: 0x0004C1E8 File Offset: 0x0004A3E8
	public void DrawRightTrash()
	{
		Item mouseItem = Main.mouseItem;
		bool favorited = mouseItem.favorited;
		if (mouseItem == null)
		{
		}
		int whoAmI = mouseItem.whoAmI;
		Item[] mouseItemSource = Main.mouseItemSource;
		GUITransactionButton.InputState inputState;
		if (inputState != GUITransactionButton.InputState.Clicked)
		{
			return;
		}
		int num = 1;
		int myPlayer = Main.myPlayer;
		if (num == 0)
		{
		}
		if (myPlayer == 0)
		{
		}
		Recipe.FindRecipes(false);
	}

	// Token: 0x06000F38 RID: 3896 RVA: 0x0004C238 File Offset: 0x0004A438
	public void DrawRightDeposit()
	{
		GUITransactionButton.InputState inputState;
		if (inputState != GUITransactionButton.InputState.Clicked)
		{
			return;
		}
	}

	// Token: 0x06000F39 RID: 3897 RVA: 0x0004C24C File Offset: 0x0004A44C
	public void DepositHeldItem()
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		Item mouseItem = Main.mouseItem;
	}

	// Token: 0x06000F3A RID: 3898 RVA: 0x0004C2C4 File Offset: 0x0004A4C4
	public GUIPageOptions()
	{
	}

	// Token: 0x04001B49 RID: 6985
	private bool _timerBegan;

	// Token: 0x04001B4A RID: 6986
	private DateTime _timeStart;

	// Token: 0x04001B4B RID: 6987
	private bool _leftPendingPush;

	// Token: 0x04001B4C RID: 6988
	private bool _displayLeftOptions;

	// Token: 0x04001B4D RID: 6989
	private bool _displayLeftOptionsGlobal;

	// Token: 0x04001B4E RID: 6990
	private bool _displayRightOptions;

	// Token: 0x04001B4F RID: 6991
	private bool _displayRightOptionsGlobal;

	// Token: 0x04001B50 RID: 6992
	private int _displayItem;

	// Token: 0x04001B51 RID: 6993
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x04001B52 RID: 6994
	private float leftOptionsScale;

	// Token: 0x04001B53 RID: 6995
	private float rightOptionsScale;

	// Token: 0x04001B54 RID: 6996
	private float leftFavoriteScale;

	// Token: 0x04001B55 RID: 6997
	private float leftChestQuickStackScale;

	// Token: 0x04001B56 RID: 6998
	private float leftChestDepositAllScale;

	// Token: 0x04001B57 RID: 6999
	private float leftChestSortScale;

	// Token: 0x04001B58 RID: 7000
	private bool usingController;

	// Token: 0x04001B59 RID: 7001
	private int lastLang;

	// Token: 0x04001B5A RID: 7002
	public string[] options;

	// Token: 0x04001B5B RID: 7003
	private Vector2 leftItemSize;

	// Token: 0x04001B5C RID: 7004
	private Vector2 leftItemPosition;

	// Token: 0x04001B5D RID: 7005
	private Vector2 leftItemSpacing;

	// Token: 0x04001B5E RID: 7006
	private int leftItemIndex;

	// Token: 0x04001B5F RID: 7007
	private Vector2 rightItemSize;

	// Token: 0x04001B60 RID: 7008
	private Vector2 rightItemPosition;

	// Token: 0x04001B61 RID: 7009
	private Vector2 rightItemSpacing;

	// Token: 0x04001B62 RID: 7010
	private int rightItemIndex;

	// Token: 0x04001B63 RID: 7011
	private float equipButtonScale;

	// Token: 0x04001B64 RID: 7012
	private float depositButtonScale;

	// Token: 0x04001B65 RID: 7013
	private float leftThrowScale;

	// Token: 0x04001B66 RID: 7014
	private float leftTrashScale;

	// Token: 0x04001B67 RID: 7015
	private float sellButtonScale = (float)16256;

	// Token: 0x04001B68 RID: 7016
	private float rightChestSortScale;

	// Token: 0x04001B69 RID: 7017
	private float chestRestockScale;

	// Token: 0x04001B6A RID: 7018
	private float chestLootAllScale;

	// Token: 0x04001B6B RID: 7019
	private float chestRenameScale;

	// Token: 0x04001B6C RID: 7020
	public bool SplitKeyPressed;

	// Token: 0x04001B6D RID: 7021
	public bool SplitInvKeyPressed;

	// Token: 0x04001B6E RID: 7022
	public bool SplitChestKeyPressed;

	// Token: 0x04001B6F RID: 7023
	private float LootButtonScale = (float)16256;
}
