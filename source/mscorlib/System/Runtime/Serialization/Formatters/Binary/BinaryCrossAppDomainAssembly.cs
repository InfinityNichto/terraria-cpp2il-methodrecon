using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000404 RID: 1028
	internal sealed class BinaryCrossAppDomainAssembly
	{
		// Token: 0x06001FE2 RID: 8162 RVA: 0x00046004 File Offset: 0x00044204
		internal BinaryCrossAppDomainAssembly()
		{
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00046018 File Offset: 0x00044218
		public void Read(__BinaryParser input)
		{
			int num = input.ReadInt32();
			this.assemId = num;
			int num2 = input.ReadInt32();
			this.assemblyIndex = num2;
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00046044 File Offset: 0x00044244
		public void Dump()
		{
		}

		// Token: 0x04001067 RID: 4199
		internal int assemId;

		// Token: 0x04001068 RID: 4200
		internal int assemblyIndex;
	}
}
