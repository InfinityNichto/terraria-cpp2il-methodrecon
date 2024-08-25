using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.UI;

// Token: 0x02000121 RID: 289
public class GUIAccessoryInfoToggles
{
	// Token: 0x0600073D RID: 1853 RVA: 0x0001A9D0 File Offset: 0x00018BD0
	public void CloseExpandedFilter()
	{
		if (this.Expanded)
		{
			return;
		}
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x0001A9E8 File Offset: 0x00018BE8
	public Rectangle GetRegion()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x0001AA04 File Offset: 0x00018C04
	public void DrawToggles()
	{
		if (this.Expanded)
		{
			Rectangle region = this.GetRegion();
			!0 instance = PageControllerLayoutDefinition.Instance;
			TransactionButton_Layout transactionButton_Layout;
			Rectangle region2 = GUITransactionButton.GetRegion(transactionButton_Layout);
			if (!this.Expanded)
			{
				!0 instance2 = PageControllerLayoutDefinition.Instance;
				TransactionButton_Layout transactionButton_Layout2;
				Rectangle region3 = GUITransactionButton.GetRegion(transactionButton_Layout2);
			}
			this.CloseExpandedFilter();
			return;
		}
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		string textValue = Language.GetTextValue("Mobile.InfoAccessoriesToggleButton");
		if (this.Expanded)
		{
			bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
			if (this.pickingInterceptor == null)
			{
				GUIInputRegionExclusive guiinputRegionExclusive;
				this.pickingInterceptor = guiinputRegionExclusive;
				if (guiinputRegionExclusive != null)
				{
				}
			}
			int num = 1;
			GUIControllerEquipment guicontrollerEquipment;
			guicontrollerEquipment.inAccessories = num != 0;
			return;
		}
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x0001AB30 File Offset: 0x00018D30
	public bool IsOver(Vector2 cursorPosition)
	{
		long num = 0L;
		if (this.Expanded)
		{
			bool flag;
			return flag;
		}
		return this.GetRegion().Contains(6, (int)num);
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x0001AB68 File Offset: 0x00018D68
	private void DrawInfoAccesoriesToggles()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x0001AB84 File Offset: 0x00018D84
	public float InfoAccScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000742)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIAccessoryInfoToggles::InfoAccScale(System.Int32)

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

	// Token: 0x06000743 RID: 1859 RVA: 0x0001AB98 File Offset: 0x00018D98
	public void InfoAccOver(int index)
	{
		int num = 1;
		this.accOver = index;
		if (num == 0)
		{
		}
		ItemSlot.UpdateTooltipContext(44, index);
		bool mouseLeftRelease = Main.mouseLeftRelease;
		bool mouseLeft = Main.mouseLeft;
	}

	// Token: 0x06000744 RID: 1860 RVA: 0x0001AC00 File Offset: 0x00018E00
	public void InfoAccDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		int num = 32640;
		int myPlayer = Main.myPlayer;
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (num == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x0001AC90 File Offset: 0x00018E90
	public GUIAccessoryInfoToggles()
	{
	}

	// Token: 0x040005A8 RID: 1448
	public bool Expanded;

	// Token: 0x040005A9 RID: 1449
	private GUIInputRegionExclusive pickingInterceptor;

	// Token: 0x040005AA RID: 1450
	private float buttonScale;

	// Token: 0x040005AB RID: 1451
	private int accOver;

	// Token: 0x040005AC RID: 1452
	private float HideShowButtonScale;
}
