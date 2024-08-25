using System;

namespace System.Configuration
{
	// Token: 0x0200000A RID: 10
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class ConfigurationCollectionAttribute : Attribute
	{
		// Token: 0x06000014 RID: 20 RVA: 0x000021A4 File Offset: 0x000003A4
		public ConfigurationCollectionAttribute(Type itemType)
		{
		}

		// Token: 0x17000005 RID: 5
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000021B4 File Offset: 0x000003B4
		public string AddItemName
		{
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000006 RID: 6
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000021C8 File Offset: 0x000003C8
		public string ClearItemsName
		{
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000007 RID: 7
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000021DC File Offset: 0x000003DC
		public ConfigurationElementCollectionType CollectionType
		{
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000008 RID: 8
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000021F0 File Offset: 0x000003F0
		public string RemoveItemName
		{
			set
			{
				throw new NotSupportedException();
			}
		}
	}
}
