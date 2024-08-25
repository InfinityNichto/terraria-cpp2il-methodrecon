using System;
using Controller;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.UI;

// Token: 0x02000148 RID: 328
public class GUIHotbar
{
	// Token: 0x060008DD RID: 2269 RVA: 0x00025910 File Offset: 0x00023B10
	public GUIHotbar()
	{
	}

	// Token: 0x060008DE RID: 2270 RVA: 0x0002592C File Offset: 0x00023B2C
	public float ItemScale(int index)
	{
		/*
An exception occurred when decompiling this method (060008DE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIHotbar::ItemScale(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00B6:
	stloc:float32(var_27_C3, ldfld:float32(Hotbar_Layout::ScaleSpeed, callgetter:Hotbar_Layout(Hotbar_Layout::get_Instance)))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](index), ldloc:float32[exp:int32](var_27_C3))
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

	// Token: 0x060008DF RID: 2271 RVA: 0x00025A08 File Offset: 0x00023C08
	public void ItemOver(int index)
	{
		int num = 1;
		this.cursorOver = index;
		if (num == 0)
		{
		}
		ItemSlot.UpdateTooltipContext(46, index);
		if (num == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (num == 0)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x00025A6C File Offset: 0x00023C6C
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		bool flag = this.menuTogglePressed;
		if (flag)
		{
			int selectedItem = this.hotbarController.GetSelectedItem();
			if (!flag)
			{
			}
			int myPlayer = Main.myPlayer;
			if (!flag)
			{
				if (!flag)
				{
				}
				int myPlayer2 = Main.myPlayer;
				int myPlayer3 = Main.myPlayer;
				int myPlayer4 = Main.myPlayer;
				int myPlayer5 = Main.myPlayer;
			}
		}
		int num = 17174;
		int num2 = 17046;
		if (num == 0)
		{
		}
		if (num2 == 0)
		{
		}
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		int myPlayer6 = Main.myPlayer;
		if (num == 0)
		{
		}
		int myPlayer7 = Main.myPlayer;
		if (num == 0)
		{
		}
		int myPlayer8 = Main.myPlayer;
		if (num == 0)
		{
		}
		int myPlayer9 = Main.myPlayer;
		if (num2 == 0)
		{
		}
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x00025B3C File Offset: 0x00023D3C
	public void UpdateHotbarKeybinds()
	{
		ControllerDevice controllerDevice;
		bool[] keyState = controllerDevice._KeyState;
		long num = 0L;
		this.SetItem((int)num);
		int num2 = 1;
		this.SetItem(num2);
		int num3 = 2;
		this.SetItem(num3);
		int num4 = 3;
		this.SetItem(num4);
		int num5 = 4;
		this.SetItem(num5);
		int num6 = 5;
		this.SetItem(num6);
		int num7 = 6;
		this.SetItem(num7);
		int num8 = 7;
		this.SetItem(num8);
		int num9 = 8;
		this.SetItem(num9);
		int num10 = 9;
		this.SetItem(num10);
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		int myPlayer3 = Main.myPlayer;
		int myPlayer4 = Main.myPlayer;
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x00025BF4 File Offset: 0x00023DF4
	private void UpdateHotbarScroll()
	{
		float scrollAmount = this.ScrollAmount;
		float mouseScrollDelta = XNAUnityRunner.GetMouseScrollDelta(false);
		this.PreviousItem();
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x00025C28 File Offset: 0x00023E28
	public void UpdateHotbarNavigation()
	{
		ControllerDevice controllerDevice;
		bool[] keyState = controllerDevice._KeyState;
		this.NextItem();
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x00025CC4 File Offset: 0x00023EC4
	public Rectangle GetRegion()
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
		int myPlayer3 = Main.myPlayer;
		if (10 == 0)
		{
		}
		InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
		GUIPageIconGrouping guipageIconGrouping;
		guipageIconGrouping.LoadPageAnchor();
		Hotbar_Layout instance = Hotbar_Layout.Instance;
		GUIItemGrid.GetItemScaleHandler getItemScaleHandler = this.itemScale;
		if (instance == null)
		{
		}
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x00025D24 File Offset: 0x00023F24
	public void Draw()
	{
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		this.UpdateHotbarKeybinds();
		int myPlayer3 = Main.myPlayer;
		InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
		GUIPageIconGrouping guipageIconGrouping;
		guipageIconGrouping.LoadPageAnchor();
		int myPlayer4 = Main.myPlayer;
		int myPlayer5 = Main.myPlayer;
		int myPlayer6 = Main.myPlayer;
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x00025E3C File Offset: 0x0002403C
	public void DrawHotbarItem(SpriteBatch spriteBatch, ItemGrid_Layout layout, Item[] inv, int slot, Vector2 position, Color lightColor, float scale)
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		int num = this.cursorOver;
		Cursor cursor;
		if (cursor != null)
		{
		}
		bool flag = this.menuTogglePressed;
		if (flag)
		{
			if (!flag)
			{
			}
			return;
		}
	}

	// Token: 0x060008E7 RID: 2279 RVA: 0x00026030 File Offset: 0x00024230
	public void SetItem(int item)
	{
		int num = 1;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (num == 0)
		{
			int myPlayer2 = Main.myPlayer;
			int myPlayer3 = Main.myPlayer;
		}
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x00026064 File Offset: 0x00024264
	public void NextItem()
	{
		int num = 1;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (num == 0)
		{
			int myPlayer2 = Main.myPlayer;
			return;
		}
	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x00026128 File Offset: 0x00024328
	private void RefreshInvCursorPosition(int itemOver)
	{
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x00026140 File Offset: 0x00024340
	public void PreviousItem()
	{
		int num = 1;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (num == 0)
		{
			int myPlayer2 = Main.myPlayer;
			return;
		}
	}

	// Token: 0x040007B5 RID: 1973
	private int cursorOver = 1;

	// Token: 0x040007B6 RID: 1974
	private float TimeSinceItemChange;

	// Token: 0x040007B7 RID: 1975
	private string LastItem;

	// Token: 0x040007B8 RID: 1976
	public bool menuTogglePressed;

	// Token: 0x040007B9 RID: 1977
	public bool hotbarActive;

	// Token: 0x040007BA RID: 1978
	public GUIControllerHotbarRadial hotbarController;

	// Token: 0x040007BB RID: 1979
	private DateTime NavigationTick;

	// Token: 0x040007BC RID: 1980
	private float ScrollAmount;

	// Token: 0x040007BD RID: 1981
	private GUIItemGrid.GetItemScaleHandler itemScale;

	// Token: 0x040007BE RID: 1982
	private GUIItemGrid.CursorOver itemOver;

	// Token: 0x040007BF RID: 1983
	private GUIItemGrid.DrawItemHandler itemDraw;
}
