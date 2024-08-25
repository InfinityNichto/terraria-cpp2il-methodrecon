using System;

namespace System.Net.Sockets
{
	// Token: 0x02000302 RID: 770
	public enum SocketOptionName
	{
		// Token: 0x04001097 RID: 4247
		Debug = 1,
		// Token: 0x04001098 RID: 4248
		AcceptConnection,
		// Token: 0x04001099 RID: 4249
		ReuseAddress = 4,
		// Token: 0x0400109A RID: 4250
		KeepAlive = 8,
		// Token: 0x0400109B RID: 4251
		DontRoute = 16,
		// Token: 0x0400109C RID: 4252
		Broadcast = 32,
		// Token: 0x0400109D RID: 4253
		UseLoopback = 64,
		// Token: 0x0400109E RID: 4254
		Linger = 128,
		// Token: 0x0400109F RID: 4255
		OutOfBandInline = 256,
		// Token: 0x040010A0 RID: 4256
		DontLinger = -129,
		// Token: 0x040010A1 RID: 4257
		ExclusiveAddressUse = -5,
		// Token: 0x040010A2 RID: 4258
		SendBuffer = 4097,
		// Token: 0x040010A3 RID: 4259
		ReceiveBuffer,
		// Token: 0x040010A4 RID: 4260
		SendLowWater,
		// Token: 0x040010A5 RID: 4261
		ReceiveLowWater,
		// Token: 0x040010A6 RID: 4262
		SendTimeout,
		// Token: 0x040010A7 RID: 4263
		ReceiveTimeout,
		// Token: 0x040010A8 RID: 4264
		Error,
		// Token: 0x040010A9 RID: 4265
		Type,
		// Token: 0x040010AA RID: 4266
		ReuseUnicastPort = 12295,
		// Token: 0x040010AB RID: 4267
		MaxConnections = 2147483647,
		// Token: 0x040010AC RID: 4268
		IPOptions = 1,
		// Token: 0x040010AD RID: 4269
		HeaderIncluded,
		// Token: 0x040010AE RID: 4270
		TypeOfService,
		// Token: 0x040010AF RID: 4271
		IpTimeToLive,
		// Token: 0x040010B0 RID: 4272
		MulticastInterface = 9,
		// Token: 0x040010B1 RID: 4273
		MulticastTimeToLive,
		// Token: 0x040010B2 RID: 4274
		MulticastLoopback,
		// Token: 0x040010B3 RID: 4275
		AddMembership,
		// Token: 0x040010B4 RID: 4276
		DropMembership,
		// Token: 0x040010B5 RID: 4277
		DontFragment,
		// Token: 0x040010B6 RID: 4278
		AddSourceMembership,
		// Token: 0x040010B7 RID: 4279
		DropSourceMembership,
		// Token: 0x040010B8 RID: 4280
		BlockSource,
		// Token: 0x040010B9 RID: 4281
		UnblockSource,
		// Token: 0x040010BA RID: 4282
		PacketInformation,
		// Token: 0x040010BB RID: 4283
		HopLimit = 21,
		// Token: 0x040010BC RID: 4284
		IPProtectionLevel = 23,
		// Token: 0x040010BD RID: 4285
		IPv6Only = 27,
		// Token: 0x040010BE RID: 4286
		NoDelay = 1,
		// Token: 0x040010BF RID: 4287
		BsdUrgent,
		// Token: 0x040010C0 RID: 4288
		Expedited = 2,
		// Token: 0x040010C1 RID: 4289
		NoChecksum = 1,
		// Token: 0x040010C2 RID: 4290
		ChecksumCoverage = 20,
		// Token: 0x040010C3 RID: 4291
		UpdateAcceptContext = 28683,
		// Token: 0x040010C4 RID: 4292
		UpdateConnectContext = 28688
	}
}
