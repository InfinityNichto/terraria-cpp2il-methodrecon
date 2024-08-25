using System;
using System.IO;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000403 RID: 1027
	internal sealed class BinaryAssembly
	{
		// Token: 0x06001FDD RID: 8157 RVA: 0x00045F64 File Offset: 0x00044164
		internal BinaryAssembly()
		{
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x00045F78 File Offset: 0x00044178
		internal void Set(int assemId, string assemblyString)
		{
			this.assemId = assemId;
			this.assemblyString = assemblyString;
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x00045F94 File Offset: 0x00044194
		public void Write(__BinaryWriter sout)
		{
			BinaryWriter dataWriter = sout.dataWriter;
			BinaryWriter dataWriter2 = sout.dataWriter;
			int num = this.assemId;
			BinaryWriter dataWriter3 = sout.dataWriter;
			string text = this.assemblyString;
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x00045FC8 File Offset: 0x000441C8
		public void Read(__BinaryParser input)
		{
			int num = input.ReadInt32();
			this.assemId = num;
			string text = input.ReadString();
			this.assemblyString = text;
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x00045FF4 File Offset: 0x000441F4
		public void Dump()
		{
		}

		// Token: 0x04001065 RID: 4197
		internal int assemId;

		// Token: 0x04001066 RID: 4198
		internal string assemblyString;
	}
}
