using System;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x020001B4 RID: 436
	[Serializable]
	public class AbandonedMutexException : SystemException
	{
		// Token: 0x060010A4 RID: 4260 RVA: 0x000234D4 File Offset: 0x000216D4
		public AbandonedMutexException()
		{
			this._mutexIndex = 1;
			base..ctor("The wait completed due to an abandoned mutex.");
			this._HResult = 5421;
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00023500 File Offset: 0x00021700
		public AbandonedMutexException(int location, WaitHandle handle)
		{
			this._mutexIndex = 1;
			base..ctor("The wait completed due to an abandoned mutex.");
			this._HResult = 5421;
			this._mutexIndex = location;
			if (handle != null)
			{
			}
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x00023534 File Offset: 0x00021734
		protected AbandonedMutexException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0002354C File Offset: 0x0002174C
		private void SetupException(int location, WaitHandle handle)
		{
			this._mutexIndex = location;
			if (handle != null)
			{
			}
		}

		// Token: 0x040008F6 RID: 2294
		private int _mutexIndex;

		// Token: 0x040008F7 RID: 2295
		private Mutex _mutex;
	}
}
