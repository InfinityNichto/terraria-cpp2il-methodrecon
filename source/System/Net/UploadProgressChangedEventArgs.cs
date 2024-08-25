using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Net
{
	// Token: 0x02000183 RID: 387
	public class UploadProgressChangedEventArgs : global::System.ComponentModel.ProgressChangedEventArgs
	{
		// Token: 0x06000A05 RID: 2565 RVA: 0x00022174 File Offset: 0x00020374
		internal UploadProgressChangedEventArgs(int progressPercentage, object userToken, long bytesSent, long totalBytesToSend, long bytesReceived, long totalBytesToReceive)
			: base(progressPercentage, userToken)
		{
			this.BytesReceived = bytesReceived;
			this.TotalBytesToReceive = totalBytesToReceive;
			this.BytesSent = bytesSent;
			this.TotalBytesToSend = totalBytesToSend;
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x000221A8 File Offset: 0x000203A8
		public long BytesReceived
		{
			[CompilerGenerated]
			get
			{
				return this.<BytesReceived>k__BackingField;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x000221BC File Offset: 0x000203BC
		public long TotalBytesToReceive
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalBytesToReceive>k__BackingField;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x000221D0 File Offset: 0x000203D0
		public long BytesSent
		{
			[CompilerGenerated]
			get
			{
				return this.<BytesSent>k__BackingField;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x000221E4 File Offset: 0x000203E4
		public long TotalBytesToSend
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalBytesToSend>k__BackingField;
			}
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x000221F8 File Offset: 0x000203F8
		internal UploadProgressChangedEventArgs()
		{
			throw new NotSupportedException();
		}

		// Token: 0x040007A4 RID: 1956
		[CompilerGenerated]
		private readonly long <BytesReceived>k__BackingField;

		// Token: 0x040007A5 RID: 1957
		[CompilerGenerated]
		private readonly long <TotalBytesToReceive>k__BackingField;

		// Token: 0x040007A6 RID: 1958
		[CompilerGenerated]
		private readonly long <BytesSent>k__BackingField;

		// Token: 0x040007A7 RID: 1959
		[CompilerGenerated]
		private readonly long <TotalBytesToSend>k__BackingField;
	}
}
