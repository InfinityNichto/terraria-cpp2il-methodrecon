using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000128 RID: 296
	[Preserve]
	internal class BsonBinary : BsonValue
	{
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0001BC60 File Offset: 0x00019E60
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x0001BC74 File Offset: 0x00019E74
		public BsonBinaryType BinaryType
		{
			[CompilerGenerated]
			get
			{
				return this.<BinaryType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<BinaryType>k__BackingField = value;
			}
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0001BC88 File Offset: 0x00019E88
		public BsonBinary(byte[] value, BsonBinaryType binaryType)
		{
			this._value = value;
			this._type = BsonType.Binary;
			this.BinaryType = binaryType;
		}

		// Token: 0x04000454 RID: 1108
		[CompilerGenerated]
		private BsonBinaryType <BinaryType>k__BackingField;
	}
}
