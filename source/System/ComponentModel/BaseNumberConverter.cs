using System;
using System.Globalization;

namespace System.ComponentModel
{
	// Token: 0x0200034E RID: 846
	public abstract class BaseNumberConverter : TypeConverter
	{
		// Token: 0x060015FC RID: 5628 RVA: 0x00040EA8 File Offset: 0x0003F0A8
		internal BaseNumberConverter()
		{
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x00040EBC File Offset: 0x0003F0BC
		internal virtual bool AllowHex
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060015FE RID: 5630
		internal abstract Type TargetType { get; }

		// Token: 0x060015FF RID: 5631
		internal abstract object FromString(string value, int radix);

		// Token: 0x06001600 RID: 5632
		internal abstract object FromString(string value, NumberFormatInfo formatInfo);

		// Token: 0x06001601 RID: 5633
		internal abstract string ToString(object value, NumberFormatInfo formatInfo);

		// Token: 0x06001602 RID: 5634 RVA: 0x00040ECC File Offset: 0x0003F0CC
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = sourceType == type;
			return true;
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00040EE8 File Offset: 0x0003F0E8
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value != null)
			{
			}
			return base.ConvertFrom(context, culture, value);
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00040F48 File Offset: 0x0003F148
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			do
			{
				if (!true)
				{
				}
				Type type;
				bool flag = destinationType == type;
			}
			while (culture != null);
			if (CultureInfo.CurrentCulture != null)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00040F78 File Offset: 0x0003F178
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			bool flag = base.CanConvertTo(context, destinationType);
			return true;
		}
	}
}
