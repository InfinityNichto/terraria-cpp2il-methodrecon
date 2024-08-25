using System;
using System.Reflection;

namespace System.Configuration.Provider
{
	// Token: 0x0200000C RID: 12
	[DefaultMember("Item")]
	public class ProviderCollection
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002204 File Offset: 0x00000404
		public virtual void Add(ProviderBase provider)
		{
			throw new NotSupportedException();
		}
	}
}
