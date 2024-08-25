using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Security.Cryptography
{
	// Token: 0x020002D0 RID: 720
	[ComVisible(true)]
	[Serializable]
	public class CryptographicUnexpectedOperationException : CryptographicException
	{
		// Token: 0x0600184C RID: 6220 RVA: 0x00033F04 File Offset: 0x00032104
		public CryptographicUnexpectedOperationException()
		{
			base.SetErrorCode(5169);
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x00033F24 File Offset: 0x00032124
		public CryptographicUnexpectedOperationException(string message)
			: base(message)
		{
			base.SetErrorCode(5168);
			base.SetErrorCode(5168);
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00033F50 File Offset: 0x00032150
		public CryptographicUnexpectedOperationException(string format, string insert)
		{
			if (!true)
			{
			}
			string text = string.Format(CultureInfo.CurrentCulture, format, insert);
			base..ctor(text);
			base.SetErrorCode(5168);
			base.SetErrorCode(5168);
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00033F8C File Offset: 0x0003218C
		public CryptographicUnexpectedOperationException(string message, Exception inner)
			: base(message, inner)
		{
			base.SetErrorCode(5168);
			base.SetErrorCode(5168);
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00033FB8 File Offset: 0x000321B8
		protected CryptographicUnexpectedOperationException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
