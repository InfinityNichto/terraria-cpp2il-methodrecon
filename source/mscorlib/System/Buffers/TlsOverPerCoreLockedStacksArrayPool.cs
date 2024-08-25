using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Internal.Runtime.Augments;

namespace System.Buffers
{
	// Token: 0x02000666 RID: 1638
	internal sealed class TlsOverPerCoreLockedStacksArrayPool<T> : ArrayPool<T>
	{
		// Token: 0x060031CF RID: 12751 RVA: 0x0006BB58 File Offset: 0x00069D58
		public TlsOverPerCoreLockedStacksArrayPool()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x0006BB74 File Offset: 0x00069D74
		private TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks CreatePerCoreLockedStacks(int bucketIndex)
		{
			/*
An exception occurred when decompiling this method (060031D0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1/PerCoreLockedStacks<T> System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1::CreatePerCoreLockedStacks(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(TlsOverPerCoreLockedStacksArrayPool`1::_callbackCreated, ldloc:TlsOverPerCoreLockedStacksArrayPool`1(this)))
	stloc:class System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1/PerCoreLockedStacks[](var_1_0D, ldfld:class System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1/PerCoreLockedStacks<!T>[][exp:class System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1/PerCoreLockedStacks[]](TlsOverPerCoreLockedStacksArrayPool`1::_buckets, ldloc:TlsOverPerCoreLockedStacksArrayPool`1(this)))
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

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060031D1 RID: 12753 RVA: 0x0000207A File Offset: 0x0000027A
		private int Id
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x0006BB90 File Offset: 0x00069D90
		public override T[] Rent(int minimumLength)
		{
			/*
An exception occurred when decompiling this method (060031D2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T[] System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1::Rent(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0023:
	stloc:class System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1/PerCoreLockedStacks[](var_5_29, ldfld:class System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1/PerCoreLockedStacks<!T>[][exp:class System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1/PerCoreLockedStacks[]](TlsOverPerCoreLockedStacksArrayPool`1::_buckets, ldloc:TlsOverPerCoreLockedStacksArrayPool`1(this)))
	stloc:int32[](var_7_31, ldfld:int32[](TlsOverPerCoreLockedStacksArrayPool`1::_bucketArraySizes, ldloc:TlsOverPerCoreLockedStacksArrayPool`1(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x060031D3 RID: 12755 RVA: 0x0006BBD0 File Offset: 0x00069DD0
		public override void Return(T[] array, bool clearArray = false)
		{
			if (array == null)
			{
				return;
			}
			TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks[] buckets = this._buckets;
			long num = 0L;
			Array.Clear(array, (int)num, clearArray ? 1 : 0);
			if (this._bucketArraySizes == null)
			{
			}
			if (array == null)
			{
				throw new ArrayTypeMismatchException();
			}
			if (clearArray)
			{
				TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks[] buckets2 = this._buckets;
				if (array == null)
				{
				}
				return;
			}
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x0006BC28 File Offset: 0x00069E28
		public bool Trim()
		{
			int tickCount = Environment.TickCount;
			TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks[] buckets = this._buckets;
			long num = 0L;
			int[] bucketArraySizes = this._bucketArraySizes;
			int value = tickCount.m_value;
			int value2 = tickCount.m_value;
			int value3 = tickCount.m_value;
			if (num != 0L)
			{
			}
			long num2 = 0L;
			int num3 = 7;
			int value4;
			if (tickCount != 0)
			{
				value4 = tickCount.m_value;
			}
			if (num2 == 0L)
			{
				if (num3 == 0)
				{
					if (value4 == 0)
					{
					}
					long value5 = num2.m_value;
					long value6 = num2.m_value;
					long value7 = num2.m_value;
					long num4 = 0L;
					if (num2 != 0L)
					{
						long value8 = num2.m_value;
					}
					if (num4 == 0L)
					{
					}
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x0006BD18 File Offset: 0x00069F18
		private static bool Gen2GcCallbackFunc(object target)
		{
			throw new InvalidCastException();
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x0006BD2C File Offset: 0x00069F2C
		private static TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure GetMemoryPressure()
		{
			if (!true)
			{
			}
			return (TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure)(-2147483648);
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x0006BD44 File Offset: 0x00069F44
		private static bool GetTrimBuffers()
		{
			return true;
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x0006BD54 File Offset: 0x00069F54
		// Note: this type is marked as 'beforefieldinit'.
		static TlsOverPerCoreLockedStacksArrayPool()
		{
		}

		// Token: 0x04001AB2 RID: 6834
		private readonly int[] _bucketArraySizes;

		// Token: 0x04001AB3 RID: 6835
		private readonly TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks[] _buckets;

		// Token: 0x04001AB4 RID: 6836
		[ThreadStatic]
		private static T[][] t_tlsBuckets;

		// Token: 0x04001AB5 RID: 6837
		private int _callbackCreated;

		// Token: 0x04001AB6 RID: 6838
		private static readonly bool s_trimBuffers;

		// Token: 0x04001AB7 RID: 6839
		private static readonly ConditionalWeakTable<T[][], object> s_allTlsBuckets;

		// Token: 0x02000667 RID: 1639
		private enum MemoryPressure
		{
			// Token: 0x04001AB9 RID: 6841
			Low,
			// Token: 0x04001ABA RID: 6842
			Medium,
			// Token: 0x04001ABB RID: 6843
			High
		}

		// Token: 0x02000668 RID: 1640
		private sealed class PerCoreLockedStacks
		{
			// Token: 0x060031D9 RID: 12761 RVA: 0x0006BD68 File Offset: 0x00069F68
			public PerCoreLockedStacks()
			{
				int processorCount = Environment.ProcessorCount;
				int num = 64;
				int num2 = Math.Min(processorCount, num);
			}

			// Token: 0x060031DA RID: 12762 RVA: 0x0006BD98 File Offset: 0x00069F98
			public void TryPush(T[] array)
			{
				int num = 1;
				TlsOverPerCoreLockedStacksArrayPool.LockedStack[] perCoreStacks = this._perCoreStacks;
				if (num == 0)
				{
				}
				int currentProcessorId = RuntimeThread.GetCurrentProcessorId();
			}

			// Token: 0x060031DB RID: 12763 RVA: 0x0006BDBC File Offset: 0x00069FBC
			public T[] TryPop()
			{
				for (;;)
				{
					int num = 1;
					TlsOverPerCoreLockedStacksArrayPool.LockedStack[] perCoreStacks = this._perCoreStacks;
					if (num == 0)
					{
					}
					if (RuntimeThread.GetCurrentProcessorId() == 0)
					{
						return;
					}
				}
			}

			// Token: 0x060031DC RID: 12764 RVA: 0x0006BDE8 File Offset: 0x00069FE8
			public bool Trim(uint tickCount, int id, TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure pressure, int[] bucketSizes)
			{
				/*
An exception occurred when decompiling this method (060031DC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1/PerCoreLockedStacks::Trim(System.UInt32,System.Int32,System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1/MemoryPressure<T>,System.Int32[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1/LockedStack[](var_0_06, ldfld:class System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1/LockedStack<!T>[][exp:class System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1/LockedStack[]](PerCoreLockedStacks::_perCoreStacks, ldloc:PerCoreLockedStacks(this)))
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

			// Token: 0x04001ABC RID: 6844
			private readonly TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack[] _perCoreStacks;
		}

		// Token: 0x02000669 RID: 1641
		private sealed class LockedStack
		{
			// Token: 0x060031DD RID: 12765 RVA: 0x0000207A File Offset: 0x0000027A
			public bool TryPush(T[] array)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060031DE RID: 12766 RVA: 0x0000207A File Offset: 0x0000027A
			public T[] TryPop()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060031DF RID: 12767 RVA: 0x0000207A File Offset: 0x0000027A
			public void Trim(uint tickCount, int id, TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure pressure, int bucketSize)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060031E0 RID: 12768 RVA: 0x0006BE00 File Offset: 0x0006A000
			public LockedStack()
			{
				this._arrays = this;
				base..ctor();
			}

			// Token: 0x04001ABD RID: 6845
			private readonly T[][] _arrays;

			// Token: 0x04001ABE RID: 6846
			private int _count;

			// Token: 0x04001ABF RID: 6847
			private uint _firstStackItemMS;
		}
	}
}
