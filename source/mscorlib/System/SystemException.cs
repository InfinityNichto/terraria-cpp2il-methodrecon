using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000104 RID: 260
	[Serializable]
	public class SystemException : Exception
	{
		// Token: 0x060009A1 RID: 2465 RVA: 0x00017244 File Offset: 0x00015444
		public SystemException()
		{
			if (!true)
			{
			}
			base..ctor("System error.");
			this._HResult = 5377;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0001726C File Offset: 0x0001546C
		public SystemException(string message)
		{
			if (!true)
			{
			}
			base..ctor(message);
			this._HResult = 5377;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00017290 File Offset: 0x00015490
		public SystemException(string message, Exception innerException)
		{
			if (!true)
			{
			}
			base..ctor(message, innerException);
			this._HResult = 5377;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x000172B4 File Offset: 0x000154B4
		protected SystemException(SerializationInfo info, StreamingContext context)
		{
			if (!true)
			{
			}
			base..ctor(info, context);
		}
	}
}
