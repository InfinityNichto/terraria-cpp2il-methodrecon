using System;
using System.Configuration;
using System.Net.Mail;

namespace System.Net.Configuration
{
	// Token: 0x02000476 RID: 1142
	public sealed class SmtpSection : ConfigurationSection
	{
		// Token: 0x06001EEF RID: 7919 RVA: 0x000514E8 File Offset: 0x0004F6E8
		public SmtpSection()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x000514FC File Offset: 0x0004F6FC
		// (set) Token: 0x06001EF1 RID: 7921 RVA: 0x00051510 File Offset: 0x0004F710
		public global::System.Net.Mail.SmtpDeliveryFormat DeliveryFormat
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

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x00051524 File Offset: 0x0004F724
		// (set) Token: 0x06001EF3 RID: 7923 RVA: 0x00051538 File Offset: 0x0004F738
		public global::System.Net.Mail.SmtpDeliveryMethod DeliveryMethod
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

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x0005154C File Offset: 0x0004F74C
		// (set) Token: 0x06001EF5 RID: 7925 RVA: 0x00051560 File Offset: 0x0004F760
		public string From
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

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x00051574 File Offset: 0x0004F774
		public SmtpNetworkElement Network
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x00051588 File Offset: 0x0004F788
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x0005159C File Offset: 0x0004F79C
		public SmtpSpecifiedPickupDirectoryElement SpecifiedPickupDirectory
		{
			get
			{
				throw new NotSupportedException();
			}
		}
	}
}
