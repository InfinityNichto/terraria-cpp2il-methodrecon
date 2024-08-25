using System;
using System.Collections.Generic;
using System.Globalization;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Graphics;
using Terraria.IO;

// Token: 0x0200028A RID: 650
public class GUIWorldSelectMenu
{
	// Token: 0x17000185 RID: 389
	// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x0004A944 File Offset: 0x00048B44
	private GUIContollerTransactionButtonList WorldListOptionsController
	{
		get
		{
			GUIContollerTransactionButtonList worldListOptionsController = this._worldListOptionsController;
			if (worldListOptionsController != null || (worldListOptionsController != null && worldListOptionsController == null) || worldListOptionsController == null || worldListOptionsController != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}
	}

	// Token: 0x06000EF9 RID: 3833 RVA: 0x0004A96C File Offset: 0x00048B6C
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

	// Token: 0x06000EFA RID: 3834 RVA: 0x0004A9D0 File Offset: 0x00048BD0
	private Rectangle UpdateGlitchAnimation(WorldFileData worldData)
	{
		int glitchFrameCounter = worldData._glitchFrameCounter;
		int glitchVariation = worldData._glitchVariation;
		if (glitchFrameCounter == 0)
		{
		}
		int glitchFrame = worldData._glitchFrame;
		worldData._glitchVariation = glitchFrame;
		if (glitchFrame == 0)
		{
		}
		int num;
		if (num == 0)
		{
			if (glitchFrame == 0)
			{
			}
			int num2;
			worldData._glitchVariation = num2;
		}
		Texture2D texture2D = this.everythingAnimatedIcon;
		int glitchFrame2 = worldData._glitchFrame;
		bool currentSaveFormat = worldData.CurrentSaveFormat;
		if (glitchFrame == 0)
		{
		}
		int num3 = 7;
		int num4 = 16;
		long num5 = 0L;
		long num6 = 0L;
		return texture2D.Frame(num3, num4, currentSaveFormat ? 1 : 0, glitchFrame2, (int)num5, (int)num6);
	}

	// Token: 0x06000EFB RID: 3835 RVA: 0x0004AA58 File Offset: 0x00048C58
	private Texture2D GetIcon(WorldFileData worldData)
	{
		bool drunkWorld = worldData.DrunkWorld;
		Texture2D texture2D;
		if (drunkWorld)
		{
			bool remixWorld = worldData.RemixWorld;
			if (remixWorld)
			{
				if (this.everythingAnimatedIcon == null)
				{
					if (!remixWorld)
					{
					}
					texture2D = TextureManager.Load("Images/UI/IconEverythingAnimated");
					this.everythingAnimatedIcon = texture2D;
				}
				return texture2D;
			}
		}
		return texture2D;
	}

	// Token: 0x06000EFC RID: 3836 RVA: 0x0004AAF0 File Offset: 0x00048CF0
	private Texture2D GetSeedIcon(WorldFileData worldData, string seed)
	{
		bool isHardMode = worldData.IsHardMode;
		if (!worldData.HasCorruption)
		{
		}
		string text;
		return TextureManager.Load(text);
	}

	// Token: 0x06000EFD RID: 3837 RVA: 0x0004AB14 File Offset: 0x00048D14
	private void PlayWorldCheck()
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000EFE RID: 3838 RVA: 0x0004AB28 File Offset: 0x00048D28
	public void ActionNew()
	{
		if (!true)
		{
		}
		Main.menuMode = 16;
		byte difficulty = Main.ActivePlayerFileData._player.difficulty;
		Main.GameMode = int.MinValue;
		byte difficulty2 = Main.ActivePlayerFileData._player.difficulty;
	}

	// Token: 0x06000EFF RID: 3839 RVA: 0x0004AB70 File Offset: 0x00048D70
	private bool DrawMenuButton(string label, TransactionButton_Layout buttonLayout, float scale, bool disabled)
	{
		/*
An exception occurred when decompiling this method (06000EFF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIWorldSelectMenu::DrawMenuButton(System.String,TransactionButton_Layout,System.Single,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
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

	// Token: 0x06000F00 RID: 3840 RVA: 0x000021DB File Offset: 0x000003DB
	private bool DrawMenuButton(ControllerActionButton action, string label, TransactionButton_Layout buttonLayout, float scale, bool disabled)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000F01 RID: 3841 RVA: 0x0004AB88 File Offset: 0x00048D88
	public Vector2 ItemSize(int index)
	{
		/*
An exception occurred when decompiling this method (06000F01)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 GUIWorldSelectMenu::ItemSize(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GUIWorldSelectMenu::SelectedItem, ldloc:GUIWorldSelectMenu(this)))
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

	// Token: 0x06000F02 RID: 3842 RVA: 0x0004AB9C File Offset: 0x00048D9C
	private void DrawWorldSync()
	{
		if (6899 == 0)
		{
		}
	}

	// Token: 0x06000F03 RID: 3843 RVA: 0x000021DB File Offset: 0x000003DB
	public void SelectAndHighlight(WorldFileData worldDataOld)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000F04 RID: 3844 RVA: 0x0004ABB0 File Offset: 0x00048DB0
	private void OpenNameEdit()
	{
		int selectedItem = this.SelectedItem;
		this.LastSelectedItem = selectedItem;
	}

	// Token: 0x06000F05 RID: 3845 RVA: 0x0004ABCC File Offset: 0x00048DCC
	private void CloseNameEditAndSaveIf()
	{
		int selectedItem = this.SelectedItem;
		int size = this.SortedWorldData._size;
		string text;
		int stringLength = text._stringLength;
		List<WorldFileData> sortedWorldData = this.SortedWorldData;
		int selectedItem2 = this.SelectedItem;
		bool flag = WorldFile.RenameWorldUsingLoadAndSave(text);
	}

	// Token: 0x06000F06 RID: 3846 RVA: 0x0004AC20 File Offset: 0x00048E20
	private void CloseNameEditIf()
	{
	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x0004AC30 File Offset: 0x00048E30
	private void CloseNameEdit()
	{
	}

	// Token: 0x06000F08 RID: 3848 RVA: 0x000021DB File Offset: 0x000003DB
	public void Draw()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000F09 RID: 3849 RVA: 0x0004AC40 File Offset: 0x00048E40
	public void Back()
	{
		GUIControllerWorldSelect controllerInput = this._controllerInput;
		DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
		if (controllerInput == null)
		{
		}
		Main.menuMode = 1;
	}

	// Token: 0x06000F0A RID: 3850 RVA: 0x0004AC6C File Offset: 0x00048E6C
	private void DrawWorld(WorldFileData worldData)
	{
		Texture2D icon = this.GetIcon(worldData);
		if (worldData.DrunkWorld && worldData.RemixWorld)
		{
			Rectangle rectangle = this.UpdateGlitchAnimation(worldData);
			return;
		}
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		Rectangle rectangle2 = icon.Frame(1, 1, (int)num, (int)num2, (int)num3, (int)num4);
	}

	// Token: 0x06000F0B RID: 3851 RVA: 0x0004ACC0 File Offset: 0x00048EC0
	private void WorldDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		int selectedItem = this.SelectedItem;
		int num = 168;
		List<WorldFileData> sortedWorldData = this.SortedWorldData;
		int num2 = this.worldOver;
		int selectedItem2 = this.SelectedItem;
		int selectedItem3 = this.SelectedItem;
		if (this.SeedVersionToggle)
		{
			return;
		}
		if (num == 0)
		{
		}
		if (32 == 0)
		{
		}
		int size = sortedWorldData._size;
		int num3 = 16;
		if (num3 == 0)
		{
		}
		int selectedItem4 = this.SelectedItem;
		int lastSelectedItem = this.LastSelectedItem;
		this.CloseNameEditIf();
		int selectedItem5 = this.SelectedItem;
		this.LastSelectedItem = selectedItem5;
		if (lastSelectedItem == 0)
		{
		}
		if (num3 != 0)
		{
			return;
		}
		int num4;
		if (num4 == 0)
		{
		}
		this.CloseNameEditAndSaveIf();
	}

	// Token: 0x06000F0C RID: 3852 RVA: 0x0004B0C0 File Offset: 0x000492C0
	private void PlayWorld()
	{
		if (true && true)
		{
			Main.menuMode = 448;
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			return;
		}
		Main.menuMode = 10;
		WorldGen.playWorld();
	}

	// Token: 0x06000F0D RID: 3853 RVA: 0x000021DB File Offset: 0x000003DB
	public void SortWorlds()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000F0E RID: 3854 RVA: 0x0004B0F8 File Offset: 0x000492F8
	private int SortEntry(WorldFileData a, WorldFileData b)
	{
		bool flag = this.CanWorldBePlayed(a);
		int num;
		if (a._isFavorite && !b._isFavorite)
		{
			return num;
		}
		if (!a._isFavorite && b._isFavorite)
		{
			return 1;
		}
		string name = a.Name;
		string name2 = b.Name;
		return num;
	}

	// Token: 0x06000F0F RID: 3855 RVA: 0x0004B144 File Offset: 0x00049344
	private bool CanWorldBePlayed(WorldFileData world)
	{
		return true;
	}

	// Token: 0x06000F10 RID: 3856 RVA: 0x000021DB File Offset: 0x000003DB
	private float WorldScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000F11 RID: 3857 RVA: 0x0004B170 File Offset: 0x00049370
	private void WorldOver(int index)
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		this.worldOver = index;
	}

	// Token: 0x06000F12 RID: 3858 RVA: 0x0004B194 File Offset: 0x00049394
	public int CompareNatural(string strA, string strB)
	{
		if (!true)
		{
		}
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		int num;
		return num;
	}

	// Token: 0x06000F13 RID: 3859 RVA: 0x0004B1B0 File Offset: 0x000493B0
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
			char c7 = strA[(int)num];
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

	// Token: 0x06000F14 RID: 3860 RVA: 0x0004B3C4 File Offset: 0x000495C4
	public GUIWorldSelectMenu()
	{
		if ("" == null)
		{
		}
		if (!true)
		{
		}
		this.LastTouchMouse = 1;
		this.allowItemClicking = true;
		base..ctor();
	}

	// Token: 0x04001B1D RID: 6941
	private const double DOUBLE_CLICK_TIME = 500.0;

	// Token: 0x04001B1E RID: 6942
	private const double SINGLE_CLICK_TIME = 350.0;

	// Token: 0x04001B1F RID: 6943
	private const float SINGLE_CLICK_DISTANCE = 30f;

	// Token: 0x04001B20 RID: 6944
	private float TitleScale;

	// Token: 0x04001B21 RID: 6945
	private float BackScale;

	// Token: 0x04001B22 RID: 6946
	private float NewScale;

	// Token: 0x04001B23 RID: 6947
	private float PlayScale;

	// Token: 0x04001B24 RID: 6948
	private float DeleteScale;

	// Token: 0x04001B25 RID: 6949
	private float FavoriteScale;

	// Token: 0x04001B26 RID: 6950
	private float OptionsScale;

	// Token: 0x04001B27 RID: 6951
	private float RenameScale;

	// Token: 0x04001B28 RID: 6952
	private float SeedDisplayScale = (float)16256;

	// Token: 0x04001B29 RID: 6953
	public float ScrollOffset;

	// Token: 0x04001B2A RID: 6954
	private float ScrollMomentum;

	// Token: 0x04001B2B RID: 6955
	private int ScrollDragging;

	// Token: 0x04001B2C RID: 6956
	private Vector2 DragOffset;

	// Token: 0x04001B2D RID: 6957
	public static Texture2D _dividerTexture;

	// Token: 0x04001B2E RID: 6958
	public static Texture2D _buttonCloudActiveTexture;

	// Token: 0x04001B2F RID: 6959
	public static Texture2D _buttonCloudInactiveTexture;

	// Token: 0x04001B30 RID: 6960
	public static Texture2D _buttonFavoriteActiveTexture;

	// Token: 0x04001B31 RID: 6961
	public static Texture2D _buttonFavoriteInactiveTexture;

	// Token: 0x04001B32 RID: 6962
	public static Texture2D _buttonPlayTexture;

	// Token: 0x04001B33 RID: 6963
	public static Texture2D _buttonDeleteTexture;

	// Token: 0x04001B34 RID: 6964
	private int _worldCount;

	// Token: 0x04001B35 RID: 6965
	public List<WorldFileData> SortedWorldData;

	// Token: 0x04001B36 RID: 6966
	private bool SeedVersionToggle;

	// Token: 0x04001B37 RID: 6967
	public int SelectedItem;

	// Token: 0x04001B38 RID: 6968
	private int LastSelectedItem;

	// Token: 0x04001B39 RID: 6969
	public string SelectedItemWorld = "";

	// Token: 0x04001B3A RID: 6970
	private DateTime LastSelectTime;

	// Token: 0x04001B3B RID: 6971
	private DateTime LastTouchTime = "";

	// Token: 0x04001B3C RID: 6972
	private Vector2 LastTouchMouse;

	// Token: 0x04001B3D RID: 6973
	public bool SyncingWorlds;

	// Token: 0x04001B3E RID: 6974
	private GUIControllerWorldSelect _controllerInput;

	// Token: 0x04001B3F RID: 6975
	private GUIContollerTransactionButtonList _worldListOptionsController;

	// Token: 0x04001B40 RID: 6976
	private Texture2D everythingAnimatedIcon;

	// Token: 0x04001B41 RID: 6977
	private bool allowItemClicking;

	// Token: 0x04001B42 RID: 6978
	private Rectangle fullClipRegion;

	// Token: 0x04001B43 RID: 6979
	private Rectangle dragClipRegion;

	// Token: 0x04001B44 RID: 6980
	private int worldOver;

	// Token: 0x0200028B RID: 651
	public enum WorldRenameOption
	{
		// Token: 0x04001B46 RID: 6982
		DontRenameOldFormatWorlds,
		// Token: 0x04001B47 RID: 6983
		RenameOldFormatWithLoadSave,
		// Token: 0x04001B48 RID: 6984
		RenameAllFormatsWithLoadSave
	}
}
