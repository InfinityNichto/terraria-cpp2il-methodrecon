using System;

namespace System.Security
{
	// Token: 0x02000291 RID: 657
	public interface IPermission : ISecurityEncodable
	{
		// Token: 0x060016BB RID: 5819
		void Demand();

		// Token: 0x060016BC RID: 5820
		bool IsSubsetOf(IPermission target);
	}
}
