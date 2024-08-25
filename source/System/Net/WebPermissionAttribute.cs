using System;
using System.Security;
using System.Security.Permissions;

namespace System.Net
{
	// Token: 0x020001D2 RID: 466
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class WebPermissionAttribute : CodeAccessSecurityAttribute
	{
		// Token: 0x06000B55 RID: 2901 RVA: 0x0002525C File Offset: 0x0002345C
		public WebPermissionAttribute(SecurityAction action)
			: base(action)
		{
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x00025270 File Offset: 0x00023470
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x00025288 File Offset: 0x00023488
		public string Connect
		{
			get
			{
				if (this.m_connect != null)
				{
					return;
				}
			}
			set
			{
				if (this.m_connect == null)
				{
					this.m_connect = value;
					return;
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x000252B0 File Offset: 0x000234B0
		// (set) Token: 0x06000B59 RID: 2905 RVA: 0x000252C8 File Offset: 0x000234C8
		public string Accept
		{
			get
			{
				if (this.m_accept != null)
				{
					return;
				}
			}
			set
			{
				if (this.m_accept == null)
				{
					this.m_accept = value;
					return;
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x000252F0 File Offset: 0x000234F0
		// (set) Token: 0x06000B5B RID: 2907 RVA: 0x00025308 File Offset: 0x00023508
		public string ConnectPattern
		{
			get
			{
				if (this.m_connect != null)
				{
					return;
				}
			}
			set
			{
				if (this.m_connect == null)
				{
					bool flag = value == ".*";
					return;
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x00025338 File Offset: 0x00023538
		// (set) Token: 0x06000B5D RID: 2909 RVA: 0x00025350 File Offset: 0x00023550
		public string AcceptPattern
		{
			get
			{
				if (this.m_accept != null)
				{
					return;
				}
			}
			set
			{
				if (this.m_accept == null)
				{
					bool flag = value == ".*";
					return;
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00025380 File Offset: 0x00023580
		public override IPermission CreatePermission()
		{
			if (this.m_Unrestricted)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x040009EB RID: 2539
		private object m_accept;

		// Token: 0x040009EC RID: 2540
		private object m_connect;
	}
}
