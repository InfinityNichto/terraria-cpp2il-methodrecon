using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

// Token: 0x02000018 RID: 24
public class CursorManager
{
	// Token: 0x0600006A RID: 106 RVA: 0x000021DB File Offset: 0x000003DB
	public static CursorManager Create()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00002B48 File Offset: 0x00000D48
	public CursorManager()
	{
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00002B5C File Offset: 0x00000D5C
	public bool IsCursorActive()
	{
		if (this.ActivateMouseMode)
		{
			long num = 0L;
			bool flag = this.IsMouseActive((int)num);
			return true;
		}
		int touchCount = Input.touchCount;
		return this.IsMouseActive(1);
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00002B8C File Offset: 0x00000D8C
	public int GetNumCursors()
	{
		return this._cursors._size;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00002BA4 File Offset: 0x00000DA4
	public global::Cursor GetCursor(int index)
	{
		/*
An exception occurred when decompiling this method (0600006E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Cursor CursorManager::GetCursor(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Cursor>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Cursor>(CursorManager::_cursors, ldloc:CursorManager(this)))
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

	// Token: 0x0600006F RID: 111 RVA: 0x00002BB8 File Offset: 0x00000DB8
	public void UpdateCursors()
	{
		this.UpdateCursorList();
		if (!true)
		{
		}
		if (true)
		{
			if (!true)
			{
			}
			CursorInputLayer.Resort();
		}
		List<global::Cursor> cursors = this._cursors;
		if (true)
		{
			while (!true)
			{
			}
			return;
		}
		for (;;)
		{
		}
		if (!true)
		{
		}
		if (!false)
		{
			return;
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002C3C File Offset: 0x00000E3C
	private bool IsMouseActive(int index)
	{
		bool flag = this.updatingEMUMouseTouches;
		if (!true)
		{
		}
		bool mouseButtonDown = XNAUnityRunner.GetMouseButtonDown(index, index != 0);
		bool flag2 = this.updatingEMUMouseTouches;
		if (!true)
		{
		}
		bool mouseButton = XNAUnityRunner.GetMouseButton(index, index != 0);
		bool flag3 = this.updatingEMUMouseTouches;
		if (!true)
		{
		}
		bool mouseButtonUp = XNAUnityRunner.GetMouseButtonUp(index, index != 0);
		return true;
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00002C94 File Offset: 0x00000E94
	private bool IsTouchScrollOnly(int touchIndex)
	{
		while (!this.ActivateMouseMode)
		{
		}
		long num;
		if (this.GetTouchId(touchIndex) != 0)
		{
			num = 0L;
		}
		bool flag = this.updatingEMUMouseTouches;
		if (num == 0L)
		{
		}
		bool mouseButtonDown = XNAUnityRunner.GetMouseButtonDown(0, touchIndex != 0);
		long num2 = 0L;
		bool flag2 = this.updatingEMUMouseTouches;
		if (num2 == 0L)
		{
		}
		bool mouseButton = XNAUnityRunner.GetMouseButton(0, touchIndex != 0);
		long num3 = 0L;
		bool flag3 = this.updatingEMUMouseTouches;
		if (num3 == 0L)
		{
		}
		return XNAUnityRunner.GetMouseButtonUp(0, touchIndex != 0);
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002CF4 File Offset: 0x00000EF4
	public int GetRealTouchCount()
	{
		return Input.touchCount;
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00002D08 File Offset: 0x00000F08
	public int GetTouchCount()
	{
		do
		{
			bool flag = this.emuTouchFromMouse;
			if (flag)
			{
				if (!flag)
				{
				}
				if (flag)
				{
					goto IL_006C;
				}
				long num = 0L;
				bool flag2 = this.IsMouseActive((int)num);
				if (!this.mouseActive)
				{
					int num2 = 1;
					this.mouseActive = num2 != 0;
				}
				int touchCount = this._touchCount;
				this._touchCount = touchCount;
			}
		}
		while (this.ActivateMouseMode && !this.updatingEMUMouseTouches);
		return Input.touchCount;
		IL_006C:
		return this._touchCount;
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00002D88 File Offset: 0x00000F88
	private int GetTouchId(int touchIndex)
	{
		while (!this.emuTouchFromMouse)
		{
			if (!this.ActivateMouseMode || this.updatingEMUMouseTouches)
			{
				return Input.touches.fingerId;
			}
		}
		int touchCount = this._touchCount;
		return touchIndex;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00002DCC File Offset: 0x00000FCC
	private int GetTouchIndex(int touchId)
	{
		bool flag;
		while (this.emuTouchFromMouse)
		{
			flag = this.fakeMouseActive;
			if (flag)
			{
				bool flag2 = this.mouseActive;
				break;
			}
		}
		if (flag)
		{
			while (!flag)
			{
			}
		}
		Touch[] touches = Input.touches;
		float y = touches.m_PositionDelta.y;
		return touches.fingerId;
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000076 RID: 118 RVA: 0x00002E24 File Offset: 0x00001024
	public bool EmuMouseModeActive
	{
		get
		{
			if (this.emuMouseModeActive)
			{
				bool flag = this.updatingEMUMouseTouches;
				return;
			}
		}
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00002E44 File Offset: 0x00001044
	public bool GetEMUMouseButton(int index)
	{
		/*
An exception occurred when decompiling this method (06000077)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean CursorManager::GetEMUMouseButton(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
	stloc:int32(var_1_10, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype CursorManager/TouchInput>[exp:List`1](CursorManager::EMUMouseTouches, ldloc:CursorManager(this))))
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

	// Token: 0x06000078 RID: 120 RVA: 0x00002E64 File Offset: 0x00001064
	public bool GetEMUMouseButtonDown(int index)
	{
		/*
An exception occurred when decompiling this method (06000078)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean CursorManager::GetEMUMouseButtonDown(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0012:
	stloc:int32(var_1_1D, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype CursorManager/TouchInput>[exp:List`1](CursorManager::EMUMouseTouches, ldloc:CursorManager(this))))
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

	// Token: 0x06000079 RID: 121 RVA: 0x00002E90 File Offset: 0x00001090
	public bool GetEMUMouseButtonUp(int index)
	{
		/*
An exception occurred when decompiling this method (06000079)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean CursorManager::GetEMUMouseButtonUp(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
	stloc:int32(var_1_10, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype CursorManager/TouchInput>[exp:List`1](CursorManager::PreviousEMUMouseTouches, ldloc:CursorManager(this))))
	stloc:int32(var_2_1C, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype CursorManager/TouchInput>[exp:List`1](CursorManager::EMUMouseTouches, ldloc:CursorManager(this))))
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

	// Token: 0x0600007A RID: 122 RVA: 0x00002EBC File Offset: 0x000010BC
	private TouchPhase GetTouchPhase(int touchIndex)
	{
		do
		{
			if (this.emuTouchFromMouse)
			{
				int touchId = this.GetTouchId(touchIndex);
				bool flag = this.updatingEMUMouseTouches;
				bool mouseButtonDown = XNAUnityRunner.GetMouseButtonDown(1, touchIndex != 0);
			}
		}
		while (this.ActivateMouseMode && !this.updatingEMUMouseTouches);
		Touch[] touches = Input.touches;
		return touches.phase;
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002FDC File Offset: 0x000011DC
	private bool ShouldIgnoreTouch(int touchIndex)
	{
		if (!this.ActivateMouseMode && !this.emuTouchFromMouse)
		{
			TouchType type = Input.touches.type;
			return;
		}
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00003008 File Offset: 0x00001208
	private Vector2 GetTouchPosition(int touchIndex)
	{
		/*
An exception occurred when decompiling this method (0600007C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector2 CursorManager::GetTouchPosition(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0038:
	stloc:valuetype [UnityEngine.InputLegacyModule]UnityEngine.Touch[](var_3_3D, callgetter:valuetype [UnityEngine.InputLegacyModule]UnityEngine.Touch[](Input::get_touches))
	stloc:Vector2(var_5_48, callgetter:Vector2(Touch::get_position, ldloc:valuetype [UnityEngine.InputLegacyModule]UnityEngine.Touch[][exp:valuetype [UnityEngine.InputLegacyModule]UnityEngine.Touch&](var_3_3D)))
	stloc:Vector3(var_7_52, callgetter:Vector3(XNAUnityRunner::get_MousePositionReal))
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

	// Token: 0x0600007D RID: 125 RVA: 0x00003068 File Offset: 0x00001268
	private Vector2 GetTouchScroll(int touchIndex)
	{
		/*
An exception occurred when decompiling this method (0600007D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector2 CursorManager::GetTouchScroll(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Vector2(var_1_0F, callgetter:Vector2(Input::get_mouseScrollDelta))
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

	// Token: 0x0600007E RID: 126 RVA: 0x00003084 File Offset: 0x00001284
	private bool ShouldIgnoreForWorld(Vector2 position)
	{
		if (!true)
		{
		}
		XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
		if (!true)
		{
		}
		if (!true)
		{
		}
		if (XNAUnityRunner.ScreenWidth == 0)
		{
		}
		int screenHeight = XNAUnityRunner.ScreenHeight;
		return true;
	}

	// Token: 0x0600007F RID: 127 RVA: 0x000021DB File Offset: 0x000003DB
	private void UpdateMouseEMUTouches()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000080 RID: 128 RVA: 0x000021DB File Offset: 0x000003DB
	private void UpdateCursorList()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000081 RID: 129 RVA: 0x000030BC File Offset: 0x000012BC
	public void DrawCursorOverlay(SpriteBatch batch)
	{
		int size = this._cursorsInpacts._size;
		if (this._cursorsInpacts == null)
		{
		}
		int size2 = this._cursorsInpacts._size;
	}

	// Token: 0x0400004C RID: 76
	public static CursorManager Instance;

	// Token: 0x0400004D RID: 77
	private int _touchCount;

	// Token: 0x0400004E RID: 78
	public bool ActivateMouseMode;

	// Token: 0x0400004F RID: 79
	private bool emuTouchFromMouse;

	// Token: 0x04000050 RID: 80
	private bool fakeMouseActive;

	// Token: 0x04000051 RID: 81
	private bool mouseActive;

	// Token: 0x04000052 RID: 82
	private Vector2 fakeMousePosition;

	// Token: 0x04000053 RID: 83
	private bool updatingSwitchTouches;

	// Token: 0x04000054 RID: 84
	private List<CursorManager.TouchInput> UserSwitchTouches;

	// Token: 0x04000055 RID: 85
	private bool emuMouseModeActive;

	// Token: 0x04000056 RID: 86
	private bool updatingEMUMouseTouches;

	// Token: 0x04000057 RID: 87
	private Vector3 emuMouseLastHWMousePosition;

	// Token: 0x04000058 RID: 88
	public Vector2 EmuMousePosition;

	// Token: 0x04000059 RID: 89
	private List<CursorManager.TouchInput> EMUMouseTouches;

	// Token: 0x0400005A RID: 90
	private List<CursorManager.TouchInput> PreviousEMUMouseTouches;

	// Token: 0x0400005B RID: 91
	private List<global::Cursor> _cursors;

	// Token: 0x0400005C RID: 92
	private List<CursorManager.CursorFirstContact> _cursorsInpacts;

	// Token: 0x0400005D RID: 93
	public List<CursorInputLayer> Layers;

	// Token: 0x02000019 RID: 25
	public struct TouchInput
	{
		// Token: 0x06000082 RID: 130 RVA: 0x000030EC File Offset: 0x000012EC
		public TouchInput(int id, Vector2 position, TouchPhase phase)
		{
			this.TouchId = id;
			this.TouchPhase = position;
		}

		// Token: 0x0400005E RID: 94
		public readonly int TouchId;

		// Token: 0x0400005F RID: 95
		public readonly Vector2 TouchPosition;

		// Token: 0x04000060 RID: 96
		public readonly TouchPhase TouchPhase;
	}

	// Token: 0x0200001A RID: 26
	private struct CursorFirstContact
	{
		// Token: 0x04000061 RID: 97
		public Vector2 position;

		// Token: 0x04000062 RID: 98
		public DateTime time;
	}
}
