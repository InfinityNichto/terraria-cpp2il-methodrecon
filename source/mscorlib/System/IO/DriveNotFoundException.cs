using System;
using System.Runtime.Serialization;

namespace System.IO
{
	// Token: 0x02000549 RID: 1353
	[Serializable]
	public class DriveNotFoundException : IOException
	{
		// Token: 0x06002834 RID: 10292 RVA: 0x00057540 File Offset: 0x00055740
		public DriveNotFoundException()
			: base("Could not find the drive. The drive might not be ready or might not be mapped.")
		{
			this._HResult = 3;
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x00057560 File Offset: 0x00055760
		public DriveNotFoundException(string message)
			: base(message)
		{
			this._HResult = 3;
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x0005757C File Offset: 0x0005577C
		protected DriveNotFoundException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
