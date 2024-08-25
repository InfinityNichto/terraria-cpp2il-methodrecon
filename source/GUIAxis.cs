using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000102 RID: 258
public static class GUIAxis
{
	// Token: 0x060006A2 RID: 1698 RVA: 0x000156DC File Offset: 0x000138DC
	public static void Draw(Axis_Layout layout, Texture2D icon, Vector2 innerScreenOffset, Vector2 centre, bool active, bool useAlternativeInner = false, bool disabled = false)
	{
		bool recentreOnTouch = layout.RecentreOnTouch;
		if (recentreOnTouch)
		{
			float x = centre.X;
			float y = centre.Y;
			return;
		}
		ControlAnchor.ControlId anchorControl = layout.AnchorControl;
		Vector2 centreLocation = layout.CentreLocation;
		float x2 = layout.CentreLocation.X;
		float y2 = layout.CentreLocation.Y;
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x000158D0 File Offset: 0x00013AD0
	public static void Draw(Axis_Layout layout, Texture2D icon, Rectangle srcRect, Vector2 innerScreenOffset, Vector2 centre, bool active, bool useAlternativeInner = false, bool disabled = false)
	{
		bool recentreOnTouch = layout.RecentreOnTouch;
		if (recentreOnTouch)
		{
			bool value = active.m_value;
			return;
		}
		ControlAnchor.ControlId anchorControl = layout.AnchorControl;
		Vector2 centreLocation = layout.CentreLocation;
		float x = layout.CentreLocation.X;
		float y = layout.CentreLocation.Y;
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x00015AA0 File Offset: 0x00013CA0
	public static bool RegisterPickingRegion(Axis_Layout layout)
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		if (!true)
		{
		}
		Vector2 vector;
		float num = vector.Length();
		float num2 = vector.Length();
		float num3 = vector.Length();
		return true;
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00015AE4 File Offset: 0x00013CE4
	public static bool IsCursorOverExpanded(Vector2 position, Axis_Layout layout, [Out] Vector2 screenOffset, [Out] Vector2 axis, Vector2 centre, bool wasActive, float expandedSize, bool forceCursorInside = false, bool disableAxisRebalance = false)
	{
		/*
An exception occurred when decompiling this method (060006A5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIAxis::IsCursorOverExpanded(Microsoft.Xna.Framework.Vector2,Axis_Layout,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,System.Boolean,System.Single,System.Boolean,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00E6:
	stfld:float32(Vector2::X, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](position), ldloc:int32[exp:float32](var_24_7E))
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

	// Token: 0x060006A6 RID: 1702 RVA: 0x00015BE4 File Offset: 0x00013DE4
	public static bool IsCursorOver(Vector2 position, Axis_Layout layout, [Out] Vector2 screenOffset, [Out] Vector2 axis, Vector2 centre, bool wasActive, bool forceCursorInside = false, bool disableAxisRebalance = false)
	{
		/*
An exception occurred when decompiling this method (060006A6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIAxis::IsCursorOver(Microsoft.Xna.Framework.Vector2,Axis_Layout,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,System.Boolean,System.Boolean,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00BD:
	stfld:float32(Vector2::X, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](position), ldloc:int32[exp:float32](var_19_51))
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

	// Token: 0x060006A7 RID: 1703 RVA: 0x00015CBC File Offset: 0x00013EBC
	// Note: this type is marked as 'beforefieldinit'.
	static GUIAxis()
	{
	}

	// Token: 0x04000526 RID: 1318
	public static float GlobalScale;
}
