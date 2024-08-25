using System;

namespace System.Net.Sockets
{
	// Token: 0x020002FF RID: 767
	public enum SocketError
	{
		// Token: 0x04001056 RID: 4182
		Success,
		// Token: 0x04001057 RID: 4183
		SocketError = -1,
		// Token: 0x04001058 RID: 4184
		Interrupted = 10004,
		// Token: 0x04001059 RID: 4185
		AccessDenied = 10013,
		// Token: 0x0400105A RID: 4186
		Fault,
		// Token: 0x0400105B RID: 4187
		InvalidArgument = 10022,
		// Token: 0x0400105C RID: 4188
		TooManyOpenSockets = 10024,
		// Token: 0x0400105D RID: 4189
		WouldBlock = 10035,
		// Token: 0x0400105E RID: 4190
		InProgress,
		// Token: 0x0400105F RID: 4191
		AlreadyInProgress,
		// Token: 0x04001060 RID: 4192
		NotSocket,
		// Token: 0x04001061 RID: 4193
		DestinationAddressRequired,
		// Token: 0x04001062 RID: 4194
		MessageSize,
		// Token: 0x04001063 RID: 4195
		ProtocolType,
		// Token: 0x04001064 RID: 4196
		ProtocolOption,
		// Token: 0x04001065 RID: 4197
		ProtocolNotSupported,
		// Token: 0x04001066 RID: 4198
		SocketNotSupported,
		// Token: 0x04001067 RID: 4199
		OperationNotSupported,
		// Token: 0x04001068 RID: 4200
		ProtocolFamilyNotSupported,
		// Token: 0x04001069 RID: 4201
		AddressFamilyNotSupported,
		// Token: 0x0400106A RID: 4202
		AddressAlreadyInUse,
		// Token: 0x0400106B RID: 4203
		AddressNotAvailable,
		// Token: 0x0400106C RID: 4204
		NetworkDown,
		// Token: 0x0400106D RID: 4205
		NetworkUnreachable,
		// Token: 0x0400106E RID: 4206
		NetworkReset,
		// Token: 0x0400106F RID: 4207
		ConnectionAborted,
		// Token: 0x04001070 RID: 4208
		ConnectionReset,
		// Token: 0x04001071 RID: 4209
		NoBufferSpaceAvailable,
		// Token: 0x04001072 RID: 4210
		IsConnected,
		// Token: 0x04001073 RID: 4211
		NotConnected,
		// Token: 0x04001074 RID: 4212
		Shutdown,
		// Token: 0x04001075 RID: 4213
		TimedOut = 10060,
		// Token: 0x04001076 RID: 4214
		ConnectionRefused,
		// Token: 0x04001077 RID: 4215
		HostDown = 10064,
		// Token: 0x04001078 RID: 4216
		HostUnreachable,
		// Token: 0x04001079 RID: 4217
		ProcessLimit = 10067,
		// Token: 0x0400107A RID: 4218
		SystemNotReady = 10091,
		// Token: 0x0400107B RID: 4219
		VersionNotSupported,
		// Token: 0x0400107C RID: 4220
		NotInitialized,
		// Token: 0x0400107D RID: 4221
		Disconnecting = 10101,
		// Token: 0x0400107E RID: 4222
		TypeNotFound = 10109,
		// Token: 0x0400107F RID: 4223
		HostNotFound = 11001,
		// Token: 0x04001080 RID: 4224
		TryAgain,
		// Token: 0x04001081 RID: 4225
		NoRecovery,
		// Token: 0x04001082 RID: 4226
		NoData,
		// Token: 0x04001083 RID: 4227
		IOPending = 997,
		// Token: 0x04001084 RID: 4228
		OperationAborted = 995
	}
}
