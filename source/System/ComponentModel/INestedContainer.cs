using System;

namespace System.ComponentModel
{
	// Token: 0x02000385 RID: 901
	public interface INestedContainer : IContainer, IDisposable
	{
		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600179C RID: 6044
		IComponent Owner { get; }
	}
}
