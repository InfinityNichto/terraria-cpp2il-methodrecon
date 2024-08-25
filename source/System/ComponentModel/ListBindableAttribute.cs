using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x02000399 RID: 921
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ListBindableAttribute : Attribute
	{
		// Token: 0x060017F1 RID: 6129 RVA: 0x00043D2C File Offset: 0x00041F2C
		public ListBindableAttribute(bool listBindable)
		{
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00043D40 File Offset: 0x00041F40
		public ListBindableAttribute(BindableSupport flags)
		{
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060017F3 RID: 6131 RVA: 0x00043D54 File Offset: 0x00041F54
		public bool ListBindable
		{
			[CompilerGenerated]
			get
			{
				return this.<ListBindable>k__BackingField;
			}
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00043D68 File Offset: 0x00041F68
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			return true;
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00043D84 File Offset: 0x00041F84
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00043D98 File Offset: 0x00041F98
		public override bool IsDefaultAttribute()
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00043DB4 File Offset: 0x00041FB4
		// Note: this type is marked as 'beforefieldinit'.
		static ListBindableAttribute()
		{
		}

		// Token: 0x0400123B RID: 4667
		public static readonly ListBindableAttribute Yes;

		// Token: 0x0400123C RID: 4668
		public static readonly ListBindableAttribute No;

		// Token: 0x0400123D RID: 4669
		public static readonly ListBindableAttribute Default;

		// Token: 0x0400123E RID: 4670
		private bool _isDefault;

		// Token: 0x0400123F RID: 4671
		[CompilerGenerated]
		private readonly bool <ListBindable>k__BackingField;
	}
}
