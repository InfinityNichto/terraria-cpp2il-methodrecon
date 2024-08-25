using System;

namespace System.Globalization
{
	// Token: 0x020005BA RID: 1466
	[Serializable]
	internal class CodePageDataItem
	{
		// Token: 0x06002CCC RID: 11468 RVA: 0x00062A5C File Offset: 0x00060C5C
		internal CodePageDataItem(int dataIndex)
		{
			int num = 1;
			base..ctor();
			this.m_dataIndex = dataIndex;
			if (num == 0)
			{
			}
			this.m_flags = (uint)num;
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x00062A84 File Offset: 0x00060C84
		internal static string CreateString(string pStrings, uint index)
		{
			if (!true)
			{
			}
			string[] array;
			return array;
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06002CCE RID: 11470 RVA: 0x00062A9C File Offset: 0x00060C9C
		public string WebName
		{
			get
			{
				int num = 1;
				string text;
				if (this.m_webName == null)
				{
					if (num == 0)
					{
					}
					this.m_webName = text;
				}
				return text;
			}
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x00062AC0 File Offset: 0x00060CC0
		// Note: this type is marked as 'beforefieldinit'.
		static CodePageDataItem()
		{
		}

		// Token: 0x040018E9 RID: 6377
		internal int m_dataIndex;

		// Token: 0x040018EA RID: 6378
		internal int m_uiFamilyCodePage;

		// Token: 0x040018EB RID: 6379
		internal string m_webName;

		// Token: 0x040018EC RID: 6380
		internal uint m_flags;

		// Token: 0x040018ED RID: 6381
		private static readonly char[] sep;
	}
}
