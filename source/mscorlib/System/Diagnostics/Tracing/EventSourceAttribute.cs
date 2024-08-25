using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020005DC RID: 1500
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class EventSourceAttribute : Attribute
	{
		// Token: 0x170006F1 RID: 1777
		// (set) Token: 0x06002D92 RID: 11666 RVA: 0x00064CC0 File Offset: 0x00062EC0
		public string Guid
		{
			[CompilerGenerated]
			set
			{
				this.<Guid>k__BackingField = value;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (set) Token: 0x06002D93 RID: 11667 RVA: 0x00064CD4 File Offset: 0x00062ED4
		public string Name
		{
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x00064CE8 File Offset: 0x00062EE8
		public EventSourceAttribute()
		{
		}

		// Token: 0x0400198F RID: 6543
		[CompilerGenerated]
		private string <Guid>k__BackingField;

		// Token: 0x04001990 RID: 6544
		[CompilerGenerated]
		private string <Name>k__BackingField;
	}
}
