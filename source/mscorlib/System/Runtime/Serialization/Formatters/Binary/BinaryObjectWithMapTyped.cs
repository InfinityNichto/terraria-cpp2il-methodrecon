using System;
using System.IO;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200040D RID: 1037
	internal sealed class BinaryObjectWithMapTyped
	{
		// Token: 0x06002007 RID: 8199 RVA: 0x0004659C File Offset: 0x0004479C
		internal BinaryObjectWithMapTyped()
		{
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x000465B0 File Offset: 0x000447B0
		internal BinaryObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum)
		{
			this.binaryHeaderEnum = binaryHeaderEnum;
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x000465CC File Offset: 0x000447CC
		internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId)
		{
			this.name = name;
			this.numMembers = numMembers;
			this.memberNames = memberNames;
			this.binaryTypeEnumA = binaryTypeEnumA;
			this.typeInformationA = typeInformationA;
			this.memberAssemIds = memberAssemIds;
			this.binaryHeaderEnum = BinaryHeaderEnum.ObjectWithMapTyped;
			this.name = objectId;
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x00046618 File Offset: 0x00044818
		public void Write(__BinaryWriter sout)
		{
			BinaryWriter dataWriter = sout.dataWriter;
			BinaryHeaderEnum binaryHeaderEnum = this.binaryHeaderEnum;
			BinaryWriter dataWriter2 = sout.dataWriter;
			int num = this.objectId;
			BinaryWriter dataWriter3 = sout.dataWriter;
			string text = this.name;
			BinaryWriter dataWriter4 = sout.dataWriter;
			int num2 = this.numMembers;
			int num3 = this.numMembers;
			BinaryWriter dataWriter5 = sout.dataWriter;
			string[] array = this.memberNames;
			BinaryWriter dataWriter6 = sout.dataWriter;
			BinaryTypeEnum[] array2 = this.binaryTypeEnumA;
			BinaryTypeEnum[] array3 = this.binaryTypeEnumA;
			object[] array4 = this.typeInformationA;
			int[] array5 = this.memberAssemIds;
			int num4 = this.assemId;
			BinaryWriter dataWriter7 = sout.dataWriter;
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x000466BC File Offset: 0x000448BC
		public void Read(__BinaryParser input)
		{
			int num = input.ReadInt32();
			this.objectId = num;
			string text = input.ReadString();
			this.name = text;
			int num2 = input.ReadInt32();
			this.numMembers = num2;
			int num3 = this.numMembers;
			int num4 = this.numMembers;
			int num5 = this.numMembers;
			int num6 = this.numMembers;
			string[] array = this.memberNames;
			string text2 = input.ReadString();
			if (text2 == null || text2 != null)
			{
				BinaryTypeEnum[] array2 = this.binaryTypeEnumA;
				byte b = input.ReadByte();
				BinaryTypeEnum[] array3 = this.binaryTypeEnumA;
				int[] array4 = this.memberAssemIds;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04001087 RID: 4231
		internal BinaryHeaderEnum binaryHeaderEnum;

		// Token: 0x04001088 RID: 4232
		internal int objectId;

		// Token: 0x04001089 RID: 4233
		internal string name;

		// Token: 0x0400108A RID: 4234
		internal int numMembers;

		// Token: 0x0400108B RID: 4235
		internal string[] memberNames;

		// Token: 0x0400108C RID: 4236
		internal BinaryTypeEnum[] binaryTypeEnumA;

		// Token: 0x0400108D RID: 4237
		internal object[] typeInformationA;

		// Token: 0x0400108E RID: 4238
		internal int[] memberAssemIds;

		// Token: 0x0400108F RID: 4239
		internal int assemId;
	}
}
