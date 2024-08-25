using System;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;

namespace System.Net.Security
{
	// Token: 0x02000312 RID: 786
	internal class SecurityBuffer
	{
		// Token: 0x06001486 RID: 5254 RVA: 0x0003E68C File Offset: 0x0003C88C
		public SecurityBuffer(byte[] data, SecurityBufferType tokentype)
		{
			if (data != null)
			{
				return;
			}
			long num = 0L;
			this.token = num;
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0003E6AC File Offset: 0x0003C8AC
		public SecurityBuffer(int size, SecurityBufferType tokentype)
		{
			this.size = size;
			this.token = tokentype;
			if (size == 0)
			{
				return;
			}
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x0003E6F4 File Offset: 0x0003C8F4
		public SecurityBuffer(global::System.Security.Authentication.ExtendedProtection.ChannelBinding binding)
		{
			if (binding != null)
			{
				return;
			}
			long num = 0L;
			this.size = (int)num;
			this.token = 14;
			this.unmanagedToken = binding;
		}

		// Token: 0x0400111A RID: 4378
		public int size;

		// Token: 0x0400111B RID: 4379
		public SecurityBufferType type;

		// Token: 0x0400111C RID: 4380
		public byte[] token;

		// Token: 0x0400111D RID: 4381
		public SafeHandle unmanagedToken;

		// Token: 0x0400111E RID: 4382
		public int offset;
	}
}
