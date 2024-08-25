using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting
{
	// Token: 0x02000348 RID: 840
	[ComVisible(true)]
	[Serializable]
	public class RemotingException : SystemException
	{
		// Token: 0x06001C1A RID: 7194 RVA: 0x0003D188 File Offset: 0x0003B388
		public RemotingException()
		{
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x0003D19C File Offset: 0x0003B39C
		public RemotingException(string message)
			: base(message)
		{
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0003D1B0 File Offset: 0x0003B3B0
		protected RemotingException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0003D1C8 File Offset: 0x0003B3C8
		public RemotingException(string message, Exception InnerException)
			: base(message, InnerException)
		{
		}
	}
}
