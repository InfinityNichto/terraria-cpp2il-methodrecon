using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000272 RID: 626
	internal class ServicePointScheduler
	{
		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x00035984 File Offset: 0x00033B84
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x00035998 File Offset: 0x00033B98
		private ServicePoint ServicePoint
		{
			[CompilerGenerated]
			get
			{
				return this.<ServicePoint>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ServicePoint>k__BackingField = value;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x000359AC File Offset: 0x00033BAC
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x000359C0 File Offset: 0x00033BC0
		public int MaxIdleTime
		{
			get
			{
				return this.maxIdleTime;
			}
			set
			{
				int num = this.maxIdleTime;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x000359E4 File Offset: 0x00033BE4
		// (set) Token: 0x0600112E RID: 4398 RVA: 0x000359F8 File Offset: 0x00033BF8
		public int ConnectionLimit
		{
			get
			{
				return this.connectionLimit;
			}
			set
			{
				int num = this.connectionLimit;
			}
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00035A1C File Offset: 0x00033C1C
		public ServicePointScheduler(ServicePoint servicePoint, int connectionLimit, int maxIdleTime)
		{
			int num = 34464;
			this.maxIdleTime = num;
			base..ctor();
			this.ServicePoint = servicePoint;
			this.connectionLimit = connectionLimit;
			this.maxIdleTime = maxIdleTime;
			DateTime utcNow = DateTime.UtcNow;
			this.idleSince = utcNow;
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00035A64 File Offset: 0x00033C64
		[Conditional("MONO_WEB_DEBUG")]
		private void Debug(string message)
		{
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x00035A74 File Offset: 0x00033C74
		public int CurrentConnections
		{
			get
			{
				return this.currentConnections;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x00035A88 File Offset: 0x00033C88
		public DateTime IdleSince
		{
			get
			{
				DateTime dateTime = this.idleSince;
				DateTime dateTime2;
				return dateTime2;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x00035AA0 File Offset: 0x00033CA0
		internal string ME
		{
			[CompilerGenerated]
			get
			{
				return this.<ME>k__BackingField;
			}
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00035AB4 File Offset: 0x00033CB4
		public void Run()
		{
			int num = 1;
			long num2 = 0L;
			if (Interlocked.CompareExchange(0, num, (int)num2) == 0)
			{
			}
			this.schedulerEvent.Set();
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00035ADC File Offset: 0x00033CDC
		private Task RunScheduler()
		{
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x00035AF4 File Offset: 0x00033CF4
		private void Cleanup()
		{
			if (this.groups != null)
			{
				Dictionary<string, ServicePointScheduler.ConnectionGroup> dictionary = this.groups;
				Dictionary<string, ServicePointScheduler.ConnectionGroup> dictionary2 = this.groups;
				Dictionary<string, ServicePointScheduler.ConnectionGroup> dictionary3 = this.groups;
				Dictionary<string, ServicePointScheduler.ConnectionGroup> dictionary4 = this.groups;
				if (this.groups == null)
				{
				}
			}
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00035B30 File Offset: 0x00033D30
		private void RunSchedulerIteration()
		{
			this.schedulerEvent.Reset();
			ServicePointScheduler.ConnectionGroup connectionGroup = this.defaultGroup;
			bool flag = this.SchedulerIteration(connectionGroup);
			if (this.groups != null)
			{
				return;
			}
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x00035B74 File Offset: 0x00033D74
		private bool OperationCompleted(ServicePointScheduler.ConnectionGroup group, WebOperation operation)
		{
			WebCompletionSource.Result currentResult = operation.finishedTask.currentResult;
			bool success = currentResult.Success;
			WebConnection <Connection>k__BackingField = operation.<Connection>k__BackingField;
			if (currentResult != null)
			{
				bool flag;
				return flag;
			}
			Task task = Task.Delay(this.maxIdleTime);
			WebConnection <Connection>k__BackingField2 = operation.<Connection>k__BackingField;
			global::System.Collections.Generic.LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> linkedList = this.idleConnections;
			return true;
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x00035C00 File Offset: 0x00033E00
		private void CloseIdleConnection(ServicePointScheduler.ConnectionGroup group, WebConnection connection)
		{
			group.RemoveConnection(connection);
			this.RemoveIdleConnection(connection);
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00035C1C File Offset: 0x00033E1C
		private bool SchedulerIteration(ServicePointScheduler.ConnectionGroup group)
		{
			group.Cleanup();
			WebOperation nextOperation = group.GetNextOperation();
			if (nextOperation != null)
			{
				long num = 0L;
				if (group.CreateOrReuseConnection(nextOperation, num != 0L) != null)
				{
					global::System.Collections.Generic.LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> linkedList = this.operations;
				}
			}
			return true;
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00035C50 File Offset: 0x00033E50
		private void RemoveOperation(WebOperation operation)
		{
			global::System.Collections.Generic.LinkedListNode head = this.operations.head;
			if (head != null)
			{
				global::System.Collections.Generic.LinkedListNode next = head.Next;
				this.operations.Remove(head);
				while (next != null)
				{
				}
			}
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00035C84 File Offset: 0x00033E84
		private void RemoveIdleConnection(WebConnection connection)
		{
			global::System.Collections.Generic.LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> linkedList = this.idleConnections;
			global::System.Collections.Generic.LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> linkedList2 = this.idleConnections;
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00035CA0 File Offset: 0x00033EA0
		private void FinalCleanup()
		{
			ServicePoint servicePoint = this.<ServicePoint>k__BackingField;
			servicePoint.disposed = true;
			if (!true)
			{
			}
			ServicePointManager.RemoveServicePoint(servicePoint);
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00035CC4 File Offset: 0x00033EC4
		public void SendRequest(WebOperation operation, string groupName)
		{
			ServicePoint servicePoint = this.<ServicePoint>k__BackingField;
			this.GetConnectionGroup(groupName).EnqueueOperation(operation);
			this.Run();
			long num = 0L;
			Monitor.Exit(servicePoint);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00035D18 File Offset: 0x00033F18
		public bool CloseConnectionGroup(string groupName)
		{
			bool flag = string.IsNullOrEmpty(groupName);
			ServicePointScheduler.ConnectionGroup connectionGroup = this.defaultGroup;
			this.Run();
			return true;
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x00035D5C File Offset: 0x00033F5C
		private ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name)
		{
			ServicePoint servicePoint = this.<ServicePoint>k__BackingField;
			bool flag = string.IsNullOrEmpty(name);
			ServicePointScheduler.ConnectionGroup connectionGroup = this.defaultGroup;
			if (this.groups == null)
			{
			}
			Dictionary<string, ServicePointScheduler.ConnectionGroup> dictionary = this.groups;
			long num = 0L;
			Monitor.Exit(servicePoint);
			if (num == 0L)
			{
				return connectionGroup;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00035DC0 File Offset: 0x00033FC0
		private void OnConnectionCreated(WebConnection connection)
		{
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00035DD0 File Offset: 0x00033FD0
		private void OnConnectionClosed(WebConnection connection)
		{
			this.RemoveIdleConnection(connection);
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00035DE4 File Offset: 0x00033FE4
		public static Task<bool> WaitAsync(Task workerTask, int millisecondTimeout)
		{
			/*
An exception occurred when decompiling this method (06001143)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Boolean> System.Net.ServicePointScheduler::WaitAsync(System.Threading.Tasks.Task,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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

		// Token: 0x06001144 RID: 4420 RVA: 0x00035DF4 File Offset: 0x00033FF4
		[CompilerGenerated]
		private Task <Run>b__31_0()
		{
			return this.RunScheduler();
		}

		// Token: 0x04000D57 RID: 3415
		[CompilerGenerated]
		private ServicePoint <ServicePoint>k__BackingField;

		// Token: 0x04000D58 RID: 3416
		private int running;

		// Token: 0x04000D59 RID: 3417
		private int maxIdleTime;

		// Token: 0x04000D5A RID: 3418
		private ServicePointScheduler.AsyncManualResetEvent schedulerEvent;

		// Token: 0x04000D5B RID: 3419
		private ServicePointScheduler.ConnectionGroup defaultGroup;

		// Token: 0x04000D5C RID: 3420
		private Dictionary<string, ServicePointScheduler.ConnectionGroup> groups;

		// Token: 0x04000D5D RID: 3421
		private global::System.Collections.Generic.LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> operations;

		// Token: 0x04000D5E RID: 3422
		private global::System.Collections.Generic.LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> idleConnections;

		// Token: 0x04000D5F RID: 3423
		private int currentConnections;

		// Token: 0x04000D60 RID: 3424
		private int connectionLimit;

		// Token: 0x04000D61 RID: 3425
		private DateTime idleSince;

		// Token: 0x04000D62 RID: 3426
		private static int nextId;

		// Token: 0x04000D63 RID: 3427
		public readonly int ID;

		// Token: 0x04000D64 RID: 3428
		[CompilerGenerated]
		private readonly string <ME>k__BackingField;

		// Token: 0x02000273 RID: 627
		private class ConnectionGroup
		{
			// Token: 0x170003F4 RID: 1012
			// (get) Token: 0x06001145 RID: 4421 RVA: 0x00035E08 File Offset: 0x00034008
			public ServicePointScheduler Scheduler
			{
				[CompilerGenerated]
				get
				{
					return this.<Scheduler>k__BackingField;
				}
			}

			// Token: 0x170003F5 RID: 1013
			// (get) Token: 0x06001146 RID: 4422 RVA: 0x00035E1C File Offset: 0x0003401C
			public string Name
			{
				[CompilerGenerated]
				get
				{
					return this.<Name>k__BackingField;
				}
			}

			// Token: 0x170003F6 RID: 1014
			// (get) Token: 0x06001147 RID: 4423 RVA: 0x00035E30 File Offset: 0x00034030
			public bool IsDefault
			{
				get
				{
					return string.IsNullOrEmpty(this.<Name>k__BackingField);
				}
			}

			// Token: 0x06001148 RID: 4424 RVA: 0x00035E48 File Offset: 0x00034048
			public ConnectionGroup(ServicePointScheduler scheduler, string name)
			{
				this.Scheduler = scheduler;
				this.Name = name;
			}

			// Token: 0x06001149 RID: 4425 RVA: 0x00035E6C File Offset: 0x0003406C
			public bool IsEmpty()
			{
				/*
An exception occurred when decompiling this method (06001149)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.ServicePointScheduler/ConnectionGroup::IsEmpty()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:int32(var_1_1A, ldfld:int32(LinkedList`1::count, ldfld:class System.Collections.Generic.LinkedList`1<class System.Net.WebOperation>[exp:LinkedList`1](ConnectionGroup::queue, ldloc:ConnectionGroup(this))))
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

			// Token: 0x0600114A RID: 4426 RVA: 0x00035E94 File Offset: 0x00034094
			public void RemoveConnection(WebConnection connection)
			{
				global::System.Collections.Generic.LinkedList<WebConnection> linkedList = this.connections;
				long num = 0L;
				connection.Dispose(num != 0L);
				this.<Scheduler>k__BackingField.RemoveIdleConnection(connection);
			}

			// Token: 0x0600114B RID: 4427 RVA: 0x00035EC0 File Offset: 0x000340C0
			public void Cleanup()
			{
				global::System.Collections.Generic.LinkedList<WebConnection> linkedList = this.connections;
				global::System.Collections.Generic.LinkedListNode head = linkedList.head;
				if (head != null)
				{
					!0 item = head.item;
					if (linkedList != null)
					{
						global::System.Collections.Generic.LinkedList<WebConnection> linkedList2 = this.connections;
						ServicePointScheduler servicePointScheduler = this.<Scheduler>k__BackingField;
					}
					while (head != null)
					{
					}
				}
			}

			// Token: 0x0600114C RID: 4428 RVA: 0x00035EFC File Offset: 0x000340FC
			public void Close()
			{
				global::System.Collections.Generic.LinkedList<WebOperation> linkedList = this.queue;
				ServicePointScheduler servicePointScheduler = this.<Scheduler>k__BackingField;
			}

			// Token: 0x0600114D RID: 4429 RVA: 0x00035F64 File Offset: 0x00034164
			public void EnqueueOperation(WebOperation operation)
			{
				global::System.Collections.Generic.LinkedList<WebOperation> linkedList = this.queue;
			}

			// Token: 0x0600114E RID: 4430 RVA: 0x00035F78 File Offset: 0x00034178
			public WebOperation GetNextOperation()
			{
				global::System.Collections.Generic.LinkedListNode head = this.queue.head;
				if (head != null)
				{
					!0 item = head.item;
					global::System.Collections.Generic.LinkedList<WebOperation> linkedList = this.queue;
					ServicePointScheduler servicePointScheduler = this.<Scheduler>k__BackingField;
					while (head != null)
					{
					}
					return;
				}
			}

			// Token: 0x0600114F RID: 4431 RVA: 0x00035FB0 File Offset: 0x000341B0
			public WebConnection FindIdleConnection(WebOperation operation)
			{
				global::System.Collections.Generic.LinkedList<WebConnection> linkedList = this.connections;
				if (!true)
				{
				}
				global::System.Collections.Generic.LinkedList<WebOperation> linkedList2 = this.queue;
				global::System.Collections.Generic.LinkedList<WebConnection> linkedList3 = this.connections;
				global::System.Collections.Generic.LinkedList<WebOperation> linkedList4 = this.queue;
				throw new OutOfMemoryException();
			}

			// Token: 0x06001150 RID: 4432 RVA: 0x00036000 File Offset: 0x00034200
			public ValueTuple<WebConnection, bool> CreateOrReuseConnection(WebOperation operation, bool force)
			{
				/*
An exception occurred when decompiling this method (06001150)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ValueTuple`2<System.Net.WebConnection,System.Boolean> System.Net.ServicePointScheduler/ConnectionGroup::CreateOrReuseConnection(System.Net.WebOperation,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002D:
	stloc:ServicePoint(var_4_33, ldfld:ServicePoint(ServicePointScheduler::<ServicePoint>k__BackingField, ldloc:ServicePointScheduler(var_0_0F)))
	stloc:class System.Collections.Generic.LinkedList`1<class System.Net.WebConnection>(var_7_3E, ldfld:class System.Collections.Generic.LinkedList`1<class System.Net.WebConnection>(ConnectionGroup::connections, ldloc:ConnectionGroup(this)))
	stloc:ServicePointScheduler(var_8_46, ldfld:ServicePointScheduler(ConnectionGroup::<Scheduler>k__BackingField, ldloc:ConnectionGroup(this)))
	stloc:class System.Collections.Generic.LinkedList`1<class System.Net.WebOperation>(var_10_4E, ldfld:class System.Collections.Generic.LinkedList`1<class System.Net.WebOperation>(ConnectionGroup::queue, ldloc:ConnectionGroup(this)))
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

			// Token: 0x04000D65 RID: 3429
			[CompilerGenerated]
			private readonly ServicePointScheduler <Scheduler>k__BackingField;

			// Token: 0x04000D66 RID: 3430
			[CompilerGenerated]
			private readonly string <Name>k__BackingField;

			// Token: 0x04000D67 RID: 3431
			private static int nextId;

			// Token: 0x04000D68 RID: 3432
			public readonly int ID;

			// Token: 0x04000D69 RID: 3433
			private global::System.Collections.Generic.LinkedList<WebConnection> connections;

			// Token: 0x04000D6A RID: 3434
			private global::System.Collections.Generic.LinkedList<WebOperation> queue;
		}

		// Token: 0x02000274 RID: 628
		private class AsyncManualResetEvent
		{
			// Token: 0x06001151 RID: 4433 RVA: 0x0003605C File Offset: 0x0003425C
			public Task WaitAsync()
			{
				/*
An exception occurred when decompiling this method (06001151)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task System.Net.ServicePointScheduler/AsyncManualResetEvent::WaitAsync()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Task`1(var_0_0B, ldfld:class [mscorlib]System.Threading.Tasks.Task`1<!0>[exp:Task`1](TaskCompletionSource`1::_task, ldfld:class [mscorlib]System.Threading.Tasks.TaskCompletionSource`1<bool>[exp:TaskCompletionSource`1](AsyncManualResetEvent::m_tcs, ldloc:AsyncManualResetEvent(this))))
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

			// Token: 0x06001152 RID: 4434 RVA: 0x00036074 File Offset: 0x00034274
			public bool WaitOne(int millisecondTimeout)
			{
				return this.m_tcs._task.Wait(millisecondTimeout);
			}

			// Token: 0x06001153 RID: 4435 RVA: 0x00036094 File Offset: 0x00034294
			public Task<bool> WaitAsync(int millisecondTimeout)
			{
				return ServicePointScheduler.WaitAsync(this.m_tcs._task, millisecondTimeout);
			}

			// Token: 0x06001154 RID: 4436 RVA: 0x000360B4 File Offset: 0x000342B4
			public void Set()
			{
				TaskCompletionSource<bool> tcs = this.m_tcs;
				if (!true)
				{
				}
				CancellationToken none = CancellationToken.None;
				if (!true)
				{
				}
				tcs._task.Wait();
			}

			// Token: 0x06001155 RID: 4437 RVA: 0x000360E4 File Offset: 0x000342E4
			public void Reset()
			{
			}

			// Token: 0x06001156 RID: 4438 RVA: 0x000360F4 File Offset: 0x000342F4
			public AsyncManualResetEvent(bool state)
			{
				this.Set();
			}

			// Token: 0x04000D6B RID: 3435
			private TaskCompletionSource<bool> m_tcs;

			// Token: 0x02000275 RID: 629
			[CompilerGenerated]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06001157 RID: 4439 RVA: 0x0000205C File Offset: 0x0000025C
				// Note: this type is marked as 'beforefieldinit'.
				static <>c()
				{
				}

				// Token: 0x06001158 RID: 4440 RVA: 0x0000205C File Offset: 0x0000025C
				public <>c()
				{
				}

				// Token: 0x06001159 RID: 4441 RVA: 0x00036110 File Offset: 0x00034310
				internal bool <Set>b__4_0(object s)
				{
					return default(bool);
				}

				// Token: 0x04000D6C RID: 3436
				public static readonly ServicePointScheduler.AsyncManualResetEvent.<>c <>9;

				// Token: 0x04000D6D RID: 3437
				public static Func<object, bool> <>9__4_0;
			}
		}

		// Token: 0x02000276 RID: 630
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <RunScheduler>d__32 : IAsyncStateMachine
		{
			// Token: 0x0600115A RID: 4442 RVA: 0x00002050 File Offset: 0x00000250
			private void MoveNext()
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600115B RID: 4443 RVA: 0x00036128 File Offset: 0x00034328
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000D6E RID: 3438
			public int <>1__state;

			// Token: 0x04000D6F RID: 3439
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000D70 RID: 3440
			public ServicePointScheduler <>4__this;

			// Token: 0x04000D71 RID: 3441
			private ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>[] <operationArray>5__2;

			// Token: 0x04000D72 RID: 3442
			private ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>[] <idleArray>5__3;

			// Token: 0x04000D73 RID: 3443
			private List<Task> <taskList>5__4;

			// Token: 0x04000D74 RID: 3444
			private Task<bool> <schedulerTask>5__5;

			// Token: 0x04000D75 RID: 3445
			private bool <finalCleanup>5__6;

			// Token: 0x04000D76 RID: 3446
			private ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000277 RID: 631
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <WaitAsync>d__46 : IAsyncStateMachine
		{
			// Token: 0x0600115C RID: 4444 RVA: 0x00036138 File Offset: 0x00034338
			private void MoveNext()
			{
				CancellationToken cancellationToken;
				Task task = Task.Delay(this.millisecondTimeout, cancellationToken);
				this.<timeoutTask>5__3 = task;
				Task task2 = this.workerTask;
				if (task2 != null && task2 == null)
				{
					throw new ArrayTypeMismatchException();
				}
				Task task3 = this.<timeoutTask>5__3;
				if (task3 == null || task3 != null)
				{
					return;
				}
				throw new ArrayTypeMismatchException();
			}

			// Token: 0x0600115D RID: 4445 RVA: 0x00036208 File Offset: 0x00034408
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000D77 RID: 3447
			public int <>1__state;

			// Token: 0x04000D78 RID: 3448
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04000D79 RID: 3449
			public int millisecondTimeout;

			// Token: 0x04000D7A RID: 3450
			public Task workerTask;

			// Token: 0x04000D7B RID: 3451
			private CancellationTokenSource <cts>5__2;

			// Token: 0x04000D7C RID: 3452
			private Task <timeoutTask>5__3;

			// Token: 0x04000D7D RID: 3453
			private ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
