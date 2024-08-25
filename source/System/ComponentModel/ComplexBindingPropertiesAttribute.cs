using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x0200035A RID: 858
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ComplexBindingPropertiesAttribute : Attribute
	{
		// Token: 0x06001665 RID: 5733 RVA: 0x00041728 File Offset: 0x0003F928
		public ComplexBindingPropertiesAttribute()
		{
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x0004173C File Offset: 0x0003F93C
		public ComplexBindingPropertiesAttribute(string dataSource)
		{
			this.DataSource = dataSource;
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00041758 File Offset: 0x0003F958
		public ComplexBindingPropertiesAttribute(string dataSource, string dataMember)
		{
			this.DataSource = dataSource;
			this.DataMember = dataMember;
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001668 RID: 5736 RVA: 0x0004177C File Offset: 0x0003F97C
		public string DataSource
		{
			[CompilerGenerated]
			get
			{
				return this.<DataSource>k__BackingField;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x00041790 File Offset: 0x0003F990
		public string DataMember
		{
			[CompilerGenerated]
			get
			{
				return this.<DataMember>k__BackingField;
			}
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x000417A4 File Offset: 0x0003F9A4
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				string text = this.<DataSource>k__BackingField;
				string text2 = this.<DataMember>k__BackingField;
				bool flag;
				return flag;
			}
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x000417C8 File Offset: 0x0003F9C8
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x000417DC File Offset: 0x0003F9DC
		// Note: this type is marked as 'beforefieldinit'.
		static ComplexBindingPropertiesAttribute()
		{
		}

		// Token: 0x040011DE RID: 4574
		[CompilerGenerated]
		private readonly string <DataSource>k__BackingField;

		// Token: 0x040011DF RID: 4575
		[CompilerGenerated]
		private readonly string <DataMember>k__BackingField;

		// Token: 0x040011E0 RID: 4576
		public static readonly ComplexBindingPropertiesAttribute Default;
	}
}
