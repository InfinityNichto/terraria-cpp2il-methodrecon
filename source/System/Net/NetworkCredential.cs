using System;
using System.Security;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x020001C2 RID: 450
	public class NetworkCredential : ICredentials, ICredentialsByHost
	{
		// Token: 0x06000AB9 RID: 2745 RVA: 0x000239FC File Offset: 0x00021BFC
		public NetworkCredential()
		{
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00023A0C File Offset: 0x00021C0C
		public NetworkCredential(string userName, string password)
		{
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00023A1C File Offset: 0x00021C1C
		public NetworkCredential(string userName, SecureString password)
		{
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00023A2C File Offset: 0x00021C2C
		public NetworkCredential(string userName, string password, string domain)
		{
			if (userName != null)
			{
				this.m_userName = userName;
				return;
			}
			SecureString secureString = UnsafeNclNativeMethods.SecureStringHelper.CreateSecureString(password);
			this.m_password = secureString;
			if (domain != null)
			{
				this.m_domain = domain;
				return;
			}
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00023A64 File Offset: 0x00021C64
		public NetworkCredential(string userName, SecureString password, string domain)
		{
			if (userName != null)
			{
				this.m_userName = userName;
				return;
			}
			this.SecurePassword = password;
			if (domain != null)
			{
				this.m_domain = domain;
				return;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x00023A94 File Offset: 0x00021C94
		public string UserName
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00023AA4 File Offset: 0x00021CA4
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x00023ABC File Offset: 0x00021CBC
		public string Password
		{
			get
			{
				return UnsafeNclNativeMethods.SecureStringHelper.CreateString(this.m_password);
			}
			set
			{
				SecureString secureString = UnsafeNclNativeMethods.SecureStringHelper.CreateSecureString(value);
				this.m_password = secureString;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x00023AD8 File Offset: 0x00021CD8
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x00023AF0 File Offset: 0x00021CF0
		public SecureString SecurePassword
		{
			get
			{
				return this.m_password.Copy();
			}
			set
			{
				if (value != null)
				{
					SecureString secureString = value.Copy();
					this.m_password = secureString;
					return;
				}
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x00023B10 File Offset: 0x00021D10
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x00023B24 File Offset: 0x00021D24
		public string Domain
		{
			get
			{
				return this.m_domain;
			}
			set
			{
				if (value != null)
				{
					this.m_domain = value;
					return;
				}
			}
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00023B3C File Offset: 0x00021D3C
		internal string InternalGetUserName()
		{
			return this.m_userName;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00023B50 File Offset: 0x00021D50
		internal string InternalGetPassword()
		{
			return UnsafeNclNativeMethods.SecureStringHelper.CreateString(this.m_password);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00023B68 File Offset: 0x00021D68
		internal SecureString InternalGetSecurePassword()
		{
			return this.m_password;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00002050 File Offset: 0x00000250
		internal string InternalGetDomain()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00023B7C File Offset: 0x00021D7C
		internal string InternalGetDomainUserName()
		{
			string domain = this.m_domain;
			string text;
			if (true)
			{
				text = domain + "\\";
			}
			string userName = this.m_userName;
			return text + userName;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00023BB0 File Offset: 0x00021DB0
		public NetworkCredential GetCredential(global::System.Uri uri, string authType)
		{
			return this;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00023BC0 File Offset: 0x00021DC0
		public NetworkCredential GetCredential(string host, int port, string authenticationType)
		{
			return this;
		}

		// Token: 0x04000983 RID: 2435
		private string m_domain;

		// Token: 0x04000984 RID: 2436
		private string m_userName;

		// Token: 0x04000985 RID: 2437
		private SecureString m_password;
	}
}
