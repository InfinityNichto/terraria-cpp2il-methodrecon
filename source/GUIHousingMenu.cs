using System;
using System.Collections.Generic;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.UI;

// Token: 0x02000149 RID: 329
public class GUIHousingMenu
{
	// Token: 0x170000DF RID: 223
	// (get) Token: 0x060008EB RID: 2283 RVA: 0x000261F8 File Offset: 0x000243F8
	// (set) Token: 0x060008EC RID: 2284 RVA: 0x0002620C File Offset: 0x0002440C
	public bool Visible
	{
		get
		{
			return this._visible;
		}
		set
		{
			if (!true)
			{
			}
		}
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x0002621C File Offset: 0x0002441C
	public void LoadPageRegion()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle;
		ControlAnchor.PageContentRegion = rectangle;
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x00026238 File Offset: 0x00024438
	private void DrawPageIcons()
	{
	}

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x060008EF RID: 2287 RVA: 0x00026248 File Offset: 0x00024448
	public bool collapsed
	{
		get
		{
			if (!true)
			{
			}
			return InterfaceStyles_Layout.Active.IsCollapsed(GUIPageIcons.Category.Housing);
		}
	}

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00026268 File Offset: 0x00024468
	private Texture2D _npcHeadTextureEmpty
	{
		get
		{
			!0 instance = PageControllerLayoutDefinition.Instance;
			Texture2D texture2D;
			return texture2D;
		}
	}

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0002627C File Offset: 0x0002447C
	public bool HasFocus
	{
		get
		{
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			return true;
		}
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x000021DB File Offset: 0x000003DB
	private void RefreshNPCEntries()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x00026294 File Offset: 0x00024494
	public float NPCScale(int index)
	{
		/*
An exception occurred when decompiling this method (060008F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIHousingMenu::NPCScale(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!0(var_0_05, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
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

	// Token: 0x060008F4 RID: 2292 RVA: 0x000262A8 File Offset: 0x000244A8
	public void NPCOver(int index)
	{
		int num = 1;
		this.over = index;
		if (num == 0)
		{
		}
		ItemSlot.UpdateTooltipContext(37, index);
		if (index == 0)
		{
			bool mouseLeft = Main.mouseLeft;
			if (Main.mouseItem.type == 0)
			{
				GUIControllerHousing guicontrollerHousing;
				if (guicontrollerHousing != null)
				{
					long num2 = 0L;
					GUIControllerDynamicGridNavigator guicontrollerDynamicGridNavigator;
					guicontrollerDynamicGridNavigator.Activate((int)num2);
				}
				if (this._lastNPCOVer != 0)
				{
					return;
				}
			}
			if (Main.mouseItem.type == 0)
			{
				int num3 = 1;
				this._npcOver = num3 != 0;
			}
			return;
		}
		List<int> activeNPCEntries = this._activeNPCEntries;
		if (num == 0)
		{
		}
		List<int> activeNPCEntries2 = this._activeNPCEntries;
		string text;
		this.npcString = text;
		bool mouseLeft2 = Main.mouseLeft;
		if (Main.mouseItem.type == 0)
		{
			List<int> activeNPCEntries3 = this._activeNPCEntries;
			GUIControllerHousing guicontrollerHousing2;
			if (guicontrollerHousing2 != null)
			{
				GUIControllerDynamicGridNavigator guicontrollerDynamicGridNavigator2;
				guicontrollerDynamicGridNavigator2.Activate(index);
			}
			bool mouseLeftRelease = Main.mouseLeftRelease;
			int lastNPCOVer = this._lastNPCOVer;
			List<int> activeNPCEntries4 = this._activeNPCEntries;
			List<int> activeNPCEntries5 = this._activeNPCEntries;
			object syncRoot = this._activeNPCEntries._syncRoot;
			Main.mouseLeftRelease = false;
			return;
		}
		string text2 = this.npcString;
	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x000263B8 File Offset: 0x000245B8
	public void NPCDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		if (index != 0)
		{
			List<int> activeNPCEntries = this._activeNPCEntries;
			List<int> activeNPCEntries2 = this._activeNPCEntries;
			return;
		}
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x000265F4 File Offset: 0x000247F4
	public void UpdateHotbarNavigation()
	{
		ControllerDevice controllerDevice;
		bool[] keyState = controllerDevice._KeyState;
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x0002666C File Offset: 0x0002486C
	private void PreviousItem()
	{
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x00026684 File Offset: 0x00024884
	private void NextItem()
	{
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x0002669C File Offset: 0x0002489C
	private void UpdateHotbarScroll()
	{
		float scrollAmount = this.ScrollAmount;
		float mouseScrollDelta = XNAUnityRunner.GetMouseScrollDelta(false);
	}

	// Token: 0x060008FA RID: 2298 RVA: 0x000266C4 File Offset: 0x000248C4
	public void Draw()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		this.UpdateHotbarNavigation();
		this.RefreshNPCEntries();
		bool npcOver = this._npcOver;
		if (!npcOver)
		{
			this._lastNPCOVer = (npcOver ? 1 : 0);
		}
		this.over = (npcOver ? 1 : 0);
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		DraggableItemGrid_Layout draggableItemGrid_Layout;
		int itemCount = draggableItemGrid_Layout.ItemCount;
		Rectangle rectangle;
		if (rectangle == null)
		{
		}
		int mouseX = Main.mouseX;
		int mouseY = Main.mouseY;
		!0 instance4 = PageControllerLayoutDefinition.Instance;
		List<int> activeNPCEntries = this._activeNPCEntries;
		int size = activeNPCEntries._size;
		if (activeNPCEntries == null)
		{
		}
		GUIControllerHousing guicontrollerHousing;
		if (guicontrollerHousing != null)
		{
			GUIControllerDynamicGridNavigator guicontrollerDynamicGridNavigator;
			guicontrollerDynamicGridNavigator.DisableScrollUntilChange();
		}
		bool npcOver2 = this._npcOver;
		if (npcOver2)
		{
			if (!npcOver2)
			{
			}
			bool npcOver3 = this._npcOver;
			int num;
			this._lastNPCOVer = num;
			if (npcOver3)
			{
				if (!npcOver3)
				{
				}
				string text = this.npcString;
				return;
			}
		}
		else
		{
			bool npcOver3;
			this._lastNPCOVer = (npcOver3 ? 1 : 0);
		}
	}

	// Token: 0x060008FB RID: 2299 RVA: 0x000267A8 File Offset: 0x000249A8
	public GUIHousingMenu()
	{
	}

	// Token: 0x040007C0 RID: 1984
	private bool _visible;

	// Token: 0x040007C1 RID: 1985
	public int LastNPCHousingHover;

	// Token: 0x040007C2 RID: 1986
	public int NPCHousingHover;

	// Token: 0x040007C3 RID: 1987
	public List<int> _activeNPCEntries;

	// Token: 0x040007C4 RID: 1988
	public string npcString;

	// Token: 0x040007C5 RID: 1989
	private int _lastNPCOVer;

	// Token: 0x040007C6 RID: 1990
	private bool _npcOver;

	// Token: 0x040007C7 RID: 1991
	private int over;

	// Token: 0x040007C8 RID: 1992
	private Texture2D _npcHeadTexture;

	// Token: 0x040007C9 RID: 1993
	public float scrollOffset;

	// Token: 0x040007CA RID: 1994
	private float scrollMomentum;

	// Token: 0x040007CB RID: 1995
	private int scrollDragging;

	// Token: 0x040007CC RID: 1996
	private Vector2 dragOffset;

	// Token: 0x040007CD RID: 1997
	private float scrollDelay;

	// Token: 0x040007CE RID: 1998
	private int _npcCount;

	// Token: 0x040007CF RID: 1999
	public int ActiveNPCCount;

	// Token: 0x040007D0 RID: 2000
	private float HousingQueryScale = (float)16256;

	// Token: 0x040007D1 RID: 2001
	public bool menuTogglePressed;

	// Token: 0x040007D2 RID: 2002
	private DateTime NavigationTick;

	// Token: 0x040007D3 RID: 2003
	private bool hotbarActive;

	// Token: 0x040007D4 RID: 2004
	private float ScrollAmount;
}
