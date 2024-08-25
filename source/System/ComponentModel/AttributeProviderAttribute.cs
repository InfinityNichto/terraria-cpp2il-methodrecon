using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x0200034C RID: 844
	[AttributeUsage(AttributeTargets.Property)]
	public class AttributeProviderAttribute : Attribute
	{
		// Token: 0x060015F4 RID: 5620 RVA: 0x00040E04 File Offset: 0x0003F004
		public AttributeProviderAttribute(string typeName)
		{
			do
			{
				base..ctor();
			}
			while (typeName == null);
			this.TypeName = typeName;
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00040E24 File Offset: 0x0003F024
		public AttributeProviderAttribute(string typeName, string propertyName)
		{
			do
			{
				base..ctor();
				if (typeName == null)
				{
					return;
				}
			}
			while (propertyName == null);
			this.TypeName = typeName;
			this.PropertyName = propertyName;
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00040E4C File Offset: 0x0003F04C
		public AttributeProviderAttribute(Type type)
		{
			if (!true)
			{
			}
			this.TypeName = type;
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x00040E6C File Offset: 0x0003F06C
		public string TypeName
		{
			[CompilerGenerated]
			get
			{
				return this.<TypeName>k__BackingField;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x00040E80 File Offset: 0x0003F080
		public string PropertyName
		{
			[CompilerGenerated]
			get
			{
				return this.<PropertyName>k__BackingField;
			}
		}

		// Token: 0x040011BC RID: 4540
		[CompilerGenerated]
		private readonly string <TypeName>k__BackingField;

		// Token: 0x040011BD RID: 4541
		[CompilerGenerated]
		private readonly string <PropertyName>k__BackingField;
	}
}
