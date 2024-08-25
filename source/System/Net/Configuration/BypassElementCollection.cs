using System;
using System.Configuration;

namespace System.Net.Configuration
{
	// Token: 0x02000465 RID: 1125
	[ConfigurationCollection(typeof(BypassElement))]
	public sealed class BypassElementCollection : ConfigurationElementCollection
	{
		// Token: 0x06001E80 RID: 7808 RVA: 0x00050C3C File Offset: 0x0004EE3C
		public BypassElementCollection()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x00050C50 File Offset: 0x0004EE50
		public BypassElement get_Item(int index)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x00050C64 File Offset: 0x0004EE64
		public void set_Item(int index, BypassElement value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x170006E6 RID: 1766
		public BypassElement this[string name]
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

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x00050CA0 File Offset: 0x0004EEA0
		protected override bool ThrowOnDuplicate
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x00050CB4 File Offset: 0x0004EEB4
		public void Add(BypassElement element)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x00050CC8 File Offset: 0x0004EEC8
		public void Clear()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x00050CDC File Offset: 0x0004EEDC
		protected override ConfigurationElement CreateNewElement()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x00050CF0 File Offset: 0x0004EEF0
		protected override object GetElementKey(ConfigurationElement element)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x00050D04 File Offset: 0x0004EF04
		public int IndexOf(BypassElement element)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x00050D18 File Offset: 0x0004EF18
		public void Remove(BypassElement element)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x00050D2C File Offset: 0x0004EF2C
		public void Remove(string name)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x00050D40 File Offset: 0x0004EF40
		public void RemoveAt(int index)
		{
			throw new NotSupportedException();
		}
	}
}
