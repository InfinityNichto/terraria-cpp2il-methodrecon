using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2IlInjected;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x02000369 RID: 873
	internal class CrossContextChannel : IMessageSink
	{
		// Token: 0x06001D08 RID: 7432 RVA: 0x0003F5C4 File Offset: 0x0003D7C4
		public IMessage SyncProcessMessage(IMessage msg)
		{
			if (!true)
			{
			}
			if (RemotingServices.GetMessageTargetIdentity(msg) != null)
			{
			}
			Context currentContext = Thread.CurrentContext;
			long num = 0L;
			int num2 = 1;
			long num3 = 0L;
			long num4 = 0L;
			Context.NotifyGlobalDynamicSinks(num2 != 0, msg, num3 != 0L, num4 != 0L);
			Context currentContext2 = Thread.CurrentContext;
			int num5 = 1;
			long num6 = 0L;
			long num7 = 0L;
			currentContext2.NotifyDynamicSinks(num5 != 0, msg, num6 != 0L, num7 != 0L);
			IMessageSink serverContextSinkChain = currentContext2.GetServerContextSinkChain();
			long num8 = 0L;
			long num9 = 0L;
			long num10 = 0L;
			Context.NotifyGlobalDynamicSinks(num8 != 0L, msg, num9 != 0L, num10 != 0L);
			Context currentContext3 = Thread.CurrentContext;
			long num11 = 0L;
			long num12 = 0L;
			long num13 = 0L;
			currentContext3.NotifyDynamicSinks(num11 != 0L, msg, num12 != 0L, num13 != 0L);
			long num14 = 0L;
			if (num != 0L)
			{
			}
			if (num14 == 0L)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x0003F6A4 File Offset: 0x0003D8A4
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			if (!true)
			{
			}
			if (RemotingServices.GetMessageTargetIdentity(msg) != null)
			{
			}
			Context currentContext = Thread.CurrentContext;
			long num = 0L;
			int num2 = 1;
			int num3 = 1;
			long num4 = 0L;
			Context.NotifyGlobalDynamicSinks(num2 != 0, msg, num4 != 0L, num3 != 0);
			Context currentContext2 = Thread.CurrentContext;
			int num5 = 1;
			long num6 = 0L;
			long num7 = 0L;
			currentContext2.NotifyDynamicSinks(num5 != 0, msg, num6 != 0L, num7 != 0L);
			if (replySink != null)
			{
			}
			if (!false)
			{
				long num8 = 0L;
				long num9 = 0L;
				long num10 = 0L;
				Context.NotifyGlobalDynamicSinks(num8 != 0L, msg, num9 != 0L, num10 != 0L);
				Context currentContext3 = Thread.CurrentContext;
				long num11 = 0L;
				long num12 = 0L;
				long num13 = 0L;
				currentContext3.NotifyDynamicSinks(num11 != 0L, msg, num12 != 0L, num13 != 0L);
			}
			long num14 = 0L;
			if (num != 0L)
			{
			}
			if (num14 == 0L)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x0003F790 File Offset: 0x0003D990
		public CrossContextChannel()
		{
		}

		// Token: 0x0200036A RID: 874
		private class ContextRestoreSink : IMessageSink
		{
			// Token: 0x06001D0B RID: 7435 RVA: 0x0003F7A4 File Offset: 0x0003D9A4
			public ContextRestoreSink(IMessageSink next, Context context, IMessage call)
			{
				this._call = call;
			}

			// Token: 0x06001D0C RID: 7436 RVA: 0x0003F7C0 File Offset: 0x0003D9C0
			public IMessage SyncProcessMessage(IMessage msg)
			{
				if (!true)
				{
				}
				Context currentContext = Thread.CurrentContext;
				long num = 0L;
				long num2 = 0L;
				long num3 = 0L;
				currentContext.NotifyDynamicSinks(num != 0L, msg, num2 != 0L, num3 != 0L);
				IMessageSink next = this._next;
				long num4 = 0L;
				Context context = this._context;
				if (context != null)
				{
					Context context2 = AppDomain.InternalSetContext(context);
				}
				if (num4 == 0L)
				{
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x06001D0D RID: 7437 RVA: 0x0000207A File Offset: 0x0000027A
			public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000EB3 RID: 3763
			private IMessageSink _next;

			// Token: 0x04000EB4 RID: 3764
			private Context _context;

			// Token: 0x04000EB5 RID: 3765
			private IMessage _call;
		}
	}
}
