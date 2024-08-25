using System;
using System.Configuration;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration
{
	// Token: 0x02000470 RID: 1136
	public sealed class HttpCachePolicyElement : ConfigurationElement
	{
		// Token: 0x06001EC6 RID: 7878 RVA: 0x000511B4 File Offset: 0x0004F3B4
		public HttpCachePolicyElement()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x000511C8 File Offset: 0x0004F3C8
		// (set) Token: 0x06001EC8 RID: 7880 RVA: 0x000511DC File Offset: 0x0004F3DC
		public TimeSpan MaximumAge
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x000511F0 File Offset: 0x0004F3F0
		// (set) Token: 0x06001ECA RID: 7882 RVA: 0x00051204 File Offset: 0x0004F404
		public TimeSpan MaximumStale
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001ECB RID: 7883 RVA: 0x00051218 File Offset: 0x0004F418
		// (set) Token: 0x06001ECC RID: 7884 RVA: 0x0005122C File Offset: 0x0004F42C
		public TimeSpan MinimumFresh
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x00051240 File Offset: 0x0004F440
		// (set) Token: 0x06001ECE RID: 7886 RVA: 0x00051254 File Offset: 0x0004F454
		public global::System.Net.Cache.HttpRequestCacheLevel PolicyLevel
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001ECF RID: 7887 RVA: 0x00051268 File Offset: 0x0004F468
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x0005127C File Offset: 0x0004F47C
		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00051290 File Offset: 0x0004F490
		protected override void Reset(ConfigurationElement parentElement)
		{
			throw new NotSupportedException();
		}
	}
}
