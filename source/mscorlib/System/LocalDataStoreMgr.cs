using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000143 RID: 323
	internal sealed class LocalDataStoreMgr
	{
		// Token: 0x06000CBF RID: 3263 RVA: 0x0000207A File Offset: 0x0000027A
		public LocalDataStoreHolder CreateLocalDataStore()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x0001BBCC File Offset: 0x00019DCC
		public void DeleteLocalDataStore(LocalDataStore store)
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			List<LocalDataStore> managedLocalDataStores = this.m_ManagedLocalDataStores;
			long num = 0L;
			Monitor.Exit(this);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0001BC18 File Offset: 0x00019E18
		public LocalDataStoreSlot AllocateDataSlot()
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			bool[] slotInfoTable = this.m_SlotInfoTable;
			int firstAvailableSlot = this.m_FirstAvailableSlot;
			bool[] slotInfoTable2 = this.m_SlotInfoTable;
			int num = 1;
			long cookieGenerator = this.m_CookieGenerator;
			this.m_CookieGenerator = (long)num;
			long num2 = 0L;
			Monitor.Exit(this);
			if (num2 == 0L)
			{
				throw new OverflowException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x0001BC88 File Offset: 0x00019E88
		public LocalDataStoreSlot AllocateNamedDataSlot(string name)
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			LocalDataStoreSlot localDataStoreSlot = this.AllocateDataSlot();
			Dictionary<string, LocalDataStoreSlot> keyToSlotMap = this.m_KeyToSlotMap;
			long num = 0L;
			Monitor.Exit(this);
			if (num == 0L)
			{
				return localDataStoreSlot;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0001BCD8 File Offset: 0x00019ED8
		public LocalDataStoreSlot GetNamedDataSlot(string name)
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			Dictionary<string, LocalDataStoreSlot> keyToSlotMap = this.m_KeyToSlotMap;
			string text;
			LocalDataStoreSlot localDataStoreSlot;
			if (text == null)
			{
				localDataStoreSlot = this.AllocateNamedDataSlot(name);
			}
			long num = 0L;
			Monitor.Exit(this);
			if (num == 0L)
			{
				return localDataStoreSlot;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x0001BD28 File Offset: 0x00019F28
		public void FreeNamedDataSlot(string name)
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			Dictionary<string, LocalDataStoreSlot> keyToSlotMap = this.m_KeyToSlotMap;
			long num = 0L;
			Monitor.Exit(this);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x0000207A File Offset: 0x0000027A
		internal void FreeDataSlot(int slot, long cookie)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x0001BD74 File Offset: 0x00019F74
		public void ValidateSlot(LocalDataStoreSlot slot)
		{
			/*
An exception occurred when decompiling this method (06000CC6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.LocalDataStoreMgr::ValidateSlot(System.LocalDataStoreSlot)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stloc:string(var_1_15, call:string(Environment::GetResourceString, ldstr:string("Specified slot number was invalid.")))
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

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0001BD98 File Offset: 0x00019F98
		internal int GetSlotTableLength()
		{
			/*
An exception occurred when decompiling this method (06000CC7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.LocalDataStoreMgr::GetSlotTableLength()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool[](var_0_06, ldfld:bool[](LocalDataStoreMgr::m_SlotInfoTable, ldloc:LocalDataStoreMgr(this)))
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

		// Token: 0x06000CC8 RID: 3272 RVA: 0x0001BDAC File Offset: 0x00019FAC
		public LocalDataStoreMgr()
		{
		}

		// Token: 0x040004EF RID: 1263
		private const int InitialSlotTableSize = 64;

		// Token: 0x040004F0 RID: 1264
		private const int SlotTableDoubleThreshold = 512;

		// Token: 0x040004F1 RID: 1265
		private const int LargeSlotTableSizeIncrease = 128;

		// Token: 0x040004F2 RID: 1266
		private bool[] m_SlotInfoTable;

		// Token: 0x040004F3 RID: 1267
		private int m_FirstAvailableSlot;

		// Token: 0x040004F4 RID: 1268
		private List<LocalDataStore> m_ManagedLocalDataStores;

		// Token: 0x040004F5 RID: 1269
		private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap;

		// Token: 0x040004F6 RID: 1270
		private long m_CookieGenerator;
	}
}
