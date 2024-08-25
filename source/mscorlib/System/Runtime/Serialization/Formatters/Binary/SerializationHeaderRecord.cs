using System;
using System.IO;
using Cpp2IlInjected;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000402 RID: 1026
	internal sealed class SerializationHeaderRecord
	{
		// Token: 0x06001FD7 RID: 8151 RVA: 0x00045E40 File Offset: 0x00044040
		internal SerializationHeaderRecord()
		{
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x00045E5C File Offset: 0x0004405C
		internal SerializationHeaderRecord(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion)
		{
			this.binaryHeaderEnum = binaryHeaderEnum;
			this.headerId = topId;
			this.headerId = headerId;
			this.minorVersion = majorVersion;
			this.minorVersion = minorVersion;
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00045E9C File Offset: 0x0004409C
		public void Write(__BinaryWriter sout)
		{
			int num = this.binaryFormatterMajorVersion;
			BinaryWriter dataWriter = sout.dataWriter;
			BinaryHeaderEnum binaryHeaderEnum = this.binaryHeaderEnum;
			BinaryWriter dataWriter2 = sout.dataWriter;
			int num2 = this.topId;
			BinaryWriter dataWriter3 = sout.dataWriter;
			int num3 = this.headerId;
			BinaryWriter dataWriter4 = sout.dataWriter;
			int num4 = this.binaryFormatterMajorVersion;
			BinaryWriter dataWriter5 = sout.dataWriter;
			int num5 = this.binaryFormatterMinorVersion;
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x0000207A File Offset: 0x0000027A
		private static int GetInt32(byte[] buffer, int index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x00045F00 File Offset: 0x00044100
		public void Read(__BinaryParser input)
		{
			byte[] array = input.ReadBytes(17);
			__Error.EndOfFile();
			int num = this.binaryFormatterMajorVersion;
			this.majorVersion = input;
			this.binaryHeaderEnum = input;
			this.topId = input;
			this.headerId = input;
			this.minorVersion = input;
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x00045F54 File Offset: 0x00044154
		public void Dump()
		{
		}

		// Token: 0x0400105E RID: 4190
		internal int binaryFormatterMajorVersion = 1;

		// Token: 0x0400105F RID: 4191
		internal int binaryFormatterMinorVersion;

		// Token: 0x04001060 RID: 4192
		internal BinaryHeaderEnum binaryHeaderEnum;

		// Token: 0x04001061 RID: 4193
		internal int topId;

		// Token: 0x04001062 RID: 4194
		internal int headerId;

		// Token: 0x04001063 RID: 4195
		internal int majorVersion;

		// Token: 0x04001064 RID: 4196
		internal int minorVersion;
	}
}
