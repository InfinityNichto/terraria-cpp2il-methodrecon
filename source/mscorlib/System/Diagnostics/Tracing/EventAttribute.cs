using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020005D9 RID: 1497
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class EventAttribute : Attribute
	{
		// Token: 0x06002D7B RID: 11643 RVA: 0x00064AB4 File Offset: 0x00062CB4
		public EventAttribute(int eventId)
		{
			this.EventId = eventId;
		}

		// Token: 0x170006E9 RID: 1769
		// (set) Token: 0x06002D7C RID: 11644 RVA: 0x00064AD0 File Offset: 0x00062CD0
		private int EventId
		{
			[CompilerGenerated]
			set
			{
				this.<EventId>k__BackingField = value;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (set) Token: 0x06002D7D RID: 11645 RVA: 0x00064AE4 File Offset: 0x00062CE4
		public EventLevel Level
		{
			[CompilerGenerated]
			set
			{
				this.<Level>k__BackingField = value;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (set) Token: 0x06002D7E RID: 11646 RVA: 0x00064AF8 File Offset: 0x00062CF8
		public EventKeywords Keywords
		{
			[CompilerGenerated]
			set
			{
				this.<Keywords>k__BackingField = value;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (set) Token: 0x06002D7F RID: 11647 RVA: 0x00064B0C File Offset: 0x00062D0C
		public string Message
		{
			[CompilerGenerated]
			set
			{
				this.<Message>k__BackingField = value;
			}
		}

		// Token: 0x04001987 RID: 6535
		[CompilerGenerated]
		private int <EventId>k__BackingField;

		// Token: 0x04001988 RID: 6536
		[CompilerGenerated]
		private EventLevel <Level>k__BackingField;

		// Token: 0x04001989 RID: 6537
		[CompilerGenerated]
		private EventKeywords <Keywords>k__BackingField;

		// Token: 0x0400198A RID: 6538
		[CompilerGenerated]
		private string <Message>k__BackingField;
	}
}
