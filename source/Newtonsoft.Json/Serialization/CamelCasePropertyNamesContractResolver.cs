using System;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000087 RID: 135
	[Preserve]
	public class CamelCasePropertyNamesContractResolver : DefaultContractResolver
	{
		// Token: 0x060004CD RID: 1229 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		public CamelCasePropertyNamesContractResolver()
		{
			if (!true)
			{
			}
			base..ctor();
			this._sharedCache = true;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0000C9E0 File Offset: 0x0000ABE0
		protected override string ResolvePropertyName(string propertyName)
		{
			return StringUtils.ToCamelCase(propertyName);
		}
	}
}
