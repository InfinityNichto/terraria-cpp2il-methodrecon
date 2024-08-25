using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x020004C0 RID: 1216
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyDelaySignAttribute : Attribute
	{
		// Token: 0x06002362 RID: 9058 RVA: 0x000502E4 File Offset: 0x0004E4E4
		public AssemblyDelaySignAttribute(bool delaySign)
		{
		}

		// Token: 0x0400135B RID: 4955
		[CompilerGenerated]
		private readonly bool <DelaySign>k__BackingField;
	}
}
