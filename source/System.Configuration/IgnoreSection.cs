using System;
using System.Xml;

namespace System.Configuration
{
	// Token: 0x0200000D RID: 13
	public sealed class IgnoreSection : ConfigurationSection
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002218 File Offset: 0x00000418
		public IgnoreSection()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001B RID: 27 RVA: 0x0000222C File Offset: 0x0000042C
		protected internal override ConfigurationPropertyCollection Properties
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002240 File Offset: 0x00000440
		protected internal override void DeserializeSection(XmlReader xmlReader)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002254 File Offset: 0x00000454
		protected internal override bool IsModified()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002268 File Offset: 0x00000468
		protected internal override void Reset(ConfigurationElement parentSection)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000227C File Offset: 0x0000047C
		protected internal override void ResetModified()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002290 File Offset: 0x00000490
		protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode)
		{
			throw new NotSupportedException();
		}
	}
}
