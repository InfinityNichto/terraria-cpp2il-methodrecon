using System;
using Terraria;
using UnityEngine;

// Token: 0x0200030E RID: 782
[Serializable]
public class XNAWorldCameraSettings : DeviceVPPICalculator
{
	// Token: 0x0600124A RID: 4682 RVA: 0x00058F58 File Offset: 0x00057158
	public XNAWorldCameraSettings()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x0600124B RID: 4683 RVA: 0x00058F70 File Offset: 0x00057170
	public XNAWorldCameraSettings(Camera camera, XNAWorldCameraSettings defaultSettings)
	{
		if (!true)
		{
		}
		base..ctor();
		this.Camera = camera;
		AnimationCurve uiscreenWorldOffset = defaultSettings.UIScreenWorldOffset;
		this.UIScreenWorldOffset = uiscreenWorldOffset;
		AnimationCurve physicalToVPPICurve = defaultSettings.PhysicalToVPPICurve;
		this.PhysicalToVPPICurve = physicalToVPPICurve;
		float physicalHeight = defaultSettings.PhysicalHeight;
		this.PhysicalHeight = physicalHeight;
		float dpi = defaultSettings.DPI;
		this.DPI = dpi;
	}

	// Token: 0x0600124C RID: 4684 RVA: 0x00058FC8 File Offset: 0x000571C8
	public override void UpdateViewport(Rect newVeiwport)
	{
		float zoomScale = this._zoomScale;
		base.UpdateViewport(newVeiwport);
		Camera camera = this.Camera;
		this.RecalculateVirtualScreen();
		if (!this._wasInMenus)
		{
			float maxPixelScale = this.MaxPixelScale;
			float maxPixelScale2 = this.MaxPixelScale;
			float maxPixelScale3 = this.MaxPixelScale;
			return;
		}
	}

	// Token: 0x170001C5 RID: 453
	// (get) Token: 0x0600124D RID: 4685 RVA: 0x00059028 File Offset: 0x00057228
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
			if (lastVPPIOverridden)
			{
				float lastVPPI = this._lastVPPI;
				float vppi = this.VPPI;
				return true;
			}
		}
	}

	// Token: 0x0600124E RID: 4686 RVA: 0x00059094 File Offset: 0x00057294
	private void RecalculateVirtualScreen()
	{
		int nativeWidth = this.NativeWidth;
		int nativeHeight = this.NativeHeight;
		bool vppioverridden = this.VPPIOverridden;
		float vppi = this.VPPI;
		float zoomScale = this._zoomScale;
		this._lastVPPIOverridden = vppioverridden;
		this._lastVPPI = vppi;
		this._wasInMenus = zoomScale != null;
		long num = 0L;
		base.UpdatePixelScale(num != 0L);
	}

	// Token: 0x170001C6 RID: 454
	// (get) Token: 0x0600124F RID: 4687 RVA: 0x000590E8 File Offset: 0x000572E8
	public float MaxPixelScale
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600124F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single XNAWorldCameraSettings::get_MaxPixelScale()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, callgetter:int32(XNAWorldCameraSettings::get_NativeHeight, ldloc:XNAWorldCameraSettings(this)))
	stloc:float32(var_1_0D, ldfld:float32(DeviceVPPICalculator::VPPI, ldloc:XNAWorldCameraSettings[exp:DeviceVPPICalculator](this)))
	stloc:float32(var_2_14, ldfld:float32(DeviceVPPICalculator::DPI, ldloc:XNAWorldCameraSettings[exp:DeviceVPPICalculator](this)))
	stloc:int32(var_3_1B, callgetter:int32(XNAWorldCameraSettings::get_NativeWidth, ldloc:XNAWorldCameraSettings(this)))
	stloc:float32(var_4_22, ldfld:float32(DeviceVPPICalculator::VPPI, ldloc:XNAWorldCameraSettings[exp:DeviceVPPICalculator](this)))
	stloc:float32(var_5_2A, ldfld:float32(DeviceVPPICalculator::DPI, ldloc:XNAWorldCameraSettings[exp:DeviceVPPICalculator](this)))
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

	// Token: 0x170001C7 RID: 455
	// (get) Token: 0x06001250 RID: 4688 RVA: 0x00059120 File Offset: 0x00057320
	public float MinPixelScale
	{
		get
		{
			/*
An exception occurred when decompiling this method (06001250)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single XNAWorldCameraSettings::get_MinPixelScale()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, callgetter:int32(XNAWorldCameraSettings::get_NativeHeight, ldloc:XNAWorldCameraSettings(this)))
	stloc:int32(var_1_0D, callgetter:int32(XNAWorldCameraSettings::get_NativeWidth, ldloc:XNAWorldCameraSettings(this)))
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

	// Token: 0x170001C8 RID: 456
	// (get) Token: 0x06001251 RID: 4689 RVA: 0x0005913C File Offset: 0x0005733C
	public int MaxWorldWidth
	{
		get
		{
			float vppi = this.VPPI;
			float dpi = this.DPI;
			float maxPixelScale = this.MaxPixelScale;
			return this.NativeWidth;
		}
	}

	// Token: 0x170001C9 RID: 457
	// (get) Token: 0x06001252 RID: 4690 RVA: 0x00059164 File Offset: 0x00057364
	public int MaxWorldHeight
	{
		get
		{
			float vppi = this.VPPI;
			float dpi = this.DPI;
			float maxPixelScale = this.MaxPixelScale;
			return this.NativeHeight;
		}
	}

	// Token: 0x170001CA RID: 458
	// (get) Token: 0x06001253 RID: 4691 RVA: 0x0005918C File Offset: 0x0005738C
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

	// Token: 0x170001CB RID: 459
	// (get) Token: 0x06001254 RID: 4692 RVA: 0x000591A4 File Offset: 0x000573A4
	public int NativeHeight
	{
		get
		{
			if (!true)
			{
			}
			return Screen.height;
		}
	}

	// Token: 0x06001255 RID: 4693 RVA: 0x000591BC File Offset: 0x000573BC
	public void ApplyCamera()
	{
		if (!true)
		{
		}
		bool gameMenu = Main.gameMenu;
		float physicalHeight = this.PhysicalHeight;
		int num = 1;
		this._wasInMenus = num != 0;
		this.RecalculateVirtualScreen();
		float physicalHeight2 = this.PhysicalHeight;
		int num2 = 16256;
		this._zoomScale = (float)num2;
	}

	// Token: 0x040021DC RID: 8668
	public Camera MagnifyCamera;

	// Token: 0x040021DD RID: 8669
	public bool MagnifyActive;

	// Token: 0x040021DE RID: 8670
	public Vector2 MagnifySrcRegionOffset;

	// Token: 0x040021DF RID: 8671
	public Vector2 MagnifySrcRegionSize;

	// Token: 0x040021E0 RID: 8672
	public Vector2 MagnifyDstRegionOffset;

	// Token: 0x040021E1 RID: 8673
	public Vector2 MagnifyDstRegionSize;

	// Token: 0x040021E2 RID: 8674
	public Camera Camera;

	// Token: 0x040021E3 RID: 8675
	public AnimationCurve UIScreenWorldOffset;

	// Token: 0x040021E4 RID: 8676
	private Vector2 _lastScreenResolution;

	// Token: 0x040021E5 RID: 8677
	private bool _lastVPPIOverridden;

	// Token: 0x040021E6 RID: 8678
	private float _lastVPPI;

	// Token: 0x040021E7 RID: 8679
	private float _lastZoomScale;

	// Token: 0x040021E8 RID: 8680
	private bool _wasInMenus;

	// Token: 0x040021E9 RID: 8681
	public int _cameraWidth;

	// Token: 0x040021EA RID: 8682
	public int _cameraHeight;

	// Token: 0x040021EB RID: 8683
	public Vector2 HorizontalSplitScreenResolution;

	// Token: 0x040021EC RID: 8684
	public Vector2 VertialSplitScreenResolution;

	// Token: 0x040021ED RID: 8685
	public Vector2 QuaterSplitScreenResolution;
}
