using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x020004BC RID: 1212
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyConfigurationAttribute : Attribute
	{
		// Token: 0x0600235F RID: 9055 RVA: 0x00050298 File Offset: 0x0004E498
		public AssemblyConfigurationAttribute(string configuration)
		{
		}

		// Token: 0x04001355 RID: 4949
		[CompilerGenerated]
		private readonly string <Configuration>k__BackingField;
	}
}
