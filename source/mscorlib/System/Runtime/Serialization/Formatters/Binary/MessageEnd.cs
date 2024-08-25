using System;
using System.IO;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000412 RID: 1042
	internal sealed class MessageEnd
	{
		// Token: 0x06002021 RID: 8225 RVA: 0x00046C04 File Offset: 0x00044E04
		internal MessageEnd()
		{
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00046C18 File Offset: 0x00044E18
		public void Write(__BinaryWriter sout)
		{
			BinaryWriter dataWriter = sout.dataWriter;
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x00046C2C File Offset: 0x00044E2C
		public void Read(__BinaryParser input)
		{
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00046C3C File Offset: 0x00044E3C
		public void Dump()
		{
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x00046C4C File Offset: 0x00044E4C
		public void Dump(Stream sout)
		{
		}
	}
}
