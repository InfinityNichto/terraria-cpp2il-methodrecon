using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000A9 RID: 169
	[Serializable]
	public class FormatException : SystemException
	{
		// Token: 0x0600067F RID: 1663 RVA: 0x0000FAA0 File Offset: 0x0000DCA0
		public FormatException()
			: base("One of the identified items was in an invalid format.")
		{
			this._HResult = 5431;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0000FAC4 File Offset: 0x0000DCC4
		public FormatException(string message)
			: base(message)
		{
			this._HResult = 5431;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0000FAE4 File Offset: 0x0000DCE4
		public FormatException(string message, Exception innerException)
			: base(message, innerException)
		{
			this._HResult = 5431;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0000FB04 File Offset: 0x0000DD04
		protected FormatException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
