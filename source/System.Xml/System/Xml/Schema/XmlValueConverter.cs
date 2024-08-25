using System;

namespace System.Xml.Schema
{
	// Token: 0x0200015C RID: 348
	internal abstract class XmlValueConverter
	{
		// Token: 0x06000B20 RID: 2848
		public abstract bool ToBoolean(long value);

		// Token: 0x06000B21 RID: 2849
		public abstract bool ToBoolean(int value);

		// Token: 0x06000B22 RID: 2850
		public abstract bool ToBoolean(double value);

		// Token: 0x06000B23 RID: 2851
		public abstract bool ToBoolean(DateTime value);

		// Token: 0x06000B24 RID: 2852
		public abstract bool ToBoolean(string value);

		// Token: 0x06000B25 RID: 2853
		public abstract bool ToBoolean(object value);

		// Token: 0x06000B26 RID: 2854
		public abstract int ToInt32(bool value);

		// Token: 0x06000B27 RID: 2855
		public abstract int ToInt32(long value);

		// Token: 0x06000B28 RID: 2856
		public abstract int ToInt32(double value);

		// Token: 0x06000B29 RID: 2857
		public abstract int ToInt32(DateTime value);

		// Token: 0x06000B2A RID: 2858
		public abstract int ToInt32(string value);

		// Token: 0x06000B2B RID: 2859
		public abstract int ToInt32(object value);

		// Token: 0x06000B2C RID: 2860
		public abstract long ToInt64(bool value);

		// Token: 0x06000B2D RID: 2861
		public abstract long ToInt64(int value);

		// Token: 0x06000B2E RID: 2862
		public abstract long ToInt64(double value);

		// Token: 0x06000B2F RID: 2863
		public abstract long ToInt64(DateTime value);

		// Token: 0x06000B30 RID: 2864
		public abstract long ToInt64(string value);

		// Token: 0x06000B31 RID: 2865
		public abstract long ToInt64(object value);

		// Token: 0x06000B32 RID: 2866
		public abstract decimal ToDecimal(string value);

		// Token: 0x06000B33 RID: 2867
		public abstract decimal ToDecimal(object value);

		// Token: 0x06000B34 RID: 2868
		public abstract double ToDouble(bool value);

		// Token: 0x06000B35 RID: 2869
		public abstract double ToDouble(int value);

		// Token: 0x06000B36 RID: 2870
		public abstract double ToDouble(long value);

		// Token: 0x06000B37 RID: 2871
		public abstract double ToDouble(DateTime value);

		// Token: 0x06000B38 RID: 2872
		public abstract double ToDouble(string value);

		// Token: 0x06000B39 RID: 2873
		public abstract double ToDouble(object value);

		// Token: 0x06000B3A RID: 2874
		public abstract float ToSingle(double value);

		// Token: 0x06000B3B RID: 2875
		public abstract float ToSingle(string value);

		// Token: 0x06000B3C RID: 2876
		public abstract float ToSingle(object value);

		// Token: 0x06000B3D RID: 2877
		public abstract DateTime ToDateTime(bool value);

		// Token: 0x06000B3E RID: 2878
		public abstract DateTime ToDateTime(int value);

		// Token: 0x06000B3F RID: 2879
		public abstract DateTime ToDateTime(long value);

		// Token: 0x06000B40 RID: 2880
		public abstract DateTime ToDateTime(double value);

		// Token: 0x06000B41 RID: 2881
		public abstract DateTime ToDateTime(DateTimeOffset value);

		// Token: 0x06000B42 RID: 2882
		public abstract DateTime ToDateTime(string value);

		// Token: 0x06000B43 RID: 2883
		public abstract DateTime ToDateTime(object value);

		// Token: 0x06000B44 RID: 2884
		public abstract DateTimeOffset ToDateTimeOffset(DateTime value);

		// Token: 0x06000B45 RID: 2885
		public abstract DateTimeOffset ToDateTimeOffset(string value);

		// Token: 0x06000B46 RID: 2886
		public abstract DateTimeOffset ToDateTimeOffset(object value);

		// Token: 0x06000B47 RID: 2887
		public abstract string ToString(bool value);

		// Token: 0x06000B48 RID: 2888
		public abstract string ToString(int value);

		// Token: 0x06000B49 RID: 2889
		public abstract string ToString(long value);

		// Token: 0x06000B4A RID: 2890
		public abstract string ToString(decimal value);

		// Token: 0x06000B4B RID: 2891
		public abstract string ToString(float value);

		// Token: 0x06000B4C RID: 2892
		public abstract string ToString(double value);

		// Token: 0x06000B4D RID: 2893
		public abstract string ToString(DateTime value);

		// Token: 0x06000B4E RID: 2894
		public abstract string ToString(DateTimeOffset value);

		// Token: 0x06000B4F RID: 2895
		public abstract string ToString(object value);

		// Token: 0x06000B50 RID: 2896
		public abstract string ToString(object value, IXmlNamespaceResolver nsResolver);

		// Token: 0x06000B51 RID: 2897
		public abstract object ChangeType(bool value, Type destinationType);

		// Token: 0x06000B52 RID: 2898
		public abstract object ChangeType(int value, Type destinationType);

		// Token: 0x06000B53 RID: 2899
		public abstract object ChangeType(long value, Type destinationType);

		// Token: 0x06000B54 RID: 2900
		public abstract object ChangeType(decimal value, Type destinationType);

		// Token: 0x06000B55 RID: 2901
		public abstract object ChangeType(double value, Type destinationType);

		// Token: 0x06000B56 RID: 2902
		public abstract object ChangeType(DateTime value, Type destinationType);

		// Token: 0x06000B57 RID: 2903
		public abstract object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver);

		// Token: 0x06000B58 RID: 2904
		public abstract object ChangeType(object value, Type destinationType);

		// Token: 0x06000B59 RID: 2905
		public abstract object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver);

		// Token: 0x06000B5A RID: 2906 RVA: 0x0001E9EC File Offset: 0x0001CBEC
		protected XmlValueConverter()
		{
		}
	}
}
