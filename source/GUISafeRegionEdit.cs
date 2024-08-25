using System;
using UnityEngine;

// Token: 0x0200027E RID: 638
public class GUISafeRegionEdit
{
	// Token: 0x06000E6C RID: 3692 RVA: 0x000467E4 File Offset: 0x000449E4
	public GUISafeRegionEdit()
	{
		this._inputLayer.Priority = 100;
	}

	// Token: 0x06000E6D RID: 3693 RVA: 0x00046804 File Offset: 0x00044A04
	public void UpdateCursor(global::Cursor cursor)
	{
		CursorInputLayer inputLayer = cursor.InputLayer;
		if (inputLayer == null)
		{
			float x = cursor.Position.x;
			float y = cursor.Position.y;
			if (inputLayer == null)
			{
			}
			CursorInputLayer inputLayer2 = this._inputLayer;
			float x2 = cursor.Position.x;
			cursor.InputLayer = inputLayer2;
			cursor.InputLayerData = inputLayer2;
			this.leftInitialOffset = x;
			return;
		}
	}

	// Token: 0x06000E6E RID: 3694 RVA: 0x00046918 File Offset: 0x00044B18
	public void DrawBacking()
	{
		int screenHeight = XNAUnityRunner.ScreenHeight;
		int screenWidth = XNAUnityRunner.ScreenWidth;
		if (!this.LeftPressed)
		{
		}
		if (!this.TopPressed)
		{
		}
		if (!this.BottomPressed)
		{
		}
		if (!this.RightPressed)
		{
		}
		if (this.LeftPressed)
		{
		}
		if (this.TopPressed)
		{
		}
		if (this.BottomPressed)
		{
		}
		bool rightPressed = this.RightPressed;
		if (rightPressed)
		{
		}
		if (!rightPressed)
		{
		}
	}

	// Token: 0x06000E6F RID: 3695 RVA: 0x00046984 File Offset: 0x00044B84
	public void UpdateEdit()
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		InterfaceStyles_Layout.LoadUIResolution();
	}

	// Token: 0x06000E70 RID: 3696 RVA: 0x000469A0 File Offset: 0x00044BA0
	public void Draw()
	{
		bool leftPressed = this.LeftPressed;
		bool rightPressed = this.RightPressed;
		bool topPressed = this.TopPressed;
		bool bottomPressed = this.BottomPressed;
		bool leftPressed2 = this.LeftPressed;
		bool rightPressed2 = this.RightPressed;
		bool topPressed2 = this.TopPressed;
		bool bottomPressed2 = this.BottomPressed;
	}

	// Token: 0x06000E71 RID: 3697 RVA: 0x000469EC File Offset: 0x00044BEC
	private bool UpdateCursorDragging(Rect safeArea)
	{
		/*
An exception occurred when decompiling this method (06000E71)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUISafeRegionEdit::UpdateCursorDragging(UnityEngine.Rect)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_016A:
	stloc:int32(var_59_172, callgetter:int32(XNAUnityRunner::get_ScreenWidth))
	callsetter:float32(Rect::set_xMin, ldloc:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](safeArea), ldloc:float32(var_47_132))
	stloc:int32(var_61_184, callgetter:int32(XNAUnityRunner::get_ScreenWidth))
	stloc:int32(var_63_18E, callgetter:int32(XNAUnityRunner::get_ScreenWidth))
	callsetter:float32(Rect::set_xMax, ldloc:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](safeArea), ldloc:float32(var_47_132))
	stloc:int32(var_65_1A0, callgetter:int32(XNAUnityRunner::get_ScreenHeight))
	callsetter:float32(Rect::set_yMin, ldloc:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](safeArea), ldloc:float32(var_47_132))
	stloc:int32(var_67_1B2, callgetter:int32(XNAUnityRunner::get_ScreenHeight))
	stloc:int32(var_69_1BC, callgetter:int32(XNAUnityRunner::get_ScreenHeight))
	callsetter:float32(Rect::set_yMax, ldloc:Rect[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Rect&](safeArea), ldloc:float32(var_47_132))
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

	// Token: 0x04001A53 RID: 6739
	private CursorInputLayer _inputLayer;

	// Token: 0x04001A54 RID: 6740
	private float leftInitialOffset;

	// Token: 0x04001A55 RID: 6741
	private float rightInitialOffset;

	// Token: 0x04001A56 RID: 6742
	private float topInitialOffset;

	// Token: 0x04001A57 RID: 6743
	private float bottomInitialOffset;

	// Token: 0x04001A58 RID: 6744
	private float leftScale;

	// Token: 0x04001A59 RID: 6745
	private float rightScale;

	// Token: 0x04001A5A RID: 6746
	private float topScale;

	// Token: 0x04001A5B RID: 6747
	private float bottomScale;

	// Token: 0x04001A5C RID: 6748
	private float finishScale;

	// Token: 0x04001A5D RID: 6749
	private float resetScale;

	// Token: 0x04001A5E RID: 6750
	private bool LeftPressed;

	// Token: 0x04001A5F RID: 6751
	private bool RightPressed;

	// Token: 0x04001A60 RID: 6752
	private bool TopPressed;

	// Token: 0x04001A61 RID: 6753
	private bool BottomPressed;
}
