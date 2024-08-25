using System;

namespace System.Runtime.Serialization
{
	// Token: 0x02000002 RID: 2
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
	public sealed class DataContractAttribute : Attribute
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public DataContractAttribute()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002064 File Offset: 0x00000264
		public bool IsReference
		{
			get
			{
				return this.isReference;
			}
		}

		// Token: 0x04000001 RID: 1
		private bool isReference;
	}
}
