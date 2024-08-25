using System;
using System.Text;

namespace System.Collections.Generic
{
	// Token: 0x02000638 RID: 1592
	public static class KeyValuePair
	{
		// Token: 0x0600309E RID: 12446 RVA: 0x0006A758 File Offset: 0x00068958
		internal static string PairToString(object key, object value)
		{
			StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
			StringBuilder stringBuilder2 = stringBuilder.Append(", ");
			if (key != null)
			{
				StringBuilder stringBuilder3 = stringBuilder.Append(key);
			}
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}
	}
}
