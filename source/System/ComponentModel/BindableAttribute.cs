using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x0200034F RID: 847
	[AttributeUsage(AttributeTargets.All)]
	public sealed class BindableAttribute : Attribute
	{
		// Token: 0x06001606 RID: 5638 RVA: 0x00040F98 File Offset: 0x0003F198
		public BindableAttribute(bool bindable)
		{
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00040FAC File Offset: 0x0003F1AC
		public BindableAttribute(bool bindable, BindingDirection direction)
		{
			this.Direction = direction;
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00040FC8 File Offset: 0x0003F1C8
		public BindableAttribute(BindableSupport flags)
		{
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00040FDC File Offset: 0x0003F1DC
		public BindableAttribute(BindableSupport flags, BindingDirection direction)
		{
			this.Direction = direction;
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x00040FF8 File Offset: 0x0003F1F8
		public bool Bindable
		{
			[CompilerGenerated]
			get
			{
				return this.<Bindable>k__BackingField;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x0004100C File Offset: 0x0003F20C
		public BindingDirection Direction
		{
			[CompilerGenerated]
			get
			{
				return this.<Direction>k__BackingField;
			}
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x00041020 File Offset: 0x0003F220
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			return true;
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x0004103C File Offset: 0x0003F23C
		public override int GetHashCode()
		{
			bool flag = this.<Bindable>k__BackingField;
			int num;
			return num;
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00041054 File Offset: 0x0003F254
		public override bool IsDefaultAttribute()
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x00041070 File Offset: 0x0003F270
		// Note: this type is marked as 'beforefieldinit'.
		static BindableAttribute()
		{
		}

		// Token: 0x040011BE RID: 4542
		public static readonly BindableAttribute Yes;

		// Token: 0x040011BF RID: 4543
		public static readonly BindableAttribute No;

		// Token: 0x040011C0 RID: 4544
		public static readonly BindableAttribute Default;

		// Token: 0x040011C1 RID: 4545
		private bool _isDefault;

		// Token: 0x040011C2 RID: 4546
		[CompilerGenerated]
		private readonly bool <Bindable>k__BackingField;

		// Token: 0x040011C3 RID: 4547
		[CompilerGenerated]
		private readonly BindingDirection <Direction>k__BackingField;
	}
}
