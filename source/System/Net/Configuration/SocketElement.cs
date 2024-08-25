using System;
using System.Configuration;
using System.Net.Sockets;

namespace System.Net.Configuration
{
	// Token: 0x0200047E RID: 1150
	public sealed class SocketElement : ConfigurationElement
	{
		// Token: 0x06001F47 RID: 8007 RVA: 0x00051BC8 File Offset: 0x0004FDC8
		public SocketElement()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001F48 RID: 8008 RVA: 0x00051BDC File Offset: 0x0004FDDC
		// (set) Token: 0x06001F49 RID: 8009 RVA: 0x00051BF0 File Offset: 0x0004FDF0
		public bool AlwaysUseCompletionPortsForAccept
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001F4A RID: 8010 RVA: 0x00051C04 File Offset: 0x0004FE04
		// (set) Token: 0x06001F4B RID: 8011 RVA: 0x00051C18 File Offset: 0x0004FE18
		public bool AlwaysUseCompletionPortsForConnect
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001F4C RID: 8012 RVA: 0x00051C2C File Offset: 0x0004FE2C
		// (set) Token: 0x06001F4D RID: 8013 RVA: 0x00051C40 File Offset: 0x0004FE40
		public global::System.Net.Sockets.IPProtectionLevel IPProtectionLevel
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001F4E RID: 8014 RVA: 0x00051C54 File Offset: 0x0004FE54
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x00051C68 File Offset: 0x0004FE68
		protected override void PostDeserialize()
		{
			throw new NotSupportedException();
		}
	}
}
