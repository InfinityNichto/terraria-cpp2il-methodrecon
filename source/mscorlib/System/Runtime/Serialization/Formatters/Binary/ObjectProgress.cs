using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000414 RID: 1044
	internal sealed class ObjectProgress
	{
		// Token: 0x0600202B RID: 8235 RVA: 0x00046DD0 File Offset: 0x00044FD0
		internal ObjectProgress()
		{
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00046DEC File Offset: 0x00044FEC
		internal void Init()
		{
			this.pr.Init();
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00046E04 File Offset: 0x00045004
		internal void ArrayCountIncrement(int value)
		{
			int num = this.count;
			this.count = num;
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x00046E20 File Offset: 0x00045020
		internal bool GetNext([Out] BinaryTypeEnum outBinaryTypeEnum, [Out] object outTypeInformation)
		{
			InternalObjectTypeE internalObjectTypeE = this.objectTypeEnum;
			int num = this.numItems;
			BinaryTypeEnum binaryTypeEnum = this.binaryTypeEnum;
			outBinaryTypeEnum.value__ = (int)binaryTypeEnum;
			object obj = this.typeInformation;
			int num2 = this.count;
			if (num2 == 0)
			{
			}
			this.count = num2;
			int num3 = this.memberLength;
			if (this.isInitial)
			{
				BinaryTypeEnum[] array = this.binaryTypeEnumA;
				outBinaryTypeEnum.value__ = num2;
				object[] array2 = this.typeInformationA;
				if (num2 == 0)
				{
				}
				string[] array3 = this.memberNames;
				Type[] array4 = this.memberTypes;
				this.name = array3;
				this.count = num2;
				this.dtType = array3;
				return;
			}
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x00046EC0 File Offset: 0x000450C0
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectProgress()
		{
		}

		// Token: 0x040010A8 RID: 4264
		internal static int opRecordIdCount;

		// Token: 0x040010A9 RID: 4265
		internal bool isInitial;

		// Token: 0x040010AA RID: 4266
		internal int count;

		// Token: 0x040010AB RID: 4267
		internal BinaryTypeEnum expectedType = BinaryTypeEnum.ObjectUrt;

		// Token: 0x040010AC RID: 4268
		internal object expectedTypeInformation;

		// Token: 0x040010AD RID: 4269
		internal string name;

		// Token: 0x040010AE RID: 4270
		internal InternalObjectTypeE objectTypeEnum;

		// Token: 0x040010AF RID: 4271
		internal InternalMemberTypeE memberTypeEnum;

		// Token: 0x040010B0 RID: 4272
		internal InternalMemberValueE memberValueEnum;

		// Token: 0x040010B1 RID: 4273
		internal Type dtType;

		// Token: 0x040010B2 RID: 4274
		internal int numItems;

		// Token: 0x040010B3 RID: 4275
		internal BinaryTypeEnum binaryTypeEnum;

		// Token: 0x040010B4 RID: 4276
		internal object typeInformation;

		// Token: 0x040010B5 RID: 4277
		internal int nullCount;

		// Token: 0x040010B6 RID: 4278
		internal int memberLength;

		// Token: 0x040010B7 RID: 4279
		internal BinaryTypeEnum[] binaryTypeEnumA;

		// Token: 0x040010B8 RID: 4280
		internal object[] typeInformationA;

		// Token: 0x040010B9 RID: 4281
		internal string[] memberNames;

		// Token: 0x040010BA RID: 4282
		internal Type[] memberTypes;

		// Token: 0x040010BB RID: 4283
		internal ParseRecord pr;
	}
}
