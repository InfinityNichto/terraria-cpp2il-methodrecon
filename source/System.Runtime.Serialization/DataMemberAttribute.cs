using System;

namespace System.Runtime.Serialization
{
	// Token: 0x02000003 RID: 3
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class DataMemberAttribute : Attribute
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002078 File Offset: 0x00000278
		public DataMemberAttribute()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002094 File Offset: 0x00000294
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000020A8 File Offset: 0x000002A8
		public int Order
		{
			get
			{
				return this.order;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020BC File Offset: 0x000002BC
		public bool IsRequired
		{
			get
			{
				return this.isRequired;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000020D0 File Offset: 0x000002D0
		public bool EmitDefaultValue
		{
			get
			{
				return this.emitDefaultValue;
			}
		}

		// Token: 0x04000002 RID: 2
		private string name;

		// Token: 0x04000003 RID: 3
		private int order;

		// Token: 0x04000004 RID: 4
		private bool isRequired;

		// Token: 0x04000005 RID: 5
		private bool emitDefaultValue = true;
	}
}
