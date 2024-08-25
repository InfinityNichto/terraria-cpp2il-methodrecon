using System;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000333 RID: 819
	public class Game : IDisposable
	{
		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x0005EB88 File Offset: 0x0005CD88
		// (set) Token: 0x06001477 RID: 5239 RVA: 0x0005EB9C File Offset: 0x0005CD9C
		public ContentManager Content
		{
			get
			{
				return this.content;
			}
			set
			{
				this.content = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x0005EBB0 File Offset: 0x0005CDB0
		public GraphicsDevice GraphicsDevice
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001478)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.GraphicsDevice Microsoft.Xna.Framework.Game::get_GraphicsDevice()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:GraphicsDevice[exp:bool](Game::graphicsDevice, ldloc:Game(this)))
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

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x0005EBC4 File Offset: 0x0005CDC4
		// (set) Token: 0x0600147A RID: 5242 RVA: 0x0005EBD8 File Offset: 0x0005CDD8
		public bool IsActive
		{
			get
			{
				return this._active;
			}
			set
			{
			}
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0005EBE8 File Offset: 0x0005CDE8
		public Game()
		{
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0005EC0C File Offset: 0x0005CE0C
		protected virtual void Update(GameTime gameTime)
		{
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x0005EC1C File Offset: 0x0005CE1C
		public GameComponentCollection Components
		{
			get
			{
				return this._components;
			}
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x0005EC30 File Offset: 0x0005CE30
		public void UnityAwake()
		{
			if (!true)
			{
			}
			Main.UpdateTrialMode();
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x0005EC48 File Offset: 0x0005CE48
		public void initialiseCallBack(object threadContext)
		{
			if (!true)
			{
			}
			TextureAtlasDB.LoadTextureDBs();
			DateTime now = DateTime.Now;
			this._lastUpdate = now;
			this._firstUpdate = now;
			this._initialised = true;
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0005EC98 File Offset: 0x0005CE98
		public void UnityStart()
		{
			if (!true)
			{
			}
			Main.UpdateTrialMode();
			long num = 0L;
			this.initialiseCallBack(num);
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x0005ECBC File Offset: 0x0005CEBC
		public void UnityServerInitialise()
		{
			this._serverRunning = true;
			if (!true)
			{
			}
			DateTime now = DateTime.Now;
			this._lastUpdate = now;
			this._firstUpdate = now;
			if (!true)
			{
			}
			TimeSpan timeSpan;
			this._totalTime = timeSpan;
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x0005ECF8 File Offset: 0x0005CEF8
		public void UnityServerShutdown()
		{
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x0005ED08 File Offset: 0x0005CF08
		public void UnityServerUpdate(float elapsedTime)
		{
			bool serverRunning = this._serverRunning;
			if (serverRunning)
			{
				TimeSpan totalTime = this._totalTime;
				if (!serverRunning)
				{
				}
				DateTime now = DateTime.Now;
				DateTime lastUpdate = this._lastUpdate;
				TimeSpan timeSpan = now - lastUpdate;
				TimeSpan timeSpan2 = TimeSpan.FromSeconds((double)elapsedTime);
				bool flag = timeSpan > timeSpan2;
				DateTime now2 = DateTime.Now;
				DateTime dateTime;
				this._lastUpdate = dateTime;
				DateTime now3 = DateTime.Now;
				DateTime lastUpdate2 = this._lastUpdate;
				TimeSpan timeSpan3 = now3 - lastUpdate2;
				WorldGen.ExecuteThreadTime();
				bool serverRunning2 = this._serverRunning;
				if (serverRunning2)
				{
					if (!serverRunning2)
					{
					}
					Netplay.ServerLoopUpdateFrame();
					Netplay.ServerUpdateFrame();
				}
				DateTime lastUpdate3 = this._lastUpdate;
				if (!serverRunning2)
				{
				}
				DateTime dateTime2;
				this._lastUpdate = dateTime2;
				TimeSpan totalTime2 = this._totalTime;
				TimeSpan timeSpan4;
				this._totalTime = timeSpan4;
				return;
			}
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x0005EDD8 File Offset: 0x0005CFD8
		public void UnityUpdate(float elapsedTime)
		{
			bool initialised = this._initialised;
			if (!initialised)
			{
				return;
			}
			if (!initialised)
			{
			}
			Main.UpdateTrialMode();
			int num;
			if (!this._uiHidden)
			{
				num = 1;
				this._uiHidden = num != 0;
			}
			if (num == 0)
			{
			}
			bool flag = TextureAtlasDB.PendingAssetUnload();
			DateTime now = DateTime.Now;
			DateTime lastUpdate = this._lastUpdate;
			TimeSpan timeSpan = now - lastUpdate;
			bool flag2 = this.highFrameRate;
			if (flag2)
			{
				if (!flag2)
				{
				}
				if (!flag2)
				{
				}
				TimeSpan timeSpan2;
				Thread.Sleep(timeSpan2);
				DateTime now2 = DateTime.Now;
				DateTime lastUpdate2 = this._lastUpdate;
				TimeSpan timeSpan3 = now2 - lastUpdate2;
				return;
			}
			DateTime now3 = DateTime.Now;
			int num2 = this.updateCount;
			this.updateCount = num2;
			DateTime dateTime = this.updateTimeStart;
			if (num2 == 0)
			{
			}
			double totalMilliseconds = (now3 - dateTime).TotalMilliseconds;
			int num3 = this.updateCount;
			this.updateTimeStart = now3;
			this.fpsCount = num3;
			int num4 = 1;
			this.highFrameRate = num4 != 0;
			int num5;
			if (!this.updateModeVariable)
			{
				num5 = 1;
				this.updateModeVariable = num5 != 0;
				return;
			}
			if (num5 == 0)
			{
			}
			Main.ProcessAsyncLoad();
			if (num5 == 0)
			{
			}
			TextureAtlasDB.ActionPendingUnloadAssets(false);
			this.UnityUpdate((float)totalMilliseconds);
			if (num5 == 0)
			{
			}
			TimeSpan totalTime = this._totalTime;
			DateTime lastUpdate3 = this._lastUpdate;
			if (num5 == 0)
			{
			}
			TimeSpan timeSpan4 = now3 - lastUpdate3;
			TimeSpan timeSpan5 = TimeSpan.FromSeconds(totalMilliseconds);
			bool flag3 = timeSpan4 > timeSpan5;
			DateTime dateTime2;
			this._lastUpdate = dateTime2;
			TimeSpan timeSpan6 = now3 - dateTime2;
			DateTime lastUpdate4 = this._lastUpdate;
			TimeSpan timeSpan7 = now3 - lastUpdate4;
			Netplay.UpdateClientNet();
			bool serverRunning = this._serverRunning;
			if (serverRunning)
			{
				if (!serverRunning)
				{
				}
				Netplay.ServerLoopUpdateFrame();
				Netplay.ServerUpdateFrame();
			}
			DateTime lastUpdate5 = this._lastUpdate;
			if (!serverRunning)
			{
			}
			DateTime dateTime3;
			this._lastUpdate = dateTime3;
			TimeSpan totalTime2 = this._totalTime;
			TimeSpan timeSpan8;
			this._totalTime = timeSpan8;
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x0005EFDC File Offset: 0x0005D1DC
		public void UnityDraw()
		{
			int num = 1;
			if (num == 0)
			{
			}
			GeometryBufferInstance.ClearInstances();
			if (num == 0)
			{
			}
			MaterialBuffer.ClearInstances();
			if (num == 0)
			{
			}
			ScreenPostProcessor.BeginUpdate();
			Main.FlushBatches();
			GeometryBufferInstance.FinaliseInstances();
			ScreenPostProcessor.EndUpdate();
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x0005F028 File Offset: 0x0005D228
		protected virtual void Draw(GameTime gameTime)
		{
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0005F038 File Offset: 0x0005D238
		protected virtual void Initialize()
		{
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x0005F048 File Offset: 0x0005D248
		protected virtual void LoadContent()
		{
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x0005F058 File Offset: 0x0005D258
		protected virtual void UnloadContent()
		{
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x0005F068 File Offset: 0x0005D268
		protected virtual void Exit()
		{
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x000021DB File Offset: 0x000003DB
		public GameWindow Window
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x0005F078 File Offset: 0x0005D278
		public GameServiceContainer Services
		{
			get
			{
				if (this.content.serviceProvider != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x000021DB File Offset: 0x000003DB
		internal void Run()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0005F098 File Offset: 0x0005D298
		public void Dispose()
		{
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x0005F0A8 File Offset: 0x0005D2A8
		internal void Begin()
		{
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x0005F0B8 File Offset: 0x0005D2B8
		internal void Tick(float deltaTime)
		{
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x0005F0C8 File Offset: 0x0005D2C8
		// Note: this type is marked as 'beforefieldinit'.
		static Game()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04002290 RID: 8848
		private GameComponentCollection _components;

		// Token: 0x04002291 RID: 8849
		private ContentManager content;

		// Token: 0x04002292 RID: 8850
		private GraphicsDevice graphicsDevice;

		// Token: 0x04002293 RID: 8851
		private long totalTicks;

		// Token: 0x04002294 RID: 8852
		private bool _active = true;

		// Token: 0x04002295 RID: 8853
		public bool IsMouseVisible;

		// Token: 0x04002296 RID: 8854
		public bool IsFixedTimeStep;

		// Token: 0x04002297 RID: 8855
		private DateTime _lastUpdate;

		// Token: 0x04002298 RID: 8856
		private DateTime _firstUpdate;

		// Token: 0x04002299 RID: 8857
		private TimeSpan _totalTime;

		// Token: 0x0400229A RID: 8858
		private bool _initialised;

		// Token: 0x0400229B RID: 8859
		private bool _uiHidden;

		// Token: 0x0400229C RID: 8860
		private bool _serverRunning;

		// Token: 0x0400229D RID: 8861
		private static TimeSpan FrameTickTime;

		// Token: 0x0400229E RID: 8862
		private static TimeSpan FrameClampTickTime;

		// Token: 0x0400229F RID: 8863
		private static TimeSpan FrameIgnoreTime;

		// Token: 0x040022A0 RID: 8864
		private static GameTime RunGameTime;

		// Token: 0x040022A1 RID: 8865
		private static DateTime lastFrameUpdate;

		// Token: 0x040022A2 RID: 8866
		private static DateTime[] lastFrameTime;

		// Token: 0x040022A3 RID: 8867
		private static DateTime[] frameTime;

		// Token: 0x040022A4 RID: 8868
		private static int frameTimeCounter;

		// Token: 0x040022A5 RID: 8869
		private bool updateModeVariable = true;

		// Token: 0x040022A6 RID: 8870
		private int updateCount;

		// Token: 0x040022A7 RID: 8871
		private DateTime updateTimeStart;

		// Token: 0x040022A8 RID: 8872
		private DateTime lastUpdateTime;

		// Token: 0x040022A9 RID: 8873
		private int fpsCount;

		// Token: 0x040022AA RID: 8874
		private int slowFrameCount;

		// Token: 0x040022AB RID: 8875
		private int oddFrameCount;

		// Token: 0x040022AC RID: 8876
		private bool highFrameRate;
	}
}
