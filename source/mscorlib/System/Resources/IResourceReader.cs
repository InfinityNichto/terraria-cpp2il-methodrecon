using System;
using System.Collections;

namespace System.Resources
{
	// Token: 0x020004A5 RID: 1189
	public interface IResourceReader : IEnumerable, IDisposable
	{
		// Token: 0x060022C1 RID: 8897
		void Close();

		// Token: 0x060022C2 RID: 8898
		IDictionaryEnumerator GetEnumerator();
	}
}
