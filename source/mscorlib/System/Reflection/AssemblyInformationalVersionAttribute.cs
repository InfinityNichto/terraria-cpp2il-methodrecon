using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x020004C3 RID: 1219
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyInformationalVersionAttribute : Attribute
	{
		// Token: 0x06002365 RID: 9061 RVA: 0x00050334 File Offset: 0x0004E534
		public AssemblyInformationalVersionAttribute(string informationalVersion)
		{
			this.<InformationalVersion>k__BackingField = informationalVersion;
		}

		// Token: 0x0400135E RID: 4958
		[CompilerGenerated]
		private readonly string <InformationalVersion>k__BackingField;
	}
}
