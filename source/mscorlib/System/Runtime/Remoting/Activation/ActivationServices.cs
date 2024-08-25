using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Threading;
using Cpp2IlInjected;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x02000384 RID: 900
	internal class ActivationServices
	{
		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x0000207A File Offset: 0x0000027A
		private static IActivator ConstructionActivator
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00040080 File Offset: 0x0003E280
		public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall)
		{
			int num = 1;
			bool hasExitSinks = Thread.CurrentContext.HasExitSinks;
			if (num != 0)
			{
				IMessage message;
				if (message == null)
				{
					return message;
				}
				if (message != null)
				{
					if (message != null)
					{
						return message;
					}
					throw new InvalidCastException();
				}
			}
			else
			{
				IMessageSink clientContextSinkChain = Thread.CurrentContext.GetClientContextSinkChain();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x000400CC File Offset: 0x0003E2CC
		public static IMessage RemoteActivate(IConstructionCallMessage ctorCall)
		{
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x000400DC File Offset: 0x0003E2DC
		public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, object[] activationAttributes)
		{
			IActivator constructionActivator = ActivationServices.ConstructionActivator;
			if (activationUrl != null)
			{
			}
			Context currentContext = Thread.CurrentContext;
			long value = 0.m_value;
			if (false)
			{
				throw new OutOfMemoryException();
			}
			long value2 = 0.m_value;
			long num = 0L;
			int num2 = 12;
			if (num == 0L)
			{
				if (num2 == 0)
				{
				}
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x00040158 File Offset: 0x0003E358
		public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall)
		{
			Identity identity;
			if (identity != null)
			{
			}
			Context currentContext = Thread.CurrentContext;
			bool flag;
			if (!false || !flag || !flag)
			{
				bool value = flag.m_value;
				bool value2 = flag.m_value;
				if (flag)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x00040198 File Offset: 0x0003E398
		public static object CreateProxyForType(Type type)
		{
			if (!true)
			{
			}
			ActivatedClientTypeEntry activatedClientTypeEntry;
			if (activatedClientTypeEntry != null)
			{
				if (!true)
				{
				}
				object obj;
				return obj;
			}
			if (!true)
			{
			}
			WellKnownClientTypeEntry wellKnownClientTypeEntry;
			if (wellKnownClientTypeEntry != null)
			{
				if (!true)
				{
				}
				return RemotingServices.CreateClientProxy(wellKnownClientTypeEntry);
			}
			if (!true)
			{
			}
			object obj2;
			return obj2;
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x0000207A File Offset: 0x0000027A
		public static object AllocateUninitializedClassInstance(Type type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x000401C8 File Offset: 0x0003E3C8
		public static void EnableProxyActivation(Type type, bool enable)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000EC9 RID: 3785
		private static IActivator _constructionActivator;
	}
}
