using System;
using System.Xml;

namespace System.Configuration
{
	// Token: 0x02000497 RID: 1175
	public class DictionarySectionHandler : IConfigurationSectionHandler
	{
		// Token: 0x06001FDC RID: 8156 RVA: 0x00052760 File Offset: 0x00050960
		public DictionarySectionHandler()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x00052774 File Offset: 0x00050974
		protected virtual string KeyAttributeName
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001FDE RID: 8158 RVA: 0x00052788 File Offset: 0x00050988
		protected virtual string ValueAttributeName
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x0005279C File Offset: 0x0005099C
		public virtual object Create(object parent, object context, XmlNode section)
		{
			throw new NotSupportedException();
		}
	}
}
