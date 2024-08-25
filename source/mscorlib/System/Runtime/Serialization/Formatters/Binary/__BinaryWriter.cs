using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000417 RID: 1047
	internal sealed class __BinaryWriter
	{
		// Token: 0x0600204D RID: 8269 RVA: 0x000472E8 File Offset: 0x000454E8
		internal __BinaryWriter(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle)
		{
			this.sout = sout;
			this.formatterTypeStyle = formatterTypeStyle;
			this.objectWriter = objectWriter;
			Encoding utf = Encoding.UTF8;
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x00047324 File Offset: 0x00045524
		internal void WriteBegin()
		{
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x00047334 File Offset: 0x00045534
		internal void WriteEnd()
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x00047348 File Offset: 0x00045548
		internal void WriteBoolean(bool value)
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x0004735C File Offset: 0x0004555C
		internal void WriteByte(byte value)
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00047370 File Offset: 0x00045570
		private void WriteBytes(byte[] value)
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x00047384 File Offset: 0x00045584
		private void WriteBytes(byte[] byteA, int offset, int size)
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00047398 File Offset: 0x00045598
		internal void WriteChar(char value)
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x000473AC File Offset: 0x000455AC
		internal void WriteChars(char[] value)
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x000473C0 File Offset: 0x000455C0
		internal void WriteDecimal(decimal value)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x000473E0 File Offset: 0x000455E0
		internal void WriteSingle(float value)
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x000473F4 File Offset: 0x000455F4
		internal void WriteDouble(double value)
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x00047408 File Offset: 0x00045608
		internal void WriteInt16(short value)
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x0004741C File Offset: 0x0004561C
		internal void WriteInt32(int value)
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x00047430 File Offset: 0x00045630
		internal void WriteInt64(long value)
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x00047444 File Offset: 0x00045644
		internal void WriteSByte(sbyte value)
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x00047458 File Offset: 0x00045658
		internal void WriteString(string value)
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x0004746C File Offset: 0x0004566C
		internal void WriteTimeSpan(TimeSpan value)
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x00047480 File Offset: 0x00045680
		internal void WriteDateTime(DateTime value)
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x00047494 File Offset: 0x00045694
		internal void WriteUInt16(ushort value)
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x000474A8 File Offset: 0x000456A8
		internal void WriteUInt32(uint value)
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x000474BC File Offset: 0x000456BC
		internal void WriteUInt64(ulong value)
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x000474D0 File Offset: 0x000456D0
		internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x000474E0 File Offset: 0x000456E0
		internal void WriteSerializationHeaderEnd()
		{
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000474F4 File Offset: 0x000456F4
		internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion)
		{
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x00047504 File Offset: 0x00045704
		internal void WriteMethodCall()
		{
			if (this.binaryMethodCall == null)
			{
			}
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x0004751C File Offset: 0x0004571C
		internal void WriteMethodReturn()
		{
			if (this.binaryMethodReturn == null)
			{
			}
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x00047534 File Offset: 0x00045734
		internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, string[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos)
		{
			this.InternalWriteItemNull();
			long niobjectId = nameInfo.NIobjectId;
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x000475B0 File Offset: 0x000457B0
		internal void WriteObjectString(int objectId, string value)
		{
			this.InternalWriteItemNull();
			if (this.binaryObjectString == null)
			{
			}
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x000475CC File Offset: 0x000457CC
		internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array)
		{
			this.InternalWriteItemNull();
			if (lowerBound != 0)
			{
				return;
			}
			long num = 0L;
			Type nitype = arrayElemTypeNameInfo.NItype;
			string niname = arrayElemTypeNameInfo.NIname;
			ObjectWriter objectWriter = this.objectWriter;
			if (this.binaryArray == null)
			{
			}
			long niobjectId = arrayNameInfo.NIobjectId;
			BinaryTypeEnum binaryTypeEnum;
			if (num == 0L && binaryTypeEnum == BinaryTypeEnum.Primitive)
			{
				return;
			}
			InternalPrimitiveTypeE niprimitiveTypeEnum = arrayElemTypeNameInfo.NIprimitiveTypeEnum;
			if (16 == 0)
			{
			}
			if (lowerBound != 0)
			{
				return;
			}
			InternalPrimitiveTypeE niprimitiveTypeEnum2 = arrayElemTypeNameInfo.NIprimitiveTypeEnum;
			if (array != null && array == null)
			{
				return;
			}
			BinaryWriter binaryWriter = this.dataWriter;
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x00047664 File Offset: 0x00045864
		private void WriteArrayAsBytes(Array array, int typeLength)
		{
			this.InternalWriteItemNull();
			if (this.byteBuffer == null)
			{
				int num = this.chunkSize;
			}
			int length = array.Length;
			int num2 = this.chunkSize;
			long num3 = 0L;
			int length2 = array.Length;
			int num4 = Math.Min(0, (int)num3);
			byte[] array2 = this.byteBuffer;
			long num5 = 0L;
			bool flag = Buffer.InternalBlockCopy(array, (int)num3, array2, (int)num5, num2);
			if (!false)
			{
			}
			if (!false)
			{
				byte[] array3 = this.byteBuffer;
				byte[] array4 = this.byteBuffer;
			}
			BinaryWriter binaryWriter = this.dataWriter;
			byte[] array5 = this.byteBuffer;
			int length3 = array.Length;
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x000476F8 File Offset: 0x000458F8
		internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound)
		{
			this.InternalWriteItemNull();
			if (lowerBound != 0)
			{
				return;
			}
			Type nitype = arrayElemTypeNameInfo.NItype;
			string niname = arrayElemTypeNameInfo.NIname;
			ObjectWriter objectWriter = this.objectWriter;
			if (this.binaryArray == null)
			{
			}
			long niobjectId = arrayNameInfo.NIobjectId;
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x00047738 File Offset: 0x00045938
		internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, int[] lengthA, int[] lowerBoundA)
		{
			this.InternalWriteItemNull();
			Type nitype = arrayElemTypeNameInfo.NItype;
			string niname = arrayElemTypeNameInfo.NIname;
			ObjectWriter objectWriter = this.objectWriter;
			if (this.binaryArray == null)
			{
			}
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x00047778 File Offset: 0x00045978
		internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, byte[] byteA)
		{
			this.InternalWriteItemNull();
			this.WriteSingleArray(memberNameInfo, arrayNameInfo, objectInfo, arrayElemTypeNameInfo, length, lowerBound, byteA);
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x0004779C File Offset: 0x0004599C
		internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value)
		{
			this.InternalWriteItemNull();
			bool nitransmitTypeOnMember = memberNameInfo.NItransmitTypeOnMember;
			InternalPrimitiveTypeE niprimitiveTypeEnum = typeNameInfo.NIprimitiveTypeEnum;
			if (nitransmitTypeOnMember)
			{
				if (this.memberPrimitiveTyped == null)
				{
				}
				return;
			}
			this.WriteValue(niprimitiveTypeEnum, value);
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x000477D4 File Offset: 0x000459D4
		internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
			this.InternalWriteItemNull();
			if (this.objectNull == null)
			{
			}
			if (!memberNameInfo.NIisArrayItem)
			{
			}
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x000477F8 File Offset: 0x000459F8
		internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef)
		{
			this.InternalWriteItemNull();
			if (this.memberReference == null)
			{
			}
			BinaryWriter binaryWriter = this.dataWriter;
			BinaryWriter binaryWriter2 = this.dataWriter;
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x00047824 File Offset: 0x00045A24
		internal void WriteMemberNested(NameInfo memberNameInfo)
		{
			this.InternalWriteItemNull();
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x00047838 File Offset: 0x00045A38
		internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value)
		{
			this.InternalWriteItemNull();
			long niobjectId = typeNameInfo.NIobjectId;
			this.WriteObjectString((int)niobjectId, value);
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x0004785C File Offset: 0x00045A5C
		internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value)
		{
			this.InternalWriteItemNull();
			this.WriteMember(itemNameInfo, typeNameInfo, value);
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x00047878 File Offset: 0x00045A78
		internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo)
		{
			int num = this.nullCount;
			this.nullCount = num;
			this.InternalWriteItemNull();
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x0004789C File Offset: 0x00045A9C
		internal void WriteDelayedNullItem()
		{
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x000478AC File Offset: 0x00045AAC
		internal void WriteItemEnd()
		{
			this.InternalWriteItemNull();
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x000478C0 File Offset: 0x00045AC0
		private void InternalWriteItemNull()
		{
			int num = this.nullCount;
			if (this.objectNull == null)
			{
				int num2 = this.nullCount;
			}
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x000478E4 File Offset: 0x00045AE4
		internal void WriteItemObjectRef(NameInfo nameInfo, int idRef)
		{
			this.InternalWriteItemNull();
			this.WriteMemberObjectRef(nameInfo, idRef);
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x00047900 File Offset: 0x00045B00
		internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew)
		{
			this.InternalWriteItemNull();
			if (assemblyString != null)
			{
				if (this.binaryAssembly == null)
				{
				}
				return;
			}
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x00047920 File Offset: 0x00045B20
		internal void WriteValue(InternalPrimitiveTypeE code, object value)
		{
		}

		// Token: 0x040010F3 RID: 4339
		internal Stream sout;

		// Token: 0x040010F4 RID: 4340
		internal FormatterTypeStyle formatterTypeStyle;

		// Token: 0x040010F5 RID: 4341
		internal Hashtable objectMapTable;

		// Token: 0x040010F6 RID: 4342
		internal ObjectWriter objectWriter;

		// Token: 0x040010F7 RID: 4343
		internal BinaryWriter dataWriter;

		// Token: 0x040010F8 RID: 4344
		internal int m_nestedObjectCount;

		// Token: 0x040010F9 RID: 4345
		private int nullCount;

		// Token: 0x040010FA RID: 4346
		internal BinaryMethodCall binaryMethodCall;

		// Token: 0x040010FB RID: 4347
		internal BinaryMethodReturn binaryMethodReturn;

		// Token: 0x040010FC RID: 4348
		internal BinaryObject binaryObject;

		// Token: 0x040010FD RID: 4349
		internal BinaryObjectWithMap binaryObjectWithMap;

		// Token: 0x040010FE RID: 4350
		internal BinaryObjectWithMapTyped binaryObjectWithMapTyped;

		// Token: 0x040010FF RID: 4351
		internal BinaryObjectString binaryObjectString;

		// Token: 0x04001100 RID: 4352
		internal BinaryArray binaryArray;

		// Token: 0x04001101 RID: 4353
		private byte[] byteBuffer;

		// Token: 0x04001102 RID: 4354
		private int chunkSize = 4096;

		// Token: 0x04001103 RID: 4355
		internal MemberPrimitiveUnTyped memberPrimitiveUnTyped;

		// Token: 0x04001104 RID: 4356
		internal MemberPrimitiveTyped memberPrimitiveTyped;

		// Token: 0x04001105 RID: 4357
		internal ObjectNull objectNull;

		// Token: 0x04001106 RID: 4358
		internal MemberReference memberReference;

		// Token: 0x04001107 RID: 4359
		internal BinaryAssembly binaryAssembly;
	}
}
