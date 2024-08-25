using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x020004C6 RID: 1222
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyProductAttribute : Attribute
	{
		// Token: 0x06002367 RID: 9063 RVA: 0x0005036C File Offset: 0x0004E56C
		public AssemblyProductAttribute(string product)
		{
			this.<Product>k__BackingField = product;
		}

		// Token: 0x04001366 RID: 4966
		[CompilerGenerated]
		private readonly string <Product>k__BackingField;
	}
}
