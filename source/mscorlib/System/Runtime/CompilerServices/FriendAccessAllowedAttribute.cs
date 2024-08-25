using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200049C RID: 1180
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	[FriendAccessAllowed]
	internal sealed class FriendAccessAllowedAttribute : Attribute
	{
		// Token: 0x0600228C RID: 8844 RVA: 0x0004DAE0 File Offset: 0x0004BCE0
		public FriendAccessAllowedAttribute()
		{
		}
	}
}
