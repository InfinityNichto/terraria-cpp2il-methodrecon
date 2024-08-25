using System;
using System.Threading;
using Cpp2IlInjected;

namespace System.Net.Configuration
{
	// Token: 0x020002DD RID: 733
	internal sealed class DefaultProxySectionInternal
	{
		// Token: 0x060012DA RID: 4826 RVA: 0x0003A9B8 File Offset: 0x00038BB8
		private static IWebProxy GetDefaultProxy_UsingOldMonoCode()
		{
			return global::System.Net.WebProxy.CreateDefaultProxy();
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x0003A9CC File Offset: 0x00038BCC
		private static IWebProxy GetSystemWebProxy()
		{
			return global::System.Net.WebProxy.CreateDefaultProxy();
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x00002050 File Offset: 0x00000250
		internal static object ClassSyncObject
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0003A9E0 File Offset: 0x00038BE0
		internal static DefaultProxySectionInternal GetSection()
		{
			object obj = DefaultProxySectionInternal.ClassSyncObject;
			IWebProxy webProxy = global::System.Net.WebProxy.CreateDefaultProxy();
			long num = 0L;
			Monitor.Exit(obj);
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x0003AA28 File Offset: 0x00038C28
		internal IWebProxy WebProxy
		{
			get
			{
				return this.webProxy;
			}
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0003AA3C File Offset: 0x00038C3C
		public DefaultProxySectionInternal()
		{
		}

		// Token: 0x04000F57 RID: 3927
		private IWebProxy webProxy;

		// Token: 0x04000F58 RID: 3928
		private static object classSyncObject;
	}
}
