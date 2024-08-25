using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Win32.SafeHandles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Liquid;
using Terraria.Graphics;
using Terraria.Graphics.Light;
using UnityEngine;

// Token: 0x020002D7 RID: 727
public class ThreadedRenderManager
{
	// Token: 0x060010B7 RID: 4279 RVA: 0x00052D9C File Offset: 0x00050F9C
	private static string GetStackTrace(Thread t)
	{
		string newLine = Environment.NewLine;
		if ("<UnknownType>" == null)
		{
			return;
		}
	}

	// Token: 0x060010B8 RID: 4280 RVA: 0x00052DC8 File Offset: 0x00050FC8
	public static void GetTilePartition(int partitionIndex, int partitionCount, int firstTileX, int firstTileY, int lastTileX, int lastTileY, [Out] int resultFirstTileX, [Out] int resultFirstTileY, [Out] int resultLastTileX, [Out] int resultLastTileY)
	{
		resultFirstTileX.m_value = firstTileX;
	}

	// Token: 0x060010B9 RID: 4281 RVA: 0x00052DE0 File Offset: 0x00050FE0
	public ThreadedRenderManager()
	{
		ThreadedRenderManager.RenderThreadInstance[] drawThreads = this.DrawThreads;
	}

	// Token: 0x060010BA RID: 4282 RVA: 0x00052E60 File Offset: 0x00051060
	public void ThreadMonitor()
	{
		ThreadedRenderManager.RenderThreadInstance[] drawThreads = this.DrawThreads;
		LiquidRenderer waterRenderer = drawThreads.waterRenderer;
		if (!drawThreads.ThreadHandle.IsAlive)
		{
			if (waterRenderer == null)
			{
			}
			string text;
			Debug.LogError(text);
			ThreadedRenderManager.RenderThreadInstance[] drawThreads2 = this.DrawThreads;
		}
		ThreadedRenderManager.RenderThreadInstance[] drawThreads3 = this.DrawThreads;
		Thread.Sleep(10);
	}

	// Token: 0x060010BB RID: 4283 RVA: 0x00052EA8 File Offset: 0x000510A8
	public void WaitAndProcessInOrder(ThreadedRenderManager.BatchProcessCallback callback, int numberOfThreads)
	{
		AutoResetEvent[][] waitHandles = this.WaitHandles;
		int[][] waitThreads = this.WaitThreads;
		SafeWaitHandle safeWaitHandle = waitHandles.safeWaitHandle;
		if (numberOfThreads == 0 || numberOfThreads != 0)
		{
			AutoResetEvent[][] waitHandles2 = this.WaitHandles;
			int[][] waitThreads2 = this.WaitThreads;
			return;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x060010BC RID: 4284 RVA: 0x00052F54 File Offset: 0x00051154
	public void WaitAndProcess(ThreadedRenderManager.BatchProcessCallback callback, int numberOfThreads)
	{
		AutoResetEvent[][] waitHandles = this.WaitHandles;
		int[][] waitThreads = this.WaitThreads;
		SafeWaitHandle safeWaitHandle = waitHandles.safeWaitHandle;
		if ("Thread wait aborted!" != null)
		{
			AutoResetEvent[][] waitHandles2 = this.WaitHandles;
			int[][] waitThreads2 = this.WaitThreads;
			return;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x060010BD RID: 4285 RVA: 0x00052FF8 File Offset: 0x000511F8
	// Note: this type is marked as 'beforefieldinit'.
	static ThreadedRenderManager()
	{
	}

	// Token: 0x04002078 RID: 8312
	public static int PrefferedThreadCount;

	// Token: 0x04002079 RID: 8313
	private const int MaxThreadCount = 3;

	// Token: 0x0400207A RID: 8314
	public static ThreadedRenderManager Instance;

	// Token: 0x0400207B RID: 8315
	public ThreadedRenderManager.RenderThreadInstance[] DrawThreads;

	// Token: 0x0400207C RID: 8316
	private AutoResetEvent[][] WaitHandles;

	// Token: 0x0400207D RID: 8317
	private int[][] WaitThreads;

	// Token: 0x0400207E RID: 8318
	private Thread monitor;

	// Token: 0x020002D8 RID: 728
	public sealed class BatchProcessCallback : MulticastDelegate
	{
		// Token: 0x060010BE RID: 4286 RVA: 0x00053008 File Offset: 0x00051208
		public BatchProcessCallback(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0005305C File Offset: 0x0005125C
		public void Invoke(int index)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(int index, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00053080 File Offset: 0x00051280
		public void EndInvoke(IAsyncResult result)
		{
		}
	}

	// Token: 0x020002D9 RID: 729
	public class RenderThreadInstance
	{
		// Token: 0x060010C2 RID: 4290 RVA: 0x00053090 File Offset: 0x00051290
		public RenderThreadInstance(int index)
		{
			this._index = index;
			if (!true)
			{
			}
			ManagedThread managedThread;
			this.ThreadHandle = managedThread;
			MainThreadExecution.ExcludeThread(managedThread);
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x000530C8 File Offset: 0x000512C8
		public void RestartThread()
		{
			bool flag = this.completeEvent.Set();
			bool flag2 = this.startEvent.Reset();
			if (!true)
			{
			}
			ManagedThread managedThread;
			this.ThreadHandle = managedThread;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x000530F8 File Offset: 0x000512F8
		public void DrawRockLayer(int bgStartX, int bgstartY, int bgLoops, int byLoopsY, int diff, Microsoft.Xna.Framework.Vector2 drawOffset)
		{
			AutoResetEvent autoResetEvent = this.completeEvent;
			this._firstTileX = bgStartX;
			this._lastTileX = bgstartY;
			this._lastTileX = bgLoops;
			this._solidLayer = byLoopsY != 0;
			this._task = ThreadedRenderManager.RenderThreadInstance.DrawTask.Background_RockLayer;
			this._diff = diff;
			bool flag = autoResetEvent.Reset();
			bool flag2 = this.startEvent.Set();
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x0005314C File Offset: 0x0005134C
		public void DrawMagmaLayer(int bgStartX, int bgstartY, int bgLoops, int byLoopsY, int diff, Microsoft.Xna.Framework.Vector2 drawOffset)
		{
			AutoResetEvent autoResetEvent = this.completeEvent;
			this._firstTileX = bgStartX;
			this._lastTileX = bgstartY;
			this._lastTileX = bgLoops;
			this._solidLayer = byLoopsY != 0;
			this._task = ThreadedRenderManager.RenderThreadInstance.DrawTask.Background_MagmaLayer;
			this._diff = diff;
			bool flag = autoResetEvent.Reset();
			bool flag2 = this.startEvent.Set();
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x000531A0 File Offset: 0x000513A0
		public void DrawCurrentBackground(int bgStartX, int bgstartY, int bgLoops, int byLoopsY, int diff, Microsoft.Xna.Framework.Vector2 drawOffset)
		{
			AutoResetEvent autoResetEvent = this.completeEvent;
			this._firstTileX = bgStartX;
			this._lastTileX = bgstartY;
			this._lastTileX = bgLoops;
			this._solidLayer = byLoopsY != 0;
			this._task = ThreadedRenderManager.RenderThreadInstance.DrawTask.Background_CurrentLayer;
			this._diff = diff;
			bool flag = autoResetEvent.Reset();
			bool flag2 = this.startEvent.Set();
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x000531F4 File Offset: 0x000513F4
		public void DrawTiles(TileDrawing parent, Microsoft.Xna.Framework.Vector2 screenPosition, Microsoft.Xna.Framework.Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY, bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
		{
			this._firstTileX = screenPosition;
			this._lastTileX = offSet;
			AutoResetEvent autoResetEvent = this.completeEvent;
			this.tileDrawing = parent;
			this._lastTileX = firstTileX;
			this._task = ThreadedRenderManager.RenderThreadInstance.DrawTask.DrawTask_DrawTiles;
			bool flag = autoResetEvent.Reset();
			bool flag2 = this.startEvent.Set();
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x00053240 File Offset: 0x00051440
		public void DrawWalls(WallDrawing parent, Microsoft.Xna.Framework.Vector2 screenPosition, Microsoft.Xna.Framework.Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY)
		{
			AutoResetEvent autoResetEvent = this.completeEvent;
			this.wallDrawing = parent;
			this._firstTileX = screenPosition;
			this._lastTileX = offSet;
			this._task = ThreadedRenderManager.RenderThreadInstance.DrawTask.DrawTask_DrawWalls;
			this._lastTileX = firstTileX;
			this._solidLayer = firstTileY != 0;
			bool flag = autoResetEvent.Reset();
			bool flag2 = this.startEvent.Set();
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00053294 File Offset: 0x00051494
		public void ExportToMinimap(LightingEngine parent, int firstTileX, int firstTileY, int lastTileX, int lastTileY)
		{
			AutoResetEvent autoResetEvent = this.completeEvent;
			this.lightingEngine = parent;
			this._firstTileX = firstTileX;
			this._lastTileX = firstTileY;
			this._task = ThreadedRenderManager.RenderThreadInstance.DrawTask.LightingNew_ExportToMiniMap;
			this._lastTileX = lastTileX;
			this._solidLayer = lastTileY != 0;
			bool flag = autoResetEvent.Reset();
			bool flag2 = this.startEvent.Set();
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x000532E8 File Offset: 0x000514E8
		public void BlurPass1(LightMap parent, int start, int end)
		{
			AutoResetEvent autoResetEvent = this.completeEvent;
			this.lightingMap = parent;
			this._firstTileX = start;
			this._task = ThreadedRenderManager.RenderThreadInstance.DrawTask.LightMap_BlurPass1;
			this._lastTileX = end;
			bool flag = autoResetEvent.Reset();
			bool flag2 = this.startEvent.Set();
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0005332C File Offset: 0x0005152C
		public void BlurPass2(LightMap parent, int start, int end)
		{
			AutoResetEvent autoResetEvent = this.completeEvent;
			this.lightingMap = parent;
			this._firstTileX = start;
			this._task = ThreadedRenderManager.RenderThreadInstance.DrawTask.LightMap_BlurPass2;
			this._lastTileX = end;
			bool flag = autoResetEvent.Reset();
			bool flag2 = this.startEvent.Set();
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00053370 File Offset: 0x00051570
		public void ExportTo(TileLightScanner scanner, int startX, int startY, int endX, int endY, int lightStartX, int lightStartY, LightMap outputMap)
		{
			AutoResetEvent autoResetEvent = this.completeEvent;
			this.tileScanner = scanner;
			this._firstTileX = startX;
			this._lastTileX = startY;
			this._lastTileX = endX;
			this._solidLayer = endY != 0;
			this._task = ThreadedRenderManager.RenderThreadInstance.DrawTask.TileScanner_ExportTo;
			this._scannerTileX = lightStartX;
			this.state = lightStartY;
			bool flag = autoResetEvent.Reset();
			bool flag2 = this.startEvent.Set();
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x000021DB File Offset: 0x000003DB
		public void DrawThread()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400207F RID: 8319
		private ThreadedRenderManager.RenderThreadInstance.DrawTask _task;

		// Token: 0x04002080 RID: 8320
		public LiquidRenderer waterRenderer;

		// Token: 0x04002081 RID: 8321
		public TileDrawing tileDrawing;

		// Token: 0x04002082 RID: 8322
		public WallDrawing wallDrawing;

		// Token: 0x04002083 RID: 8323
		public LightingEngine lightingEngine;

		// Token: 0x04002084 RID: 8324
		public LightMap lightingMap;

		// Token: 0x04002085 RID: 8325
		public TileLightScanner tileScanner;

		// Token: 0x04002086 RID: 8326
		public SpriteBatch spriteBatch;

		// Token: 0x04002087 RID: 8327
		public SpriteBatch spriteBatch2;

		// Token: 0x04002088 RID: 8328
		public TileBatch tileBatch;

		// Token: 0x04002089 RID: 8329
		private AutoResetEvent startEvent;

		// Token: 0x0400208A RID: 8330
		public AutoResetEvent completeEvent;

		// Token: 0x0400208B RID: 8331
		public bool Active;

		// Token: 0x0400208C RID: 8332
		public bool Complete = true;

		// Token: 0x0400208D RID: 8333
		public ManagedThread ThreadHandle;

		// Token: 0x0400208E RID: 8334
		private Microsoft.Xna.Framework.Vector2 _screenPosition;

		// Token: 0x0400208F RID: 8335
		private Microsoft.Xna.Framework.Vector2 _offSet;

		// Token: 0x04002090 RID: 8336
		private int _firstTileX;

		// Token: 0x04002091 RID: 8337
		private int _firstTileY;

		// Token: 0x04002092 RID: 8338
		private int _lastTileX;

		// Token: 0x04002093 RID: 8339
		private int _lastTileY;

		// Token: 0x04002094 RID: 8340
		private bool _solidLayer;

		// Token: 0x04002095 RID: 8341
		private bool _forRenderTargets;

		// Token: 0x04002096 RID: 8342
		private bool _intoRenderTargets;

		// Token: 0x04002097 RID: 8343
		private int _waterStyleOverride;

		// Token: 0x04002098 RID: 8344
		private int _scannerTileX;

		// Token: 0x04002099 RID: 8345
		private int _scannerTileY;

		// Token: 0x0400209A RID: 8346
		private LocalUserGameState state;

		// Token: 0x0400209B RID: 8347
		private int _index;

		// Token: 0x0400209C RID: 8348
		private int _diff;

		// Token: 0x0400209D RID: 8349
		public bool Running;

		// Token: 0x0400209E RID: 8350
		public Dictionary<Point, int> _displayDollTileEntityPositions;

		// Token: 0x0400209F RID: 8351
		public Dictionary<Point, int> _hatRackTileEntityPositions;

		// Token: 0x040020A0 RID: 8352
		public Dictionary<Point, int> _trainingDummyTileEntityPositions;

		// Token: 0x040020A1 RID: 8353
		public Dictionary<Point, int> _itemFrameTileEntityPositions;

		// Token: 0x040020A2 RID: 8354
		public Dictionary<Point, int> _foodPlatterTileEntityPositions;

		// Token: 0x040020A3 RID: 8355
		public Dictionary<Point, int> _weaponRackTileEntityPositions;

		// Token: 0x040020A4 RID: 8356
		public Dictionary<Point, int> _chestPositions;

		// Token: 0x020002DA RID: 730
		private enum DrawTask
		{
			// Token: 0x040020A6 RID: 8358
			None,
			// Token: 0x040020A7 RID: 8359
			DrawTask_DrawTiles,
			// Token: 0x040020A8 RID: 8360
			DrawTask_DrawWalls,
			// Token: 0x040020A9 RID: 8361
			LightingNew_ExportToMiniMap,
			// Token: 0x040020AA RID: 8362
			LightMap_BlurPass1,
			// Token: 0x040020AB RID: 8363
			LightMap_BlurPass2,
			// Token: 0x040020AC RID: 8364
			Background_RockLayer,
			// Token: 0x040020AD RID: 8365
			Background_MagmaLayer,
			// Token: 0x040020AE RID: 8366
			Background_CurrentLayer,
			// Token: 0x040020AF RID: 8367
			TileScanner_ExportTo
		}
	}
}
