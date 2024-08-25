using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000019 RID: 25
	[Preserve]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public sealed class JsonRequiredAttribute : Attribute
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00002770 File Offset: 0x00000970
		public JsonRequiredAttribute()
		{
		}
	}
}
