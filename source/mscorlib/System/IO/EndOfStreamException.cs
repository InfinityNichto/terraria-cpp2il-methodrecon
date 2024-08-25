using System;
using System.Runtime.Serialization;

namespace System.IO
{
	// Token: 0x02000530 RID: 1328
	[Serializable]
	public class EndOfStreamException : IOException
	{
		// Token: 0x0600272F RID: 10031 RVA: 0x00054CB0 File Offset: 0x00052EB0
		public EndOfStreamException()
			: base("Attempted to read past the end of the stream.")
		{
			this._HResult = 38;
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x00054CD0 File Offset: 0x00052ED0
		public EndOfStreamException(string message)
			: base(message)
		{
			this._HResult = 38;
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x00054CEC File Offset: 0x00052EEC
		protected EndOfStreamException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
