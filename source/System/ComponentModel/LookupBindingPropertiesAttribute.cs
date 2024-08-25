using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x020003A0 RID: 928
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class LookupBindingPropertiesAttribute : Attribute
	{
		// Token: 0x0600181D RID: 6173 RVA: 0x00044098 File Offset: 0x00042298
		public LookupBindingPropertiesAttribute()
		{
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x000440AC File Offset: 0x000422AC
		public LookupBindingPropertiesAttribute(string dataSource, string displayMember, string valueMember, string lookupMember)
		{
			this.DataSource = dataSource;
			this.DisplayMember = displayMember;
			this.ValueMember = valueMember;
			this.LookupMember = lookupMember;
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x000440DC File Offset: 0x000422DC
		public string DataSource
		{
			[CompilerGenerated]
			get
			{
				return this.<DataSource>k__BackingField;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x000440F0 File Offset: 0x000422F0
		public string DisplayMember
		{
			[CompilerGenerated]
			get
			{
				return this.<DisplayMember>k__BackingField;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x00044104 File Offset: 0x00042304
		public string ValueMember
		{
			[CompilerGenerated]
			get
			{
				return this.<ValueMember>k__BackingField;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001822 RID: 6178 RVA: 0x00044118 File Offset: 0x00042318
		public string LookupMember
		{
			[CompilerGenerated]
			get
			{
				return this.<LookupMember>k__BackingField;
			}
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x0004412C File Offset: 0x0004232C
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				string text = this.<DataSource>k__BackingField;
				string text2 = this.<DisplayMember>k__BackingField;
				string text3 = this.<ValueMember>k__BackingField;
				string text4 = this.<LookupMember>k__BackingField;
				bool flag;
				return flag;
			}
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x00044160 File Offset: 0x00042360
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x00044174 File Offset: 0x00042374
		// Note: this type is marked as 'beforefieldinit'.
		static LookupBindingPropertiesAttribute()
		{
		}

		// Token: 0x04001253 RID: 4691
		[CompilerGenerated]
		private readonly string <DataSource>k__BackingField;

		// Token: 0x04001254 RID: 4692
		[CompilerGenerated]
		private readonly string <DisplayMember>k__BackingField;

		// Token: 0x04001255 RID: 4693
		[CompilerGenerated]
		private readonly string <ValueMember>k__BackingField;

		// Token: 0x04001256 RID: 4694
		[CompilerGenerated]
		private readonly string <LookupMember>k__BackingField;

		// Token: 0x04001257 RID: 4695
		public static readonly LookupBindingPropertiesAttribute Default;
	}
}
