using System;
using System.Runtime.CompilerServices;

namespace Mono.Net.Security
{
	// Token: 0x02000052 RID: 82
	internal abstract class AsyncReadOrWriteRequest : AsyncProtocolRequest
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00004064 File Offset: 0x00002264
		protected BufferOffsetSize UserBuffer
		{
			[CompilerGenerated]
			get
			{
				return this.<UserBuffer>k__BackingField;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00004078 File Offset: 0x00002278
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0000408C File Offset: 0x0000228C
		protected int CurrentSize
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrentSize>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CurrentSize>k__BackingField = value;
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000040A0 File Offset: 0x000022A0
		public AsyncReadOrWriteRequest(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size)
			: base(parent, sync)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000040B8 File Offset: 0x000022B8
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x040000C3 RID: 195
		[CompilerGenerated]
		private readonly BufferOffsetSize <UserBuffer>k__BackingField;

		// Token: 0x040000C4 RID: 196
		[CompilerGenerated]
		private int <CurrentSize>k__BackingField;
	}
}
