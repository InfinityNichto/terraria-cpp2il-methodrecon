using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x020004BB RID: 1211
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyCompanyAttribute : Attribute
	{
		// Token: 0x0600235E RID: 9054 RVA: 0x0005027C File Offset: 0x0004E47C
		public AssemblyCompanyAttribute(string company)
		{
			this.<Company>k__BackingField = company;
		}

		// Token: 0x04001354 RID: 4948
		[CompilerGenerated]
		private readonly string <Company>k__BackingField;
	}
}
