using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200048D RID: 1165
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false, AllowMultiple = false)]
	internal class ReflectionBlockedAttribute : Attribute
	{
		// Token: 0x06002256 RID: 8790 RVA: 0x0004D43C File Offset: 0x0004B63C
		public ReflectionBlockedAttribute()
		{
		}
	}
}
