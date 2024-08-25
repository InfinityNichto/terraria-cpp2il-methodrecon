using System;

namespace System.ComponentModel
{
	// Token: 0x02000386 RID: 902
	public interface INestedSite : ISite, IServiceProvider
	{
		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x0600179D RID: 6045
		string FullName { get; }
	}
}
