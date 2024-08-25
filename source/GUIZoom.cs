using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Terraria;
using UnityEngine;

// Token: 0x0200017A RID: 378
public class GUIZoom
{
	// Token: 0x06000ABD RID: 2749 RVA: 0x00036B38 File Offset: 0x00034D38
	public float GetDefaultWorldZoomScale()
	{
		/*
An exception occurred when decompiling this method (06000ABD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIZoom::GetDefaultWorldZoomScale()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(GUIZoom::ZoomValue, ldloc:GUIZoom(this)))
	stloc:DrPlatformType(var_3_0E, callgetter:DrPlatformType(DrPlatform::get_CurrentPlatform))
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

	// Token: 0x06000ABE RID: 2750 RVA: 0x00036B54 File Offset: 0x00034D54
	public void LoadDefaultZoom()
	{
		float defaultWorldZoomScale = this.DefaultWorldZoomScale;
		float defaultWorldZoomScale2 = this.GetDefaultWorldZoomScale();
		if (!true)
		{
		}
	}

	// Token: 0x06000ABF RID: 2751 RVA: 0x00036B74 File Offset: 0x00034D74
	public GUIZoom()
	{
		this._inputlayerZoomPinch.Priority = 99;
	}

	// Token: 0x06000AC0 RID: 2752 RVA: 0x00036BAC File Offset: 0x00034DAC
	private bool IsCursorOver(Microsoft.Xna.Framework.Vector2 position, [Out] float sliderPosition)
	{
		return true;
	}

	// Token: 0x06000AC1 RID: 2753 RVA: 0x00036BC8 File Offset: 0x00034DC8
	private void ApplyPixelZoom(float pixelScale)
	{
		if (!true)
		{
		}
		bool mapEnabled = Main.mapEnabled;
	}

	// Token: 0x06000AC2 RID: 2754 RVA: 0x00036CA4 File Offset: 0x00034EA4
	private void UpdatePixelZoom()
	{
	}

	// Token: 0x06000AC3 RID: 2755 RVA: 0x00036CB4 File Offset: 0x00034EB4
	public void UpdateCursorDummy(global::Cursor cursor)
	{
	}

	// Token: 0x06000AC4 RID: 2756 RVA: 0x00036CC4 File Offset: 0x00034EC4
	public void UpdateCursor(global::Cursor cursor)
	{
		if (!true)
		{
		}
		bool gameMenu = Main.gameMenu;
		CursorInputLayer inputLayer;
		if (cursor.InputLayer != null)
		{
			inputLayer = cursor.InputLayer;
			CursorInputLayer inputLayer2 = this._inputLayer;
		}
		float x = cursor.Position.x;
		float y = cursor.Position.y;
		if (inputLayer == null)
		{
		}
		CursorInputLayer inputLayer3 = this._inputLayer;
	}

	// Token: 0x06000AC5 RID: 2757 RVA: 0x00036D44 File Offset: 0x00034F44
	public void UpdatePinchZoom()
	{
		float x3;
		float y3;
		float mapFullscreenScale3;
		int num;
		for (;;)
		{
			if (!true)
			{
			}
			bool mapFullscreen = Main.mapFullscreen;
			bool pinchZoomMapEnabled = this.PinchZoomMapEnabled;
			if (!pinchZoomMapEnabled)
			{
				return;
			}
			if (!pinchZoomMapEnabled)
			{
			}
			bool mapFullscreen2 = Main.mapFullscreen;
			if (!this.PinchZoomWorldEnabled)
			{
			}
			if (this._pinchZoomActive)
			{
				global::Cursor cursor;
				if (cursor.Down)
				{
					global::Cursor zoomCursor = this._zoomCursor0;
					global::Cursor zoomCursor2 = this._zoomCursor1;
				}
				global::Cursor zoomCursor3 = this._zoomCursor0;
				global::Cursor zoomCursor4 = this._zoomCursor1;
				float x = zoomCursor3.Position.x;
				float y = zoomCursor3.Position.y;
				float x2 = zoomCursor4.Position.x;
				float y2 = zoomCursor4.Position.y;
				if (zoomCursor3 == null)
				{
				}
				if (zoomCursor3 == null)
				{
				}
				bool mapFullscreen3 = Main.mapFullscreen;
				if (this._lastFrameFullScreenMap)
				{
					x3 = this._lastFrameGrabCentre.X;
					y3 = this._lastFrameGrabCentre.Y;
					Microsoft.Xna.Framework.Vector2 mapFullscreenPos = Main.mapFullscreenPos;
					float mapFullscreenScale = Main.mapFullscreenScale;
					float mapFullscreenScale2 = Main.mapFullscreenScale;
				}
				bool mapFullscreen4 = Main.mapFullscreen;
				if (true)
				{
					break;
				}
				global::Cursor zoomCursor5 = this._zoomCursor0;
				global::Cursor zoomCursor6 = this._zoomCursor1;
				float x4 = zoomCursor5.Position.x;
				float x5 = zoomCursor6.Position.x;
				if (!true)
				{
				}
				float initialZoom = this._initialZoom;
				this.ApplyPixelZoom(mapFullscreenScale3);
				if (this._pinchZoomActive)
				{
					return;
				}
			}
			else
			{
				num = 1;
				global::Cursor cursor2;
				if (cursor2.IgnoreForWorld)
				{
					return;
				}
				bool mapFullscreen5 = Main.mapFullscreen;
				bool mapFullscreen6 = Main.mapFullscreen;
				if (this._zoomCursor1 == null)
				{
					goto Block_6;
				}
			}
		}
		return;
		Block_6:
		int num2;
		this._zoomCursor1 = num2;
		this._pinchZoomActive = num != 0;
		CursorInputLayer inputlayerZoomPinch = this._inputlayerZoomPinch;
		this._initialPosition0 = inputlayerZoomPinch;
		this._initialPosition1 = inputlayerZoomPinch;
		this._lastFrameGrabCentre.X = x3;
		this._lastFrameGrabCentre.Y = y3;
		bool mapFullscreen7 = Main.mapFullscreen;
		bool mapFullscreen8 = Main.mapFullscreen;
		mapFullscreenScale3 = Main.mapFullscreenScale;
		this._initialZoom = x3;
	}

	// Token: 0x06000AC6 RID: 2758 RVA: 0x00036F40 File Offset: 0x00035140
	public void Draw()
	{
	}

	// Token: 0x04000B15 RID: 2837
	private bool draggingSlider;

	// Token: 0x04000B16 RID: 2838
	private float ZoomValue = (float)16128;

	// Token: 0x04000B17 RID: 2839
	private CursorInputLayer _inputLayer;

	// Token: 0x04000B18 RID: 2840
	private CursorInputLayer _inputlayerZoomPinch;

	// Token: 0x04000B19 RID: 2841
	private float MaxZoomValue;

	// Token: 0x04000B1A RID: 2842
	public float DefaultWorldZoomScale;

	// Token: 0x04000B1B RID: 2843
	private bool _pinchZoomActive;

	// Token: 0x04000B1C RID: 2844
	private global::Cursor _zoomCursor0;

	// Token: 0x04000B1D RID: 2845
	private global::Cursor _zoomCursor1;

	// Token: 0x04000B1E RID: 2846
	private global::UnityEngine.Vector2 _initialPosition0;

	// Token: 0x04000B1F RID: 2847
	private global::UnityEngine.Vector2 _initialPosition1;

	// Token: 0x04000B20 RID: 2848
	private bool _lastFrameFullScreenMap;

	// Token: 0x04000B21 RID: 2849
	private Microsoft.Xna.Framework.Vector2 _lastFrameGrabCentre;

	// Token: 0x04000B22 RID: 2850
	private float _initialZoom;

	// Token: 0x04000B23 RID: 2851
	public bool PinchZoomWorldEnabled = 257 != 0;

	// Token: 0x04000B24 RID: 2852
	public bool PinchZoomMapEnabled;
}
