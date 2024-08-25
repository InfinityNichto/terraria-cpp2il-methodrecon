using System;
using System.Xml;

namespace System.Configuration
{
	// Token: 0x02000005 RID: 5
	public abstract class ConfigurationSection : ConfigurationElement
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002118 File Offset: 0x00000318
		protected internal virtual void DeserializeSection(XmlReader reader)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000212C File Offset: 0x0000032C
		protected internal override bool IsModified()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002140 File Offset: 0x00000340
		protected internal override void ResetModified()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002154 File Offset: 0x00000354
		protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode)
		{
			throw new NotSupportedException();
		}
	}
}
