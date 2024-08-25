using System;
using System.Runtime.CompilerServices;

namespace System.Resources
{
	// Token: 0x020004AD RID: 1197
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	public sealed class SatelliteContractVersionAttribute : Attribute
	{
		// Token: 0x060022E1 RID: 8929 RVA: 0x0004E5E8 File Offset: 0x0004C7E8
		public SatelliteContractVersionAttribute(string version)
		{
			do
			{
				base..ctor();
			}
			while (version == null);
			this.Version = version;
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060022E2 RID: 8930 RVA: 0x0004E608 File Offset: 0x0004C808
		public string Version
		{
			[CompilerGenerated]
			get
			{
				return this.<Version>k__BackingField;
			}
		}

		// Token: 0x0400131C RID: 4892
		[CompilerGenerated]
		private readonly string <Version>k__BackingField;
	}
}
