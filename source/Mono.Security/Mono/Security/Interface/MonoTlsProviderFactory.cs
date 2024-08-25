using System;
using Mono.Net.Security;

namespace Mono.Security.Interface
{
	// Token: 0x0200004D RID: 77
	public static class MonoTlsProviderFactory
	{
		// Token: 0x06000202 RID: 514 RVA: 0x00008C9C File Offset: 0x00006E9C
		public static MonoTlsProvider GetProvider()
		{
			if (NoReflectionHelper.GetProvider() != null)
			{
			}
			throw new InvalidCastException();
		}
	}
}
