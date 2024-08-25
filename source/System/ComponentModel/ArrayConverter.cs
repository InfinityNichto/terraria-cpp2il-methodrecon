using System;
using System.Globalization;

namespace System.ComponentModel
{
	// Token: 0x02000348 RID: 840
	public class ArrayConverter : CollectionConverter
	{
		// Token: 0x060015DA RID: 5594 RVA: 0x00040AC4 File Offset: 0x0003ECC4
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = destinationType == type;
			if (value != null)
			{
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00040B00 File Offset: 0x0003ED00
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			if (value != null)
			{
				bool isArray = value.GetType().IsArray;
				Type type = value.GetType();
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00040B38 File Offset: 0x0003ED38
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00040B48 File Offset: 0x0003ED48
		public ArrayConverter()
		{
		}

		// Token: 0x02000349 RID: 841
		private class ArrayPropertyDescriptor : TypeConverter.SimplePropertyDescriptor
		{
			// Token: 0x060015DE RID: 5598 RVA: 0x00040B5C File Offset: 0x0003ED5C
			public ArrayPropertyDescriptor(Type arrayType, Type elementType, int index)
			{
				string text2;
				string text = "[" + text2 + "]";
				this._index = "[";
			}

			// Token: 0x060015DF RID: 5599 RVA: 0x00040B88 File Offset: 0x0003ED88
			public override object GetValue(object instance)
			{
				if (instance != null)
				{
					int index = this._index;
					object obj;
					return obj;
				}
			}

			// Token: 0x060015E0 RID: 5600 RVA: 0x00040BA8 File Offset: 0x0003EDA8
			public override void SetValue(object instance, object value)
			{
				if (instance != null)
				{
				}
			}

			// Token: 0x040011B2 RID: 4530
			private readonly int _index;
		}
	}
}
