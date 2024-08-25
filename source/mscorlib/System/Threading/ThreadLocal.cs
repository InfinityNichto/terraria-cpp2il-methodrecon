using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x020001E3 RID: 483
	[DebuggerDisplay("IsValueCreated={IsValueCreated}, Value={ValueForDebugDisplay}, Count={ValuesCountForDebugDisplay}")]
	[DebuggerTypeProxy(typeof(SystemThreading_ThreadLocalDebugView<>))]
	public class ThreadLocal<T> : IDisposable
	{
		// Token: 0x06001165 RID: 4453 RVA: 0x00024ECC File Offset: 0x000230CC
		public ThreadLocal(Func<T> valueFactory)
		{
			do
			{
				base..ctor();
			}
			while (valueFactory == null);
			Func valueFactory2 = this.m_valueFactory;
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x00024EEC File Offset: 0x000230EC
		private void Initialize(Func<T> valueFactory, bool trackAllValues)
		{
			this.m_valueFactory = valueFactory;
			this.m_initialized = true;
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00024F08 File Offset: 0x00023108
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00024F3C File Offset: 0x0002313C
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00024F50 File Offset: 0x00023150
		protected virtual void Dispose(bool disposing)
		{
			int idComplement = this.m_idComplement;
			int idComplement2 = this.m_idComplement;
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x0000207A File Offset: 0x0000027A
		public override string ToString()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x00024FA8 File Offset: 0x000231A8
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x00024FCC File Offset: 0x000231CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public T Value
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600116B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T System.Threading.ThreadLocal`1::get_Value()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_0_06, ldfld:int32(ThreadLocal`1::m_idComplement, ldloc:ThreadLocal`1(this)))
	stloc:int32(var_1_0D, ldfld:int32(ThreadLocal`1::m_idComplement, ldloc:ThreadLocal`1(this)))
	brtrue(IL_0000, logicnot:bool(ldfld:bool(ThreadLocal`1::m_initialized, ldloc:ThreadLocal`1(this))))
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
			set
			{
				int idComplement = this.m_idComplement;
				int idComplement2 = this.m_idComplement;
				if (this.m_initialized)
				{
					return;
				}
			}
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x00024FF0 File Offset: 0x000231F0
		private T GetValueSlow()
		{
			/*
An exception occurred when decompiling this method (0600116D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T System.Threading.ThreadLocal`1::GetValueSlow()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0021:
	stloc:string(var_4_2D, call:string(Environment::GetResourceString, ldstr:string("The ThreadLocal object has been disposed.")))
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

		// Token: 0x0600116E RID: 4462 RVA: 0x0002502C File Offset: 0x0002322C
		private void SetValueSlow(T value, ThreadLocal<T>.LinkedSlotVolatile[] slotArray)
		{
			/*
An exception occurred when decompiling this method (0600116E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Threading.ThreadLocal`1::SetValueSlow(T,System.Threading.ThreadLocal`1/LinkedSlotVolatile<T>[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0066:
	stloc:string(var_7_70, call:string(Environment::GetResourceString, ldstr:string("The ThreadLocal object has been disposed.")))
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

		// Token: 0x0600116F RID: 4463 RVA: 0x000250AC File Offset: 0x000232AC
		private void CreateLinkedSlot(ThreadLocal<T>.LinkedSlotVolatile[] slotArray, int id, T value)
		{
			int idComplement = this.m_idComplement;
			if (this == null)
			{
			}
			int idComplement2 = this.m_idComplement;
			if (!this.m_initialized)
			{
				string resourceString = Environment.GetResourceString("The ThreadLocal object has been disposed.");
				return;
			}
			Func valueFactory = this.m_valueFactory;
			this.m_valueFactory = valueFactory;
			if (valueFactory != null)
			{
			}
			this.m_valueFactory = this;
			long num = 0L;
			if (this != null)
			{
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x00025124 File Offset: 0x00023324
		public bool IsValueCreated
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001170)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.ThreadLocal`1::get_IsValueCreated()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ThreadLocal`1::m_idComplement, ldloc:ThreadLocal`1(this)))
	stloc:string(var_2_13, call:string(Environment::GetResourceString, ldstr:string("The ThreadLocal object has been disposed.")))
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

		// Token: 0x06001171 RID: 4465 RVA: 0x00025144 File Offset: 0x00023344
		private void GrowTable(ThreadLocal<T>.LinkedSlotVolatile[] table, int minLength)
		{
			long num = 0L;
			int num2 = 5;
			if (num == 0L)
			{
				if (num2 == 0)
				{
					table.Value = minLength;
				}
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x0000207A File Offset: 0x0000027A
		private static int GetNewTableSize(int minSize)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x0002517C File Offset: 0x0002337C
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadLocal()
		{
		}

		// Token: 0x04000965 RID: 2405
		private Func<T> m_valueFactory;

		// Token: 0x04000966 RID: 2406
		[ThreadStatic]
		private static ThreadLocal<T>.LinkedSlotVolatile[] ts_slotArray;

		// Token: 0x04000967 RID: 2407
		[ThreadStatic]
		private static ThreadLocal<T>.FinalizationHelper ts_finalizationHelper;

		// Token: 0x04000968 RID: 2408
		private int m_idComplement;

		// Token: 0x04000969 RID: 2409
		private bool m_initialized;

		// Token: 0x0400096A RID: 2410
		private static ThreadLocal<T>.IdManager s_idManager;

		// Token: 0x0400096B RID: 2411
		private ThreadLocal<T>.LinkedSlot m_linkedSlot;

		// Token: 0x0400096C RID: 2412
		private bool m_trackAllValues;

		// Token: 0x020001E4 RID: 484
		private struct LinkedSlotVolatile
		{
			// Token: 0x0400096D RID: 2413
			internal ThreadLocal<T>.LinkedSlot Value;
		}

		// Token: 0x020001E5 RID: 485
		private sealed class LinkedSlot
		{
			// Token: 0x06001174 RID: 4468 RVA: 0x0002518C File Offset: 0x0002338C
			internal LinkedSlot(ThreadLocal<T>.LinkedSlotVolatile[] slotArray)
			{
				this.SlotArray = slotArray;
			}

			// Token: 0x0400096E RID: 2414
			internal ThreadLocal<T>.LinkedSlot Next;

			// Token: 0x0400096F RID: 2415
			internal ThreadLocal<T>.LinkedSlot Previous;

			// Token: 0x04000970 RID: 2416
			internal ThreadLocal<T>.LinkedSlotVolatile[] SlotArray;

			// Token: 0x04000971 RID: 2417
			internal T Value;
		}

		// Token: 0x020001E6 RID: 486
		private class IdManager
		{
			// Token: 0x06001175 RID: 4469 RVA: 0x000251A8 File Offset: 0x000233A8
			internal int GetId()
			{
				int nextIdToTry = this.m_nextIdToTry;
				return 43147264;
			}

			// Token: 0x06001176 RID: 4470 RVA: 0x000251EC File Offset: 0x000233EC
			internal void ReturnId(int id)
			{
				int nextIdToTry = this.m_nextIdToTry;
				this.m_nextIdToTry = id;
			}

			// Token: 0x06001177 RID: 4471 RVA: 0x00025230 File Offset: 0x00023430
			public IdManager()
			{
			}

			// Token: 0x04000972 RID: 2418
			private int m_nextIdToTry;

			// Token: 0x04000973 RID: 2419
			private List<bool> m_freeIds;
		}

		// Token: 0x020001E7 RID: 487
		private class FinalizationHelper
		{
			// Token: 0x06001178 RID: 4472 RVA: 0x00025244 File Offset: 0x00023444
			internal FinalizationHelper(ThreadLocal<T>.LinkedSlotVolatile[] slotArray, bool trackAllValues)
			{
				this.SlotArray = slotArray;
			}

			// Token: 0x06001179 RID: 4473 RVA: 0x00025260 File Offset: 0x00023460
			protected override void Finalize()
			{
				ThreadLocal.LinkedSlotVolatile[] slotArray = this.SlotArray;
				bool trackAllValues = this.m_trackAllValues;
				if (trackAllValues)
				{
					return;
				}
				if (!trackAllValues)
				{
				}
				long num = 0L;
				if (trackAllValues)
				{
				}
				if (num == 0L)
				{
					return;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x04000974 RID: 2420
			internal ThreadLocal<T>.LinkedSlotVolatile[] SlotArray;

			// Token: 0x04000975 RID: 2421
			private bool m_trackAllValues;
		}
	}
}
