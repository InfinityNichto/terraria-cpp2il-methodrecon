using System;
using System.IO;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000408 RID: 1032
	internal sealed class BinaryObjectString
	{
		// Token: 0x06001FF1 RID: 8177 RVA: 0x00046260 File Offset: 0x00044460
		internal BinaryObjectString()
		{
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x00046274 File Offset: 0x00044474
		internal void Set(int objectId, string value)
		{
			this.objectId = objectId;
			this.value = value;
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x00046290 File Offset: 0x00044490
		public void Write(__BinaryWriter sout)
		{
			BinaryWriter dataWriter = sout.dataWriter;
			BinaryWriter dataWriter2 = sout.dataWriter;
			int num = this.objectId;
			BinaryWriter dataWriter3 = sout.dataWriter;
			string text = this.value;
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x000462C4 File Offset: 0x000444C4
		public void Read(__BinaryParser input)
		{
			int num = input.ReadInt32();
			this.objectId = num;
			string text = input.ReadString();
			this.value = text;
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x000462F0 File Offset: 0x000444F0
		public void Dump()
		{
		}

		// Token: 0x0400107A RID: 4218
		internal int objectId;

		// Token: 0x0400107B RID: 4219
		internal string value;
	}
}
