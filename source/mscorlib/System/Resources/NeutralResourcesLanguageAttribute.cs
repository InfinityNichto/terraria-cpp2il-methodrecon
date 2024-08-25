using System;
using System.Runtime.CompilerServices;

namespace System.Resources
{
	// Token: 0x020004A8 RID: 1192
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	public sealed class NeutralResourcesLanguageAttribute : Attribute
	{
		// Token: 0x060022C9 RID: 8905 RVA: 0x0004E0A8 File Offset: 0x0004C2A8
		public NeutralResourcesLanguageAttribute(string cultureName)
		{
			do
			{
				base..ctor();
			}
			while (cultureName == null);
			this.CultureName = cultureName;
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x060022CA RID: 8906 RVA: 0x0004E0C8 File Offset: 0x0004C2C8
		public string CultureName
		{
			[CompilerGenerated]
			get
			{
				return this.<CultureName>k__BackingField;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x0004E0DC File Offset: 0x0004C2DC
		public UltimateResourceFallbackLocation Location
		{
			[CompilerGenerated]
			get
			{
				return this.<Location>k__BackingField;
			}
		}

		// Token: 0x040012F7 RID: 4855
		[CompilerGenerated]
		private readonly string <CultureName>k__BackingField;

		// Token: 0x040012F8 RID: 4856
		[CompilerGenerated]
		private readonly UltimateResourceFallbackLocation <Location>k__BackingField;
	}
}
