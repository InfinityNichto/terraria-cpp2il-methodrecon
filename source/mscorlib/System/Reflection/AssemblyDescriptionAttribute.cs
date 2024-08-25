using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x020004C1 RID: 1217
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyDescriptionAttribute : Attribute
	{
		// Token: 0x06002363 RID: 9059 RVA: 0x000502F8 File Offset: 0x0004E4F8
		public AssemblyDescriptionAttribute(string description)
		{
			this.<Description>k__BackingField = description;
		}

		// Token: 0x0400135C RID: 4956
		[CompilerGenerated]
		private readonly string <Description>k__BackingField;
	}
}
