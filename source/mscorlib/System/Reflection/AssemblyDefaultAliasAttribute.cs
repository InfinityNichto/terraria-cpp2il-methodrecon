using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x020004BF RID: 1215
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyDefaultAliasAttribute : Attribute
	{
		// Token: 0x06002361 RID: 9057 RVA: 0x000502C8 File Offset: 0x0004E4C8
		public AssemblyDefaultAliasAttribute(string defaultAlias)
		{
			this.<DefaultAlias>k__BackingField = defaultAlias;
		}

		// Token: 0x0400135A RID: 4954
		[CompilerGenerated]
		private readonly string <DefaultAlias>k__BackingField;
	}
}
