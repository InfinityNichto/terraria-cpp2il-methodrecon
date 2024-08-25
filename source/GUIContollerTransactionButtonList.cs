using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x02000084 RID: 132
public class GUIContollerTransactionButtonList : GUIControllerItem
{
	// Token: 0x06000332 RID: 818 RVA: 0x0000A93C File Offset: 0x00008B3C
	public int GetNavigationOutDirs()
	{
		while (this._wrapAround)
		{
			bool vertical = this._vertical;
			int selectedItem = this._selectedItem;
			if (vertical)
			{
				Vector2 location = this._items.Location;
				return;
			}
		}
	}

	// Token: 0x06000333 RID: 819 RVA: 0x0000A970 File Offset: 0x00008B70
	public GUIContollerTransactionButtonList(bool vertical, bool wrapAround, TransactionButton_Layout[] items, [Optional] GUIContollerTransactionButtonList.SetupRegions regionSetup)
	{
		this._items = items;
		this._regionSetup = regionSetup;
	}

	// Token: 0x06000334 RID: 820 RVA: 0x0000A994 File Offset: 0x00008B94
	public void Activate()
	{
	}

	// Token: 0x06000335 RID: 821 RVA: 0x0000A9A4 File Offset: 0x00008BA4
	public void SelectOption(int option)
	{
		this._selectedItem = option;
	}

	// Token: 0x06000336 RID: 822 RVA: 0x0000A9B8 File Offset: 0x00008BB8
	public Rectangle GetSelectedItemRegion()
	{
		GUIContollerTransactionButtonList.SetupRegions regionSetup = this._regionSetup;
		if (regionSetup != null)
		{
			IntPtr invoke_impl = regionSetup.invoke_impl;
			IntPtr method_code = regionSetup.method_code;
			IntPtr method = regionSetup.method;
		}
		float scale = this._items.Scale;
		GUIContollerTransactionButtonList.SetupRegions regionSetup2 = this._regionSetup;
		if (regionSetup2 != null)
		{
			IntPtr invoke_impl2 = regionSetup2.invoke_impl;
			IntPtr method_code2 = regionSetup2.method_code;
			IntPtr method2 = regionSetup2.method;
		}
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x06000337 RID: 823 RVA: 0x0000AA1C File Offset: 0x00008C1C
	public GUIControllerItem Navigate(Vector2 navigationAxis)
	{
		/*
An exception occurred when decompiling this method (06000337)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIContollerTransactionButtonList::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003B:
	stloc:Vector2(var_5_46, ldfld:Vector2(Button_Layout::Location, ldfld:class TransactionButton_Layout[][exp:Button_Layout](GUIContollerTransactionButtonList::_items, ldloc:GUIContollerTransactionButtonList(this))))
	stfld:int32(GUIContollerTransactionButtonList::_selectedItem, ldloc:GUIContollerTransactionButtonList(this), ldloc:int32(var_3_2A))
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

	// Token: 0x04000339 RID: 825
	private bool _vertical;

	// Token: 0x0400033A RID: 826
	private bool _wrapAround;

	// Token: 0x0400033B RID: 827
	private int _selectedItem;

	// Token: 0x0400033C RID: 828
	private TransactionButton_Layout[] _items;

	// Token: 0x0400033D RID: 829
	private GUIContollerTransactionButtonList.SetupRegions _regionSetup;

	// Token: 0x02000085 RID: 133
	public sealed class SetupRegions : MulticastDelegate
	{
		// Token: 0x06000338 RID: 824 RVA: 0x0000AA78 File Offset: 0x00008C78
		public SetupRegions(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000AACC File Offset: 0x00008CCC
		public void Invoke(bool setup)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(bool setup, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000AAF0 File Offset: 0x00008CF0
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
