using System;
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x020003AA RID: 938
	public class NullableConverter : TypeConverter
	{
		// Token: 0x060018BA RID: 6330 RVA: 0x00045A4C File Offset: 0x00043C4C
		public NullableConverter(Type type)
		{
			this.NullableType = type;
			Type underlyingType = Nullable.GetUnderlyingType(type);
			this.UnderlyingType = underlyingType;
			if (!true)
			{
			}
			TypeConverter converter = TypeDescriptor.GetConverter(this.<UnderlyingType>k__BackingField);
			this.UnderlyingTypeConverter = converter;
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x00045A8C File Offset: 0x00043C8C
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			Type type = this.<UnderlyingType>k__BackingField;
			if (!true)
			{
			}
			bool flag = sourceType == type;
			return true;
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00045AC0 File Offset: 0x00043CC0
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
				Type type2 = this.<UnderlyingType>k__BackingField;
				bool flag = type == type2;
				return value;
			}
			if (this.<UnderlyingTypeConverter>k__BackingField != null)
			{
			}
			return base.ConvertFrom(context, culture, value);
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00045AFC File Offset: 0x00043CFC
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			Type type = this.<UnderlyingType>k__BackingField;
			if (!true)
			{
			}
			bool flag = destinationType == type;
			return true;
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00045B30 File Offset: 0x00043D30
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (!true)
			{
			}
			Type type = this.<UnderlyingType>k__BackingField;
			if (!true)
			{
			}
			bool flag = destinationType == type;
			if (value != null)
			{
				Type type2 = this.<NullableType>k__BackingField;
			}
			if (value == null || this.<UnderlyingTypeConverter>k__BackingField != null)
			{
				Type type3;
				bool flag2 = destinationType == type3;
			}
			object obj;
			return obj;
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00045B78 File Offset: 0x00043D78
		public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
		{
			if (this.<UnderlyingTypeConverter>k__BackingField != null)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00045B90 File Offset: 0x00043D90
		public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
		{
			if (this.<UnderlyingTypeConverter>k__BackingField != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00045BA8 File Offset: 0x00043DA8
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			if (this.<UnderlyingTypeConverter>k__BackingField != null)
			{
			}
			PropertyDescriptorCollection propertyDescriptorCollection;
			return propertyDescriptorCollection;
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00045BC0 File Offset: 0x00043DC0
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			if (this.<UnderlyingTypeConverter>k__BackingField != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00045BD8 File Offset: 0x00043DD8
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			TypeConverter typeConverter = this.<UnderlyingTypeConverter>k__BackingField;
			IEnumerator enumerator;
			if (typeConverter == null || typeConverter == null || enumerator == null || enumerator != null)
			{
				TypeConverter.StandardValuesCollection standardValuesCollection;
				return standardValuesCollection;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00045C24 File Offset: 0x00043E24
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			if (this.<UnderlyingTypeConverter>k__BackingField != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00045C3C File Offset: 0x00043E3C
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			if (this.<UnderlyingTypeConverter>k__BackingField != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00045C54 File Offset: 0x00043E54
		public override bool IsValid(ITypeDescriptorContext context, object value)
		{
			bool flag;
			return (this.<UnderlyingTypeConverter>k__BackingField != null && value == null) || flag;
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x00045C70 File Offset: 0x00043E70
		public Type NullableType
		{
			[CompilerGenerated]
			get
			{
				return this.<NullableType>k__BackingField;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060018C8 RID: 6344 RVA: 0x00045C84 File Offset: 0x00043E84
		public Type UnderlyingType
		{
			[CompilerGenerated]
			get
			{
				return this.<UnderlyingType>k__BackingField;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x00045C98 File Offset: 0x00043E98
		public TypeConverter UnderlyingTypeConverter
		{
			[CompilerGenerated]
			get
			{
				return this.<UnderlyingTypeConverter>k__BackingField;
			}
		}

		// Token: 0x0400129A RID: 4762
		[CompilerGenerated]
		private readonly Type <NullableType>k__BackingField;

		// Token: 0x0400129B RID: 4763
		[CompilerGenerated]
		private readonly Type <UnderlyingType>k__BackingField;

		// Token: 0x0400129C RID: 4764
		[CompilerGenerated]
		private readonly TypeConverter <UnderlyingTypeConverter>k__BackingField;
	}
}
