using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x020004C2 RID: 1218
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyFileVersionAttribute : Attribute
	{
		// Token: 0x06002364 RID: 9060 RVA: 0x00050314 File Offset: 0x0004E514
		public AssemblyFileVersionAttribute(string version)
		{
			do
			{
				base..ctor();
			}
			while (version == null);
			this.<Version>k__BackingField = version;
		}

		// Token: 0x0400135D RID: 4957
		[CompilerGenerated]
		private readonly string <Version>k__BackingField;
	}
}
