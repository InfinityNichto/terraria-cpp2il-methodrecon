using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x0200010C RID: 268
public static class GUIItemGrid
{
	// Token: 0x060006C6 RID: 1734 RVA: 0x00016AD0 File Offset: 0x00014CD0
	private static void DummyDraw(ItemGrid_Layout gridLayout, int itemIndex, Vector2 position, float scale)
	{
		int num = 1;
		if (num == 0)
		{
		}
		int num2 = 32640;
		if (num2 == 0)
		{
		}
		if (num == 0)
		{
		}
		if (num2 == 0)
		{
		}
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x00016AF8 File Offset: 0x00014CF8
	public static Rectangle CalculateRegion(ItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, Vector2 itemSize, int overloadedItemCount = -1)
	{
		/*
An exception occurred when decompiling this method (060006C7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIItemGrid::CalculateRegion(ItemGrid_Layout,GUIItemGrid/GetItemScaleHandler,Microsoft.Xna.Framework.Vector2,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

	// Token: 0x060006C8 RID: 1736 RVA: 0x00016B08 File Offset: 0x00014D08
	public static Rectangle CalculateRegion(ItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, int overloadedItemCount = -1, [Optional] Texture2D overloadBackingTexture)
	{
		if (overloadedItemCount != 0 || !true)
		{
		}
		if (!true)
		{
		}
		if (!true)
		{
		}
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x00016B24 File Offset: 0x00014D24
	public static void Draw(ItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, GUIItemGrid.CursorOver cursorOverHandler, GUIItemGrid.DrawItemHandler drawhandler, int overloadedItemCount = -1, [Optional] Texture2D overloadBackingTexture)
	{
		if (overloadBackingTexture != null)
		{
			if (!true)
			{
			}
			Vector2 vector = overloadBackingTexture.Size();
			if (!true)
			{
			}
			return;
		}
		if (!true)
		{
		}
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x00016B48 File Offset: 0x00014D48
	public static void Draw(ItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, GUIItemGrid.CursorOver cursorOverHandler, GUIItemGrid.DrawItemHandler drawhandler, GUIItemGrid.GetItemSizeHandler itemSizeHandler, int overloadedItemCount = -1, int reverseOrverOffset = 0, int maxRowSize = -1, int maxRowSizeLineCount = 1)
	{
		int num = 1;
		ControlAnchor.ControlId firstAnchorControl = gridLayout.FirstAnchorControl;
		Vector2 firstItemLocation = gridLayout.FirstItemLocation;
		float x = gridLayout.FirstItemLocation.X;
		float y = gridLayout.FirstItemLocation.Y;
		if (num == 0)
		{
		}
		IntPtr invoke_impl = scaleHandler.invoke_impl;
		IntPtr method_code = scaleHandler.method_code;
		bool horizontal = gridLayout.Horizontal;
		int itemCount = gridLayout.ItemCount;
		if (gridLayout.CentreAlign)
		{
			return;
		}
		if (gridLayout.RightAlign)
		{
			IntPtr invoke_impl2 = itemSizeHandler.invoke_impl;
			IntPtr method_code2 = itemSizeHandler.method_code;
			IntPtr method = itemSizeHandler.method;
			if (horizontal)
			{
				float x2 = gridLayout.ExtraElementSpacing.X;
			}
			bool centreAlign = gridLayout.CentreAlign;
			return;
		}
		ItemGrid_Layout.ReorderStyle reorder = gridLayout.Reorder;
		IntPtr invoke_impl3 = itemSizeHandler.invoke_impl;
		IntPtr method_code3 = itemSizeHandler.method_code;
		IntPtr method2 = itemSizeHandler.method;
		if (horizontal)
		{
			if (gridLayout.CentreAlign || gridLayout.RightAlign)
			{
				IntPtr invoke_impl4 = itemSizeHandler.invoke_impl;
				IntPtr method_code4 = itemSizeHandler.method_code;
				IntPtr method3 = itemSizeHandler.method;
				float x3 = gridLayout.ExtraElementSpacing.X;
				if (gridLayout.CentreAlign)
				{
					return;
				}
				if (gridLayout.RightAlign)
				{
				}
			}
			float y2 = gridLayout.ExtraElementSpacing.Y;
		}
		ItemGrid_Layout.ReorderStyle reorder2 = gridLayout.Reorder;
		float y3 = gridLayout.ExtraElementSpacing.Y;
		if (reorder2 == ItemGrid_Layout.ReorderStyle.None)
		{
		}
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x00016D90 File Offset: 0x00014F90
	public static void Draw(ItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, GUIItemGrid.CursorOver cursorOverHandler, GUIItemGrid.DrawItemHandler drawhandler, Vector2 itemSize, int overloadedItemCount = -1)
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num != 0)
		{
			IntPtr invoke_impl = scaleHandler.invoke_impl;
			IntPtr method_code = scaleHandler.method_code;
			IntPtr method = scaleHandler.method;
			return;
		}
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x00016F0C File Offset: 0x0001510C
	// Note: this type is marked as 'beforefieldinit'.
	static GUIItemGrid()
	{
	}

	// Token: 0x04000560 RID: 1376
	public static bool disablePickingCallbacks;

	// Token: 0x04000561 RID: 1377
	private static Rectangle calculatedRegion;

	// Token: 0x04000562 RID: 1378
	private static int calcBackingWidth;

	// Token: 0x04000563 RID: 1379
	private static int calcBackingHeight;

	// Token: 0x04000564 RID: 1380
	private static bool calcRegionInitialised;

	// Token: 0x04000565 RID: 1381
	private static GUIItemGrid.DrawItemHandler dummyDraw;

	// Token: 0x0200010D RID: 269
	public sealed class CursorOver : MulticastDelegate
	{
		// Token: 0x060006CD RID: 1741 RVA: 0x00016F1C File Offset: 0x0001511C
		public CursorOver(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00016F70 File Offset: 0x00015170
		public void Invoke(int itemIndex)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(int itemIndex, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00016F94 File Offset: 0x00015194
		public void EndInvoke(IAsyncResult result)
		{
		}
	}

	// Token: 0x0200010E RID: 270
	public sealed class GetItemScaleHandler : MulticastDelegate
	{
		// Token: 0x060006D1 RID: 1745 RVA: 0x00016FA4 File Offset: 0x000151A4
		public GetItemScaleHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00016FF8 File Offset: 0x000151F8
		public float Invoke(int itemIndex)
		{
			/*
An exception occurred when decompiling this method (060006D2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIItemGrid/GetItemScaleHandler::Invoke(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:GetItemScaleHandler[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetItemScaleHandler[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:GetItemScaleHandler[exp:Delegate](this)))
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

		// Token: 0x060006D3 RID: 1747 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(int itemIndex, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x000021DB File Offset: 0x000003DB
		public float EndInvoke(IAsyncResult result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x0200010F RID: 271
	public sealed class DrawItemHandler : MulticastDelegate
	{
		// Token: 0x060006D5 RID: 1749 RVA: 0x0001701C File Offset: 0x0001521C
		public DrawItemHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0001707C File Offset: 0x0001527C
		public void Invoke(ItemGrid_Layout gridLayout, int itemIndex, Vector2 position, float scale)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(ItemGrid_Layout gridLayout, int itemIndex, Vector2 position, float scale, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000170A0 File Offset: 0x000152A0
		public void EndInvoke(IAsyncResult result)
		{
		}
	}

	// Token: 0x02000110 RID: 272
	public sealed class GetItemSizeHandler : MulticastDelegate
	{
		// Token: 0x060006D9 RID: 1753 RVA: 0x000170B0 File Offset: 0x000152B0
		public GetItemSizeHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00017104 File Offset: 0x00015304
		public Vector2 Invoke(int itemIndex)
		{
			/*
An exception occurred when decompiling this method (060006DA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 GUIItemGrid/GetItemSizeHandler::Invoke(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:GetItemSizeHandler[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetItemSizeHandler[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:GetItemSizeHandler[exp:Delegate](this)))
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

		// Token: 0x060006DB RID: 1755 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(int itemIndex, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00017128 File Offset: 0x00015328
		public Vector2 EndInvoke(IAsyncResult result)
		{
			Vector2 vector;
			return vector;
		}
	}
}
