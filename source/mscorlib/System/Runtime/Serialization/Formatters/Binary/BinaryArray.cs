using System;
using System.IO;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200040E RID: 1038
	internal sealed class BinaryArray
	{
		// Token: 0x0600200C RID: 8204 RVA: 0x00046788 File Offset: 0x00044988
		internal BinaryArray()
		{
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x0004679C File Offset: 0x0004499C
		internal BinaryArray(BinaryHeaderEnum binaryHeaderEnum)
		{
			this.binaryHeaderEnum = binaryHeaderEnum;
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x000467B8 File Offset: 0x000449B8
		internal void Set(int objectId, int rank, int[] lengthA, int[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId)
		{
			this.objectId = objectId;
			this.lengthA = rank;
			this.lengthA = lengthA;
			this.lowerBoundA = lowerBoundA;
			this.binaryTypeEnum = binaryTypeEnum;
			this.typeInformation = typeInformation;
			this.binaryHeaderEnum = BinaryHeaderEnum.Array;
			if (binaryArrayTypeEnum == BinaryArrayTypeEnum.Single && binaryTypeEnum == BinaryTypeEnum.Primitive)
			{
				return;
			}
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x0004680C File Offset: 0x00044A0C
		public void Write(__BinaryWriter sout)
		{
			BinaryHeaderEnum binaryHeaderEnum = this.binaryHeaderEnum;
			BinaryWriter dataWriter = sout.dataWriter;
			BinaryWriter dataWriter2 = sout.dataWriter;
			int num = this.objectId;
			BinaryWriter dataWriter3 = sout.dataWriter;
			int[] array = this.lengthA;
			object obj = this.typeInformation;
			BinaryWriter dataWriter4 = sout.dataWriter;
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x00046924 File Offset: 0x00044B24
		public void Read(__BinaryParser input)
		{
			BinaryHeaderEnum binaryHeaderEnum = this.binaryHeaderEnum;
			int num = input.ReadInt32();
			this.objectId = num;
			int num2 = 1;
			int num3 = input.ReadInt32();
			this.rank = num2;
			byte b = input.ReadByte();
		}

		// Token: 0x04001090 RID: 4240
		internal int objectId;

		// Token: 0x04001091 RID: 4241
		internal int rank;

		// Token: 0x04001092 RID: 4242
		internal int[] lengthA;

		// Token: 0x04001093 RID: 4243
		internal int[] lowerBoundA;

		// Token: 0x04001094 RID: 4244
		internal BinaryTypeEnum binaryTypeEnum;

		// Token: 0x04001095 RID: 4245
		internal object typeInformation;

		// Token: 0x04001096 RID: 4246
		internal int assemId;

		// Token: 0x04001097 RID: 4247
		private BinaryHeaderEnum binaryHeaderEnum;

		// Token: 0x04001098 RID: 4248
		internal BinaryArrayTypeEnum binaryArrayTypeEnum;
	}
}
