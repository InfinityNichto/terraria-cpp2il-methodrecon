using System;
using System.IO;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200040B RID: 1035
	internal sealed class MemberPrimitiveTyped
	{
		// Token: 0x06001FFC RID: 8188 RVA: 0x00046390 File Offset: 0x00044590
		internal MemberPrimitiveTyped()
		{
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x000463A4 File Offset: 0x000445A4
		internal void Set(InternalPrimitiveTypeE primitiveTypeEnum, object value)
		{
			this.primitiveTypeEnum = primitiveTypeEnum;
			this.value = value;
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x000463C0 File Offset: 0x000445C0
		public void Write(__BinaryWriter sout)
		{
			BinaryWriter dataWriter = sout.dataWriter;
			BinaryWriter dataWriter2 = sout.dataWriter;
			InternalPrimitiveTypeE internalPrimitiveTypeE = this.primitiveTypeEnum;
			InternalPrimitiveTypeE internalPrimitiveTypeE2 = this.primitiveTypeEnum;
			object obj = this.value;
			sout.WriteValue(internalPrimitiveTypeE2, obj);
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x000463FC File Offset: 0x000445FC
		public void Read(__BinaryParser input)
		{
			long num = 0L;
			byte b = input.ReadByte();
			this.primitiveTypeEnum = (InternalPrimitiveTypeE)num;
			object obj;
			this.value = obj;
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x00046420 File Offset: 0x00044620
		public void Dump()
		{
		}

		// Token: 0x0400107F RID: 4223
		internal InternalPrimitiveTypeE primitiveTypeEnum;

		// Token: 0x04001080 RID: 4224
		internal object value;
	}
}
