using System;
using System.Runtime.Serialization;

namespace System.Security
{
	// Token: 0x02000293 RID: 659
	[Serializable]
	public sealed class XmlSyntaxException : SystemException
	{
		// Token: 0x060016BE RID: 5822 RVA: 0x0002FEEC File Offset: 0x0002E0EC
		public XmlSyntaxException()
		{
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x0002FF00 File Offset: 0x0002E100
		public XmlSyntaxException(int lineNumber)
		{
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x0002FF14 File Offset: 0x0002E114
		public XmlSyntaxException(int lineNumber, string message)
		{
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x0002FF28 File Offset: 0x0002E128
		private XmlSyntaxException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
