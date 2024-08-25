using System;
using System.Runtime.CompilerServices;

namespace NaughtyAttributes
{
	// Token: 0x0200001D RID: 29
	public abstract class MetaAttribute : NaughtyAttribute
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000027D0 File Offset: 0x000009D0
		// (set) Token: 0x06000055 RID: 85 RVA: 0x000027E4 File Offset: 0x000009E4
		public int Order
		{
			[CompilerGenerated]
			get
			{
				return this.<Order>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Order>k__BackingField = value;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000027F8 File Offset: 0x000009F8
		protected MetaAttribute()
		{
		}

		// Token: 0x0400002C RID: 44
		[CompilerGenerated]
		private int <Order>k__BackingField;
	}
}
