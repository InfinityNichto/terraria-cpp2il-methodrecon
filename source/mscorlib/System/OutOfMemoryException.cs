using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000133 RID: 307
	[Serializable]
	public class OutOfMemoryException : SystemException
	{
		// Token: 0x06000BE4 RID: 3044 RVA: 0x0001A808 File Offset: 0x00018A08
		public OutOfMemoryException()
			: base("Insufficient memory to continue the execution of the program.")
		{
			this._HResult = 14;
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x0001A828 File Offset: 0x00018A28
		public OutOfMemoryException(string message)
			: base(message)
		{
			this._HResult = 14;
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x0001A844 File Offset: 0x00018A44
		protected OutOfMemoryException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
