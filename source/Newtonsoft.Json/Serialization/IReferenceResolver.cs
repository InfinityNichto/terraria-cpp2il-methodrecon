using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000A4 RID: 164
	[Preserve]
	public interface IReferenceResolver
	{
		// Token: 0x060005E3 RID: 1507
		object ResolveReference(object context, string reference);

		// Token: 0x060005E4 RID: 1508
		string GetReference(object context, object value);

		// Token: 0x060005E5 RID: 1509
		bool IsReferenced(object context, object value);

		// Token: 0x060005E6 RID: 1510
		void AddReference(object context, string reference, object value);
	}
}
