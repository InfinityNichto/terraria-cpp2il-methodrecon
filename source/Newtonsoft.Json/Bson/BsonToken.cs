using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000123 RID: 291
	[Preserve]
	internal abstract class BsonToken
	{
		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000B63 RID: 2915
		public abstract BsonType Type { get; }

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0001BAC8 File Offset: 0x00019CC8
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x0001BADC File Offset: 0x00019CDC
		public BsonToken Parent
		{
			[CompilerGenerated]
			get
			{
				return this.<Parent>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Parent>k__BackingField = value;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x0001BAF0 File Offset: 0x00019CF0
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x0001BB04 File Offset: 0x00019D04
		public int CalculatedSize
		{
			[CompilerGenerated]
			get
			{
				return this.<CalculatedSize>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CalculatedSize>k__BackingField = value;
			}
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0001BB18 File Offset: 0x00019D18
		protected BsonToken()
		{
		}

		// Token: 0x0400044C RID: 1100
		[CompilerGenerated]
		private BsonToken <Parent>k__BackingField;

		// Token: 0x0400044D RID: 1101
		[CompilerGenerated]
		private int <CalculatedSize>k__BackingField;
	}
}
