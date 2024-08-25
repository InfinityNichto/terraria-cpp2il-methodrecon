using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000077 RID: 119
	[Preserve]
	internal static class ValidationUtils
	{
		// Token: 0x06000449 RID: 1097 RVA: 0x0000B91C File Offset: 0x00009B1C
		public static void ArgumentNotNull(object value, string parameterName)
		{
			while (value == null)
			{
			}
		}
	}
}
