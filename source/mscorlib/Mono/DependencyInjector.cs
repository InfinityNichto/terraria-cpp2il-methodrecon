using System;
using System.Reflection;

namespace Mono
{
	// Token: 0x0200000F RID: 15
	internal static class DependencyInjector
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002300 File Offset: 0x00000500
		internal static ISystemDependencyProvider SystemProvider
		{
			get
			{
				if (true)
				{
				}
				for (;;)
				{
				}
				ISystemDependencyProvider systemDependencyProvider = DependencyInjector.ReflectionLoad();
				if (systemDependencyProvider == null)
				{
					throw new OutOfMemoryException();
				}
				if (!false)
				{
					return systemDependencyProvider;
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002338 File Offset: 0x00000538
		internal static void Register(ISystemDependencyProvider provider)
		{
			if (!true)
			{
			}
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002368 File Offset: 0x00000568
		private static ISystemDependencyProvider ReflectionLoad()
		{
			if (!true)
			{
			}
			long num = 0L;
			PropertyInfo propertyInfo;
			object value = propertyInfo.GetValue(num);
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002390 File Offset: 0x00000590
		// Note: this type is marked as 'beforefieldinit'.
		static DependencyInjector()
		{
		}

		// Token: 0x04000088 RID: 136
		private static object locker;

		// Token: 0x04000089 RID: 137
		private static ISystemDependencyProvider systemDependency;
	}
}
