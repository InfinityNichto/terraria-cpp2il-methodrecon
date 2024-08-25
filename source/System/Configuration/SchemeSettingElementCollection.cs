using System;

namespace System.Configuration
{
	// Token: 0x020004A3 RID: 1187
	[ConfigurationCollection(typeof(SchemeSettingElement), CollectionType = 1, AddItemName = "add", ClearItemsName = "clear", RemoveItemName = "remove")]
	public sealed class SchemeSettingElementCollection : ConfigurationElementCollection
	{
		// Token: 0x06002008 RID: 8200 RVA: 0x00052A04 File Offset: 0x00050C04
		public SchemeSettingElementCollection()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x00052A18 File Offset: 0x00050C18
		public override ConfigurationElementCollectionType CollectionType
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x00052A2C File Offset: 0x00050C2C
		public SchemeSettingElement get_Item(int index)
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000782 RID: 1922
		public SchemeSettingElement this[string name]
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x00052A54 File Offset: 0x00050C54
		protected override ConfigurationElement CreateNewElement()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x00052A68 File Offset: 0x00050C68
		protected override object GetElementKey(ConfigurationElement element)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x00052A7C File Offset: 0x00050C7C
		public int IndexOf(SchemeSettingElement element)
		{
			throw new NotSupportedException();
		}
	}
}
