using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000430 RID: 1072
	[Serializable]
	public class MarshalDirectiveException : SystemException
	{
		// Token: 0x0600214E RID: 8526 RVA: 0x0004BE18 File Offset: 0x0004A018
		public MarshalDirectiveException()
			: base("Marshaling directives are invalid.")
		{
			this._HResult = 5429;
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x0004BE3C File Offset: 0x0004A03C
		public MarshalDirectiveException(string message)
			: base(message)
		{
			this._HResult = 5429;
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x0004BE5C File Offset: 0x0004A05C
		protected MarshalDirectiveException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
