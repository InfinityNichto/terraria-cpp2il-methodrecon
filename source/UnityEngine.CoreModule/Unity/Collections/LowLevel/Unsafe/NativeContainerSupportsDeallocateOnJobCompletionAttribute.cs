using System;
using UnityEngine.Scripting;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000025 RID: 37
	[AttributeUsage(AttributeTargets.Struct)]
	[RequiredByNativeCode]
	public sealed class NativeContainerSupportsDeallocateOnJobCompletionAttribute : Attribute
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002398 File Offset: 0x00000598
		public NativeContainerSupportsDeallocateOnJobCompletionAttribute()
		{
		}
	}
}
