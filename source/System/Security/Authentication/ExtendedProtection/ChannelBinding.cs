using System;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Authentication.ExtendedProtection
{
	// Token: 0x020000E8 RID: 232
	public abstract class ChannelBinding : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000543 RID: 1347
		public abstract int Size { get; }
	}
}
