using System;

namespace System.Runtime.Versioning
{
	// Token: 0x020003C2 RID: 962
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	internal sealed class NonVersionableAttribute : Attribute
	{
		// Token: 0x06001EBB RID: 7867 RVA: 0x00043458 File Offset: 0x00041658
		public NonVersionableAttribute()
		{
		}
	}
}
