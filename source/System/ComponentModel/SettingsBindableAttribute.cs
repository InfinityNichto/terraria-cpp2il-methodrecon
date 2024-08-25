using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x020003B8 RID: 952
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class SettingsBindableAttribute : Attribute
	{
		// Token: 0x06001961 RID: 6497 RVA: 0x00047094 File Offset: 0x00045294
		public SettingsBindableAttribute(bool bindable)
		{
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x000470A8 File Offset: 0x000452A8
		public bool Bindable
		{
			[CompilerGenerated]
			get
			{
				return this.<Bindable>k__BackingField;
			}
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x000470BC File Offset: 0x000452BC
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			return true;
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x000470D8 File Offset: 0x000452D8
		public override int GetHashCode()
		{
			bool flag = this.<Bindable>k__BackingField;
			int num;
			return num;
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x000470F0 File Offset: 0x000452F0
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsBindableAttribute()
		{
		}

		// Token: 0x040012C8 RID: 4808
		public static readonly SettingsBindableAttribute Yes;

		// Token: 0x040012C9 RID: 4809
		public static readonly SettingsBindableAttribute No;

		// Token: 0x040012CA RID: 4810
		[CompilerGenerated]
		private readonly bool <Bindable>k__BackingField;
	}
}
