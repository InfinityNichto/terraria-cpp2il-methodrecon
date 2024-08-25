using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200017E RID: 382
public class GUIInputRegionManager
{
	// Token: 0x06000AD1 RID: 2769 RVA: 0x000021DB File Offset: 0x000003DB
	public static GUIInputRegionManager Create()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x17000116 RID: 278
	// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x00037098 File Offset: 0x00035298
	public Vector2 MousePosition
	{
		get
		{
			int mouseX = this._mouseX;
			int mouseY = this._mouseY;
			Vector2 vector;
			return vector;
		}
	}

	// Token: 0x06000AD3 RID: 2771 RVA: 0x000370B4 File Offset: 0x000352B4
	public void DisableAllPicking()
	{
		this._disableAllRegions = true;
	}

	// Token: 0x06000AD4 RID: 2772 RVA: 0x000370C8 File Offset: 0x000352C8
	public void RenablePicking()
	{
	}

	// Token: 0x06000AD5 RID: 2773 RVA: 0x000370D8 File Offset: 0x000352D8
	public void SetMousePosition(int x, int y, bool inUISpace = false)
	{
		this._mouseX = x;
		this._checkingExclusiveRegions = y != 0;
	}

	// Token: 0x06000AD6 RID: 2774 RVA: 0x000370F8 File Offset: 0x000352F8
	public bool RegisterInputRegion(Rectangle rect)
	{
		bool flag;
		return flag;
	}

	// Token: 0x06000AD7 RID: 2775 RVA: 0x00037108 File Offset: 0x00035308
	public bool RegisterInputRegion(int x, int y, Texture2D texture, float scale)
	{
		int width = texture.Width;
		int height = texture.Height;
		bool flag;
		return flag;
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x00037124 File Offset: 0x00035324
	public bool RegisterInputRegion(int x, int y, Texture2D texture, float scale, Vector2 padding)
	{
		int width = texture.Width;
		int height = texture.Height;
		bool flag;
		return flag;
	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x000021DB File Offset: 0x000003DB
	public bool RegisterInputRegion(int xMin, int xMax, int yMin, int yMax)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000ADA RID: 2778 RVA: 0x00037140 File Offset: 0x00035340
	public bool IsOverExclusiveRegion()
	{
		/*
An exception occurred when decompiling this method (06000ADA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIInputRegionManager::IsOverExclusiveRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class GUIInputRegionExclusive>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIInputRegionExclusive>(GUIInputRegionManager::_exclusiveRegion, ldloc:GUIInputRegionManager(this)))
	stloc:int32(var_1_08, ldc.i4:int32(1))
	stfld:bool(GUIInputRegionManager::_checkingExclusiveRegions, ldloc:GUIInputRegionManager(this), ldloc:int32[exp:bool](var_1_08))
	stloc:int32(var_2_16, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class GUIInputRegionExclusive>[exp:List`1](var_0_06)))
	stloc:int32(var_4_1F, ldfld:int32(GUIInputRegionManager::_mouseX, ldloc:GUIInputRegionManager(this)))
	stloc:bool(var_5_27, ldfld:bool(GUIInputRegionManager::_checkingExclusiveRegions, ldloc:GUIInputRegionManager(this)))
	stloc:int32(var_7_34, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class GUIInputRegionExclusive>[exp:List`1](GUIInputRegionManager::_exclusiveRegion, ldloc:GUIInputRegionManager(this))))
	call:void(GUIInputRegionManager::RemovePendingRegions, ldloc:GUIInputRegionManager(this))
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

	// Token: 0x06000ADB RID: 2779 RVA: 0x000021DB File Offset: 0x000003DB
	private void RemovePendingRegions()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x000021DB File Offset: 0x000003DB
	public GUIInputRegionExclusive RegisterPickingInterceptor(GUIInputRegionExclusive.IsOverHandler handler)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x000021DB File Offset: 0x000003DB
	public void UnregisterPickingInterceptor(GUIInputRegionExclusive region)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x0003718C File Offset: 0x0003538C
	public bool RegisterInputRegion(int x, int y, Vector2 size)
	{
		bool flag;
		return flag;
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x000021DB File Offset: 0x000003DB
	public bool IsOverRegion()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x0003719C File Offset: 0x0003539C
	public bool IsOverRegionExpanded()
	{
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x000021DB File Offset: 0x000003DB
	public bool IsPositionOverUI(Vector2 uiPosition)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x000021DB File Offset: 0x000003DB
	public void Clear()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x000371B0 File Offset: 0x000353B0
	public GUIInputRegionManager()
	{
	}

	// Token: 0x04000B2B RID: 2859
	public static GUIInputRegionManager Instance;

	// Token: 0x04000B2C RID: 2860
	private bool _disableAllRegions;

	// Token: 0x04000B2D RID: 2861
	private int _mouseX;

	// Token: 0x04000B2E RID: 2862
	private int _mouseY;

	// Token: 0x04000B2F RID: 2863
	private bool _checkingExclusiveRegions;

	// Token: 0x04000B30 RID: 2864
	private List<GUIInputRegionExclusive> _exclusiveRegion;

	// Token: 0x04000B31 RID: 2865
	private List<GUIInputRegionExclusive> _prendingExclusiveRegionRemoves;

	// Token: 0x04000B32 RID: 2866
	private List<GUIInputRegion> _currentRegion;

	// Token: 0x04000B33 RID: 2867
	private List<GUIInputRegion> _availableRegion;
}
