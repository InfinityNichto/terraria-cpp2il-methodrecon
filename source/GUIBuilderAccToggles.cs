using System;
using System.Collections.Generic;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.UI;

// Token: 0x02000126 RID: 294
public class GUIBuilderAccToggles
{
	// Token: 0x06000796 RID: 1942 RVA: 0x0001C964 File Offset: 0x0001AB64
	public Rectangle GetRegion()
	{
		/*
An exception occurred when decompiling this method (06000796)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIBuilderAccToggles::GetRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:BuilderAccToggles_Layout(var_1_07, callgetter:BuilderAccToggles_Layout(BuilderAccToggles_Layout::get_Instance))
	stloc:ItemGrid_Layout(var_2_0E, callgetter:ItemGrid_Layout(BuilderAccToggles_Layout::get_ToggleOptionsGrid, ldloc:BuilderAccToggles_Layout(var_1_07)))
	stloc:bool(var_4_16, callgetter:bool(RightSideHUDAnchorUpdator::get_UseCollpasedCoinsAmmo))
	stloc:float32(var_5_23, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](ItemGrid_Layout::FirstItemLocation, ldloc:ItemGrid_Layout(var_2_0E))))
	stfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](ItemGrid_Layout::FirstItemLocation, ldloc:ItemGrid_Layout(var_2_0E)), ldloc:float32(var_5_23))
	stloc:class [mscorlib]System.Collections.Generic.List`1<int32>(var_6_38, ldfld:class [mscorlib]System.Collections.Generic.List`1<int32>(GUIBuilderAccToggles::items, ldloc:GUIBuilderAccToggles(this)))
	stloc:float32(var_7_45, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](GUIBuilderAccToggles::toggleSize, ldloc:GUIBuilderAccToggles(this))))
	stloc:float32(var_8_52, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](GUIBuilderAccToggles::toggleSize, ldloc:GUIBuilderAccToggles(this))))
	stloc:int32(var_9_5B, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<int32>[exp:List`1](var_6_38)))
	stloc:float32(var_11_68, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](BuilderAccToggles_Layout::BackingTLOffset, ldloc:BuilderAccToggles_Layout(var_1_07))))
	stloc:float32(var_12_75, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](BuilderAccToggles_Layout::BackingTLOffset, ldloc:BuilderAccToggles_Layout(var_1_07))))
	stloc:float32(var_13_82, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](BuilderAccToggles_Layout::BackingBROffset, ldloc:BuilderAccToggles_Layout(var_1_07))))
	stloc:float32(var_14_8F, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](BuilderAccToggles_Layout::BackingBROffset, ldloc:BuilderAccToggles_Layout(var_1_07))))
	stloc:bool(var_16_99, callgetter:bool(RightSideHUDAnchorUpdator::get_UseCollpasedCoinsAmmo))
	stloc:float32(var_17_A6, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](ItemGrid_Layout::FirstItemLocation, ldloc:ItemGrid_Layout(var_2_0E))))
	stfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](ItemGrid_Layout::FirstItemLocation, ldloc:ItemGrid_Layout(var_2_0E)), ldloc:float32(var_17_A6))
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

	// Token: 0x06000797 RID: 1943 RVA: 0x0001CA28 File Offset: 0x0001AC28
	public TransactionButton_Layout SetupLayout()
	{
		/*
An exception occurred when decompiling this method (06000797)

ICSharpCode.Decompiler.DecompilerException: Error decompiling TransactionButton_Layout GUIBuilderAccToggles::SetupLayout()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:BuilderAccToggles_Layout(var_2_07, callgetter:BuilderAccToggles_Layout(BuilderAccToggles_Layout::get_Instance))
	stloc:bool(var_4_0F, callgetter:bool(RightSideHUDAnchorUpdator::get_UseCollpasedCoinsAmmo))
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

	// Token: 0x06000798 RID: 1944 RVA: 0x0001CA48 File Offset: 0x0001AC48
	public void FinaliseLayout(TransactionButton_Layout layout)
	{
		bool useCollpasedCoinsAmmo = RightSideHUDAnchorUpdator.UseCollpasedCoinsAmmo;
		float x = layout.Location.X;
		layout.Location.X = x;
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x0001CA78 File Offset: 0x0001AC78
	public void Draw()
	{
		if (this.Enabled)
		{
			Rectangle region = this.GetRegion();
			TransactionButton_Layout transactionButton_Layout;
			Rectangle region2 = GUITransactionButton.GetRegion(transactionButton_Layout);
			bool useCollpasedCoinsAmmo = RightSideHUDAnchorUpdator.UseCollpasedCoinsAmmo;
			float x = transactionButton_Layout.Location.X;
			transactionButton_Layout.Location.X = x;
			this.Close();
			return;
		}
		bool useCollpasedCoinsAmmo2 = RightSideHUDAnchorUpdator.UseCollpasedCoinsAmmo;
		int myPlayer = Main.myPlayer;
		BuilderAccToggles_Layout instance = BuilderAccToggles_Layout.Instance;
		bool enabled = this.Enabled;
		if (this.Enabled)
		{
		}
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
	}

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x0600079A RID: 1946 RVA: 0x0001CD00 File Offset: 0x0001AF00
	public int ItemCount
	{
		get
		{
			if (this.Enabled)
			{
				return this.items._size;
			}
		}
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x000021DB File Offset: 0x000003DB
	private void RefreshList(Player plr)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x0001CD24 File Offset: 0x0001AF24
	private float ItemScale(int index)
	{
		/*
An exception occurred when decompiling this method (0600079C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIBuilderAccToggles::ItemScale(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_1_0C, ldfld:float32(BuilderAccToggles_Layout::ToggleScale, callgetter:BuilderAccToggles_Layout(BuilderAccToggles_Layout::get_Instance)))
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

	// Token: 0x0600079D RID: 1949 RVA: 0x0001CD40 File Offset: 0x0001AF40
	private void ItemOver(int index)
	{
		this.hoverItem = index;
		if (!true)
		{
		}
		ItemSlot.UpdateTooltipContext(45, index);
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x0001CD60 File Offset: 0x0001AF60
	private void ItemDraw(ItemGrid_Layout gridLayout, int z, Vector2 position, float scale)
	{
		int num = 1;
		BuilderAccToggles_Layout instance = BuilderAccToggles_Layout.Instance;
		float x = this.toggleSize.X;
		float y = this.toggleSize.Y;
		int num2 = 32640;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		List<int> list = this.items;
		BuilderAccToggles_Layout instance2 = BuilderAccToggles_Layout.Instance;
		if (num == 0)
		{
		}
		if (num2 == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
		if (num2 == 0)
		{
		}
		int num3 = this.hoverItem;
		if (num3 == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (num3 == 0)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		if (num3 == 0)
		{
		}
		int myPlayer3 = Main.myPlayer;
		int myPlayer4 = Main.myPlayer;
		int myPlayer5 = Main.myPlayer;
		if (num2 == 0)
		{
		}
		string text;
		string textValue = Language.GetTextValue(text);
		bool mouseLeft2 = Main.mouseLeft;
		bool mouseLeftRelease2 = Main.mouseLeftRelease;
		this.TooltipString = text;
		TransactionButton_Layout toggleEntry = instance.ToggleEntry;
		TransactionButton_Layout toggleEntry2 = instance.ToggleEntry;
		TransactionButton_Layout toggleEntry3 = instance.ToggleEntry;
		TransactionButton_Layout toggleEntry4 = instance.ToggleEntry;
		if (toggleEntry3 == null)
		{
		}
		int myPlayer6 = Main.myPlayer;
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x0001D034 File Offset: 0x0001B234
	public void Close()
	{
		if (!this.Enabled || this.pickingInterceptor != null)
		{
		}
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x0001D054 File Offset: 0x0001B254
	private bool IsOverBuilderTools(Vector2 position)
	{
		if (this.Enabled)
		{
			BuilderAccToggles_Layout instance = BuilderAccToggles_Layout.Instance;
			Rectangle pageGroupRegion = ControlAnchor.PageGroupRegion;
			Rectangle pageContentRegion = ControlAnchor.PageContentRegion;
			GUIPageIconGrouping categoryGrouping = InterfaceStyles_Layout.Active.GetCategoryGrouping(GUIPageIcons.Category.Inventory, 16777216 != 0);
			categoryGrouping.LoadPageAnchor();
			Rectangle region = this.GetRegion();
			ControlAnchor.PageGroupRegion = pageGroupRegion;
			ControlAnchor.PageContentRegion = pageContentRegion;
		}
		bool flag;
		return flag;
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x0001D0C4 File Offset: 0x0001B2C4
	public GUIBuilderAccToggles()
	{
	}

	// Token: 0x04000614 RID: 1556
	public bool Enabled;

	// Token: 0x04000615 RID: 1557
	private float toggleButtonScale;

	// Token: 0x04000616 RID: 1558
	private int blockReplaceIcons;

	// Token: 0x04000617 RID: 1559
	private int torchGodIcons;

	// Token: 0x04000618 RID: 1560
	private int totalDrawnIcons;

	// Token: 0x04000619 RID: 1561
	private int hoverItem;

	// Token: 0x0400061A RID: 1562
	private GUIInputRegionExclusive pickingInterceptor;

	// Token: 0x0400061B RID: 1563
	public Vector2 toggleSize;

	// Token: 0x0400061C RID: 1564
	private List<int> items;

	// Token: 0x0400061D RID: 1565
	private float TimeSinceChanged = (float)17096;

	// Token: 0x0400061E RID: 1566
	private string TooltipString;
}
