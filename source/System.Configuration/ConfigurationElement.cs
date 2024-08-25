using System;
using System.Reflection;
using System.Xml;

namespace System.Configuration
{
	// Token: 0x02000003 RID: 3
	[DefaultMember("Item")]
	public abstract class ConfigurationElement
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002064 File Offset: 0x00000264
		protected internal virtual ConfigurationPropertyCollection Properties
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002078 File Offset: 0x00000278
		protected internal virtual void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000208C File Offset: 0x0000028C
		protected internal virtual void InitializeDefault()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020A0 File Offset: 0x000002A0
		protected internal virtual bool IsModified()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020B4 File Offset: 0x000002B4
		protected virtual void PostDeserialize()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020C8 File Offset: 0x000002C8
		protected internal virtual void Reset(ConfigurationElement parentElement)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020DC File Offset: 0x000002DC
		protected internal virtual void ResetModified()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020F0 File Offset: 0x000002F0
		protected internal virtual bool SerializeToXmlElement(XmlWriter writer, string elementName)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002104 File Offset: 0x00000304
		protected internal virtual void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode)
		{
			throw new NotSupportedException();
		}
	}
}
