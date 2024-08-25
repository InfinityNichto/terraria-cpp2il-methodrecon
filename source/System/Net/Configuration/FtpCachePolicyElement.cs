using System;
using System.Configuration;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration
{
	// Token: 0x0200046F RID: 1135
	public sealed class FtpCachePolicyElement : ConfigurationElement
	{
		// Token: 0x06001EC0 RID: 7872 RVA: 0x0005113C File Offset: 0x0004F33C
		public FtpCachePolicyElement()
		{
			throw new NotSupportedException();
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001EC1 RID: 7873 RVA: 0x00051150 File Offset: 0x0004F350
		// (set) Token: 0x06001EC2 RID: 7874 RVA: 0x00051164 File Offset: 0x0004F364
		public global::System.Net.Cache.RequestCacheLevel PolicyLevel
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

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001EC3 RID: 7875 RVA: 0x00051178 File Offset: 0x0004F378
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x0005118C File Offset: 0x0004F38C
		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x000511A0 File Offset: 0x0004F3A0
		protected override void Reset(ConfigurationElement parentElement)
		{
			throw new NotSupportedException();
		}
	}
}
