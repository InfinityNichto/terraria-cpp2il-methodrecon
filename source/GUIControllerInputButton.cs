using System;
using System.Runtime.InteropServices;
using Controller;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000104 RID: 260
public static class GUIControllerInputButton
{
	// Token: 0x060006B2 RID: 1714 RVA: 0x00015F90 File Offset: 0x00014190
	public static void LoadContent(ContentManager content)
	{
		Texture2D texture2D = content.Load<Texture2D>("Images/UI/ControllerButtons");
		Texture2D texture2D2 = content.Load<Texture2D>("Images/UI/ControllerShoulderButtons");
		Texture2D texture2D3 = content.Load<Texture2D>("Images/UI/PS4_Pad");
		Texture2D texture2D4 = content.Load<Texture2D>("Images/UI/ControllerDpadsSticks");
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x00015FD0 File Offset: 0x000141D0
	public static Texture2D GetShoulderButtonTexureInformation(GUIControllerInputButton.ShoulderButtonControl controlType, [Out] Rectangle srcRegion, int overloadedControlType = -1)
	{
		/*
An exception occurred when decompiling this method (060006B3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Texture2D GUIControllerInputButton::GetShoulderButtonTexureInformation(GUIControllerInputButton/ShoulderButtonControl,Microsoft.Xna.Framework.Rectangle,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0012:
	stloc:DrPlatformType(var_5_1A, callgetter:DrPlatformType(DrPlatform::get_CurrentPlatform))
	stloc:int64(var_6_1D, ldc.i4:int64(0))
	stfld:int32(ShoulderButtonControl::value__, ldloc:ShoulderButtonControl[exp:valuetype GUIControllerInputButton/ShoulderButtonControl&](controlType), ldloc:int64[exp:int32](var_6_1D))
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

	// Token: 0x060006B4 RID: 1716 RVA: 0x00016008 File Offset: 0x00014208
	public static Texture2D GetAxisTexureInformation(GUIControllerInputButton.AxisControl controlType, [Out] Rectangle srcRegion, int overloadedControlType = -1)
	{
		/*
An exception occurred when decompiling this method (060006B4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Texture2D GUIControllerInputButton::GetAxisTexureInformation(GUIControllerInputButton/AxisControl,Microsoft.Xna.Framework.Rectangle,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:DrPlatformType(var_3_11, callgetter:DrPlatformType(DrPlatform::get_CurrentPlatform))
	stloc:bool(var_5_1A, callgetter:bool(Application::get_isEditor))
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

	// Token: 0x060006B5 RID: 1717 RVA: 0x00016034 File Offset: 0x00014234
	public static Texture2D GetButtonTexureInformation(GUIControllerInputButton.LinkedControlType controlType, [Out] Rectangle srcRegion, int overloadedControlType = -1)
	{
		return 11;
	}

	// Token: 0x04000529 RID: 1321
	private const ControllerDevice.ControlScheme defaultScheme = ControllerDevice.ControlScheme.CONTROLS_ABXY_XBOX;

	// Token: 0x0400052A RID: 1322
	private static Texture2D ButtonControls;

	// Token: 0x0400052B RID: 1323
	private static Texture2D ShoulderButtonControls;

	// Token: 0x0400052C RID: 1324
	private static Texture2D AxisControls;

	// Token: 0x0400052D RID: 1325
	private static Texture2D PS4TouchPad;

	// Token: 0x02000105 RID: 261
	public enum LinkedControlType
	{
		// Token: 0x0400052F RID: 1327
		Action1,
		// Token: 0x04000530 RID: 1328
		Action2,
		// Token: 0x04000531 RID: 1329
		Action3,
		// Token: 0x04000532 RID: 1330
		Action4,
		// Token: 0x04000533 RID: 1331
		LB,
		// Token: 0x04000534 RID: 1332
		RB,
		// Token: 0x04000535 RID: 1333
		LT,
		// Token: 0x04000536 RID: 1334
		RT,
		// Token: 0x04000537 RID: 1335
		View,
		// Token: 0x04000538 RID: 1336
		Options,
		// Token: 0x04000539 RID: 1337
		LeftStick,
		// Token: 0x0400053A RID: 1338
		RightStick
	}

	// Token: 0x02000106 RID: 262
	public enum ShoulderButtonControl
	{
		// Token: 0x0400053C RID: 1340
		LB,
		// Token: 0x0400053D RID: 1341
		RB,
		// Token: 0x0400053E RID: 1342
		LT,
		// Token: 0x0400053F RID: 1343
		RT,
		// Token: 0x04000540 RID: 1344
		View,
		// Token: 0x04000541 RID: 1345
		Options
	}

	// Token: 0x02000107 RID: 263
	public enum AxisControl
	{
		// Token: 0x04000543 RID: 1347
		DPad,
		// Token: 0x04000544 RID: 1348
		DPadLeft,
		// Token: 0x04000545 RID: 1349
		DPadRight,
		// Token: 0x04000546 RID: 1350
		DPadUp,
		// Token: 0x04000547 RID: 1351
		DPadDown,
		// Token: 0x04000548 RID: 1352
		DPadDummy,
		// Token: 0x04000549 RID: 1353
		LS,
		// Token: 0x0400054A RID: 1354
		LSLeft,
		// Token: 0x0400054B RID: 1355
		LSRight,
		// Token: 0x0400054C RID: 1356
		LSUp,
		// Token: 0x0400054D RID: 1357
		LSDown,
		// Token: 0x0400054E RID: 1358
		LSClick,
		// Token: 0x0400054F RID: 1359
		RS,
		// Token: 0x04000550 RID: 1360
		RSLeft,
		// Token: 0x04000551 RID: 1361
		RSRight,
		// Token: 0x04000552 RID: 1362
		RSUp,
		// Token: 0x04000553 RID: 1363
		RSDown,
		// Token: 0x04000554 RID: 1364
		RSClick
	}
}
