using System;

namespace System
{
	// Token: 0x02000140 RID: 320
	internal sealed class LocalDataStoreElement
	{
		// Token: 0x06000CB0 RID: 3248 RVA: 0x0001B958 File Offset: 0x00019B58
		public LocalDataStoreElement(long cookie)
		{
			this.m_cookie = cookie;
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0001B974 File Offset: 0x00019B74
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x0001B988 File Offset: 0x00019B88
		public object Value
		{
			get
			{
				return this.m_value;
			}
			set
			{
				this.m_value = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x0001B99C File Offset: 0x00019B9C
		public long Cookie
		{
			get
			{
				return this.m_cookie;
			}
		}

		// Token: 0x040004E8 RID: 1256
		private object m_value;

		// Token: 0x040004E9 RID: 1257
		private long m_cookie;
	}
}
