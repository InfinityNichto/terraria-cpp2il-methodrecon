using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000082 RID: 130
	[Preserve]
	public class JsonISerializableContract : JsonContainerContract
	{
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0000C808 File Offset: 0x0000AA08
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x0000C81C File Offset: 0x0000AA1C
		public ObjectConstructor<object> ISerializableCreator
		{
			[CompilerGenerated]
			get
			{
				return this.<ISerializableCreator>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ISerializableCreator>k__BackingField = value;
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0000C830 File Offset: 0x0000AA30
		public JsonISerializableContract(Type underlyingType)
			: base(underlyingType)
		{
			this.ContractType = JsonContractType.Serializable;
		}

		// Token: 0x0400021D RID: 541
		[CompilerGenerated]
		private ObjectConstructor<object> <ISerializableCreator>k__BackingField;
	}
}
