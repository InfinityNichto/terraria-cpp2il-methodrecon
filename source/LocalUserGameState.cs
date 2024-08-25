using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.Achievements;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Golf;
using Terraria.GameContent.UI.BigProgressBar;
using Terraria.GameContent.UI.Minimap;
using Terraria.GameContent.UI.ResourceSets;
using Terraria.GameInput;
using Terraria.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Light;
using Terraria.IO;
using Terraria.Map;

// Token: 0x020002B9 RID: 697
public class LocalUserGameState
{
	// Token: 0x1700018D RID: 397
	// (get) Token: 0x06001028 RID: 4136 RVA: 0x0004F970 File Offset: 0x0004DB70
	public FavoritesFile LocalFavoriteData
	{
		get
		{
			/*
An exception occurred when decompiling this method (06001028)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.IO.FavoritesFile LocalUserGameState::get_LocalFavoriteData()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_2_1A, call:string(string::Concat, callgetter:string(Main::get_SavePath), ldloc:string(var_1), ldstr:string("favorites.json")))
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

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x06001029 RID: 4137 RVA: 0x0004F99C File Offset: 0x0004DB9C
	// (set) Token: 0x0600102A RID: 4138 RVA: 0x0004F9B0 File Offset: 0x0004DBB0
	public WaterfallManager waterfallManager
	{
		get
		{
			/*
An exception occurred when decompiling this method (06001029)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.WaterfallManager LocalUserGameState::get_waterfallManager()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:WaterfallManager[exp:bool](LocalUserGameState::_waterfallManager, ldloc:LocalUserGameState(this)))
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
		set
		{
			this._waterfallManager = value;
		}
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x0600102B RID: 4139 RVA: 0x0004F9C4 File Offset: 0x0004DBC4
	public LightingEngine NewEngine
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600102B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Graphics.Light.LightingEngine LocalUserGameState::get_NewEngine()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:LightingEngine[exp:bool](LocalUserGameState::_newEngine, ldloc:LocalUserGameState(this)))
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
	}

	// Token: 0x17000190 RID: 400
	// (get) Token: 0x0600102C RID: 4140 RVA: 0x0004F9D8 File Offset: 0x0004DBD8
	public LegacyLighting LegacyEngine
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600102C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Graphics.Light.LegacyLighting LocalUserGameState::get_LegacyEngine()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Camera(var_1_0F, callgetter:Camera(Main::get_Camera))
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

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x0600102D RID: 4141 RVA: 0x0004F9F4 File Offset: 0x0004DBF4
	// (set) Token: 0x0600102E RID: 4142 RVA: 0x0004FA20 File Offset: 0x0004DC20
	public ILightingEngine _activeEngine
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600102D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Graphics.Light.ILightingEngine LocalUserGameState::get__activeEngine()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:LightMode(var_0_0E, ldfld:LightMode(LocalUserGameState::_mode, ldloc:LocalUserGameState(this)))
	stloc:LightingEngine(var_1_15, callgetter:LightingEngine(LocalUserGameState::get_NewEngine, ldloc:LocalUserGameState(this)))
	stfld:ILightingEngine(LocalUserGameState::_activeEngineVal, ldloc:LocalUserGameState(this), ldloc:LegacyLighting[exp:ILightingEngine](var_2))
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
		set
		{
			this._activeEngineVal = value;
		}
	}

	// Token: 0x0600102F RID: 4143 RVA: 0x0004FA34 File Offset: 0x0004DC34
	public LocalUserGameState()
	{
		int num = 16256;
		this.ScrollSensitivity = (float)num;
		int num2 = 2;
		this.mapDelay = num2;
		int num3 = 1;
		this.SettingsEnabled_MinersWobble = num3 != 0;
		this.SettingsEnabled_OpaqueBoxBehindTooltips = num3 != 0;
		this.MouseShowBuildingGrid = num3 != 0;
		this.npcChatText = "";
		string text;
		this.blockKey = text;
		int num4 = 7;
		this.gFadeDir = (byte)num3;
		this.stackDelay = num4;
		int num5 = 49024;
		this.mouseItemTime = (float)num5;
		int num6 = 16192;
		this.inventoryScale = (float)num6;
		this.gameMenu = num3 != 0;
		this.cursorColorDirection = num3;
		int num7 = 2;
		this.BackgroundEnabled = num3 != 0;
		this.instantBGTransitionCounter = num7;
		if (!true)
		{
		}
		int num8 = 2;
		int num9 = 1;
		this.invasionProgressMode = num8;
		int num10 = 257;
		this.mapEnabled = num9 != 0;
		int num11 = 3;
		int num12 = 16256;
		this.autoPause = (Main.AutoPauseMode)num9;
		this.WaveQuality = num11;
		this.UseStormEffects = num10 != 0;
		this.soundVolume = (float)num12;
		int num13 = 18350;
		this.caveParallax = (float)num13;
		this.showItemText = num9 != 0;
		this.mapStyle = num9;
		int num14 = 13107;
		this.mapOverlayAlpha = (float)num14;
		this.mapMinimapAlpha = 0f;
		this.resetMapFullCharacter = num14;
		long num15 = 15L;
		int num16 = 4;
		int num17 = 6;
		this.tileRangeY = num16;
		this.BlockInteractionWithProjectiles = num11;
		this.lastPound = num9 != 0;
		this.musicNotes = num17;
		this.SmartAxeAfterPickaxe = num9 != 0;
		if (num15 == 0L)
		{
		}
		if (num15 == 0L)
		{
		}
		int num18 = 3;
		int num19 = 257;
		int num20 = 1;
		this._mode = (LightMode)num18;
		this.DisableLeftShiftTrashCan = num19 != 0;
		this.ChildSafetyDisabled = num20 != 0;
		base..ctor();
	}

	// Token: 0x04001DBE RID: 7614
	[ThreadStatic]
	public static LocalUserGameState Instance;

	// Token: 0x04001DBF RID: 7615
	public AchievementManager _achievements;

	// Token: 0x04001DC0 RID: 7616
	public CreativePowerManager CreativePowerManager;

	// Token: 0x04001DC1 RID: 7617
	public bool CreativePowerManager_initialized;

	// Token: 0x04001DC2 RID: 7618
	public bool SwapBumpersTriggers;

	// Token: 0x04001DC3 RID: 7619
	public object MapHelperIOLock;

	// Token: 0x04001DC4 RID: 7620
	public float ScrollSensitivity;

	// Token: 0x04001DC5 RID: 7621
	public LockOnHelperStaticData LockOnHelperStaticData;

	// Token: 0x04001DC6 RID: 7622
	public TileObjectPreviewData objectPreview;

	// Token: 0x04001DC7 RID: 7623
	public bool flushLighting;

	// Token: 0x04001DC8 RID: 7624
	public MinimapFrame ActiveMinimapFrame;

	// Token: 0x04001DC9 RID: 7625
	public IPlayerResourcesDisplaySet ActivePlayerResourcesSet;

	// Token: 0x04001DCA RID: 7626
	public int mapDelay;

	// Token: 0x04001DCB RID: 7627
	public bool InReforgeMenu;

	// Token: 0x04001DCC RID: 7628
	public bool InGuideCraftMenu;

	// Token: 0x04001DCD RID: 7629
	public bool anglerQuestFinished;

	// Token: 0x04001DCE RID: 7630
	public bool HoveringOverAnNPC;

	// Token: 0x04001DCF RID: 7631
	public int currentNPCShowingChatBubble;

	// Token: 0x04001DD0 RID: 7632
	public float hBar;

	// Token: 0x04001DD1 RID: 7633
	public float sBar;

	// Token: 0x04001DD2 RID: 7634
	public float lBar;

	// Token: 0x04001DD3 RID: 7635
	public float aBar;

	// Token: 0x04001DD4 RID: 7636
	public int mouseNPCIndex;

	// Token: 0x04001DD5 RID: 7637
	public int mouseNPCType;

	// Token: 0x04001DD6 RID: 7638
	public int firstTileX;

	// Token: 0x04001DD7 RID: 7639
	public int lastTileX;

	// Token: 0x04001DD8 RID: 7640
	public int firstTileY;

	// Token: 0x04001DD9 RID: 7641
	public int lastTileY;

	// Token: 0x04001DDA RID: 7642
	public int rare;

	// Token: 0x04001DDB RID: 7643
	public int hairStart;

	// Token: 0x04001DDC RID: 7644
	public int oldHairStyle;

	// Token: 0x04001DDD RID: 7645
	public Color oldHairColor;

	// Token: 0x04001DDE RID: 7646
	public int selClothes;

	// Token: 0x04001DDF RID: 7647
	public Color[] oldClothesColor;

	// Token: 0x04001DE0 RID: 7648
	public int oldClothesStyle;

	// Token: 0x04001DE1 RID: 7649
	public int interactedDresserTopLeftX;

	// Token: 0x04001DE2 RID: 7650
	public int interactedDresserTopLeftY;

	// Token: 0x04001DE3 RID: 7651
	public Vector2 _itemIconCacheScreenPosition;

	// Token: 0x04001DE4 RID: 7652
	public int _itemIconCacheSelectedItemID;

	// Token: 0x04001DE5 RID: 7653
	public int _itemIconCacheTime;

	// Token: 0x04001DE6 RID: 7654
	public Player dresserInterfaceDummy;

	// Token: 0x04001DE7 RID: 7655
	public Color selColor;

	// Token: 0x04001DE8 RID: 7656
	public int waterStyle;

	// Token: 0x04001DE9 RID: 7657
	public bool drewLava;

	// Token: 0x04001DEA RID: 7658
	public float[] liquidAlpha;

	// Token: 0x04001DEB RID: 7659
	public int[] activeLiquidAlpha;

	// Token: 0x04001DEC RID: 7660
	public int numActiveLiquidAlpha;

	// Token: 0x04001DED RID: 7661
	public bool SettingsUnlock_WorldEvil;

	// Token: 0x04001DEE RID: 7662
	public bool SettingsEnabled_MinersWobble;

	// Token: 0x04001DEF RID: 7663
	public bool SettingBlockGamepadsEntirely;

	// Token: 0x04001DF0 RID: 7664
	public bool SettingDontScaleMainMenuUp;

	// Token: 0x04001DF1 RID: 7665
	public bool SettingsEnabled_OpaqueBoxBehindTooltips;

	// Token: 0x04001DF2 RID: 7666
	public int tooltipTime;

	// Token: 0x04001DF3 RID: 7667
	public int inventoryTooltipTime;

	// Token: 0x04001DF4 RID: 7668
	public bool SettingMusicReplayDelayEnabled;

	// Token: 0x04001DF5 RID: 7669
	public bool MouseShowBuildingGrid;

	// Token: 0x04001DF6 RID: 7670
	public float MouseBuildingGridAlpha;

	// Token: 0x04001DF7 RID: 7671
	public float GraveyardVisualIntensity;

	// Token: 0x04001DF8 RID: 7672
	public bool ScreenPostProcessor_Enabled;

	// Token: 0x04001DF9 RID: 7673
	public List<ScreenPostProcessor> ScreenPostProcessor_Instances;

	// Token: 0x04001DFA RID: 7674
	public List<ScreenPostProcessor> ScreenPostProcessor_UIInstances;

	// Token: 0x04001DFB RID: 7675
	public List<Filter> ScreenPostProcessor_Filters;

	// Token: 0x04001DFC RID: 7676
	public int ScreenPostProcessor_countUpdate;

	// Token: 0x04001DFD RID: 7677
	public int ScreenPostProcessor_renderCheck;

	// Token: 0x04001DFE RID: 7678
	public ItemShopSellbackHelper shopSellbackHelper;

	// Token: 0x04001DFF RID: 7679
	public Chest[] shop;

	// Token: 0x04001E00 RID: 7680
	public int npcChatCornerItem;

	// Token: 0x04001E01 RID: 7681
	public int npcShop;

	// Token: 0x04001E02 RID: 7682
	public bool npcChatFocus1;

	// Token: 0x04001E03 RID: 7683
	public bool npcChatFocus2;

	// Token: 0x04001E04 RID: 7684
	public bool npcChatFocus3;

	// Token: 0x04001E05 RID: 7685
	public bool npcChatFocus4;

	// Token: 0x04001E06 RID: 7686
	public string npcChatText;

	// Token: 0x04001E07 RID: 7687
	public string defaultChestName;

	// Token: 0x04001E08 RID: 7688
	public string blockKey;

	// Token: 0x04001E09 RID: 7689
	public bool blockInput;

	// Token: 0x04001E0A RID: 7690
	public string _savePath;

	// Token: 0x04001E0B RID: 7691
	public string _oldSavePath;

	// Token: 0x04001E0C RID: 7692
	public bool StateInitialised;

	// Token: 0x04001E0D RID: 7693
	public Camera Camera;

	// Token: 0x04001E0E RID: 7694
	public FavoritesFile _localFavoriteData;

	// Token: 0x04001E0F RID: 7695
	public Preferences _configuration;

	// Token: 0x04001E10 RID: 7696
	public Preferences _inputProfiles;

	// Token: 0x04001E11 RID: 7697
	public WorldSections sectionManager;

	// Token: 0x04001E12 RID: 7698
	public BigProgressBarSystem BigBossProgressBar;

	// Token: 0x04001E13 RID: 7699
	public float hellBlackBoxBottom;

	// Token: 0x04001E14 RID: 7700
	public int[] backTexture;

	// Token: 0x04001E15 RID: 7701
	public int[] oldBackTexture;

	// Token: 0x04001E16 RID: 7702
	public Texture2D[] backTextureValues;

	// Token: 0x04001E17 RID: 7703
	public Texture2D[] oldBackTextureValues;

	// Token: 0x04001E18 RID: 7704
	public FileMetadata MapFileMetadata;

	// Token: 0x04001E19 RID: 7705
	public Main.MouseTextCache _mouseTextCache;

	// Token: 0x04001E1A RID: 7706
	private WaterfallManager _waterfallManager;

	// Token: 0x04001E1B RID: 7707
	public Rain[] rain;

	// Token: 0x04001E1C RID: 7708
	public PopupText[] popupText;

	// Token: 0x04001E1D RID: 7709
	public int mouseX;

	// Token: 0x04001E1E RID: 7710
	public int mouseY;

	// Token: 0x04001E1F RID: 7711
	public int worldMouseX;

	// Token: 0x04001E20 RID: 7712
	public int worldMouseY;

	// Token: 0x04001E21 RID: 7713
	public int lastMouseX;

	// Token: 0x04001E22 RID: 7714
	public int lastMouseY;

	// Token: 0x04001E23 RID: 7715
	public bool mouseLeft;

	// Token: 0x04001E24 RID: 7716
	public bool mouseRight;

	// Token: 0x04001E25 RID: 7717
	public bool worldMouseLeft;

	// Token: 0x04001E26 RID: 7718
	public bool worldMouseRight;

	// Token: 0x04001E27 RID: 7719
	public bool worldMouseLeftRelease;

	// Token: 0x04001E28 RID: 7720
	public bool worldMouseRightRelease;

	// Token: 0x04001E29 RID: 7721
	public bool isMouseLeftConsumedByUI;

	// Token: 0x04001E2A RID: 7722
	public bool hairWindow;

	// Token: 0x04001E2B RID: 7723
	public bool clothesWindow;

	// Token: 0x04001E2C RID: 7724
	public bool ingameOptionsWindow;

	// Token: 0x04001E2D RID: 7725
	public bool inFancyUI;

	// Token: 0x04001E2E RID: 7726
	public byte gFade;

	// Token: 0x04001E2F RID: 7727
	public float gFader;

	// Token: 0x04001E30 RID: 7728
	public byte gFadeDir;

	// Token: 0x04001E31 RID: 7729
	public float startScreenYOffset;

	// Token: 0x04001E32 RID: 7730
	public float targetScreenYOffset;

	// Token: 0x04001E33 RID: 7731
	public int CameraMovementMode;

	// Token: 0x04001E34 RID: 7732
	public float screenYOffset;

	// Token: 0x04001E35 RID: 7733
	public float cameraOffset;

	// Token: 0x04001E36 RID: 7734
	public Vector2 screenPosition;

	// Token: 0x04001E37 RID: 7735
	public Vector2 screenLastPosition;

	// Token: 0x04001E38 RID: 7736
	public int screenWidth;

	// Token: 0x04001E39 RID: 7737
	public int screenHeight;

	// Token: 0x04001E3A RID: 7738
	public bool mouseLeftRelease;

	// Token: 0x04001E3B RID: 7739
	public bool mouseRightRelease;

	// Token: 0x04001E3C RID: 7740
	public bool playerInventory;

	// Token: 0x04001E3D RID: 7741
	public int stackSplit;

	// Token: 0x04001E3E RID: 7742
	public bool preventStackSplitReset;

	// Token: 0x04001E3F RID: 7743
	public int stackCounter;

	// Token: 0x04001E40 RID: 7744
	public int stackDelay;

	// Token: 0x04001E41 RID: 7745
	public int superFastStack;

	// Token: 0x04001E42 RID: 7746
	public int timesTriedToFastStack;

	// Token: 0x04001E43 RID: 7747
	public Item mouseItem;

	// Token: 0x04001E44 RID: 7748
	public float mouseItemTime;

	// Token: 0x04001E45 RID: 7749
	public Item[] mouseItemSource;

	// Token: 0x04001E46 RID: 7750
	public int mouseItemSourceIndex;

	// Token: 0x04001E47 RID: 7751
	public int mouseItemSourceContext;

	// Token: 0x04001E48 RID: 7752
	public Item guideItem;

	// Token: 0x04001E49 RID: 7753
	public Item reforgeItem;

	// Token: 0x04001E4A RID: 7754
	public float inventoryScale;

	// Token: 0x04001E4B RID: 7755
	public Point rulerLineDisplayValues;

	// Token: 0x04001E4C RID: 7756
	public int[] availableRecipe;

	// Token: 0x04001E4D RID: 7757
	public int lastRecipeUpdateId;

	// Token: 0x04001E4E RID: 7758
	public int numAvailableRecipes;

	// Token: 0x04001E4F RID: 7759
	public int focusRecipe;

	// Token: 0x04001E50 RID: 7760
	public int myPlayer;

	// Token: 0x04001E51 RID: 7761
	public int spawnTileX;

	// Token: 0x04001E52 RID: 7762
	public int spawnTileY;

	// Token: 0x04001E53 RID: 7763
	public bool npcChatRelease;

	// Token: 0x04001E54 RID: 7764
	public bool editSign;

	// Token: 0x04001E55 RID: 7765
	public bool editChest;

	// Token: 0x04001E56 RID: 7766
	public int oldNPCShop;

	// Token: 0x04001E57 RID: 7767
	public bool gameMenu;

	// Token: 0x04001E58 RID: 7768
	public int menuMode;

	// Token: 0x04001E59 RID: 7769
	public bool Quitting;

	// Token: 0x04001E5A RID: 7770
	public List<PlayerFileData> PlayerList;

	// Token: 0x04001E5B RID: 7771
	public PlayerFileData ActivePlayerFileData;

	// Token: 0x04001E5C RID: 7772
	public Player PendingPlayer;

	// Token: 0x04001E5D RID: 7773
	public bool SmartCursorShowing;

	// Token: 0x04001E5E RID: 7774
	public int SmartCursorX;

	// Token: 0x04001E5F RID: 7775
	public int SmartCursorY;

	// Token: 0x04001E60 RID: 7776
	public bool SmartInteractShowingGenuine;

	// Token: 0x04001E61 RID: 7777
	public bool SmartInteractShowingFake;

	// Token: 0x04001E62 RID: 7778
	public int SmartInteractX;

	// Token: 0x04001E63 RID: 7779
	public int SmartInteractY;

	// Token: 0x04001E64 RID: 7780
	public int SmartInteractNPC;

	// Token: 0x04001E65 RID: 7781
	public int SmartInteractProj;

	// Token: 0x04001E66 RID: 7782
	public bool SmartInteractPotionOfReturn;

	// Token: 0x04001E67 RID: 7783
	public Dictionary<int, bool> SmartInteractTileCoords;

	// Token: 0x04001E68 RID: 7784
	public Dictionary<int, bool> SmartInteractTileCoordsSelected;

	// Token: 0x04001E69 RID: 7785
	public int TileInteractionLX;

	// Token: 0x04001E6A RID: 7786
	public int TileInteractionLY;

	// Token: 0x04001E6B RID: 7787
	public int TileInteractionHX;

	// Token: 0x04001E6C RID: 7788
	public int TileInteractionHY;

	// Token: 0x04001E6D RID: 7789
	public int cursorOverride;

	// Token: 0x04001E6E RID: 7790
	public int signHover;

	// Token: 0x04001E6F RID: 7791
	public int lastSignHover;

	// Token: 0x04001E70 RID: 7792
	public float GamepadCursorAlpha;

	// Token: 0x04001E71 RID: 7793
	public int overloadedMousePositionX;

	// Token: 0x04001E72 RID: 7794
	public int overloadedMousePositionY;

	// Token: 0x04001E73 RID: 7795
	public Color mouseColor;

	// Token: 0x04001E74 RID: 7796
	public Color MouseBorderColor;

	// Token: 0x04001E75 RID: 7797
	public Color ControllerColor;

	// Token: 0x04001E76 RID: 7798
	public Color ControllerBorderColor;

	// Token: 0x04001E77 RID: 7799
	public Color cursorColor;

	// Token: 0x04001E78 RID: 7800
	public int cursorColorDirection;

	// Token: 0x04001E79 RID: 7801
	public float cursorAlpha;

	// Token: 0x04001E7A RID: 7802
	public float cursorScale;

	// Token: 0x04001E7B RID: 7803
	public bool signBubble;

	// Token: 0x04001E7C RID: 7804
	public int signX;

	// Token: 0x04001E7D RID: 7805
	public int signY;

	// Token: 0x04001E7E RID: 7806
	public bool hideUI;

	// Token: 0x04001E7F RID: 7807
	public bool releaseUI;

	// Token: 0x04001E80 RID: 7808
	public bool renderNow;

	// Token: 0x04001E81 RID: 7809
	public int renderCount;

	// Token: 0x04001E82 RID: 7810
	public bool render;

	// Token: 0x04001E83 RID: 7811
	public Stopwatch saveTime;

	// Token: 0x04001E84 RID: 7812
	public bool BackgroundEnabled;

	// Token: 0x04001E85 RID: 7813
	public SceneMetrics SceneMetrics;

	// Token: 0x04001E86 RID: 7814
	public int instantBGTransitionCounter;

	// Token: 0x04001E87 RID: 7815
	public int bgDelay;

	// Token: 0x04001E88 RID: 7816
	public int background;

	// Token: 0x04001E89 RID: 7817
	public int caveBackground;

	// Token: 0x04001E8A RID: 7818
	public GolfState LocalGolfState;

	// Token: 0x04001E8B RID: 7819
	public DroneCameraTracker DroneCameraTracker;

	// Token: 0x04001E8C RID: 7820
	public Vector2 CurrentPan;

	// Token: 0x04001E8D RID: 7821
	public float sunCircle;

	// Token: 0x04001E8E RID: 7822
	public int BlackFadeIn;

	// Token: 0x04001E8F RID: 7823
	public float ugBackTransition;

	// Token: 0x04001E90 RID: 7824
	public int undergroundBackground;

	// Token: 0x04001E91 RID: 7825
	public int oldUndergroundBackground;

	// Token: 0x04001E92 RID: 7826
	public int bgStyle;

	// Token: 0x04001E93 RID: 7827
	public float[] bgAlphaFrontLayer;

	// Token: 0x04001E94 RID: 7828
	public float[] bgAlphaFarBackLayer;

	// Token: 0x04001E95 RID: 7829
	public int[] bgFrame;

	// Token: 0x04001E96 RID: 7830
	public int[] bgFrameCounter;

	// Token: 0x04001E97 RID: 7831
	public bool mapEnabled;

	// Token: 0x04001E98 RID: 7832
	public int invasionProgressMode;

	// Token: 0x04001E99 RID: 7833
	public bool invasionProgressNearInvasion;

	// Token: 0x04001E9A RID: 7834
	public bool placementPreview;

	// Token: 0x04001E9B RID: 7835
	public bool autoSave;

	// Token: 0x04001E9C RID: 7836
	public Main.AutoPauseMode autoPause;

	// Token: 0x04001E9D RID: 7837
	public bool DisableIntenseVisualEffects;

	// Token: 0x04001E9E RID: 7838
	public int WaveQuality;

	// Token: 0x04001E9F RID: 7839
	public bool UseStormEffects;

	// Token: 0x04001EA0 RID: 7840
	public bool UseHeatDistortion;

	// Token: 0x04001EA1 RID: 7841
	public float musicVolume;

	// Token: 0x04001EA2 RID: 7842
	public float ambientVolume;

	// Token: 0x04001EA3 RID: 7843
	public float soundVolume;

	// Token: 0x04001EA4 RID: 7844
	public bool TOWMusicUnlocked;

	// Token: 0x04001EA5 RID: 7845
	public int qaStyle;

	// Token: 0x04001EA6 RID: 7846
	public float caveParallax;

	// Token: 0x04001EA7 RID: 7847
	public int bgScroll;

	// Token: 0x04001EA8 RID: 7848
	public bool showItemText;

	// Token: 0x04001EA9 RID: 7849
	public bool HidePassword;

	// Token: 0x04001EAA RID: 7850
	public bool ReversedUpDownArmorSetBonuses;

	// Token: 0x04001EAB RID: 7851
	public bool SettingsEnabled_TilesSwayInWind;

	// Token: 0x04001EAC RID: 7852
	public bool cSmartCursorModeIsToggleAndNotHold;

	// Token: 0x04001EAD RID: 7853
	public float gfxQuality;

	// Token: 0x04001EAE RID: 7854
	public float gfxRate;

	// Token: 0x04001EAF RID: 7855
	public int teamCooldown;

	// Token: 0x04001EB0 RID: 7856
	public bool showFrameRate;

	// Token: 0x04001EB1 RID: 7857
	public bool SettingsSavePending;

	// Token: 0x04001EB2 RID: 7858
	public WorldMap Map;

	// Token: 0x04001EB3 RID: 7859
	public bool refreshMap;

	// Token: 0x04001EB4 RID: 7860
	public int loadMapLastX;

	// Token: 0x04001EB5 RID: 7861
	public bool loadMapLock;

	// Token: 0x04001EB6 RID: 7862
	public bool loadMap;

	// Token: 0x04001EB7 RID: 7863
	public bool loadMapSections;

	// Token: 0x04001EB8 RID: 7864
	public bool mapReady;

	// Token: 0x04001EB9 RID: 7865
	public bool updateMap;

	// Token: 0x04001EBA RID: 7866
	public int mapMinX;

	// Token: 0x04001EBB RID: 7867
	public int mapMaxX;

	// Token: 0x04001EBC RID: 7868
	public int mapMinY;

	// Token: 0x04001EBD RID: 7869
	public int mapMaxY;

	// Token: 0x04001EBE RID: 7870
	public int mapTimeMax;

	// Token: 0x04001EBF RID: 7871
	public int mapTime;

	// Token: 0x04001EC0 RID: 7872
	public bool clearMap;

	// Token: 0x04001EC1 RID: 7873
	public bool mapInit;

	// Token: 0x04001EC2 RID: 7874
	public int mapStyle;

	// Token: 0x04001EC3 RID: 7875
	public float grabMapX;

	// Token: 0x04001EC4 RID: 7876
	public float grabMapY;

	// Token: 0x04001EC5 RID: 7877
	public float grabMapInitialX;

	// Token: 0x04001EC6 RID: 7878
	public float grabMapInitialY;

	// Token: 0x04001EC7 RID: 7879
	public bool grabMapInProgress;

	// Token: 0x04001EC8 RID: 7880
	public int miniMapX;

	// Token: 0x04001EC9 RID: 7881
	public int miniMapY;

	// Token: 0x04001ECA RID: 7882
	public int miniMapWidth;

	// Token: 0x04001ECB RID: 7883
	public int miniMapHeight;

	// Token: 0x04001ECC RID: 7884
	public float mapMinimapScale;

	// Token: 0x04001ECD RID: 7885
	public float mapMinimapAlpha;

	// Token: 0x04001ECE RID: 7886
	public float mapOverlayScale;

	// Token: 0x04001ECF RID: 7887
	public float mapOverlayAlpha;

	// Token: 0x04001ED0 RID: 7888
	public bool mapFullscreen;

	// Token: 0x04001ED1 RID: 7889
	public bool resetMapFull;

	// Token: 0x04001ED2 RID: 7890
	public int resetMapFullCharacter;

	// Token: 0x04001ED3 RID: 7891
	public float mapFullscreenScale;

	// Token: 0x04001ED4 RID: 7892
	public Vector2 mapFullscreenPos;

	// Token: 0x04001ED5 RID: 7893
	public bool _MouseOversCanClear;

	// Token: 0x04001ED6 RID: 7894
	public TriggersPack Triggers;

	// Token: 0x04001ED7 RID: 7895
	public MouseState MouseInfo;

	// Token: 0x04001ED8 RID: 7896
	public MouseState MouseInfoOld;

	// Token: 0x04001ED9 RID: 7897
	public int MouseX;

	// Token: 0x04001EDA RID: 7898
	public int MouseY;

	// Token: 0x04001EDB RID: 7899
	public bool LockGamepadTileUseButton;

	// Token: 0x04001EDC RID: 7900
	public int PreUIX;

	// Token: 0x04001EDD RID: 7901
	public int PreUIY;

	// Token: 0x04001EDE RID: 7902
	public int PreLockOnX;

	// Token: 0x04001EDF RID: 7903
	public int PreLockOnY;

	// Token: 0x04001EE0 RID: 7904
	public int ScrollWheelValue;

	// Token: 0x04001EE1 RID: 7905
	public int ScrollWheelValueOld;

	// Token: 0x04001EE2 RID: 7906
	public int ScrollWheelDelta;

	// Token: 0x04001EE3 RID: 7907
	public int taxRate;

	// Token: 0x04001EE4 RID: 7908
	public int tileRangeX;

	// Token: 0x04001EE5 RID: 7909
	public int tileRangeY;

	// Token: 0x04001EE6 RID: 7910
	public int tileTargetX;

	// Token: 0x04001EE7 RID: 7911
	public int tileTargetY;

	// Token: 0x04001EE8 RID: 7912
	public int jumpHeight;

	// Token: 0x04001EE9 RID: 7913
	public float jumpSpeed;

	// Token: 0x04001EEA RID: 7914
	public int BlockInteractionWithProjectiles;

	// Token: 0x04001EEB RID: 7915
	public bool lastPound;

	// Token: 0x04001EEC RID: 7916
	public int musicNotes;

	// Token: 0x04001EED RID: 7917
	public bool SmartBlocksEnabled;

	// Token: 0x04001EEE RID: 7918
	public bool SmartAxeAfterPickaxe;

	// Token: 0x04001EEF RID: 7919
	public int[] _specialsCount;

	// Token: 0x04001EF0 RID: 7920
	public Point[][] _specialPositions;

	// Token: 0x04001EF1 RID: 7921
	public WindGrid _windGrid;

	// Token: 0x04001EF2 RID: 7922
	public bool _shouldShowInvisibleBlocks;

	// Token: 0x04001EF3 RID: 7923
	public bool _shouldShowInvisibleBlocks_LastFrame;

	// Token: 0x04001EF4 RID: 7924
	public ThreadLocal<TileDrawInfo> _currentTileDrawInfo;

	// Token: 0x04001EF5 RID: 7925
	public LightMode _mode;

	// Token: 0x04001EF6 RID: 7926
	private LightingEngine _newEngine;

	// Token: 0x04001EF7 RID: 7927
	private LegacyLighting _legacyEngine;

	// Token: 0x04001EF8 RID: 7928
	private ILightingEngine _activeEngineVal;

	// Token: 0x04001EF9 RID: 7929
	public bool DisableLeftShiftTrashCan;

	// Token: 0x04001EFA RID: 7930
	public bool HighlightNewItems;

	// Token: 0x04001EFB RID: 7931
	public bool DisableQuickTrash;

	// Token: 0x04001EFC RID: 7932
	public bool ChildSafetyDisabled;

	// Token: 0x020002BA RID: 698
	[CompilerGenerated]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001030 RID: 4144 RVA: 0x0004FC58 File Offset: 0x0004DE58
		// Note: this type is marked as 'beforefieldinit'.
		static <>c()
		{
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0004FC68 File Offset: 0x0004DE68
		public <>c()
		{
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x000021DB File Offset: 0x000003DB
		internal TileDrawInfo <.ctor>b__331_0()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04001EFD RID: 7933
		public static readonly LocalUserGameState.<>c <>9;

		// Token: 0x04001EFE RID: 7934
		public static Func<TileDrawInfo> <>9__331_0;
	}
}
