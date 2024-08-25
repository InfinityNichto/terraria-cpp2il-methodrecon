using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000ED RID: 237
	[Preserve]
	internal abstract class PathFilter
	{
		// Token: 0x060009D1 RID: 2513
		public abstract IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch);

		// Token: 0x060009D2 RID: 2514 RVA: 0x0001824C File Offset: 0x0001644C
		protected static JToken GetTokenIndex(JToken t, bool errorWhenNoMatch, int index)
		{
			long num = 0L;
			long num2 = 0L;
			if (num != 0L)
			{
				JToken jtoken;
				return jtoken;
			}
			if (num2 != 0L)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			return "Index {0} outside the bounds of JArray.";
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00018294 File Offset: 0x00016494
		protected PathFilter()
		{
		}
	}
}
