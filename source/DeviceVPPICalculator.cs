using System;
using UnityEngine;

// Token: 0x02000302 RID: 770
public class DeviceVPPICalculator
{
	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x060011D0 RID: 4560 RVA: 0x00057108 File Offset: 0x00055308
	public DeviceOrientation deviceOrientation
	{
		get
		{
			DeviceOrientation deviceOrientation = Input.deviceOrientation;
			this._cachedOrientation = deviceOrientation;
			return deviceOrientation;
		}
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x0005712C File Offset: 0x0005532C
	private float GetDeviceDPI()
	{
		/*
An exception occurred when decompiling this method (060011D1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single DeviceVPPICalculator::GetDeviceDPI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0020:
	stloc:float32(var_7_28, callgetter:float32(Screen::get_dpi))
	stfld:float32(DeviceVPPICalculator::DeviceDPI, ldloc:DeviceVPPICalculator(this), ldloc:float32(var_4))
	stfld:bool(DeviceVPPICalculator::DeviceDPISectup, ldloc:DeviceVPPICalculator(this), ldc.i4:bool(1))
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

	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x060011D2 RID: 4562 RVA: 0x00057174 File Offset: 0x00055374
	public Rect Viewport
	{
		get
		{
			/*
An exception occurred when decompiling this method (060011D2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Rect DeviceVPPICalculator::get_Viewport()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Rect::m_XMin, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](DeviceVPPICalculator::_viewport, ldloc:DeviceVPPICalculator(this))))
	stloc:float32(var_1_17, ldfld:float32(Rect::m_YMin, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](DeviceVPPICalculator::_viewport, ldloc:DeviceVPPICalculator(this))))
	stloc:float32(var_2_23, ldfld:float32(Rect::m_Width, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](DeviceVPPICalculator::_viewport, ldloc:DeviceVPPICalculator(this))))
	stloc:float32(var_3_2F, ldfld:float32(Rect::m_Height, ldfld:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](DeviceVPPICalculator::_viewport, ldloc:DeviceVPPICalculator(this))))
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

	// Token: 0x060011D3 RID: 4563 RVA: 0x000571B0 File Offset: 0x000553B0
	public virtual void UpdateViewport(Rect newVeiwport)
	{
		if (!true)
		{
		}
	}

	// Token: 0x060011D4 RID: 4564 RVA: 0x000571C0 File Offset: 0x000553C0
	public float GetDefaultVerticalResolution(bool safeRegion = false)
	{
		if (!true)
		{
		}
		float deviceDPI = this.GetDeviceDPI();
		float deviceDPI2 = this.GetDeviceDPI();
		DeviceVPPICalculator.EditorMobileEmuEntry forceEMUEntry = this._forceEMUEntry;
		if (forceEMUEntry != null)
		{
			int height = forceEMUEntry.Height;
			Rect viewportSafeRegion = this.GetViewportSafeRegion();
			float height2 = viewportSafeRegion.height;
			float dpi = this.DPI;
			float height3 = viewportSafeRegion.height;
			float num = this.PhysicalToResolution.Evaluate(height3);
			if (forceEMUEntry == null)
			{
			}
			if (forceEMUEntry == null)
			{
			}
		}
		int height4 = Screen.height;
		DeviceVPPICalculator.EditorMobileEmuEntry forceEMUEntry2 = this._forceEMUEntry;
		while (forceEMUEntry2 != null)
		{
		}
		float height5 = this.GetViewportSafeRegion().height;
		while (forceEMUEntry2 != null)
		{
		}
		throw new MissingMethodException();
	}

	// Token: 0x060011D5 RID: 4565 RVA: 0x00057254 File Offset: 0x00055454
	protected void UpdatePixelScale(bool safeRegion = false)
	{
		bool isEditor = Application.isEditor;
		this.UpdateForcedEmulation();
		float deviceDPI = this.GetDeviceDPI();
		DeviceVPPICalculator.EditorMobileEmuEntry forceEMUEntry = this._forceEMUEntry;
		int height;
		if (forceEMUEntry != null)
		{
			float dpi = forceEMUEntry.DPI;
			this.DPI = dpi;
			height = forceEMUEntry.Height;
			return;
		}
		this.DPI = (float)height;
		float height2 = this.GetViewportSafeRegion().height;
		float dpi2 = this.DPI;
		this.PhysicalHeight = (float)height;
		if (forceEMUEntry == null)
		{
		}
		bool vppioverridden = this.VPPIOverridden;
		if (vppioverridden)
		{
			float vppi = this.VPPI;
			return;
		}
		AnimationCurve physicalToResolution = this.PhysicalToResolution;
		float physicalHeight = this.PhysicalHeight;
		float num = physicalToResolution.Evaluate(height2);
		float physicalHeight2 = this.PhysicalHeight;
		this.VPPI = physicalHeight;
		float zoomScale = this._zoomScale;
		float dpi3 = this.DPI;
		this.PixelScale = physicalHeight;
	}

	// Token: 0x060011D6 RID: 4566 RVA: 0x00057364 File Offset: 0x00055564
	public Rect GetDefaultSafeArea()
	{
		/*
An exception occurred when decompiling this method (060011D6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Rect DeviceVPPICalculator::GetDefaultSafeArea()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0015:
	stloc:int32(var_4_1C, callgetter:int32(Screen::get_height))
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

	// Token: 0x060011D7 RID: 4567 RVA: 0x00057390 File Offset: 0x00055590
	private bool IsSafeAreaValid()
	{
		/*
An exception occurred when decompiling this method (060011D7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean DeviceVPPICalculator::IsSafeAreaValid()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:int32(var_6_10, callgetter:int32(Screen::get_width))
	stloc:int32(var_9_1A, callgetter:int32(Screen::get_width))
	stloc:int32(var_12_24, callgetter:int32(Screen::get_width))
	stloc:int32(var_16_2E, callgetter:int32(Screen::get_height))
	stloc:int32(var_19_38, callgetter:int32(Screen::get_height))
	stloc:int32(var_22_42, callgetter:int32(Screen::get_height))
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

	// Token: 0x060011D8 RID: 4568 RVA: 0x000573E8 File Offset: 0x000555E8
	public Rect GetViewportSafeRegion()
	{
		if (!true)
		{
		}
		int width = Screen.width;
		int height = Screen.height;
		int width2 = Screen.width;
		int height2 = Screen.height;
		Rect safeArea = this.GetSafeArea();
		float xMin = safeArea.xMin;
		float xMin2 = safeArea.xMin;
		float xMax = safeArea.xMax;
		float xMax2 = safeArea.xMax;
		float yMin = safeArea.yMin;
		float yMin2 = safeArea.yMin;
		float yMax = safeArea.yMax;
		float yMax2 = safeArea.yMax;
		return safeArea;
	}

	// Token: 0x060011D9 RID: 4569 RVA: 0x00057470 File Offset: 0x00055670
	public Rect GetSafeArea()
	{
		/*
An exception occurred when decompiling this method (060011D9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Rect DeviceVPPICalculator::GetSafeArea()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:int32(var_4_11, callgetter:int32(Screen::get_width))
	stloc:int32(var_7_1B, callgetter:int32(Screen::get_width))
	stloc:int32(var_10_25, callgetter:int32(Screen::get_height))
	stloc:int32(var_13_2F, callgetter:int32(Screen::get_height))
	stloc:Preferences(var_15_39, callgetter:Preferences(Main::get_Configuration))
	stloc:Preferences(var_18_43, callgetter:Preferences(Main::get_Configuration))
	stloc:Preferences(var_21_4D, callgetter:Preferences(Main::get_Configuration))
	stloc:Preferences(var_24_57, callgetter:Preferences(Main::get_Configuration))
	stloc:int32(var_28_61, callgetter:int32(Screen::get_width))
	stloc:int32(var_31_6B, callgetter:int32(Screen::get_width))
	stloc:int32(var_34_75, callgetter:int32(Screen::get_height))
	stloc:int32(var_37_7F, callgetter:int32(Screen::get_height))
	stloc:Rect(var_39_87, call:Rect(DeviceVPPICalculator::GetDefaultSafeArea, ldloc:DeviceVPPICalculator(this)))
	stloc:DeviceOrientation(var_41_91, callgetter:DeviceOrientation(Input::get_deviceOrientation))
	stfld:DeviceOrientation(DeviceVPPICalculator::_cachedOrientation, ldloc:DeviceVPPICalculator(this), ldc.i4:DeviceOrientation(3))
	stfld:DeviceOrientation(DeviceVPPICalculator::_cachedOrientation, ldloc:DeviceVPPICalculator(this), ldc.i4:DeviceOrientation(4))
	stloc:DeviceOrientation(var_42_A7, ldfld:DeviceOrientation(DeviceVPPICalculator::_cachedOrientation, ldloc:DeviceVPPICalculator(this)))
	stloc:int32(var_44_B1, callgetter:int32(Screen::get_width))
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

	// Token: 0x060011DA RID: 4570 RVA: 0x00057530 File Offset: 0x00055730
	public void ResetSafeArea()
	{
		Rect defaultSafeArea = this.GetDefaultSafeArea();
		if (!true)
		{
		}
	}

	// Token: 0x060011DB RID: 4571 RVA: 0x00057548 File Offset: 0x00055748
	public void SetSafeArea(Rect area)
	{
		int width = Screen.width;
		int width2 = Screen.width;
		int width3 = Screen.width;
		int height = Screen.height;
		int height2 = Screen.height;
		int height3 = Screen.height;
		Rect defaultSafeArea = this.GetDefaultSafeArea();
	}

	// Token: 0x060011DC RID: 4572 RVA: 0x000575D4 File Offset: 0x000557D4
	private void UpdateForcedEmulation()
	{
		DeviceVPPICalculator.EditorMobileEmuEntry forceEMUEntry = this._forceEMUEntry;
		if (forceEMUEntry != null)
		{
			if (forceEMUEntry == null)
			{
			}
			int width = Screen.width;
			DeviceVPPICalculator.EditorMobileEmuEntry forceEMUEntry2 = this._forceEMUEntry;
			int width2 = forceEMUEntry2.Width;
			if (forceEMUEntry2 == null)
			{
			}
			int height = Screen.height;
			DeviceVPPICalculator.EditorMobileEmuEntry forceEMUEntry3 = this._forceEMUEntry;
			int height2 = forceEMUEntry3.Height;
			int allowedPlatforms = forceEMUEntry3.AllowedPlatforms;
			if (this._forceEMUEntry != null)
			{
			}
		}
	}

	// Token: 0x060011DD RID: 4573 RVA: 0x00057634 File Offset: 0x00055834
	public void OverrideVerticalResolution(int verticalResolution)
	{
		float physicalHeight = this.PhysicalHeight;
		this.VPPIOverridden = true;
		this.VPPI = physicalHeight;
	}

	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x060011DE RID: 4574 RVA: 0x00057658 File Offset: 0x00055858
	// (set) Token: 0x060011DF RID: 4575 RVA: 0x0005766C File Offset: 0x0005586C
	public float ZoomScale
	{
		get
		{
			/*
An exception occurred when decompiling this method (060011DE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single DeviceVPPICalculator::get_ZoomScale()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(DeviceVPPICalculator::_zoomScale, ldloc:DeviceVPPICalculator(this)))
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
		set
		{
		}
	}

	// Token: 0x060011E0 RID: 4576 RVA: 0x0005767C File Offset: 0x0005587C
	public DeviceVPPICalculator()
	{
	}

	// Token: 0x060011E1 RID: 4577 RVA: 0x000576B4 File Offset: 0x000558B4
	// Note: this type is marked as 'beforefieldinit'.
	static DeviceVPPICalculator()
	{
	}

	// Token: 0x04002153 RID: 8531
	private DeviceOrientation _cachedOrientation = DeviceOrientation.LandscapeLeft;

	// Token: 0x04002154 RID: 8532
	private bool DeviceDPISectup;

	// Token: 0x04002155 RID: 8533
	private float DeviceDPI;

	// Token: 0x04002156 RID: 8534
	private static float DefaultResolution;

	// Token: 0x04002157 RID: 8535
	protected Rect _viewport;

	// Token: 0x04002158 RID: 8536
	public AnimationCurve PhysicalToVPPICurve;

	// Token: 0x04002159 RID: 8537
	public AnimationCurve PhysicalToResolution;

	// Token: 0x0400215A RID: 8538
	public float PhysicalHeight;

	// Token: 0x0400215B RID: 8539
	public float VPPI;

	// Token: 0x0400215C RID: 8540
	public float DPI;

	// Token: 0x0400215D RID: 8541
	public float PixelScale = (float)16256;

	// Token: 0x0400215E RID: 8542
	public bool VPPIOverridden;

	// Token: 0x0400215F RID: 8543
	public static Rect SafeArea;

	// Token: 0x04002160 RID: 8544
	private float _zoomScale = (float)16256;

	// Token: 0x04002161 RID: 8545
	private static float DefaultPhysicalHeight;

	// Token: 0x04002162 RID: 8546
	private DeviceVPPICalculator.EditorMobileEmuEntry[] MobileResolutionEntries;

	// Token: 0x04002163 RID: 8547
	private DeviceVPPICalculator.EditorMobileEmuEntry _forceEMUEntry;

	// Token: 0x02000303 RID: 771
	public class EditorMobileEmuEntry
	{
		// Token: 0x060011E2 RID: 4578 RVA: 0x000576C4 File Offset: 0x000558C4
		public EditorMobileEmuEntry(string id, int width, int height, float dpi, int allowedPlatforms = 65535)
		{
			this.Width = width;
			this.DPI = (float)height;
			this.Id = id;
			this.AllowedPlatforms = allowedPlatforms;
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x000576F4 File Offset: 0x000558F4
		public EditorMobileEmuEntry(string id, int width, int height, float dpi, Rect safeRegion, int allowedPlatforms = 65535)
		{
			this.Id = id;
			this.Width = width;
			this.DPI = (float)height;
			this.AllowedPlatforms = safeRegion;
		}

		// Token: 0x04002164 RID: 8548
		public readonly string Id;

		// Token: 0x04002165 RID: 8549
		public readonly int Width;

		// Token: 0x04002166 RID: 8550
		public readonly int Height;

		// Token: 0x04002167 RID: 8551
		public readonly float DPI;

		// Token: 0x04002168 RID: 8552
		public readonly Rect SafeRegion;

		// Token: 0x04002169 RID: 8553
		public readonly int AllowedPlatforms;
	}
}
