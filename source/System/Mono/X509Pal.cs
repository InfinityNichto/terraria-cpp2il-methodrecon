using System;

namespace Mono
{
	// Token: 0x0200000A RID: 10
	internal static class X509Pal
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000225C File Offset: 0x0000045C
		public static X509PalImpl Instance
		{
			get
			{
				if (!true)
				{
				}
				SystemDependencyProvider instance = SystemDependencyProvider.Instance;
				X509PalImpl x509PalImpl;
				return x509PalImpl;
			}
		}
	}
}
