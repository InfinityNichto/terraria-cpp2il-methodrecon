using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200012A RID: 298
	[Preserve]
	internal class BsonProperty
	{
		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x0001BD14 File Offset: 0x00019F14
		// (set) Token: 0x06000B85 RID: 2949 RVA: 0x0001BD28 File Offset: 0x00019F28
		public BsonString Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x0001BD3C File Offset: 0x00019F3C
		// (set) Token: 0x06000B87 RID: 2951 RVA: 0x0001BD50 File Offset: 0x00019F50
		public BsonToken Value
		{
			[CompilerGenerated]
			get
			{
				return this.<Value>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0001BD64 File Offset: 0x00019F64
		public BsonProperty()
		{
		}

		// Token: 0x04000457 RID: 1111
		[CompilerGenerated]
		private BsonString <Name>k__BackingField;

		// Token: 0x04000458 RID: 1112
		[CompilerGenerated]
		private BsonToken <Value>k__BackingField;
	}
}
