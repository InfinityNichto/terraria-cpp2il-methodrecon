using System;

namespace System.Runtime.Serialization
{
	// Token: 0x020003C8 RID: 968
	[Serializable]
	public class SerializationException : SystemException
	{
		// Token: 0x06001EC6 RID: 7878 RVA: 0x0004347C File Offset: 0x0004167C
		public SerializationException()
		{
			if (!true)
			{
			}
			this._HResult = 5388;
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00043498 File Offset: 0x00041698
		public SerializationException(string message)
			: base(message)
		{
			this._HResult = 5388;
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x000434B8 File Offset: 0x000416B8
		public SerializationException(string message, Exception innerException)
			: base(message, innerException)
		{
			this._HResult = 5388;
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x000434D8 File Offset: 0x000416D8
		protected SerializationException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x000434F0 File Offset: 0x000416F0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationException()
		{
		}

		// Token: 0x04000F75 RID: 3957
		private static string s_nullMessage;
	}
}
