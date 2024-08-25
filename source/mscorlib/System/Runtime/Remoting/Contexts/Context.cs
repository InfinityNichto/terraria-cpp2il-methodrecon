using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x02000365 RID: 869
	[ComVisible(true)]
	[StructLayout(0)]
	public class Context
	{
		// Token: 0x06001CDB RID: 7387 RVA: 0x0003EE90 File Offset: 0x0003D090
		private static void RegisterContext(Context ctx)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x0003EEA4 File Offset: 0x0003D0A4
		private static void ReleaseContext(Context ctx)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x0003EEB8 File Offset: 0x0003D0B8
		public Context()
		{
			int num = 1;
			base..ctor();
			int domainID = Thread.GetDomainID();
			this.domain_id = domainID;
			if (num == 0)
			{
			}
			int num2 = Interlocked.Increment(int.MinValue);
			this.context_id = num2;
			throw new NotSupportedException();
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x0003EEF8 File Offset: 0x0003D0F8
		protected override void Finalize()
		{
			if (!true)
			{
			}
			throw new NotSupportedException();
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x0003EF38 File Offset: 0x0003D138
		public static Context DefaultContext
		{
			get
			{
				return AppDomain.InternalGetDefaultContext();
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x0003EF4C File Offset: 0x0003D14C
		public virtual int ContextID
		{
			get
			{
				return this.context_id;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x0003EF60 File Offset: 0x0003D160
		public virtual IContextProperty[] ContextProperties
		{
			get
			{
				if (this.context_properties != null)
				{
					return;
				}
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x0003EF78 File Offset: 0x0003D178
		internal bool IsDefaultContext
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001CE2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Remoting.Contexts.Context::get_IsDefaultContext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Context::context_id, ldloc:Context(this)))
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

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x0003EF8C File Offset: 0x0003D18C
		internal bool NeedsContextSink
		{
			get
			{
				int num = this.context_id;
				if (num != 0)
				{
					return true;
				}
				if (num == 0)
				{
				}
				if (num != 0)
				{
				}
				DynamicPropertyCollection dynamicPropertyCollection = this.context_dynamic_properties;
				if (dynamicPropertyCollection != null)
				{
					ArrayList properties = dynamicPropertyCollection._properties;
					goto IL_0023;
				}
				goto IL_0023;
				IL_0023:;
			}
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x0003EFC0 File Offset: 0x0003D1C0
		public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x0003EFD4 File Offset: 0x0003D1D4
		public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x0003EFE8 File Offset: 0x0003D1E8
		private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx)
		{
			/*
An exception occurred when decompiling this method (06001CE6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Remoting.Contexts.DynamicPropertyCollection System.Runtime.Remoting.Contexts.Context::GetDynamicPropertyCollection(System.ContextBoundObject,System.Runtime.Remoting.Contexts.Context)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001E:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x06001CE7 RID: 7399 RVA: 0x0003F018 File Offset: 0x0003D218
		internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x0003F02C File Offset: 0x0003D22C
		internal static bool HasGlobalDynamicSinks
		{
			get
			{
				if (!true)
				{
				}
				if (true)
				{
					return;
				}
			}
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0003F040 File Offset: 0x0003D240
		internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			DynamicPropertyCollection dynamicPropertyCollection = this.context_dynamic_properties;
			if (dynamicPropertyCollection != null)
			{
				ArrayList properties = dynamicPropertyCollection._properties;
				this.context_dynamic_properties.NotifyMessage(start, req_msg, client_site, async);
				return;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06001CEA RID: 7402 RVA: 0x0003F070 File Offset: 0x0003D270
		internal bool HasDynamicSinks
		{
			get
			{
				DynamicPropertyCollection dynamicPropertyCollection = this.context_dynamic_properties;
				if (dynamicPropertyCollection != null)
				{
					ArrayList properties = dynamicPropertyCollection._properties;
					return;
				}
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x0003F090 File Offset: 0x0003D290
		internal bool HasExitSinks
		{
			get
			{
				IMessageSink messageSink;
				if (messageSink != null)
				{
				}
				return Context.HasGlobalDynamicSinks;
			}
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x0003F0A8 File Offset: 0x0003D2A8
		public virtual IContextProperty GetProperty(string name)
		{
			if (this.context_properties != null)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x0003F0D0 File Offset: 0x0003D2D0
		public virtual void SetProperty(IContextProperty prop)
		{
			if (prop != null)
			{
				Context context = AppDomain.InternalGetDefaultContext();
				if (this.context_properties == null)
				{
				}
				return;
			}
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x0003F0F4 File Offset: 0x0003D2F4
		public virtual void Freeze()
		{
			if (this.context_properties != null)
			{
				return;
			}
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0003F120 File Offset: 0x0003D320
		public override string ToString()
		{
			string text;
			return "ContextID: " + text;
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x0003F138 File Offset: 0x0003D338
		internal IMessageSink GetServerContextSinkChain()
		{
			int num = 1;
			IMessageSink messageSink = this.server_context_sink_chain;
			if (messageSink != null)
			{
				return messageSink;
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			List<IContextProperty> list = this.context_properties;
			while (list == null)
			{
			}
			int size = list._size;
			if (list != null)
			{
				IMessageSink messageSink2 = this.server_context_sink_chain;
				if (size != 0)
				{
				}
				this.server_context_sink_chain = list;
			}
			List<IContextProperty> list2 = this.context_properties;
			return this.server_context_sink_chain;
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x0003F190 File Offset: 0x0003D390
		internal IMessageSink GetClientContextSinkChain()
		{
			IMessageSink messageSink2;
			if (this.client_context_sink_chain == null)
			{
				List<IContextProperty> list = this.context_properties;
				if (list != null)
				{
					while (list == null)
					{
					}
					IMessageSink messageSink = this.client_context_sink_chain;
					this.client_context_sink_chain = list;
					messageSink2 = this.client_context_sink_chain;
				}
			}
			return messageSink2;
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x0003F1DC File Offset: 0x0003D3DC
		internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute)
		{
			/*
An exception occurred when decompiling this method (06001CF2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Remoting.Messaging.IMessageSink System.Runtime.Remoting.Contexts.Context::CreateServerObjectSinkChain(System.MarshalByRefObject,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	stloc:class System.Collections.Generic.List`1<class System.Runtime.Remoting.Contexts.IContextProperty>(var_2_1A, ldfld:class System.Collections.Generic.List`1<class System.Runtime.Remoting.Contexts.IContextProperty>(Context::context_properties, ldloc:Context(this)))
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

		// Token: 0x06001CF3 RID: 7411 RVA: 0x0003F204 File Offset: 0x0003D404
		internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject)
		{
			if (!true)
			{
			}
			List<IContextProperty> list = this.context_properties;
			if (list != null)
			{
				while (list == null)
				{
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x0003F230 File Offset: 0x0003D430
		internal static Context SwitchToContext(Context newContext)
		{
			Context context;
			return context;
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x0003F240 File Offset: 0x0003D440
		internal static Context CreateNewContext(IConstructionCallMessage msg)
		{
			long value = 0.m_value;
			if (false)
			{
				throw new OutOfMemoryException();
			}
			long value2 = 0.m_value;
			if (!false)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x0003F2A0 File Offset: 0x0003D4A0
		public void DoCallBack(CrossContextDelegate deleg)
		{
			if (this.callback_object != null)
			{
				return;
			}
			Context context = AppDomain.InternalSetContext(AppDomain.InternalSetContext(this));
			long num = 0L;
			Monitor.Exit(this);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x0003F2F0 File Offset: 0x0003D4F0
		private LocalDataStore MyLocalStore
		{
			get
			{
				LocalDataStoreHolder localDataStore = this._localDataStore;
				if (localDataStore == null)
				{
					if (!true)
					{
					}
					if (this._localDataStore != null)
					{
					}
					if (!true)
					{
					}
					long num = 0L;
					LocalDataStoreHolder localDataStoreHolder;
					this._localDataStore = localDataStoreHolder;
					if (true)
					{
						Monitor.Exit(localDataStore);
					}
					if (num != 0L)
					{
						throw new OutOfMemoryException();
					}
				}
				return this._localDataStore.m_Store;
			}
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x0003F354 File Offset: 0x0003D554
		public static LocalDataStoreSlot AllocateDataSlot()
		{
			if (!true)
			{
			}
			LocalDataStoreSlot localDataStoreSlot;
			return localDataStoreSlot;
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x0003F368 File Offset: 0x0003D568
		public static LocalDataStoreSlot AllocateNamedDataSlot(string name)
		{
			if (!true)
			{
			}
			LocalDataStoreSlot localDataStoreSlot;
			return localDataStoreSlot;
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x0003F37C File Offset: 0x0003D57C
		public static void FreeNamedDataSlot(string name)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x0003F38C File Offset: 0x0003D58C
		public static LocalDataStoreSlot GetNamedDataSlot(string name)
		{
			if (!true)
			{
			}
			LocalDataStoreSlot localDataStoreSlot;
			return localDataStoreSlot;
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x0003F3A0 File Offset: 0x0003D5A0
		public static object GetData(LocalDataStoreSlot slot)
		{
			return Thread.CurrentContext.MyLocalStore.GetData(slot);
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x0003F3C0 File Offset: 0x0003D5C0
		public static void SetData(LocalDataStoreSlot slot, object data)
		{
			Thread.CurrentContext.MyLocalStore.SetData(slot, data);
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x0003F3E0 File Offset: 0x0003D5E0
		// Note: this type is marked as 'beforefieldinit'.
		static Context()
		{
		}

		// Token: 0x04000EA1 RID: 3745
		private int domain_id;

		// Token: 0x04000EA2 RID: 3746
		private int context_id;

		// Token: 0x04000EA3 RID: 3747
		private UIntPtr static_data;

		// Token: 0x04000EA4 RID: 3748
		private UIntPtr data;

		// Token: 0x04000EA5 RID: 3749
		[ContextStatic]
		private static object[] local_slots;

		// Token: 0x04000EA6 RID: 3750
		private static IMessageSink default_server_context_sink;

		// Token: 0x04000EA7 RID: 3751
		private IMessageSink server_context_sink_chain;

		// Token: 0x04000EA8 RID: 3752
		private IMessageSink client_context_sink_chain;

		// Token: 0x04000EA9 RID: 3753
		private List<IContextProperty> context_properties;

		// Token: 0x04000EAA RID: 3754
		private static int global_count;

		// Token: 0x04000EAB RID: 3755
		private LocalDataStoreHolder _localDataStore;

		// Token: 0x04000EAC RID: 3756
		private static LocalDataStoreMgr _localDataStoreMgr;

		// Token: 0x04000EAD RID: 3757
		private static DynamicPropertyCollection global_dynamic_properties;

		// Token: 0x04000EAE RID: 3758
		private DynamicPropertyCollection context_dynamic_properties;

		// Token: 0x04000EAF RID: 3759
		private ContextCallbackObject callback_object;
	}
}
