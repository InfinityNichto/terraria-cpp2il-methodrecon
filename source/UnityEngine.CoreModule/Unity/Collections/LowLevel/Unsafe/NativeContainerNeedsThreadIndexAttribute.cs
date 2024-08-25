using System;
using UnityEngine.Scripting;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000028 RID: 40
	[RequiredByNativeCode]
	[Obsolete("Use NativeSetThreadIndexAttribute instead")]
	[AttributeUsage(AttributeTargets.Struct)]
	public sealed class NativeContainerNeedsThreadIndexAttribute : Attribute
	{
	}
}
