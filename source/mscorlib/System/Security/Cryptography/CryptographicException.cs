using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;
using Microsoft.Win32;

namespace System.Security.Cryptography
{
	// Token: 0x020002CF RID: 719
	[ComVisible(true)]
	[Serializable]
	public class CryptographicException : SystemException
	{
		// Token: 0x06001845 RID: 6213 RVA: 0x00033E18 File Offset: 0x00032018
		public CryptographicException()
		{
			string resourceString = Environment.GetResourceString("Error occurred during a cryptographic operation.");
			base..ctor(resourceString);
			base.SetErrorCode(5168);
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00033E44 File Offset: 0x00032044
		public CryptographicException(string message)
			: base(message)
		{
			base.SetErrorCode(5168);
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00033E64 File Offset: 0x00032064
		public CryptographicException(string format, string insert)
		{
			if (!true)
			{
			}
			string text = string.Format(CultureInfo.CurrentCulture, format, insert);
			base..ctor(text);
			base.SetErrorCode(5168);
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00033E98 File Offset: 0x00032098
		public CryptographicException(string message, Exception inner)
			: base(message, inner)
		{
			base.SetErrorCode(5168);
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00033EB8 File Offset: 0x000320B8
		public CryptographicException(int hr)
		{
			string message = Win32Native.GetMessage(hr);
			base..ctor(message);
			base.SetErrorCode(5168);
			base.SetErrorCode(5168);
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00033EEC File Offset: 0x000320EC
		protected CryptographicException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x0000207A File Offset: 0x0000027A
		private static void ThrowCryptographicException(int hr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000C8E RID: 3214
		private const int FORMAT_MESSAGE_IGNORE_INSERTS = 512;

		// Token: 0x04000C8F RID: 3215
		private const int FORMAT_MESSAGE_FROM_SYSTEM = 4096;

		// Token: 0x04000C90 RID: 3216
		private const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 8192;
	}
}
