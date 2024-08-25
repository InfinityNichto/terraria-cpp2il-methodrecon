using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x02000340 RID: 832
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class InitializationEventAttribute : Attribute
	{
		// Token: 0x060015AB RID: 5547 RVA: 0x00040654 File Offset: 0x0003E854
		public InitializationEventAttribute(string eventName)
		{
			this.EventName = eventName;
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x00040670 File Offset: 0x0003E870
		public string EventName
		{
			[CompilerGenerated]
			get
			{
				return this.<EventName>k__BackingField;
			}
		}

		// Token: 0x040011A3 RID: 4515
		[CompilerGenerated]
		private readonly string <EventName>k__BackingField;
	}
}
