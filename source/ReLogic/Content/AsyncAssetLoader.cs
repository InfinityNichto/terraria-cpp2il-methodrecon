using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ReLogic.Content
{
	// Token: 0x02000B47 RID: 2887
	public class AsyncAssetLoader
	{
		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06005401 RID: 21505 RVA: 0x00285584 File Offset: 0x00283784
		// (set) Token: 0x06005402 RID: 21506 RVA: 0x00285598 File Offset: 0x00283798
		public int Remaining
		{
			[CompilerGenerated]
			get
			{
				return this.<Remaining>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Remaining>k__BackingField = value;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06005403 RID: 21507 RVA: 0x002855AC File Offset: 0x002837AC
		internal int AssetsReadyForTransfer
		{
			get
			{
				/*
An exception occurred when decompiling this method (06005403)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ReLogic.Content.AsyncAssetLoader::get_AssetsReadyForTransfer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Concurrent.ConcurrentQueue`1<class [mscorlib]System.Action>(var_0_06, ldfld:class [mscorlib]System.Collections.Concurrent.ConcurrentQueue`1<class [mscorlib]System.Action>(AsyncAssetLoader::_pendingCallbacks, ldloc:AsyncAssetLoader(this)))
	stloc:class [mscorlib]System.Collections.Concurrent.ConcurrentQueue`1<class [mscorlib]System.Action>(var_1_0D, ldfld:class [mscorlib]System.Collections.Concurrent.ConcurrentQueue`1<class [mscorlib]System.Action>(AsyncAssetLoader::_pendingDelayedCallbacks, ldloc:AsyncAssetLoader(this)))
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

		// Token: 0x06005404 RID: 21508 RVA: 0x002855C8 File Offset: 0x002837C8
		public AsyncAssetLoader(AssetReaderCollection readers)
		{
			this._readers = readers;
			this._maxCreationsPerTransfer = 1;
		}

		// Token: 0x06005405 RID: 21509 RVA: 0x002855EC File Offset: 0x002837EC
		public AsyncAssetLoader(AssetReaderCollection readers, int maxCreationsPerTransfer)
		{
			this._readers = readers;
			this._maxCreationsPerTransfer = maxCreationsPerTransfer;
		}

		// Token: 0x06005406 RID: 21510 RVA: 0x00285610 File Offset: 0x00283810
		public void TransferCompleted()
		{
			ConcurrentQueue<Action> pendingCallbacks = this._pendingCallbacks;
			int num = this.<Remaining>k__BackingField;
			this.<Remaining>k__BackingField = num;
		}

		// Token: 0x04008D0E RID: 36110
		[CompilerGenerated]
		private int <Remaining>k__BackingField;

		// Token: 0x04008D0F RID: 36111
		private readonly AssetReaderCollection _readers;

		// Token: 0x04008D10 RID: 36112
		private readonly ConcurrentQueue<Action> _pendingCallbacks;

		// Token: 0x04008D11 RID: 36113
		private readonly ConcurrentQueue<Action> _pendingDelayedCallbacks;

		// Token: 0x04008D12 RID: 36114
		private readonly HashSet<Type> _delayedLoadTypes;

		// Token: 0x04008D13 RID: 36115
		private readonly int _maxCreationsPerTransfer;
	}
}
