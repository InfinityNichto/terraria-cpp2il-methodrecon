using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200047E RID: 1150
	[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	[Serializable]
	public class StateMachineAttribute : Attribute
	{
		// Token: 0x06002227 RID: 8743 RVA: 0x0004CFFC File Offset: 0x0004B1FC
		public StateMachineAttribute(Type stateMachineType)
		{
			this.StateMachineType = stateMachineType;
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x0004D018 File Offset: 0x0004B218
		public Type StateMachineType
		{
			[CompilerGenerated]
			get
			{
				return this.<StateMachineType>k__BackingField;
			}
		}

		// Token: 0x040012B6 RID: 4790
		[CompilerGenerated]
		private readonly Type <StateMachineType>k__BackingField;
	}
}
