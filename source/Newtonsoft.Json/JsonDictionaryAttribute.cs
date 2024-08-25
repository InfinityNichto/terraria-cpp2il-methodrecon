using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000014 RID: 20
	[Preserve]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonDictionaryAttribute : JsonContainerAttribute
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000024F4 File Offset: 0x000006F4
		public JsonDictionaryAttribute()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002508 File Offset: 0x00000708
		public JsonDictionaryAttribute(string id)
		{
			this.<Id>k__BackingField = id;
		}
	}
}
