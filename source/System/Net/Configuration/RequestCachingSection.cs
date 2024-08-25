using System;
using System.Configuration;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration
{
	// Token: 0x0200047A RID: 1146
	public sealed class RequestCachingSection : ConfigurationSection
	{
		// Token: 0x06001F19 RID: 7961 RVA: 0x00051830 File Offset: 0x0004FA30
		public RequestCachingSection()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001F1A RID: 7962 RVA: 0x00051844 File Offset: 0x0004FA44
		public FtpCachePolicyElement DefaultFtpCachePolicy
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x00051858 File Offset: 0x0004FA58
		public HttpCachePolicyElement DefaultHttpCachePolicy
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x0005186C File Offset: 0x0004FA6C
		// (set) Token: 0x06001F1D RID: 7965 RVA: 0x00051880 File Offset: 0x0004FA80
		public global::System.Net.Cache.RequestCacheLevel DefaultPolicyLevel
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

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x00051894 File Offset: 0x0004FA94
		// (set) Token: 0x06001F1F RID: 7967 RVA: 0x000518A8 File Offset: 0x0004FAA8
		public bool DisableAllCaching
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

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x000518BC File Offset: 0x0004FABC
		// (set) Token: 0x06001F21 RID: 7969 RVA: 0x000518D0 File Offset: 0x0004FAD0
		public bool IsPrivateCache
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

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x000518E4 File Offset: 0x0004FAE4
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06001F23 RID: 7971 RVA: 0x000518F8 File Offset: 0x0004FAF8
		// (set) Token: 0x06001F24 RID: 7972 RVA: 0x0005190C File Offset: 0x0004FB0C
		public TimeSpan UnspecifiedMaximumAge
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

		// Token: 0x06001F25 RID: 7973 RVA: 0x00051920 File Offset: 0x0004FB20
		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x00051934 File Offset: 0x0004FB34
		protected override void PostDeserialize()
		{
			throw new NotSupportedException();
		}
	}
}
