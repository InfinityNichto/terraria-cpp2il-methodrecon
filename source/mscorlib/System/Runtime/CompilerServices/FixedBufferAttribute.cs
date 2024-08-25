using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000470 RID: 1136
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	public sealed class FixedBufferAttribute : Attribute
	{
		// Token: 0x0600220E RID: 8718 RVA: 0x0004CDD4 File Offset: 0x0004AFD4
		public FixedBufferAttribute(Type elementType, int length)
		{
			this.ElementType = elementType;
			this.Length = length;
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x0004CDF8 File Offset: 0x0004AFF8
		public Type ElementType
		{
			[CompilerGenerated]
			get
			{
				return this.<ElementType>k__BackingField;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06002210 RID: 8720 RVA: 0x0004CE0C File Offset: 0x0004B00C
		public int Length
		{
			[CompilerGenerated]
			get
			{
				return this.<Length>k__BackingField;
			}
		}

		// Token: 0x040012B0 RID: 4784
		[CompilerGenerated]
		private readonly Type <ElementType>k__BackingField;

		// Token: 0x040012B1 RID: 4785
		[CompilerGenerated]
		private readonly int <Length>k__BackingField;
	}
}
