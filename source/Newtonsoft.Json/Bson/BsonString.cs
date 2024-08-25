using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000127 RID: 295
	[Preserve]
	internal class BsonString : BsonValue
	{
		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0001BBF0 File Offset: 0x00019DF0
		// (set) Token: 0x06000B77 RID: 2935 RVA: 0x0001BC04 File Offset: 0x00019E04
		public int ByteCount
		{
			[CompilerGenerated]
			get
			{
				return this.<ByteCount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ByteCount>k__BackingField = value;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x0001BC18 File Offset: 0x00019E18
		// (set) Token: 0x06000B79 RID: 2937 RVA: 0x0001BC2C File Offset: 0x00019E2C
		public bool IncludeLength
		{
			[CompilerGenerated]
			get
			{
				return this.<IncludeLength>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0001BC3C File Offset: 0x00019E3C
		public BsonString(object value, bool includeLength)
		{
			this._value = value;
			this._type = BsonType.String;
		}

		// Token: 0x04000452 RID: 1106
		[CompilerGenerated]
		private int <ByteCount>k__BackingField;

		// Token: 0x04000453 RID: 1107
		[CompilerGenerated]
		private bool <IncludeLength>k__BackingField;
	}
}
