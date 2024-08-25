using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x02000369 RID: 873
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DefaultPropertyAttribute : Attribute
	{
		// Token: 0x060016C2 RID: 5826 RVA: 0x0004237C File Offset: 0x0004057C
		public DefaultPropertyAttribute(string name)
		{
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x00042390 File Offset: 0x00040590
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x000423A4 File Offset: 0x000405A4
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			string text = this.<Name>k__BackingField;
			bool flag;
			return flag;
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x000423C0 File Offset: 0x000405C0
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x000423D4 File Offset: 0x000405D4
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultPropertyAttribute()
		{
		}

		// Token: 0x040011FC RID: 4604
		[CompilerGenerated]
		private readonly string <Name>k__BackingField;

		// Token: 0x040011FD RID: 4605
		public static readonly DefaultPropertyAttribute Default;
	}
}
