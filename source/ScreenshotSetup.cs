using System;
using Controller;
using UnityEngine;

// Token: 0x02000306 RID: 774
[Serializable]
public class ScreenshotSetup
{
	// Token: 0x170001AA RID: 426
	// (get) Token: 0x060011FB RID: 4603 RVA: 0x00057ABC File Offset: 0x00055CBC
	public RenderTexture RenderTexture
	{
		get
		{
			RenderTexture renderTexture = this._renderTexture;
			if (!true)
			{
			}
			RenderTexture renderTexture2 = this._renderTexture;
			int height = this.Height;
			RenderTexture renderTexture3 = this._renderTexture;
			int width = this.Width;
			RenderTexture renderTexture4 = this._renderTexture;
			return renderTexture3;
		}
	}

	// Token: 0x170001AB RID: 427
	// (get) Token: 0x060011FC RID: 4604 RVA: 0x00057B20 File Offset: 0x00055D20
	public Texture2D SaveTexture
	{
		get
		{
			Texture2D tex = this._tex;
			if (!true)
			{
			}
			Texture2D tex2 = this._tex;
			int height = this.Height;
			Texture2D tex3 = this._tex;
			int width = this.Width;
			Texture2D tex4 = this._tex;
			return tex3;
		}
	}

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x060011FD RID: 4605 RVA: 0x00057B88 File Offset: 0x00055D88
	public DeviceVPPICalculator.EditorMobileEmuEntry EmulationEntry
	{
		get
		{
			/*
An exception occurred when decompiling this method (060011FD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling DeviceVPPICalculator/EditorMobileEmuEntry ScreenshotSetup::get_EmulationEntry()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0037:
	stloc:string(var_9_3D, ldfld:string(ScreenshotSetup::Id, ldloc:ScreenshotSetup(this)))
	stloc:string(var_10_4B, call:string(string::Concat, ldstr:string("Screenshot_"), ldloc:string(var_9_3D)))
	stloc:int32(var_11_53, ldfld:int32(ScreenshotSetup::Width, ldloc:ScreenshotSetup(this)))
	stloc:int32(var_12_5B, ldfld:int32(ScreenshotSetup::DPI, ldloc:ScreenshotSetup(this)))
	stloc:string(var_13_63, ldfld:string(ScreenshotSetup::Id, ldloc:ScreenshotSetup(this)))
	stloc:int32(var_15_6B, ldfld:int32(ScreenshotSetup::Width, ldloc:ScreenshotSetup(this)))
	stloc:int32(var_16_73, ldfld:int32(ScreenshotSetup::DPI, ldloc:ScreenshotSetup(this)))
	stloc:int32(var_17_7B, ldfld:int32(ScreenshotSetup::DPI, ldloc:ScreenshotSetup(this)))
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

	// Token: 0x060011FE RID: 4606 RVA: 0x00057C18 File Offset: 0x00055E18
	public ScreenshotSetup()
	{
	}

	// Token: 0x04002179 RID: 8569
	private RenderTexture _renderTexture;

	// Token: 0x0400217A RID: 8570
	private Texture2D _tex;

	// Token: 0x0400217B RID: 8571
	private DeviceVPPICalculator.EditorMobileEmuEntry _emulationEntry;

	// Token: 0x0400217C RID: 8572
	public string Id;

	// Token: 0x0400217D RID: 8573
	public ScreenshotSetup.UIStyle Style;

	// Token: 0x0400217E RID: 8574
	public ControllerDevice.ControlScheme ControlScheme = ControllerDevice.ControlScheme.CONTROLS_ABXY_XBOX;

	// Token: 0x0400217F RID: 8575
	public int Width;

	// Token: 0x04002180 RID: 8576
	public int Height;

	// Token: 0x04002181 RID: 8577
	public int DPI;

	// Token: 0x04002182 RID: 8578
	public Rect SafeRegion;

	// Token: 0x04002183 RID: 8579
	public string OutputPath;

	// Token: 0x04002184 RID: 8580
	public string OutputFileStart;

	// Token: 0x02000307 RID: 775
	public enum UIStyle
	{
		// Token: 0x04002186 RID: 8582
		VirtualControls,
		// Token: 0x04002187 RID: 8583
		Controller,
		// Token: 0x04002188 RID: 8584
		None
	}
}
