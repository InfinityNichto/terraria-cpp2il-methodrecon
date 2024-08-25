using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x020004C8 RID: 1224
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyTrademarkAttribute : Attribute
	{
		// Token: 0x06002369 RID: 9065 RVA: 0x000503A4 File Offset: 0x0004E5A4
		public AssemblyTrademarkAttribute(string trademark)
		{
			this.<Trademark>k__BackingField = trademark;
		}

		// Token: 0x04001368 RID: 4968
		[CompilerGenerated]
		private readonly string <Trademark>k__BackingField;
	}
}
