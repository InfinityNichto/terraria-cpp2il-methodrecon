using System;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;

namespace System.Xml.Linq
{
	// Token: 0x0200000D RID: 13
	internal sealed class XHashtable<TValue>
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00003184 File Offset: 0x00001384
		public XHashtable(XHashtable<TValue>.ExtractKeyDelegate extractKey, int capacity)
		{
			this._state = this;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000031A0 File Offset: 0x000013A0
		public bool TryGetValue(string key, int index, int count, [Out] TValue value)
		{
			/*
An exception occurred when decompiling this method (06000074)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.Linq.XHashtable`1::TryGetValue(System.String,System.Int32,System.Int32,TValue)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XHashtableState(var_0_06, ldfld:class System.Xml.Linq.XHashtable`1/XHashtableState<!TValue>[exp:XHashtableState](XHashtable`1::_state, ldloc:XHashtable`1(this)))
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

		// Token: 0x06000075 RID: 117 RVA: 0x000031B4 File Offset: 0x000013B4
		public TValue Add(TValue value)
		{
			XHashtable.XHashtableState state = this._state;
			XHashtable.XHashtableState state2 = this._state;
			long num = 0L;
			Thread.MemoryBarrier();
			this._state = state2;
			Monitor.Exit(num);
			XHashtable.XHashtableState state3 = this._state;
			throw new OutOfMemoryException();
		}

		// Token: 0x0400001C RID: 28
		private XHashtable<TValue>.XHashtableState _state;

		// Token: 0x0200000E RID: 14
		public sealed class ExtractKeyDelegate : MulticastDelegate
		{
			// Token: 0x06000076 RID: 118 RVA: 0x00003208 File Offset: 0x00001408
			public ExtractKeyDelegate(object @object, IntPtr method)
			{
			}

			// Token: 0x06000077 RID: 119 RVA: 0x00002367 File Offset: 0x00000567
			public string Invoke(TValue value)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0200000F RID: 15
		private sealed class XHashtableState
		{
			// Token: 0x06000078 RID: 120 RVA: 0x00003228 File Offset: 0x00001428
			public XHashtableState(XHashtable<TValue>.ExtractKeyDelegate extractKey, int capacity)
			{
				this._entries = 1;
			}

			// Token: 0x06000079 RID: 121 RVA: 0x00003244 File Offset: 0x00001444
			public XHashtable<TValue>.XHashtableState Resize()
			{
				/*
An exception occurred when decompiling this method (06000079)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.Linq.XHashtable`1/XHashtableState<TValue> System.Xml.Linq.XHashtable`1/XHashtableState::Resize()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002B:
	stloc:int32[](var_7_31, ldfld:int32[](XHashtableState::_buckets, ldloc:XHashtableState(this)))
	stloc:int32[](var_9_3C, ldfld:int32[](XHashtableState::_buckets, ldloc:XHashtableState(this)))
	stloc:valuetype System.Xml.Linq.XHashtable`1/XHashtableState/Entry[](var_11_47, ldfld:valuetype System.Xml.Linq.XHashtable`1/XHashtableState/Entry<!TValue>[][exp:valuetype System.Xml.Linq.XHashtable`1/XHashtableState/Entry[]](XHashtableState::_entries, ldloc:XHashtableState(this)))
	stloc:valuetype System.Xml.Linq.XHashtable`1/XHashtableState/Entry[](var_12_4F, ldfld:valuetype System.Xml.Linq.XHashtable`1/XHashtableState/Entry<!TValue>[][exp:valuetype System.Xml.Linq.XHashtable`1/XHashtableState/Entry[]](XHashtableState::_entries, ldloc:XHashtableState(this)))
	stloc:int32[](var_13_57, ldfld:int32[](XHashtableState::_buckets, ldloc:XHashtableState(this)))
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

			// Token: 0x0600007A RID: 122 RVA: 0x000032AC File Offset: 0x000014AC
			public bool TryGetValue(string key, int index, int count, [Out] TValue value)
			{
				/*
An exception occurred when decompiling this method (0600007A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.Linq.XHashtable`1/XHashtableState::TryGetValue(System.String,System.Int32,System.Int32,TValue)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype System.Xml.Linq.XHashtable`1/XHashtableState/Entry[](var_0_06, ldfld:valuetype System.Xml.Linq.XHashtable`1/XHashtableState/Entry<!TValue>[][exp:valuetype System.Xml.Linq.XHashtable`1/XHashtableState/Entry[]](XHashtableState::_entries, ldloc:XHashtableState(this)))
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

			// Token: 0x0600007B RID: 123 RVA: 0x000032C4 File Offset: 0x000014C4
			public bool TryAdd(TValue value, [Out] TValue newValue)
			{
				if (this != null)
				{
					int[] buckets = this._buckets;
					int[] buckets2 = this._buckets;
					XHashtable.XHashtableState.Entry[] entries = this._entries;
					Thread.MemoryBarrier();
					int[] buckets3 = this._buckets;
					if (entries != null)
					{
						XHashtable.XHashtableState.Entry[] entries2 = this._entries;
					}
					int[] buckets4 = this._buckets;
					XHashtable.XHashtableState.Entry[] entries3 = this._entries;
					return;
				}
			}

			// Token: 0x0600007C RID: 124 RVA: 0x0000331C File Offset: 0x0000151C
			private bool FindEntry(int hashCode, string key, int index, int count, int entryIndex)
			{
				int[] buckets = this._buckets;
				XHashtable.XHashtableState.Entry[] entries = this._entries;
				if (this == null)
				{
					XHashtable.XHashtableState.Entry[] entries2 = this._entries;
					XHashtable.XHashtableState.Entry[] entries3 = this._entries;
				}
				int[] buckets2 = this._buckets;
				int num;
				if (num != 0)
				{
					XHashtable.XHashtableState.Entry[] entries4 = this._entries;
					int[] buckets3 = this._buckets;
					return;
				}
			}

			// Token: 0x0600007D RID: 125 RVA: 0x00002367 File Offset: 0x00000567
			private static int ComputeHashCode(string key, int index, int count)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0400001D RID: 29
			private int[] _buckets;

			// Token: 0x0400001E RID: 30
			private XHashtable<TValue>.XHashtableState.Entry[] _entries;

			// Token: 0x0400001F RID: 31
			private int _numEntries;

			// Token: 0x04000020 RID: 32
			private XHashtable<TValue>.ExtractKeyDelegate _extractKey;

			// Token: 0x02000010 RID: 16
			private struct Entry
			{
				// Token: 0x04000021 RID: 33
				public TValue Value;

				// Token: 0x04000022 RID: 34
				public int HashCode;

				// Token: 0x04000023 RID: 35
				public int Next;
			}
		}
	}
}
