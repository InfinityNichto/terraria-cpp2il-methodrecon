using System;
using System.Runtime.Serialization;

namespace System.IO
{
	// Token: 0x0200052F RID: 1327
	[Serializable]
	public class DirectoryNotFoundException : IOException
	{
		// Token: 0x0600272C RID: 10028 RVA: 0x00054C5C File Offset: 0x00052E5C
		public DirectoryNotFoundException()
			: base("Attempted to access a path that is not on the disk.")
		{
			this._HResult = 3;
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x00054C7C File Offset: 0x00052E7C
		public DirectoryNotFoundException(string message)
			: base(message)
		{
			this._HResult = 3;
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x00054C98 File Offset: 0x00052E98
		protected DirectoryNotFoundException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
