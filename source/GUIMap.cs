using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Map;
using Unity.Collections;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

// Token: 0x02000156 RID: 342
public class GUIMap
{
	// Token: 0x170000EA RID: 234
	// (get) Token: 0x0600095B RID: 2395 RVA: 0x00029088 File Offset: 0x00027288
	// (set) Token: 0x0600095C RID: 2396 RVA: 0x0002909C File Offset: 0x0002729C
	public GUIMap.MinimapFrameStyle ActiveFrameStyle
	{
		get
		{
			return this._activeFrameStyle;
		}
		set
		{
			this._activeFrameStyle = value;
			if (!true)
			{
			}
			string text2;
			string text = "Images/UI/Minimap/" + text2 + "/MinimapFrame";
			this.BackingMiniTextureId = text;
			string text4;
			string text3 = "Images/UI/Minimap/" + text4 + "/MinimapFrameConsole";
			this.BackingLargeTextureId = text3;
		}
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x000290E4 File Offset: 0x000272E4
	private unsafe void ClearMap()
	{
		bool flag = this.use565Map;
		int num = this.activeY;
		int num2 = this.activeX;
		Microsoft.Xna.Framework.Graphics.Texture2D[] array = this.mapTarget;
		NativeArray<ushort>[] array2 = this.mapTextureData;
		int num3 = this.activeX;
		NativeArray<ushort>[] array3 = this.mapTextureData;
		ushort*[] array4 = this.mapTextureDataPtr;
		int num4 = this.activeX;
		bool[] array5 = this.mapDirty;
		int num5 = this.activeY;
		if (num4 == 0)
		{
		}
		Main.clearMap = false;
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x0002915C File Offset: 0x0002735C
	private unsafe void ApplyMap()
	{
		int num = this.activeY;
		int num2 = this.activeX;
		if (this.mapDirty != null)
		{
			string <Name>k__BackingField = this.mapTarget.<Name>k__BackingField;
			global::UnityEngine.Texture2D texture2D;
			texture2D.Apply();
			int num3 = this.activeX;
			bool[] array = this.mapDirty;
			ushort*[] array2 = this.mapTextureDataPtr;
		}
		int num4 = this.activeY;
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x000291B8 File Offset: 0x000273B8
	private unsafe void InitialiseTargets()
	{
		Microsoft.Xna.Framework.Graphics.Texture2D[] array = this.mapTarget;
		int num;
		if (array != null)
		{
			num = this.activeX;
			EventHandler<EventArgs> disposing = array.Disposing;
		}
		Microsoft.Xna.Framework.Graphics.Texture2D[] array2 = this.mapTarget;
		this.use565Map = num != 0;
		if (array2 != null)
		{
			EventHandler<EventArgs> disposing2 = array2.Disposing;
			int num2 = this.activeX;
			int num3 = this.activeX;
			int num4 = this.activeX;
			int num5 = this.activeX;
			ushort*[] array3 = this.mapTextureDataPtr;
			int num6 = this.activeX;
			ushort*[] array4 = this.mapTextureDataPtr;
			return;
		}
		int num7 = this.activeX;
		int num8 = this.activeX;
		int num9 = this.activeX;
		int num10 = this.activeX;
		bool flag = this.use565Map;
		Microsoft.Xna.Framework.Graphics.Texture2D[] array5 = this.mapTarget;
		bool[] array6 = this.mapDirty;
		ushort*[] array7 = this.mapTextureDataPtr;
		Microsoft.Xna.Framework.Graphics.Texture2D[] array8 = this.mapTarget;
	}

	// Token: 0x06000960 RID: 2400 RVA: 0x00029288 File Offset: 0x00027488
	public void LoadContent(ContentManager content)
	{
		GUIMap.MinimapFrameStyle activeFrameStyle = this._activeFrameStyle;
		string text2;
		string text = "Images/UI/Minimap/" + text2 + "/HideMiniMap";
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(text);
		this.miniMapOpen = texture2D;
		GUIMap.MinimapFrameStyle activeFrameStyle2 = this._activeFrameStyle;
		string text4;
		string text3 = "Images/UI/Minimap/" + text4 + "/ShowMiniMap";
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D2 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(text3);
		this.miniMapClosed = texture2D2;
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x000292EC File Offset: 0x000274EC
	public void LoadDefaultZoom()
	{
		float num;
		Main.mapMinimapScale = num;
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x00029304 File Offset: 0x00027504
	public bool IsCursorOverFullScreenMapControls(global::Cursor cursor)
	{
		float x = cursor.Position.x;
		float y = cursor.Position.y;
		if (!true)
		{
		}
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		return true;
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x00029350 File Offset: 0x00027550
	public void CleanupMapTargets()
	{
		Microsoft.Xna.Framework.Graphics.Texture2D[] array = this.mapTarget;
		if (array != null)
		{
			EventHandler<EventArgs> disposing = array.Disposing;
			string <Name>k__BackingField = array.<Name>k__BackingField;
			if (disposing == null)
			{
			}
			global::UnityEngine.Texture2D texture2D;
			global::UnityEngine.Object.DestroyImmediate(texture2D);
			int num = this.activeX;
			int num2 = this.activeX;
			int num3 = this.activeX;
		}
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x0002939C File Offset: 0x0002759C
	[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
	[Il2CppSetOption(Option.NullChecks, false)]
	public void DrawToMap()
	{
		WorldMap map = Main.Map;
		if (map != null)
		{
			map.UpdateChunks();
		}
		bool mapEnabled = Main.mapEnabled;
		int num = this.activeY;
		this.activeY = num;
		this.InitialiseTargets();
		bool clearMap = Main.clearMap;
		this.ClearMap();
		int mapMinX = Main.mapMinX;
		int mapMaxX = Main.mapMaxX;
		int mapMinY = Main.mapMinY;
		int mapMaxY = Main.mapMaxY;
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x000294E0 File Offset: 0x000276E0
	private unsafe void ApplySection(int xStart, int xEnd, int yStart, int yEnd)
	{
		if (!true)
		{
		}
		WorldMap map = Main.Map;
		int num = this.activeX;
		Microsoft.Xna.Framework.Graphics.Texture2D[] array = this.mapTarget;
		int num2 = this.activeX;
		if (this.mapDirty != null)
		{
			ushort*[] array2 = this.mapTextureDataPtr;
			return;
		}
		NativeArray<ushort>[] array3 = this.mapTextureData;
		int num3 = this.activeX;
		NativeArray<ushort>[] array4 = this.mapTextureData;
		int num4 = this.activeX;
		ushort*[] array5 = this.mapTextureDataPtr;
		bool[] array6 = this.mapDirty;
		MapTile* ptr;
		byte color = ptr->Color;
		byte light = ptr->Light;
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x000021DB File Offset: 0x000003DB
	public IEnumerator DrawToMap_Section_Sliced(int secX, int secY)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x0002958C File Offset: 0x0002778C
	public unsafe void DrawToMap_Section(int secX, int secY)
	{
		if (!true)
		{
		}
		int num = this.activeY;
		this.activeY = num;
		this.InitialiseTargets();
		int num2 = 150;
		if (num == 0)
		{
		}
		if (num2 == 0)
		{
		}
		if (num == 0)
		{
		}
		if (num2 == 0)
		{
		}
		WorldMap map = Main.Map;
		if (num == 0)
		{
		}
		int num3 = this.activeX;
		Microsoft.Xna.Framework.Graphics.Texture2D[] array = this.mapTarget;
		int num4 = this.activeX;
		if (this.mapDirty != null)
		{
			ushort*[] array2 = this.mapTextureDataPtr;
			return;
		}
		NativeArray<ushort>[] array3 = this.mapTextureData;
		int num5 = this.activeX;
		NativeArray<ushort>[] array4 = this.mapTextureData;
		int num6 = this.activeX;
		ushort*[] array5 = this.mapTextureDataPtr;
		bool[] array6 = this.mapDirty;
		if (num6 == 0)
		{
		}
		WorldMap map2 = Main.Map;
		MapTile* ptr;
		byte color = ptr->Color;
		byte light = ptr->Light;
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x0002967C File Offset: 0x0002787C
	public void ResetMapPing()
	{
		if (!true)
		{
		}
		this._lastPingMouseDownTime = 1;
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x00029694 File Offset: 0x00027894
	public void DrawMap()
	{
		if ("" == null)
		{
		}
		bool mapEnabled = Main.mapEnabled;
		if ("" == null)
		{
		}
		bool mapReady = Main.mapReady;
		if ("" == null)
		{
		}
		bool mapFullscreen = Main.mapFullscreen;
		GUIControllerFullScreenMap controller = this._controller;
	}

	// Token: 0x0600096A RID: 2410 RVA: 0x0002AE9C File Offset: 0x0002909C
	private void DrawMapFullscreenBackground(Microsoft.Xna.Framework.Vector2 screenPosition, int screenWidth, int screenHeight)
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		Tile tile;
		ushort wall = tile.wall;
	}

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x0600096B RID: 2411 RVA: 0x0002B04C File Offset: 0x0002924C
	private int WorldScreenWidth
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600096B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIMap::get_WorldScreenWidth()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_0A, callgetter:bool(Main::get_mapFullscreen))
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

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x0600096C RID: 2412 RVA: 0x0002B064 File Offset: 0x00029264
	private int WorldScreenHeight
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600096C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIMap::get_WorldScreenHeight()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_0A, callgetter:bool(Main::get_mapFullscreen))
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

	// Token: 0x0600096D RID: 2413 RVA: 0x0002B07C File Offset: 0x0002927C
	public GUIMap()
	{
	}

	// Token: 0x0400090A RID: 2314
	private const int MapTextureDimensions = 256;

	// Token: 0x0400090B RID: 2315
	private bool grabbedMap;

	// Token: 0x0400090C RID: 2316
	private int activeX;

	// Token: 0x0400090D RID: 2317
	private int activeY;

	// Token: 0x0400090E RID: 2318
	private Microsoft.Xna.Framework.Graphics.Texture2D[] mapTarget;

	// Token: 0x0400090F RID: 2319
	private bool[] mapDirty;

	// Token: 0x04000910 RID: 2320
	private NativeArray<ushort>[] mapTextureData;

	// Token: 0x04000911 RID: 2321
	private unsafe ushort*[] mapTextureDataPtr;

	// Token: 0x04000912 RID: 2322
	public bool miniMapEnabled = true;

	// Token: 0x04000913 RID: 2323
	private bool minimapPressed;

	// Token: 0x04000914 RID: 2324
	private bool mapPressed;

	// Token: 0x04000915 RID: 2325
	private bool mapPressedLast;

	// Token: 0x04000916 RID: 2326
	private bool mapZoomInPressed;

	// Token: 0x04000917 RID: 2327
	private bool mapZoomOutPressed;

	// Token: 0x04000918 RID: 2328
	private bool mapZoomResetPressed;

	// Token: 0x04000919 RID: 2329
	public Microsoft.Xna.Framework.Graphics.Texture2D miniMapOpen;

	// Token: 0x0400091A RID: 2330
	public Microsoft.Xna.Framework.Graphics.Texture2D miniMapClosed;

	// Token: 0x0400091B RID: 2331
	private float ZoomInButtonScale;

	// Token: 0x0400091C RID: 2332
	private float ZoomOutButtonScale;

	// Token: 0x0400091D RID: 2333
	private float ZoomDefaultButtonScale;

	// Token: 0x0400091E RID: 2334
	private float ToggleButtonScale;

	// Token: 0x0400091F RID: 2335
	private float MapButtonScale = (float)16256;

	// Token: 0x04000920 RID: 2336
	private bool use565Map;

	// Token: 0x04000921 RID: 2337
	private GUIMap.MinimapFrameStyle _activeFrameStyle;

	// Token: 0x04000922 RID: 2338
	public string BackingMiniTextureId;

	// Token: 0x04000923 RID: 2339
	public string BackingLargeTextureId;

	// Token: 0x04000924 RID: 2340
	private bool draggingSlider;

	// Token: 0x04000925 RID: 2341
	private float ZoomValue;

	// Token: 0x04000926 RID: 2342
	private float TinyScrollScale;

	// Token: 0x04000927 RID: 2343
	private float TinyXOffset;

	// Token: 0x04000928 RID: 2344
	private float TinyYOffset;

	// Token: 0x04000929 RID: 2345
	private float TinyW;

	// Token: 0x0400092A RID: 2346
	private float TinyH;

	// Token: 0x0400092B RID: 2347
	private GUIControllerFullScreenMap _controller;

	// Token: 0x0400092C RID: 2348
	private DateTime _lastPingMouseDownTime;

	// Token: 0x0400092D RID: 2349
	private Microsoft.Xna.Framework.Vector2 _lastPingMousePosition;

	// Token: 0x0400092E RID: 2350
	private int LastFrame = 1;

	// Token: 0x02000157 RID: 343
	public enum MinimapFrameStyle
	{
		// Token: 0x04000930 RID: 2352
		Default,
		// Token: 0x04000931 RID: 2353
		Golden,
		// Token: 0x04000932 RID: 2354
		Remix,
		// Token: 0x04000933 RID: 2355
		Sticks,
		// Token: 0x04000934 RID: 2356
		StoneGold,
		// Token: 0x04000935 RID: 2357
		TwigLeaf,
		// Token: 0x04000936 RID: 2358
		Leaf,
		// Token: 0x04000937 RID: 2359
		Retro,
		// Token: 0x04000938 RID: 2360
		Valkyrie
	}

	// Token: 0x02000158 RID: 344
	[CompilerGenerated]
	private sealed class <DrawToMap_Section_Sliced>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600096E RID: 2414 RVA: 0x0002B0A8 File Offset: 0x000292A8
		[DebuggerHidden]
		public <DrawToMap_Section_Sliced>d__41(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0002B0C4 File Offset: 0x000292C4
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0002B0D4 File Offset: 0x000292D4
		private bool MoveNext()
		{
			/*
An exception occurred when decompiling this method (06000970)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIMap/<DrawToMap_Section_Sliced>d__41::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00CD:
	stloc:int32(var_12_D6, ldfld:int32('<DrawToMap_Section_Sliced>d__41'::<ty>5__5, ldloc:'<DrawToMap_Section_Sliced>d__41'(this)))
	stloc:int32(var_13_DE, ldfld:int32('<DrawToMap_Section_Sliced>d__41'::<chunkEndY>5__7, ldloc:'<DrawToMap_Section_Sliced>d__41'(this)))
	call:void(GUIMap::ApplySection, ldloc:GUIMap(var_1_0D), ldloc:int32(var_7), ldc.i4:int32(-2147483648), ldloc:int32(var_12_D6), ldloc:int32(var_13_DE))
	call:void(GUIMap::ApplyMap, ldloc:GUIMap(var_1_0D))
	stloc:int32(var_14_F8, ldc.i4:int32(1))
	stfld:int32('<DrawToMap_Section_Sliced>d__41'::<tx>5__6, ldloc:'<DrawToMap_Section_Sliced>d__41'(this), ldc.i4:int32(-2147483648))
	stfld:int32('<DrawToMap_Section_Sliced>d__41'::<>1__state, ldloc:'<DrawToMap_Section_Sliced>d__41'(this), ldloc:int32(var_14_F8))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x0002B1F0 File Offset: 0x000293F0
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x000021DB File Offset: 0x000003DB
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x0002B204 File Offset: 0x00029404
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x04000939 RID: 2361
		private int <>1__state;

		// Token: 0x0400093A RID: 2362
		private object <>2__current;

		// Token: 0x0400093B RID: 2363
		public GUIMap <>4__this;

		// Token: 0x0400093C RID: 2364
		public int secX;

		// Token: 0x0400093D RID: 2365
		public int secY;

		// Token: 0x0400093E RID: 2366
		private int <xStart>5__2;

		// Token: 0x0400093F RID: 2367
		private int <xEnd>5__3;

		// Token: 0x04000940 RID: 2368
		private int <yEnd>5__4;

		// Token: 0x04000941 RID: 2369
		private int <ty>5__5;

		// Token: 0x04000942 RID: 2370
		private int <tx>5__6;

		// Token: 0x04000943 RID: 2371
		private int <chunkEndY>5__7;
	}
}
