using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000097 RID: 151
	[Preserve]
	public interface IValueProvider
	{
		// Token: 0x0600053A RID: 1338
		void SetValue(object target, object value);

		// Token: 0x0600053B RID: 1339
		object GetValue(object target);
	}
}
