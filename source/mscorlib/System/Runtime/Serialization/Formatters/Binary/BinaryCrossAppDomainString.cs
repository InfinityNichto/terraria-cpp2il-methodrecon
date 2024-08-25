using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000409 RID: 1033
	internal sealed class BinaryCrossAppDomainString
	{
		// Token: 0x06001FF6 RID: 8182 RVA: 0x00046300 File Offset: 0x00044500
		internal BinaryCrossAppDomainString()
		{
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x00046314 File Offset: 0x00044514
		public void Read(__BinaryParser input)
		{
			int num = input.ReadInt32();
			this.objectId = num;
			int num2 = input.ReadInt32();
			this.value = num2;
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x00046340 File Offset: 0x00044540
		public void Dump()
		{
		}

		// Token: 0x0400107C RID: 4220
		internal int objectId;

		// Token: 0x0400107D RID: 4221
		internal int value;
	}
}
