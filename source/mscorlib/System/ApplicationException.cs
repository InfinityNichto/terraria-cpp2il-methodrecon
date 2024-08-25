using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000082 RID: 130
	[Serializable]
	public class ApplicationException : Exception
	{
		// Token: 0x060003C2 RID: 962 RVA: 0x0000BDB4 File Offset: 0x00009FB4
		public ApplicationException()
		{
			if (!true)
			{
			}
			base..ctor("Error in the application.");
			this._HResult = 5632;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000BDDC File Offset: 0x00009FDC
		public ApplicationException(string message)
		{
			if (!true)
			{
			}
			base..ctor(message);
			this._HResult = 5632;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000BE00 File Offset: 0x0000A000
		public ApplicationException(string message, Exception innerException)
		{
			if (!true)
			{
			}
			base..ctor(message, innerException);
			this._HResult = 5632;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000BE24 File Offset: 0x0000A024
		protected ApplicationException(SerializationInfo info, StreamingContext context)
		{
			if (!true)
			{
			}
			base..ctor(info, context);
		}
	}
}
