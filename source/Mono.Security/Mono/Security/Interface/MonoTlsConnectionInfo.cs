using System;
using System.Runtime.CompilerServices;

namespace Mono.Security.Interface
{
	// Token: 0x02000048 RID: 72
	public class MonoTlsConnectionInfo
	{
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00008B04 File Offset: 0x00006D04
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00008B18 File Offset: 0x00006D18
		[CLSCompliant(false)]
		public CipherSuiteCode CipherSuiteCode
		{
			[CompilerGenerated]
			get
			{
				return this.<CipherSuiteCode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CipherSuiteCode>k__BackingField = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00008B2C File Offset: 0x00006D2C
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00008B40 File Offset: 0x00006D40
		public TlsProtocols ProtocolVersion
		{
			[CompilerGenerated]
			get
			{
				return this.<ProtocolVersion>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ProtocolVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00008B54 File Offset: 0x00006D54
		public string PeerDomainName
		{
			[CompilerGenerated]
			set
			{
				this.<PeerDomainName>k__BackingField = value;
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00008B68 File Offset: 0x00006D68
		public override string ToString()
		{
			TlsProtocols tlsProtocols = this.<ProtocolVersion>k__BackingField;
			CipherSuiteCode cipherSuiteCode = this.<CipherSuiteCode>k__BackingField;
			string text;
			return text;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00008B84 File Offset: 0x00006D84
		public MonoTlsConnectionInfo()
		{
		}

		// Token: 0x04000225 RID: 549
		[CompilerGenerated]
		private CipherSuiteCode <CipherSuiteCode>k__BackingField;

		// Token: 0x04000226 RID: 550
		[CompilerGenerated]
		private TlsProtocols <ProtocolVersion>k__BackingField;

		// Token: 0x04000227 RID: 551
		[CompilerGenerated]
		private string <PeerDomainName>k__BackingField;
	}
}
