using System;

namespace System
{
	// Token: 0x0200008E RID: 142
	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	[Serializable]
	public sealed class AttributeUsageAttribute : Attribute
	{
		// Token: 0x06000406 RID: 1030 RVA: 0x0000C688 File Offset: 0x0000A888
		public AttributeUsageAttribute(AttributeTargets validOn)
		{
			this._attributeTarget = validOn;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0000C6B4 File Offset: 0x0000A8B4
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x0000C6C8 File Offset: 0x0000A8C8
		public bool AllowMultiple
		{
			get
			{
				return this._allowMultiple;
			}
			set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x0000C6EC File Offset: 0x0000A8EC
		public bool Inherited
		{
			get
			{
				return this._inherited;
			}
			set
			{
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000C6FC File Offset: 0x0000A8FC
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeUsageAttribute()
		{
		}

		// Token: 0x040001F7 RID: 503
		private AttributeTargets _attributeTarget = AttributeTargets.All;

		// Token: 0x040001F8 RID: 504
		private bool _allowMultiple;

		// Token: 0x040001F9 RID: 505
		private bool _inherited = true;

		// Token: 0x040001FA RID: 506
		internal static AttributeUsageAttribute Default;
	}
}
