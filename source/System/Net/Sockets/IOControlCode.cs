using System;

namespace System.Net.Sockets
{
	// Token: 0x020002F8 RID: 760
	public enum IOControlCode : long
	{
		// Token: 0x04001003 RID: 4099
		AsyncIO = 2147772029L,
		// Token: 0x04001004 RID: 4100
		NonBlockingIO,
		// Token: 0x04001005 RID: 4101
		DataToRead = 1074030207L,
		// Token: 0x04001006 RID: 4102
		OobDataRead = 1074033415L,
		// Token: 0x04001007 RID: 4103
		AssociateHandle = 2281701377L,
		// Token: 0x04001008 RID: 4104
		EnableCircularQueuing = 671088642L,
		// Token: 0x04001009 RID: 4105
		Flush = 671088644L,
		// Token: 0x0400100A RID: 4106
		GetBroadcastAddress = 1207959557L,
		// Token: 0x0400100B RID: 4107
		GetExtensionFunctionPointer = 3355443206L,
		// Token: 0x0400100C RID: 4108
		GetQos,
		// Token: 0x0400100D RID: 4109
		GetGroupQos,
		// Token: 0x0400100E RID: 4110
		MultipointLoopback = 2281701385L,
		// Token: 0x0400100F RID: 4111
		MulticastScope,
		// Token: 0x04001010 RID: 4112
		SetQos,
		// Token: 0x04001011 RID: 4113
		SetGroupQos,
		// Token: 0x04001012 RID: 4114
		TranslateHandle = 3355443213L,
		// Token: 0x04001013 RID: 4115
		RoutingInterfaceQuery = 3355443220L,
		// Token: 0x04001014 RID: 4116
		RoutingInterfaceChange = 2281701397L,
		// Token: 0x04001015 RID: 4117
		AddressListQuery = 1207959574L,
		// Token: 0x04001016 RID: 4118
		AddressListChange = 671088663L,
		// Token: 0x04001017 RID: 4119
		QueryTargetPnpHandle = 1207959576L,
		// Token: 0x04001018 RID: 4120
		NamespaceChange = 2281701401L,
		// Token: 0x04001019 RID: 4121
		AddressListSort = 3355443225L,
		// Token: 0x0400101A RID: 4122
		ReceiveAll = 2550136833L,
		// Token: 0x0400101B RID: 4123
		ReceiveAllMulticast,
		// Token: 0x0400101C RID: 4124
		ReceiveAllIgmpMulticast,
		// Token: 0x0400101D RID: 4125
		KeepAliveValues,
		// Token: 0x0400101E RID: 4126
		AbsorbRouterAlert,
		// Token: 0x0400101F RID: 4127
		UnicastInterface,
		// Token: 0x04001020 RID: 4128
		LimitBroadcasts,
		// Token: 0x04001021 RID: 4129
		BindToInterface,
		// Token: 0x04001022 RID: 4130
		MulticastInterface,
		// Token: 0x04001023 RID: 4131
		AddMulticastGroupOnInterface,
		// Token: 0x04001024 RID: 4132
		DeleteMulticastGroupFromInterface
	}
}
