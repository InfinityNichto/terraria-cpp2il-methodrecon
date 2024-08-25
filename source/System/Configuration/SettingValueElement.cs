using System;
using System.Xml;

namespace System.Configuration
{
	// Token: 0x02000493 RID: 1171
	public sealed class SettingValueElement : ConfigurationElement
	{
		// Token: 0x06001FC7 RID: 8135 RVA: 0x000525C0 File Offset: 0x000507C0
		public SettingValueElement()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x000525D4 File Offset: 0x000507D4
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x000525E8 File Offset: 0x000507E8
		// (set) Token: 0x06001FCA RID: 8138 RVA: 0x000525FC File Offset: 0x000507FC
		public XmlNode ValueXml
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

		// Token: 0x06001FCB RID: 8139 RVA: 0x00052610 File Offset: 0x00050810
		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x00052624 File Offset: 0x00050824
		protected override bool IsModified()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x00052638 File Offset: 0x00050838
		protected override void Reset(ConfigurationElement parentElement)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x0005264C File Offset: 0x0005084C
		protected override void ResetModified()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00052660 File Offset: 0x00050860
		protected override bool SerializeToXmlElement(XmlWriter writer, string elementName)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x00052674 File Offset: 0x00050874
		protected override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode)
		{
			throw new NotSupportedException();
		}
	}
}
