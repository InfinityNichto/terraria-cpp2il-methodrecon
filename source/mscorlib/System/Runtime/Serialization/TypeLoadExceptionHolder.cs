using System;

namespace System.Runtime.Serialization
{
	// Token: 0x020003E3 RID: 995
	internal class TypeLoadExceptionHolder
	{
		// Token: 0x06001F7F RID: 8063 RVA: 0x0004532C File Offset: 0x0004352C
		internal TypeLoadExceptionHolder(string typeName)
		{
			this.m_typeName = typeName;
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001F80 RID: 8064 RVA: 0x00045348 File Offset: 0x00043548
		internal string TypeName
		{
			get
			{
				return this.m_typeName;
			}
		}

		// Token: 0x04000FBF RID: 4031
		private string m_typeName;
	}
}
