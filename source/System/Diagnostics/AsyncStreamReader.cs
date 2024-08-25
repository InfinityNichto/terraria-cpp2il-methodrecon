using System;
using System.IO;
using System.Text;
using System.Threading;

namespace System.Diagnostics
{
	// Token: 0x020000D5 RID: 213
	internal class AsyncStreamReader
	{
		// Token: 0x060004D8 RID: 1240 RVA: 0x00013D78 File Offset: 0x00011F78
		public virtual void Close()
		{
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00013D88 File Offset: 0x00011F88
		protected virtual void Dispose(bool disposing)
		{
			object obj = this.syncObject;
			Monitor.Enter(obj, disposing);
			if (this.stream != null)
			{
				if (this.asyncReadResult != null)
				{
					return;
				}
				Stream stream = this.stream;
			}
			if (this.stream != null)
			{
			}
			if (this.eofEvent != null)
			{
				return;
			}
			long num = 0L;
			Monitor.Exit(obj);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00013E20 File Offset: 0x00012020
		internal void CancelOperation()
		{
			this.cancelOperation = true;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00013E34 File Offset: 0x00012034
		internal void WaitUtilEOF()
		{
			if (this.eofEvent != null)
			{
				ManualResetEvent manualResetEvent = this.eofEvent;
			}
		}

		// Token: 0x040003C0 RID: 960
		private Stream stream;

		// Token: 0x040003C1 RID: 961
		private Encoding encoding;

		// Token: 0x040003C2 RID: 962
		private Decoder decoder;

		// Token: 0x040003C3 RID: 963
		private byte[] byteBuffer;

		// Token: 0x040003C4 RID: 964
		private char[] charBuffer;

		// Token: 0x040003C5 RID: 965
		private bool cancelOperation;

		// Token: 0x040003C6 RID: 966
		private ManualResetEvent eofEvent;

		// Token: 0x040003C7 RID: 967
		private object syncObject;

		// Token: 0x040003C8 RID: 968
		private IAsyncResult asyncReadResult;
	}
}
