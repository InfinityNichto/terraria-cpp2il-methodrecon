using System;
using System.Runtime.Serialization;

namespace System.IO
{
	// Token: 0x0200053B RID: 1339
	[Serializable]
	public class PathTooLongException : IOException
	{
		// Token: 0x06002781 RID: 10113 RVA: 0x000559DC File Offset: 0x00053BDC
		public PathTooLongException()
			: base("The specified file name or path is too long, or a component of the specified path is too long.")
		{
			this._HResult = 206;
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x00055A00 File Offset: 0x00053C00
		public PathTooLongException(string message)
			: base(message)
		{
			this._HResult = 206;
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x00055A20 File Offset: 0x00053C20
		protected PathTooLongException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
