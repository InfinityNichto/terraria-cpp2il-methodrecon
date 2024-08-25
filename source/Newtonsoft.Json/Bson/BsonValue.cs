using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000126 RID: 294
	[Preserve]
	internal class BsonValue : BsonToken
	{
		// Token: 0x06000B73 RID: 2931 RVA: 0x0001BBA4 File Offset: 0x00019DA4
		public BsonValue(object value, BsonType type)
		{
			this._value = value;
			this._type = type;
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x0001BBC8 File Offset: 0x00019DC8
		public object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x0001BBDC File Offset: 0x00019DDC
		public override BsonType Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x04000450 RID: 1104
		private readonly object _value;

		// Token: 0x04000451 RID: 1105
		private readonly BsonType _type;
	}
}
