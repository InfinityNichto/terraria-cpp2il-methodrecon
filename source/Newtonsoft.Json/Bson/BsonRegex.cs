using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000129 RID: 297
	[Preserve]
	internal class BsonRegex : BsonToken
	{
		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x0001BCB0 File Offset: 0x00019EB0
		// (set) Token: 0x06000B7F RID: 2943 RVA: 0x0001BCC4 File Offset: 0x00019EC4
		public BsonString Pattern
		{
			[CompilerGenerated]
			get
			{
				return this.<Pattern>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Pattern>k__BackingField = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x0001BCD8 File Offset: 0x00019ED8
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x0001BCEC File Offset: 0x00019EEC
		public BsonString Options
		{
			[CompilerGenerated]
			get
			{
				return this.<Options>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Options>k__BackingField = value;
			}
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0001BD00 File Offset: 0x00019F00
		public BsonRegex(string pattern, string options)
		{
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x0000212A File Offset: 0x0000032A
		public override BsonType Type
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x04000455 RID: 1109
		[CompilerGenerated]
		private BsonString <Pattern>k__BackingField;

		// Token: 0x04000456 RID: 1110
		[CompilerGenerated]
		private BsonString <Options>k__BackingField;
	}
}
