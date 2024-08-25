using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000463 RID: 1123
	[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	[Serializable]
	public sealed class AsyncStateMachineAttribute : StateMachineAttribute
	{
		// Token: 0x060021F2 RID: 8690 RVA: 0x0004CBD0 File Offset: 0x0004ADD0
		public AsyncStateMachineAttribute(Type stateMachineType)
		{
			this.<StateMachineType>k__BackingField = stateMachineType;
		}
	}
}
