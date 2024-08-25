using System;
using System.Collections;
using System.Globalization;

namespace System.ComponentModel
{
	// Token: 0x020003B1 RID: 945
	public class ReferenceConverter : TypeConverter
	{
		// Token: 0x06001937 RID: 6455 RVA: 0x000469F4 File Offset: 0x00044BF4
		public ReferenceConverter(Type type)
		{
			this._type = type;
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00046A10 File Offset: 0x00044C10
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = sourceType == type;
			return context != null || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00046A38 File Offset: 0x00044C38
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value != null)
			{
			}
			return base.ConvertFrom(context, culture, value);
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00046A6C File Offset: 0x00044C6C
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = destinationType == type;
			if (value != null)
			{
				if (context != null)
				{
					object obj;
					return obj;
				}
			}
			else if (context == null || context == null || context == null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00046AA8 File Offset: 0x00044CA8
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			if (context != null)
			{
			}
			if (context != null)
			{
				if (context == null)
				{
					throw new InvalidCastException();
				}
				Type type = this._type;
			}
			if (context != null)
			{
				while (context == null)
				{
				}
				if (context != null)
				{
					Type type2 = this._type;
					long num = 0L;
					int num2 = 7;
					if (context != null)
					{
					}
					if (num != 0L)
					{
						throw new OutOfMemoryException();
					}
					if (num2 == 0)
					{
					}
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00046B0C File Offset: 0x00044D0C
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x00046B1C File Offset: 0x00044D1C
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00046B2C File Offset: 0x00044D2C
		protected virtual bool IsValueAllowed(ITypeDescriptorContext context, object value)
		{
			return true;
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00046B3C File Offset: 0x00044D3C
		// Note: this type is marked as 'beforefieldinit'.
		static ReferenceConverter()
		{
		}

		// Token: 0x040012B9 RID: 4793
		private static readonly string s_none;

		// Token: 0x040012BA RID: 4794
		private Type _type;

		// Token: 0x020003B2 RID: 946
		private class ReferenceComparer : IComparer
		{
			// Token: 0x06001940 RID: 6464 RVA: 0x00046B4C File Offset: 0x00044D4C
			public ReferenceComparer(ReferenceConverter converter)
			{
				this._converter = converter;
			}

			// Token: 0x06001941 RID: 6465 RVA: 0x00046B68 File Offset: 0x00044D68
			public int Compare(object item1, object item2)
			{
				string text = this._converter.ConvertToString(item1);
				string text2 = this._converter.ConvertToString(item2);
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				long num = 0L;
				return string.Compare(text, text2, num != 0L, invariantCulture);
			}

			// Token: 0x040012BB RID: 4795
			private ReferenceConverter _converter;
		}
	}
}
