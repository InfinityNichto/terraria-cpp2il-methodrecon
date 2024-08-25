using System;
using UnityEngine;

// Token: 0x0200030A RID: 778
[Serializable]
public class XNAUICameraSettings : DeviceVPPICalculator
{
	// Token: 0x0600120A RID: 4618 RVA: 0x00057DA8 File Offset: 0x00055FA8
	public XNAUICameraSettings()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x0600120B RID: 4619 RVA: 0x00057DC0 File Offset: 0x00055FC0
	public XNAUICameraSettings(Camera camera, XNAUICameraSettings defaultSettings)
	{
		if (!true)
		{
		}
		base..ctor();
		this.Camera = camera;
		AnimationCurve physicalToVPPICurve = defaultSettings.PhysicalToVPPICurve;
		this.PhysicalToVPPICurve = physicalToVPPICurve;
		float physicalHeight = defaultSettings.PhysicalHeight;
		this.PhysicalHeight = physicalHeight;
		float dpi = defaultSettings.DPI;
		this.DPI = dpi;
	}

	// Token: 0x0600120C RID: 4620 RVA: 0x00057E08 File Offset: 0x00056008
	public override void UpdateViewport(Rect newVeiwport)
	{
		base.UpdateViewport(newVeiwport);
		Camera camera = this.Camera;
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x00057E24 File Offset: 0x00056024
	private static bool RectRoughlyEqual(Rect a, Rect b)
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		return true;
	}

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x0600120E RID: 4622 RVA: 0x00057E3C File Offset: 0x0005603C
	private bool ScreenResolutionSettingsDirty
	{
		get
		{
			float x = this._lastScreenResolution.x;
			int nativeWidth = this.NativeWidth;
			float y = this._lastScreenResolution.y;
			int nativeHeight = this.NativeHeight;
			bool lastVPPIOverridden = this._lastVPPIOverridden;
			bool vppioverridden = this.VPPIOverridden;
			float lastZoomScale = this._lastZoomScale;
			float zoomScale = this._zoomScale;
			float xmin = this._lastSafeRegion.m_XMin;
			float ymin = this._lastSafeRegion.m_YMin;
			float width = this._lastSafeRegion.m_Width;
			float height = this._lastSafeRegion.m_Height;
			Rect viewportSafeRegion = this.GetViewportSafeRegion();
			return true;
		}
	}

	// Token: 0x0600120F RID: 4623 RVA: 0x00057EEC File Offset: 0x000560EC
	public void RecalculateVirtualScreen()
	{
		int nativeWidth = this.NativeWidth;
		int nativeHeight = this.NativeHeight;
		bool vppioverridden = this.VPPIOverridden;
		float vppi = this.VPPI;
		this._lastVPPIOverridden = vppioverridden;
		this._lastVPPI = vppi;
		Rect viewportSafeRegion = this.GetViewportSafeRegion();
		base.UpdatePixelScale(true);
	}

	// Token: 0x06001210 RID: 4624 RVA: 0x00057F34 File Offset: 0x00056134
	public float GetMinResolution()
	{
		/*
An exception occurred when decompiling this method (06001210)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single XNAUICameraSettings::GetMinResolution()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:Rect(var_0_06, call:Rect(XNAUICameraSettings::GetViewportSafeRegion, ldloc:XNAUICameraSettings(this)))
	stloc:float32(var_1_0D, callgetter:float32(Rect::get_width, ldloc:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](var_0_06)))
	stloc:float32(var_2_14, callgetter:float32(Rect::get_height, ldloc:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](var_0_06)))
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

	// Token: 0x06001211 RID: 4625 RVA: 0x00057F58 File Offset: 0x00056158
	public float GetMaxResolution()
	{
		/*
An exception occurred when decompiling this method (06001211)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single XNAUICameraSettings::GetMaxResolution()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_10, callgetter:float32(Keyframe::get_time, callgetter:valuetype [UnityEngine.CoreModule]UnityEngine.Keyframe[][exp:valuetype [UnityEngine.CoreModule]UnityEngine.Keyframe&](AnimationCurve::get_keys, ldfld:AnimationCurve(DeviceVPPICalculator::PhysicalToResolution, ldloc:XNAUICameraSettings[exp:DeviceVPPICalculator](this)))))
	stloc:float32(var_1_17, ldfld:float32(DeviceVPPICalculator::PhysicalHeight, ldloc:XNAUICameraSettings[exp:DeviceVPPICalculator](this)))
	stloc:float32(var_2_28, callgetter:float32(Keyframe::get_value, callgetter:valuetype [UnityEngine.CoreModule]UnityEngine.Keyframe[][exp:valuetype [UnityEngine.CoreModule]UnityEngine.Keyframe&](AnimationCurve::get_keys, ldfld:AnimationCurve(DeviceVPPICalculator::PhysicalToResolution, ldloc:XNAUICameraSettings[exp:DeviceVPPICalculator](this)))))
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

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x06001212 RID: 4626 RVA: 0x00057F90 File Offset: 0x00056190
	private int NativeWidth
	{
		get
		{
			if (!true)
			{
			}
			return Screen.width;
		}
	}

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x06001213 RID: 4627 RVA: 0x00057FA8 File Offset: 0x000561A8
	private int NativeHeight
	{
		get
		{
			if (!true)
			{
			}
			return Screen.height;
		}
	}

	// Token: 0x06001214 RID: 4628 RVA: 0x00057FC0 File Offset: 0x000561C0
	private new Rect GetViewportSafeRegion()
	{
		if (!true)
		{
		}
		int width = Screen.width;
		int height = Screen.height;
		int width2 = Screen.width;
		int height2 = Screen.height;
		Rect safeArea = base.GetSafeArea();
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

	// Token: 0x06001215 RID: 4629 RVA: 0x00058048 File Offset: 0x00056248
	public void ApplyCamera()
	{
		Rect viewportSafeRegion = this.GetViewportSafeRegion();
		bool screenResolutionSettingsDirty = this.ScreenResolutionSettingsDirty;
		int num = 16256;
		this._zoomScale = (float)num;
		this.RecalculateVirtualScreen();
		Rect viewportSafeRegion2 = this.GetViewportSafeRegion();
		float height = viewportSafeRegion2.height;
		float pixelScale = this.PixelScale;
		float width = viewportSafeRegion2.width;
		float height2 = viewportSafeRegion2.height;
		if (num == 0)
		{
		}
		this.RecalculateVirtualScreen();
		float pixelScale2 = this.PixelScale;
		if (32640 == 0)
		{
		}
		int cameraWidth = this._cameraWidth;
		int cameraHeight = this._cameraHeight;
		float xmin = this._cameraSafeRegion.m_XMin;
		float ymin = this._cameraSafeRegion.m_YMin;
		float width2 = this._cameraSafeRegion.m_Width;
		float height3 = this._cameraSafeRegion.m_Height;
		this._cameraSafeRegion = 43139072;
		int nativeHeight = this.NativeHeight;
		float pixelScale3 = this.PixelScale;
		int num2 = 32640;
		this.realVirtualScreenHeight = num2;
		int nativeWidth = this.NativeWidth;
		int nativeHeight2 = this.NativeHeight;
		int num3 = this.realVirtualScreenHeight;
		if (cameraWidth == 0)
		{
		}
		int num4 = 32640;
		this.realVirtualScreenWidth = num4;
		int nativeWidth2 = this.NativeWidth;
		int num5 = this.realVirtualScreenWidth;
		int num6 = 65408;
		this.realVirtualScreenOffsetX = num6;
		int nativeHeight3 = this.NativeHeight;
		int num7 = this.realVirtualScreenHeight;
		Camera camera = this.Camera;
		this.realVirtualScreenOffsetY = num6;
		if (num6 == 0)
		{
		}
		Transform transform = this.Camera.transform;
		int num8 = this.realVirtualScreenWidth;
		int nativeWidth3 = this.NativeWidth;
		int num9 = this.realVirtualScreenWidth;
		int num10 = this.realVirtualScreenOffsetX;
		if (num6 == 0)
		{
		}
		int height4 = Screen.height;
		int num11 = this.realVirtualScreenHeight;
		int num12 = this.realVirtualScreenWidth;
		int num13 = this.realVirtualScreenOffsetX;
		Camera camera2 = this.Camera;
	}

	// Token: 0x04002195 RID: 8597
	public Camera Camera;

	// Token: 0x04002196 RID: 8598
	private Vector2 _lastScreenResolution;

	// Token: 0x04002197 RID: 8599
	private bool _lastVPPIOverridden;

	// Token: 0x04002198 RID: 8600
	private float _lastVPPI;

	// Token: 0x04002199 RID: 8601
	private float _lastZoomScale;

	// Token: 0x0400219A RID: 8602
	private Rect _lastSafeRegion;

	// Token: 0x0400219B RID: 8603
	public int _cameraWidth;

	// Token: 0x0400219C RID: 8604
	public int _cameraHeight;

	// Token: 0x0400219D RID: 8605
	private Rect _cameraSafeRegion;

	// Token: 0x0400219E RID: 8606
	public float _safeRegionMinX;

	// Token: 0x0400219F RID: 8607
	public float _safeRegionMinY;

	// Token: 0x040021A0 RID: 8608
	public int realVirtualScreenWidth;

	// Token: 0x040021A1 RID: 8609
	public int realVirtualScreenHeight;

	// Token: 0x040021A2 RID: 8610
	public int realVirtualScreenOffsetX;

	// Token: 0x040021A3 RID: 8611
	public int realVirtualScreenOffsetY;
}
