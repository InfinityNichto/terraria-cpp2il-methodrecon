using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System
{
	// Token: 0x02000141 RID: 321
	internal sealed class LocalDataStore
	{
		// Token: 0x06000CB4 RID: 3252 RVA: 0x0001B9B0 File Offset: 0x00019BB0
		public LocalDataStore(LocalDataStoreMgr mgr, int InitialCapacity)
		{
			this.m_Manager = mgr;
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x0001B9CC File Offset: 0x00019BCC
		internal void Dispose()
		{
			this.m_Manager.DeleteLocalDataStore(this);
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x0001B9E8 File Offset: 0x00019BE8
		public object GetData(LocalDataStoreSlot slot)
		{
			/*
An exception occurred when decompiling this method (06000CB6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.LocalDataStore::GetData(System.LocalDataStoreSlot)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(LocalDataStoreMgr::ValidateSlot, ldfld:LocalDataStoreMgr(LocalDataStore::m_Manager, ldloc:LocalDataStore(this)), ldloc:LocalDataStoreSlot(slot))
	stloc:int64(var_0_17, ldfld:int64(LocalDataStoreElement::m_cookie, ldfld:class System.LocalDataStoreElement[][exp:LocalDataStoreElement](LocalDataStore::m_DataTable, ldloc:LocalDataStore(this))))
	stloc:int64(var_1_1E, ldfld:int64(LocalDataStoreSlot::m_cookie, ldloc:LocalDataStoreSlot(slot)))
	stloc:string(var_3_2B, call:string(Environment::GetResourceString, ldstr:string("LocalDataStoreSlot storage has been freed.")))
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

		// Token: 0x06000CB7 RID: 3255 RVA: 0x0001BA20 File Offset: 0x00019C20
		public void SetData(LocalDataStoreSlot slot, object data)
		{
			LocalDataStoreMgr manager = this.m_Manager;
			manager.ValidateSlot(slot);
			if (manager == null)
			{
			}
			LocalDataStoreElement localDataStoreElement;
			long cookie = localDataStoreElement.m_cookie;
			long cookie2 = slot.m_cookie;
			localDataStoreElement.m_value = data;
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x0001BA60 File Offset: 0x00019C60
		internal void FreeData(int slot, long cookie)
		{
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0001BA70 File Offset: 0x00019C70
		private LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot)
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			LocalDataStoreMgr manager = this.m_Manager;
			long cookie = this.m_DataTable.m_cookie;
			bool[] slotInfoTable = this.m_Manager.m_SlotInfoTable;
			long cookie2 = this.m_DataTable.m_cookie;
			if (slotInfoTable == null)
			{
				long cookie3 = slot.m_cookie;
				LocalDataStoreElement[] dataTable = this.m_DataTable;
			}
			long num = 0L;
			Monitor.Exit(this.m_Manager);
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x040004EA RID: 1258
		private LocalDataStoreElement[] m_DataTable;

		// Token: 0x040004EB RID: 1259
		private LocalDataStoreMgr m_Manager;
	}
}
