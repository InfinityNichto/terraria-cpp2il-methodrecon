using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000B42 RID: 2882
	public class AssetRepository : IAssetRepository, IDisposable
	{
		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x060053E6 RID: 21478 RVA: 0x00285180 File Offset: 0x00283380
		public int PendingAssets
		{
			get
			{
				return this._queuedAssets._size;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x060053E7 RID: 21479 RVA: 0x00285198 File Offset: 0x00283398
		// (set) Token: 0x060053E8 RID: 21480 RVA: 0x002851AC File Offset: 0x002833AC
		public int TotalAssets
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalAssets>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<TotalAssets>k__BackingField = value;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x060053E9 RID: 21481 RVA: 0x002851C0 File Offset: 0x002833C0
		// (set) Token: 0x060053EA RID: 21482 RVA: 0x002851D4 File Offset: 0x002833D4
		public int LoadedAssets
		{
			[CompilerGenerated]
			get
			{
				return this.<LoadedAssets>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<LoadedAssets>k__BackingField = value;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x060053EB RID: 21483 RVA: 0x002851E8 File Offset: 0x002833E8
		public bool IsAsyncLoadingEnabled
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060053EC RID: 21484 RVA: 0x002851F8 File Offset: 0x002833F8
		public AssetRepository(IAssetLoader syncLoader, AsyncAssetLoader asyncLoader)
		{
			this._asyncLoader = asyncLoader;
			this._loader = syncLoader;
		}

		// Token: 0x060053ED RID: 21485 RVA: 0x0028521C File Offset: 0x0028341C
		internal AssetRepository(IAssetLoader syncLoader, AsyncAssetLoader asyncLoader, bool useAsync)
		{
			this._asyncLoader = asyncLoader;
			this._loader = syncLoader;
		}

		// Token: 0x060053EE RID: 21486 RVA: 0x00285240 File Offset: 0x00283440
		public void ProcessAsyncLoad()
		{
			if (!true)
			{
			}
			DateTime now = DateTime.Now;
			if (this._queuedAssets._size == 0)
			{
			}
			TimeSpan timeSpan = DateTime.Now - now;
			TimeSpan timeSpan2;
			bool flag = timeSpan < timeSpan2;
			List<IAsset> queuedAssets = this._queuedAssets;
			List<IAsset> queuedAssets2 = this._queuedAssets;
		}

		// Token: 0x060053EF RID: 21487 RVA: 0x002852B4 File Offset: 0x002834B4
		public void SetSources(IEnumerable<IContentSource> sources, AssetRequestMode mode = AssetRequestMode.ImmediateLoad)
		{
			this.ThrowIfDisposed();
			object requestLock = this._requestLock;
			AsyncAssetLoader asyncLoader = this._asyncLoader;
			int <Remaining>k__BackingField = asyncLoader.<Remaining>k__BackingField;
			asyncLoader.TransferCompleted();
		}

		// Token: 0x060053F0 RID: 21488 RVA: 0x00285328 File Offset: 0x00283528
		public Asset<T> Request<T>(string assetName, AssetRequestMode mode = AssetRequestMode.ImmediateLoad) where T : class
		{
			this.ThrowIfDisposed();
			long num = 0L;
			string text = AssetPathHelper.CleanPath(assetName);
			object requestLock = this._requestLock;
			Monitor.Enter(requestLock, num != 0L);
			Dictionary<string, IAsset> assets = this._assets;
			Dictionary<string, IAsset> assets2 = this._assets;
			long num2 = 0L;
			Monitor.Exit(requestLock);
			if (num2 == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x0028538C File Offset: 0x0028358C
		public void TransferCompletedAssets()
		{
			this.ThrowIfDisposed();
			object requestLock = this._requestLock;
			this._asyncLoader.TransferCompleted();
			long num = 0L;
			Monitor.Exit(requestLock);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060053F2 RID: 21490 RVA: 0x002853E0 File Offset: 0x002835E0
		private void ReloadAssetsIfSourceChanged(AssetRequestMode mode)
		{
			Dictionary<string, IAsset> assets = this._assets;
		}

		// Token: 0x060053F3 RID: 21491 RVA: 0x00285430 File Offset: 0x00283630
		private void LoadAsset<T>(Asset<T> asset, AssetRequestMode mode) where T : class
		{
			if (mode != AssetRequestMode.DoNotLoad)
			{
				int num = this.<TotalAssets>k__BackingField;
				this.<TotalAssets>k__BackingField = num;
				return;
			}
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x000021DB File Offset: 0x000003DB
		private void TryLoadingAsset<T>(Asset<T> asset, AssetRequestMode mode) where T : class
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060053F5 RID: 21493 RVA: 0x00285450 File Offset: 0x00283650
		private void ForceReloadAsset(IAsset asset, AssetRequestMode mode)
		{
			if (mode != AssetRequestMode.DoNotLoad)
			{
				int num = this.<LoadedAssets>k__BackingField;
				this.<LoadedAssets>k__BackingField = num;
			}
			Dictionary<Type, Action<IAsset, AssetRequestMode>> typeSpecificReloadActions = this._typeSpecificReloadActions;
			Dictionary.ValueCollection values = typeSpecificReloadActions._values;
			Dictionary.Entry[] entries = typeSpecificReloadActions._entries;
			int freeCount = typeSpecificReloadActions._freeCount;
		}

		// Token: 0x060053F6 RID: 21494 RVA: 0x0028548C File Offset: 0x0028368C
		private void EnsureReloadActionExistsForType<T>() where T : class
		{
			Dictionary<Type, Action<IAsset, AssetRequestMode>> typeSpecificReloadActions = this._typeSpecificReloadActions;
		}

		// Token: 0x060053F7 RID: 21495 RVA: 0x002854A0 File Offset: 0x002836A0
		private void ForceReloadAsset<T>(IAsset asset, AssetRequestMode mode) where T : class
		{
			if (asset != null)
			{
			}
		}

		// Token: 0x060053F8 RID: 21496 RVA: 0x002854B8 File Offset: 0x002836B8
		private IContentSource FindSourceForAsset(string assetName)
		{
			/*
An exception occurred when decompiling this method (060053F8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ReLogic.Content.Sources.IContentSource ReLogic.Content.AssetRepository::FindSourceForAsset(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<class ReLogic.Content.Sources.IContentSource>[exp:bool](AssetRepository::_sources, ldloc:AssetRepository(this))))
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

		// Token: 0x060053F9 RID: 21497 RVA: 0x002854CC File Offset: 0x002836CC
		private void ThrowIfDisposed()
		{
			while (this._isDisposed)
			{
			}
		}

		// Token: 0x060053FA RID: 21498 RVA: 0x002854E4 File Offset: 0x002836E4
		protected virtual void Dispose(bool disposing)
		{
			if (!this._isDisposed)
			{
				Dictionary<string, IAsset> assets = this._assets;
				return;
			}
		}

		// Token: 0x060053FB RID: 21499 RVA: 0x00285528 File Offset: 0x00283728
		public void Dispose()
		{
		}

		// Token: 0x04008CF9 RID: 36089
		[CompilerGenerated]
		private int <TotalAssets>k__BackingField;

		// Token: 0x04008CFA RID: 36090
		[CompilerGenerated]
		private int <LoadedAssets>k__BackingField;

		// Token: 0x04008CFB RID: 36091
		private readonly Dictionary<string, IAsset> _assets;

		// Token: 0x04008CFC RID: 36092
		private IEnumerable<IContentSource> _sources;

		// Token: 0x04008CFD RID: 36093
		private readonly Dictionary<Type, Action<IAsset, AssetRequestMode>> _typeSpecificReloadActions;

		// Token: 0x04008CFE RID: 36094
		private readonly AsyncAssetLoader _asyncLoader;

		// Token: 0x04008CFF RID: 36095
		private readonly IAssetLoader _loader;

		// Token: 0x04008D00 RID: 36096
		private List<IAsset> _queuedAssets;

		// Token: 0x04008D01 RID: 36097
		private readonly object _requestLock;

		// Token: 0x04008D02 RID: 36098
		private bool _isDisposed;

		// Token: 0x02000B43 RID: 2883
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060053FC RID: 21500 RVA: 0x00285538 File Offset: 0x00283738
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060053FD RID: 21501 RVA: 0x00285548 File Offset: 0x00283748
			public <>c()
			{
			}

			// Token: 0x060053FE RID: 21502 RVA: 0x000021DB File Offset: 0x000003DB
			internal bool <ReloadAssetsIfSourceChanged>b__25_0(IAsset asset)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04008D03 RID: 36099
			public static readonly AssetRepository.<>c <>9;

			// Token: 0x04008D04 RID: 36100
			public static Func<IAsset, bool> <>9__25_0;
		}

		// Token: 0x02000B44 RID: 2884
		[CompilerGenerated]
		private sealed class <>c__DisplayClass31_0
		{
			// Token: 0x060053FF RID: 21503 RVA: 0x0028555C File Offset: 0x0028375C
			public <>c__DisplayClass31_0()
			{
			}

			// Token: 0x06005400 RID: 21504 RVA: 0x00285570 File Offset: 0x00283770
			internal bool <FindSourceForAsset>b__0(IContentSource source)
			{
				/*
An exception occurred when decompiling this method (06005400)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ReLogic.Content.AssetRepository/<>c__DisplayClass31_0::<FindSourceForAsset>b__0(ReLogic.Content.Sources.IContentSource)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string('<>c__DisplayClass31_0'::assetName, ldloc:'<>c__DisplayClass31_0'(this)))
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

			// Token: 0x04008D05 RID: 36101
			public string assetName;
		}
	}
}
