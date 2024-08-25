using System;
using System.Collections.Concurrent;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000427 RID: 1063
	internal sealed class NameCache
	{
		// Token: 0x06002135 RID: 8501 RVA: 0x0004B934 File Offset: 0x00049B34
		internal object GetCachedValue(string name)
		{
			this.name = name;
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x0004B94C File Offset: 0x00049B4C
		internal void SetCachedValue(object value)
		{
			if (!true)
			{
			}
			string text = this.name;
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x0004B964 File Offset: 0x00049B64
		public NameCache()
		{
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x0004B978 File Offset: 0x00049B78
		// Note: this type is marked as 'beforefieldinit'.
		static NameCache()
		{
		}

		// Token: 0x040011B4 RID: 4532
		private static ConcurrentDictionary<string, object> ht;

		// Token: 0x040011B5 RID: 4533
		private string name;
	}
}
