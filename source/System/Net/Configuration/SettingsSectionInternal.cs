using System;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace System.Net.Configuration
{
	// Token: 0x020002E0 RID: 736
	internal sealed class SettingsSectionInternal
	{
		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060012E0 RID: 4832 RVA: 0x0003AA50 File Offset: 0x00038C50
		internal static SettingsSectionInternal Section
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x0003AA64 File Offset: 0x00038C64
		// (set) Token: 0x060012E2 RID: 4834 RVA: 0x0003AA78 File Offset: 0x00038C78
		internal bool UseNagleAlgorithm
		{
			[CompilerGenerated]
			get
			{
				return this.<UseNagleAlgorithm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x0003AA88 File Offset: 0x00038C88
		// (set) Token: 0x060012E4 RID: 4836 RVA: 0x0003AA9C File Offset: 0x00038C9C
		internal bool Expect100Continue
		{
			[CompilerGenerated]
			get
			{
				return this.<Expect100Continue>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x0003AAAC File Offset: 0x00038CAC
		// (set) Token: 0x060012E6 RID: 4838 RVA: 0x0003AAC0 File Offset: 0x00038CC0
		internal bool CheckCertificateName
		{
			[CompilerGenerated]
			get
			{
				return this.<CheckCertificateName>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x0003AAD0 File Offset: 0x00038CD0
		// (set) Token: 0x060012E8 RID: 4840 RVA: 0x0003AAE4 File Offset: 0x00038CE4
		internal int DnsRefreshTimeout
		{
			[CompilerGenerated]
			get
			{
				return this.<DnsRefreshTimeout>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DnsRefreshTimeout>k__BackingField = value;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x0003AAF8 File Offset: 0x00038CF8
		// (set) Token: 0x060012EA RID: 4842 RVA: 0x0003AB0C File Offset: 0x00038D0C
		internal bool EnableDnsRoundRobin
		{
			[CompilerGenerated]
			get
			{
				return this.<EnableDnsRoundRobin>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x0003AB1C File Offset: 0x00038D1C
		// (set) Token: 0x060012EC RID: 4844 RVA: 0x0003AB30 File Offset: 0x00038D30
		internal bool CheckCertificateRevocationList
		{
			[CompilerGenerated]
			get
			{
				return this.<CheckCertificateRevocationList>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x0003AB40 File Offset: 0x00038D40
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x0003AB54 File Offset: 0x00038D54
		internal global::System.Net.Security.EncryptionPolicy EncryptionPolicy
		{
			[CompilerGenerated]
			get
			{
				return this.<EncryptionPolicy>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<EncryptionPolicy>k__BackingField = value;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x0003AB68 File Offset: 0x00038D68
		internal bool Ipv6Enabled
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x0003AB78 File Offset: 0x00038D78
		public SettingsSectionInternal()
		{
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0003AB94 File Offset: 0x00038D94
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsSectionInternal()
		{
		}

		// Token: 0x04000F62 RID: 3938
		private static readonly SettingsSectionInternal instance;

		// Token: 0x04000F63 RID: 3939
		internal readonly bool HttpListenerUnescapeRequestUrl = true;

		// Token: 0x04000F64 RID: 3940
		internal readonly global::System.Net.Sockets.IPProtectionLevel IPProtectionLevel;

		// Token: 0x04000F65 RID: 3941
		[CompilerGenerated]
		private bool <UseNagleAlgorithm>k__BackingField;

		// Token: 0x04000F66 RID: 3942
		[CompilerGenerated]
		private bool <Expect100Continue>k__BackingField;

		// Token: 0x04000F67 RID: 3943
		[CompilerGenerated]
		private bool <CheckCertificateName>k__BackingField;

		// Token: 0x04000F68 RID: 3944
		[CompilerGenerated]
		private int <DnsRefreshTimeout>k__BackingField;

		// Token: 0x04000F69 RID: 3945
		[CompilerGenerated]
		private bool <EnableDnsRoundRobin>k__BackingField;

		// Token: 0x04000F6A RID: 3946
		[CompilerGenerated]
		private bool <CheckCertificateRevocationList>k__BackingField;

		// Token: 0x04000F6B RID: 3947
		[CompilerGenerated]
		private global::System.Net.Security.EncryptionPolicy <EncryptionPolicy>k__BackingField;
	}
}
