using System;

namespace System.Configuration
{
	// Token: 0x02000491 RID: 1169
	public sealed class SettingElementCollection : ConfigurationElementCollection
	{
		// Token: 0x06001FB5 RID: 8117 RVA: 0x00052458 File Offset: 0x00050658
		public SettingElementCollection()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x0005246C File Offset: 0x0005066C
		public override ConfigurationElementCollectionType CollectionType
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x00052480 File Offset: 0x00050680
		protected override string ElementName
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x00052494 File Offset: 0x00050694
		public void Add(SettingElement element)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x000524A8 File Offset: 0x000506A8
		public void Clear()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x000524BC File Offset: 0x000506BC
		protected override ConfigurationElement CreateNewElement()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x000524D0 File Offset: 0x000506D0
		public SettingElement Get(string elementKey)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x000524E4 File Offset: 0x000506E4
		protected override object GetElementKey(ConfigurationElement element)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x000524F8 File Offset: 0x000506F8
		public void Remove(SettingElement element)
		{
			throw new NotSupportedException();
		}
	}
}
