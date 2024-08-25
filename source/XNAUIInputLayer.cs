using System;
using Controller;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000297 RID: 663
public class XNAUIInputLayer
{
	// Token: 0x06000F80 RID: 3968 RVA: 0x0004DE98 File Offset: 0x0004C098
	public XNAUIInputLayer()
	{
		this._inputLayer.Priority = 90;
		this._inputLayer2.Priority = 80;
		CursorInputLayer worldInputLayer = this._worldInputLayer;
		long num = 0L;
		worldInputLayer.Priority = (int)num;
	}

	// Token: 0x06000F81 RID: 3969 RVA: 0x0004DEE4 File Offset: 0x0004C0E4
	public void CaptureUICrusorDrag(int dragFromAxis = -1)
	{
		this.UICrusorDraggingFromAxis = dragFromAxis;
		this.UICrusorDragging = true;
		this._timeWithoutUICursor = (float)17096;
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x0004DF0C File Offset: 0x0004C10C
	public void CancelUICrusorDrag()
	{
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x0004DF1C File Offset: 0x0004C11C
	public void UpdateCursor(global::Cursor cursor)
	{
		if (cursor.InputLayer != null)
		{
			if (cursor.Down || cursor.WasDown)
			{
				return;
			}
			bool key = KeyboardInput.GetKey(KeyCode.Mouse1);
			CursorInputLayer inputLayer = cursor.InputLayer;
		}
		CursorInputLayer inputLayer2 = this._inputLayer;
		Debug.Log("Releasing cursor");
		float x = cursor.Position.x;
		float y = cursor.Position.y;
		CursorInputLayer inputLayer3 = this._inputLayer;
		cursor.InputLayer = inputLayer3;
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x0004DF90 File Offset: 0x0004C190
	public void UpdateCursorSecondary(global::Cursor cursor)
	{
		if (!cursor.IgnoreForWorld && cursor.InputLayer == null)
		{
			float x = cursor.Position.x;
			float y = cursor.Position.y;
			CursorInputLayer inputLayer = this._inputLayer;
			cursor.InputLayer = inputLayer;
		}
	}

	// Token: 0x06000F85 RID: 3973 RVA: 0x0004DFD8 File Offset: 0x0004C1D8
	public void CaptureWorldCursor()
	{
		global::Cursor worldCursor = this.GetWorldCursor();
		if (worldCursor != null)
		{
			CursorInputLayer worldInputLayer = this._worldInputLayer;
			worldCursor.InputLayer = worldInputLayer;
		}
	}

	// Token: 0x06000F86 RID: 3974 RVA: 0x0004E000 File Offset: 0x0004C200
	public void WorldUpdateCursor(global::Cursor cursor)
	{
	}

	// Token: 0x06000F87 RID: 3975 RVA: 0x0004E010 File Offset: 0x0004C210
	public void ResetTimeWithoutCursor()
	{
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x0004E020 File Offset: 0x0004C220
	public void Update(float elapsedTime)
	{
		global::Cursor uicursor = this.GetUICursor();
		if (uicursor == null)
		{
			if (this.HadUICursor)
			{
				this._timeWithoutUICursor = (float)17096;
			}
			float timeWithoutUICursor = this._timeWithoutUICursor;
			this._timeWithoutUICursor = timeWithoutUICursor;
			return;
		}
		if (this.UICrusorDragging)
		{
			int uicrusorDraggingFromAxis = this.UICrusorDraggingFromAxis;
			ControllerActionVector controllerActionVector;
			ControllerDevice controllerDevice;
			Vector2 value = controllerActionVector.GetValue(controllerDevice);
			if (this.UICrusorDraggingFromAxis == 0)
			{
			}
			return;
		}
		bool wasDown;
		if (!uicursor.Down)
		{
			wasDown = uicursor.WasDown;
			if (!wasDown)
			{
			}
		}
		if (!wasDown)
		{
		}
		XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
		if (!this.UICrusorDragging && (!this.HadUICursor || uicursor.Down))
		{
			return;
		}
		float timeWithoutUICursor2 = this._timeWithoutUICursor;
		this._timeWithoutUICursor = timeWithoutUICursor2;
		this.HadUICursor = true;
	}

	// Token: 0x1700018B RID: 395
	// (get) Token: 0x06000F89 RID: 3977 RVA: 0x000021DB File Offset: 0x000003DB
	public static float UITextAlpha
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x000021DB File Offset: 0x000003DB
	public static float UITextAlphaCustom(float _timeForFullUIMouse, float _timeForUIMouseFade = 1f)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x0004E0D0 File Offset: 0x0004C2D0
	public global::Cursor GetUICursor()
	{
		global::Cursor cursor;
		return cursor;
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x0004E0F4 File Offset: 0x0004C2F4
	public global::Cursor GetWorldCursor()
	{
		/*
An exception occurred when decompiling this method (06000F8C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Cursor XNAUIInputLayer::GetWorldCursor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0029:
	stloc:CursorInputLayer(var_9_2F, ldfld:CursorInputLayer(XNAUIInputLayer::_worldInputLayer, ldloc:XNAUIInputLayer(this)))
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

	// Token: 0x04001C26 RID: 7206
	public static XNAUIInputLayer Instance;

	// Token: 0x04001C27 RID: 7207
	public CursorInputLayer _inputLayer;

	// Token: 0x04001C28 RID: 7208
	public CursorInputLayer _inputLayer2;

	// Token: 0x04001C29 RID: 7209
	public CursorInputLayer _worldInputLayer;

	// Token: 0x04001C2A RID: 7210
	public int UICrusorDraggingFromAxis = 1;

	// Token: 0x04001C2B RID: 7211
	public bool UICrusorDragging = true;

	// Token: 0x04001C2C RID: 7212
	public bool HadUICursor;

	// Token: 0x04001C2D RID: 7213
	private const float TimeForUIMouseFade = 1f;

	// Token: 0x04001C2E RID: 7214
	private const float TimeForFullUIMouse = 1f;

	// Token: 0x04001C2F RID: 7215
	public float _timeWithoutUICursor;
}
