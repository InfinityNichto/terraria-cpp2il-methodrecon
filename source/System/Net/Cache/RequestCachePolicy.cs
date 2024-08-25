using System;

namespace System.Net.Cache
{
	// Token: 0x020002E7 RID: 743
	public class RequestCachePolicy
	{
		// Token: 0x060012FD RID: 4861 RVA: 0x0003ACE8 File Offset: 0x00038EE8
		public RequestCachePolicy(RequestCacheLevel level)
		{
			this.m_Level = level;
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x0003AD04 File Offset: 0x00038F04
		public RequestCacheLevel Level
		{
			get
			{
				return this.m_Level;
			}
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x0003AD18 File Offset: 0x00038F18
		public override string ToString()
		{
			RequestCacheLevel level = this.m_Level;
			string text;
			return "Level:" + text;
		}

		// Token: 0x04000F7E RID: 3966
		private RequestCacheLevel m_Level;
	}
}
