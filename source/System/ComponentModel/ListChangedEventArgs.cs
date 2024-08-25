using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x0200039A RID: 922
	public class ListChangedEventArgs : EventArgs
	{
		// Token: 0x060017F8 RID: 6136 RVA: 0x00043DC4 File Offset: 0x00041FC4
		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex)
		{
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00043DD4 File Offset: 0x00041FD4
		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc)
		{
			this.PropertyDescriptor = propDesc;
			this.OldIndex = newIndex;
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00043DF0 File Offset: 0x00041FF0
		public ListChangedEventArgs(ListChangedType listChangedType, PropertyDescriptor propDesc)
		{
			if (!true)
			{
			}
			base..ctor();
			this.ListChangedType = listChangedType;
			this.PropertyDescriptor = propDesc;
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x00043E14 File Offset: 0x00042014
		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, int oldIndex)
		{
			if (!true)
			{
			}
			base..ctor();
			this.ListChangedType = listChangedType;
			this.OldIndex = newIndex;
			this.OldIndex = oldIndex;
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060017FC RID: 6140 RVA: 0x00043E40 File Offset: 0x00042040
		public ListChangedType ListChangedType
		{
			[CompilerGenerated]
			get
			{
				return this.<ListChangedType>k__BackingField;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x00043E54 File Offset: 0x00042054
		public int NewIndex
		{
			[CompilerGenerated]
			get
			{
				return this.<NewIndex>k__BackingField;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x00043E68 File Offset: 0x00042068
		public int OldIndex
		{
			[CompilerGenerated]
			get
			{
				return this.<OldIndex>k__BackingField;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x00043E7C File Offset: 0x0004207C
		public PropertyDescriptor PropertyDescriptor
		{
			[CompilerGenerated]
			get
			{
				return this.<PropertyDescriptor>k__BackingField;
			}
		}

		// Token: 0x04001240 RID: 4672
		[CompilerGenerated]
		private readonly ListChangedType <ListChangedType>k__BackingField;

		// Token: 0x04001241 RID: 4673
		[CompilerGenerated]
		private readonly int <NewIndex>k__BackingField;

		// Token: 0x04001242 RID: 4674
		[CompilerGenerated]
		private readonly int <OldIndex>k__BackingField;

		// Token: 0x04001243 RID: 4675
		[CompilerGenerated]
		private readonly PropertyDescriptor <PropertyDescriptor>k__BackingField;
	}
}
