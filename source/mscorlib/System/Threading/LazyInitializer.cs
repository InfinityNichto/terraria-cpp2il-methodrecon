using System;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x020001BB RID: 443
	public static class LazyInitializer
	{
		// Token: 0x060010AF RID: 4271 RVA: 0x0000207A File Offset: 0x0000027A
		public static T EnsureInitialized<T>(T target) where T : class
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00023608 File Offset: 0x00021808
		private static T EnsureInitializedCore<T>(T target) where T : class
		{
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0000207A File Offset: 0x0000027A
		public static T EnsureInitialized<T>(T target, Func<T> valueFactory) where T : class
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00023618 File Offset: 0x00021818
		private static T EnsureInitializedCore<T>(T target, Func<T> valueFactory) where T : class
		{
			while (target == null)
			{
			}
			return target;
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0000207A File Offset: 0x0000027A
		public static T EnsureInitialized<T>(T target, object syncLock, Func<T> valueFactory) where T : class
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0002362C File Offset: 0x0002182C
		private static T EnsureInitializedCore<T>(T target, object syncLock, Func<T> valueFactory) where T : class
		{
			long num = 0L;
			object obj;
			Monitor.Enter(obj, num != 0L);
			if (syncLock != null)
			{
				long num2 = 0L;
				Monitor.Exit(obj);
				if (num2 != 0L || 5 == 0)
				{
				}
				throw new OutOfMemoryException();
			}
			long num3 = 0L;
			Monitor.Exit(obj);
			if (num3 == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0002366C File Offset: 0x0002186C
		private static object EnsureLockInitialized(object syncLock)
		{
			object obj;
			if (obj == null)
			{
			}
			return obj;
		}
	}
}
