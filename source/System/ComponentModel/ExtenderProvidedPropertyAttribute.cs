using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x02000378 RID: 888
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ExtenderProvidedPropertyAttribute : Attribute
	{
		// Token: 0x0600174B RID: 5963 RVA: 0x00002050 File Offset: 0x00000250
		internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x000433AC File Offset: 0x000415AC
		public ExtenderProvidedPropertyAttribute()
		{
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600174D RID: 5965 RVA: 0x000433C0 File Offset: 0x000415C0
		// (set) Token: 0x0600174E RID: 5966 RVA: 0x000433D4 File Offset: 0x000415D4
		public PropertyDescriptor ExtenderProperty
		{
			[CompilerGenerated]
			get
			{
				return this.<ExtenderProperty>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ExtenderProperty>k__BackingField = value;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x000433E8 File Offset: 0x000415E8
		// (set) Token: 0x06001750 RID: 5968 RVA: 0x000433FC File Offset: 0x000415FC
		public IExtenderProvider Provider
		{
			[CompilerGenerated]
			get
			{
				return this.<Provider>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Provider>k__BackingField = value;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001751 RID: 5969 RVA: 0x00043410 File Offset: 0x00041610
		// (set) Token: 0x06001752 RID: 5970 RVA: 0x00043424 File Offset: 0x00041624
		public Type ReceiverType
		{
			[CompilerGenerated]
			get
			{
				return this.<ReceiverType>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ReceiverType>k__BackingField = value;
			}
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00043438 File Offset: 0x00041638
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				PropertyDescriptor propertyDescriptor = this.<ExtenderProperty>k__BackingField;
				IExtenderProvider extenderProvider = this.<Provider>k__BackingField;
				Type type = this.<ReceiverType>k__BackingField;
			}
			return true;
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x00043460 File Offset: 0x00041660
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00043474 File Offset: 0x00041674
		public override bool IsDefaultAttribute()
		{
			Type type = this.<ReceiverType>k__BackingField;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x04001228 RID: 4648
		[CompilerGenerated]
		private PropertyDescriptor <ExtenderProperty>k__BackingField;

		// Token: 0x04001229 RID: 4649
		[CompilerGenerated]
		private IExtenderProvider <Provider>k__BackingField;

		// Token: 0x0400122A RID: 4650
		[CompilerGenerated]
		private Type <ReceiverType>k__BackingField;
	}
}
