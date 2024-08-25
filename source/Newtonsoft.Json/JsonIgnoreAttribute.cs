using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200002B RID: 43
	[Preserve]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public sealed class JsonIgnoreAttribute : Attribute
	{
		// Token: 0x06000107 RID: 263 RVA: 0x00004DAC File Offset: 0x00002FAC
		public JsonIgnoreAttribute()
		{
		}
	}
}
