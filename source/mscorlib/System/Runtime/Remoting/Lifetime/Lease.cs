using System;
using System.Collections;
using System.Threading;
using Cpp2IlInjected;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x0200035F RID: 863
	internal class Lease : MarshalByRefObject, ILease
	{
		// Token: 0x06001CB9 RID: 7353 RVA: 0x0003E8CC File Offset: 0x0003CACC
		public Lease()
		{
			this._currentState = LeaseState.Initial;
			if (!true)
			{
			}
			if (!true)
			{
			}
			this._initialLeaseTime = 1;
			if (!true)
			{
			}
			this._renewOnCallTime = 1;
			if (!true)
			{
			}
			this._sponsorshipTimeout = 1;
			if (!true)
			{
			}
			DateTime utcNow = DateTime.UtcNow;
			TimeSpan initialLeaseTime = this._initialLeaseTime;
			DateTime dateTime = utcNow + initialLeaseTime;
			this._leaseExpireTime = dateTime;
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x0003E928 File Offset: 0x0003CB28
		public TimeSpan CurrentLeaseTime
		{
			get
			{
				DateTime leaseExpireTime = this._leaseExpireTime;
				if (!true)
				{
				}
				DateTime utcNow = DateTime.UtcNow;
				TimeSpan timeSpan = leaseExpireTime - utcNow;
				return 1;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001CBB RID: 7355 RVA: 0x0003E950 File Offset: 0x0003CB50
		public LeaseState CurrentState
		{
			get
			{
				return this._currentState;
			}
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x0003E964 File Offset: 0x0003CB64
		public void Activate()
		{
			this._currentState = LeaseState.Active;
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x0003E978 File Offset: 0x0003CB78
		public TimeSpan RenewOnCallTime
		{
			get
			{
				TimeSpan renewOnCallTime = this._renewOnCallTime;
				TimeSpan timeSpan;
				return timeSpan;
			}
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x0003E990 File Offset: 0x0003CB90
		public TimeSpan Renew(TimeSpan renewalTime)
		{
			if (!true)
			{
			}
			DateTime dateTime = DateTime.UtcNow + renewalTime;
			DateTime leaseExpireTime = this._leaseExpireTime;
			bool flag = dateTime > leaseExpireTime;
			this._leaseExpireTime = dateTime;
			TimeSpan currentLeaseTime = this.CurrentLeaseTime;
			return 1;
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x0003E9D0 File Offset: 0x0003CBD0
		public void Unregister(ISponsor obj)
		{
			if (this._sponsors != null)
			{
				ArrayList sponsors = this._sponsors;
				ArrayList sponsors2 = this._sponsors;
				return;
			}
			long num = 0L;
			Monitor.Exit(this);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x0003EA30 File Offset: 0x0003CC30
		internal void UpdateState()
		{
			LeaseState currentState = this._currentState;
			TimeSpan currentLeaseTime = this.CurrentLeaseTime;
			if (this._sponsors != null)
			{
				this._currentState = LeaseState.Renewing;
				Monitor.Enter(this, true);
				ArrayList sponsors = this._sponsors;
				long num = 0L;
				Monitor.Exit(this);
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (5 == 0)
				{
					this.CheckNextSponsor();
					return;
				}
			}
			else
			{
				this._currentState = LeaseState.Expired;
			}
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x0003EAB0 File Offset: 0x0003CCB0
		private void CheckNextSponsor()
		{
			if (this._renewingSponsors != null)
			{
				Queue renewingSponsors = this._renewingSponsors;
				if (renewingSponsors != null)
				{
					if (renewingSponsors == null)
					{
						throw new InvalidCastException();
					}
				}
				return;
			}
			int num = 4;
			this._currentState = (LeaseState)num;
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x0003EAF8 File Offset: 0x0003CCF8
		private void ProcessSponsorResponse(object state, bool timedOut)
		{
			if (state != null && state == null)
			{
				throw new InvalidCastException();
			}
			int num = 2;
			this._currentState = (LeaseState)num;
		}

		// Token: 0x04000E8B RID: 3723
		private DateTime _leaseExpireTime;

		// Token: 0x04000E8C RID: 3724
		private LeaseState _currentState;

		// Token: 0x04000E8D RID: 3725
		private TimeSpan _initialLeaseTime;

		// Token: 0x04000E8E RID: 3726
		private TimeSpan _renewOnCallTime;

		// Token: 0x04000E8F RID: 3727
		private TimeSpan _sponsorshipTimeout;

		// Token: 0x04000E90 RID: 3728
		private ArrayList _sponsors;

		// Token: 0x04000E91 RID: 3729
		private Queue _renewingSponsors;

		// Token: 0x04000E92 RID: 3730
		private Lease.RenewalDelegate _renewalDelegate;

		// Token: 0x02000360 RID: 864
		private sealed class RenewalDelegate : MulticastDelegate
		{
			// Token: 0x06001CC3 RID: 7363 RVA: 0x0003EB3C File Offset: 0x0003CD3C
			public RenewalDelegate(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06001CC4 RID: 7364 RVA: 0x0003EB9C File Offset: 0x0003CD9C
			public TimeSpan Invoke(ILease lease)
			{
				/*
An exception occurred when decompiling this method (06001CC4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TimeSpan System.Runtime.Remoting.Lifetime.Lease/RenewalDelegate::Invoke(System.Runtime.Remoting.Lifetime.ILease)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:RenewalDelegate[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:RenewalDelegate[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:RenewalDelegate[exp:Delegate](this)))
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

			// Token: 0x06001CC5 RID: 7365 RVA: 0x0000207A File Offset: 0x0000027A
			public IAsyncResult BeginInvoke(ILease lease, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06001CC6 RID: 7366 RVA: 0x0003EBC0 File Offset: 0x0003CDC0
			public TimeSpan EndInvoke(IAsyncResult result)
			{
				TimeSpan timeSpan;
				return timeSpan;
			}
		}
	}
}
