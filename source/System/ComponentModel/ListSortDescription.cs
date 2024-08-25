using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x0200039D RID: 925
	public class ListSortDescription
	{
		// Token: 0x06001804 RID: 6148 RVA: 0x00043F24 File Offset: 0x00042124
		public ListSortDescription(PropertyDescriptor property, ListSortDirection direction)
		{
			this.PropertyDescriptor = property;
			this.SortDirection = direction;
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x00043F48 File Offset: 0x00042148
		// (set) Token: 0x06001806 RID: 6150 RVA: 0x00043F5C File Offset: 0x0004215C
		public PropertyDescriptor PropertyDescriptor
		{
			[CompilerGenerated]
			get
			{
				return this.<PropertyDescriptor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PropertyDescriptor>k__BackingField = value;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x00043F70 File Offset: 0x00042170
		// (set) Token: 0x06001808 RID: 6152 RVA: 0x00043F84 File Offset: 0x00042184
		public ListSortDirection SortDirection
		{
			[CompilerGenerated]
			get
			{
				return this.<SortDirection>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SortDirection>k__BackingField = value;
			}
		}

		// Token: 0x0400124D RID: 4685
		[CompilerGenerated]
		private PropertyDescriptor <PropertyDescriptor>k__BackingField;

		// Token: 0x0400124E RID: 4686
		[CompilerGenerated]
		private ListSortDirection <SortDirection>k__BackingField;
	}
}
