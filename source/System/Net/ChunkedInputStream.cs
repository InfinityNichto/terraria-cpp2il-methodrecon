using System;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000232 RID: 562
	internal class ChunkedInputStream : RequestStream
	{
		// Token: 0x06000E1A RID: 3610 RVA: 0x0002CED4 File Offset: 0x0002B0D4
		public ChunkedInputStream(HttpListenerContext context, Stream stream, byte[] buffer, int offset, int length)
			: base(stream, buffer, offset, length)
		{
			this.context = context;
			if (context.request.headers != null)
			{
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x0002CF08 File Offset: 0x0002B108
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x0002CF1C File Offset: 0x0002B11C
		public MonoChunkParser Decoder
		{
			get
			{
				return this.decoder;
			}
			set
			{
				this.decoder = value;
			}
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00002050 File Offset: 0x00000250
		public override int Read([In] [Out] byte[] buffer, int offset, int count)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x0002CF30 File Offset: 0x0002B130
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			while (this.disposed || buffer == null)
			{
			}
			if (!this.no_more_data)
			{
				int num = this.decoder.Read(buffer, offset, count);
				bool wantMore = this.decoder.WantMore;
				IAsyncResult asyncResult;
				return asyncResult;
			}
			return "offset exceeds the size of buffer";
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x0002CF78 File Offset: 0x0002B178
		private void OnRead(IAsyncResult base_ares)
		{
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x0002D008 File Offset: 0x0002B208
		public override int EndRead(IAsyncResult ares)
		{
			long num;
			if (!this.disposed)
			{
				if (ares == null)
				{
					return;
				}
				num = 0L;
				if (ares != null)
				{
					return;
				}
			}
			Type type = num.GetType();
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x0002D034 File Offset: 0x0002B234
		public override void Close()
		{
			if (this.disposed)
			{
				return;
			}
			this.disposed = true;
			base.Close();
		}

		// Token: 0x04000BBB RID: 3003
		private bool disposed;

		// Token: 0x04000BBC RID: 3004
		private MonoChunkParser decoder;

		// Token: 0x04000BBD RID: 3005
		private HttpListenerContext context;

		// Token: 0x04000BBE RID: 3006
		private bool no_more_data;

		// Token: 0x02000233 RID: 563
		private class ReadBufferState
		{
			// Token: 0x06000E22 RID: 3618 RVA: 0x0002D058 File Offset: 0x0002B258
			public ReadBufferState(byte[] buffer, int offset, int count, HttpStreamAsyncResult ares)
			{
				this.Buffer = buffer;
				this.Offset = offset;
				this.InitialCount = count;
				this.InitialCount = count;
				this.Ares = ares;
			}

			// Token: 0x04000BBF RID: 3007
			public byte[] Buffer;

			// Token: 0x04000BC0 RID: 3008
			public int Offset;

			// Token: 0x04000BC1 RID: 3009
			public int Count;

			// Token: 0x04000BC2 RID: 3010
			public int InitialCount;

			// Token: 0x04000BC3 RID: 3011
			public HttpStreamAsyncResult Ares;
		}
	}
}
