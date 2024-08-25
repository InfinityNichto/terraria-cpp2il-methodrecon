using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Net
{
	// Token: 0x02000191 RID: 401
	[Serializable]
	public class HttpListenerException : global::System.ComponentModel.Win32Exception
	{
		// Token: 0x06000A49 RID: 2633 RVA: 0x00022BFC File Offset: 0x00020DFC
		public HttpListenerException()
		{
			if (!true)
			{
			}
			int lastWin32Error = Marshal.GetLastWin32Error();
			base..ctor(lastWin32Error);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00022C1C File Offset: 0x00020E1C
		public HttpListenerException(int errorCode)
			: base(errorCode)
		{
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00022C30 File Offset: 0x00020E30
		public HttpListenerException(int errorCode, string message)
			: base(errorCode, message)
		{
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00022C48 File Offset: 0x00020E48
		protected HttpListenerException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: base(serializationInfo, streamingContext)
		{
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00022C60 File Offset: 0x00020E60
		public override int ErrorCode
		{
			get
			{
				return this.nativeErrorCode;
			}
		}
	}
}
