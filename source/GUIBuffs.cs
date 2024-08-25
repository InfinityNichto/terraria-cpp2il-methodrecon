using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.Localization;
using Terraria.UI;
using UnityEngine;

// Token: 0x02000125 RID: 293
public class GUIBuffs
{
	// Token: 0x06000789 RID: 1929 RVA: 0x0001C344 File Offset: 0x0001A544
	public GUIBuffs()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x0001C364 File Offset: 0x0001A564
	public Rectangle GetRegion()
	{
		Buffs_Layout instance = Buffs_Layout.Instance;
		if (instance == null)
		{
		}
		float num = instance.ItemScale;
		if (32 == 0)
		{
		}
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x0001C388 File Offset: 0x0001A588
	private void ChangeBuffString(int buffType)
	{
		if (!true)
		{
		}
		string buffDescription = Lang.GetBuffDescription(buffType);
		bool expertMode = Main.expertMode;
		string textValue = Language.GetTextValue("BuffDescription.WellFed_Expert");
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x0001C3B4 File Offset: 0x0001A5B4
	private void NextItem()
	{
		float uitextAlpha = XNAUIInputLayer.UITextAlpha;
		GUIControllerBuff guicontrollerBuff = this.buffController;
		this.buffActive = true;
		guicontrollerBuff.Activate();
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x0001C3FC File Offset: 0x0001A5FC
	private void PreviousItem()
	{
		float uitextAlpha = XNAUIInputLayer.UITextAlpha;
		GUIControllerBuff guicontrollerBuff = this.buffController;
		this.buffActive = true;
		guicontrollerBuff.Activate();
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x0001C444 File Offset: 0x0001A644
	private void RemoveBuff()
	{
		GUIControllerBuff guicontrollerBuff = this.buffController;
		int num = this.numActiveBuffs;
		int[] array = this.activeBuffs;
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x0001C468 File Offset: 0x0001A668
	public void UpdateBuffNavigation()
	{
		int num = this.numActiveBuffs;
		int num2 = this.numActiveBuffs;
		if (this.buffActive && this.numActiveBuffs != 0)
		{
			bool flag = this.CanRemoveBuff();
			return;
		}
		int num3 = this.numActiveBuffs;
		float uitextAlpha = XNAUIInputLayer.UITextAlpha;
		if (!this.buffTogglePressed)
		{
			this.NextItem();
			return;
		}
		if (this.buffActive)
		{
			GUIControllerBuff guicontrollerBuff = this.buffController;
			int num4 = this.numActiveBuffs;
			int[] array = this.activeBuffs;
			return;
		}
		int num5 = 1;
		this.buffActive = num5 != 0;
		float uitextAlpha2 = XNAUIInputLayer.UITextAlpha;
		this.buffController.Activate();
		if (num5 == 0)
		{
		}
		DateTime now = DateTime.Now;
		this.NavigationTick = now;
		GUIControllerBuff guicontrollerBuff2 = this.buffController;
		Mouse.UpdateUICursorPoint();
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x0001C534 File Offset: 0x0001A734
	private bool CanRemoveBuff()
	{
		/*
An exception occurred when decompiling this method (06000790)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIBuffs::CanRemoveBuff()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:int32(var_3_1D, callgetter:int32(Main::get_myPlayer))
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

	// Token: 0x06000791 RID: 1937 RVA: 0x0001C564 File Offset: 0x0001A764
	private void RemoveBuff(int buff)
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x0001C608 File Offset: 0x0001A808
	public void Draw()
	{
		InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
		GUIPageIconGrouping guipageIconGrouping;
		guipageIconGrouping.LoadPageAnchor();
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		this.UpdateBuffNavigation();
		float num = this.lastdoubleClickTimer;
		float deltaTime = Time.deltaTime;
		int myPlayer3 = Main.myPlayer;
		int[] array = this.activeBuffs;
		int num2 = this.numActiveBuffs;
		this.numActiveBuffs = num2;
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x0001C714 File Offset: 0x0001A914
	public float ItemScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000793)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIBuffs::ItemScale(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_1_0C, ldfld:float32(Buffs_Layout::ItemScale, callgetter:Buffs_Layout(Buffs_Layout::get_Instance)))
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

	// Token: 0x06000794 RID: 1940 RVA: 0x0001C730 File Offset: 0x0001A930
	public void ItemOver(int index)
	{
		int[] array = this.activeBuffs;
		ItemSlot.UpdateTooltipContext(47, index);
		float uitextAlpha = XNAUIInputLayer.UITextAlpha;
		bool mouseLeft = Main.mouseLeft;
		GUIControllerBuff guicontrollerBuff = this.buffController;
		int num = 1;
		this.buffActive = num != 0;
		guicontrollerBuff.Activate();
		if (num == 0)
		{
		}
		DateTime now = DateTime.Now;
		this.NavigationTick = now;
		int num2 = this.lastDrawBuffText;
		bool mouseLeft2 = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		float num3 = this.lastdoubleClickTimer;
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x0001C7D4 File Offset: 0x0001A9D4
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		int[] array = this.activeBuffs;
		int num = this.buffOver;
	}

	// Token: 0x04000607 RID: 1543
	private int buffOver;

	// Token: 0x04000608 RID: 1544
	private int buffToRemove;

	// Token: 0x04000609 RID: 1545
	private int lastDrawBuffText = 1;

	// Token: 0x0400060A RID: 1546
	private float lastdoubleClickTimer;

	// Token: 0x0400060B RID: 1547
	public int numActiveBuffs;

	// Token: 0x0400060C RID: 1548
	private int[] activeBuffs;

	// Token: 0x0400060D RID: 1549
	public bool buffTogglePressed;

	// Token: 0x0400060E RID: 1550
	public bool buffActive;

	// Token: 0x0400060F RID: 1551
	public GUIControllerBuff buffController;

	// Token: 0x04000610 RID: 1552
	private DateTime NavigationTick;

	// Token: 0x04000611 RID: 1553
	private GUIItemGrid.GetItemScaleHandler itemScale;

	// Token: 0x04000612 RID: 1554
	private GUIItemGrid.CursorOver itemOver;

	// Token: 0x04000613 RID: 1555
	private GUIItemGrid.DrawItemHandler itemDraw;
}
