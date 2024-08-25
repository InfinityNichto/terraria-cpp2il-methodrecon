using System;
using System.Collections.Specialized;

namespace System.Configuration.Provider
{
	// Token: 0x02000002 RID: 2
	public abstract class ProviderBase
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public virtual void Initialize(string name, NameValueCollection config)
		{
			throw new NotSupportedException();
		}
	}
}
