using System;

namespace System.Net
{
	// Token: 0x020001A6 RID: 422
	internal enum SecurityStatus
	{
		// Token: 0x0400086D RID: 2157
		OK,
		// Token: 0x0400086E RID: 2158
		ContinueNeeded = 590610,
		// Token: 0x0400086F RID: 2159
		CompleteNeeded,
		// Token: 0x04000870 RID: 2160
		CompAndContinue,
		// Token: 0x04000871 RID: 2161
		ContextExpired = 590615,
		// Token: 0x04000872 RID: 2162
		CredentialsNeeded = 590624,
		// Token: 0x04000873 RID: 2163
		Renegotiate,
		// Token: 0x04000874 RID: 2164
		OutOfMemory = -2146893056,
		// Token: 0x04000875 RID: 2165
		InvalidHandle,
		// Token: 0x04000876 RID: 2166
		Unsupported,
		// Token: 0x04000877 RID: 2167
		TargetUnknown,
		// Token: 0x04000878 RID: 2168
		InternalError,
		// Token: 0x04000879 RID: 2169
		PackageNotFound,
		// Token: 0x0400087A RID: 2170
		NotOwner,
		// Token: 0x0400087B RID: 2171
		CannotInstall,
		// Token: 0x0400087C RID: 2172
		InvalidToken,
		// Token: 0x0400087D RID: 2173
		CannotPack,
		// Token: 0x0400087E RID: 2174
		QopNotSupported,
		// Token: 0x0400087F RID: 2175
		NoImpersonation,
		// Token: 0x04000880 RID: 2176
		LogonDenied,
		// Token: 0x04000881 RID: 2177
		UnknownCredentials,
		// Token: 0x04000882 RID: 2178
		NoCredentials,
		// Token: 0x04000883 RID: 2179
		MessageAltered,
		// Token: 0x04000884 RID: 2180
		OutOfSequence,
		// Token: 0x04000885 RID: 2181
		NoAuthenticatingAuthority,
		// Token: 0x04000886 RID: 2182
		IncompleteMessage = -2146893032,
		// Token: 0x04000887 RID: 2183
		IncompleteCredentials = -2146893024,
		// Token: 0x04000888 RID: 2184
		BufferNotEnough,
		// Token: 0x04000889 RID: 2185
		WrongPrincipal,
		// Token: 0x0400088A RID: 2186
		TimeSkew = -2146893020,
		// Token: 0x0400088B RID: 2187
		UntrustedRoot,
		// Token: 0x0400088C RID: 2188
		IllegalMessage,
		// Token: 0x0400088D RID: 2189
		CertUnknown,
		// Token: 0x0400088E RID: 2190
		CertExpired,
		// Token: 0x0400088F RID: 2191
		AlgorithmMismatch = -2146893007,
		// Token: 0x04000890 RID: 2192
		SecurityQosFailed,
		// Token: 0x04000891 RID: 2193
		SmartcardLogonRequired = -2146892994,
		// Token: 0x04000892 RID: 2194
		UnsupportedPreauth = -2146892989,
		// Token: 0x04000893 RID: 2195
		BadBinding = -2146892986
	}
}
