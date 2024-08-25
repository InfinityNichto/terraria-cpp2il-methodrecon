using System;
using System.Collections.Generic;
using Mono.Unity;

namespace Mono.Net.Security
{
	// Token: 0x02000064 RID: 100
	internal static class MonoTlsProviderFactory
	{
		// Token: 0x06000179 RID: 377 RVA: 0x00005634 File Offset: 0x00003834
		internal static MobileTlsProvider GetProviderInternal()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			MonoTlsProviderFactory.InitializeInternal();
			if (!false)
			{
				return 1;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000566C File Offset: 0x0000386C
		internal static void InitializeInternal()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
			SystemDependencyProvider.Initialize();
			MonoTlsProviderFactory.InitializeProviderRegistration();
			if (MonoTlsProviderFactory.CreateDefaultProviderImpl() == null)
			{
				return;
			}
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000056C0 File Offset: 0x000038C0
		private static MobileTlsProvider LookupProvider(string name, bool throwOnError)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			MonoTlsProviderFactory.InitializeProviderRegistration();
			object obj;
			long num3;
			if (obj != null)
			{
				long num2 = 0L;
				num3 = 0L;
				if (num2 != 0L)
				{
					goto IL_0026;
				}
			}
			string text = string.Format("No such TLS Provider: `{0}'.", num3);
			IL_0026:
			throw new OutOfMemoryException();
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00005728 File Offset: 0x00003928
		private static void InitializeProviderRegistration()
		{
			if ("<?xml version=\"" == null)
			{
			}
			if ("<?xml version=\"" == null)
			{
			}
			if ("<?xml version=\"" == null)
			{
			}
			Mono.Unity.UnityTls.unitytls_interface_struct nativeInterface = Mono.Unity.UnityTls.NativeInterface;
			if (nativeInterface != null)
			{
				if ("<?xml version=\"" == null)
				{
				}
				MonoTlsProviderFactory.PopulateUnityProviders();
				return;
			}
			if ("<?xml version=\"" == null)
			{
			}
			MonoTlsProviderFactory.PopulateProviders();
			long num = 0L;
			if (nativeInterface != null)
			{
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00005798 File Offset: 0x00003998
		private static void PopulateUnityProviders()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000057A8 File Offset: 0x000039A8
		private static void PopulateProviders()
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000057B8 File Offset: 0x000039B8
		private static MobileTlsProvider CreateDefaultProviderImpl()
		{
			do
			{
				string environmentVariable = Environment.GetEnvironmentVariable("MONO_TLS_PROVIDER");
				bool flag = string.IsNullOrEmpty(environmentVariable);
				bool flag2 = environmentVariable == "default";
				bool flag3 = environmentVariable == "legacy";
			}
			while (Mono.Unity.UnityTls.NativeInterface == null);
			MobileTlsProvider mobileTlsProvider;
			return mobileTlsProvider;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000057F8 File Offset: 0x000039F8
		internal static MobileTlsProvider GetProvider()
		{
			if (!true)
			{
			}
			return MonoTlsProviderFactory.GetProviderInternal();
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00005810 File Offset: 0x00003A10
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTlsProviderFactory()
		{
		}

		// Token: 0x04000116 RID: 278
		private static object locker;

		// Token: 0x04000117 RID: 279
		private static bool initialized;

		// Token: 0x04000118 RID: 280
		private static MobileTlsProvider defaultProvider;

		// Token: 0x04000119 RID: 281
		private static Dictionary<string, Tuple<Guid, string>> providerRegistration;

		// Token: 0x0400011A RID: 282
		private static Dictionary<Guid, MobileTlsProvider> providerCache;

		// Token: 0x0400011B RID: 283
		internal static readonly Guid UnityTlsId;

		// Token: 0x0400011C RID: 284
		internal static readonly Guid AppleTlsId;

		// Token: 0x0400011D RID: 285
		internal static readonly Guid BtlsId;
	}
}
