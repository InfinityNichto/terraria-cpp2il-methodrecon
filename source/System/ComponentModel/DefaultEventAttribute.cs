using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x02000368 RID: 872
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DefaultEventAttribute : Attribute
	{
		// Token: 0x060016BD RID: 5821 RVA: 0x0004230C File Offset: 0x0004050C
		public DefaultEventAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x00042328 File Offset: 0x00040528
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x0004233C File Offset: 0x0004053C
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			string text = this.<Name>k__BackingField;
			bool flag;
			return flag;
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00042358 File Offset: 0x00040558
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x0004236C File Offset: 0x0004056C
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultEventAttribute()
		{
		}

		// Token: 0x040011FA RID: 4602
		[CompilerGenerated]
		private readonly string <Name>k__BackingField;

		// Token: 0x040011FB RID: 4603
		public static readonly DefaultEventAttribute Default;
	}
}
