using System;
using System.Collections.Generic;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C1 RID: 193
	[Preserve]
	public class JTokenEqualityComparer : IEqualityComparer<JToken>
	{
		// Token: 0x060006F2 RID: 1778 RVA: 0x00012358 File Offset: 0x00010558
		public bool Equals(JToken x, JToken y)
		{
			if (!true)
			{
			}
			if (x == null || y != null)
			{
			}
			return true;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00012370 File Offset: 0x00010570
		public int GetHashCode(JToken obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00012384 File Offset: 0x00010584
		public JTokenEqualityComparer()
		{
		}
	}
}
