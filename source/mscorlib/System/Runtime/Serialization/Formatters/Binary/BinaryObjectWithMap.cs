using System;
using System.IO;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200040C RID: 1036
	internal sealed class BinaryObjectWithMap
	{
		// Token: 0x06002001 RID: 8193 RVA: 0x00046430 File Offset: 0x00044630
		internal BinaryObjectWithMap()
		{
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x00046444 File Offset: 0x00044644
		internal BinaryObjectWithMap(BinaryHeaderEnum binaryHeaderEnum)
		{
			this.binaryHeaderEnum = binaryHeaderEnum;
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x00046460 File Offset: 0x00044660
		internal void Set(int objectId, string name, int numMembers, string[] memberNames, int assemId)
		{
			this.name = name;
			this.numMembers = numMembers;
			this.memberNames = memberNames;
			this.binaryHeaderEnum = BinaryHeaderEnum.ObjectWithMap;
			this.name = objectId;
			this.assemId = assemId;
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x0004649C File Offset: 0x0004469C
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
			int num4 = this.assemId;
			BinaryWriter dataWriter6 = sout.dataWriter;
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x00046514 File Offset: 0x00044714
		public void Read(__BinaryParser input)
		{
			int num = input.ReadInt32();
			this.objectId = num;
			string text = input.ReadString();
			this.name = text;
			int num2 = input.ReadInt32();
			this.numMembers = num2;
			int num3 = this.numMembers;
			string text2 = input.ReadString();
			if (text2 == null || text2 != null)
			{
				string[] array = this.memberNames;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x0004658C File Offset: 0x0004478C
		public void Dump()
		{
		}

		// Token: 0x04001081 RID: 4225
		internal BinaryHeaderEnum binaryHeaderEnum;

		// Token: 0x04001082 RID: 4226
		internal int objectId;

		// Token: 0x04001083 RID: 4227
		internal string name;

		// Token: 0x04001084 RID: 4228
		internal int numMembers;

		// Token: 0x04001085 RID: 4229
		internal string[] memberNames;

		// Token: 0x04001086 RID: 4230
		internal int assemId;
	}
}
