using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.UI;
using Terraria.Graphics.Renderers;
using Terraria.Localization;
using Terraria.Net;

// Token: 0x0200016A RID: 362
public class GUIResearch
{
	// Token: 0x06000A2C RID: 2604 RVA: 0x00030B40 File Offset: 0x0002ED40
	public static void LoadContent()
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x00030B58 File Offset: 0x0002ED58
	public Rectangle GetRegion()
	{
		return GUIPanel.Region(Research_Layout.Instance.Backing);
	}

	// Token: 0x06000A2E RID: 2606 RVA: 0x00030B78 File Offset: 0x0002ED78
	public GUIResearch.ResearchState CanBeResearched(Item item, [Out] int percent)
	{
		/*
An exception occurred when decompiling this method (06000A2E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIResearch/ResearchState GUIResearch::CanBeResearched(Terraria.Item,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:int32(var_0_0E, ldfld:int32(Item::type, ldloc:Item(item)))
	stloc:ItemsSacrificedUnlocksTracker(var_3_1B, ldfld:ItemsSacrificedUnlocksTracker(CreativeUnlocksTracker::ItemSacrifices, callgetter:CreativeUnlocksTracker(Main::get_LocalPlayerCreativeTracker)))
	stloc:int32(var_4_22, ldfld:int32(Item::type, ldloc:Item(item)))
	stloc:int32(var_5_2C, call:int32(ItemsSacrificedUnlocksTracker::GetSacrificeCount, ldloc:ItemsSacrificedUnlocksTracker(var_3_1B), ldloc:int32(var_4_22)))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](percent), ldc.i4:int32(100))
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

	// Token: 0x06000A2F RID: 2607 RVA: 0x00030BC0 File Offset: 0x0002EDC0
	public void DrawInventoryResearchBinding()
	{
		if (!true)
		{
		}
		int gameMode = Main.GameMode;
		this.DrawInventoryResearchButton();
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x00030C0C File Offset: 0x0002EE0C
	public void DrawInventoryResearchButton()
	{
		int gameMode = Main.GameMode;
		bool useCollpasedCoinsAmmo = RightSideHUDAnchorUpdator.UseCollpasedCoinsAmmo;
		Research_Layout instance = Research_Layout.Instance;
		string textValue = Language.GetTextValue("Mobile.Research");
		string textValue2 = Language.GetTextValue("Mobile.Research");
		bool drawToolModeUI = WiresUI.Settings.DrawToolModeUI;
		TransactionButton_Layout inventoryResearchController = instance.InventoryResearchController;
		float x = instance.InventoryResearchControllerWiringOffset.X;
		float y = instance.InventoryResearchControllerWiringOffset.Y;
		float x2 = inventoryResearchController.Location.X;
		float y2 = inventoryResearchController.Location.Y;
		TransactionButton_Layout inventoryResearch = instance.InventoryResearch;
		int num = 18;
		int myPlayer = Main.myPlayer;
		this.Open(num);
		bool drawToolModeUI2 = WiresUI.Settings.DrawToolModeUI;
		TransactionButton_Layout inventoryResearchController2 = instance.InventoryResearchController;
		float x3 = instance.InventoryResearchControllerWiringOffset.X;
		float y3 = instance.InventoryResearchControllerWiringOffset.Y;
		float x4 = inventoryResearchController2.Location.X;
		float y4 = inventoryResearchController2.Location.Y;
	}

	// Token: 0x06000A31 RID: 2609 RVA: 0x00030D14 File Offset: 0x0002EF14
	public bool IsOver(Vector2 cursorPosition)
	{
		if (!true)
		{
		}
		if (InterfaceStyles_Layout.Active.GetCategoryGrouping(GUIPageIcons.Category.Research, true) != null)
		{
		}
		if (this.Displaying)
		{
			Research_Layout instance = Research_Layout.Instance;
			Rectangle rectangle = GUIPanel.Region(Research_Layout.Instance.Backing);
			Rectangle controlRegion = ControlAnchor.GetControlRegion(ControlAnchor.ControlId.GridItem);
			ControlAnchor.SetGridItemRegion(rectangle);
			TransactionButton_Layout close = instance.Close;
			Rectangle region = GUITransactionButton.GetRegion(close);
			ControlAnchor.SetGridItemRegion(controlRegion);
		}
		return true;
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x00030D90 File Offset: 0x0002EF90
	public void Open(int item)
	{
		GUIInputRegionExclusive guiinputRegionExclusive;
		if (!this.Displaying)
		{
			int num = 1;
			this.PickingInterceptor = guiinputRegionExclusive;
			guiinputRegionExclusive.Active = num != 0;
		}
		int num2 = 1;
		this.Displaying = num2 != 0;
		this.selectedResearchItem = item;
		bool active = guiinputRegionExclusive.Active;
		long num3 = 0L;
		int num4 = this.selectedResearchItem;
		GUIControllerDynamicGridNavigator guicontrollerDynamicGridNavigator;
		guicontrollerDynamicGridNavigator.Activate((int)num3);
		GUIControllerDynamicGridNavigator.GetCollectionCount collectionCount = guicontrollerDynamicGridNavigator._collectionCount;
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x00030DEC File Offset: 0x0002EFEC
	public void Close()
	{
		if (!this.Displaying || this.PickingInterceptor != null)
		{
		}
	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x00030E0C File Offset: 0x0002F00C
	public void Draw()
	{
		if (!true)
		{
		}
		GUIPageIconGrouping categoryGrouping = InterfaceStyles_Layout.Active.GetCategoryGrouping(GUIPageIcons.Category.Research, true);
		GUIInputRegionExclusive pickingInterceptor = this.PickingInterceptor;
		if (pickingInterceptor != null)
		{
		}
		if (pickingInterceptor == null)
		{
		}
		if (!true)
		{
		}
		Main.FlushBatches();
		this.DrawResearchBacking();
		this.DrawResearchCogs();
		this.DrawItemProgress();
		this.DrawResearchParticles();
		Panel_Layout divider = Research_Layout.Instance.Divider;
		Panel_Layout divider2 = Research_Layout.Instance.Divider2;
		this.DrawMainButtons();
		GUIInputRegionExclusive pickingInterceptor2 = this.PickingInterceptor;
		if (pickingInterceptor2 != null)
		{
			pickingInterceptor2.Active = true;
		}
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x00030E94 File Offset: 0x0002F094
	private void DrawResearchParticles()
	{
		if (this.ResearchAnimationInProgress)
		{
			int size = this.ResearchParticles._size;
			int size2 = this.ResearchParticles._size;
		}
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x00030EC4 File Offset: 0x0002F0C4
	private void DrawMainButtons()
	{
		int num = 1;
		int openedFrame = this.OpenedFrame;
		if (num == 0)
		{
		}
		Research_Layout instance = Research_Layout.Instance;
		TransactionButton_Layout close = instance.Close;
		GUITransactionButton.InputState inputState2;
		if (!this.ResearchAnimationInProgress)
		{
			TransactionButton_Layout actionResearch = instance.ActionResearch;
			string textValue = Language.GetTextValue("Mobile.Research");
			GUITransactionButton.InputState inputState;
			if (inputState == GUITransactionButton.InputState.Clicked)
			{
				this.ActionResearch();
				while (inputState2 != GUITransactionButton.InputState.Clicked)
				{
				}
				goto IL_004B;
			}
		}
		if (inputState2 != GUITransactionButton.InputState.Clicked)
		{
			return;
		}
		IL_004B:
		this.Close();
	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x000021DB File Offset: 0x000003DB
	private void BeginResearchAnimation(int itemResearched, int amountStart, int amountSubmitted, bool completed)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000A38 RID: 2616 RVA: 0x00030F24 File Offset: 0x0002F124
	private void ActionResearch()
	{
		int num = 1;
		Item researchItem = this.GetResearchItem();
		bool isAir = researchItem.IsAir;
		if (num == 0)
		{
		}
		int type = researchItem.type;
		if (num == 0)
		{
		}
		ItemsSacrificedUnlocksTracker itemSacrifices = Main.LocalPlayerCreativeTracker.ItemSacrifices;
		int type2 = researchItem.type;
		int sacrificeCount = itemSacrifices.GetSacrificeCount(type2);
		int stack = researchItem.stack;
		int type3 = researchItem.type;
		if (stack == 0)
		{
		}
		if (stack != 0)
		{
			NetPacket netPacket = NetCreativeUnlocksPlayerReportModule.SerializeSacrificeRequest(researchItem.type, 1073741824);
			if (stack == 0)
			{
			}
			return;
		}
		if (stack == 0)
		{
		}
		ItemsSacrificedUnlocksTracker itemSacrifices2 = Main.LocalPlayerCreativeTracker.ItemSacrifices;
		int type4 = researchItem.type;
		itemSacrifices2.RegisterItemSacrifice(type4, 1073741824);
		int stack2 = researchItem.stack;
		researchItem.stack = stack2;
		long num2 = 0L;
		researchItem.TurnToAir(num2 != 0L);
		if (stack2 == 0)
		{
		}
		Recipe.FindRecipes(false);
	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x00030FF0 File Offset: 0x0002F1F0
	private void DrawBacking()
	{
		ControlAnchor.SetGridItemRegion(GUIPanel.Region(Research_Layout.Instance.Backing));
	}

	// Token: 0x06000A3A RID: 2618 RVA: 0x000021DB File Offset: 0x000003DB
	private int UpdateResearchAnimation()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x00031014 File Offset: 0x0002F214
	private void DrawResearchBacking()
	{
		Research_Layout instance = Research_Layout.Instance;
		Panel_Layout imageBacking = instance.ImageBacking;
		Rectangle rectangle = GUIPanel.Region(instance.ResearchItemBacking);
		int num = this.UpdateResearchAnimation();
		this.DrawResearchItem();
		if (!true)
		{
		}
		Vector2 vector = rectangle.TopLeft();
		Vector2 vector2 = rectangle.Size();
		Color backingColor = instance.ResearchItemBacking.BackingColor;
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x0003106C File Offset: 0x0002F26C
	public Rectangle SetupFrame(Texture2D texture, int frameCountHorizontal, int frameCountVertical, int frameX, int frameY)
	{
		if (!true)
		{
		}
		long num = 0L;
		long num2 = 0L;
		return texture.Frame(frameCountHorizontal, frameCountVertical, frameX, frameY, (int)num, (int)num2);
	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x00031090 File Offset: 0x0002F290
	public void DrawResearchCogs()
	{
		float smallRotation = this._smallRotation;
		float largeRotation = this._largeRotation;
		this._smallRotation = smallRotation;
		this._largeRotation = largeRotation;
		Research_Layout instance = Research_Layout.Instance;
		Panel_Layout researchCogLeft = instance.ResearchCogLeft1;
		float smallRotation2 = this._smallRotation;
		Panel_Layout researchCogRight = instance.ResearchCogRight1;
		float smallRotation3 = this._smallRotation;
		Panel_Layout researchCogLeft2 = instance.ResearchCogLeft2;
		float mediumRotation = this._mediumRotation;
		Panel_Layout researchCogRight2 = instance.ResearchCogRight2;
		float mediumRotation2 = this._mediumRotation;
		Panel_Layout researchCogLeft3 = instance.ResearchCogLeft3;
		float largeRotation2 = this._largeRotation;
		Panel_Layout researchCogRight3 = instance.ResearchCogRight3;
		float largeRotation3 = this._largeRotation;
	}

	// Token: 0x06000A3E RID: 2622 RVA: 0x00031124 File Offset: 0x0002F324
	public void DrawTexture(Panel_Layout layout, Texture2D texture, float rotation)
	{
		Rectangle rectangle = GUIPanel.Region(layout);
		if (!true)
		{
		}
		Vector2 vector = rectangle.TopLeft();
		Vector2 vector2 = rectangle.Size();
		Color backingColor = layout.BackingColor;
	}

	// Token: 0x06000A3F RID: 2623 RVA: 0x00031150 File Offset: 0x0002F350
	public void DrawTexture(Vector2 position, Vector2 size, Texture2D texture, Color color, float rotation)
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		if (!true)
		{
		}
	}

	// Token: 0x06000A40 RID: 2624 RVA: 0x00031170 File Offset: 0x0002F370
	private Item GetResearchItem()
	{
		/*
An exception occurred when decompiling this method (06000A40)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item GUIResearch::GetResearchItem()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0017:
	stloc:int32(var_3_1E, callgetter:int32(Main::get_myPlayer))
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

	// Token: 0x06000A41 RID: 2625 RVA: 0x0003119C File Offset: 0x0002F39C
	private void DrawItemProgress()
	{
		Research_Layout instance = Research_Layout.Instance;
		Item researchItem = this.GetResearchItem();
		int stack = researchItem.stack;
		String_Layout itemName = instance.ItemName;
		string name = researchItem.Name;
		GUIString.Draw(itemName, name);
		String_Layout description = instance.Description;
		string textValue = Language.GetTextValue("Mobile.ResearchDescription");
		GUIString.Draw(description, textValue);
		Panel_Layout barBacking = instance.BarBacking;
		Rectangle rectangle = GUIPanel.Region(instance.BarBacking);
		bool isAir = researchItem.IsAir;
		int type = researchItem.type;
		int researchItemStart;
		if (this.ResearchAnimationInProgress)
		{
			int researchFrame = this.ResearchFrame;
			researchItemStart = this.ResearchItemStart;
			int researchFrame2 = this.ResearchFrame;
			return;
		}
		ItemsSacrificedUnlocksTracker itemSacrifices = Main.LocalPlayerCreativeTracker.ItemSacrifices;
		int type2 = researchItem.type;
		int sacrificeCount = itemSacrifices.GetSacrificeCount(type2);
		if (researchItemStart == 0)
		{
		}
		int stack2 = researchItem.stack;
	}

	// Token: 0x06000A42 RID: 2626 RVA: 0x000312B8 File Offset: 0x0002F4B8
	private void DrawResearchItem()
	{
		Item researchItem = this.GetResearchItem();
		Research_Layout instance = Research_Layout.Instance;
		Panel_Layout researchItem2 = instance.ResearchItem;
		int num = 32640;
		float x = researchItem2.Size.X;
		float y = researchItem2.Size.Y;
		int num2 = 32768;
		if (researchItem2 == null)
		{
		}
		if (num2 == 0)
		{
		}
		if (researchItem2.Size != null)
		{
			if (num == 0)
			{
			}
			return;
		}
	}

	// Token: 0x06000A43 RID: 2627 RVA: 0x000313B4 File Offset: 0x0002F5B4
	public GUIResearch()
	{
	}

	// Token: 0x04000A0A RID: 2570
	private int OpenedFrame;

	// Token: 0x04000A0B RID: 2571
	public bool Displaying;

	// Token: 0x04000A0C RID: 2572
	private static Asset<Texture2D> pistonsAsset;

	// Token: 0x04000A0D RID: 2573
	private static Asset<Texture2D> pistonParticleAsset;

	// Token: 0x04000A0E RID: 2574
	private static Asset<Texture2D> cogsSmall;

	// Token: 0x04000A0F RID: 2575
	private static Asset<Texture2D> cogsMedium;

	// Token: 0x04000A10 RID: 2576
	private static Asset<Texture2D> cogsLarge;

	// Token: 0x04000A11 RID: 2577
	private float inventoryResearchScale;

	// Token: 0x04000A12 RID: 2578
	private GUIInputRegionExclusive PickingInterceptor;

	// Token: 0x04000A13 RID: 2579
	private int selectedResearchItem;

	// Token: 0x04000A14 RID: 2580
	private float closeScale;

	// Token: 0x04000A15 RID: 2581
	private float researchScale;

	// Token: 0x04000A16 RID: 2582
	public bool ResearchAnimationInProgress;

	// Token: 0x04000A17 RID: 2583
	private DateTime ResearchAnimationTime;

	// Token: 0x04000A18 RID: 2584
	private int ResearchItem;

	// Token: 0x04000A19 RID: 2585
	private int ResearchItemStart;

	// Token: 0x04000A1A RID: 2586
	private int ResearchItemCount;

	// Token: 0x04000A1B RID: 2587
	private int ResearchFrame;

	// Token: 0x04000A1C RID: 2588
	private bool ResearchCompleted;

	// Token: 0x04000A1D RID: 2589
	private ParticleRendererSettings ResearchParticleSettings;

	// Token: 0x04000A1E RID: 2590
	private List<CreativeSacrificeParticle> ResearchParticles;

	// Token: 0x04000A1F RID: 2591
	private float _smallRotation;

	// Token: 0x04000A20 RID: 2592
	private float _mediumRotation;

	// Token: 0x04000A21 RID: 2593
	private float _largeRotation;

	// Token: 0x04000A22 RID: 2594
	private float testProgress;

	// Token: 0x0200016B RID: 363
	public enum ResearchState
	{
		// Token: 0x04000A24 RID: 2596
		Invalid,
		// Token: 0x04000A25 RID: 2597
		Valid,
		// Token: 0x04000A26 RID: 2598
		Complete
	}
}
