using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000012 RID: 18
	[Preserve]
	public interface IArrayPool<T>
	{
		// Token: 0x0600002D RID: 45
		T[] Rent(int minimumLength);

		// Token: 0x0600002E RID: 46
		void Return(T[] array);
	}
}
