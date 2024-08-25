using System;

namespace System.Net.Sockets
{
	// Token: 0x020002FA RID: 762
	public class LingerOption
	{
		// Token: 0x06001409 RID: 5129 RVA: 0x0003D45C File Offset: 0x0003B65C
		public LingerOption(bool enable, int seconds)
		{
			this.lingerTime = seconds;
		}

		// Token: 0x17000489 RID: 1161
		// (set) Token: 0x0600140A RID: 5130 RVA: 0x0003D478 File Offset: 0x0003B678
		public bool Enabled
		{
			set
			{
			}
		}

		// Token: 0x1700048A RID: 1162
		// (set) Token: 0x0600140B RID: 5131 RVA: 0x0003D488 File Offset: 0x0003B688
		public int LingerTime
		{
			set
			{
				this.lingerTime = value;
			}
		}

		// Token: 0x0400102A RID: 4138
		private bool enabled;

		// Token: 0x0400102B RID: 4139
		private int lingerTime;
	}
}
