using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000013 RID: 19
	[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false)]
	[Preserve]
	public sealed class JsonConstructorAttribute : Attribute
	{
		// Token: 0x0600002F RID: 47 RVA: 0x000024E0 File Offset: 0x000006E0
		public JsonConstructorAttribute()
		{
		}
	}
}
