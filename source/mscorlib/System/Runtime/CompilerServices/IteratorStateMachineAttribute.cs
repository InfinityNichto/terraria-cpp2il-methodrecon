using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200047A RID: 1146
	[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	[Serializable]
	public sealed class IteratorStateMachineAttribute : StateMachineAttribute
	{
		// Token: 0x0600221F RID: 8735 RVA: 0x0004CF0C File Offset: 0x0004B10C
		public IteratorStateMachineAttribute(Type stateMachineType)
		{
			this.<StateMachineType>k__BackingField = stateMachineType;
		}
	}
}
