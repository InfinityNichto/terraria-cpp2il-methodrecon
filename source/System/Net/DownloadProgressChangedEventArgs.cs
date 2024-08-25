using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Net
{
	// Token: 0x02000182 RID: 386
	public class DownloadProgressChangedEventArgs : global::System.ComponentModel.ProgressChangedEventArgs
	{
		// Token: 0x06000A01 RID: 2561 RVA: 0x00022114 File Offset: 0x00020314
		internal DownloadProgressChangedEventArgs(int progressPercentage, object userToken, long bytesReceived, long totalBytesToReceive)
			: base(progressPercentage, userToken)
		{
			this.BytesReceived = bytesReceived;
			this.TotalBytesToReceive = totalBytesToReceive;
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00022138 File Offset: 0x00020338
		public long BytesReceived
		{
			[CompilerGenerated]
			get
			{
				return this.<BytesReceived>k__BackingField;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0002214C File Offset: 0x0002034C
		public long TotalBytesToReceive
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalBytesToReceive>k__BackingField;
			}
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00022160 File Offset: 0x00020360
		internal DownloadProgressChangedEventArgs()
		{
			throw new NotSupportedException();
		}

		// Token: 0x040007A2 RID: 1954
		[CompilerGenerated]
		private readonly long <BytesReceived>k__BackingField;

		// Token: 0x040007A3 RID: 1955
		[CompilerGenerated]
		private readonly long <TotalBytesToReceive>k__BackingField;
	}
}
