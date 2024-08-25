using System;
using System.Collections.Generic;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007A RID: 122
	[Preserve]
	public interface IAttributeProvider
	{
		// Token: 0x06000450 RID: 1104
		IList<Attribute> GetAttributes(bool inherit);

		// Token: 0x06000451 RID: 1105
		IList<Attribute> GetAttributes(Type attributeType, bool inherit);
	}
}
