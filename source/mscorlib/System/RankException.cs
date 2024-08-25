using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000F1 RID: 241
	[Serializable]
	public class RankException : SystemException
	{
		// Token: 0x060008F1 RID: 2289 RVA: 0x00015C04 File Offset: 0x00013E04
		public RankException()
			: base("Attempted to operate on an array with the incorrect number of dimensions.")
		{
			this._HResult = 5399;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00015C28 File Offset: 0x00013E28
		public RankException(string message)
			: base(message)
		{
			this._HResult = 5399;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00015C48 File Offset: 0x00013E48
		protected RankException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
