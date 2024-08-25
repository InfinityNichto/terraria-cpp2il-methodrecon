using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;

// Token: 0x02000295 RID: 661
public class GUISliderSetting : GUISettingEntry
{
	// Token: 0x06000F6A RID: 3946 RVA: 0x0004D2F0 File Offset: 0x0004B4F0
	public GUISliderSetting(GUISettingID id)
	{
		this._id = id;
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x000021DB File Offset: 0x000003DB
	protected virtual SettingsOverlaySlider_Layout GetLayout()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000F6C RID: 3948 RVA: 0x0004D318 File Offset: 0x0004B518
	private Vector3 GetHSL()
	{
		/*
An exception occurred when decompiling this method (06000F6C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector3 GUISliderSetting::GetHSL()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	stloc:GUISettingID(var_0_0C, ldfld:GUISettingID(GUISettingEntry::_id, ldloc:GUISliderSetting[exp:GUISettingEntry](this)))
	stloc:Vector3(var_2_19, call:Vector3(Main::rgbToHsl, callgetter:Color(Main::get_ControllerColor)))
	stloc:Vector3(var_4_26, call:Vector3(Main::rgbToHsl, callgetter:Color(Main::get_ControllerBorderColor)))
	stloc:Vector3(var_6_35, call:Vector3(Main::rgbToHsl, callgetter:Color(Main::get_mouseColor)))
	stloc:Vector3(var_8_44, call:Vector3(Main::rgbToHsl, callgetter:Color(Main::get_MouseBorderColor)))
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

	// Token: 0x06000F6D RID: 3949 RVA: 0x0004D36C File Offset: 0x0004B56C
	private void SetHSL(Vector3 hsl)
	{
		GUISettingID id = this._id;
	}

	// Token: 0x06000F6E RID: 3950 RVA: 0x0004D3AC File Offset: 0x0004B5AC
	public override void Draw()
	{
		if (ControlAnchor._gridItemRegion == null)
		{
		}
		int mouseX = Main.mouseX;
		int mouseY = Main.mouseY;
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x000021DB File Offset: 0x000003DB
	public override float GetElementHeight()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x0004D590 File Offset: 0x0004B790
	private float GetValue()
	{
		/*
An exception occurred when decompiling this method (06000F70)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUISliderSetting::GetValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GUISettingID(var_0_06, ldfld:GUISettingID(GUISettingEntry::_id, ldloc:GUISliderSetting[exp:GUISettingEntry](this)))
	stloc:Vector3(var_1_0D, call:Vector3(GUISliderSetting::GetHSL, ldloc:GUISliderSetting(this)))
	stloc:int32(var_3_15, callgetter:int32(Main::get_tooltipTime))
	stloc:float32(var_5_1E, callgetter:float32(Main::get_ambientVolume))
	stloc:int32(var_7_28, callgetter:int32(Main::get_bgScroll))
	stloc:float32(var_11_3C, call:float32(ASharedSliderPower::GetSliderValue, call:ModifyRainPower[exp:ASharedSliderPower](CreativePowerManager::GetPower, callgetter:CreativePowerManager(CreativePowerManager::get_Instance))))
	stloc:float32(var_13_50, call:float32(APerPlayerSliderPower::GetSliderValue, call:SpawnRateSliderPerPlayerPower[exp:APerPlayerSliderPower](CreativePowerManager::GetPower, callgetter:CreativePowerManager(CreativePowerManager::get_Instance))))
	stloc:float32(var_15_5A, callgetter:float32(Main::get_musicVolume))
	stloc:int32(var_17_64, callgetter:int32(Main::get_inventoryTooltipTime))
	stloc:float32(var_19_6E, callgetter:float32(Main::get_soundVolume))
	stloc:Color(var_21_78, callgetter:Color(Main::get_ControllerBorderColor))
	stloc:Color(var_23_82, callgetter:Color(Main::get_MouseBorderColor))
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

	// Token: 0x06000F71 RID: 3953 RVA: 0x0004D620 File Offset: 0x0004B820
	private int GetMaxValue()
	{
		GUISettingID id = this._id;
		return 95;
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x0004D654 File Offset: 0x0004B854
	private void SetValue(float value)
	{
		GUISettingID id = this._id;
	}

	// Token: 0x06000F73 RID: 3955 RVA: 0x0004D7A0 File Offset: 0x0004B9A0
	private string GetStringValue()
	{
		GUISettingID id = this._id;
		int <TargetTimeRate>k__BackingField = CreativePowerManager.Instance.GetPower<CreativePowers.ModifyTimeRate>().<TargetTimeRate>k__BackingField;
		string text;
		return text;
	}

	// Token: 0x06000F74 RID: 3956 RVA: 0x0004D89C File Offset: 0x0004BA9C
	private string GetTitle()
	{
		GUISettingID id = this._id;
		return "Mobile.WorldDifficultyTitle";
	}

	// Token: 0x04001C1E RID: 7198
	private float scale;

	// Token: 0x04001C1F RID: 7199
	protected float sliderValue;

	// Token: 0x04001C20 RID: 7200
	private float TimeSinceModified = (float)17096;

	// Token: 0x04001C21 RID: 7201
	protected GUISlider.DragState dragState;

	// Token: 0x04001C22 RID: 7202
	protected GUISlider.DrawBackingHandler backingHandler;
}
