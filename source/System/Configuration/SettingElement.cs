using System;

namespace System.Configuration
{
	// Token: 0x02000492 RID: 1170
	public sealed class SettingElement : ConfigurationElement
	{
		// Token: 0x06001FBE RID: 8126 RVA: 0x0005250C File Offset: 0x0005070C
		public SettingElement()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x00052520 File Offset: 0x00050720
		public SettingElement(string name, SettingsSerializeAs serializeAs)
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x00052534 File Offset: 0x00050734
		// (set) Token: 0x06001FC1 RID: 8129 RVA: 0x00052548 File Offset: 0x00050748
		public string Name
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

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x0005255C File Offset: 0x0005075C
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x00052570 File Offset: 0x00050770
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x00052584 File Offset: 0x00050784
		public SettingsSerializeAs SerializeAs
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

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x00052598 File Offset: 0x00050798
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x000525AC File Offset: 0x000507AC
		public SettingValueElement Value
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
	}
}
