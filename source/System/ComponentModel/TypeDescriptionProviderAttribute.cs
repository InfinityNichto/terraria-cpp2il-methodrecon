using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x020003C2 RID: 962
	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	public sealed class TypeDescriptionProviderAttribute : Attribute
	{
		// Token: 0x06001997 RID: 6551 RVA: 0x000475AC File Offset: 0x000457AC
		public TypeDescriptionProviderAttribute(string typeName)
		{
			do
			{
				base..ctor();
			}
			while (typeName == null);
			this.TypeName = typeName;
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x000475CC File Offset: 0x000457CC
		public TypeDescriptionProviderAttribute(Type type)
		{
			if (!true)
			{
			}
			this.TypeName = type;
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001999 RID: 6553 RVA: 0x000475EC File Offset: 0x000457EC
		public string TypeName
		{
			[CompilerGenerated]
			get
			{
				return this.<TypeName>k__BackingField;
			}
		}

		// Token: 0x040012D7 RID: 4823
		[CompilerGenerated]
		private readonly string <TypeName>k__BackingField;
	}
}
