using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using UnityEngine;

// Token: 0x020001F2 RID: 498
public class Map_Layout : LayoutDefinition
{
	// Token: 0x06000C7B RID: 3195 RVA: 0x0003DCB4 File Offset: 0x0003BEB4
	private void Awake()
	{
	}

	// Token: 0x17000157 RID: 343
	// (get) Token: 0x06000C7C RID: 3196 RVA: 0x000021DB File Offset: 0x000003DB
	// (set) Token: 0x06000C7D RID: 3197 RVA: 0x0003DCC4 File Offset: 0x0003BEC4
	public static bool UseLargeMinimap
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
		set
		{
		}
	}

	// Token: 0x17000158 RID: 344
	// (get) Token: 0x06000C7E RID: 3198 RVA: 0x000021DB File Offset: 0x000003DB
	public Panel_Layout DisplayMinimap
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x17000159 RID: 345
	// (get) Token: 0x06000C7F RID: 3199 RVA: 0x0003DCD4 File Offset: 0x0003BED4
	public Panel_Layout DisplayMinimapFrame
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000C7F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Panel_Layout Map_Layout::get_DisplayMinimapFrame()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Texture_Layout(var_1_0B, ldfld:Texture_Layout(Panel_Layout::Backing, ldfld:Panel_Layout(Map_Layout::MinimapLargeFrame, ldloc:Map_Layout(this))))
	stloc:Texture_Layout(var_3_17, ldfld:Texture_Layout(Panel_Layout::Backing, ldfld:Panel_Layout(Map_Layout::MinimapFrame, ldloc:Map_Layout(this))))
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

	// Token: 0x1700015A RID: 346
	// (get) Token: 0x06000C80 RID: 3200 RVA: 0x0003DCF8 File Offset: 0x0003BEF8
	public float MinMinimapScale
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000C80)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Map_Layout::get_MinMinimapScale()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Panel_Layout(var_0_06, ldfld:Panel_Layout(Map_Layout::MinimapFrame, ldloc:Map_Layout(this)))
	stloc:int32(var_1_0D, ldfld:int32(Map_Layout::MaxMiniMapWorldWidth, ldloc:Map_Layout(this)))
	stloc:float32(var_2_19, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Panel_Layout::SizeLocation, ldloc:Panel_Layout(var_0_06))))
	stloc:float32(var_3_25, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Panel_Layout::Location, ldloc:Panel_Layout(var_0_06))))
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

	// Token: 0x1700015B RID: 347
	// (get) Token: 0x06000C81 RID: 3201 RVA: 0x0003DD2C File Offset: 0x0003BF2C
	public float MaxMinimapScale
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000C81)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Map_Layout::get_MaxMinimapScale()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Panel_Layout(var_0_06, ldfld:Panel_Layout(Map_Layout::MinimapFrame, ldloc:Map_Layout(this)))
	stloc:int32(var_1_0D, ldfld:int32(Map_Layout::MinMiniMapWorldWidth, ldloc:Map_Layout(this)))
	stloc:float32(var_2_19, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Panel_Layout::SizeLocation, ldloc:Panel_Layout(var_0_06))))
	stloc:float32(var_3_25, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Panel_Layout::Location, ldloc:Panel_Layout(var_0_06))))
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

	// Token: 0x1700015C RID: 348
	// (get) Token: 0x06000C82 RID: 3202 RVA: 0x0003DD60 File Offset: 0x0003BF60
	public float DefaultMinimapScale
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000C82)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Map_Layout::get_DefaultMinimapScale()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Panel_Layout(var_0_06, ldfld:Panel_Layout(Map_Layout::MinimapFrame, ldloc:Map_Layout(this)))
	stloc:int32(var_1_0D, ldfld:int32(Map_Layout::DefaultMiniMapWorldWidth, ldloc:Map_Layout(this)))
	stloc:float32(var_2_19, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Panel_Layout::SizeLocation, ldloc:Panel_Layout(var_0_06))))
	stloc:float32(var_3_25, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Panel_Layout::Location, ldloc:Panel_Layout(var_0_06))))
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

	// Token: 0x1700015D RID: 349
	// (get) Token: 0x06000C83 RID: 3203 RVA: 0x000021DB File Offset: 0x000003DB
	public QuickActionButton_Layout HUDMap
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x06000C84 RID: 3204 RVA: 0x000021DB File Offset: 0x000003DB
	public QuickActionButton_Layout HUDMiniMapToggle
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x0003DD94 File Offset: 0x0003BF94
	public Map_Layout()
	{
		if (16256 == 0)
		{
		}
		if (!true)
		{
		}
		this.SliderBackScale = (float)16256;
		this.SliderLocation = 1;
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001215 RID: 4629
	public static Map_Layout Instance;

	// Token: 0x04001216 RID: 4630
	public int DefaultMiniMapWorldWidth;

	// Token: 0x04001217 RID: 4631
	public int MinMiniMapWorldWidth;

	// Token: 0x04001218 RID: 4632
	public int MaxMiniMapWorldWidth;

	// Token: 0x04001219 RID: 4633
	public Panel_Layout Minimap;

	// Token: 0x0400121A RID: 4634
	public Panel_Layout MinimapFrame;

	// Token: 0x0400121B RID: 4635
	public Panel_Layout MinimapLarge;

	// Token: 0x0400121C RID: 4636
	public Panel_Layout MinimapLargeFrame;

	// Token: 0x0400121D RID: 4637
	public float MinimapScale = (float)16256;

	// Token: 0x0400121E RID: 4638
	public QuickActionButton_Layout MinimapZoomDefault;

	// Token: 0x0400121F RID: 4639
	public QuickActionButton_Layout MinimapZoomIn;

	// Token: 0x04001220 RID: 4640
	public QuickActionButton_Layout MinimapZoomOut;

	// Token: 0x04001221 RID: 4641
	public QuickActionButton_Layout MapZoomDefault;

	// Token: 0x04001222 RID: 4642
	public QuickActionButton_Layout MapZoomIn;

	// Token: 0x04001223 RID: 4643
	public QuickActionButton_Layout MapZoomOut;

	// Token: 0x04001224 RID: 4644
	public QuickActionButton_Layout Map;

	// Token: 0x04001225 RID: 4645
	public QuickActionButton_Layout MapHorizontal;

	// Token: 0x04001226 RID: 4646
	public ControlAnchor.ControlId SliderAnchorControl;

	// Token: 0x04001227 RID: 4647
	public LayoutCalculator.AnchorType SliderAnchor = LayoutCalculator.AnchorType.CentreBoth;

	// Token: 0x04001228 RID: 4648
	public Microsoft.Xna.Framework.Vector2 SliderLocation;

	// Token: 0x04001229 RID: 4649
	public float SliderBackScale;

	// Token: 0x0400122A RID: 4650
	public Microsoft.Xna.Framework.Vector2 SliderPickBorder;

	// Token: 0x0400122B RID: 4651
	public float SliderIndicatorScale;

	// Token: 0x0400122C RID: 4652
	public float SliderEndCap;

	// Token: 0x0400122D RID: 4653
	public float ControllerMovementSpeed;

	// Token: 0x0400122E RID: 4654
	public float SliderDefaultPosition;

	// Token: 0x0400122F RID: 4655
	public AnimationCurve SliderToPixelScale;

	// Token: 0x04001230 RID: 4656
	public QuickActionButton_Layout MinimapToggle;

	// Token: 0x04001231 RID: 4657
	public QuickActionButton_Layout MinimapToggleHorizontal;
}
