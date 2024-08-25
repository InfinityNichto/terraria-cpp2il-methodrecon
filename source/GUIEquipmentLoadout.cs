using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.UI;

// Token: 0x02000140 RID: 320
public class GUIEquipmentLoadout
{
	// Token: 0x060008A1 RID: 2209 RVA: 0x00023C24 File Offset: 0x00021E24
	public void CloseExpandedFilter()
	{
		if (this.Expanded)
		{
			return;
		}
	}

	// Token: 0x060008A2 RID: 2210 RVA: 0x00023C3C File Offset: 0x00021E3C
	public Rectangle GetRegion()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x060008A3 RID: 2211 RVA: 0x00023C58 File Offset: 0x00021E58
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
		string textValue = Language.GetTextValue("Mobile.LoadoutsToggleButton");
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
			guicontrollerEquipment.inLoadout = num != 0;
			return;
		}
	}

	// Token: 0x060008A4 RID: 2212 RVA: 0x00023E48 File Offset: 0x00022048
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

	// Token: 0x060008A5 RID: 2213 RVA: 0x00023E80 File Offset: 0x00022080
	private void DrawLoadouts()
	{
		this.loadoutOver = 1;
		!0 instance = PageControllerLayoutDefinition.Instance;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
	}

	// Token: 0x060008A6 RID: 2214 RVA: 0x00023EA0 File Offset: 0x000220A0
	public float LoadoutScale(int index)
	{
		/*
An exception occurred when decompiling this method (060008A6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIEquipmentLoadout::LoadoutScale(System.Int32)

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

	// Token: 0x060008A7 RID: 2215 RVA: 0x00023EB4 File Offset: 0x000220B4
	public void LoadoutOver(int index)
	{
		int num = 1;
		this.loadoutOver = index;
		if (num == 0)
		{
		}
		ItemSlot.UpdateTooltipContext(48, index);
		if (num == 0)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		if (num == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		this.CloseExpandedFilter();
	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x00023F00 File Offset: 0x00022100
	public void LoadoutDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		int num = 1;
		if (num == 0)
		{
		}
		int num2 = 32640;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		if (this.loadoutOver == 0)
		{
		}
		string text;
		string textValue = Language.GetTextValue("UI.Loadout" + text);
		if ("UI.Loadout" == null)
		{
		}
		if ("UI.Loadout" == null)
		{
		}
		if ("UI.Loadout" == null)
		{
		}
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (num2 == 0)
		{
		}
		Rectangle rectangle;
		Vector2 vector = rectangle.Size();
	}

	// Token: 0x060008A9 RID: 2217 RVA: 0x00023F7C File Offset: 0x0002217C
	public GUIEquipmentLoadout()
	{
	}

	// Token: 0x04000775 RID: 1909
	public bool Expanded;

	// Token: 0x04000776 RID: 1910
	private GUIInputRegionExclusive pickingInterceptor;

	// Token: 0x04000777 RID: 1911
	private float buttonScale;

	// Token: 0x04000778 RID: 1912
	private int loadoutOver;

	// Token: 0x04000779 RID: 1913
	private float HideShowButtonScale;
}
