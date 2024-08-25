using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x0200035D RID: 861
	public class CultureInfoConverter : TypeConverter
	{
		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001675 RID: 5749 RVA: 0x000419F0 File Offset: 0x0003FBF0
		private string DefaultCultureString
		{
			get
			{
				return "(Default)";
			}
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual string GetCultureName(CultureInfo culture)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00041A04 File Offset: 0x0003FC04
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = sourceType == type;
			return true;
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x00041A28 File Offset: 0x0003FC28
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = destinationType == type;
			return true;
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00041A4C File Offset: 0x0003FC4C
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value != null)
			{
			}
			return base.ConvertFrom(context, culture, value);
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00041B84 File Offset: 0x0003FD84
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Type type;
			bool flag = destinationType == type;
			int num2 = 1;
			if (culture != null)
			{
				if (num2 == 0)
				{
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			}
			if (value != null)
			{
				if ("(Default)" == null)
				{
				}
				CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			}
			Type type2;
			if (value == null || ((type2 == null || type2 != null) && (value == null || value != null)))
			{
				object obj;
				return obj;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00041BF0 File Offset: 0x0003FDF0
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			int num = 1;
			if (this._values == null)
			{
				if (num == 0)
				{
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				CultureInfo[] array;
				int parent_lcid = array.parent_lcid;
				int parent_lcid2 = array.parent_lcid;
				int parent_lcid3 = array.parent_lcid;
				if (parent_lcid2 == 0)
				{
					if (parent_lcid2 == 0)
					{
					}
					CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
					if (invariantCulture2 == null || invariantCulture2 != null)
					{
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00041C4C File Offset: 0x0003FE4C
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00041C5C File Offset: 0x0003FE5C
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00041C6C File Offset: 0x0003FE6C
		public CultureInfoConverter()
		{
		}

		// Token: 0x040011E3 RID: 4579
		private TypeConverter.StandardValuesCollection _values;

		// Token: 0x040011E4 RID: 4580
		private const string DefaultInvariantCultureString = "(Default)";

		// Token: 0x0200035E RID: 862
		private class CultureComparer : IComparer
		{
			// Token: 0x0600167F RID: 5759 RVA: 0x00041C80 File Offset: 0x0003FE80
			public CultureComparer(CultureInfoConverter cultureConverter)
			{
				this._converter = cultureConverter;
			}

			// Token: 0x06001680 RID: 5760 RVA: 0x00041C9C File Offset: 0x0003FE9C
			public int Compare(object item1, object item2)
			{
				if (item1 != null && item2 != null)
				{
					CultureInfoConverter converter = this._converter;
					CultureInfoConverter converter2 = this._converter;
					CultureInfo currentCulture = CultureInfo.CurrentCulture;
				}
				return 1;
			}

			// Token: 0x040011E5 RID: 4581
			private CultureInfoConverter _converter;
		}

		// Token: 0x0200035F RID: 863
		private static class CultureInfoMapper
		{
			// Token: 0x06001681 RID: 5761 RVA: 0x00002050 File Offset: 0x00000250
			private static Dictionary<string, string> CreateMap()
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06001682 RID: 5762 RVA: 0x00041CD4 File Offset: 0x0003FED4
			public static string GetCultureInfoName(string cultureInfoDisplayName)
			{
				if (!true)
				{
				}
				return 1;
			}

			// Token: 0x06001683 RID: 5763 RVA: 0x00041CE8 File Offset: 0x0003FEE8
			// Note: this type is marked as 'beforefieldinit'.
			static CultureInfoMapper()
			{
				Dictionary<string, string> dictionary = CultureInfoConverter.CultureInfoMapper.CreateMap();
			}

			// Token: 0x040011E6 RID: 4582
			private static readonly Dictionary<string, string> s_cultureInfoNameMap;
		}
	}
}
