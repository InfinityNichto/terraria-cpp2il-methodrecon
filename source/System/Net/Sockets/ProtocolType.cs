using System;

namespace System.Net.Sockets
{
	// Token: 0x020002FC RID: 764
	public enum ProtocolType
	{
		// Token: 0x0400102D RID: 4141
		IP,
		// Token: 0x0400102E RID: 4142
		IPv6HopByHopOptions = 0,
		// Token: 0x0400102F RID: 4143
		Icmp,
		// Token: 0x04001030 RID: 4144
		Igmp,
		// Token: 0x04001031 RID: 4145
		Ggp,
		// Token: 0x04001032 RID: 4146
		IPv4,
		// Token: 0x04001033 RID: 4147
		Tcp = 6,
		// Token: 0x04001034 RID: 4148
		Pup = 12,
		// Token: 0x04001035 RID: 4149
		Udp = 17,
		// Token: 0x04001036 RID: 4150
		Idp = 22,
		// Token: 0x04001037 RID: 4151
		IPv6 = 41,
		// Token: 0x04001038 RID: 4152
		IPv6RoutingHeader = 43,
		// Token: 0x04001039 RID: 4153
		IPv6FragmentHeader,
		// Token: 0x0400103A RID: 4154
		IPSecEncapsulatingSecurityPayload = 50,
		// Token: 0x0400103B RID: 4155
		IPSecAuthenticationHeader,
		// Token: 0x0400103C RID: 4156
		IcmpV6 = 58,
		// Token: 0x0400103D RID: 4157
		IPv6NoNextHeader,
		// Token: 0x0400103E RID: 4158
		IPv6DestinationOptions,
		// Token: 0x0400103F RID: 4159
		ND = 77,
		// Token: 0x04001040 RID: 4160
		Raw = 255,
		// Token: 0x04001041 RID: 4161
		Unspecified = 0,
		// Token: 0x04001042 RID: 4162
		Ipx = 1000,
		// Token: 0x04001043 RID: 4163
		Spx = 1256,
		// Token: 0x04001044 RID: 4164
		SpxII,
		// Token: 0x04001045 RID: 4165
		Unknown = -1
	}
}
