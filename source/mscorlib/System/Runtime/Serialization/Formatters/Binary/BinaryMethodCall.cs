using System;
using System.IO;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000406 RID: 1030
	internal sealed class BinaryMethodCall
	{
		// Token: 0x06001FEA RID: 8170 RVA: 0x000460EC File Offset: 0x000442EC
		internal void Write(__BinaryWriter sout)
		{
			BinaryWriter dataWriter = sout.dataWriter;
			BinaryWriter dataWriter2 = sout.dataWriter;
			MessageEnum messageEnum = this.messageEnum;
			IOUtil.WriteStringWithCode(this.methodName, sout);
			IOUtil.WriteStringWithCode(this.typeName, sout);
			MessageEnum messageEnum2 = this.messageEnum;
			if (this.callContext != null)
			{
			}
			MessageEnum messageEnum3 = this.messageEnum;
			BinaryWriter dataWriter3 = sout.dataWriter;
			object[] array = this.args;
			object[] array2 = this.args;
			Type[] array3 = this.argTypes;
			object[] array4 = this.args;
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x0004616C File Offset: 0x0004436C
		internal void Dump()
		{
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x0004617C File Offset: 0x0004437C
		public BinaryMethodCall()
		{
		}

		// Token: 0x0400106B RID: 4203
		private string methodName;

		// Token: 0x0400106C RID: 4204
		private string typeName;

		// Token: 0x0400106D RID: 4205
		private object[] args;

		// Token: 0x0400106E RID: 4206
		private object callContext;

		// Token: 0x0400106F RID: 4207
		private Type[] argTypes;

		// Token: 0x04001070 RID: 4208
		private bool bArgsPrimitive = true;

		// Token: 0x04001071 RID: 4209
		private MessageEnum messageEnum;
	}
}
