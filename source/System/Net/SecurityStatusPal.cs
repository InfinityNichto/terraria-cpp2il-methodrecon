using System;
using System.Runtime.InteropServices;

namespace System.Net
{
	// Token: 0x0200012F RID: 303
	internal readonly struct SecurityStatusPal
	{
		// Token: 0x0600072D RID: 1837 RVA: 0x0001A108 File Offset: 0x00018308
		public SecurityStatusPal(SecurityStatusPalErrorCode errorCode, [Optional] Exception exception)
		{
			this.ErrorCode = errorCode;
			this.Exception = exception;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0001A124 File Offset: 0x00018324
		public override string ToString()
		{
			if (this.Exception != null)
			{
				if (("ErrorCode" == null || "ErrorCode" != null) && ("Exception" == null || "Exception" != null))
				{
					Exception exception = this.Exception;
					if (exception == null || exception != null)
					{
						string text;
						return text;
					}
				}
				throw new ArrayTypeMismatchException();
			}
			string text2;
			return text2;
		}

		// Token: 0x04000597 RID: 1431
		public readonly SecurityStatusPalErrorCode ErrorCode;

		// Token: 0x04000598 RID: 1432
		public readonly Exception Exception;
	}
}
