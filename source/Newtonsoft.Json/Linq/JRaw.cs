using System;
using System.Globalization;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000BF RID: 191
	[Preserve]
	public class JRaw : JValue
	{
		// Token: 0x060006ED RID: 1773 RVA: 0x000122D0 File Offset: 0x000104D0
		public JRaw(JRaw other)
			: base(other)
		{
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x000122E4 File Offset: 0x000104E4
		public JRaw(object rawJson)
			: base(rawJson, JTokenType.Raw)
		{
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x000122FC File Offset: 0x000104FC
		public static JRaw Create(JsonReader reader)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			if (!false)
			{
				if (!false)
				{
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0000212A File Offset: 0x0000032A
		internal override JToken CloneToken()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
