using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x020004C7 RID: 1223
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyTitleAttribute : Attribute
	{
		// Token: 0x06002368 RID: 9064 RVA: 0x00050388 File Offset: 0x0004E588
		public AssemblyTitleAttribute(string title)
		{
			this.<Title>k__BackingField = title;
		}

		// Token: 0x04001367 RID: 4967
		[CompilerGenerated]
		private readonly string <Title>k__BackingField;
	}
}
