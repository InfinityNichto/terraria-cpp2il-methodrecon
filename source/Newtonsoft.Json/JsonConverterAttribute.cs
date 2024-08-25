using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000022 RID: 34
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter, AllowMultiple = false)]
	[Preserve]
	public sealed class JsonConverterAttribute : Attribute
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002984 File Offset: 0x00000B84
		public Type ConverterType
		{
			get
			{
				return this._converterType;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002998 File Offset: 0x00000B98
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000029AC File Offset: 0x00000BAC
		public object[] ConverterParameters
		{
			[CompilerGenerated]
			get
			{
				return this.<ConverterParameters>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ConverterParameters>k__BackingField = value;
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000029C0 File Offset: 0x00000BC0
		public JsonConverterAttribute(Type converterType)
		{
			do
			{
				base..ctor();
			}
			while (converterType == null);
			this._converterType = converterType;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000029E0 File Offset: 0x00000BE0
		public JsonConverterAttribute(Type converterType, params object[] converterParameters)
		{
			this.ConverterParameters = converterParameters;
		}

		// Token: 0x04000054 RID: 84
		private readonly Type _converterType;

		// Token: 0x04000055 RID: 85
		[CompilerGenerated]
		private object[] <ConverterParameters>k__BackingField;
	}
}
