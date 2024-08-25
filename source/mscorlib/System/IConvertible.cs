using System;

namespace System
{
	// Token: 0x020000C6 RID: 198
	[CLSCompliant(false)]
	public interface IConvertible
	{
		// Token: 0x0600075A RID: 1882
		TypeCode GetTypeCode();

		// Token: 0x0600075B RID: 1883
		bool ToBoolean(IFormatProvider provider);

		// Token: 0x0600075C RID: 1884
		char ToChar(IFormatProvider provider);

		// Token: 0x0600075D RID: 1885
		sbyte ToSByte(IFormatProvider provider);

		// Token: 0x0600075E RID: 1886
		byte ToByte(IFormatProvider provider);

		// Token: 0x0600075F RID: 1887
		short ToInt16(IFormatProvider provider);

		// Token: 0x06000760 RID: 1888
		ushort ToUInt16(IFormatProvider provider);

		// Token: 0x06000761 RID: 1889
		int ToInt32(IFormatProvider provider);

		// Token: 0x06000762 RID: 1890
		uint ToUInt32(IFormatProvider provider);

		// Token: 0x06000763 RID: 1891
		long ToInt64(IFormatProvider provider);

		// Token: 0x06000764 RID: 1892
		ulong ToUInt64(IFormatProvider provider);

		// Token: 0x06000765 RID: 1893
		float ToSingle(IFormatProvider provider);

		// Token: 0x06000766 RID: 1894
		double ToDouble(IFormatProvider provider);

		// Token: 0x06000767 RID: 1895
		decimal ToDecimal(IFormatProvider provider);

		// Token: 0x06000768 RID: 1896
		DateTime ToDateTime(IFormatProvider provider);

		// Token: 0x06000769 RID: 1897
		string ToString(IFormatProvider provider);

		// Token: 0x0600076A RID: 1898
		object ToType(Type conversionType, IFormatProvider provider);
	}
}
