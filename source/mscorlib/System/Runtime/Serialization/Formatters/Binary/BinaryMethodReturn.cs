using System;
using System.IO;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000407 RID: 1031
	internal sealed class BinaryMethodReturn
	{
		// Token: 0x06001FED RID: 8173 RVA: 0x00046198 File Offset: 0x00044398
		static BinaryMethodReturn()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x000461A8 File Offset: 0x000443A8
		internal BinaryMethodReturn()
		{
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x000461C4 File Offset: 0x000443C4
		public void Write(__BinaryWriter sout)
		{
			BinaryWriter dataWriter = sout.dataWriter;
			BinaryWriter dataWriter2 = sout.dataWriter;
			MessageEnum messageEnum = this.messageEnum;
			MessageEnum messageEnum2 = this.messageEnum;
			Type type = this.returnType;
			object obj = this.returnValue;
			IOUtil.WriteWithCode(type, obj, sout);
			MessageEnum messageEnum3 = this.messageEnum;
			if (this.callContext != null)
			{
			}
			MessageEnum messageEnum4 = this.messageEnum;
			BinaryWriter dataWriter3 = sout.dataWriter;
			object[] array = this.args;
			object[] array2 = this.args;
			Type[] array3 = this.argTypes;
			object[] array4 = this.args;
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00046250 File Offset: 0x00044450
		public void Dump()
		{
		}

		// Token: 0x04001072 RID: 4210
		private object returnValue;

		// Token: 0x04001073 RID: 4211
		private object[] args;

		// Token: 0x04001074 RID: 4212
		private object callContext;

		// Token: 0x04001075 RID: 4213
		private Type[] argTypes;

		// Token: 0x04001076 RID: 4214
		private bool bArgsPrimitive = true;

		// Token: 0x04001077 RID: 4215
		private MessageEnum messageEnum;

		// Token: 0x04001078 RID: 4216
		private Type returnType;

		// Token: 0x04001079 RID: 4217
		private static object instanceOfVoid;
	}
}
