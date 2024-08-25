using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x02000367 RID: 871
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DefaultBindingPropertyAttribute : Attribute
	{
		// Token: 0x060016B7 RID: 5815 RVA: 0x00042288 File Offset: 0x00040488
		public DefaultBindingPropertyAttribute()
		{
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x0004229C File Offset: 0x0004049C
		public DefaultBindingPropertyAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x000422B8 File Offset: 0x000404B8
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x000422CC File Offset: 0x000404CC
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			string text = this.<Name>k__BackingField;
			bool flag;
			return flag;
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x000422E8 File Offset: 0x000404E8
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x000422FC File Offset: 0x000404FC
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultBindingPropertyAttribute()
		{
		}

		// Token: 0x040011F8 RID: 4600
		[CompilerGenerated]
		private readonly string <Name>k__BackingField;

		// Token: 0x040011F9 RID: 4601
		public static readonly DefaultBindingPropertyAttribute Default;
	}
}
