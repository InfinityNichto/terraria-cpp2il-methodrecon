using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Drawing;
using Terraria.Map;
using Unity.IL2CPP.CompilerServices;

namespace Terraria.Graphics.Light
{
	// Token: 0x02000776 RID: 1910
	public class LightingEngine : ILightingEngine
	{
		// Token: 0x06003E91 RID: 16017 RVA: 0x0023DC50 File Offset: 0x0023BE50
		public LightingEngine()
		{
			if (!true)
			{
			}
			this._threadManager = 1;
			base..ctor();
		}

		// Token: 0x06003E92 RID: 16018 RVA: 0x000021DB File Offset: 0x000003DB
		public void AddLight(int x, int y, Vector3 color)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003E93 RID: 16019 RVA: 0x0023DC70 File Offset: 0x0023BE70
		public void Clear()
		{
			this._activeLightMap.Clear();
			this._workingLightMap.Clear();
			List<LightingEngine.PerFrameLight> perFrameLights = this._perFrameLights;
			int version = perFrameLights._version;
			perFrameLights._syncRoot = version;
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x0023DCA8 File Offset: 0x0023BEA8
		public LightMap GetLightMap([Out] Rectangle lightMapRegion)
		{
			return this._activeLightMap;
		}

		// Token: 0x06003E95 RID: 16021 RVA: 0x0023DCBC File Offset: 0x0023BEBC
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		public Vector3 GetColor(int x, int y)
		{
			LightMap activeLightMap = this._activeLightMap;
			Rectangle activeProcessedArea = this._activeProcessedArea;
			int width = this._activeProcessedArea.Width;
			int <Height>k__BackingField = activeLightMap.<Height>k__BackingField;
			return activeLightMap._colors;
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x0023DCFC File Offset: 0x0023BEFC
		public void ProcessArea(Rectangle area)
		{
			if (!true)
			{
			}
			Main.renderCount = Main.renderCount;
			this.SetState();
			this._timer.Start();
			LightingEngine.EngineState state = this._state;
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x0023DE08 File Offset: 0x0023C008
		private void SetState()
		{
			if (!true)
			{
			}
			int renderCount = Main.renderCount;
			this._state = (LightingEngine.EngineState)renderCount;
		}

		// Token: 0x06003E98 RID: 16024 RVA: 0x0023DE28 File Offset: 0x0023C028
		private void ProcessScan(Rectangle area)
		{
			this._workingLightMap.SetSize(20, 20);
			this._workingLightMap.<NonVisiblePadding>k__BackingField = 10;
			this._tileScanner.Update();
			TileLightScanner tileScanner = this._tileScanner;
			LightMap workingLightMap = this._workingLightMap;
		}

		// Token: 0x06003E99 RID: 16025 RVA: 0x0023DE6C File Offset: 0x0023C06C
		private void ProcessBlur()
		{
			this.UpdateLightDecay();
			this.ApplyPerFrameLights();
			this._workingLightMap.BlurPass();
		}

		// Token: 0x06003E9A RID: 16026 RVA: 0x0023DE90 File Offset: 0x0023C090
		private void ProcessBlur2()
		{
			this._workingLightMap.BlurPass();
		}

		// Token: 0x06003E9B RID: 16027 RVA: 0x0023DEA8 File Offset: 0x0023C0A8
		private void Present()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003E9C RID: 16028 RVA: 0x0023DEB8 File Offset: 0x0023C0B8
		private void UpdateLightDecay()
		{
			LightMap workingLightMap = this._workingLightMap;
			Vector3[] decayColors = workingLightMap._decayColors;
			Vector3[] decayColors2 = workingLightMap._decayColors;
			if (workingLightMap._decayColors == null)
			{
			}
			int waterStyle = Main.waterStyle;
		}

		// Token: 0x06003E9D RID: 16029 RVA: 0x0023DF8C File Offset: 0x0023C18C
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		private void ApplyPerFrameLights()
		{
			LightMap workingLightMap = this._workingLightMap;
			Vector3[] colors = workingLightMap._colors;
			int <Height>k__BackingField = workingLightMap.<Height>k__BackingField;
			if (colors != null && workingLightMap != null)
			{
				return;
			}
			int size = this._perFrameLights._size;
			Rectangle workingProcessedArea = this._workingProcessedArea;
			int width = this._workingProcessedArea.Width;
			int y = workingProcessedArea.Y;
			int width2 = workingProcessedArea.Width;
			List<LightingEngine.PerFrameLight> perFrameLights = this._perFrameLights;
			int size2 = perFrameLights._size;
			int version = perFrameLights._version;
			perFrameLights._syncRoot = version;
		}

		// Token: 0x06003E9E RID: 16030 RVA: 0x0023E010 File Offset: 0x0023C210
		public void Rebuild()
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			this._workingProcessedArea.X = 1;
		}

		// Token: 0x06003E9F RID: 16031 RVA: 0x0023E034 File Offset: 0x0023C234
		private void ExportBatchFinished(int index)
		{
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06003EA0 RID: 16032 RVA: 0x0023E044 File Offset: 0x0023C244
		private ThreadedRenderManager.BatchProcessCallback ExportBatchFinishedCallback
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003EA0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ThreadedRenderManager/BatchProcessCallback Terraria.Graphics.Light.LightingEngine::get_ExportBatchFinishedCallback()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:BatchProcessCallback[exp:bool](LightingEngine::_processBatchFinishedCallback, ldloc:LightingEngine(this)))
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
		}

		// Token: 0x06003EA1 RID: 16033 RVA: 0x0023E058 File Offset: 0x0023C258
		private void ExportToMiniMapThreaded(int firstTileX, int firstTileY, int lastTileX, int lastTileY)
		{
			LightingEngine lightingEngine = this._threadManager.DrawThreads.lightingEngine;
			WallDrawing wallDrawing = this._threadManager.DrawThreads.wallDrawing;
			TileDrawing tileDrawing = this._threadManager.DrawThreads.tileDrawing;
			this.ExportToMiniMap(firstTileX, firstTileY, firstTileY, lastTileX);
			ThreadedRenderManager threadManager = this._threadManager;
			ThreadedRenderManager.BatchProcessCallback exportBatchFinishedCallback = this.ExportBatchFinishedCallback;
			int num = 3;
			threadManager.WaitAndProcess(exportBatchFinishedCallback, num);
		}

		// Token: 0x06003EA2 RID: 16034 RVA: 0x0023E0C0 File Offset: 0x0023C2C0
		public Rectangle GetScanRegion()
		{
			Rectangle rectangle = this.screenRegionScan;
			int width = this.screenRegionScan.Width;
			return rectangle;
		}

		// Token: 0x06003EA3 RID: 16035 RVA: 0x0023E0E4 File Offset: 0x0023C2E4
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		public void ExportToMiniMap(int left, int top, int right, int bottom)
		{
			if (!true)
			{
			}
			WorldMap map = Main.Map;
		}

		// Token: 0x06003EA4 RID: 16036 RVA: 0x0023E1D4 File Offset: 0x0023C3D4
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		private void ExportToMiniMap()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool mapEnabled = Main.mapEnabled;
			if (num == 0)
			{
			}
			bool mapReady = Main.mapReady;
			int width = this._activeProcessedArea.Width;
			int height = this._activeProcessedArea.Height;
			Rectangle activeProcessedArea = this._activeProcessedArea;
			int width2 = this._activeProcessedArea.Width;
			if (width == 0)
			{
			}
			if (width == 0)
			{
			}
			Rectangle rectangle;
			Main.mapMaxX = rectangle.Right;
			int num2;
			Main.mapMaxY = num2;
			long num3 = 0L;
			int num4;
			int num5;
			this.ExportToMiniMapThreaded((int)num3, 42183576, num4, num5);
		}

		// Token: 0x04007D41 RID: 32065
		public const int AREA_PADDING = 20;

		// Token: 0x04007D42 RID: 32066
		private const int NON_VISIBLE_PADDING = 10;

		// Token: 0x04007D43 RID: 32067
		private readonly List<LightingEngine.PerFrameLight> _perFrameLights;

		// Token: 0x04007D44 RID: 32068
		private TileLightScanner _tileScanner;

		// Token: 0x04007D45 RID: 32069
		private LightMap _activeLightMap;

		// Token: 0x04007D46 RID: 32070
		private Rectangle _activeProcessedArea;

		// Token: 0x04007D47 RID: 32071
		private LightMap _workingLightMap;

		// Token: 0x04007D48 RID: 32072
		private Rectangle _workingProcessedArea;

		// Token: 0x04007D49 RID: 32073
		private readonly Stopwatch _timer;

		// Token: 0x04007D4A RID: 32074
		private LightingEngine.EngineState _state;

		// Token: 0x04007D4B RID: 32075
		private ThreadedRenderManager _threadManager;

		// Token: 0x04007D4C RID: 32076
		private Rectangle screenRegionScan;

		// Token: 0x04007D4D RID: 32077
		private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

		// Token: 0x02000777 RID: 1911
		private enum EngineState
		{
			// Token: 0x04007D4F RID: 32079
			MinimapUpdate,
			// Token: 0x04007D50 RID: 32080
			ExportMetrics,
			// Token: 0x04007D51 RID: 32081
			Scan,
			// Token: 0x04007D52 RID: 32082
			Blur,
			// Token: 0x04007D53 RID: 32083
			Blur2
		}

		// Token: 0x02000778 RID: 1912
		private struct PerFrameLight
		{
			// Token: 0x06003EA5 RID: 16037 RVA: 0x0023E278 File Offset: 0x0023C478
			public PerFrameLight(Point position, Vector3 color)
			{
				this.Position = position;
			}

			// Token: 0x04007D54 RID: 32084
			public Point Position;

			// Token: 0x04007D55 RID: 32085
			public Vector3 Color;
		}
	}
}
