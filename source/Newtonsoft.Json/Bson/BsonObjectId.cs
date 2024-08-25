using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200012D RID: 301
	[Preserve]
	public class BsonObjectId
	{
		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x0001C1C4 File Offset: 0x0001A3C4
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x0001C1D8 File Offset: 0x0001A3D8
		public byte[] Value
		{
			[CompilerGenerated]
			get
			{
				return this.<Value>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0001C1EC File Offset: 0x0001A3EC
		public BsonObjectId(byte[] value)
		{
			ValidationUtils.ArgumentNotNull(value, "value");
			this.Value = value;
		}

		// Token: 0x04000472 RID: 1138
		[CompilerGenerated]
		private byte[] <Value>k__BackingField;
	}
}
