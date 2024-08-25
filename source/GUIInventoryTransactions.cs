using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.UI;

// Token: 0x0200014D RID: 333
public class GUIInventoryTransactions
{
	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x06000914 RID: 2324 RVA: 0x00027620 File Offset: 0x00025820
	public Item SelectedItem
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000914)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item GUIInventoryTransactions::get_SelectedItem()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Main::get_myPlayer))
	stloc:int32(var_3_12, callgetter:int32(Main::get_myPlayer))
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

	// Token: 0x06000915 RID: 2325 RVA: 0x00027640 File Offset: 0x00025840
	public void Draw()
	{
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x00027650 File Offset: 0x00025850
	public void SellItem()
	{
		int npcShop = Main.npcShop;
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		int myPlayer3 = Main.myPlayer;
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x00027694 File Offset: 0x00025894
	public void EquipItem()
	{
		Item item;
		if (item.maxStack == 0)
		{
		}
		Main.mouseRight = true;
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		Recipe.FindRecipes(false);
		Main.mouseRight = false;
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x0002776C File Offset: 0x0002596C
	public void PlaceItemDoll()
	{
		int myPlayer = Main.myPlayer;
		TileEntity tileEntity;
		if (tileEntity == null)
		{
			Recipe.FindRecipes(false);
			return;
		}
		bool isAir = Main.mouseItem.IsAir;
		Item item;
		if (item.accessory)
		{
			return;
		}
		Item item2;
		int headSlot = item2.headSlot;
	}

	// Token: 0x06000919 RID: 2329 RVA: 0x000277DC File Offset: 0x000259DC
	public void PlaceItemHat()
	{
		int myPlayer = Main.myPlayer;
		TileEntity tileEntity;
		if (tileEntity != null)
		{
			bool isAir = Main.mouseItem.IsAir;
			Item item;
			int headSlot = item.headSlot;
			bool isAir2 = item.IsAir;
			return;
		}
		Recipe.FindRecipes(false);
	}

	// Token: 0x0600091A RID: 2330 RVA: 0x00027834 File Offset: 0x00025A34
	public void DepositItem()
	{
		int myPlayer = Main.myPlayer;
		ChestUI.Deposit(int.MinValue);
	}

	// Token: 0x0600091B RID: 2331 RVA: 0x00027854 File Offset: 0x00025A54
	public GUIInventoryTransactions()
	{
	}

	// Token: 0x04000887 RID: 2183
	private float sellButtonScale;

	// Token: 0x04000888 RID: 2184
	private float equipButtonScale;

	// Token: 0x04000889 RID: 2185
	private float depositButtonScale = (float)16256;

	// Token: 0x0400088A RID: 2186
	public bool canBeDeposited;
}
