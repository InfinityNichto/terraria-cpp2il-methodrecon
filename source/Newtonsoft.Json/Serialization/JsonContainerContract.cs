using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007C RID: 124
	[Preserve]
	public class JsonContainerContract : JsonContract
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x0000B9FC File Offset: 0x00009BFC
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x0000BA10 File Offset: 0x00009C10
		internal JsonContract ItemContract
		{
			get
			{
				return this._itemContract;
			}
			set
			{
				this._itemContract = value;
				if (value != null)
				{
					bool isSealed = value.<UnderlyingType>k__BackingField.IsSealed;
					JsonContract itemContract = this._itemContract;
					this._finalItemContract = itemContract;
					return;
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0000BA44 File Offset: 0x00009C44
		internal JsonContract FinalItemContract
		{
			get
			{
				return this._finalItemContract;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0000BA58 File Offset: 0x00009C58
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x0000BA6C File Offset: 0x00009C6C
		public JsonConverter ItemConverter
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemConverter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ItemConverter>k__BackingField = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0000BA80 File Offset: 0x00009C80
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x0000BA94 File Offset: 0x00009C94
		public bool? ItemIsReference
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemIsReference>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ItemIsReference>k__BackingField = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		public ReferenceLoopHandling? ItemReferenceLoopHandling
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x0000BAB8 File Offset: 0x00009CB8
		public TypeNameHandling? ItemTypeNameHandling
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000BAC8 File Offset: 0x00009CC8
		internal JsonContainerContract(Type underlyingType)
			: base(underlyingType)
		{
			if (!true)
			{
			}
			JsonContainerAttribute cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>(underlyingType);
			if (cachedAttribute != null)
			{
				Type <ItemConverterType>k__BackingField = cachedAttribute.<ItemConverterType>k__BackingField;
				if (<ItemConverterType>k__BackingField != null)
				{
					object[] <ItemConverterParameters>k__BackingField = cachedAttribute.<ItemConverterParameters>k__BackingField;
					if (!true)
					{
					}
					JsonConverter jsonConverter = JsonTypeReflector.CreateJsonConverterInstance(<ItemConverterType>k__BackingField, <ItemConverterParameters>k__BackingField);
					this.ItemConverter = jsonConverter;
				}
				bool? itemIsReference = cachedAttribute._itemIsReference;
				this.ItemIsReference = itemIsReference;
			}
		}

		// Token: 0x0400020B RID: 523
		private JsonContract _itemContract;

		// Token: 0x0400020C RID: 524
		private JsonContract _finalItemContract;

		// Token: 0x0400020D RID: 525
		[CompilerGenerated]
		private JsonConverter <ItemConverter>k__BackingField;

		// Token: 0x0400020E RID: 526
		[CompilerGenerated]
		private bool? <ItemIsReference>k__BackingField;

		// Token: 0x0400020F RID: 527
		[CompilerGenerated]
		private ReferenceLoopHandling? <ItemReferenceLoopHandling>k__BackingField;

		// Token: 0x04000210 RID: 528
		[CompilerGenerated]
		private TypeNameHandling? <ItemTypeNameHandling>k__BackingField;
	}
}
