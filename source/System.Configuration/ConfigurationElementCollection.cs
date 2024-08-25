using System;
using System.Diagnostics;

namespace System.Configuration
{
	// Token: 0x02000008 RID: 8
	[DebuggerDisplay("Count = {Count}")]
	public abstract class ConfigurationElementCollection : ConfigurationElement
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002168 File Offset: 0x00000368
		public virtual ConfigurationElementCollectionType CollectionType
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000217C File Offset: 0x0000037C
		protected virtual string ElementName
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002190 File Offset: 0x00000390
		protected virtual bool ThrowOnDuplicate
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06000012 RID: 18
		protected abstract ConfigurationElement CreateNewElement();

		// Token: 0x06000013 RID: 19
		protected abstract object GetElementKey(ConfigurationElement element);
	}
}
