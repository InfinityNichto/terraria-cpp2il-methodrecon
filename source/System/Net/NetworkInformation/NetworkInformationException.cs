using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002A1 RID: 673
	[Serializable]
	public class NetworkInformationException : global::System.ComponentModel.Win32Exception
	{
		// Token: 0x06001285 RID: 4741 RVA: 0x00039F40 File Offset: 0x00038140
		public NetworkInformationException()
		{
			if (!true)
			{
			}
			int lastWin32Error = Marshal.GetLastWin32Error();
			base..ctor(lastWin32Error);
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00039F60 File Offset: 0x00038160
		protected NetworkInformationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: base(serializationInfo, streamingContext)
		{
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x00039F78 File Offset: 0x00038178
		public override int ErrorCode
		{
			get
			{
				return this.nativeErrorCode;
			}
		}
	}
}
