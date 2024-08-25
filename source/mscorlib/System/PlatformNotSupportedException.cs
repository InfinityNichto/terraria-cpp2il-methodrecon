using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000EF RID: 239
	[Serializable]
	public class PlatformNotSupportedException : NotSupportedException
	{
		// Token: 0x060008E2 RID: 2274 RVA: 0x00015A38 File Offset: 0x00013C38
		public PlatformNotSupportedException()
			: base("Operation is not supported on this platform.")
		{
			this._HResult = 5433;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00015A5C File Offset: 0x00013C5C
		public PlatformNotSupportedException(string message)
			: base(message)
		{
			this._HResult = 5433;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00015A7C File Offset: 0x00013C7C
		protected PlatformNotSupportedException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
