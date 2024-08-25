using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000285 RID: 645
	internal abstract class WebConnectionStream : Stream
	{
		// Token: 0x060011B6 RID: 4534 RVA: 0x000373D8 File Offset: 0x000355D8
		protected WebConnectionStream(WebConnection cnc, WebOperation operation)
		{
			if (!true)
			{
			}
			base..ctor();
			this.Connection = cnc;
			this.Operation = operation;
			HttpWebRequest httpWebRequest = operation.<Request>k__BackingField;
			this.Request = httpWebRequest;
			int readWriteTimeout = httpWebRequest.readWriteTimeout;
			this.read_timeout = readWriteTimeout;
			this.IgnoreIOErrors = readWriteTimeout != 0;
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x00037420 File Offset: 0x00035620
		internal HttpWebRequest Request
		{
			[CompilerGenerated]
			get
			{
				return this.<Request>k__BackingField;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x00037434 File Offset: 0x00035634
		internal WebConnection Connection
		{
			[CompilerGenerated]
			get
			{
				return this.<Connection>k__BackingField;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x00037448 File Offset: 0x00035648
		internal WebOperation Operation
		{
			[CompilerGenerated]
			get
			{
				return this.<Operation>k__BackingField;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x0003745C File Offset: 0x0003565C
		internal ServicePoint ServicePoint
		{
			get
			{
				return this.<Connection>k__BackingField.<ServicePoint>k__BackingField;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x00037474 File Offset: 0x00035674
		public override bool CanTimeout
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x00037484 File Offset: 0x00035684
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x00037498 File Offset: 0x00035698
		public override int ReadTimeout
		{
			get
			{
				return this.read_timeout;
			}
			set
			{
				this.read_timeout = value;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x000374AC File Offset: 0x000356AC
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x000374C0 File Offset: 0x000356C0
		public override int WriteTimeout
		{
			get
			{
				return this.write_timeout;
			}
			set
			{
				this.write_timeout = value;
			}
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x000374D4 File Offset: 0x000356D4
		protected Exception GetException(Exception e)
		{
			if (!true)
			{
			}
			Exception ex = HttpWebRequest.FlattenException(e);
			if (ex != null)
			{
			}
			bool aborted = this.<Operation>k__BackingField.Aborted;
			WebException ex2 = HttpWebRequest.CreateRequestAbortedException();
			if (ex != null)
			{
			}
			return ex;
		}

		// Token: 0x060011C1 RID: 4545
		protected abstract bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, [Out] int result);

		// Token: 0x060011C2 RID: 4546 RVA: 0x00037504 File Offset: 0x00035704
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (buffer != null)
			{
				this.<Operation>k__BackingField.ThrowIfClosedOrDisposed();
				CancellationToken none = CancellationToken.None;
				return "offset";
			}
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00037530 File Offset: 0x00035730
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cb, object state)
		{
			do
			{
				this.<Operation>k__BackingField.ThrowIfClosedOrDisposed();
			}
			while (buffer == null);
			CancellationToken none = CancellationToken.None;
			IAsyncResult asyncResult;
			return asyncResult;
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00037560 File Offset: 0x00035760
		public override int EndRead(IAsyncResult r)
		{
			if (r != null)
			{
				return TaskToApm.End<int>(r);
			}
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00037578 File Offset: 0x00035778
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cb, object state)
		{
			while (buffer == null)
			{
			}
			this.<Operation>k__BackingField.ThrowIfClosedOrDisposed();
			CancellationToken none = CancellationToken.None;
			IAsyncResult asyncResult;
			return asyncResult;
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x000375A4 File Offset: 0x000357A4
		public override void EndWrite(IAsyncResult r)
		{
			if (r != null)
			{
				TaskToApm.End(r);
				return;
			}
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x000375C0 File Offset: 0x000357C0
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (buffer != null)
			{
				this.<Operation>k__BackingField.ThrowIfClosedOrDisposed();
				base.WriteAsync(buffer, offset, count).Wait();
				return;
			}
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x000375F0 File Offset: 0x000357F0
		public override void Flush()
		{
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00037600 File Offset: 0x00035800
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			Task task;
			return task;
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00037618 File Offset: 0x00035818
		internal void InternalClose()
		{
			this.disposed = true;
		}

		// Token: 0x060011CB RID: 4555
		protected abstract void Close_internal(bool disposed);

		// Token: 0x060011CC RID: 4556 RVA: 0x0003762C File Offset: 0x0003582C
		public override void Close()
		{
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00002050 File Offset: 0x00000250
		public override long Seek(long a, SeekOrigin b)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00002050 File Offset: 0x00000250
		public override void SetLength(long a)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x0003763C File Offset: 0x0003583C
		public override bool CanSeek
		{
			get
			{
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x00002050 File Offset: 0x00000250
		public override long Length
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060011D2 RID: 4562 RVA: 0x00002050 File Offset: 0x00000250
		public override long Position
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x04000DC3 RID: 3523
		protected bool closed;

		// Token: 0x04000DC4 RID: 3524
		private bool disposed;

		// Token: 0x04000DC5 RID: 3525
		private object locker;

		// Token: 0x04000DC6 RID: 3526
		private int read_timeout;

		// Token: 0x04000DC7 RID: 3527
		private int write_timeout;

		// Token: 0x04000DC8 RID: 3528
		internal bool IgnoreIOErrors;

		// Token: 0x04000DC9 RID: 3529
		[CompilerGenerated]
		private readonly HttpWebRequest <Request>k__BackingField;

		// Token: 0x04000DCA RID: 3530
		[CompilerGenerated]
		private readonly WebConnection <Connection>k__BackingField;

		// Token: 0x04000DCB RID: 3531
		[CompilerGenerated]
		private readonly WebOperation <Operation>k__BackingField;
	}
}
