using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000084 RID: 132
	[Preserve]
	public class JsonPrimitiveContract : JsonContract
	{
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0000C868 File Offset: 0x0000AA68
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x0000C87C File Offset: 0x0000AA7C
		internal PrimitiveTypeCode TypeCode
		{
			[CompilerGenerated]
			get
			{
				return this.<TypeCode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<TypeCode>k__BackingField = value;
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0000C890 File Offset: 0x0000AA90
		public JsonPrimitiveContract(Type underlyingType)
			: base(underlyingType)
		{
			this.ContractType = JsonContractType.Primitive;
			if (3 == 0)
			{
			}
			PrimitiveTypeCode typeCode = ConvertUtils.GetTypeCode(underlyingType);
			this.TypeCode = typeCode;
			this.IsReadOnlyOrFixedSize = true;
			if (!true)
			{
			}
			Type nonNullableUnderlyingType = this.NonNullableUnderlyingType;
			this.InternalReadType = ReadType.ReadAsInt32;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0000C8D4 File Offset: 0x0000AAD4
		// Note: this type is marked as 'beforefieldinit'.
		static JsonPrimitiveContract()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0400021E RID: 542
		[CompilerGenerated]
		private PrimitiveTypeCode <TypeCode>k__BackingField;

		// Token: 0x0400021F RID: 543
		private static readonly Dictionary<Type, ReadType> ReadTypeMap;
	}
}
